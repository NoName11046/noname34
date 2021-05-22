using System;
using System.Threading;

namespace Adyga_bot
{
	internal static class VKserver
	{
		public static string APIRequest(string method, string param, string token, string captcha_data = "")
		{
			Random random = new Random();
			var text =
					Network.GET($"https://api.vk.com/method/{method}?{param}&access_token={token}{captcha_data}&v=5.126&random_id={random.Next()}", null);
			
			string result;

			if (text.Contains("\"error_code\":14"))
			{
				string between = StrWrk.GetBetween(text, "\"captcha_sid\":\"", "\"");
				string url = StrWrk.GetBetween(text, "\"captcha_img\":\"", "\"").Replace("\\", "");
				string str = "";

				if (VkCaptchaWorks.Enabled)
				{
					Log.Push("[captcha]: обработка капчи");
					try
					{
						str = VkCaptchaWorks.Solve(url, between);
					}
					catch (RuCaptchaException ex)
					{
						Log.Push("[Ошибка обработки captcha]: " + ex.Message);
					}
					result = VKserver.APIRequest(method, param, token, "&captcha_sid=" + between + "&captcha_key=" + str);
				}
				else
				{
					Log.Push("[captcha]: изображение поставлено в очередь на ручной ввод");
					str = VkCaptchaWorks.SolveManual(url, between);
					result = APIRequest(method, param, token, "&captcha_sid=" + between + "&captcha_key=" + str);
				}
			}
			else
			{
				if (text.Contains("\"error_code\""))
				{
					throw new Exception(StrWrk.GetBetween(text, "\"error_msg\":\"", "\""));
				}
				result = text;
			}
			return result;
		}
	}
}
