using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Craxs_Rat
{
	// Token: 0x020000B3 RID: 179
	[DesignerGenerated]
	public partial class Download : Form
	{
		// Token: 0x06000BCB RID: 3019 RVA: 0x0007C71C File Offset: 0x0007A91C
		public Download()
		{
			base.Load += this.Download_Load;
			base.Closing += this.Download_Closing;
			this.stream_0 = null;
			this.long_0 = 0L;
			this.string_0 = "null";
			this.string_1 = "null";
			this.InitializeComponent();
		}

		// Token: 0x1700035B RID: 859
		// (get) Token: 0x06000BCE RID: 3022 RVA: 0x000063FD File Offset: 0x000045FD
		// (set) Token: 0x06000BCF RID: 3023 RVA: 0x0007CBFC File Offset: 0x0007ADFC
		internal virtual ProgressBar ProgressBar1 { get; set; }

		// Token: 0x1700035C RID: 860
		// (get) Token: 0x06000BD0 RID: 3024 RVA: 0x00006405 File Offset: 0x00004605
		// (set) Token: 0x06000BD1 RID: 3025 RVA: 0x0007CC10 File Offset: 0x0007AE10
		internal virtual DataGridView DGV0 { get; set; }

		// Token: 0x1700035F RID: 863
		// (get) Token: 0x06000BD2 RID: 3026 RVA: 0x0000640D File Offset: 0x0000460D
		// (set) Token: 0x06000BD3 RID: 3027 RVA: 0x0007CC24 File Offset: 0x0007AE24
		internal virtual Timer TimeFinish
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
				Timer timeFinish = this._TimeFinish;
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

		// Token: 0x1700035D RID: 861
		// (get) Token: 0x06000BD4 RID: 3028 RVA: 0x00006415 File Offset: 0x00004615
		// (set) Token: 0x06000BD5 RID: 3029 RVA: 0x0007CC68 File Offset: 0x0007AE68
		internal virtual DataGridViewTextBoxColumn Column1 { get; set; }

		// Token: 0x1700035E RID: 862
		// (get) Token: 0x06000BD6 RID: 3030 RVA: 0x0000641D File Offset: 0x0000461D
		// (set) Token: 0x06000BD7 RID: 3031 RVA: 0x0007CC7C File Offset: 0x0007AE7C
		internal virtual DataGridViewTextBoxColumn Column6 { get; set; }

		// Token: 0x17000360 RID: 864
		// (get) Token: 0x06000BD8 RID: 3032 RVA: 0x00006425 File Offset: 0x00004625
		// (set) Token: 0x06000BD9 RID: 3033 RVA: 0x0007CC90 File Offset: 0x0007AE90
		internal virtual Timer TOpacity
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
				Timer topacity = this._TOpacity;
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

		// Token: 0x06000BDA RID: 3034 RVA: 0x0007CCD4 File Offset: 0x0007AED4
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

		// Token: 0x06000BDB RID: 3035 RVA: 0x0007CDA8 File Offset: 0x0007AFA8
		private void TOpacity_Tick(object sender, EventArgs e)
		{
			if (base.Opacity == 1.0)
			{
				this.TOpacity.Enabled = false;
			}
			else
			{
				base.Opacity += 0.1;
			}
		}

		// Token: 0x06000BDC RID: 3036 RVA: 0x0007CDF0 File Offset: 0x0007AFF0
		private void Download_Load(object sender, EventArgs e)
		{
			base.Location = checked(new Point(Screen.PrimaryScreen.WorkingArea.Width - base.Width, Screen.PrimaryScreen.WorkingArea.Height - base.Height));
			base.Icon = new Icon(Module8.string_1 + "\\Icons\\win\\7.ico");
			this.method_0();
			this.DGV0.ColumnHeadersDefaultCellStyle.Font = Module8.font_1;
			this.DGV0.DefaultCellStyle.Font = Module8.font_1;
			this.TimeFinish.Interval = 1000;
			this.TimeFinish.Enabled = true;
			this.Text = this.string_1;
			this.TOpacity.Interval = Module5.int_0;
			this.TOpacity.Enabled = true;
		}

		// Token: 0x06000BDD RID: 3037 RVA: 0x0007CEC8 File Offset: 0x0007B0C8
		private void Download_Closing(object sender, CancelEventArgs e)
		{
			this.TimeFinish.Enabled = false;
			if (this.gclass8_0 != null)
			{
				this.gclass8_0.bool_2 = true;
				this.gclass8_0.method_6(this.tcpClient_0);
			}
			if (this.stream_0 != null)
			{
				this.stream_0.Dispose();
				this.stream_0.Close();
			}
		}

		// Token: 0x06000BDE RID: 3038 RVA: 0x0007CF2C File Offset: 0x0007B12C
		private void TimeFinish_Tick(object sender, EventArgs e)
		{
			if (this.DGV0.Rows.Count > 0 && this.long_0 <= this.long_1 && this.long_0 > 0L)
			{
				this.dateTime_1 = DateAndTime.Now;
				this.timeSpan_0 = this.dateTime_1.Subtract(this.dateTime_0);
				long long_ = checked((long)Math.Round(unchecked((double)(checked(this.long_1 - this.long_0)) * this.timeSpan_0.TotalSeconds) / (double)this.long_0));
				string text = Module2.smethod_22(long_);
				if (!text.Equals("0:0:0"))
				{
					DateTime dateTime = DateTime.Now;
					DateTime dateTime2 = Convert.ToDateTime(text);
					dateTime = dateTime.AddHours((double)dateTime2.Hour).AddMinutes((double)dateTime2.Minute).AddSeconds((double)dateTime2.Second);
					this.DGV0.Rows[3].Cells[1].Value = string.Format("[{0}]", text);
				}
			}
		}

		// Token: 0x04000691 RID: 1681
		public TcpClient tcpClient_0;

		// Token: 0x04000692 RID: 1682
		public GClass8 gclass8_0;

		// Token: 0x04000693 RID: 1683
		public Stream stream_0;

		// Token: 0x04000694 RID: 1684
		public long long_0;

		// Token: 0x04000695 RID: 1685
		public string string_0;

		// Token: 0x04000696 RID: 1686
		public long long_1;

		// Token: 0x04000697 RID: 1687
		public TimeSpan timeSpan_0;

		// Token: 0x04000698 RID: 1688
		public DateTime dateTime_0;

		// Token: 0x04000699 RID: 1689
		public DateTime dateTime_1;

		// Token: 0x0400069A RID: 1690
		public object object_0;

		// Token: 0x0400069B RID: 1691
		public string string_1;
	}
}
