// SPDX-FileCopyrightText: 2011-2018 pancake <pancake@nopcode.org>
// SPDX-License-Identifier: MIT

#include <stdio.h>
#include <fcntl.h>
#include <errno.h>
#include <string.h>
#include <stdlib.h>
#include <sys/stat.h>
#include <rz_util/rz_mem.h>
#include <rz_util/rz_assert.h>
#include "sdb.h"
#include "sdb_private.h"

static inline SdbKv *next_kv(HtSS *ht, SdbKv *kv) {
	return (SdbKv *)((char *)kv + ht->opt.elem_size);
}

#define BUCKET_FOREACH(ht, bt, j, kv) \
	for ((j) = 0, (kv) = (SdbKv *)(bt)->arr; j < (bt)->count; (j)++, (kv) = next_kv(ht, kv))

#define BUCKET_FOREACH_SAFE(ht, bt, j, count, kv) \
	if ((bt)->arr) \
		for ((j) = 0, (kv) = (SdbKv *)(bt)->arr, (count) = (ht)->count; \
			(j) < (bt)->count; \
			(j) = (count) == (ht)->count ? j + 1 : j, (kv) = (count) == (ht)->count ? next_kv(ht, kv) : kv, (count) = (ht)->count)

// TODO: use mmap instead of read.. much faster!
RZ_API Sdb *sdb_new0(void) {
	return sdb_new(NULL, NULL, 0);
}

RZ_API Sdb *sdb_new(const char *path, const char *name, int lock) {
	Sdb *s = RZ_NEW0(Sdb);
	if (!s) {
		return NULL;
	}
	s->db.fd = -1;
	s->fd = -1;
	s->refs = 1;
	if (path && !*path) {
		path = NULL;
	}
	if (name && *name && strcmp(name, "-")) {
		if (path && *path) {
			int plen = strlen(path);
			int nlen = strlen(name);
			s->dir = malloc(plen + nlen + 2);
			if (!s->dir) {
				free(s);
				return NULL;
			}
			memcpy(s->dir, path, plen);
			s->dir[plen] = '/';
			memcpy(s->dir + plen + 1, name, nlen + 1);
			s->path = strdup(path);
		} else {
			s->dir = strdup(name);
		}
		switch (lock) {
		case 1:
			if (!sdb_lock(sdb_lock_file(s->dir))) {
				goto fail;
			}
			break;
		case 2:
			if (!sdb_lock_wait(sdb_lock_file(s->dir))) {
				goto fail;
			}
			break;
		}
		if (sdb_open(s, s->dir) == -1) {
			// TODO: must fail if we cant open for write in sync
		}
		s->name = strdup(name);
	} else {
		s->fd = -1;
	}
	s->fdump = -1;
	s->depth = 0;
	s->ndump = NULL;
	s->ns = rz_list_new(); // TODO: should be NULL
	if (!s->ns) {
		goto fail;
	}
	s->ht = sdb_ht_new();
	s->lock = lock;
	// if open fails ignore
	cdb_init(&s->db, s->fd);
	return s;
fail:
	if (s->fd != -1) {
		close(s->fd);
		s->fd = -1;
	}
	free(s->dir);
	free(s->name);
	free(s->path);
	free(s);
	return NULL;
}

// XXX: this is wrong. stuff not stored in memory is lost
RZ_API void sdb_file(Sdb *s, const char *dir) {
	if (s->lock) {
		sdb_unlock(sdb_lock_file(s->dir));
	}
	free(s->dir);
	s->dir = (dir && *dir) ? strdup(dir) : NULL;
	if (s->lock) {
		sdb_lock(sdb_lock_file(s->dir));
	}
}

static bool sdb_merge_cb(void *user, const SdbKv *kv) {
	sdb_set(user, sdbkv_key(kv), sdbkv_value(kv));
	return true;
}

RZ_API bool sdb_merge(Sdb *d, Sdb *s) {
	return sdb_foreach(s, sdb_merge_cb, d);
}

