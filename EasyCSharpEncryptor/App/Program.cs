using System;
using System.Windows.Forms;
using EasyCSharpEncryptor.Containers;
using EasyCSharpEncryptor.Dependency;

namespace EasyCSharpEncryptor.App
{
	public static class Program
	{
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			FormsContainer.CreateForms();
			FeaturesContainer.CreateFeatures();

			FeaturesContainer.DataContainer.Init();
			DependencyManager.Init();

			Application.Run(FormsContainer.MainForm);
		}
	}
}
