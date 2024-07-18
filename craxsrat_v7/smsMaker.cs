using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using DrakeUI.Framework;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Craxs_Rat
{
	// Token: 0x02000032 RID: 50
	[DesignerGenerated]
	public partial class smsMaker : Form
	{
		// Token: 0x06000388 RID: 904 RVA: 0x0001F760 File Offset: 0x0001D960
		public smsMaker()
		{
			base.Load += this.smsMaker_Load;
			this.InitializeComponent();
		}

		// Token: 0x17000144 RID: 324
		// (get) Token: 0x0600038B RID: 907 RVA: 0x000027C7 File Offset: 0x000009C7
		// (set) Token: 0x0600038C RID: 908 RVA: 0x000205D0 File Offset: 0x0001E7D0
		internal virtual DrakeUITextBox phonetext
		{
			[CompilerGenerated]
			get
			{
				return this._phonetext;
			}
			[CompilerGenerated]
			set
			{
				KeyPressEventHandler value2 = new KeyPressEventHandler(this.phonetext_KeyPress);
				DrakeUITextBox phonetext = this._phonetext;
				if (phonetext != null)
				{
					phonetext.KeyPress -= value2;
				}
				this._phonetext = value;
				phonetext = this._phonetext;
				if (phonetext != null)
				{
					phonetext.KeyPress += value2;
				}
			}
		}

		// Token: 0x17000145 RID: 325
		// (get) Token: 0x0600038D RID: 909 RVA: 0x000027CF File Offset: 0x000009CF
		// (set) Token: 0x0600038E RID: 910 RVA: 0x00020614 File Offset: 0x0001E814
		internal virtual DrakeUITextBox msgtext { get; set; }

		// Token: 0x17000146 RID: 326
		// (get) Token: 0x0600038F RID: 911 RVA: 0x000027D7 File Offset: 0x000009D7
		// (set) Token: 0x06000390 RID: 912 RVA: 0x00020628 File Offset: 0x0001E828
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

		// Token: 0x17000147 RID: 327
		// (get) Token: 0x06000391 RID: 913 RVA: 0x000027DF File Offset: 0x000009DF
		// (set) Token: 0x06000392 RID: 914 RVA: 0x0002066C File Offset: 0x0001E86C
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

		// Token: 0x17000148 RID: 328
		// (get) Token: 0x06000393 RID: 915 RVA: 0x000027E7 File Offset: 0x000009E7
		// (set) Token: 0x06000394 RID: 916 RVA: 0x000206B0 File Offset: 0x0001E8B0
		internal virtual Label Label1 { get; set; }

		// Token: 0x17000149 RID: 329
		// (get) Token: 0x06000395 RID: 917 RVA: 0x000027EF File Offset: 0x000009EF
		// (set) Token: 0x06000396 RID: 918 RVA: 0x000206C4 File Offset: 0x0001E8C4
		internal virtual Label Label34 { get; set; }

		// Token: 0x1700014A RID: 330
		// (get) Token: 0x06000397 RID: 919 RVA: 0x000027F7 File Offset: 0x000009F7
		// (set) Token: 0x06000398 RID: 920 RVA: 0x000206D8 File Offset: 0x0001E8D8
		internal virtual DrakeUIListBox numslist { get; set; }

		// Token: 0x1700014B RID: 331
		// (get) Token: 0x06000399 RID: 921 RVA: 0x000027FF File Offset: 0x000009FF
		// (set) Token: 0x0600039A RID: 922 RVA: 0x000206EC File Offset: 0x0001E8EC
		internal virtual DrakeUIAvatar remnum
		{
			[CompilerGenerated]
			get
			{
				return this._remnum;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.remnum_Click);
				DrakeUIAvatar remnum = this._remnum;
				if (remnum != null)
				{
					remnum.Click -= value2;
				}
				this._remnum = value;
				remnum = this._remnum;
				if (remnum != null)
				{
					remnum.Click += value2;
				}
			}
		}

		// Token: 0x1700014C RID: 332
		// (get) Token: 0x0600039B RID: 923 RVA: 0x00002807 File Offset: 0x00000A07
		// (set) Token: 0x0600039C RID: 924 RVA: 0x00020730 File Offset: 0x0001E930
		internal virtual DrakeUIAvatar addnum
		{
			[CompilerGenerated]
			get
			{
				return this._addnum;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.addnum_Click);
				DrakeUIAvatar addnum = this._addnum;
				if (addnum != null)
				{
					addnum.Click -= value2;
				}
				this._addnum = value;
				addnum = this._addnum;
				if (addnum != null)
				{
					addnum.Click += value2;
				}
			}
		}

		// Token: 0x1700014D RID: 333
		// (get) Token: 0x0600039D RID: 925 RVA: 0x0000280F File Offset: 0x00000A0F
		// (set) Token: 0x0600039E RID: 926 RVA: 0x00020774 File Offset: 0x0001E974
		internal virtual DrakeUIAvatar selectlist
		{
			[CompilerGenerated]
			get
			{
				return this._selectlist;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.selectlist_Click);
				DrakeUIAvatar selectlist = this._selectlist;
				if (selectlist != null)
				{
					selectlist.Click -= value2;
				}
				this._selectlist = value;
				selectlist = this._selectlist;
				if (selectlist != null)
				{
					selectlist.Click += value2;
				}
			}
		}

		// Token: 0x1700014E RID: 334
		// (get) Token: 0x0600039F RID: 927 RVA: 0x00002817 File Offset: 0x00000A17
		// (set) Token: 0x060003A0 RID: 928 RVA: 0x000207B8 File Offset: 0x0001E9B8
		internal virtual Label Label2 { get; set; }

		// Token: 0x17000150 RID: 336
		// (get) Token: 0x060003A1 RID: 929 RVA: 0x0000281F File Offset: 0x00000A1F
		// (set) Token: 0x060003A2 RID: 930 RVA: 0x000207CC File Offset: 0x0001E9CC
		internal virtual DrakeUIToolTip DrakeUIToolTip1 { get; set; }

		// Token: 0x1700014F RID: 335
		// (get) Token: 0x060003A3 RID: 931 RVA: 0x00002827 File Offset: 0x00000A27
		// (set) Token: 0x060003A4 RID: 932 RVA: 0x000207E0 File Offset: 0x0001E9E0
		internal virtual DrakeUICheckBox checkall
		{
			[CompilerGenerated]
			get
			{
				return this._checkall;
			}
			[CompilerGenerated]
			set
			{
				MouseEventHandler value2 = new MouseEventHandler(this.checkall_MouseClick);
				DrakeUICheckBox checkall = this._checkall;
				if (checkall != null)
				{
					checkall.MouseClick -= value2;
				}
				this._checkall = value;
				checkall = this._checkall;
				if (checkall != null)
				{
					checkall.MouseClick += value2;
				}
			}
		}

		// Token: 0x060003A5 RID: 933 RVA: 0x0001D5C0 File Offset: 0x0001B7C0
		private void DrakeUIButtonIcon2_Click(object sender, EventArgs e)
		{
			base.DialogResult = DialogResult.Cancel;
			base.Close();
		}

		// Token: 0x060003A6 RID: 934 RVA: 0x00020824 File Offset: 0x0001EA24
		private void DrakeUIButtonIcon1_Click(object sender, EventArgs e)
		{
			if (!this.checkall.Checked && this.numslist.Items.Count == 0)
			{
				Interaction.MsgBox("Add Phone Number to list First", MsgBoxStyle.OkOnly, null);
			}
			else
			{
				base.DialogResult = DialogResult.OK;
				base.Close();
			}
		}

		// Token: 0x060003A7 RID: 935 RVA: 0x00020874 File Offset: 0x0001EA74
		private void phonetext_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (Strings.Asc(e.KeyChar) != 8 && (Strings.Asc(e.KeyChar) < 48 | Strings.Asc(e.KeyChar) > 57))
			{
				e.Handled = true;
			}
		}

		// Token: 0x060003A8 RID: 936 RVA: 0x0000246D File Offset: 0x0000066D
		private void smsMaker_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x060003A9 RID: 937 RVA: 0x0000246D File Offset: 0x0000066D
		private void method_4(object sender, EventArgs e)
		{
		}

		// Token: 0x060003AA RID: 938 RVA: 0x000208BC File Offset: 0x0001EABC
		private void addnum_Click(object sender, EventArgs e)
		{
			if (!(string.IsNullOrEmpty(this.phonetext.Text) | string.IsNullOrWhiteSpace(this.phonetext.Text)))
			{
				this.numslist.Items.Add(this.phonetext.Text);
			}
			else
			{
				Interaction.MsgBox("Enter Phone Number First", MsgBoxStyle.OkOnly, null);
			}
		}

		// Token: 0x060003AB RID: 939 RVA: 0x00020918 File Offset: 0x0001EB18
		private void remnum_Click(object sender, EventArgs e)
		{
			if (this.numslist.Items.Count != 0)
			{
				if (!Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(this.numslist.SelectedItem, null, "Count", new object[0], null, null, null), 0, false))
				{
					object obj;
					object loopObj;
					if (ObjectFlowControl.ForLoopControl.ForLoopInitObj(obj, 0, Operators.SubtractObject(NewLateBinding.LateGet(this.numslist.SelectedItem, null, "Count", new object[0], null, null, null), 1), 1, ref loopObj, ref obj))
					{
						do
						{
							try
							{
								this.numslist.Items.Remove(RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet(this.numslist.SelectedItem, new object[]
								{
									obj
								}, null)));
							}
							catch (Exception ex)
							{
							}
						}
						while (ObjectFlowControl.ForLoopControl.ForNextCheckObj(obj, loopObj, ref obj));
					}
				}
				else
				{
					Interaction.MsgBox("select number from list to remove", MsgBoxStyle.OkOnly, null);
				}
			}
			else
			{
				Interaction.MsgBox("Add Phone Number to list First", MsgBoxStyle.OkOnly, null);
			}
		}

		// Token: 0x060003AC RID: 940 RVA: 0x00020A2C File Offset: 0x0001EC2C
		private void selectlist_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.InitialDirectory = "C:\\";
			openFileDialog.Title = "Open a Text File";
			openFileDialog.Filter = "Text Files|*.txt";
			checked
			{
				if (openFileDialog.ShowDialog() == DialogResult.OK)
				{
					try
					{
						string fileName = openFileDialog.FileName;
						if (!string.IsNullOrEmpty(fileName) && !string.IsNullOrWhiteSpace(fileName))
						{
							string[] array = File.ReadAllLines(fileName);
							if (array.Length > 0)
							{
								int num = array.Length - 1;
								for (int i = 0; i <= num; i++)
								{
									string text = array[i].Replace(" ", "");
									if (Versioned.IsNumeric(text))
									{
										this.numslist.Items.Add(text);
									}
								}
							}
						}
					}
					catch (Exception ex)
					{
					}
				}
			}
		}

		// Token: 0x060003AD RID: 941 RVA: 0x00020B08 File Offset: 0x0001ED08
		private void checkall_MouseClick(object sender, MouseEventArgs e)
		{
			if (!this.checkall.Checked)
			{
				this.phonetext.Text = "";
				this.phonetext.Enabled = true;
				this.numslist.Enabled = true;
				this.selectlist.Enabled = true;
				this.addnum.Enabled = true;
				this.remnum.Enabled = false;
			}
			else
			{
				this.phonetext.Text = "";
				this.phonetext.Enabled = false;
				this.numslist.Items.Clear();
				this.numslist.Enabled = false;
				this.selectlist.Enabled = false;
				this.addnum.Enabled = false;
				this.remnum.Enabled = false;
			}
		}
	}
}