RZ_API bool sdb_isempty(Sdb *s) {
	if (s) {
		if (s->db.fd != -1) {
			SdbKv it = { 0 };
			sdb_dump_begin(s);
			while (sdb_dump_next(s, &it)) {
				return false;
			}
		}
		if (s->ht && s->ht->count > 0) {
			return false;
		}
	}
	return true;
}

RZ_API int sdb_count(Sdb *s) {
	int count = 0;
	if (s) {
		if (s->db.fd != -1) {
			SdbKv it = { 0 };
			sdb_dump_begin(s);
			while (sdb_dump_next(s, &it)) {
				count++;
			}
		}
		if (s->ht) {
			count += s->ht->count;
		}
	}
	return count;
}

static void sdb_fini(Sdb *s, int donull) {
	if (!s) {
		return;
	}
	cdb_free(&s->db);
	if (s->lock) {
		sdb_unlock(sdb_lock_file(s->dir));
	}
	sdb_ns_free_all(s);
	s->refs = 0;
	free(s->name);
	free(s->path);
	rz_list_free(s->ns);
	sdb_ht_free(s->ht);
	if (s->fd != -1) {
		close(s->fd);
		s->fd = -1;
	}
	free(s->ndump);
	free(s->dir);
	if (donull) {
		memset(s, 0, sizeof(Sdb));
	}
}

RZ_API bool sdb_free(Sdb *s) {
	if (s && s->ht && s->refs) {
		s->refs--;
		if (s->refs < 1) {
			s->refs = 0;
			sdb_fini(s, 0);
			s->ht = NULL;
			free(s);
			return true;
		}
	}
	return false;
}

RZ_API const char *sdb_const_get_len(Sdb *s, const char *key, int *vlen) {
	ut32 pos, len;
	bool found;

	if (vlen) {
		*vlen = 0;
	}
	if (!s || !key) {
		return NULL;
	}
	// TODO: optimize, iterate once
	size_t keylen = strlen(key);

	/* search in memory */
	SdbKv *kv = (SdbKv *)sdb_ht_find_kvp(s->ht, key, &found);
	if (found) {
		if (!sdbkv_value(kv) || !*sdbkv_value(kv)) {
			return NULL;
		}
		if (vlen) {
			*vlen = sdbkv_value_len(kv);
		}
		return sdbkv_value(kv);
	}
	/* search in disk */
	if (s->fd == -1) {
		return NULL;
	}
	(void)cdb_findstart(&s->db);
	if (cdb_findnext(&s->db, s->ht->opt.hashfn(key), key, keylen) < 1) {
		return NULL;
	}
	len = cdb_datalen(&s->db);
	if (len < SDB_CDB_MIN_VALUE || len >= SDB_CDB_MAX_VALUE) {
		return NULL;
	}
	if (vlen) {
		*vlen = len;
	}
	pos = cdb_datapos(&s->db);
	return s->db.map + pos;
}

RZ_API const char *sdb_const_get(Sdb *s, const char *key) {
	return sdb_const_get_len(s, key, NULL);
}

// TODO: add sdb_getf?

RZ_API char *sdb_get_len(Sdb *s, const char *key, int *vlen) {
	const char *value = sdb_const_get_len(s, key, vlen);
	return value ? strdup(value) : NULL;
}

RZ_API char *sdb_get(Sdb *s, const char *key) {
	return sdb_get_len(s, key, NULL);
}

RZ_API int sdb_unset(Sdb *s, const char *key) {
	return key ? sdb_set(s, key, "") : 0;
}

/* remove from memory */
RZ_API bool sdb_remove(Sdb *s, const char *key) {
	return sdb_ht_delete(s->ht, key);
}

// alias for '-key=str'.. '+key=str' concats
RZ_API bool sdb_uncat(Sdb *s, const char *key, const char *value) {
	// remove 'value' from current key value.
	int vlen = 0, valen;
	char *p, *v = sdb_get_len(s, key, &vlen);
	int mod = 0;
	if (!v || !key || !value) {
		free(v);
		return 0;
	}
	valen = strlen(value);
	if (valen > 0) {
		while ((p = strstr(v, value))) {
			memmove(p, p + valen, strlen(p + valen) + 1);
			mod = 1;
		}
	}
	if (mod) {
		sdb_set_owned(s, key, v);
	} else {
		free(v);
	}
	return 0;
}

