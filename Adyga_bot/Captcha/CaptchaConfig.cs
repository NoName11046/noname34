using System;
using System.Collections.Generic;
using System.Collections.Specialized;

namespace Adyga_bot
{
	// Token: 0x02000006 RID: 6
	public class CaptchaConfig
	{
		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000020 RID: 32 RVA: 0x000032C4 File Offset: 0x000014C4
		public Dictionary<string, string> Parameters
		{
			get
			{
				return this.parameters;
			}
		}

		// Token: 0x06000021 RID: 33 RVA: 0x000032DC File Offset: 0x000014DC
		public NameValueCollection GetParameters()
		{
			NameValueCollection nameValueCollection = new NameValueCollection();
			foreach (KeyValuePair<string, string> keyValuePair in this.parameters)
			{
				nameValueCollection.Add(keyValuePair.Key, keyValuePair.Value);
			}
			return nameValueCollection;
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00003350 File Offset: 0x00001550
		public CaptchaConfig()
		{
			this.parameters = new Dictionary<string, string>();
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00003368 File Offset: 0x00001568
		public CaptchaConfig SetIsPhrase(bool value)
		{
			this.parameters["phrase"] = (value ? "1" : "0");
			return this;
		}

		// Token: 0x06000024 RID: 36 RVA: 0x0000339C File Offset: 0x0000159C
		public CaptchaConfig SetRegisterSensitive(bool value)
		{
			this.parameters["regsense"] = (value ? "1" : "0");
			return this;
		}

		// Token: 0x06000025 RID: 37 RVA: 0x000033D0 File Offset: 0x000015D0
		public CaptchaConfig SetNeedCalc(bool value)
		{
			this.parameters["calc"] = (value ? "1" : "0");
			return this;
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00003404 File Offset: 0x00001604
		public CaptchaConfig SetCharType(CaptchaCharTypeEnum value)
		{
			bool flag = value == CaptchaCharTypeEnum.Default;
			bool flag2 = flag;
			bool flag3 = flag2;
			if (flag3)
			{
				this.parameters.Remove("numeric");
			}
			else
			{
				Dictionary<string, string> dictionary = this.parameters;
				string key = "numeric";
				int num = (int)value;
				dictionary[key] = num.ToString();
			}
			return this;
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00003460 File Offset: 0x00001660
		public CaptchaConfig SetMinLen(int? minLen)
		{
			bool flag = minLen != null;
			bool flag2 = flag;
			bool flag3 = flag2;
			if (flag3)
			{
				bool flag4 = minLen.Value >= 1;
				bool flag5 = flag4;
				bool flag6;
				if (flag5)
				{
					int? num = minLen;
					int num2 = 20;
					flag6 = (num.GetValueOrDefault() > num2 & num != null);
				}
				else
				{
					flag6 = true;
				}
				bool flag7 = flag6;
				bool flag8 = flag7;
				bool flag9 = flag8;
				if (flag9)
				{
					throw new ArgumentOutOfRangeException("minLen", minLen.Value, "Количество знаков в отчете может быть в диапазоне от 1 до 20 символов.");
				}
				this.parameters["min_len"] = minLen.Value.ToString();
			}
			else
			{
				this.parameters.Remove("min_len");
			}
			return this;
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00003528 File Offset: 0x00001728
		public CaptchaConfig SetMaxLen(int? maxLen)
		{
			bool flag = maxLen != null;
			bool flag2 = flag;
			bool flag3 = flag2;
			if (flag3)
			{
				bool flag4 = maxLen.Value >= 1;
				bool flag5 = flag4;
				bool flag6;
				if (flag5)
				{
					int? num = maxLen;
					int num2 = 20;
					flag6 = (num.GetValueOrDefault() > num2 & num != null);
				}
				else
				{
					flag6 = true;
				}
				bool flag7 = flag6;
				bool flag8 = flag7;
				bool flag9 = flag8;
				if (flag9)
				{
					throw new ArgumentOutOfRangeException("maxLen", maxLen.Value, "Количество знаков в отчете может быть в диапазоне от 1 до 20 символов.");
				}
				this.parameters["max_len"] = maxLen.Value.ToString();
			}
			else
			{
				this.parameters.Remove("max_len");
			}
			return this;
		}

		// Token: 0x06000029 RID: 41 RVA: 0x000035F0 File Offset: 0x000017F0
		public CaptchaConfig SetLanguage(CaptchaLanguageEnum lang)
		{
			bool flag = lang == CaptchaLanguageEnum.Default;
			bool flag2 = flag;
			bool flag3 = flag2;
			if (flag3)
			{
				this.parameters.Remove("language");
			}
			else
			{
				Dictionary<string, string> dictionary = this.parameters;
				string key = "language";
				int num = (int)lang;
				dictionary[key] = num.ToString();
			}
			return this;
		}

		// Token: 0x0600002A RID: 42 RVA: 0x0000364C File Offset: 0x0000184C
		public CaptchaConfig SetSoftId(string softId)
		{
			this.parameters["soft_id"] = softId;
			return this;
		}

		// Token: 0x0400002B RID: 43
		private Dictionary<string, string> parameters;
	}
}
