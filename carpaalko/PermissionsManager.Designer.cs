namespace Craxs_Rat
{
	// Token: 0x020000BF RID: 191
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class PermissionsManager : global::System.Windows.Forms.Form
	{
		// Token: 0x06000E06 RID: 3590 RVA: 0x00093700 File Offset: 0x00091900
		protected override void Dispose(bool disposing)
		{
			try
			{
				if (disposing && this.components != null)
				{
					((global::System.IDisposable)this.components).Dispose();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		// Token: 0x06000E07 RID: 3591 RVA: 0x00093744 File Offset: 0x00091944
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Craxs_Rat.PermissionsManager));
			this.DrakeUITabControl1 = new global::DrakeUI.Framework.DrakeUITabControl();
			this.TabPage1 = new global::System.Windows.Forms.TabPage();
			this.DGVPRIM = new global::System.Windows.Forms.DataGridView();
			this.iconprim = new global::System.Windows.Forms.DataGridViewImageColumn();
			this.primname = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Status = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DrakeUIButtonIcon3 = new global::DrakeUI.Framework.DrakeUIButtonIcon();
			this.TabPage2 = new global::System.Windows.Forms.TabPage();
			this.Button2 = new global::System.Windows.Forms.Button();
			this.Button1 = new global::System.Windows.Forms.Button();
			this.Primslist = new global::DrakeUI.Framework.DrakeUIListBox();
			this.addactiv = new global::System.Windows.Forms.Button();
			this.comboproms = new global::DrakeUI.Framework.DrakeUIComboBox();
			this.Panel1 = new global::System.Windows.Forms.Panel();
			this.checkbattery = new global::DrakeUI.Framework.DrakeUICheckBox();
			this.checkdraw = new global::DrakeUI.Framework.DrakeUICheckBox();
			this.checkacess = new global::DrakeUI.Framework.DrakeUICheckBox();
			this.Label3 = new global::System.Windows.Forms.Label();
			this.Label2 = new global::System.Windows.Forms.Label();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.TabPage3 = new global::System.Windows.Forms.TabPage();
			this.PictureBox2 = new global::System.Windows.Forms.PictureBox();
			this.Label5 = new global::System.Windows.Forms.Label();
			this.PictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.Label4 = new global::System.Windows.Forms.Label();
			this.TextBox1 = new global::System.Windows.Forms.TextBox();
			this.Panel2 = new global::System.Windows.Forms.Panel();
			this.statustext = new global::System.Windows.Forms.Label();
			this.DrakeUIToolTip1 = new global::DrakeUI.Framework.DrakeUIToolTip(this.components);
			this.checkautostart = new global::DrakeUI.Framework.DrakeUICheckBox();
			this.Checkbg = new global::DrakeUI.Framework.DrakeUICheckBox();
			this.DrakeUITabControl1.SuspendLayout();
			this.TabPage1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.DGVPRIM).BeginInit();
			this.TabPage2.SuspendLayout();
			this.Panel1.SuspendLayout();
			this.TabPage3.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.PictureBox2).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.PictureBox1).BeginInit();
			this.Panel2.SuspendLayout();
			base.SuspendLayout();
			this.DrakeUITabControl1.Controls.Add(this.TabPage1);
			this.DrakeUITabControl1.Controls.Add(this.TabPage2);
			this.DrakeUITabControl1.Controls.Add(this.TabPage3);
			this.DrakeUITabControl1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.DrakeUITabControl1.DrawMode = global::System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
			this.DrakeUITabControl1.FillColor = global::System.Drawing.Color.Black;
			this.DrakeUITabControl1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f);
			this.DrakeUITabControl1.ItemSize = new global::System.Drawing.Size(290, 40);
			this.DrakeUITabControl1.Location = new global::System.Drawing.Point(0, 0);
			this.DrakeUITabControl1.MenuStyle = global::DrakeUI.Framework.UIMenuStyle.Custom;
			this.DrakeUITabControl1.Name = "DrakeUITabControl1";
			this.DrakeUITabControl1.SelectedIndex = 0;
			this.DrakeUITabControl1.Size = new global::System.Drawing.Size(934, 570);
			this.DrakeUITabControl1.SizeMode = global::System.Windows.Forms.TabSizeMode.Fixed;
			this.DrakeUITabControl1.Style = global::DrakeUI.Framework.UIStyle.Custom;
			this.DrakeUITabControl1.TabBackColor = global::System.Drawing.Color.Black;
			this.DrakeUITabControl1.TabIndex = 0;
			this.DrakeUITabControl1.TabSelectedColor = global::System.Drawing.Color.FromArgb(10, 10, 10);
			this.DrakeUITabControl1.TabSelectedForeColor = global::System.Drawing.Color.FromArgb(195, 18, 9);
			this.DrakeUITabControl1.TabSelectedHighColor = global::System.Drawing.Color.FromArgb(195, 18, 9);
			this.DrakeUITabControl1.TabUnSelectedForeColor = global::System.Drawing.Color.FromArgb(240, 240, 240);
			this.TabPage1.BackColor = global::System.Drawing.Color.Black;
			this.TabPage1.Controls.Add(this.DGVPRIM);
			this.TabPage1.Controls.Add(this.DrakeUIButtonIcon3);
			this.TabPage1.Location = new global::System.Drawing.Point(0, 40);
			this.TabPage1.Name = "TabPage1";
			this.TabPage1.Size = new global::System.Drawing.Size(934, 530);
			this.TabPage1.TabIndex = 0;
			this.TabPage1.Text = "Manage";
			this.DGVPRIM.AllowUserToAddRows = false;
			this.DGVPRIM.AllowUserToDeleteRows = false;
			this.DGVPRIM.AllowUserToResizeColumns = false;
			this.DGVPRIM.AllowUserToResizeRows = false;
			dataGridViewCellStyle.BackColor = global::System.Drawing.Color.Black;
			dataGridViewCellStyle.ForeColor = global::System.Drawing.Color.White;
			dataGridViewCellStyle.SelectionBackColor = global::System.Drawing.Color.White;
			dataGridViewCellStyle.SelectionForeColor = global::System.Drawing.Color.Black;
			this.DGVPRIM.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle;
			this.DGVPRIM.AutoSizeColumnsMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.DGVPRIM.AutoSizeRowsMode = global::System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.DGVPRIM.BackgroundColor = global::System.Drawing.Color.Black;
			this.DGVPRIM.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			dataGridViewCellStyle2.Alignment = global::System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = global::System.Drawing.Color.Black;
			dataGridViewCellStyle2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f);
			dataGridViewCellStyle2.ForeColor = global::System.Drawing.Color.White;
			dataGridViewCellStyle2.SelectionBackColor = global::System.Drawing.Color.White;
			dataGridViewCellStyle2.SelectionForeColor = global::System.Drawing.Color.Black;
			dataGridViewCellStyle2.WrapMode = global::System.Windows.Forms.DataGridViewTriState.True;
			this.DGVPRIM.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.DGVPRIM.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DGVPRIM.Columns.AddRange(new global::System.Windows.Forms.DataGridViewColumn[]
			{
				this.iconprim,
				this.primname,
				this.Status
			});
			dataGridViewCellStyle3.Alignment = global::System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = global::System.Drawing.Color.Black;
			dataGridViewCellStyle3.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f);
			dataGridViewCellStyle3.ForeColor = global::System.Drawing.Color.White;
			dataGridViewCellStyle3.SelectionBackColor = global::System.Drawing.Color.White;
			dataGridViewCellStyle3.SelectionForeColor = global::System.Drawing.Color.Black;
			dataGridViewCellStyle3.WrapMode = global::System.Windows.Forms.DataGridViewTriState.False;
			this.DGVPRIM.DefaultCellStyle = dataGridViewCellStyle3;
			this.DGVPRIM.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.DGVPRIM.EnableHeadersVisualStyles = false;
			this.DGVPRIM.GridColor = global::System.Drawing.Color.FromArgb(195, 18, 9);
			this.DGVPRIM.Location = new global::System.Drawing.Point(0, 66);
			this.DGVPRIM.Name = "DGVPRIM";
			dataGridViewCellStyle4.Alignment = global::System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = global::System.Drawing.Color.Black;
			dataGridViewCellStyle4.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f);
			dataGridViewCellStyle4.ForeColor = global::System.Drawing.Color.White;
			dataGridViewCellStyle4.SelectionBackColor = global::System.Drawing.Color.White;
			dataGridViewCellStyle4.SelectionForeColor = global::System.Drawing.Color.Black;
			dataGridViewCellStyle4.WrapMode = global::System.Windows.Forms.DataGridViewTriState.True;
			this.DGVPRIM.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
			this.DGVPRIM.RowHeadersVisible = false;
			dataGridViewCellStyle5.BackColor = global::System.Drawing.Color.Black;
			dataGridViewCellStyle5.ForeColor = global::System.Drawing.Color.White;
			dataGridViewCellStyle5.SelectionBackColor = global::System.Drawing.Color.White;
			dataGridViewCellStyle5.SelectionForeColor = global::System.Drawing.Color.Black;
			this.DGVPRIM.RowsDefaultCellStyle = dataGridViewCellStyle5;
			this.DGVPRIM.RowTemplate.Height = 24;
			this.DGVPRIM.SelectionMode = global::System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.DGVPRIM.ShowCellErrors = false;
			this.DGVPRIM.ShowEditingIcon = false;
			this.DGVPRIM.ShowRowErrors = false;
			this.DGVPRIM.Size = new global::System.Drawing.Size(934, 464);
			this.DGVPRIM.TabIndex = 0;
			this.iconprim.FillWeight = 20f;
			this.iconprim.HeaderText = " ";
			this.iconprim.Name = "iconprim";
			this.primname.FillWeight = 73.85786f;
			this.primname.HeaderText = "Permission";
			this.primname.Name = "primname";
			this.Status.FillWeight = 45f;
			this.Status.HeaderText = "isActive";
			this.Status.Name = "Status";
			this.DrakeUIButtonIcon3.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.DrakeUIButtonIcon3.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.DrakeUIButtonIcon3.FillColor = global::System.Drawing.Color.Black;
			this.DrakeUIButtonIcon3.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f);
			this.DrakeUIButtonIcon3.ForeColor = global::System.Drawing.Color.FromArgb(195, 18, 9);
			this.DrakeUIButtonIcon3.Location = new global::System.Drawing.Point(0, 0);
			this.DrakeUIButtonIcon3.Name = "DrakeUIButtonIcon3";
			this.DrakeUIButtonIcon3.RectColor = global::System.Drawing.Color.FromArgb(195, 18, 9);
			this.DrakeUIButtonIcon3.RectDisableColor = global::System.Drawing.Color.FromArgb(227, 242, 253);
			this.DrakeUIButtonIcon3.Size = new global::System.Drawing.Size(934, 66);
			this.DrakeUIButtonIcon3.Style = global::DrakeUI.Framework.UIStyle.Custom;
			this.DrakeUIButtonIcon3.Symbol = 61473;
			this.DrakeUIButtonIcon3.TabIndex = 34;
			this.DrakeUIButtonIcon3.Text = "Refresh";
			this.TabPage2.BackColor = global::System.Drawing.Color.Black;
			this.TabPage2.Controls.Add(this.Button2);
			this.TabPage2.Controls.Add(this.Button1);
			this.TabPage2.Controls.Add(this.Primslist);
			this.TabPage2.Controls.Add(this.addactiv);
			this.TabPage2.Controls.Add(this.comboproms);
			this.TabPage2.Controls.Add(this.Panel1);
			this.TabPage2.Location = new global::System.Drawing.Point(0, 40);
			this.TabPage2.Name = "TabPage2";
			this.TabPage2.Size = new global::System.Drawing.Size(934, 530);
			this.TabPage2.TabIndex = 1;
			this.TabPage2.Text = "Request";
			this.Button2.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.Button2.ForeColor = global::System.Drawing.Color.FromArgb(195, 18, 9);
			this.Button2.Location = new global::System.Drawing.Point(816, 148);
			this.Button2.Name = "Button2";
			this.Button2.Size = new global::System.Drawing.Size(65, 34);
			this.Button2.TabIndex = 31;
			this.Button2.Text = "-";
			this.DrakeUIToolTip1.SetToolTip(this.Button2, "REMOVE");
			this.Button2.UseVisualStyleBackColor = true;
			this.Button1.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.Button1.ForeColor = global::System.Drawing.Color.FromArgb(195, 18, 9);
			this.Button1.Location = new global::System.Drawing.Point(709, 460);
			this.Button1.Name = "Button1";
			this.Button1.Size = new global::System.Drawing.Size(171, 34);
			this.Button1.TabIndex = 30;
			this.Button1.Text = "Request Now";
			this.Button1.UseVisualStyleBackColor = true;
			this.Primslist.BackColor = global::System.Drawing.Color.Black;
			this.Primslist.FillColor = global::System.Drawing.Color.Black;
			this.Primslist.FillDisableColor = global::System.Drawing.Color.Black;
			this.Primslist.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f);
			this.Primslist.ForeColor = global::System.Drawing.Color.White;
			this.Primslist.HoverColor = global::System.Drawing.Color.Silver;
			this.Primslist.ItemSelectBackColor = global::System.Drawing.Color.FromArgb(140, 140, 140);
			this.Primslist.ItemSelectForeColor = global::System.Drawing.Color.FromArgb(195, 18, 9);
			this.Primslist.Location = new global::System.Drawing.Point(47, 192);
			this.Primslist.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Primslist.Name = "Primslist";
			this.Primslist.Padding = new global::System.Windows.Forms.Padding(7);
			this.Primslist.Radius = 15;
			this.Primslist.RectColor = global::System.Drawing.Color.FromArgb(195, 18, 9);
			this.Primslist.RectDisableColor = global::System.Drawing.Color.FromArgb(195, 18, 9);
			this.Primslist.Size = new global::System.Drawing.Size(833, 264);
			this.Primslist.Style = global::DrakeUI.Framework.UIStyle.Custom;
			this.Primslist.StyleCustomMode = true;
			this.Primslist.TabIndex = 29;
			this.Primslist.Text = "DrakeUIListBox1";
			this.addactiv.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.addactiv.ForeColor = global::System.Drawing.Color.FromArgb(195, 18, 9);
			this.addactiv.Location = new global::System.Drawing.Point(732, 148);
			this.addactiv.Name = "addactiv";
			this.addactiv.Size = new global::System.Drawing.Size(65, 34);
			this.addactiv.TabIndex = 28;
			this.addactiv.Text = "+";
			this.DrakeUIToolTip1.SetToolTip(this.addactiv, "ADD");
			this.addactiv.UseVisualStyleBackColor = true;
			this.comboproms.DropDownStyle = global::DrakeUI.Framework.UIDropDownStyle.DropDownList;
			this.comboproms.FillColor = global::System.Drawing.Color.White;
			this.comboproms.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 14f);
			this.comboproms.Items.AddRange(new object[]
			{
				"Send SMS",
				"Record Calls",
				"Change Wallpaper",
				"Read SMS",
				"Read Call Logs",
				"Read Contacts",
				"Read Accounts",
				"Camera",
				"Microphone",
				"Location",
				"Make Calls"
			});
			this.comboproms.Location = new global::System.Drawing.Point(47, 148);
			this.comboproms.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.comboproms.MinimumSize = new global::System.Drawing.Size(63, 0);
			this.comboproms.Name = "comboproms";
			this.comboproms.Padding = new global::System.Windows.Forms.Padding(0, 0, 30, 0);
			this.comboproms.RectColor = global::System.Drawing.Color.FromArgb(56, 142, 60);
			this.comboproms.RectDisableColor = global::System.Drawing.Color.FromArgb(227, 242, 253);
			this.comboproms.Size = new global::System.Drawing.Size(667, 34);
			this.comboproms.Style = global::DrakeUI.Framework.UIStyle.Green;
			this.comboproms.TabIndex = 27;
			this.comboproms.TextAlignment = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.Panel1.Controls.Add(this.checkbattery);
			this.Panel1.Controls.Add(this.checkdraw);
			this.Panel1.Controls.Add(this.checkacess);
			this.Panel1.Controls.Add(this.Label3);
			this.Panel1.Controls.Add(this.Label2);
			this.Panel1.Controls.Add(this.Label1);
			this.Panel1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.Panel1.Location = new global::System.Drawing.Point(0, 0);
			this.Panel1.Name = "Panel1";
			this.Panel1.Size = new global::System.Drawing.Size(934, 99);
			this.Panel1.TabIndex = 0;
			this.checkbattery.CheckBoxColor = global::System.Drawing.Color.FromArgb(30, 136, 229);
			this.checkbattery.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.checkbattery.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f);
			this.checkbattery.Location = new global::System.Drawing.Point(708, 34);
			this.checkbattery.Name = "checkbattery";
			this.checkbattery.Padding = new global::System.Windows.Forms.Padding(22, 0, 0, 0);
			this.checkbattery.Size = new global::System.Drawing.Size(43, 29);
			this.checkbattery.TabIndex = 15;
			this.checkdraw.CheckBoxColor = global::System.Drawing.Color.FromArgb(30, 136, 229);
			this.checkdraw.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.checkdraw.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f);
			this.checkdraw.Location = new global::System.Drawing.Point(381, 34);
			this.checkdraw.Name = "checkdraw";
			this.checkdraw.Padding = new global::System.Windows.Forms.Padding(22, 0, 0, 0);
			this.checkdraw.Size = new global::System.Drawing.Size(43, 29);
			this.checkdraw.TabIndex = 14;
			this.checkacess.CheckBoxColor = global::System.Drawing.Color.FromArgb(30, 136, 229);
			this.checkacess.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.checkacess.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f);
			this.checkacess.Location = new global::System.Drawing.Point(29, 34);
			this.checkacess.Name = "checkacess";
			this.checkacess.Padding = new global::System.Windows.Forms.Padding(22, 0, 0, 0);
			this.checkacess.Size = new global::System.Drawing.Size(43, 29);
			this.checkacess.TabIndex = 13;
			this.Label3.AutoSize = true;
			this.Label3.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f);
			this.Label3.ForeColor = global::System.Drawing.Color.White;
			this.Label3.Location = new global::System.Drawing.Point(757, 34);
			this.Label3.Name = "Label3";
			this.Label3.Size = new global::System.Drawing.Size(165, 25);
			this.Label3.TabIndex = 12;
			this.Label3.Text = "Battery optimizing";
			this.Label2.AutoSize = true;
			this.Label2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f);
			this.Label2.ForeColor = global::System.Drawing.Color.White;
			this.Label2.Location = new global::System.Drawing.Point(421, 34);
			this.Label2.Name = "Label2";
			this.Label2.Size = new global::System.Drawing.Size(177, 25);
			this.Label2.TabIndex = 9;
			this.Label2.Text = "Drawing over Apps";
			this.Label1.AutoSize = true;
			this.Label1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f);
			this.Label1.ForeColor = global::System.Drawing.Color.White;
			this.Label1.Location = new global::System.Drawing.Point(78, 36);
			this.Label1.Name = "Label1";
			this.Label1.Size = new global::System.Drawing.Size(200, 25);
			this.Label1.TabIndex = 7;
			this.Label1.Text = "Accessibility Services";
			this.TabPage3.BackColor = global::System.Drawing.Color.Black;
			this.TabPage3.Controls.Add(this.Checkbg);
			this.TabPage3.Controls.Add(this.checkautostart);
			this.TabPage3.Controls.Add(this.PictureBox2);
			this.TabPage3.Controls.Add(this.Label5);
			this.TabPage3.Controls.Add(this.PictureBox1);
			this.TabPage3.Controls.Add(this.Label4);
			this.TabPage3.Controls.Add(this.TextBox1);
			this.TabPage3.Location = new global::System.Drawing.Point(0, 40);
			this.TabPage3.Name = "TabPage3";
			this.TabPage3.Size = new global::System.Drawing.Size(934, 530);
			this.TabPage3.TabIndex = 2;
			this.TabPage3.Text = "MIUI (oppo,vevo,etc...)";
			this.PictureBox2.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("PictureBox2.Image");
			this.PictureBox2.Location = new global::System.Drawing.Point(58, 107);
			this.PictureBox2.Name = "PictureBox2";
			this.PictureBox2.Size = new global::System.Drawing.Size(246, 297);
			this.PictureBox2.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.PictureBox2.TabIndex = 15;
			this.PictureBox2.TabStop = false;
			this.Label5.AutoSize = true;
			this.Label5.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f);
			this.Label5.ForeColor = global::System.Drawing.Color.White;
			this.Label5.Location = new global::System.Drawing.Point(143, 69);
			this.Label5.Name = "Label5";
			this.Label5.Size = new global::System.Drawing.Size(99, 25);
			this.Label5.TabIndex = 14;
			this.Label5.Text = "Auto Start";
			this.PictureBox1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("PictureBox1.Image");
			this.PictureBox1.Location = new global::System.Drawing.Point(528, 107);
			this.PictureBox1.Name = "PictureBox1";
			this.PictureBox1.Size = new global::System.Drawing.Size(352, 297);
			this.PictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.PictureBox1.TabIndex = 12;
			this.PictureBox1.TabStop = false;
			this.Label4.AutoSize = true;
			this.Label4.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f);
			this.Label4.ForeColor = global::System.Drawing.Color.White;
			this.Label4.Location = new global::System.Drawing.Point(657, 69);
			this.Label4.Name = "Label4";
			this.Label4.Size = new global::System.Drawing.Size(177, 25);
			this.Label4.TabIndex = 11;
			this.Label4.Text = "Run in Background";
			this.TextBox1.BackColor = global::System.Drawing.Color.Black;
			this.TextBox1.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.TextBox1.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.TextBox1.ForeColor = global::System.Drawing.Color.FromArgb(195, 18, 9);
			this.TextBox1.Location = new global::System.Drawing.Point(0, 443);
			this.TextBox1.Multiline = true;
			this.TextBox1.Name = "TextBox1";
			this.TextBox1.ReadOnly = true;
			this.TextBox1.Size = new global::System.Drawing.Size(934, 87);
			this.TextBox1.TabIndex = 0;
			this.TextBox1.Text = "this options is not fully tested as there is different kinds of chinese phones , if the phone is not supported nothing will show up on the phone";
			this.TextBox1.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.Panel2.BackColor = global::System.Drawing.Color.Black;
			this.Panel2.Controls.Add(this.statustext);
			this.Panel2.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.Panel2.Location = new global::System.Drawing.Point(0, 540);
			this.Panel2.Name = "Panel2";
			this.Panel2.Size = new global::System.Drawing.Size(934, 30);
			this.Panel2.TabIndex = 31;
			this.statustext.BackColor = global::System.Drawing.Color.Black;
			this.statustext.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.statustext.ForeColor = global::System.Drawing.Color.Lime;
			this.statustext.Location = new global::System.Drawing.Point(0, 0);
			this.statustext.Name = "statustext";
			this.statustext.Size = new global::System.Drawing.Size(934, 30);
			this.statustext.TabIndex = 1;
			this.statustext.Text = "...";
			this.statustext.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.DrakeUIToolTip1.BackColor = global::System.Drawing.Color.FromArgb(54, 54, 54);
			this.DrakeUIToolTip1.ForeColor = global::System.Drawing.Color.FromArgb(239, 239, 239);
			this.DrakeUIToolTip1.OwnerDraw = true;
			this.checkautostart.CheckBoxColor = global::System.Drawing.Color.FromArgb(30, 136, 229);
			this.checkautostart.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.checkautostart.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f);
			this.checkautostart.Location = new global::System.Drawing.Point(94, 65);
			this.checkautostart.Name = "checkautostart";
			this.checkautostart.Padding = new global::System.Windows.Forms.Padding(22, 0, 0, 0);
			this.checkautostart.Size = new global::System.Drawing.Size(43, 29);
			this.checkautostart.TabIndex = 16;
			this.Checkbg.CheckBoxColor = global::System.Drawing.Color.FromArgb(30, 136, 229);
			this.Checkbg.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.Checkbg.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f);
			this.Checkbg.Location = new global::System.Drawing.Point(608, 65);
			this.Checkbg.Name = "Checkbg";
			this.Checkbg.Padding = new global::System.Windows.Forms.Padding(22, 0, 0, 0);
			this.Checkbg.Size = new global::System.Drawing.Size(43, 29);
			this.Checkbg.TabIndex = 17;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(8f, 16f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.Black;
			base.ClientSize = new global::System.Drawing.Size(934, 570);
			base.Controls.Add(this.Panel2);
			base.Controls.Add(this.DrakeUITabControl1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			base.Name = "PermissionsManager";
			base.ShowIcon = false;
			this.Text = "PermissionsManager";
			base.TopMost = true;
			this.DrakeUITabControl1.ResumeLayout(false);
			this.TabPage1.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.DGVPRIM).EndInit();
			this.TabPage2.ResumeLayout(false);
			this.Panel1.ResumeLayout(false);
			this.Panel1.PerformLayout();
			this.TabPage3.ResumeLayout(false);
			this.TabPage3.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.PictureBox2).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.PictureBox1).EndInit();
			this.Panel2.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x040007BF RID: 1983
		private global::System.ComponentModel.Container components;
	}
}
