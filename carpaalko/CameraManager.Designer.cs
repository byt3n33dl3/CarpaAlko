namespace Craxs_Rat
{
	// Token: 0x020000AA RID: 170
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class CameraManager : global::System.Windows.Forms.Form
	{
		// Token: 0x06000A91 RID: 2705 RVA: 0x000730AC File Offset: 0x000712AC
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

		// Token: 0x06000A92 RID: 2706 RVA: 0x000730F0 File Offset: 0x000712F0
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			this.CAM0 = new global::System.Windows.Forms.PictureBox();
			this.Frames = new global::System.Windows.Forms.Timer(this.components);
			this.TOpacity = new global::System.Windows.Forms.Timer(this.components);
			this.Panel1 = new global::System.Windows.Forms.Panel();
			this.Panel4 = new global::System.Windows.Forms.Panel();
			this.statustext = new global::System.Windows.Forms.Label();
			this.DrakeUILampLED1 = new global::DrakeUI.Framework.DrakeUILampLED();
			this.Label2 = new global::System.Windows.Forms.Label();
			this.cmbofoucs = new global::System.Windows.Forms.ComboBox();
			this.combqulty = new global::System.Windows.Forms.ComboBox();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.Panel2 = new global::System.Windows.Forms.Panel();
			this.qultytext = new global::System.Windows.Forms.Label();
			this.comboqualty = new global::DrakeUI.Framework.DrakeUIComboBox();
			this.combotext = new global::System.Windows.Forms.Label();
			this.combosizes = new global::DrakeUI.Framework.DrakeUIComboBox();
			this.DrakeUIAvatar2 = new global::DrakeUI.Framework.DrakeUIAvatar();
			this.Button3 = new global::DrakeUI.Framework.DrakeUIAvatar();
			this.Bbtn = new global::DrakeUI.Framework.DrakeUIButton();
			this.Sbtn = new global::DrakeUI.Framework.DrakeUIButton();
			this.Fbtn = new global::DrakeUI.Framework.DrakeUIButton();
			this.ClientPic = new global::System.Windows.Forms.PictureBox();
			this.ToolTip1 = new global::System.Windows.Forms.ToolTip(this.components);
			this.DrakeUIToolTip1 = new global::DrakeUI.Framework.DrakeUIToolTip(this.components);
			((global::System.ComponentModel.ISupportInitialize)this.CAM0).BeginInit();
			this.Panel1.SuspendLayout();
			this.Panel4.SuspendLayout();
			this.Panel2.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.ClientPic).BeginInit();
			base.SuspendLayout();
			this.CAM0.BackColor = global::System.Drawing.Color.Black;
			this.CAM0.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.CAM0.Location = new global::System.Drawing.Point(0, 0);
			this.CAM0.Name = "CAM0";
			this.CAM0.Size = new global::System.Drawing.Size(786, 602);
			this.CAM0.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.CAM0.TabIndex = 0;
			this.CAM0.TabStop = false;
			this.Frames.Interval = 1000;
			this.TOpacity.Interval = 1;
			this.Panel1.Controls.Add(this.CAM0);
			this.Panel1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.Panel1.Location = new global::System.Drawing.Point(0, 0);
			this.Panel1.Name = "Panel1";
			this.Panel1.Size = new global::System.Drawing.Size(786, 602);
			this.Panel1.TabIndex = 3;
			this.Panel4.BackColor = global::System.Drawing.Color.Black;
			this.Panel4.Controls.Add(this.statustext);
			this.Panel4.Controls.Add(this.DrakeUILampLED1);
			this.Panel4.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.Panel4.Location = new global::System.Drawing.Point(0, 630);
			this.Panel4.Name = "Panel4";
			this.Panel4.Size = new global::System.Drawing.Size(786, 16);
			this.Panel4.TabIndex = 1;
			this.statustext.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.statustext.Font = new global::System.Drawing.Font("Roboto", 8.7f);
			this.statustext.ForeColor = global::System.Drawing.Color.FromArgb(157, 5, 17);
			this.statustext.Location = new global::System.Drawing.Point(0, 0);
			this.statustext.Name = "statustext";
			this.statustext.Size = new global::System.Drawing.Size(771, 16);
			this.statustext.TabIndex = 15;
			this.statustext.Text = "Select Camera ...";
			this.DrakeUILampLED1.Color = global::System.Drawing.Color.Lime;
			this.DrakeUILampLED1.Dock = global::System.Windows.Forms.DockStyle.Right;
			this.DrakeUILampLED1.Enabled = false;
			this.DrakeUILampLED1.Location = new global::System.Drawing.Point(771, 0);
			this.DrakeUILampLED1.Name = "DrakeUILampLED1";
			this.DrakeUILampLED1.Size = new global::System.Drawing.Size(15, 16);
			this.DrakeUILampLED1.TabIndex = 22;
			this.DrakeUILampLED1.Text = "DrakeUILampLED1";
			this.DrakeUIToolTip1.SetToolTip(this.DrakeUILampLED1, "Saving...");
			this.DrakeUILampLED1.Visible = false;
			this.Label2.AutoSize = true;
			this.Label2.BackColor = global::System.Drawing.Color.FromArgb(10, 10, 10);
			this.Label2.Font = new global::System.Drawing.Font("Palatino Linotype", 10f, global::System.Drawing.FontStyle.Bold);
			this.Label2.ForeColor = global::System.Drawing.Color.FromArgb(95, 95, 250);
			this.Label2.Location = new global::System.Drawing.Point(426, 215);
			this.Label2.Name = "Label2";
			this.Label2.Size = new global::System.Drawing.Size(54, 23);
			this.Label2.TabIndex = 15;
			this.Label2.Text = "Focus";
			this.cmbofoucs.BackColor = global::System.Drawing.Color.Black;
			this.cmbofoucs.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbofoucs.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.cmbofoucs.ForeColor = global::System.Drawing.Color.White;
			this.cmbofoucs.Items.AddRange(new object[]
			{
				"Yes",
				"No"
			});
			this.cmbofoucs.Location = new global::System.Drawing.Point(337, 213);
			this.cmbofoucs.Name = "cmbofoucs";
			this.cmbofoucs.Size = new global::System.Drawing.Size(83, 27);
			this.cmbofoucs.TabIndex = 16;
			this.combqulty.BackColor = global::System.Drawing.Color.Black;
			this.combqulty.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.combqulty.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.combqulty.ForeColor = global::System.Drawing.Color.White;
			this.combqulty.Items.AddRange(new object[]
			{
				"Auto",
				"High Quality"
			});
			this.combqulty.Location = new global::System.Drawing.Point(337, 176);
			this.combqulty.Name = "combqulty";
			this.combqulty.Size = new global::System.Drawing.Size(83, 27);
			this.combqulty.TabIndex = 17;
			this.Label1.AutoSize = true;
			this.Label1.BackColor = global::System.Drawing.Color.FromArgb(10, 10, 10);
			this.Label1.Font = new global::System.Drawing.Font("Palatino Linotype", 10f, global::System.Drawing.FontStyle.Bold);
			this.Label1.ForeColor = global::System.Drawing.Color.FromArgb(95, 95, 250);
			this.Label1.Location = new global::System.Drawing.Point(426, 176);
			this.Label1.Name = "Label1";
			this.Label1.Size = new global::System.Drawing.Size(63, 23);
			this.Label1.TabIndex = 14;
			this.Label1.Text = "Qualty";
			this.Panel2.BackColor = global::System.Drawing.Color.Black;
			this.Panel2.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Zoom;
			this.Panel2.Controls.Add(this.qultytext);
			this.Panel2.Controls.Add(this.comboqualty);
			this.Panel2.Controls.Add(this.combotext);
			this.Panel2.Controls.Add(this.combosizes);
			this.Panel2.Controls.Add(this.DrakeUIAvatar2);
			this.Panel2.Controls.Add(this.Button3);
			this.Panel2.Controls.Add(this.Bbtn);
			this.Panel2.Controls.Add(this.Sbtn);
			this.Panel2.Controls.Add(this.Fbtn);
			this.Panel2.Controls.Add(this.Label2);
			this.Panel2.Controls.Add(this.cmbofoucs);
			this.Panel2.Controls.Add(this.Label1);
			this.Panel2.Controls.Add(this.combqulty);
			this.Panel2.Controls.Add(this.ClientPic);
			this.Panel2.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.Panel2.Location = new global::System.Drawing.Point(0, 602);
			this.Panel2.Name = "Panel2";
			this.Panel2.Size = new global::System.Drawing.Size(786, 28);
			this.Panel2.TabIndex = 1;
			this.qultytext.Dock = global::System.Windows.Forms.DockStyle.Right;
			this.qultytext.Font = new global::System.Drawing.Font("Roboto", 8.7f, global::System.Drawing.FontStyle.Bold);
			this.qultytext.ForeColor = global::System.Drawing.Color.FromArgb(157, 5, 17);
			this.qultytext.Location = new global::System.Drawing.Point(314, 0);
			this.qultytext.Name = "qultytext";
			this.qultytext.Size = new global::System.Drawing.Size(78, 28);
			this.qultytext.TabIndex = 42;
			this.qultytext.Text = "Quality >";
			this.qultytext.TextAlign = global::System.Drawing.ContentAlignment.MiddleRight;
			this.comboqualty.Dock = global::System.Windows.Forms.DockStyle.Right;
			this.comboqualty.DropDownStyle = global::DrakeUI.Framework.UIDropDownStyle.DropDownList;
			this.comboqualty.FillColor = global::System.Drawing.Color.Black;
			this.comboqualty.Font = new global::System.Drawing.Font("Roboto", 9f);
			this.comboqualty.ForeColor = global::System.Drawing.Color.White;
			this.comboqualty.Items.AddRange(new object[]
			{
				"10",
				"20",
				"30",
				"40",
				"50",
				"60",
				"70",
				"80",
				"90",
				"100"
			});
			this.comboqualty.Location = new global::System.Drawing.Point(392, 0);
			this.comboqualty.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.comboqualty.MaxDropDownItems = 25;
			this.comboqualty.MinimumSize = new global::System.Drawing.Size(63, 0);
			this.comboqualty.Name = "comboqualty";
			this.comboqualty.Padding = new global::System.Windows.Forms.Padding(0, 0, 30, 0);
			this.comboqualty.RectColor = global::System.Drawing.Color.FromArgb(157, 5, 17);
			this.comboqualty.RectDisableColor = global::System.Drawing.Color.FromArgb(227, 242, 253);
			this.comboqualty.Size = new global::System.Drawing.Size(82, 26);
			this.comboqualty.Style = global::DrakeUI.Framework.UIStyle.Custom;
			this.comboqualty.StyleCustomMode = true;
			this.comboqualty.TabIndex = 43;
			this.comboqualty.Text = "70";
			this.comboqualty.TextAlignment = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.combotext.Dock = global::System.Windows.Forms.DockStyle.Right;
			this.combotext.Font = new global::System.Drawing.Font("Roboto", 8.7f, global::System.Drawing.FontStyle.Bold);
			this.combotext.ForeColor = global::System.Drawing.Color.FromArgb(157, 5, 17);
			this.combotext.Location = new global::System.Drawing.Point(474, 0);
			this.combotext.Name = "combotext";
			this.combotext.Size = new global::System.Drawing.Size(61, 28);
			this.combotext.TabIndex = 40;
			this.combotext.Text = "Size >";
			this.combotext.TextAlign = global::System.Drawing.ContentAlignment.MiddleRight;
			this.combosizes.Dock = global::System.Windows.Forms.DockStyle.Right;
			this.combosizes.DropDownStyle = global::DrakeUI.Framework.UIDropDownStyle.DropDownList;
			this.combosizes.FillColor = global::System.Drawing.Color.Black;
			this.combosizes.Font = new global::System.Drawing.Font("Roboto", 9f);
			this.combosizes.ForeColor = global::System.Drawing.Color.White;
			this.combosizes.Location = new global::System.Drawing.Point(535, 0);
			this.combosizes.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.combosizes.MaxDropDownItems = 25;
			this.combosizes.MinimumSize = new global::System.Drawing.Size(63, 0);
			this.combosizes.Name = "combosizes";
			this.combosizes.Padding = new global::System.Windows.Forms.Padding(0, 0, 30, 0);
			this.combosizes.RectColor = global::System.Drawing.Color.FromArgb(157, 5, 17);
			this.combosizes.RectDisableColor = global::System.Drawing.Color.FromArgb(227, 242, 253);
			this.combosizes.Size = new global::System.Drawing.Size(181, 26);
			this.combosizes.Style = global::DrakeUI.Framework.UIStyle.Custom;
			this.combosizes.StyleCustomMode = true;
			this.combosizes.TabIndex = 41;
			this.combosizes.TextAlignment = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.DrakeUIAvatar2.AvatarSize = 30;
			this.DrakeUIAvatar2.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.DrakeUIAvatar2.Dock = global::System.Windows.Forms.DockStyle.Right;
			this.DrakeUIAvatar2.FillColor = global::System.Drawing.Color.Black;
			this.DrakeUIAvatar2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f);
			this.DrakeUIAvatar2.ForeColor = global::System.Drawing.Color.FromArgb(157, 5, 17);
			this.DrakeUIAvatar2.Location = new global::System.Drawing.Point(716, 0);
			this.DrakeUIAvatar2.Margin = new global::System.Windows.Forms.Padding(4);
			this.DrakeUIAvatar2.Name = "DrakeUIAvatar2";
			this.DrakeUIAvatar2.Size = new global::System.Drawing.Size(35, 28);
			this.DrakeUIAvatar2.Style = global::DrakeUI.Framework.UIStyle.Custom;
			this.DrakeUIAvatar2.StyleCustomMode = true;
			this.DrakeUIAvatar2.Symbol = 61470;
			this.DrakeUIAvatar2.SymbolSize = 25;
			this.DrakeUIAvatar2.TabIndex = 28;
			this.DrakeUIAvatar2.Tag = "off";
			this.DrakeUIAvatar2.Text = "DrakeUIAvatar1";
			this.DrakeUIToolTip1.SetToolTip(this.DrakeUIAvatar2, "Rotate");
			this.Button3.AvatarSize = 30;
			this.Button3.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.Button3.Dock = global::System.Windows.Forms.DockStyle.Right;
			this.Button3.FillColor = global::System.Drawing.Color.Black;
			this.Button3.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f);
			this.Button3.ForeColor = global::System.Drawing.Color.FromArgb(157, 5, 17);
			this.Button3.Location = new global::System.Drawing.Point(751, 0);
			this.Button3.Margin = new global::System.Windows.Forms.Padding(4);
			this.Button3.Name = "Button3";
			this.Button3.Size = new global::System.Drawing.Size(35, 28);
			this.Button3.Style = global::DrakeUI.Framework.UIStyle.Custom;
			this.Button3.StyleCustomMode = true;
			this.Button3.Symbol = 61469;
			this.Button3.SymbolSize = 30;
			this.Button3.TabIndex = 26;
			this.Button3.Tag = "off";
			this.Button3.Text = "DrakeUIAvatar1";
			this.DrakeUIToolTip1.SetToolTip(this.Button3, "Record");
			this.Bbtn.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.Bbtn.Dock = global::System.Windows.Forms.DockStyle.Left;
			this.Bbtn.FillColor = global::System.Drawing.Color.Black;
			this.Bbtn.FillDisableColor = global::System.Drawing.Color.FromArgb(25, 25, 25);
			this.Bbtn.Font = new global::System.Drawing.Font("Segoe UI", 12f);
			this.Bbtn.ForeColor = global::System.Drawing.Color.FromArgb(157, 5, 17);
			this.Bbtn.Location = new global::System.Drawing.Point(121, 0);
			this.Bbtn.Name = "Bbtn";
			this.Bbtn.Radius = 15;
			this.Bbtn.RectColor = global::System.Drawing.Color.FromArgb(157, 5, 17);
			this.Bbtn.RectDisableColor = global::System.Drawing.Color.White;
			this.Bbtn.Size = new global::System.Drawing.Size(42, 28);
			this.Bbtn.Style = global::DrakeUI.Framework.UIStyle.Custom;
			this.Bbtn.TabIndex = 21;
			this.Bbtn.Tag = "off";
			this.Bbtn.Text = "B";
			this.DrakeUIToolTip1.SetToolTip(this.Bbtn, "Back Camera");
			this.Sbtn.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.Sbtn.Dock = global::System.Windows.Forms.DockStyle.Left;
			this.Sbtn.FillColor = global::System.Drawing.Color.Black;
			this.Sbtn.FillDisableColor = global::System.Drawing.Color.FromArgb(25, 25, 25);
			this.Sbtn.Font = new global::System.Drawing.Font("Segoe UI", 12f);
			this.Sbtn.ForeColor = global::System.Drawing.Color.FromArgb(157, 5, 17);
			this.Sbtn.Location = new global::System.Drawing.Point(79, 0);
			this.Sbtn.Name = "Sbtn";
			this.Sbtn.Radius = 15;
			this.Sbtn.RectColor = global::System.Drawing.Color.FromArgb(157, 5, 17);
			this.Sbtn.RectDisableColor = global::System.Drawing.Color.White;
			this.Sbtn.Size = new global::System.Drawing.Size(42, 28);
			this.Sbtn.Style = global::DrakeUI.Framework.UIStyle.Custom;
			this.Sbtn.TabIndex = 20;
			this.Sbtn.Text = "S";
			this.DrakeUIToolTip1.SetToolTip(this.Sbtn, "Stop Camera");
			this.Fbtn.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.Fbtn.Dock = global::System.Windows.Forms.DockStyle.Left;
			this.Fbtn.FillColor = global::System.Drawing.Color.Black;
			this.Fbtn.FillDisableColor = global::System.Drawing.Color.FromArgb(25, 25, 25);
			this.Fbtn.Font = new global::System.Drawing.Font("Segoe UI", 12f);
			this.Fbtn.ForeColor = global::System.Drawing.Color.FromArgb(157, 5, 17);
			this.Fbtn.Location = new global::System.Drawing.Point(37, 0);
			this.Fbtn.Name = "Fbtn";
			this.Fbtn.Radius = 15;
			this.Fbtn.RectColor = global::System.Drawing.Color.FromArgb(157, 5, 17);
			this.Fbtn.RectDisableColor = global::System.Drawing.Color.White;
			this.Fbtn.Size = new global::System.Drawing.Size(42, 28);
			this.Fbtn.Style = global::DrakeUI.Framework.UIStyle.Custom;
			this.Fbtn.TabIndex = 19;
			this.Fbtn.Tag = "off";
			this.Fbtn.Text = "F";
			this.DrakeUIToolTip1.SetToolTip(this.Fbtn, "Front Camera");
			this.ClientPic.BackColor = global::System.Drawing.Color.Transparent;
			this.ClientPic.Dock = global::System.Windows.Forms.DockStyle.Left;
			this.ClientPic.Location = new global::System.Drawing.Point(0, 0);
			this.ClientPic.Name = "ClientPic";
			this.ClientPic.Size = new global::System.Drawing.Size(37, 28);
			this.ClientPic.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.ClientPic.TabIndex = 11;
			this.ClientPic.TabStop = false;
			this.ToolTip1.BackColor = global::System.Drawing.Color.FromArgb(35, 35, 35);
			this.ToolTip1.ForeColor = global::System.Drawing.Color.DarkTurquoise;
			this.DrakeUIToolTip1.BackColor = global::System.Drawing.Color.FromArgb(54, 54, 54);
			this.DrakeUIToolTip1.ForeColor = global::System.Drawing.Color.FromArgb(239, 239, 239);
			this.DrakeUIToolTip1.OwnerDraw = true;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(8f, 19f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(786, 646);
			base.Controls.Add(this.Panel1);
			base.Controls.Add(this.Panel2);
			base.Controls.Add(this.Panel4);
			this.Font = new global::System.Drawing.Font("Segoe UI", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			base.MaximizeBox = false;
			this.MinimumSize = new global::System.Drawing.Size(804, 693);
			base.Name = "CameraManager";
			base.Opacity = 0.0;
			this.Text = "CameraManager";
			((global::System.ComponentModel.ISupportInitialize)this.CAM0).EndInit();
			this.Panel1.ResumeLayout(false);
			this.Panel4.ResumeLayout(false);
			this.Panel2.ResumeLayout(false);
			this.Panel2.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.ClientPic).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x040005EC RID: 1516
		private global::System.ComponentModel.Container components;
	}
}
