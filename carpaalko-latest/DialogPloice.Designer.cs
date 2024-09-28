namespace Craxs_Rat
{
	// Token: 0x020000B2 RID: 178
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class DialogPloice : global::System.Windows.Forms.Form
	{
		// Token: 0x06000BB3 RID: 2995 RVA: 0x0007BE40 File Offset: 0x0007A040
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

		// Token: 0x06000BB4 RID: 2996 RVA: 0x0007BE84 File Offset: 0x0007A084
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			this.TableLayoutPanel1 = new global::System.Windows.Forms.TableLayoutPanel();
			this.OK_Button = new global::System.Windows.Forms.Button();
			this.Cancel_Button = new global::System.Windows.Forms.Button();
			this.MainText = new global::System.Windows.Forms.TextBox();
			this.Button1 = new global::System.Windows.Forms.Button();
			this.Button2 = new global::System.Windows.Forms.Button();
			this.Acccheck = new global::System.Windows.Forms.CheckBox();
			this.Timer1 = new global::System.Windows.Forms.Timer(this.components);
			this.TableLayoutPanel1.SuspendLayout();
			base.SuspendLayout();
			this.TableLayoutPanel1.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.TableLayoutPanel1.ColumnCount = 2;
			this.TableLayoutPanel1.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Percent, 50f));
			this.TableLayoutPanel1.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Percent, 50f));
			this.TableLayoutPanel1.Controls.Add(this.OK_Button, 0, 0);
			this.TableLayoutPanel1.Controls.Add(this.Cancel_Button, 1, 0);
			this.TableLayoutPanel1.Location = new global::System.Drawing.Point(218, 297);
			this.TableLayoutPanel1.Name = "TableLayoutPanel1";
			this.TableLayoutPanel1.RowCount = 1;
			this.TableLayoutPanel1.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Percent, 50f));
			this.TableLayoutPanel1.Size = new global::System.Drawing.Size(205, 37);
			this.TableLayoutPanel1.TabIndex = 0;
			this.OK_Button.Anchor = global::System.Windows.Forms.AnchorStyles.None;
			this.OK_Button.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.OK_Button.Location = new global::System.Drawing.Point(17, 7);
			this.OK_Button.Name = "OK_Button";
			this.OK_Button.Size = new global::System.Drawing.Size(67, 23);
			this.OK_Button.TabIndex = 0;
			this.OK_Button.Text = "OK";
			this.Cancel_Button.Anchor = global::System.Windows.Forms.AnchorStyles.None;
			this.Cancel_Button.DialogResult = global::System.Windows.Forms.DialogResult.Cancel;
			this.Cancel_Button.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.Cancel_Button.Location = new global::System.Drawing.Point(120, 7);
			this.Cancel_Button.Name = "Cancel_Button";
			this.Cancel_Button.Size = new global::System.Drawing.Size(67, 23);
			this.Cancel_Button.TabIndex = 1;
			this.Cancel_Button.Text = "Cancel";
			this.MainText.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.MainText.Location = new global::System.Drawing.Point(12, 40);
			this.MainText.Multiline = true;
			this.MainText.Name = "MainText";
			this.MainText.Size = new global::System.Drawing.Size(411, 228);
			this.MainText.TabIndex = 1;
			this.Button1.Location = new global::System.Drawing.Point(12, 2);
			this.Button1.Name = "Button1";
			this.Button1.Size = new global::System.Drawing.Size(205, 32);
			this.Button1.TabIndex = 2;
			this.Button1.Text = "English";
			this.Button1.UseVisualStyleBackColor = true;
			this.Button2.Location = new global::System.Drawing.Point(218, 2);
			this.Button2.Name = "Button2";
			this.Button2.Size = new global::System.Drawing.Size(205, 32);
			this.Button2.TabIndex = 3;
			this.Button2.Text = "العربية";
			this.Button2.UseVisualStyleBackColor = true;
			this.Acccheck.AutoSize = true;
			this.Acccheck.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Acccheck.Location = new global::System.Drawing.Point(12, 274);
			this.Acccheck.Name = "Acccheck";
			this.Acccheck.Size = new global::System.Drawing.Size(246, 17);
			this.Acccheck.TabIndex = 4;
			this.Acccheck.Text = "I read all text above, And Accepted All";
			this.Acccheck.UseVisualStyleBackColor = true;
			this.Timer1.Interval = 1000;
			base.AcceptButton = this.OK_Button;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.CancelButton = this.Cancel_Button;
			base.ClientSize = new global::System.Drawing.Size(435, 336);
			base.Controls.Add(this.Acccheck);
			base.Controls.Add(this.Button2);
			base.Controls.Add(this.Button1);
			base.Controls.Add(this.MainText);
			base.Controls.Add(this.TableLayoutPanel1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedDialog;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "DialogPloice";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = " Privacy Policy & Terms of Service";
			base.TopMost = true;
			this.TableLayoutPanel1.ResumeLayout(false);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0400067D RID: 1661
		private global::System.ComponentModel.Container components;
	}
}
