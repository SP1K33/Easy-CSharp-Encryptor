using System.Collections.Generic;

namespace EasyCSharpEncryptor.Data
{
	public struct StorageData
	{
		public struct PersonalData
		{
			public string Name;
			public string Login;
			public string EncryptedPassword;
		}

		public string StorageName;
		public List<PersonalData> Container;
	}
}