RZ_API bool sdb_concat(Sdb *s, const char *key, const char *value) {
	int kl, vl;
	const char *p;
	char *o;
	if (!s || !key || !*key || !value || !*value) {
		return 0;
	}
	p = sdb_const_get_len(s, key, &kl);
	if (!p) {
		return sdb_set(s, key, value);
	}
	vl = strlen(value);
	o = malloc(kl + vl + 1);
	if (o) {
		memcpy(o, p, kl);
		memcpy(o + kl, value, vl + 1);
		return sdb_set_owned(s, key, o);
	}
	return false;
}

// set if not defined
RZ_API bool sdb_add(Sdb *s, const char *key, const char *val) {
	if (sdb_exists(s, key)) {
		return false;
	}
	return sdb_set(s, key, val);
}

RZ_API bool sdb_exists(Sdb *s, const char *key) {
	ut32 pos;
	char ch;
	bool found;
	int klen = strlen(key) + 1;
	if (!s) {
		return false;
	}
	SdbKv *kv = (SdbKv *)sdb_ht_find_kvp(s->ht, key, &found);
	if (found && kv) {
		const char *v = sdbkv_value(kv);
		return v && *v;
	}
	if (s->fd == -1) {
		return false;
	}
	(void)cdb_findstart(&s->db);
	if (cdb_findnext(&s->db, sdb_hash(key), key, klen)) {
		pos = cdb_datapos(&s->db);
		cdb_read(&s->db, &ch, 1, pos);
		return ch != 0;
	}
	return false;
}

RZ_API int sdb_open(Sdb *s, const char *file) {
	struct stat st;
	if (!s) {
		return -1;
	}
	if (file) {
		if (s->fd != -1) {
			close(s->fd);
			s->fd = -1;
		}
		s->fd = open(file, O_RDONLY | O_BINARY);
		if (file != s->dir) {
			free(s->dir);
			s->dir = strdup(file);
			s->path = NULL; // TODO: path is important
		}
	}
	if (s->fd != -1 && fstat(s->fd, &st) != -1) {
		if ((S_IFREG & st.st_mode) != S_IFREG) {
			eprintf("Database must be a file\n");
			close(s->fd);
			s->fd = -1;
			return -1;
		}
	}
	if (s->fd != -1) {
		cdb_init(&s->db, s->fd);
	}
	return s->fd;
}

RZ_API void sdb_close(Sdb *s) {
	if (s) {
		if (s->fd != -1) {
			if (s->db.fd != -1 && s->db.fd == s->fd) {
				/* close db fd as well */
				s->db.fd = -1;
			}
			close(s->fd);
			s->fd = -1;
		}
		if (s->dir) {
			free(s->dir);
			s->dir = NULL;
		}
	}
}

RZ_API void sdb_reset(Sdb *s) {
	if (!s) {
		return;
	}
	/* ignore disk cache, file is not removed, but we will ignore
	 * its values when syncing again */
	sdb_close(s);
	/* empty memory hashtable */
	sdb_ht_free(s->ht);
	s->ht = sdb_ht_new();
}

static char lastChar(const char *str) {
	int len = strlen(str);
	return str[(len > 0) ? len - 1 : 0];
}

static bool match(const char *str, const char *expr) {
	bool startsWith = *expr == '^';
	bool endsWith = lastChar(expr) == '$';
	if (startsWith && endsWith) {
		return strlen(str) == strlen(expr) - 2 &&
			!strncmp(str, expr + 1, strlen(expr) - 2);
	}
	if (startsWith) {
		return !strncmp(str, expr + 1, strlen(expr) - 1);
	}
	if (endsWith) {
		int alen = strlen(str);
		int blen = strlen(expr) - 1;
		if (alen <= blen) {
			return false;
		}
		const char *a = str + strlen(str) - blen;
		return (!strncmp(a, expr, blen));
	}
	return strstr(str, expr);
}

