using EasyCSharpEncryptor.FormLayout;
using System;
using System.Windows.Forms;
using EasyCSharpEncryptor.Data;
using EasyCSharpEncryptor.Features;

namespace EasyCSharpEncryptor.App
{
	public static class Program
	{
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			var form = new MainForm();
			Proxy.Init(form);
			Application.Run(form);
		}
	}
}
