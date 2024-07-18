using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Craxs_Rat
{
	// Token: 0x020000B2 RID: 178
	[DesignerGenerated]
	public partial class DialogPloice : Form
	{
		// Token: 0x06000BB2 RID: 2994 RVA: 0x0007BDF8 File Offset: 0x00079FF8
		public DialogPloice()
		{
			base.Load += this.DialogPloice_Load;
			this.string_0 = "انا قرأت ما موجود اعلاه , وموافق على الشروط";
			this.string_1 = "I read all text above, And Accepted All";
			this.bool_0 = false;
			this.InitializeComponent();
		}

		// Token: 0x17000353 RID: 851
		// (get) Token: 0x06000BB5 RID: 2997 RVA: 0x000063BD File Offset: 0x000045BD
		// (set) Token: 0x06000BB6 RID: 2998 RVA: 0x0007C3BC File Offset: 0x0007A5BC
		internal virtual TableLayoutPanel TableLayoutPanel1 { get; set; }

		// Token: 0x17000354 RID: 852
		// (get) Token: 0x06000BB7 RID: 2999 RVA: 0x000063C5 File Offset: 0x000045C5
		// (set) Token: 0x06000BB8 RID: 3000 RVA: 0x0007C3D0 File Offset: 0x0007A5D0
		internal virtual Button OK_Button
		{
			[CompilerGenerated]
			get
			{
				return this._OK_Button;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.OK_Button_Click);
				Button ok_Button = this._OK_Button;
				if (ok_Button != null)
				{
					ok_Button.Click -= value2;
				}
				this._OK_Button = value;
				ok_Button = this._OK_Button;
				if (ok_Button != null)
				{
					ok_Button.Click += value2;
				}
			}
		}

		// Token: 0x17000355 RID: 853
		// (get) Token: 0x06000BB9 RID: 3001 RVA: 0x000063CD File Offset: 0x000045CD
		// (set) Token: 0x06000BBA RID: 3002 RVA: 0x0007C414 File Offset: 0x0007A614
		internal virtual Button Cancel_Button
		{
			[CompilerGenerated]
			get
			{
				return this._Cancel_Button;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.Cancel_Button_Click);
				Button cancel_Button = this._Cancel_Button;
				if (cancel_Button != null)
				{
					cancel_Button.Click -= value2;
				}
				this._Cancel_Button = value;
				cancel_Button = this._Cancel_Button;
				if (cancel_Button != null)
				{
					cancel_Button.Click += value2;
				}
			}
		}

		// Token: 0x17000356 RID: 854
		// (get) Token: 0x06000BBB RID: 3003 RVA: 0x000063D5 File Offset: 0x000045D5
		// (set) Token: 0x06000BBC RID: 3004 RVA: 0x0007C458 File Offset: 0x0007A658
		internal virtual TextBox MainText { get; set; }

		// Token: 0x17000357 RID: 855
		// (get) Token: 0x06000BBD RID: 3005 RVA: 0x000063DD File Offset: 0x000045DD
		// (set) Token: 0x06000BBE RID: 3006 RVA: 0x0007C46C File Offset: 0x0007A66C
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

		// Token: 0x17000358 RID: 856
		// (get) Token: 0x06000BBF RID: 3007 RVA: 0x000063E5 File Offset: 0x000045E5
		// (set) Token: 0x06000BC0 RID: 3008 RVA: 0x0007C4B0 File Offset: 0x0007A6B0
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

		// Token: 0x17000359 RID: 857
		// (get) Token: 0x06000BC1 RID: 3009 RVA: 0x000063ED File Offset: 0x000045ED
		// (set) Token: 0x06000BC2 RID: 3010 RVA: 0x0007C4F4 File Offset: 0x0007A6F4
		internal virtual CheckBox Acccheck { get; set; }

		// Token: 0x1700035A RID: 858
		// (get) Token: 0x06000BC3 RID: 3011 RVA: 0x000063F5 File Offset: 0x000045F5
		// (set) Token: 0x06000BC4 RID: 3012 RVA: 0x0007C508 File Offset: 0x0007A708
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

		// Token: 0x06000BC5 RID: 3013 RVA: 0x0007C54C File Offset: 0x0007A74C
		private void OK_Button_Click(object sender, EventArgs e)
		{
			if (this.Acccheck.Checked)
			{
				base.DialogResult = DialogResult.OK;
				base.Close();
			}
			else if (!this.bool_0)
			{
				Interaction.MsgBox("Accepte Privacy Policy First!", MsgBoxStyle.OkOnly, null);
			}
			else
			{
				Interaction.MsgBox("قم بالموافقة على الشروط اولا!", MsgBoxStyle.OkOnly, null);
			}
		}

		// Token: 0x06000BC6 RID: 3014 RVA: 0x0001D5C0 File Offset: 0x0001B7C0
		private void Cancel_Button_Click(object sender, EventArgs e)
		{
			base.DialogResult = DialogResult.Cancel;
			base.Close();
		}

		// Token: 0x06000BC7 RID: 3015 RVA: 0x0007C59C File Offset: 0x0007A79C
		private void DialogPloice_Load(object sender, EventArgs e)
		{
			this.dateTime_0 = DateAndTime.Now.AddSeconds(15.0);
			this.Timer1.Start();
			this.OK_Button.Enabled = false;
			this.Cancel_Button.Enabled = false;
		}

		// Token: 0x06000BC8 RID: 3016 RVA: 0x0007C5E8 File Offset: 0x0007A7E8
		private void Button2_Click(object sender, EventArgs e)
		{
			this.bool_0 = true;
			this.MainText.Text = "";
			this.Acccheck.Text = this.string_0;
			this.OK_Button.Text = "موافق";
			this.Cancel_Button.Text = "كلا";
		}

		// Token: 0x06000BC9 RID: 3017 RVA: 0x0007C640 File Offset: 0x0007A840
		private void Button1_Click(object sender, EventArgs e)
		{
			this.bool_0 = false;
			this.MainText.Text = "";
			this.Acccheck.Text = this.string_1;
			this.OK_Button.Text = "OK";
			this.Cancel_Button.Text = "Cancel";
		}

		// Token: 0x06000BCA RID: 3018 RVA: 0x0007C698 File Offset: 0x0007A898
		private void Timer1_Tick(object sender, EventArgs e)
		{
			if (DateTime.Compare(this.dateTime_0, DateAndTime.Now) >= 0)
			{
				this.Text = " Privacy Policy & Terms of Service - " + (checked(this.dateTime_0.Second - DateAndTime.Now.Second)).ToString();
			}
			else
			{
				this.OK_Button.Enabled = true;
				this.Cancel_Button.Enabled = true;
				this.Text = " Privacy Policy & Terms of Service";
				this.Timer1.Stop();
			}
		}

		// Token: 0x04000686 RID: 1670
		private string string_0;

		// Token: 0x04000687 RID: 1671
		private string string_1;

		// Token: 0x04000688 RID: 1672
		private bool bool_0;

		// Token: 0x04000689 RID: 1673
		private DateTime dateTime_0;
	}
}