RZ_API bool sdbkv_match(const SdbKv *kv, const char *expr) {
	// TODO: add syntax to negate condition
	// TODO: add syntax to OR k/v instead of AND
	// [^]str[$]=[^]str[$]
	const char *eq = strchr(expr, '=');
	if (eq) {
		char *e = strdup(expr);
		char *ep = e + (eq - expr);
		*ep++ = 0;
		bool res = !*e || match(sdbkv_key(kv), e);
		bool res2 = !*ep || match(sdbkv_value(kv), ep);
		free(e);
		return res && res2;
	}
	return match(sdbkv_key(kv), expr);
}

RZ_API SdbKv *sdbkv_new(const char *k, const char *v) {
	return sdbkv_new2(k, strlen(k), v, strlen(v));
}

RZ_API SdbKv *sdbkv_new2(const char *k, int kl, const char *v, int vl) {
	SdbKv *kv;
	if (!v) {
		vl = 0;
	}
	kv = RZ_NEW0(SdbKv);
	kv->base.key_len = kl;
	kv->base.key = malloc(kv->base.key_len + 1);
	if (!kv->base.key) {
		free(kv);
		return NULL;
	}
	memcpy(kv->base.key, k, kv->base.key_len + 1);
	kv->base.value_len = vl;
	if (vl) {
		kv->base.value = malloc(vl + 1);
		if (!kv->base.value) {
			free(kv->base.key);
			free(kv);
			return NULL;
		}
		memcpy(kv->base.value, v, vl + 1);
	} else {
		kv->base.value = NULL;
		kv->base.value_len = 0;
	}
	return kv;
}

RZ_API void sdbkv_free(RZ_NULLABLE SdbKv *kv) {
	if (!kv) {
		return;
	}
	free(kv->base.key);
	free(kv->base.value);
	free(kv);
}

/**
 * Create a duplicate of SdbKv
 */
static inline RZ_OWN SdbKv *sdbkv_dup(RZ_NONNULL const SdbKv *kv) {
	return sdbkv_new2(sdbkv_key(kv), sdbkv_key_len(kv), sdbkv_value(kv), sdbkv_value_len(kv));
}

/**
 * \brief Create a duplicate of SdbKv value string
 */
RZ_API RZ_OWN char *sdbkv_dup_value(RZ_NONNULL const SdbKv *kv) {
	rz_return_val_if_fail(kv, NULL);
	return rz_mem_dup(sdbkv_value(kv), sdbkv_value_len(kv) + 1);
}

static bool sdb_set_internal(Sdb *s, const char *key, char *val, int owned) {
	ut32 vlen, klen;
	SdbKv *kv;
	bool found;
	if (!s || !key) {
		return false;
	}
	if (!val) {
		if (owned) {
			val = strdup("");
		} else {
			val = "";
		}
	}
	// XXX strlen computed twice.. because of check_*()
	klen = strlen(key);
	vlen = strlen(val);
	cdb_findstart(&s->db);
	kv = sdb_ht_find_kvp(s->ht, key, &found);
	if (found && sdbkv_value(kv)) {
		if (cdb_findnext(&s->db, sdb_hash(key), key, klen)) {
			if (vlen == sdbkv_value_len(kv) && !strcmp(sdbkv_value(kv), val)) {
				return true;
			}
			if (owned) {
				kv->base.value_len = vlen;
				free(kv->base.value);
				kv->base.value = val; // owned
			} else {
				if ((ut32)vlen > kv->base.value_len) {
					free(kv->base.value);
					kv->base.value = malloc(vlen + 1);
				}
				memcpy(kv->base.value, val, vlen + 1);
				kv->base.value_len = vlen;
			}
		} else {
			sdb_ht_delete(s->ht, key);
		}
		return true;
	}
	// empty values are also stored
	// TODO store only the ones that are in the CDB
	if (owned) {
		kv = sdbkv_new2(key, klen, NULL, 0);
		if (kv) {
			kv->base.value = val;
			kv->base.value_len = vlen;
		}
	} else {
		kv = sdbkv_new2(key, klen, val, vlen);
	}
	if (kv) {
		sdb_ht_insert_kvp(s->ht, kv, true /*update*/);
		free(kv);
		return true;
	}
	return false;
}

