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
		public static StorageHolder StorageHolder { get; private set; }

		public static MainForm MainForm { get; private set; }
		public static PasswordGeneratorForm PasswordGeneratorForm { get; private set; }
		public static EncryptionForm EncryptionForm { get; private set; }
		public static StorageEntryForm StorageEntryForm { get; private set; }
		public static CreateStorageForm CreateStorageForm { get; private set; }
		public static StorageViewForm StorageViewForm { get; private set; }

		public static void Init()
		{
			DataContainer = new DataContainer();
			DataContainer.Init();

			PasswordGeneratorForm = new PasswordGeneratorForm();
			EncryptionForm = new EncryptionForm();
			CreateStorageForm = new CreateStorageForm();
			StorageEntryForm = new StorageEntryForm();
			StorageViewForm = new StorageViewForm();
			MainForm = new MainForm();

			StorageHolder = new StorageHolder();
			PasswordGenerator = new PasswordGenerator();
			Cryptor = new Cryptor();

			PasswordGeneratorForm.Init();
			EncryptionForm.Init();
			CreateStorageForm.Init();
			StorageEntryForm.Init();
			MainForm.Init();
			StorageHolder.Init();
			PasswordGenerator.Init();
			Cryptor.Init();
		}
	}
}
