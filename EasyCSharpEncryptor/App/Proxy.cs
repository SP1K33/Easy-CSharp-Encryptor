using EasyCSharpEncryptor.Data;
using EasyCSharpEncryptor.Features;
using EasyCSharpEncryptor.FormLayout;

namespace EasyCSharpEncryptor.App
{
	public static class Proxy
	{
		public static PasswordGenerator PasswordGenerator;
		public static DataContainer DataContainer;
		public static MainForm MainForm;
		public static PasswordGeneratorForm PasswordGeneratorForm;

		public static void Init()
		{
			DataContainer = new DataContainer();
			DataContainer.Init();

			MainForm = new MainForm();
			PasswordGeneratorForm = new PasswordGeneratorForm();
			
			PasswordGenerator = new PasswordGenerator();
		}
	}
}
