using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;

namespace Adyga_bot
{
	// Token: 0x02000005 RID: 5
	public class CaptchaClient
	{
		// Token: 0x06000019 RID: 25 RVA: 0x00002D60 File Offset: 0x00000F60
		public CaptchaClient(string host, string api_key)
		{
			this.api_key = api_key;
			this.host = host;
			bool flag = CaptchaClient.errors == null;
			bool flag2 = flag;
			bool flag3 = flag2;
			if (flag3)
			{
				CaptchaClient.errors = new Dictionary<string, string>();
				CaptchaClient.errors.Add("CAPCHA_NOT_READY", "Капча в работе, ещё не расшифрована, необходимо повтороить запрос через несколько секунд.");
				CaptchaClient.errors.Add("ERROR_WRONG_ID_FORMAT", "Неверный формат ID капчи. ID должен содержать только цифры.");
				CaptchaClient.errors.Add("ERROR_WRONG_CAPTCHA_ID", "Неверное значение ID капчи.");
				CaptchaClient.errors.Add("ERROR_CAPTCHA_UNSOLVABLE", "Капчу не смогли разгадать 3 разных работника. Средства за эту капчу не списываются.");
				CaptchaClient.errors.Add("ERROR_WRONG_USER_KEY", "Неверный формат параметра key, должно быть 32 символа.");
				CaptchaClient.errors.Add("ERROR_KEY_DOES_NOT_EXIST", "Использован несуществующий key.");
				CaptchaClient.errors.Add("ERROR_ZERO_BALANCE", "Баланс Вашего аккаунта нулевой.");
				CaptchaClient.errors.Add("ERROR_NO_SLOT_AVAILABLE", "Текущая ставка распознования выше, чем максимально установленная в настройках Вашего аккаунта.");
				CaptchaClient.errors.Add("ERROR_ZERO_CAPTCHA_FILESIZE", "Размер капчи меньше 100 Байт.");
				CaptchaClient.errors.Add("ERROR_TOO_BIG_CAPTCHA_FILESIZE", "Размер капчи более 100 КБайт.");
				CaptchaClient.errors.Add("ERROR_WRONG_FILE_EXTENSION", "Ваша капча имеет неверное расширение, допустимые расширения jpg,jpeg,gif,png.");
				CaptchaClient.errors.Add("ERROR_IMAGE_TYPE_NOT_SUPPORTED", "Сервер не может определить тип файла капчи.");
				CaptchaClient.errors.Add("ERROR_IP_NOT_ALLOWED", "В Вашем аккаунте настроено ограничения по IP с которых можно делать запросы. И IP, с которого пришёл данный запрос не входит в список разрешённых.");
			}
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00002EC0 File Offset: 0x000010C0
		public string GetCaptcha(string captchaId)
		{
			string url = string.Format("{0}/res.php?key={1}&action=get&id={2}", this.host, this.api_key, captchaId);
			return this.MakeGetRequest(url);
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00002EF4 File Offset: 0x000010F4
		public string UploadCaptchaFile(string fileName)
		{
			return this.UploadCaptchaFile(fileName, null);
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00002F10 File Offset: 0x00001110
		public string UploadCaptchaFile(string fileName, CaptchaConfig config)
		{
			string requestUriString = string.Format("{0}/in.php", this.host);
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection.Add("key", this.api_key);
			bool flag = config != null;
			bool flag2 = flag;
			bool flag3 = flag2;
			if (flag3)
			{
				nameValueCollection.Add(config.GetParameters());
			}
			string str = "---------------------------" + DateTime.Now.Ticks.ToString("x");
			byte[] bytes = Encoding.ASCII.GetBytes("\r\n--" + str + "\r\n");
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(requestUriString);
			httpWebRequest.ContentType = "multipart/form-data; boundary=" + str;
			httpWebRequest.Method = "POST";
			httpWebRequest.KeepAlive = true;
			httpWebRequest.Credentials = CredentialCache.DefaultCredentials;
			Stream requestStream = httpWebRequest.GetRequestStream();
			string format = "Content-Disposition: form-data; name=\"{0}\"\r\n\r\n{1}";
			foreach (object obj in nameValueCollection.Keys)
			{
				string text = (string)obj;
				requestStream.Write(bytes, 0, bytes.Length);
				string s = string.Format(format, text, nameValueCollection[text]);
				byte[] bytes2 = Encoding.UTF8.GetBytes(s);
				requestStream.Write(bytes2, 0, bytes2.Length);
			}
			requestStream.Write(bytes, 0, bytes.Length);
			string s2 = string.Format("Content-Disposition: form-data; name=\"{0}\"; filename=\"{1}\"\r\nContent-Type: {2}\r\n\r\n", "file", fileName, "image/jpeg");
			byte[] bytes3 = Encoding.UTF8.GetBytes(s2);
			requestStream.Write(bytes3, 0, bytes3.Length);
			FileStream fileStream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
			byte[] array = new byte[4096];
			int count;
			while ((count = fileStream.Read(array, 0, array.Length)) != 0)
			{
				requestStream.Write(array, 0, count);
			}
			fileStream.Close();
			byte[] bytes4 = Encoding.ASCII.GetBytes("\r\n--" + str + "--\r\n");
			requestStream.Write(bytes4, 0, bytes4.Length);
			requestStream.Close();
			string result;
			using (WebResponse response = httpWebRequest.GetResponse())
			{
				StreamReader streamReader = new StreamReader(response.GetResponseStream());
				result = this.ParseAnswer(streamReader.ReadToEnd());
			}
			return result;
		}

		// Token: 0x0600001D RID: 29 RVA: 0x0000319C File Offset: 0x0000139C
		public decimal GetBalance()
		{
			string url = string.Format("{0}/res.php?key={1}&action=getbalance", this.host, this.api_key);
			return decimal.Parse(this.MakeGetRequest(url), CultureInfo.InvariantCulture.NumberFormat);
		}

		// Token: 0x0600001E RID: 30 RVA: 0x000031DC File Offset: 0x000013DC
		private string MakeGetRequest(string url)
		{
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
			httpWebRequest.Method = "GET";
			string serviceAnswer = "";
			using (HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse())
			{
				serviceAnswer = new StreamReader(httpWebResponse.GetResponseStream()).ReadToEnd();
			}
			return this.ParseAnswer(serviceAnswer);
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00003250 File Offset: 0x00001450
		private string ParseAnswer(string serviceAnswer)
		{
			bool flag = CaptchaClient.errors.Keys.Contains(serviceAnswer);
			bool flag2 = flag;
			bool flag3 = flag2;
			if (flag3)
			{
				throw new RuCaptchaException(string.Format("{0} ({1})", CaptchaClient.errors[serviceAnswer], serviceAnswer));
			}
			bool flag4 = serviceAnswer.StartsWith("OK|");
			bool flag5 = flag4;
			bool flag6 = flag5;
			string result;
			if (flag6)
			{
				result = serviceAnswer.Substring(3);
			}
			else
			{
				result = serviceAnswer;
			}
			return result;
		}

		// Token: 0x04000028 RID: 40
		private readonly string api_key;

		// Token: 0x04000029 RID: 41
		private readonly string host = "http://rucaptcha.com";

		// Token: 0x0400002A RID: 42
		private static Dictionary<string, string> errors;
	}
}
