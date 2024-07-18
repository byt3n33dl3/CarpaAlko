using System;
using System.Windows.Forms;

namespace Craxs_Rat
{
	// Token: 0x0200010A RID: 266
	public class GProgressBar0 : ProgressBar
	{
		// Token: 0x17000583 RID: 1411
		// (get) Token: 0x06001308 RID: 4872 RVA: 0x000CE6B0 File Offset: 0x000CC8B0
		protected override CreateParams CreateParams
		{
			get
			{
				CreateParams createParams = base.CreateParams;
				createParams.Style |= 4;
				return createParams;
			}
		}
	}
}
