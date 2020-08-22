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

		public static void Init(MainForm form)
		{
			MainForm = form;

			PasswordGenerator = new PasswordGenerator();

			DataContainer = new DataContainer();
			DataContainer.Init();
		}
	}
}
