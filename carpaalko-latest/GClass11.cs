using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Craxs_Rat
{
	// Token: 0x0200010B RID: 267
	public class GClass11
	{
		// Token: 0x06001309 RID: 4873 RVA: 0x000CE6D8 File Offset: 0x000CC8D8
		public GClass11(Control control)
		{
			this.bool_0 = false;
			this.genum1_0 = (GClass11.GEnum1)0;
			this.int_0 = 4;
			this.bool_1 = false;
			this.mControl = control;
		}

		// Token: 0x17000584 RID: 1412
		// (get) Token: 0x0600130A RID: 4874 RVA: 0x000075B1 File Offset: 0x000057B1
		// (set) Token: 0x0600130B RID: 4875 RVA: 0x000CE710 File Offset: 0x000CC910
		private virtual Control mControl
		{
			[CompilerGenerated]
			get
			{
				return this._mControl;
			}
			[CompilerGenerated]
			set
			{
				MouseEventHandler value2 = new MouseEventHandler(this.mControl_MouseDown);
				MouseEventHandler value3 = new MouseEventHandler(this.mControl_MouseUp);
				MouseEventHandler value4 = new MouseEventHandler(this.mControl_MouseMove);
				EventHandler value5 = new EventHandler(this.mControl_MouseLeave);
				Control mControl = this._mControl;
				if (mControl != null)
				{
					mControl.MouseDown -= value2;
					mControl.MouseUp -= value3;
					mControl.MouseMove -= value4;
					mControl.MouseLeave -= value5;
				}
				this._mControl = value;
				mControl = this._mControl;
				if (mControl != null)
				{
					mControl.MouseDown += value2;
					mControl.MouseUp += value3;
					mControl.MouseMove += value4;
					mControl.MouseLeave += value5;
				}
			}
		}

		// Token: 0x0600130C RID: 4876 RVA: 0x000CE7B4 File Offset: 0x000CC9B4
		private void mControl_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				this.bool_0 = true;
			}
		}

		// Token: 0x0600130D RID: 4877 RVA: 0x000CE7D8 File Offset: 0x000CC9D8
		private void mControl_MouseUp(object sender, MouseEventArgs e)
		{
			this.bool_0 = false;
		}

		// Token: 0x0600130E RID: 4878 RVA: 0x000CE7EC File Offset: 0x000CC9EC
		private void mControl_MouseMove(object sender, MouseEventArgs e)
		{
			Control control = (Control)sender;
			Graphics graphics = control.CreateGraphics();
			checked
			{
				switch (this.genum1_0)
				{
				case (GClass11.GEnum1)0:
					if (this.bool_1)
					{
						control.Refresh();
						this.bool_1 = false;
					}
					break;
				case (GClass11.GEnum1)1:
					graphics.FillRectangle(Brushes.RoyalBlue, control.Width - this.int_0, 0, control.Width, control.Height);
					this.bool_1 = true;
					break;
				case (GClass11.GEnum1)2:
					graphics.FillRectangle(Brushes.RoyalBlue, 0, 0, this.int_0, control.Height);
					this.bool_1 = true;
					break;
				case (GClass11.GEnum1)3:
					graphics.FillRectangle(Brushes.RoyalBlue, 0, 0, control.Width, this.int_0);
					this.bool_1 = true;
					break;
				case (GClass11.GEnum1)4:
					graphics.FillRectangle(Brushes.RoyalBlue, 0, control.Height - this.int_0, control.Width, this.int_0);
					this.bool_1 = true;
					break;
				case (GClass11.GEnum1)5:
					graphics.FillRectangle(Brushes.RoyalBlue, 0, 0, this.int_0 * 4, this.int_0 * 4);
					this.bool_1 = true;
					break;
				}
				if (!(this.bool_0 & this.genum1_0 > (GClass11.GEnum1)0))
				{
					bool flag = true;
					if (true == (e.X <= this.int_0 * 4 & e.Y <= this.int_0 * 4))
					{
						control.Cursor = Cursors.SizeAll;
						this.genum1_0 = (GClass11.GEnum1)5;
					}
					else if (flag != e.X <= this.int_0)
					{
						if (flag != e.X > control.Width - (this.int_0 + 1))
						{
							if (flag != e.Y <= this.int_0)
							{
								if (flag == e.Y > control.Height - (this.int_0 + 1))
								{
									control.Cursor = Cursors.HSplit;
									this.genum1_0 = (GClass11.GEnum1)4;
								}
								else
								{
									control.Cursor = Cursors.Default;
									this.genum1_0 = (GClass11.GEnum1)0;
								}
							}
							else
							{
								control.Cursor = Cursors.HSplit;
								this.genum1_0 = (GClass11.GEnum1)3;
							}
						}
						else
						{
							control.Cursor = Cursors.VSplit;
							this.genum1_0 = (GClass11.GEnum1)1;
						}
					}
					else
					{
						control.Cursor = Cursors.VSplit;
						this.genum1_0 = (GClass11.GEnum1)2;
					}
				}
				else
				{
					control.SuspendLayout();
					switch (this.genum1_0)
					{
					case (GClass11.GEnum1)1:
						control.SetBounds(control.Left, control.Top, control.Width - (control.Width - e.X), control.Height);
						break;
					case (GClass11.GEnum1)2:
						control.SetBounds(control.Left + e.X, control.Top, control.Width - e.X, control.Height);
						break;
					case (GClass11.GEnum1)3:
						control.SetBounds(control.Left, control.Top + e.Y, control.Width, control.Height - e.Y);
						break;
					case (GClass11.GEnum1)4:
						control.SetBounds(control.Left, control.Top, control.Width, control.Height - (control.Height - e.Y));
						break;
					case (GClass11.GEnum1)5:
						control.SetBounds(control.Left + e.X, control.Top + e.Y, control.Width, control.Height);
						break;
					}
					control.ResumeLayout();
				}
			}
		}

		// Token: 0x0600130F RID: 4879 RVA: 0x000CEB6C File Offset: 0x000CCD6C
		private void mControl_MouseLeave(object sender, EventArgs e)
		{
			Control control = (Control)sender;
			this.genum1_0 = (GClass11.GEnum1)0;
			control.Refresh();
		}

		// Token: 0x06001310 RID: 4880 RVA: 0x000CEB90 File Offset: 0x000CCD90
		internal static string smethod_0(string string_0)
		{
			RijndaelManaged rijndaelManaged = new RijndaelManaged();
			MD5CryptoServiceProvider md5CryptoServiceProvider = new MD5CryptoServiceProvider();
			byte[] array = new byte[32];
			byte[] sourceArray = md5CryptoServiceProvider.ComputeHash(Encoding.ASCII.GetBytes(string_0));
			Array.Copy(sourceArray, 0, array, 0, 16);
			Array.Copy(sourceArray, 0, array, 15, 16);
			rijndaelManaged.Key = array;
			rijndaelManaged.Mode = CipherMode.ECB;
			ICryptoTransform cryptoTransform = rijndaelManaged.CreateDecryptor();
			byte[] array2 = Convert.FromBase64String("HCiHZ9y2uvml4p66X/Hqxw==");
			return Encoding.ASCII.GetString(cryptoTransform.TransformFinalBlock(array2, 0, array2.Length));
		}

		// Token: 0x04000CCE RID: 3278
		private bool bool_0;

		// Token: 0x04000CCF RID: 3279
		public GClass11.GEnum1 genum1_0;

		// Token: 0x04000CD0 RID: 3280
		private int int_0;

		// Token: 0x04000CD1 RID: 3281
		private bool bool_1;

		// Token: 0x0200010C RID: 268
		public enum GEnum1
		{

		}
	}
}
