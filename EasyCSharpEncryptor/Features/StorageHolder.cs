using System;
using EasyCSharpEncryptor.App;
using EasyCSharpEncryptor.Data;
using EasyCSharpEncryptor.Responses;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace EasyCSharpEncryptor.Features
{
	public class StorageHolder
	{
		private StorageData _currentData;

		public void Init()
		{
			Proxy.CreateStorageForm.CreateStorageButtonClickEvent += OnCreateStorageButtonClicked;
			Proxy.Cryptor.EncryptionCompleteEvent += OnEncryptionCompleted;
			Proxy.StorageEntryForm.StorageRemoveEvent += OnStorageRemoved;
		}

		~StorageHolder()
		{
			Proxy.CreateStorageForm.CreateStorageButtonClickEvent -= OnCreateStorageButtonClicked;
			Proxy.Cryptor.EncryptionCompleteEvent -= OnEncryptionCompleted;
			Proxy.StorageEntryForm.StorageRemoveEvent -= OnStorageRemoved;
		}

		public event Action<StorageCreateResponse> StorageCreateEvent;

		private StorageCreateResponse GetCreateResponse(string name)
		{
			if (string.IsNullOrEmpty(name))
			{
				return StorageCreateResponse.NameIsEmpty;
			}

			if (!Regex.IsMatch(name, "^[^#%&*:<>?/{|}]+$"))
			{
				return StorageCreateResponse.NameIsIncorrect;
			}

			return StorageCreateResponse.Success;
		}


		private void OnCreateStorageButtonClicked(string name, string masterKey)
		{
			var response = GetCreateResponse(name);

			if (response != StorageCreateResponse.Success)
			{
				StorageCreateEvent?.Invoke(response);
				return;
			}

			name = name.Replace(" ", "");

			_currentData = new StorageData
			{
				StorageName = name
			};

			var inputData = new Cryptor.EncryptionInputData
			{
				Salt = Proxy.Cryptor.GetMasterSalt(),
				Mode = EncryptionMode.Encryption,
				Password = masterKey,
				Source = SerializeStorageData()
			};

			Proxy.Cryptor.Perform(inputData);
		}

		private string SerializeStorageData()
		{
			using (var memoryStream = new MemoryStream())
			{
				var serializer = new XmlSerializer(typeof(StorageData));
				serializer.Serialize(memoryStream, _currentData);
				return Encoding.UTF8.GetString(memoryStream.ToArray());
			}
		}

		private string GetStoragePath(string storageName)
		{
			string fileName = $"{storageName}.storage";
			return Path.Combine(Application.StartupPath, fileName);
		}

		private void OnEncryptionCompleted(string result, EncryptionResponse response)
		{
			if (response != EncryptionResponse.Success || !Proxy.CreateStorageForm.Visible)
			{
				return;
			}

			File.WriteAllText(GetStoragePath(_currentData.StorageName), result);
			StorageCreateEvent?.Invoke(StorageCreateResponse.Success);
		}

		private void OnStorageRemoved(string storagePath)
		{
			File.Delete(GetStoragePath(storagePath));
		}
	}
}