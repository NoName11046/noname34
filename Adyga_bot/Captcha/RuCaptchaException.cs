using System;

namespace Adyga_bot
{
	// Token: 0x02000011 RID: 17
	public class RuCaptchaException : Exception
	{
		// Token: 0x06000054 RID: 84 RVA: 0x0000656B File Offset: 0x0000476B
		public RuCaptchaException()
		{
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00006575 File Offset: 0x00004775
		public RuCaptchaException(string message) : base(message)
		{
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00006580 File Offset: 0x00004780
		public RuCaptchaException(string message, Exception inner) : base(message, inner)
		{
		}
	}
}
