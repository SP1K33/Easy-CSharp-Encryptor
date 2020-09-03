using EasyCSharpEncryptor.FormLayout;

namespace EasyCSharpEncryptor.Containers
{
	public static class FormsContainer
	{
		public static MainForm MainForm { get; private set; }
		public static PasswordGeneratorForm PasswordGeneratorForm { get; private set; }
		public static EncryptionForm EncryptionForm { get; private set; }

		public static void CreateForms()
		{
			PasswordGeneratorForm = new PasswordGeneratorForm();
			EncryptionForm = new EncryptionForm();
			MainForm = new MainForm();
		}
	}
}