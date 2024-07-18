namespace Craxs_Rat
{
	// Token: 0x0200002F RID: 47
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class dia : global::System.Windows.Forms.Form
	{
		// Token: 0x06000337 RID: 823 RVA: 0x0001CE54 File Offset: 0x0001B054
		protected override void Dispose(bool disposing)
		{
			try
			{
				if (disposing && this.components != null)
				{
					this.components.Dispose();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		// Token: 0x06000338 RID: 824 RVA: 0x0001CE98 File Offset: 0x0001B098
		private void InitializeComponent()
		{
			this.TableLayoutPanel1 = new global::System.Windows.Forms.TableLayoutPanel();
			this.OK_Button = new global::System.Windows.Forms.Button();
			this.Cancel_Button = new global::System.Windows.Forms.Button();
			this.NewKey = new global::MetroSet_UI.Controls.MetroSetTextBox();
			this.Label2 = new global::System.Windows.Forms.Label();
			this.TableLayoutPanel1.SuspendLayout();
			base.SuspendLayout();
			this.TableLayoutPanel1.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.TableLayoutPanel1.ColumnCount = 2;
			this.TableLayoutPanel1.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Percent, 50f));
			this.TableLayoutPanel1.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Percent, 50f));
			this.TableLayoutPanel1.Controls.Add(this.OK_Button, 0, 0);
			this.TableLayoutPanel1.Controls.Add(this.Cancel_Button, 1, 0);
			this.TableLayoutPanel1.Location = new global::System.Drawing.Point(12, 80);
			this.TableLayoutPanel1.Name = "TableLayoutPanel1";
			this.TableLayoutPanel1.RowCount = 1;
			this.TableLayoutPanel1.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Percent, 50f));
			this.TableLayoutPanel1.Size = new global::System.Drawing.Size(484, 41);
			this.TableLayoutPanel1.TabIndex = 0;
			this.OK_Button.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.OK_Button.FlatAppearance.BorderSize = 0;
			this.OK_Button.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.OK_Button.Font = new global::System.Drawing.Font("Palatino Linotype", 10f);
			this.OK_Button.ForeColor = global::System.Drawing.Color.FromArgb(95, 95, 250);
			this.OK_Button.Location = new global::System.Drawing.Point(3, 3);
			this.OK_Button.Name = "OK_Button";
			this.OK_Button.Size = new global::System.Drawing.Size(236, 35);
			this.OK_Button.TabIndex = 0;
			this.OK_Button.Text = "OK";
			this.Cancel_Button.DialogResult = global::System.Windows.Forms.DialogResult.Cancel;
			this.Cancel_Button.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.Cancel_Button.FlatAppearance.BorderSize = 0;
			this.Cancel_Button.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.Cancel_Button.Font = new global::System.Drawing.Font("Palatino Linotype", 10f);
			this.Cancel_Button.ForeColor = global::System.Drawing.Color.FromArgb(95, 95, 250);
			this.Cancel_Button.Location = new global::System.Drawing.Point(245, 3);
			this.Cancel_Button.Name = "Cancel_Button";
			this.Cancel_Button.Size = new global::System.Drawing.Size(236, 35);
			this.Cancel_Button.TabIndex = 1;
			this.Cancel_Button.Text = "Cancel";
			this.NewKey.AutoCompleteCustomSource = null;
			this.NewKey.AutoCompleteMode = global::System.Windows.Forms.AutoCompleteMode.None;
			this.NewKey.AutoCompleteSource = global::System.Windows.Forms.AutoCompleteSource.None;
			this.NewKey.BorderColor = global::System.Drawing.Color.FromArgb(155, 155, 155);
			this.NewKey.DisabledBackColor = global::System.Drawing.Color.FromArgb(204, 204, 204);
			this.NewKey.DisabledBorderColor = global::System.Drawing.Color.FromArgb(155, 155, 155);
			this.NewKey.DisabledForeColor = global::System.Drawing.Color.FromArgb(136, 136, 136);
			this.NewKey.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 10f);
			this.NewKey.HoverColor = global::System.Drawing.Color.FromArgb(102, 102, 102);
			this.NewKey.Image = null;
			this.NewKey.IsDerivedStyle = true;
			this.NewKey.Lines = null;
			this.NewKey.Location = new global::System.Drawing.Point(12, 52);
			this.NewKey.MaxLength = 32767;
			this.NewKey.Multiline = false;
			this.NewKey.Name = "NewKey";
			this.NewKey.ReadOnly = false;
			this.NewKey.Size = new global::System.Drawing.Size(484, 22);
			this.NewKey.Style = global::MetroSet_UI.Enums.Style.Light;
			this.NewKey.StyleManager = null;
			this.NewKey.TabIndex = 1;
			this.NewKey.Text = "Enter New Key";
			this.NewKey.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.NewKey.ThemeAuthor = "Narwin";
			this.NewKey.ThemeName = "MetroLite";
			this.NewKey.UseSystemPasswordChar = false;
			this.NewKey.WatermarkText = "";
			this.Label2.AutoSize = true;
			this.Label2.BackColor = global::System.Drawing.Color.Transparent;
			this.Label2.Font = new global::System.Drawing.Font("Palatino Linotype", 30f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label2.ForeColor = global::System.Drawing.Color.FromArgb(95, 95, 250);
			this.Label2.Location = new global::System.Drawing.Point(7, -6);
			this.Label2.Name = "Label2";
			this.Label2.Size = new global::System.Drawing.Size(489, 55);
			this.Label2.TabIndex = 5;
			this.Label2.Text = "Your License Has Expired";
			base.AcceptButton = this.OK_Button;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.FromArgb(50, 50, 50);
			base.CancelButton = this.Cancel_Button;
			base.ClientSize = new global::System.Drawing.Size(511, 133);
			base.ControlBox = false;
			base.Controls.Add(this.Label2);
			base.Controls.Add(this.NewKey);
			base.Controls.Add(this.TableLayoutPanel1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "dia";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.TableLayoutPanel1.ResumeLayout(false);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000179 RID: 377
		private global::System.IDisposable components;
	}
}
