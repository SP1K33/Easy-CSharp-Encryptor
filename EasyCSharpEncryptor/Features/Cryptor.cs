using EasyCSharpEncryptor.App;
using EasyCSharpEncryptor.Responses;
using System;
using System.Security.Cryptography;
using System.Text;
using EasyCSharpEncryptor.Containers;
using EasyCSharpEncryptor.Dependency;

namespace EasyCSharpEncryptor.Features
{
	public class Cryptor : IDependent
	{
		public struct EncryptionInputData
		{
			public string Salt;
			public string Password;
			public string Source;
			public EncryptionMode Mode;
		}

		private readonly Random _random = new Random();
		private const short _minSaltLength = 0x08;
		private const short _maxSaltLength = 0x20;
		private EncryptionInputData _currentInputData;
		private byte[] _saltBytes;

		public event Action<string> SaltGenerateEvent;
		public event Action<string, EncryptionResponse> EncryptionCompleteEvent;

		public void Enable()
		{
			FormsContainer.EncryptionForm.CryptButtonClickEvent += OnCryptButtonClicked;
			FormsContainer.EncryptionForm.GenerateSaltButtonClickEvent += OnGenerateSaltButtonClicked;
		}

		public void Disable()
		{
			FormsContainer.EncryptionForm.CryptButtonClickEvent -= OnCryptButtonClicked;
			FormsContainer.EncryptionForm.GenerateSaltButtonClickEvent -= OnGenerateSaltButtonClicked;
		}

		public string GetMasterSalt()
		{
			var saltBytes = new byte[] { 0x0, 0x0, 0x1, 0x2, 0x3, 0x4, 0x5, 0x6, 0xF1, 0xF0, 0xEE, 0x21, 0x22, 0x45 };
			return BitConverter.ToString(saltBytes);
		}

		private RijndaelManaged MakeAesEncryption()
		{
			return new RijndaelManaged
			{
				KeySize = 0x100,
				BlockSize = 128,
				Mode = CipherMode.ECB,
				Padding = PaddingMode.ISO10126,
				Key = Encoding.UTF8.GetBytes(GeneratePasswordKey()),
			};
		}

		private byte[] GenerateSalt()
		{
			var salt = new byte[_random.Next(_minSaltLength, _maxSaltLength)];
			using (var cryptoServiceProvider = new RNGCryptoServiceProvider())
			{
				cryptoServiceProvider.GetNonZeroBytes(salt);
			}

			return salt;
		}

		private string GeneratePasswordKey()
		{
			int passwordIterations = 0x3E8;
			var deriveBytes = new Rfc2898DeriveBytes(_currentInputData.Password, _saltBytes, passwordIterations, HashAlgorithmName.SHA256);
			var key = deriveBytes.GetBytes(0x100 / 0xB);
			return Convert.ToBase64String(key);
		}

		private string Encrypt(SymmetricAlgorithm aesEncryption)
		{
			var sourceBytes = Encoding.UTF8.GetBytes(_currentInputData.Source);
			var cryptoTransform = aesEncryption.CreateEncryptor();
			var cipherText = cryptoTransform.TransformFinalBlock(sourceBytes, 0, sourceBytes.Length);
			return Convert.ToBase64String(cipherText);
		}

		private string Decrypt(SymmetricAlgorithm aesEncryption)
		{
			var cryptoTransform = aesEncryption.CreateDecryptor();
			string result = string.Empty;

			try
			{
				var encryptedBytes = Convert.FromBase64CharArray(_currentInputData.Source.ToCharArray(),
					0, _currentInputData.Source.Length);
				result = Encoding.UTF8.GetString(
					cryptoTransform.TransformFinalBlock(encryptedBytes, 0, encryptedBytes.Length));
			}
			catch { }

			return result;
		}

		private EncryptionResponse ValidateInputData()
		{
			if (string.IsNullOrEmpty(_currentInputData.Password))
			{
				return EncryptionResponse.PasswordIsEmpty;
			}

			if (string.IsNullOrEmpty(_currentInputData.Source))
			{
				return EncryptionResponse.SourceIsEmpty;
			}

			if (string.IsNullOrEmpty(_currentInputData.Salt))
			{
				return EncryptionResponse.SaltIsEmpty;
			}

			try
			{
				_saltBytes = FromStringToByteArray(_currentInputData.Salt);
			}
			catch
			{
				return EncryptionResponse.SaltIsIncorrect;
			}

			if (_saltBytes.Length < _minSaltLength)
			{
				return EncryptionResponse.SaltIsLessThan8Bytes;
			}

			if (_saltBytes.Length > _maxSaltLength)
			{
				return EncryptionResponse.SaltIsMoreThan32Bytes;
			}

			return EncryptionResponse.Success;
		}

		public void Perform(EncryptionInputData data)
		{
			_currentInputData = data;

			var response = ValidateInputData();

			if (response != EncryptionResponse.Success)
			{
				EncryptionCompleteEvent?.Invoke(string.Empty, response);
				return;
			}

			var result = GetEncryptionResult();

			if (string.IsNullOrEmpty(result) && _currentInputData.Mode == EncryptionMode.Decryption)
			{
				response = EncryptionResponse.DecryptionFail;
			}

			EncryptionCompleteEvent?.Invoke(result, response);
		}

		private void OnCryptButtonClicked(EncryptionInputData data)
		{
			Perform(data);
		}

		private string GetEncryptionResult()
		{
			return _currentInputData.Mode == EncryptionMode.Encryption
				? PerformEncryption(_currentInputData)
				: PerformDecryption(_currentInputData);
		}

		private string PerformEncryption(EncryptionInputData data)
		{
			_currentInputData = data;
			var aes = MakeAesEncryption();
			return Encrypt(aes);
		}

		private string PerformDecryption(EncryptionInputData data)
		{
			_currentInputData = data;
			var aes = MakeAesEncryption();
			return Decrypt(aes);
		}

		private byte[] FromStringToByteArray(string source)
		{
			int length = (source.Length + 1) / 3;
			var result = new byte[length];
			for (int i = 0; i < length; ++i)
			{
				result[i] = Convert.ToByte(source.Substring(3 * i, 2), 0x10);
			}
			return result;
		}

		private void OnGenerateSaltButtonClicked()
		{
			var salt = GenerateSalt();
			SaltGenerateEvent?.Invoke(BitConverter.ToString(salt));
		}
	}
}