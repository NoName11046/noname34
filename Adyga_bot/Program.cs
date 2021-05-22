using Adyga_bot.Forms;
using System;
using System.Windows.Forms;

namespace Adyga_bot
{
	internal static class Program
	{
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new LoginForm());
		}
	}
}
