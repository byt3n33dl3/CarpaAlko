namespace Craxs_Rat
{
	// Token: 0x020000CD RID: 205
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class SelfRemove : global::System.Windows.Forms.Form
	{
		// Token: 0x06000F42 RID: 3906 RVA: 0x000A1150 File Offset: 0x0009F350
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

		// Token: 0x06000F43 RID: 3907 RVA: 0x000A1194 File Offset: 0x0009F394
		private void InitializeComponent()
		{
			this.Label34 = new global::System.Windows.Forms.Label();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.Label2 = new global::System.Windows.Forms.Label();
			this.DrakeUIButtonIcon1 = new global::DrakeUI.Framework.DrakeUIButtonIcon();
			this.clientpic = new global::System.Windows.Forms.PictureBox();
			this.checkrecords = new global::DrakeUI.Framework.DrakeUICheckBox();
			this.checkkeylogs = new global::DrakeUI.Framework.DrakeUICheckBox();
			this.checktouch = new global::DrakeUI.Framework.DrakeUICheckBox();
			((global::System.ComponentModel.ISupportInitialize)this.clientpic).BeginInit();
			base.SuspendLayout();
			this.Label34.AutoSize = true;
			this.Label34.BackColor = global::System.Drawing.Color.Transparent;
			this.Label34.Font = new global::System.Drawing.Font("Roboto", 15f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label34.ForeColor = global::System.Drawing.Color.White;
			this.Label34.Location = new global::System.Drawing.Point(99, 143);
			this.Label34.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label34.Name = "Label34";
			this.Label34.Size = new global::System.Drawing.Size(205, 30);
			this.Label34.TabIndex = 66;
			this.Label34.Text = "Remove Records";
			this.Label1.AutoSize = true;
			this.Label1.BackColor = global::System.Drawing.Color.Transparent;
			this.Label1.Font = new global::System.Drawing.Font("Roboto", 15f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label1.ForeColor = global::System.Drawing.Color.White;
			this.Label1.Location = new global::System.Drawing.Point(99, 212);
			this.Label1.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label1.Name = "Label1";
			this.Label1.Size = new global::System.Drawing.Size(200, 30);
			this.Label1.TabIndex = 68;
			this.Label1.Text = "Remove keylogs";
			this.Label2.AutoSize = true;
			this.Label2.BackColor = global::System.Drawing.Color.Transparent;
			this.Label2.Font = new global::System.Drawing.Font("Roboto", 15f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label2.ForeColor = global::System.Drawing.Color.White;
			this.Label2.Location = new global::System.Drawing.Point(99, 279);
			this.Label2.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label2.Name = "Label2";
			this.Label2.Size = new global::System.Drawing.Size(202, 30);
			this.Label2.TabIndex = 70;
			this.Label2.Text = "Remove touches";
			this.DrakeUIButtonIcon1.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.DrakeUIButtonIcon1.FillColor = global::System.Drawing.Color.Black;
			this.DrakeUIButtonIcon1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f);
			this.DrakeUIButtonIcon1.ForeColor = global::System.Drawing.Color.FromArgb(195, 18, 9);
			this.DrakeUIButtonIcon1.Location = new global::System.Drawing.Point(22, 359);
			this.DrakeUIButtonIcon1.Name = "DrakeUIButtonIcon1";
			this.DrakeUIButtonIcon1.RectColor = global::System.Drawing.Color.FromArgb(195, 18, 9);
			this.DrakeUIButtonIcon1.RectDisableColor = global::System.Drawing.Color.FromArgb(227, 242, 253);
			this.DrakeUIButtonIcon1.Size = new global::System.Drawing.Size(277, 35);
			this.DrakeUIButtonIcon1.Style = global::DrakeUI.Framework.UIStyle.Custom;
			this.DrakeUIButtonIcon1.Symbol = 61546;
			this.DrakeUIButtonIcon1.TabIndex = 71;
			this.DrakeUIButtonIcon1.Text = "Start Remove";
			this.clientpic.Location = new global::System.Drawing.Point(120, 27);
			this.clientpic.Name = "clientpic";
			this.clientpic.Size = new global::System.Drawing.Size(97, 81);
			this.clientpic.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.clientpic.TabIndex = 72;
			this.clientpic.TabStop = false;
			this.checkrecords.CheckBoxColor = global::System.Drawing.Color.FromArgb(30, 136, 229);
			this.checkrecords.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.checkrecords.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f);
			this.checkrecords.Location = new global::System.Drawing.Point(22, 144);
			this.checkrecords.Name = "checkrecords";
			this.checkrecords.Padding = new global::System.Windows.Forms.Padding(22, 0, 0, 0);
			this.checkrecords.Size = new global::System.Drawing.Size(45, 29);
			this.checkrecords.TabIndex = 73;
			this.checkkeylogs.CheckBoxColor = global::System.Drawing.Color.FromArgb(30, 136, 229);
			this.checkkeylogs.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.checkkeylogs.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f);
			this.checkkeylogs.Location = new global::System.Drawing.Point(22, 213);
			this.checkkeylogs.Name = "checkkeylogs";
			this.checkkeylogs.Padding = new global::System.Windows.Forms.Padding(22, 0, 0, 0);
			this.checkkeylogs.Size = new global::System.Drawing.Size(45, 29);
			this.checkkeylogs.TabIndex = 74;
			this.checktouch.CheckBoxColor = global::System.Drawing.Color.FromArgb(30, 136, 229);
			this.checktouch.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.checktouch.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f);
			this.checktouch.Location = new global::System.Drawing.Point(22, 280);
			this.checktouch.Name = "checktouch";
			this.checktouch.Padding = new global::System.Windows.Forms.Padding(22, 0, 0, 0);
			this.checktouch.Size = new global::System.Drawing.Size(45, 29);
			this.checktouch.TabIndex = 75;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(8f, 16f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.Black;
			base.ClientSize = new global::System.Drawing.Size(328, 424);
			base.Controls.Add(this.checktouch);
			base.Controls.Add(this.checkkeylogs);
			base.Controls.Add(this.checkrecords);
			base.Controls.Add(this.clientpic);
			base.Controls.Add(this.DrakeUIButtonIcon1);
			base.Controls.Add(this.Label2);
			base.Controls.Add(this.Label1);
			base.Controls.Add(this.Label34);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			base.Name = "SelfRemove";
			base.ShowIcon = false;
			this.Text = "Self Remove";
			base.TopMost = true;
			((global::System.ComponentModel.ISupportInitialize)this.clientpic).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000862 RID: 2146
		private global::System.IDisposable components;
	}
}
