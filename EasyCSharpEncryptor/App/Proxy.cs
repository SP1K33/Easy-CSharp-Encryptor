using EasyCSharpEncryptor.Data;
using EasyCSharpEncryptor.Features;
using EasyCSharpEncryptor.FormLayout;

namespace EasyCSharpEncryptor.App
{
	public static class Proxy
	{
		public static PasswordGenerator PasswordGenerator;
		public static Cryptor Cryptor;
		public static DataContainer DataContainer;
		public static MainForm MainForm;
		public static PasswordGeneratorForm PasswordGeneratorForm;
		public static EncryptionForm EncryptionForm;

		public static void Init()
		{
			DataContainer = new DataContainer();
			DataContainer.Init();

			PasswordGeneratorForm = new PasswordGeneratorForm();
			EncryptionForm = new EncryptionForm();

			MainForm = new MainForm();

			PasswordGenerator = new PasswordGenerator();
			Cryptor = new Cryptor();
		}
	}
}
