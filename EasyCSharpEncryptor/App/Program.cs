using System;
using System.Windows.Forms;

namespace EasyCSharpEncryptor.App
{
	public static class Program
	{
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Proxy.Init();
			Application.Run(Proxy.MainForm);
		}
	}
}
