using EasyCSharpEncryptor.App;
using EasyCSharpEncryptor.FormLayout;
using System;
using System.Security.Cryptography;
using System.Text;

namespace EasyCSharpEncryptor.Features
{
	public class Cryptor
	{
		public Cryptor()
		{
			Proxy.EncryptionForm.CryptButtonClickEvent += OnCryptButtonClicked;
			Proxy.EncryptionForm.GenerateSaltButtonClickEvent += OnGenerateSaltButtonClicked;
		}

		~Cryptor()
		{
			Proxy.EncryptionForm.CryptButtonClickEvent -= OnCryptButtonClicked;
			Proxy.EncryptionForm.GenerateSaltButtonClickEvent += OnGenerateSaltButtonClicked;
		}

		private byte[] _salt;

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
			const int saltLengthLimit = 0x20;
			var salt = new byte[saltLengthLimit];
			using (var cryptoServiceProvider = new RNGCryptoServiceProvider())
			{
				cryptoServiceProvider.GetNonZeroBytes(salt);
			}

			return salt;
		}

		private string GeneratePasswordKey()
		{
			int passwordIterations = 0x3E8;
			string password = Proxy.EncryptionForm.GetPassword();
			var deriveBytes = new Rfc2898DeriveBytes(password, _salt, passwordIterations, HashAlgorithmName.SHA256);
			var key = deriveBytes.GetBytes(0x100 / 0xB);
			return Convert.ToBase64String(key);
		}

		private string Encrypt(SymmetricAlgorithm aesEncryption, string source)
		{
			var sourceBytes = Encoding.UTF8.GetBytes(source);
			var cryptoTransform = aesEncryption.CreateEncryptor();
			var cipherText = cryptoTransform.TransformFinalBlock(sourceBytes, 0, sourceBytes.Length);
			return Convert.ToBase64String(cipherText);
		}

		private string Decrypt(SymmetricAlgorithm aesEncryption, string encryptedText)
		{
			var cryptoTransform = aesEncryption.CreateDecryptor();
			string result = string.Empty;

			try
			{
				var encryptedBytes = Convert.FromBase64CharArray(encryptedText.ToCharArray(), 0, encryptedText.Length);
				result = Encoding.UTF8.GetString(
					cryptoTransform.TransformFinalBlock(encryptedBytes, 0, encryptedBytes.Length));
			}
			catch
			{
				Proxy.MainForm.ShowTip("Incorrect password or source text");
			}

			return result;
		}

		private bool CheckFieldsCorrectness()
		{
			if (string.IsNullOrEmpty(Proxy.EncryptionForm.GetPassword()))
			{
				Proxy.MainForm.ShowTip("Password is empty");
				return false;
			}

			if (string.IsNullOrEmpty(Proxy.EncryptionForm.GetSource()))
			{
				Proxy.MainForm.ShowTip("Source is empty");
				return false;
			}

			if (string.IsNullOrEmpty(Proxy.EncryptionForm.GetSaltText()))
			{
				Proxy.MainForm.ShowTip("Salt is empty");
				return false;
			}

			try
			{
				_salt = FromStringToByteArray(Proxy.EncryptionForm.GetSaltText());
			}
			catch
			{
				Proxy.MainForm.ShowTip("Salt is incorrect");
				return false;
			}

			return true;
		}

		private void OnCryptButtonClicked()
		{
			if (!CheckFieldsCorrectness())
			{
				return;
			}

			var aes = MakeAesEncryption();
			string source = Proxy.EncryptionForm.GetSource();

			var result = Proxy.EncryptionForm.Mode == EncryptionForm.CryptMode.Encryption
				? Encrypt(aes, source)
				: Decrypt(aes, source);

			if (!string.IsNullOrEmpty(result))
			{
				Proxy.MainForm.HideWarning();
				Proxy.EncryptionForm.SetResultText(result);
			}
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
			Proxy.EncryptionForm.SetSaltText(BitConverter.ToString(salt));
			Proxy.MainForm.HideWarning();
		}

	}
}