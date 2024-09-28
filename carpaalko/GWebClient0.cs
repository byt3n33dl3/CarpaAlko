using System;
using System.Net;
using System.Security.Cryptography.X509Certificates;

namespace Craxs_Rat
{
	// Token: 0x02000013 RID: 19
	public class GWebClient0 : WebClient
	{
		// Token: 0x060001AB RID: 427 RVA: 0x0000F8E0 File Offset: 0x0000DAE0
		protected override WebRequest GetWebRequest(Uri address)
		{
			WebRequest webRequest = base.GetWebRequest(address);
			if (webRequest is HttpWebRequest)
			{
				HttpWebRequest httpWebRequest = (HttpWebRequest)webRequest;
				httpWebRequest.ClientCertificates.Add(new X509Certificate());
			}
			return webRequest;
		}
	}
}
