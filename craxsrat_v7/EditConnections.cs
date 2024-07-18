using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using DrakeUI.Framework;
using Microsoft.VisualBasic.CompilerServices;
using Vip.Notification;

namespace Craxs_Rat
{
	// Token: 0x020000B4 RID: 180
	[DesignerGenerated]
	public partial class EditConnections : Form
	{
		// Token: 0x06000BDF RID: 3039 RVA: 0x0007D048 File Offset: 0x0007B248
		public EditConnections(List<GClass8> gclass8s_2)
		{
			base.Load += this.EditConnections_Load;
			this.string_0 = "";
			this.string_1 = "";
			this.string_2 = "";
			this.gclass8s_0 = new List<GClass8>();
			this.gclass8s_1 = new List<GClass8>();
			this.method_1(gclass8s_2);
		}

		// Token: 0x06000BE1 RID: 3041 RVA: 0x0007D0F0 File Offset: 0x0007B2F0
		private void method_0()
		{
			this.components = new Container();
			DataGridViewCellStyle dataGridViewCellStyle = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
			this.Htext = new DrakeUITextBox();
			this.DrakeUIAvatar1 = new DrakeUIAvatar();
			this.Label2 = new Label();
			this.Label1 = new Label();
			this.DrakeUIToolTip1 = new DrakeUIToolTip(this.components);
			this.DrakeUIAvatar2 = new DrakeUIAvatar();
			this.Porttext = new DrakeUITextBox();
			this.Label4 = new Label();
			this.cliname = new DrakeUITextBox();
			this.DGVC = new DataGridView();
			this.SplitContainer1 = new SplitContainer();
			this.seleccli = new DataGridViewCheckBoxColumn();
			this.cliico = new DataGridViewImageColumn();
			this.cliename = new DataGridViewTextBoxColumn();
			this.Label3 = new Label();
			((ISupportInitialize)this.DGVC).BeginInit();
			((ISupportInitialize)this.SplitContainer1).BeginInit();
			this.SplitContainer1.Panel1.SuspendLayout();
			this.SplitContainer1.Panel2.SuspendLayout();
			this.SplitContainer1.SuspendLayout();
			base.SuspendLayout();
			this.Htext.Cursor = Cursors.IBeam;
			this.Htext.FillColor = Color.Black;
			this.Htext.Font = new Font("Microsoft Sans Serif", 12f);
			this.Htext.ForeColor = Color.White;
			this.Htext.Location = new Point(44, 234);
			this.Htext.Margin = new Padding(4, 5, 4, 5);
			this.Htext.Maximum = 2147483647.0;
			this.Htext.Minimum = -2147483648.0;
			this.Htext.Name = "Htext";
			this.Htext.Padding = new Padding(5);
			this.Htext.RectColor = Color.FromArgb(157, 5, 17);
			this.Htext.RectDisableColor = Color.FromArgb(227, 242, 253);
			this.Htext.Size = new Size(220, 30);
			this.Htext.Style = UIStyle.Custom;
			this.Htext.StyleCustomMode = true;
			this.Htext.TabIndex = 0;
			this.Htext.TextAlignment = ContentAlignment.TopCenter;
			this.Htext.Watermark = "New Host or New ip";
			this.DrakeUIAvatar1.AvatarSize = 30;
			this.DrakeUIAvatar1.Cursor = Cursors.Hand;
			this.DrakeUIAvatar1.FillColor = Color.Black;
			this.DrakeUIAvatar1.Font = new Font("Microsoft Sans Serif", 12f);
			this.DrakeUIAvatar1.ForeColor = Color.FromArgb(157, 5, 17);
			this.DrakeUIAvatar1.Location = new Point(204, 438);
			this.DrakeUIAvatar1.Name = "DrakeUIAvatar1";
			this.DrakeUIAvatar1.Size = new Size(60, 60);
			this.DrakeUIAvatar1.Style = UIStyle.Custom;
			this.DrakeUIAvatar1.Symbol = 61639;
			this.DrakeUIAvatar1.SymbolSize = 30;
			this.DrakeUIAvatar1.TabIndex = 2;
			this.DrakeUIAvatar1.Text = "DrakeUIAvatar1";
			this.DrakeUIToolTip1.SetToolTip(this.DrakeUIAvatar1, "Save");
			this.Label2.AutoSize = true;
			this.Label2.BackColor = Color.Transparent;
			this.Label2.Font = new Font("Roboto", 12f, FontStyle.Bold);
			this.Label2.ForeColor = Color.FromArgb(157, 5, 17);
			this.Label2.Location = new Point(40, 323);
			this.Label2.Margin = new Padding(4, 0, 4, 0);
			this.Label2.Name = "Label2";
			this.Label2.Size = new Size(48, 24);
			this.Label2.TabIndex = 20;
			this.Label2.Text = "Port";
			this.Label1.AutoSize = true;
			this.Label1.BackColor = Color.Transparent;
			this.Label1.Font = new Font("Roboto", 12f, FontStyle.Bold);
			this.Label1.ForeColor = Color.FromArgb(157, 5, 17);
			this.Label1.Location = new Point(40, 205);
			this.Label1.Margin = new Padding(4, 0, 4, 0);
			this.Label1.Name = "Label1";
			this.Label1.Size = new Size(52, 24);
			this.Label1.TabIndex = 21;
			this.Label1.Text = "Host";
			this.DrakeUIToolTip1.BackColor = Color.FromArgb(54, 54, 54);
			this.DrakeUIToolTip1.ForeColor = Color.FromArgb(239, 239, 239);
			this.DrakeUIToolTip1.OwnerDraw = true;
			this.DrakeUIAvatar2.AvatarSize = 30;
			this.DrakeUIAvatar2.Cursor = Cursors.Hand;
			this.DrakeUIAvatar2.FillColor = Color.Black;
			this.DrakeUIAvatar2.Font = new Font("Microsoft Sans Serif", 12f);
			this.DrakeUIAvatar2.ForeColor = Color.FromArgb(157, 5, 17);
			this.DrakeUIAvatar2.Location = new Point(44, 438);
			this.DrakeUIAvatar2.Name = "DrakeUIAvatar2";
			this.DrakeUIAvatar2.Size = new Size(60, 60);
			this.DrakeUIAvatar2.Style = UIStyle.Custom;
			this.DrakeUIAvatar2.Symbol = 61453;
			this.DrakeUIAvatar2.SymbolSize = 30;
			this.DrakeUIAvatar2.TabIndex = 22;
			this.DrakeUIAvatar2.Text = "DrakeUIAvatar2";
			this.DrakeUIToolTip1.SetToolTip(this.DrakeUIAvatar2, "Cancel");
			this.Porttext.Cursor = Cursors.IBeam;
			this.Porttext.DoubleValue = 4444.0;
			this.Porttext.FillColor = Color.Black;
			this.Porttext.Font = new Font("Microsoft Sans Serif", 12f);
			this.Porttext.ForeColor = Color.White;
			this.Porttext.IntValue = 4444;
			this.Porttext.Location = new Point(44, 352);
			this.Porttext.Margin = new Padding(4, 5, 4, 5);
			this.Porttext.Maximum = 2147483647.0;
			this.Porttext.Minimum = -2147483648.0;
			this.Porttext.Name = "Porttext";
			this.Porttext.Padding = new Padding(5);
			this.Porttext.RectColor = Color.FromArgb(157, 5, 17);
			this.Porttext.RectDisableColor = Color.FromArgb(227, 242, 253);
			this.Porttext.Size = new Size(220, 30);
			this.Porttext.Style = UIStyle.Custom;
			this.Porttext.StyleCustomMode = true;
			this.Porttext.TabIndex = 25;
			this.Porttext.Text = "4444";
			this.Porttext.TextAlignment = ContentAlignment.TopCenter;
			this.Porttext.Type = DrakeUITextBox.UIEditType.Integer;
			this.Porttext.Watermark = "New Port";
			this.Label4.AutoSize = true;
			this.Label4.BackColor = Color.Transparent;
			this.Label4.Font = new Font("Roboto", 12f, FontStyle.Bold);
			this.Label4.ForeColor = Color.FromArgb(157, 5, 17);
			this.Label4.Location = new Point(40, 80);
			this.Label4.Margin = new Padding(4, 0, 4, 0);
			this.Label4.Name = "Label4";
			this.Label4.Size = new Size(63, 24);
			this.Label4.TabIndex = 27;
			this.Label4.Text = "Name";
			this.cliname.Cursor = Cursors.IBeam;
			this.cliname.FillColor = Color.Black;
			this.cliname.Font = new Font("Microsoft Sans Serif", 12f);
			this.cliname.ForeColor = Color.White;
			this.cliname.Location = new Point(44, 109);
			this.cliname.Margin = new Padding(4, 5, 4, 5);
			this.cliname.Maximum = 2147483647.0;
			this.cliname.Minimum = -2147483648.0;
			this.cliname.Name = "cliname";
			this.cliname.Padding = new Padding(5);
			this.cliname.RectColor = Color.FromArgb(157, 5, 17);
			this.cliname.RectDisableColor = Color.FromArgb(227, 242, 253);
			this.cliname.Size = new Size(220, 30);
			this.cliname.Style = UIStyle.Custom;
			this.cliname.StyleCustomMode = true;
			this.cliname.TabIndex = 26;
			this.cliname.TextAlignment = ContentAlignment.TopCenter;
			this.cliname.Watermark = "Client name";
			this.DGVC.AllowUserToAddRows = false;
			this.DGVC.AllowUserToDeleteRows = false;
			this.DGVC.AllowUserToResizeColumns = false;
			this.DGVC.AllowUserToResizeRows = false;
			dataGridViewCellStyle.BackColor = Color.Black;
			dataGridViewCellStyle.ForeColor = Color.White;
			dataGridViewCellStyle.SelectionBackColor = Color.White;
			dataGridViewCellStyle.SelectionForeColor = Color.Black;
			this.DGVC.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle;
			this.DGVC.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			this.DGVC.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
			this.DGVC.BackgroundColor = Color.Black;
			dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = Color.Black;
			dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 7.8f, FontStyle.Regular, GraphicsUnit.Point, 0);
			dataGridViewCellStyle2.ForeColor = Color.White;
			dataGridViewCellStyle2.SelectionBackColor = Color.White;
			dataGridViewCellStyle2.SelectionForeColor = Color.Black;
			dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
			this.DGVC.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.DGVC.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DGVC.ColumnHeadersVisible = false;
			this.DGVC.Columns.AddRange(new DataGridViewColumn[]
			{
				this.seleccli,
				this.cliico,
				this.cliename
			});
			dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = Color.Black;
			dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 7.8f, FontStyle.Regular, GraphicsUnit.Point, 0);
			dataGridViewCellStyle3.ForeColor = Color.White;
			dataGridViewCellStyle3.SelectionBackColor = Color.White;
			dataGridViewCellStyle3.SelectionForeColor = Color.Black;
			dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
			this.DGVC.DefaultCellStyle = dataGridViewCellStyle3;
			this.DGVC.Dock = DockStyle.Fill;
			this.DGVC.GridColor = Color.Black;
			this.DGVC.Location = new Point(0, 0);
			this.DGVC.Name = "DGVC";
			this.DGVC.ReadOnly = true;
			dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = Color.Black;
			dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 7.8f, FontStyle.Regular, GraphicsUnit.Point, 0);
			dataGridViewCellStyle4.ForeColor = Color.White;
			dataGridViewCellStyle4.SelectionBackColor = Color.White;
			dataGridViewCellStyle4.SelectionForeColor = Color.Black;
			dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
			this.DGVC.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
			this.DGVC.RowHeadersVisible = false;
			dataGridViewCellStyle5.BackColor = Color.Black;
			dataGridViewCellStyle5.ForeColor = Color.White;
			dataGridViewCellStyle5.SelectionBackColor = Color.White;
			dataGridViewCellStyle5.SelectionForeColor = Color.Black;
			this.DGVC.RowsDefaultCellStyle = dataGridViewCellStyle5;
			this.DGVC.RowTemplate.Height = 24;
			this.DGVC.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			this.DGVC.Size = new Size(637, 510);
			this.DGVC.TabIndex = 28;
			this.SplitContainer1.Dock = DockStyle.Fill;
			this.SplitContainer1.Location = new Point(0, 0);
			this.SplitContainer1.Name = "SplitContainer1";
			this.SplitContainer1.Panel1.Controls.Add(this.Label3);
			this.SplitContainer1.Panel1.Controls.Add(this.cliname);
			this.SplitContainer1.Panel1.Controls.Add(this.DrakeUIAvatar2);
			this.SplitContainer1.Panel1.Controls.Add(this.DrakeUIAvatar1);
			this.SplitContainer1.Panel1.Controls.Add(this.Label4);
			this.SplitContainer1.Panel1.Controls.Add(this.Htext);
			this.SplitContainer1.Panel1.Controls.Add(this.Label2);
			this.SplitContainer1.Panel1.Controls.Add(this.Porttext);
			this.SplitContainer1.Panel1.Controls.Add(this.Label1);
			this.SplitContainer1.Panel2.Controls.Add(this.DGVC);
			this.SplitContainer1.Size = new Size(961, 510);
			this.SplitContainer1.SplitterDistance = 320;
			this.SplitContainer1.TabIndex = 29;
			this.seleccli.FillWeight = 67.85324f;
			this.seleccli.HeaderText = "selectme";
			this.seleccli.Name = "seleccli";
			this.seleccli.ReadOnly = true;
			this.cliico.FillWeight = 98.98477f;
			this.cliico.HeaderText = "icon";
			this.cliico.Name = "cliico";
			this.cliico.ReadOnly = true;
			this.cliename.FillWeight = 133.162f;
			this.cliename.HeaderText = "Name";
			this.cliename.Name = "cliename";
			this.cliename.ReadOnly = true;
			this.Label3.BackColor = Color.Transparent;
			this.Label3.Dock = DockStyle.Top;
			this.Label3.Font = new Font("Roboto", 12f, FontStyle.Bold);
			this.Label3.ForeColor = Color.FromArgb(157, 5, 17);
			this.Label3.Location = new Point(0, 0);
			this.Label3.Margin = new Padding(4, 0, 4, 0);
			this.Label3.Name = "Label3";
			this.Label3.Size = new Size(320, 64);
			this.Label3.TabIndex = 28;
			this.Label3.Text = "Edit connection info";
			this.Label3.TextAlign = ContentAlignment.MiddleCenter;
			base.AutoScaleDimensions = new SizeF(8f, 16f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.Black;
			base.ClientSize = new Size(961, 510);
			base.ControlBox = false;
			base.Controls.Add(this.SplitContainer1);
			this.ForeColor = Color.White;
			base.FormBorderStyle = FormBorderStyle.FixedToolWindow;
			base.Name = "EditConnections";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			this.Text = "EditConnections";
			base.TopMost = true;
			((ISupportInitialize)this.DGVC).EndInit();
			this.SplitContainer1.Panel1.ResumeLayout(false);
			this.SplitContainer1.Panel1.PerformLayout();
			this.SplitContainer1.Panel2.ResumeLayout(false);
			((ISupportInitialize)this.SplitContainer1).EndInit();
			this.SplitContainer1.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x17000361 RID: 865
		// (get) Token: 0x06000BE2 RID: 3042 RVA: 0x0000642D File Offset: 0x0000462D
		// (set) Token: 0x06000BE3 RID: 3043 RVA: 0x0007E14C File Offset: 0x0007C34C
		internal virtual DrakeUITextBox Htext { get; set; }

		// Token: 0x17000362 RID: 866
		// (get) Token: 0x06000BE4 RID: 3044 RVA: 0x00006435 File Offset: 0x00004635
		// (set) Token: 0x06000BE5 RID: 3045 RVA: 0x0007E160 File Offset: 0x0007C360
		internal virtual DrakeUIAvatar DrakeUIAvatar1
		{
			[CompilerGenerated]
			get
			{
				return this._DrakeUIAvatar1;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.DrakeUIAvatar1_Click);
				DrakeUIAvatar drakeUIAvatar = this._DrakeUIAvatar1;
				if (drakeUIAvatar != null)
				{
					drakeUIAvatar.Click -= value2;
				}
				this._DrakeUIAvatar1 = value;
				drakeUIAvatar = this._DrakeUIAvatar1;
				if (drakeUIAvatar != null)
				{
					drakeUIAvatar.Click += value2;
				}
			}
		}

		// Token: 0x1700036F RID: 879
		// (get) Token: 0x06000BE6 RID: 3046 RVA: 0x0000643D File Offset: 0x0000463D
		// (set) Token: 0x06000BE7 RID: 3047 RVA: 0x0007E1A4 File Offset: 0x0007C3A4
		internal virtual DrakeUIToolTip DrakeUIToolTip1 { get; set; }

		// Token: 0x17000363 RID: 867
		// (get) Token: 0x06000BE8 RID: 3048 RVA: 0x00006445 File Offset: 0x00004645
		// (set) Token: 0x06000BE9 RID: 3049 RVA: 0x0007E1B8 File Offset: 0x0007C3B8
		internal virtual Label Label2 { get; set; }

		// Token: 0x17000364 RID: 868
		// (get) Token: 0x06000BEA RID: 3050 RVA: 0x0000644D File Offset: 0x0000464D
		// (set) Token: 0x06000BEB RID: 3051 RVA: 0x0007E1CC File Offset: 0x0007C3CC
		internal virtual Label Label1 { get; set; }

		// Token: 0x17000365 RID: 869
		// (get) Token: 0x06000BEC RID: 3052 RVA: 0x00006455 File Offset: 0x00004655
		// (set) Token: 0x06000BED RID: 3053 RVA: 0x0007E1E0 File Offset: 0x0007C3E0
		internal virtual DrakeUIAvatar DrakeUIAvatar2
		{
			[CompilerGenerated]
			get
			{
				return this._DrakeUIAvatar2;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.DrakeUIAvatar2_Click);
				DrakeUIAvatar drakeUIAvatar = this._DrakeUIAvatar2;
				if (drakeUIAvatar != null)
				{
					drakeUIAvatar.Click -= value2;
				}
				this._DrakeUIAvatar2 = value;
				drakeUIAvatar = this._DrakeUIAvatar2;
				if (drakeUIAvatar != null)
				{
					drakeUIAvatar.Click += value2;
				}
			}
		}

		// Token: 0x17000366 RID: 870
		// (get) Token: 0x06000BEE RID: 3054 RVA: 0x0000645D File Offset: 0x0000465D
		// (set) Token: 0x06000BEF RID: 3055 RVA: 0x0007E224 File Offset: 0x0007C424
		internal virtual DrakeUITextBox Porttext { get; set; }

		// Token: 0x17000367 RID: 871
		// (get) Token: 0x06000BF0 RID: 3056 RVA: 0x00006465 File Offset: 0x00004665
		// (set) Token: 0x06000BF1 RID: 3057 RVA: 0x0007E238 File Offset: 0x0007C438
		internal virtual Label Label4 { get; set; }

		// Token: 0x17000368 RID: 872
		// (get) Token: 0x06000BF2 RID: 3058 RVA: 0x0000646D File Offset: 0x0000466D
		// (set) Token: 0x06000BF3 RID: 3059 RVA: 0x0007E24C File Offset: 0x0007C44C
		internal virtual DrakeUITextBox cliname { get; set; }

		// Token: 0x17000369 RID: 873
		// (get) Token: 0x06000BF4 RID: 3060 RVA: 0x00006475 File Offset: 0x00004675
		// (set) Token: 0x06000BF5 RID: 3061 RVA: 0x0007E260 File Offset: 0x0007C460
		internal virtual DataGridView DGVC { get; set; }

		// Token: 0x1700036A RID: 874
		// (get) Token: 0x06000BF6 RID: 3062 RVA: 0x0000647D File Offset: 0x0000467D
		// (set) Token: 0x06000BF7 RID: 3063 RVA: 0x0007E274 File Offset: 0x0007C474
		internal virtual DataGridViewCheckBoxColumn seleccli { get; set; }

		// Token: 0x1700036B RID: 875
		// (get) Token: 0x06000BF8 RID: 3064 RVA: 0x00006485 File Offset: 0x00004685
		// (set) Token: 0x06000BF9 RID: 3065 RVA: 0x0007E288 File Offset: 0x0007C488
		internal virtual DataGridViewImageColumn cliico { get; set; }

		// Token: 0x1700036C RID: 876
		// (get) Token: 0x06000BFA RID: 3066 RVA: 0x0000648D File Offset: 0x0000468D
		// (set) Token: 0x06000BFB RID: 3067 RVA: 0x0007E29C File Offset: 0x0007C49C
		internal virtual DataGridViewTextBoxColumn cliename { get; set; }

		// Token: 0x1700036D RID: 877
		// (get) Token: 0x06000BFC RID: 3068 RVA: 0x00006495 File Offset: 0x00004695
		// (set) Token: 0x06000BFD RID: 3069 RVA: 0x0007E2B0 File Offset: 0x0007C4B0
		internal virtual SplitContainer SplitContainer1 { get; set; }

		// Token: 0x1700036E RID: 878
		// (get) Token: 0x06000BFE RID: 3070 RVA: 0x0000649D File Offset: 0x0000469D
		// (set) Token: 0x06000BFF RID: 3071 RVA: 0x0007E2C4 File Offset: 0x0007C4C4
		internal virtual Label Label3 { get; set; }

		// Token: 0x06000C00 RID: 3072 RVA: 0x000064A5 File Offset: 0x000046A5
		public void method_1(List<GClass8> gclass8s_0)
		{
			this.method_0();
			this.gclass8s_0 = gclass8s_0;
		}

		// Token: 0x06000C01 RID: 3073 RVA: 0x0007E2D8 File Offset: 0x0007C4D8
		private void DrakeUIAvatar1_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(this.Htext.Text) | string.IsNullOrWhiteSpace(this.Htext.Text))
			{
				Alert.ShowWarning("Enter Host Name First");
			}
			else
			{
				this.string_0 = this.Htext.Text;
				this.string_1 = this.Porttext.Text;
				this.string_2 = this.cliname.Text;
				if (this.DGVC.Rows.Count > 0)
				{
					try
					{
						foreach (object obj in ((IEnumerable)this.DGVC.Rows))
						{
							DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
							try
							{
								this.gclass8s_1.Add((GClass8)dataGridViewRow.Tag);
							}
							catch (Exception ex)
							{
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
				base.DialogResult = DialogResult.OK;
				base.Close();
			}
		}

		// Token: 0x06000C02 RID: 3074 RVA: 0x0007BDDC File Offset: 0x00079FDC
		private void DrakeUIAvatar2_Click(object sender, EventArgs e)
		{
			base.DialogResult = DialogResult.No;
			base.Close();
		}

		// Token: 0x06000C03 RID: 3075 RVA: 0x0007E3F4 File Offset: 0x0007C5F4
		private void EditConnections_Load(object sender, EventArgs e)
		{
			if (this.gclass8s_0.Count > 0)
			{
				try
				{
					foreach (GClass8 gclass in this.gclass8s_0)
					{
						int index = this.DGVC.Rows.Add(new object[]
						{
							true,
							gclass.objects_1[0],
							gclass.string_8
						});
						this.DGVC.Rows[index].Tag = gclass;
					}
				}
				finally
				{
					List<GClass8>.Enumerator enumerator;
					((IDisposable)enumerator).Dispose();
				}
			}
		}

		// Token: 0x040006AC RID: 1708
		public string string_0;

		// Token: 0x040006AD RID: 1709
		public string string_1;

		// Token: 0x040006AE RID: 1710
		public string string_2;

		// Token: 0x040006AF RID: 1711
		public List<GClass8> gclass8s_0;

		// Token: 0x040006B0 RID: 1712
		public List<GClass8> gclass8s_1;
	}
}
