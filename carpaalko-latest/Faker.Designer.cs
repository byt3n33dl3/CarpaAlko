namespace Craxs_Rat
{
	// Token: 0x020000B7 RID: 183
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class Faker : global::System.Windows.Forms.Form
	{
		// Token: 0x06000C4A RID: 3146 RVA: 0x000804D8 File Offset: 0x0007E6D8
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

		// Token: 0x06000C4B RID: 3147 RVA: 0x0008051C File Offset: 0x0007E71C
		private void InitializeComponent()
		{
			this.DataGridView1 = new global::System.Windows.Forms.DataGridView();
			this.plat = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.n = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.pass = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.platfromtext = new global::MetroSet_UI.Controls.MetroSetComboBox();
			this.Label2 = new global::System.Windows.Forms.Label();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.Checkalert = new global::MetroSet_UI.Controls.MetroSetSwitch();
			this.MetroSetButton1 = new global::MetroSet_UI.Controls.MetroSetButton();
			((global::System.ComponentModel.ISupportInitialize)this.DataGridView1).BeginInit();
			base.SuspendLayout();
			this.DataGridView1.AutoSizeColumnsMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.DataGridView1.AutoSizeRowsMode = global::System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.DataGridView1.BackgroundColor = global::System.Drawing.Color.FromArgb(10, 0, 10);
			this.DataGridView1.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DataGridView1.Columns.AddRange(new global::System.Windows.Forms.DataGridViewColumn[]
			{
				this.plat,
				this.n,
				this.pass
			});
			this.DataGridView1.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.DataGridView1.Location = new global::System.Drawing.Point(0, 104);
			this.DataGridView1.Name = "DataGridView1";
			this.DataGridView1.RowHeadersVisible = false;
			this.DataGridView1.Size = new global::System.Drawing.Size(354, 214);
			this.DataGridView1.TabIndex = 0;
			this.plat.HeaderText = "Platform";
			this.plat.Name = "plat";
			this.n.HeaderText = "User Name";
			this.n.Name = "n";
			this.pass.HeaderText = "Password";
			this.pass.Name = "pass";
			this.platfromtext.AllowDrop = true;
			this.platfromtext.ArrowColor = global::System.Drawing.Color.FromArgb(110, 110, 110);
			this.platfromtext.BackColor = global::System.Drawing.Color.Transparent;
			this.platfromtext.BackgroundColor = global::System.Drawing.Color.FromArgb(34, 34, 34);
			this.platfromtext.BorderColor = global::System.Drawing.Color.FromArgb(110, 110, 110);
			this.platfromtext.CausesValidation = false;
			this.platfromtext.DisabledBackColor = global::System.Drawing.Color.FromArgb(80, 80, 80);
			this.platfromtext.DisabledBorderColor = global::System.Drawing.Color.FromArgb(109, 109, 109);
			this.platfromtext.DisabledForeColor = global::System.Drawing.Color.FromArgb(109, 109, 109);
			this.platfromtext.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.platfromtext.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.platfromtext.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 11f);
			this.platfromtext.FormattingEnabled = true;
			this.platfromtext.IsDerivedStyle = true;
			this.platfromtext.ItemHeight = 20;
			this.platfromtext.Items.AddRange(new object[]
			{
				"Facebook",
				"Gmail",
				"google authenticator"
			});
			this.platfromtext.Location = new global::System.Drawing.Point(101, 5);
			this.platfromtext.Name = "platfromtext";
			this.platfromtext.SelectedItemBackColor = global::System.Drawing.Color.FromArgb(65, 177, 225);
			this.platfromtext.SelectedItemForeColor = global::System.Drawing.Color.White;
			this.platfromtext.Size = new global::System.Drawing.Size(241, 26);
			this.platfromtext.Style = global::MetroSet_UI.Enums.Style.Dark;
			this.platfromtext.StyleManager = null;
			this.platfromtext.TabIndex = 1;
			this.platfromtext.ThemeAuthor = "Narwin";
			this.platfromtext.ThemeName = "MetroDark";
			this.Label2.AutoSize = true;
			this.Label2.Font = new global::System.Drawing.Font("Palatino Linotype", 10f, global::System.Drawing.FontStyle.Bold);
			this.Label2.ForeColor = global::System.Drawing.Color.FromArgb(95, 95, 250);
			this.Label2.Location = new global::System.Drawing.Point(12, 9);
			this.Label2.Name = "Label2";
			this.Label2.Size = new global::System.Drawing.Size(66, 19);
			this.Label2.TabIndex = 19;
			this.Label2.Text = "Platform";
			this.Label1.AutoSize = true;
			this.Label1.Font = new global::System.Drawing.Font("Palatino Linotype", 10f, global::System.Drawing.FontStyle.Bold);
			this.Label1.ForeColor = global::System.Drawing.Color.FromArgb(95, 95, 250);
			this.Label1.Location = new global::System.Drawing.Point(12, 37);
			this.Label1.Name = "Label1";
			this.Label1.Size = new global::System.Drawing.Size(83, 19);
			this.Label1.TabIndex = 20;
			this.Label1.Text = "Show Alert";
			this.Checkalert.BackColor = global::System.Drawing.Color.Transparent;
			this.Checkalert.BackgroundColor = global::System.Drawing.Color.Empty;
			this.Checkalert.BorderColor = global::System.Drawing.Color.FromArgb(155, 155, 155);
			this.Checkalert.CheckColor = global::System.Drawing.Color.FromArgb(65, 177, 225);
			this.Checkalert.CheckState = global::MetroSet_UI.Enums.CheckState.Unchecked;
			this.Checkalert.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.Checkalert.DisabledBorderColor = global::System.Drawing.Color.FromArgb(85, 85, 85);
			this.Checkalert.DisabledCheckColor = global::System.Drawing.Color.FromArgb(100, 65, 177, 225);
			this.Checkalert.DisabledUnCheckColor = global::System.Drawing.Color.FromArgb(200, 205, 205, 205);
			this.Checkalert.IsDerivedStyle = true;
			this.Checkalert.Location = new global::System.Drawing.Point(101, 37);
			this.Checkalert.Name = "Checkalert";
			this.Checkalert.Size = new global::System.Drawing.Size(58, 22);
			this.Checkalert.Style = global::MetroSet_UI.Enums.Style.Dark;
			this.Checkalert.StyleManager = null;
			this.Checkalert.Switched = false;
			this.Checkalert.SymbolColor = global::System.Drawing.Color.FromArgb(92, 92, 92);
			this.Checkalert.TabIndex = 21;
			this.Checkalert.Text = "MetroSetSwitch1";
			this.Checkalert.ThemeAuthor = "Narwin";
			this.Checkalert.ThemeName = "MetroDark";
			this.Checkalert.UnCheckColor = global::System.Drawing.Color.FromArgb(155, 155, 155);
			this.MetroSetButton1.DisabledBackColor = global::System.Drawing.Color.FromArgb(120, 65, 177, 225);
			this.MetroSetButton1.DisabledBorderColor = global::System.Drawing.Color.FromArgb(120, 65, 177, 225);
			this.MetroSetButton1.DisabledForeColor = global::System.Drawing.Color.Gray;
			this.MetroSetButton1.Font = new global::System.Drawing.Font("Palatino Linotype", 15f, global::System.Drawing.FontStyle.Bold);
			this.MetroSetButton1.HoverBorderColor = global::System.Drawing.Color.FromArgb(95, 207, 255);
			this.MetroSetButton1.HoverColor = global::System.Drawing.Color.FromArgb(95, 207, 255);
			this.MetroSetButton1.HoverTextColor = global::System.Drawing.Color.White;
			this.MetroSetButton1.IsDerivedStyle = true;
			this.MetroSetButton1.Location = new global::System.Drawing.Point(12, 65);
			this.MetroSetButton1.Name = "MetroSetButton1";
			this.MetroSetButton1.NormalBorderColor = global::System.Drawing.Color.FromArgb(65, 177, 225);
			this.MetroSetButton1.NormalColor = global::System.Drawing.Color.FromArgb(65, 177, 225);
			this.MetroSetButton1.NormalTextColor = global::System.Drawing.Color.White;
			this.MetroSetButton1.PressBorderColor = global::System.Drawing.Color.FromArgb(35, 147, 195);
			this.MetroSetButton1.PressColor = global::System.Drawing.Color.FromArgb(35, 147, 195);
			this.MetroSetButton1.PressTextColor = global::System.Drawing.Color.White;
			this.MetroSetButton1.Size = new global::System.Drawing.Size(333, 33);
			this.MetroSetButton1.Style = global::MetroSet_UI.Enums.Style.Dark;
			this.MetroSetButton1.StyleManager = null;
			this.MetroSetButton1.TabIndex = 22;
			this.MetroSetButton1.Text = "Show Form";
			this.MetroSetButton1.ThemeAuthor = "Narwin";
			this.MetroSetButton1.ThemeName = "MetroDark";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.FromArgb(10, 0, 10);
			base.ClientSize = new global::System.Drawing.Size(354, 318);
			base.Controls.Add(this.DataGridView1);
			base.Controls.Add(this.MetroSetButton1);
			base.Controls.Add(this.Checkalert);
			base.Controls.Add(this.Label1);
			base.Controls.Add(this.Label2);
			base.Controls.Add(this.platfromtext);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			base.Name = "Faker";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			this.Text = "Faker";
			((global::System.ComponentModel.ISupportInitialize)this.DataGridView1).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x040006CF RID: 1743
		private global::System.IDisposable components;
	}
}
