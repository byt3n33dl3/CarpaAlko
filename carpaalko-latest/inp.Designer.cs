namespace Craxs_Rat
{
	// Token: 0x020000D5 RID: 213
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class inp : global::System.Windows.Forms.Form
	{
		// Token: 0x0600100E RID: 4110 RVA: 0x000AB484 File Offset: 0x000A9684
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

		// Token: 0x0600100F RID: 4111 RVA: 0x000AB4C8 File Offset: 0x000A96C8
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			this.Panel1 = new global::System.Windows.Forms.Panel();
			this.BOXX = new global::System.Windows.Forms.Panel();
			this.CheckHidden = new global::System.Windows.Forms.CheckBox();
			this.CheckFolder = new global::System.Windows.Forms.CheckBox();
			this.b_ok = new global::System.Windows.Forms.Button();
			this.InputText = new global::System.Windows.Forms.TextBox();
			this.LTitle = new global::System.Windows.Forms.Label();
			this.TOpacity = new global::System.Windows.Forms.Timer(this.components);
			this.Panel1.SuspendLayout();
			this.BOXX.SuspendLayout();
			base.SuspendLayout();
			this.Panel1.BackColor = global::System.Drawing.Color.Black;
			this.Panel1.Controls.Add(this.BOXX);
			this.Panel1.Controls.Add(this.b_ok);
			this.Panel1.Controls.Add(this.InputText);
			this.Panel1.Controls.Add(this.LTitle);
			this.Panel1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.Panel1.ForeColor = global::System.Drawing.Color.FromArgb(190, 190, 190);
			this.Panel1.Location = new global::System.Drawing.Point(0, 0);
			this.Panel1.Name = "Panel1";
			this.Panel1.Size = new global::System.Drawing.Size(432, 130);
			this.Panel1.TabIndex = 0;
			this.BOXX.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.BOXX.Controls.Add(this.CheckHidden);
			this.BOXX.Controls.Add(this.CheckFolder);
			this.BOXX.Location = new global::System.Drawing.Point(12, 95);
			this.BOXX.Name = "BOXX";
			this.BOXX.Size = new global::System.Drawing.Size(326, 23);
			this.BOXX.TabIndex = 4;
			this.BOXX.Visible = false;
			this.CheckHidden.AutoSize = true;
			this.CheckHidden.Dock = global::System.Windows.Forms.DockStyle.Right;
			this.CheckHidden.Location = new global::System.Drawing.Point(212, 0);
			this.CheckHidden.Name = "CheckHidden";
			this.CheckHidden.Size = new global::System.Drawing.Size(58, 23);
			this.CheckHidden.TabIndex = 1;
			this.CheckHidden.Text = "hidden";
			this.CheckHidden.UseVisualStyleBackColor = true;
			this.CheckFolder.AutoSize = true;
			this.CheckFolder.Dock = global::System.Windows.Forms.DockStyle.Right;
			this.CheckFolder.Location = new global::System.Drawing.Point(270, 0);
			this.CheckFolder.Name = "CheckFolder";
			this.CheckFolder.Size = new global::System.Drawing.Size(56, 23);
			this.CheckFolder.TabIndex = 0;
			this.CheckFolder.Text = "Folder";
			this.CheckFolder.UseVisualStyleBackColor = true;
			this.b_ok.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.b_ok.BackColor = global::System.Drawing.Color.FromArgb(190, 190, 190);
			this.b_ok.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.b_ok.ForeColor = global::System.Drawing.Color.Black;
			this.b_ok.Location = new global::System.Drawing.Point(353, 95);
			this.b_ok.Name = "b_ok";
			this.b_ok.Size = new global::System.Drawing.Size(67, 23);
			this.b_ok.TabIndex = 3;
			this.b_ok.Text = "OK";
			this.b_ok.UseVisualStyleBackColor = false;
			this.InputText.BackColor = global::System.Drawing.Color.Black;
			this.InputText.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.InputText.ForeColor = global::System.Drawing.Color.FromArgb(190, 190, 190);
			this.InputText.Location = new global::System.Drawing.Point(12, 56);
			this.InputText.Name = "InputText";
			this.InputText.Size = new global::System.Drawing.Size(408, 13);
			this.InputText.TabIndex = 2;
			this.LTitle.AutoSize = true;
			this.LTitle.Location = new global::System.Drawing.Point(12, 23);
			this.LTitle.Name = "LTitle";
			this.LTitle.Size = new global::System.Drawing.Size(23, 13);
			this.LTitle.TabIndex = 1;
			this.LTitle.Text = "null";
			this.TOpacity.Interval = 1;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(432, 130);
			base.Controls.Add(this.Panel1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "inp";
			base.Opacity = 0.0;
			base.ShowInTaskbar = false;
			this.Text = "inp";
			this.Panel1.ResumeLayout(false);
			this.Panel1.PerformLayout();
			this.BOXX.ResumeLayout(false);
			this.BOXX.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x040008C4 RID: 2244
		private global::System.ComponentModel.Container components;
	}
}