RZ_API bool sdb_set_owned(Sdb *s, const char *key, char *val) {
	return sdb_set_internal(s, key, val, 1);
}

RZ_API bool sdb_set(Sdb *s, const char *key, const char *val) {
	return sdb_set_internal(s, key, (char *)val, 0);
}

static bool get_items_cb(void *user, const SdbKv *kv) {
	RzPVector *vec = (RzPVector *)user;
	SdbKv *dup = sdbkv_dup(kv);
	if (!dup) {
		return false;
	}
	if (!rz_pvector_push(vec, dup)) {
		sdbkv_free(dup);
		return false;
	}
	return true;
}

static int __cmp_asc(const void *a, const void *b, RZ_UNUSED void *user) {
	const SdbKv *ka = a, *kb = b;
	return strcmp(sdbkv_key(ka), sdbkv_key(kb));
}

/**
 * \brief Get all key-value pairs in DB
 * \param s DB
 * \param sorted If set to true sort the resulting vector by key in lexicographic order
 */
RZ_API RZ_OWN RzPVector /*<SdbKv *>*/ *sdb_get_items(RZ_NONNULL Sdb *s, bool sorted) {
	rz_return_val_if_fail(s, NULL);

	RzPVector *vec = rz_pvector_new((RzPVectorFree)sdbkv_free);
	if (!vec) {
		return NULL;
	}
	sdb_foreach(s, get_items_cb, vec);
	if (sorted) {
		rz_pvector_sort(vec, __cmp_asc, NULL);
	}
	return vec;
}

struct get_items_filter_ctx {
	SdbForeachCallback filter;
	RzPVector /*<SdbKv *>*/ *vec;
	void *user;
};

static bool get_items_filter_cb(void *user, const SdbKv *kv) {
	struct get_items_filter_ctx *ctx = (struct get_items_filter_ctx *)user;

	if (!ctx->filter(ctx->user, kv)) {
		return true;
	}
	SdbKv *dup = sdbkv_dup(kv);
	if (!dup) {
		return false;
	}
	if (!rz_pvector_push(ctx->vec, dup)) {
		sdbkv_free(dup);
		return false;
	}
	return true;
}

/**
 * \brief Get key-value pairs in DB matching filter \p filter
 * \param s DB
 * \param filter Filter callback, a key-value pair is skipped if callback return false
 * \param user User data which is passed to filter callback \p cb
 * \param sorted If set to true sort the resulting vector by key in lexicographic order
 */
RZ_API RZ_OWN RzPVector /*<SdbKv *>*/ *sdb_get_items_filter(RZ_NONNULL Sdb *s, RZ_NONNULL SdbForeachCallback filter, RZ_NULLABLE void *user, bool sorted) {
	rz_return_val_if_fail(s && filter, NULL);

	RzPVector *vec = rz_pvector_new((RzPVectorFree)sdbkv_free);
	if (!vec) {
		return NULL;
	}
	struct get_items_filter_ctx ctx = {
		.filter = filter,
		.vec = vec,
		.user = user,
	};
	sdb_foreach(s, get_items_filter_cb, &ctx);
	if (sorted) {
		rz_pvector_sort(vec, __cmp_asc, NULL);
	}
	return vec;
}

struct get_items_match_ctx {
	const char *expr;
	RzPVector /*<SdbKv *>*/ *vec;
};

static bool get_items_match_cb(void *user, const SdbKv *kv) {
	struct get_items_match_ctx *ctx = (struct get_items_match_ctx *)user;
	if (sdbkv_match(kv, ctx->expr)) {
		return true;
	}
	SdbKv *dup = sdbkv_dup(kv);
	if (!dup) {
		return false;
	}
	if (!rz_pvector_push(ctx->vec, dup)) {
		sdbkv_free(dup);
		return false;
	}
	return true;
}

