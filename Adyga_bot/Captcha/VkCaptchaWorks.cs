using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Threading;

namespace Adyga_bot
{
	// Token: 0x02000014 RID: 20
	internal static class VkCaptchaWorks
	{
		// Token: 0x0600005A RID: 90 RVA: 0x000065F4 File Offset: 0x000047F4
		public static void SetKeyAndProv(CaptchaWorksProvder prov, string key)
		{
			bool flag = prov == CaptchaWorksProvder.rucaptcha;
			bool flag2 = flag;
			bool flag3 = flag2;
			if (flag3)
			{
				VkCaptchaWorks.RCC = new CaptchaClient("https://rucaptcha.com", key);
			}
			else
			{
				VkCaptchaWorks.RCC = new CaptchaClient("https://anti-captcha.com", key);
			}
		}

		// Token: 0x0600005B RID: 91 RVA: 0x00006634 File Offset: 0x00004834
		public static string GetBalance()
		{
			bool flag = VkCaptchaWorks.RCC != null;
			bool flag2 = flag;
			bool flag3 = flag2;
			string result;
			if (flag3)
			{
				result = VkCaptchaWorks.RCC.GetBalance().ToString();
			}
			else
			{
				result = "?";
			}
			return result;
		}

		// Token: 0x0600005C RID: 92 RVA: 0x0000667C File Offset: 0x0000487C
		public static string Solve(string url, string id)
		{
			new WebClient().DownloadFile(url, id + ".png");
			string captchaId = "";
			try
			{
				captchaId = VkCaptchaWorks.RCC.UploadCaptchaFile(id + ".png");
			}
			finally
			{
				File.Delete(id + ".png");
			}
			string text = null;
			while (string.IsNullOrEmpty(text))
			{
				Thread.Sleep(1000);
				try
				{
					text = VkCaptchaWorks.RCC.GetCaptcha(captchaId);
				}
				catch (Exception ex)
				{
					bool flag = !ex.Message.Contains("CAPCHA_NOT_READY");
					bool flag2 = flag;
					bool flag3 = flag2;
					if (flag3)
					{
						Log.Push("[Ошибка обработки captcha]: " + ex.Message);
					}
				}
			}
			Log.Push("[captcha]: распознавание завершено");
			return text;
		}

		// Token: 0x0600005D RID: 93 RVA: 0x0000676C File Offset: 0x0000496C
		public static void RegisterManual(string key, string ans)
		{
			VkCaptchaWorks.answs.Add(key, ans);
		}

		// Token: 0x0600005E RID: 94 RVA: 0x0000677C File Offset: 0x0000497C
		public static string SolveManual(string url, string id)
		{
			new WebClient().DownloadFile(url, id + ".png");
			VkCaptchaWorks.toSolve.Enqueue(id);
			while (!VkCaptchaWorks.answs.ContainsKey(id))
			{
				Thread.Sleep(1000);
			}
			string result = VkCaptchaWorks.answs[id];
			VkCaptchaWorks.answs.Remove(id);
			return result;
		}

		// Token: 0x04000068 RID: 104
		private static CaptchaClient RCC = null;

		// Token: 0x04000069 RID: 105
		public static bool Enabled = false;

		// Token: 0x0400006A RID: 106
		public static Queue<string> toSolve = new Queue<string>();

		// Token: 0x0400006B RID: 107
		private static Dictionary<string, string> answs = new Dictionary<string, string>();
	}
}
