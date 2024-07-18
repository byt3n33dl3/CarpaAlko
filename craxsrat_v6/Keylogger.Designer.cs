namespace Craxs_Rat
{
	// Token: 0x020000D6 RID: 214
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class Keylogger : global::System.Windows.Forms.Form
	{
		// Token: 0x06001026 RID: 4134 RVA: 0x000ABEDC File Offset: 0x000AA0DC
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

		// Token: 0x06001027 RID: 4135 RVA: 0x000ABF20 File Offset: 0x000AA120
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new global::System.Windows.Forms.DataGridViewCellStyle();
			this.TOpacity = new global::System.Windows.Forms.Timer(this.components);
			this.DGV0 = new global::System.Windows.Forms.DataGridView();
			this.Column1 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column6 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new global::System.Windows.Forms.DataGridViewImageColumn();
			this.ctxMenu = new global::System.Windows.Forms.ContextMenuStrip(this.components);
			this.SaveToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.SaveAsToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.DataGridView1 = new global::System.Windows.Forms.DataGridView();
			this.appnam = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.texts = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Panel1 = new global::System.Windows.Forms.Panel();
			this.deleteallbtn = new global::System.Windows.Forms.Button();
			this.backallbtn = new global::System.Windows.Forms.Button();
			this.delbtn = new global::System.Windows.Forms.Button();
			this.savedbtn = new global::System.Windows.Forms.Button();
			this.loadinglogs = new global::DrakeUI.Framework.DrakeUILoadingBar();
			this.getbtn = new global::System.Windows.Forms.Button();
			this.combologs = new global::MetroSet_UI.Controls.MetroSetComboBox();
			this.Button2 = new global::System.Windows.Forms.Button();
			this.keytabs = new global::DrakeUI.Framework.DrakeUITabControl();
			this.TabPage3 = new global::System.Windows.Forms.TabPage();
			this.TabPage4 = new global::System.Windows.Forms.TabPage();
			((global::System.ComponentModel.ISupportInitialize)this.DGV0).BeginInit();
			this.ctxMenu.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.DataGridView1).BeginInit();
			this.Panel1.SuspendLayout();
			this.keytabs.SuspendLayout();
			this.TabPage3.SuspendLayout();
			this.TabPage4.SuspendLayout();
			base.SuspendLayout();
			this.TOpacity.Interval = 1;
			this.DGV0.AllowUserToAddRows = false;
			this.DGV0.AllowUserToDeleteRows = false;
			this.DGV0.AllowUserToResizeColumns = false;
			this.DGV0.AllowUserToResizeRows = false;
			this.DGV0.AutoSizeColumnsMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.DGV0.BackgroundColor = global::System.Drawing.Color.Black;
			this.DGV0.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.DGV0.CellBorderStyle = global::System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.DGV0.ColumnHeadersBorderStyle = global::System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle.Alignment = global::System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle.BackColor = global::System.Drawing.Color.White;
			dataGridViewCellStyle.Font = new global::System.Drawing.Font("Segoe UI", 12f);
			dataGridViewCellStyle.ForeColor = global::System.Drawing.Color.Black;
			dataGridViewCellStyle.SelectionBackColor = global::System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle.SelectionForeColor = global::System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle.WrapMode = global::System.Windows.Forms.DataGridViewTriState.False;
			this.DGV0.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle;
			this.DGV0.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DGV0.Columns.AddRange(new global::System.Windows.Forms.DataGridViewColumn[]
			{
				this.Column1,
				this.Column6,
				this.Column3,
				this.Column2
			});
			dataGridViewCellStyle2.Alignment = global::System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = global::System.Drawing.Color.Black;
			dataGridViewCellStyle2.Font = new global::System.Drawing.Font("Segoe UI", 12f);
			dataGridViewCellStyle2.ForeColor = global::System.Drawing.Color.FromArgb(190, 190, 190);
			dataGridViewCellStyle2.SelectionBackColor = global::System.Drawing.Color.FromArgb(190, 190, 190);
			dataGridViewCellStyle2.SelectionForeColor = global::System.Drawing.Color.Black;
			dataGridViewCellStyle2.WrapMode = global::System.Windows.Forms.DataGridViewTriState.False;
			this.DGV0.DefaultCellStyle = dataGridViewCellStyle2;
			this.DGV0.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.DGV0.EditMode = global::System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.DGV0.EnableHeadersVisualStyles = false;
			this.DGV0.GridColor = global::System.Drawing.Color.FromArgb(42, 42, 42);
			this.DGV0.Location = new global::System.Drawing.Point(0, 0);
			this.DGV0.Margin = new global::System.Windows.Forms.Padding(4);
			this.DGV0.Name = "DGV0";
			this.DGV0.RowHeadersBorderStyle = global::System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			this.DGV0.RowHeadersVisible = false;
			dataGridViewCellStyle3.Alignment = global::System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			this.DGV0.RowsDefaultCellStyle = dataGridViewCellStyle3;
			this.DGV0.SelectionMode = global::System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.DGV0.Size = new global::System.Drawing.Size(1047, 493);
			this.DGV0.TabIndex = 4;
			this.Column1.AutoSizeMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Column1.HeaderText = "Status";
			this.Column1.Name = "Column1";
			this.Column6.HeaderText = "App Name";
			this.Column6.Name = "Column6";
			this.Column3.FillWeight = 250f;
			this.Column3.HeaderText = "Text";
			this.Column3.Name = "Column3";
			this.Column2.FillWeight = 1f;
			this.Column2.HeaderText = "";
			this.Column2.ImageLayout = global::System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
			this.Column2.MinimumWidth = 2;
			this.Column2.Name = "Column2";
			this.Column2.SortMode = global::System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.ctxMenu.ImageScalingSize = new global::System.Drawing.Size(20, 20);
			this.ctxMenu.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.SaveToolStripMenuItem,
				this.SaveAsToolStripMenuItem
			});
			this.ctxMenu.Name = "ctxMenu";
			this.ctxMenu.ShowImageMargin = false;
			this.ctxMenu.Size = new global::System.Drawing.Size(105, 52);
			this.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
			this.SaveToolStripMenuItem.Size = new global::System.Drawing.Size(104, 24);
			this.SaveToolStripMenuItem.Text = "Save";
			this.SaveToolStripMenuItem.Visible = false;
			this.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem";
			this.SaveAsToolStripMenuItem.Size = new global::System.Drawing.Size(104, 24);
			this.SaveAsToolStripMenuItem.Text = "Save As";
			this.SaveAsToolStripMenuItem.Visible = false;
			this.DataGridView1.AllowUserToAddRows = false;
			this.DataGridView1.AllowUserToDeleteRows = false;
			this.DataGridView1.AllowUserToResizeColumns = false;
			this.DataGridView1.AllowUserToResizeRows = false;
			this.DataGridView1.AutoSizeColumnsMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.DataGridView1.AutoSizeRowsMode = global::System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.DataGridView1.BackgroundColor = global::System.Drawing.Color.Black;
			this.DataGridView1.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DataGridView1.Columns.AddRange(new global::System.Windows.Forms.DataGridViewColumn[]
			{
				this.appnam,
				this.texts
			});
			this.DataGridView1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.DataGridView1.Location = new global::System.Drawing.Point(0, 0);
			this.DataGridView1.Margin = new global::System.Windows.Forms.Padding(4);
			this.DataGridView1.Name = "DataGridView1";
			this.DataGridView1.RowHeadersVisible = false;
			this.DataGridView1.ShowCellErrors = false;
			this.DataGridView1.ShowCellToolTips = false;
			this.DataGridView1.ShowEditingIcon = false;
			this.DataGridView1.ShowRowErrors = false;
			this.DataGridView1.Size = new global::System.Drawing.Size(1047, 449);
			this.DataGridView1.TabIndex = 1;
			this.appnam.HeaderText = "App Name";
			this.appnam.Name = "appnam";
			this.appnam.Width = 135;
			this.texts.HeaderText = "Text";
			this.texts.Name = "texts";
			this.texts.Width = 75;
			this.Panel1.Controls.Add(this.loadinglogs);
			this.Panel1.Controls.Add(this.deleteallbtn);
			this.Panel1.Controls.Add(this.backallbtn);
			this.Panel1.Controls.Add(this.combologs);
			this.Panel1.Controls.Add(this.delbtn);
			this.Panel1.Controls.Add(this.savedbtn);
			this.Panel1.Controls.Add(this.getbtn);
			this.Panel1.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.Panel1.Location = new global::System.Drawing.Point(0, 449);
			this.Panel1.Margin = new global::System.Windows.Forms.Padding(4);
			this.Panel1.Name = "Panel1";
			this.Panel1.Size = new global::System.Drawing.Size(1047, 44);
			this.Panel1.TabIndex = 3;
			this.deleteallbtn.Dock = global::System.Windows.Forms.DockStyle.Right;
			this.deleteallbtn.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.deleteallbtn.Font = new global::System.Drawing.Font("Roboto", 9f);
			this.deleteallbtn.ForeColor = global::System.Drawing.Color.FromArgb(157, 5, 17);
			this.deleteallbtn.Location = new global::System.Drawing.Point(776, 0);
			this.deleteallbtn.Margin = new global::System.Windows.Forms.Padding(4);
			this.deleteallbtn.Name = "deleteallbtn";
			this.deleteallbtn.Size = new global::System.Drawing.Size(99, 44);
			this.deleteallbtn.TabIndex = 8;
			this.deleteallbtn.Text = "Delete all";
			this.deleteallbtn.UseVisualStyleBackColor = true;
			this.backallbtn.Dock = global::System.Windows.Forms.DockStyle.Right;
			this.backallbtn.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.backallbtn.Font = new global::System.Drawing.Font("Roboto", 9f);
			this.backallbtn.ForeColor = global::System.Drawing.Color.FromArgb(157, 5, 17);
			this.backallbtn.Location = new global::System.Drawing.Point(875, 0);
			this.backallbtn.Margin = new global::System.Windows.Forms.Padding(4);
			this.backallbtn.Name = "backallbtn";
			this.backallbtn.Size = new global::System.Drawing.Size(99, 44);
			this.backallbtn.TabIndex = 7;
			this.backallbtn.Text = "Backup all";
			this.backallbtn.UseVisualStyleBackColor = true;
			this.delbtn.Dock = global::System.Windows.Forms.DockStyle.Left;
			this.delbtn.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.delbtn.Font = new global::System.Drawing.Font("Roboto", 9f);
			this.delbtn.ForeColor = global::System.Drawing.Color.FromArgb(157, 5, 17);
			this.delbtn.Location = new global::System.Drawing.Point(114, 0);
			this.delbtn.Margin = new global::System.Windows.Forms.Padding(4);
			this.delbtn.Name = "delbtn";
			this.delbtn.Size = new global::System.Drawing.Size(126, 44);
			this.delbtn.TabIndex = 6;
			this.delbtn.Text = "Delete Selected";
			this.delbtn.UseVisualStyleBackColor = true;
			this.savedbtn.Dock = global::System.Windows.Forms.DockStyle.Right;
			this.savedbtn.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.savedbtn.Font = new global::System.Drawing.Font("Roboto", 9f);
			this.savedbtn.ForeColor = global::System.Drawing.Color.FromArgb(157, 5, 17);
			this.savedbtn.Location = new global::System.Drawing.Point(974, 0);
			this.savedbtn.Margin = new global::System.Windows.Forms.Padding(4);
			this.savedbtn.Name = "savedbtn";
			this.savedbtn.Size = new global::System.Drawing.Size(73, 44);
			this.savedbtn.TabIndex = 5;
			this.savedbtn.Text = "Saved";
			this.savedbtn.UseVisualStyleBackColor = true;
			this.loadinglogs.BackColor = global::System.Drawing.Color.Transparent;
			this.loadinglogs.Dock = global::System.Windows.Forms.DockStyle.Right;
			this.loadinglogs.Enabled = false;
			this.loadinglogs.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f);
			this.loadinglogs.ForeColor = global::System.Drawing.Color.FromArgb(157, 5, 17);
			this.loadinglogs.Location = new global::System.Drawing.Point(736, 0);
			this.loadinglogs.Margin = new global::System.Windows.Forms.Padding(4);
			this.loadinglogs.Name = "loadinglogs";
			this.loadinglogs.Size = new global::System.Drawing.Size(40, 44);
			this.loadinglogs.Style = global::DrakeUI.Framework.UIStyle.Custom;
			this.loadinglogs.StyleCustomMode = true;
			this.loadinglogs.TabIndex = 4;
			this.loadinglogs.Text = "DrakeUILoadingBar1";
			this.loadinglogs.Visible = false;
			this.getbtn.Dock = global::System.Windows.Forms.DockStyle.Left;
			this.getbtn.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.getbtn.Font = new global::System.Drawing.Font("Roboto", 9f);
			this.getbtn.ForeColor = global::System.Drawing.Color.FromArgb(157, 5, 17);
			this.getbtn.Location = new global::System.Drawing.Point(0, 0);
			this.getbtn.Margin = new global::System.Windows.Forms.Padding(4);
			this.getbtn.Name = "getbtn";
			this.getbtn.Size = new global::System.Drawing.Size(114, 44);
			this.getbtn.TabIndex = 0;
			this.getbtn.Text = "Get Selected";
			this.getbtn.UseVisualStyleBackColor = true;
			this.combologs.AllowDrop = true;
			this.combologs.ArrowColor = global::System.Drawing.Color.FromArgb(110, 110, 110);
			this.combologs.BackColor = global::System.Drawing.Color.Transparent;
			this.combologs.BackgroundColor = global::System.Drawing.Color.FromArgb(34, 34, 34);
			this.combologs.BorderColor = global::System.Drawing.Color.FromArgb(110, 110, 110);
			this.combologs.CausesValidation = false;
			this.combologs.DisabledBackColor = global::System.Drawing.Color.FromArgb(80, 80, 80);
			this.combologs.DisabledBorderColor = global::System.Drawing.Color.FromArgb(109, 109, 109);
			this.combologs.DisabledForeColor = global::System.Drawing.Color.FromArgb(109, 109, 109);
			this.combologs.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.combologs.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.combologs.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.combologs.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 11f);
			this.combologs.FormattingEnabled = true;
			this.combologs.IsDerivedStyle = true;
			this.combologs.ItemHeight = 20;
			this.combologs.Location = new global::System.Drawing.Point(248, 10);
			this.combologs.Margin = new global::System.Windows.Forms.Padding(4);
			this.combologs.Name = "combologs";
			this.combologs.SelectedItemBackColor = global::System.Drawing.Color.FromArgb(65, 177, 225);
			this.combologs.SelectedItemForeColor = global::System.Drawing.Color.White;
			this.combologs.Size = new global::System.Drawing.Size(480, 26);
			this.combologs.Style = global::MetroSet_UI.Enums.Style.Dark;
			this.combologs.StyleManager = null;
			this.combologs.TabIndex = 2;
			this.combologs.ThemeAuthor = "Narwin";
			this.combologs.ThemeName = "MetroDark";
			this.Button2.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.Button2.ForeColor = global::System.Drawing.Color.Cyan;
			this.Button2.Location = new global::System.Drawing.Point(816, 190);
			this.Button2.Margin = new global::System.Windows.Forms.Padding(4);
			this.Button2.Name = "Button2";
			this.Button2.Size = new global::System.Drawing.Size(169, 32);
			this.Button2.TabIndex = 3;
			this.Button2.Text = "Delete log";
			this.Button2.UseVisualStyleBackColor = true;
			this.Button2.Visible = false;
			this.keytabs.Controls.Add(this.TabPage3);
			this.keytabs.Controls.Add(this.TabPage4);
			this.keytabs.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.keytabs.DrawMode = global::System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
			this.keytabs.FillColor = global::System.Drawing.Color.Black;
			this.keytabs.Font = new global::System.Drawing.Font("Segoe UI", 12f);
			this.keytabs.ItemSize = new global::System.Drawing.Size(470, 40);
			this.keytabs.Location = new global::System.Drawing.Point(0, 0);
			this.keytabs.Margin = new global::System.Windows.Forms.Padding(4);
			this.keytabs.MenuStyle = global::DrakeUI.Framework.UIMenuStyle.Custom;
			this.keytabs.Name = "keytabs";
			this.keytabs.RightToLeft = global::System.Windows.Forms.RightToLeft.No;
			this.keytabs.SelectedIndex = 0;
			this.keytabs.Size = new global::System.Drawing.Size(1047, 533);
			this.keytabs.SizeMode = global::System.Windows.Forms.TabSizeMode.Fixed;
			this.keytabs.Style = global::DrakeUI.Framework.UIStyle.Custom;
			this.keytabs.StyleCustomMode = true;
			this.keytabs.TabBackColor = global::System.Drawing.Color.Black;
			this.keytabs.TabIndex = 4;
			this.keytabs.TabSelectedColor = global::System.Drawing.Color.Black;
			this.keytabs.TabSelectedForeColor = global::System.Drawing.Color.FromArgb(157, 5, 17);
			this.keytabs.TabSelectedHighColor = global::System.Drawing.Color.FromArgb(157, 5, 17);
			this.keytabs.TabUnSelectedForeColor = global::System.Drawing.Color.FromArgb(240, 240, 240);
			this.TabPage3.BackColor = global::System.Drawing.Color.Black;
			this.TabPage3.Controls.Add(this.DGV0);
			this.TabPage3.Location = new global::System.Drawing.Point(0, 40);
			this.TabPage3.Margin = new global::System.Windows.Forms.Padding(4);
			this.TabPage3.Name = "TabPage3";
			this.TabPage3.Size = new global::System.Drawing.Size(1047, 493);
			this.TabPage3.TabIndex = 0;
			this.TabPage3.Text = "Online Keylogger";
			this.TabPage4.BackColor = global::System.Drawing.Color.Black;
			this.TabPage4.Controls.Add(this.DataGridView1);
			this.TabPage4.Controls.Add(this.Panel1);
			this.TabPage4.Controls.Add(this.Button2);
			this.TabPage4.Location = new global::System.Drawing.Point(0, 40);
			this.TabPage4.Margin = new global::System.Windows.Forms.Padding(4);
			this.TabPage4.Name = "TabPage4";
			this.TabPage4.Size = new global::System.Drawing.Size(1047, 493);
			this.TabPage4.TabIndex = 1;
			this.TabPage4.Text = "Offline Keylogger";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(8f, 16f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(1047, 533);
			base.Controls.Add(this.keytabs);
			base.Margin = new global::System.Windows.Forms.Padding(4);
			this.MinimumSize = new global::System.Drawing.Size(1065, 570);
			base.Name = "Keylogger";
			base.Opacity = 0.0;
			this.Text = "Keylogger";
			((global::System.ComponentModel.ISupportInitialize)this.DGV0).EndInit();
			this.ctxMenu.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.DataGridView1).EndInit();
			this.Panel1.ResumeLayout(false);
			this.keytabs.ResumeLayout(false);
			this.TabPage3.ResumeLayout(false);
			this.TabPage4.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x040008CE RID: 2254
		private global::System.ComponentModel.Container components;
	}
}
