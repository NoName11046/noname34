using System;
using System.Collections.Generic;

namespace Adyga_bot
{
	internal static class Log
	{
		public static void Push(string s)
		{
			bool flag = !Log.enabled;
			bool flag2 = !flag;
			bool flag3 = flag2;
			if (flag3)
			{
				Log.toPush.Enqueue(" [" + DateTime.Now.ToString("HH.mm.ss") + "] " + s);
			}
		}

		public static Queue<string> toPush = new Queue<string>();

		public static bool enabled = true;
	}
}