/**
 * \brief Get key-value pairs in DB with keys matching expression \p expr
 * \param s DB
 * \param expr Expression string
 * \param sorted If set to true sort the resulting vector by key in lexicographic order
 */
RZ_API RZ_OWN RzPVector /*<SdbKv *>*/ *sdb_get_items_match(RZ_NONNULL Sdb *s, RZ_NONNULL const char *expr, bool sorted) {
	rz_return_val_if_fail(s && expr, NULL);

	RzPVector *vec = rz_pvector_new((RzPVectorFree)sdbkv_free);
	if (!vec) {
		return NULL;
	}
	struct get_items_match_ctx ctx = { expr, vec };
	sdb_foreach(s, get_items_match_cb, &ctx);
	if (sorted) {
		rz_pvector_sort(vec, __cmp_asc, NULL);
	}
	return vec;
}

static bool sdb_foreach_end(Sdb *s, bool result) {
	s->depth--;
	return result;
}

/**
 * Apply callback \p cb to every key-value pair in cdb file.
 * Keys which are presented in HT are skipped.
 */
static bool sdb_foreach_cdb(Sdb *s, SdbForeachCallback cb, void *user) {
	SdbKv it = { 0 };
	sdb_dump_begin(s);
	while (sdb_dump_next(s, &it)) {
		if (sdb_ht_find_kvp(s->ht, sdbkv_key(&it), NULL)) {
			continue;
		}
		if (!cb(user, &it)) {
			return false;
		}
	}
	return true;
}

/**
 * \brief Apply callback \p cb to every key-value pair in DB \p s
 * \param s DB
 * \param cb Callback, iteration is stopped if callback return false
 * \param user User data which is passed to callback \p cb
 */
RZ_API bool sdb_foreach(RZ_NONNULL Sdb *s, RZ_NONNULL SdbForeachCallback cb, RZ_NULLABLE void *user) {
	rz_return_val_if_fail(s && cb, false);

	s->depth++;
	bool result = sdb_foreach_cdb(s, cb, user);
	if (!result) {
		return sdb_foreach_end(s, false);
	}

	for (ut32 i = 0; i < s->ht->size; ++i) {
		HtSSBucket *bt = &s->ht->table[i];
		SdbKv *kv;
		ut32 j, count;

		BUCKET_FOREACH_SAFE(s->ht, bt, j, count, kv) {
			if (kv && sdbkv_value(kv) && *sdbkv_value(kv)) {
				if (!cb(user, kv)) {
					return sdb_foreach_end(s, false);
				}
			}
		}
	}
	return sdb_foreach_end(s, true);
}

static bool _insert_into_disk(void *user, const SdbKv *kv) {
	Sdb *s = (Sdb *)user;
	if (s) {
		sdb_disk_insert(s, sdbkv_key(kv), sdbkv_value(kv));
		return true;
	}
	return false;
}

RZ_API bool sdb_sync(Sdb *s) {
	bool result;
	ut32 i;

	if (!s || !sdb_disk_create(s)) {
		return false;
	}
	result = sdb_foreach_cdb(s, _insert_into_disk, s);
	if (!result) {
		return false;
	}

	/* append new keyvalues */
	for (i = 0; i < s->ht->size; ++i) {
		HtSSBucket *bt = &s->ht->table[i];
		SdbKv *kv;
		ut32 j, count;

		BUCKET_FOREACH_SAFE(s->ht, bt, j, count, kv) {
			if (sdbkv_key(kv) && sdbkv_value(kv) && *sdbkv_value(kv)) {
				if (sdb_disk_insert(s, sdbkv_key(kv), sdbkv_value(kv))) {
					sdb_remove(s, sdbkv_key(kv));
				}
			}
		}
	}
	sdb_disk_finish(s);
	// TODO: sdb_reset memory state?
	return true;
}

