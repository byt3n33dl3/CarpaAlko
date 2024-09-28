using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Craxs_Rat
{
	// Token: 0x02000030 RID: 48
	[DesignerGenerated]
	public partial class Dialog2 : Form
	{
		// Token: 0x06000346 RID: 838 RVA: 0x0001D5FC File Offset: 0x0001B7FC
		public Dialog2()
		{
			base.Load += this.Dialog2_Load;
			this.InitializeComponent();
		}

		// Token: 0x17000129 RID: 297
		// (get) Token: 0x06000349 RID: 841 RVA: 0x000026E7 File Offset: 0x000008E7
		// (set) Token: 0x0600034A RID: 842 RVA: 0x0001D8CC File Offset: 0x0001BACC
		internal virtual TextBox TextBox1 { get; set; }

		// Token: 0x1700012A RID: 298
		// (get) Token: 0x0600034B RID: 843 RVA: 0x000026EF File Offset: 0x000008EF
		// (set) Token: 0x0600034C RID: 844 RVA: 0x0001D8E0 File Offset: 0x0001BAE0
		internal virtual Button Button1
		{
			[CompilerGenerated]
			get
			{
				return this._Button1;
			}
			[CompilerGenerated]
			set
			{
				EventHandler value2 = new EventHandler(this.Button1_Click);
				Button button = this._Button1;
				if (button != null)
				{
					button.Click -= value2;
				}
				this._Button1 = value;
				button = this._Button1;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		// Token: 0x0600034D RID: 845 RVA: 0x00011540 File Offset: 0x0000F740
		private void Button1_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x0600034E RID: 846 RVA: 0x0001D924 File Offset: 0x0001BB24
		public void method_2()
		{
			string left = Module4.smethod_1();
			if (Operators.CompareString(left, "AR", false) != 0)
			{
				if (Operators.CompareString(left, "CN", false) != 0)
				{
					this.TextBox1.Text = Module2.smethod_58("YgzGHz2hPvBCIIpjRlTdEq7/nqkwPpR9iSK5rvyR/A4tJrjjWA678LmmjTtQmyHTnuk/yf4jvgtr\r\niVj1EuK3JV53AOGu36eDbWj6DH7rDNlHBlJQQkOYPgJVCsW0l/hjkQOWSfWEua7bzjQrTN5Zngv7\r\np0S/gbXRBOjHCyfWiYZNfgezEw0Da2QQEAIhgZLsl2xA+Fl/XbAUlIUsaTLwMDTqWhaEt/r89gb6\r\nVHEMuMyX06CG8KyOJcZLmQRR0t+SjBRz7zgb+Br9oE4PKitPSfrqV5YGuX5Bn7AsEEOox7I28VJc\r\noC8bNF9O6KHFkAjUdhViIx8elxigfmJwHABs3jTaklzTTMGRWGhFYeFstEYRjlYokLJ5DVFrfJBS\r\n6qplNgu6XBttaFqpBd/IdOChlQrh6aGQS0K8a/Qo6kaKLGDu6ke8txyZfgQK5Jy8loSoQKTYECkP\r\nUxlvSIlkAp3hy9wGwXNWR21tSG/jOp0iOdnmzKAK/7zQRyAIwDHdhVnBQZdIqR7bEwf63ZCppVMD\r\nK1O0H5kz6vbDLaQUQrj3/Oqh9ejx7/sdeikWJQ8QhU2UiZzylaYXjbC5uL/qClLWe4HfabFHSIdr\r\nomGkNHf95/hR4UirBK5TVZ0n9jR16iq91qB19FcekSqVVk+MDHfhG5DWyRgwQGnod3jNRYxDpNm0\r\nsi4bpN1Jjl2/n/R0sa5wSTeEf8dVausjnz2HPWbkUs7RO1099KJR1+uHG57lUnZymzGYRg5rbVDW\r\nmY1qELjstdJexzitTIJzKopD3sswjXgArqoYJ79ERr3eseJL7J6pvM8MR/vdHe2PStRtyET01zhx\r\nBXyHSsyaoAIqoT4wQ4x9W0K2cI5VOFx7t/51HQmfovYo9P99uZQBmoau8jr07Vw2XGmYZVgRl6Ch\r\n6kSHm/AXMtHT+j6c8wkftrXaByjpUyngFbEd7TBOpiB17kqovh5zR2AiXYvr3cAC2LvJ9LueqDfI\r\nxZgAt5cNt0i0mhJ+fV77EYsxhDMPkWgn1EMq7/rse04qREiSrUbqao8kkzhtys6WHWZRKhgNsvuE\r\nDWGCA7Dyziiu6Ah7ZxHU/05T06AH4CTDuX22mU9wKFE5XzAn6u7n5v4Vt7gT20DKSprzczXii5tO\r\nmcpUKQkAD1cD4ju97zjHfenZmj62DOIU9odm69jhgMAf5h7jG06nDrKBW5CoQYh221AR2SpzRwck\r\n/GVyopovnaaWKUGGrdENUg4z5rM/RTDEqWJMgqHLnWKEB8o/o1O3eOujwHRkAR/Uyqu0Fd/GVC9u\r\nE4h9SHzivhP+I4tfep6rkY5QyA7afHnLXM4mO8kiY/siH5btTA8SxeUKBYLStZXD1YKwpfIeGARg\r\niUJM9J3w39yM1bulSp6Dl0NxGidRTuxZXQA51n+BXpAobJ4OSYrN5CmI7RNJ3vxMHl0DLcbJyA5G\r\nne+0O84aifUo8f/0Wn+pvVrEUkzqIhQa0er9fP8QYOh9ZNufUvJRebkfWbCDmxGEw/yD1Bob7YoW\r\n+zbGR+Wv775E1VZN0lnpOdiBivcXJjja0aTfZmfnf5cKzX6erDbX5JJa0VoZNCNgJCjnNpdqDRvo\r\nvVyx", "myapp");
				}
				else
				{
					this.TextBox1.Text = "1：本软件版权归CraxsRat.net所有。\r\n\r\n2：本软件仅供个人使用。\r\n\r\n3：您对任何非法使用本软件的行为负全部责任。\r\n\r\n4：CraxsRat.net 所有者不对因本软件造成的任何损害负责\r\n\r\n5：不得将本软件分享、出售或赠送给任何人\r\n  \r\n6：如果您共享此软件，您的许可证可能会被吊销\r\n  \r\n7：您同意，我们不对任何滥用/误用我们软件的行为负责。\r\n\r\n8：您同意，您不得向任何人提供/共享您的帐户。\r\n\r\n9：您同意，如果我们检测到对我们软件的任何逆向工程，我们可以禁止您使用我们的软件。\r\n\r\n10：我们可以随时更改我们的服务条款，立即生效。\r\n\r\n11：您同意，我们被允许在我们的数据库中记录您的硬件 ID（例如处理器标识符 [散列！]）以进行验证/登录。\r\n\r\n12：您不得对我们的软件进行反编译、调试、逆向工程。\r\n\r\n13：不得将本软件用于非法用途。\r\n\r\n14：本软件只能在他人同意的情况下或在您的本地机器上用于私人目的。";
				}
			}
			else
			{
				this.TextBox1.Text = "1: يتم نسخ هذا البرنامج إلى موقع CraxsRat.net.\r\n\r\n2: هذا البرنامج للاستخدام الشخصي فقط.\r\n\r\n3: أنت المسؤول الوحيد عن أي استخدام غير قانوني لهذا البرنامج.\r\n\r\n4: مالك موقع CraxsRat.net غير مسؤول عن أي ضرر ناتج عن هذا البرنامج\r\n\r\n5: غير مسموح لك بالمشاركة أو البيع أو إعطاء هذا البرنامج لأي شخص\r\n  \r\n6: إذا قمت بمشاركة هذا البرنامج ، فقد يتم إبطال تراخيصك\r\n  \r\n7: أنت توافق على أننا لسنا مسؤولين عن أي إساءة استخدام / إساءة استخدام لبرنامجنا.\r\n\r\n8: أنت توافق على أنه لا يُسمح لك بمنح / مشاركة حسابك إلى / مع أي شخص.\r\n\r\n9: أنت توافق على أنه يُسمح لنا بمنعك من برنامجنا إذا اكتشفنا أي هندسة عكسية لبرنامجنا.\r\n\r\n10: يُسمح لنا بتغيير شروط الخدمة الخاصة بنا في أي وقت بأثر فوري.\r\n\r\n11: أنت توافق على أنه يُسمح لنا بتسجيل معرف الجهاز الخاص بك (على سبيل المثال معرف المعالج [مجزأ!]) في قاعدة البيانات الخاصة بنا لأغراض التحقق / تسجيل الدخول.\r\n\r\n12: غير مسموح لك بفك برنامجنا وتصحيحه وهندسته العكسية.\r\n\r\n13: غير مسموح لك باستخدام هذا البرنامج لأغراض غير قانونية.\r\n\r\n14: لا يجوز استخدام هذا البرنامج إلا بموافقة شخص آخر أو لأغراض خاصة على جهازك المحلي.";
			}
		}

		// Token: 0x0600034F RID: 847 RVA: 0x000026F7 File Offset: 0x000008F7
		private void Dialog2_Load(object sender, EventArgs e)
		{
			this.method_2();
		}
	}
}
