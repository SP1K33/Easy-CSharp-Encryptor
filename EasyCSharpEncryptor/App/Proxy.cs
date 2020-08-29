using EasyCSharpEncryptor.Data;
using EasyCSharpEncryptor.Features;
using EasyCSharpEncryptor.FormLayout;

namespace EasyCSharpEncryptor.App
{
	public static class Proxy
	{
		public static PasswordGenerator PasswordGenerator { get; private set; }
		public static Cryptor Cryptor { get; private set; }
		public static DataContainer DataContainer { get; private set; }
		public static MainForm MainForm { get; private set; }
		public static PasswordGeneratorForm PasswordGeneratorForm { get; private set; }
		public static EncryptionForm EncryptionForm { get; private set; }

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