RZ_API void sdb_dump_begin(RZ_NONNULL Sdb *s) {
	rz_return_if_fail(s);

	s->pos = 0;
	s->dump_end_pos = 0;
	if (s->fd == -1) {
		return;
	}
	ut8 buf[4];
	if (!cdb_read(&s->db, (char *)buf, 4, 0)) {
		return;
	}
	s->dump_end_pos = rz_read_le32(buf);
	s->pos = sizeof(((struct cdb_make *)0)->final);
	seek_set(s->fd, s->pos);
}

RZ_API bool sdb_stats(Sdb *s, ut32 *disk, ut32 *mem) {
	if (!s) {
		return false;
	}
	if (disk) {
		ut32 count = 0;
		if (s->fd != -1) {
			SdbKv it = { 0 };
			sdb_dump_begin(s);
			while (sdb_dump_next(s, &it)) {
				count++;
			}
		}
		*disk = count;
	}
	if (mem) {
		*mem = s->ht->count;
	}
	return disk || mem;
}

/**
 * \brief Get the next key-value pair
 *
 * Modifying of key/value strings is forbidden.
 */
RZ_API bool sdb_dump_next(RZ_NONNULL Sdb *s, RZ_OUT RZ_NONNULL SdbKv *kv) {
	rz_return_val_if_fail(s && kv, false);

	if (!s->db.map || s->pos >= s->dump_end_pos) {
		return false;
	}
	// klen/vlen include trailing NUL
	ut32 klen, vlen;
	if (!cdb_getkvlen(&s->db, &klen, &vlen, s->pos)) {
		return false;
	}
	if (klen < SDB_CDB_MIN_KEY || vlen < SDB_CDB_MIN_VALUE) {
		return false;
	}
	s->pos += 4;

	char *key = s->db.map + s->pos;
	s->pos += klen;
	if (s->pos > s->dump_end_pos || key[klen - 1] != '\0') {
		rz_return_val_if_reached(false);
	}

	char *value = s->db.map + s->pos;
	s->pos += vlen;
	if (s->pos > s->dump_end_pos || value[vlen - 1] != '\0') {
		rz_return_val_if_reached(false);
	}

	kv->base.key = key;
	kv->base.key_len = klen - 1;
	kv->base.value = value;
	kv->base.value_len = vlen - 1;
	return true;
}

RZ_API void sdb_config(Sdb *s, int options) {
	s->options = options;
	if (options & SDB_OPTION_SYNC) {
		// sync on every query
	}
	if (options & SDB_OPTION_NOSTAMP) {
		// sync on every query
	}
	if (options & SDB_OPTION_FS) {
		// have access to fs (handle '.' or not in query)
	}
}

RZ_API bool sdb_unlink(Sdb *s) {
	sdb_fini(s, 1);
	return sdb_disk_unlink(s);
}

RZ_API void sdb_drain(Sdb *s, Sdb *f) {
	if (s && f) {
		f->refs = s->refs;
		sdb_fini(s, 1);
		*s = *f;
		free(f);
	}
}

static bool copy_foreach_cb(void *user, const SdbKv *kv) {
	Sdb *dst = user;
	sdb_set(dst, sdbkv_key(kv), sdbkv_value(kv));
	return true;
}

RZ_API void sdb_copy(Sdb *src, Sdb *dst) {
	sdb_foreach(src, copy_foreach_cb, dst);
	RzListIter *it;
	SdbNs *ns;
	rz_list_foreach (src->ns, it, ns) {
		sdb_copy(ns->sdb, sdb_ns(dst, ns->name, true));
	}
}

typedef struct {
	Sdb *sdb;
	const char *key;
} UnsetCallbackData;

static bool unset_cb(void *user, const SdbKv *kv) {
	UnsetCallbackData *ucd = user;
	if (sdb_match(sdbkv_key(kv), ucd->key)) {
		sdb_unset(ucd->sdb, sdbkv_key(kv));
	}
	return true;
}

RZ_API int sdb_unset_like(Sdb *s, const char *k) {
	UnsetCallbackData ucd = { s, k };
	return sdb_foreach(s, unset_cb, &ucd);
}
