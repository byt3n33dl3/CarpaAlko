using System;
using System.Net.Sockets;
using System.Threading;

namespace Craxs_Rat
{
	// Token: 0x02000108 RID: 264
	public sealed class GClass10
	{
		// Token: 0x060012F1 RID: 4849 RVA: 0x000CE074 File Offset: 0x000CC274
		public GClass10(GClass8 gclass8_0, byte[] bytes_0, object[] objects_0, TcpClient tcpClient_0)
		{
			this.manualResetEvent_0 = new ManualResetEvent(false);
			this.bool_0 = false;
			this.gclass8_0 = gclass8_0;
			this.bytes_0 = bytes_0;
			this.objects_0 = objects_0;
			this.tcpClient_0 = tcpClient_0;
		}

		// Token: 0x04000CBD RID: 3261
		public bool bool_0;

		// Token: 0x04000CBE RID: 3262
		public ManualResetEvent manualResetEvent_0;

		// Token: 0x04000CBF RID: 3263
		public byte[] bytes_0;

		// Token: 0x04000CC0 RID: 3264
		public GClass8 gclass8_0;

		// Token: 0x04000CC1 RID: 3265
		public object[] objects_0;

		// Token: 0x04000CC2 RID: 3266
		public TcpClient tcpClient_0;
	}
}
