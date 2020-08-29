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
		}

		~Cryptor()
		{
			Proxy.EncryptionForm.CryptButtonClickEvent -= OnCryptButtonClicked;
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

		private string GeneratePasswordKey()
		{
			int passwordIterations = 0x3E8;
			byte[] salt = { 0x0, 0x0, 0x1, 0x2, 0x3, 0x4, 0x5, 0x6, 0xF1, 0xF0, 0xEE, 0x21, 0x22, 0x45 };
			string password = Proxy.EncryptionForm.GetPassword();
			var deriveBytes = new Rfc2898DeriveBytes(password, salt, passwordIterations, HashAlgorithmName.SHA256);
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
				result = Encoding.UTF8.GetString(cryptoTransform.TransformFinalBlock(encryptedBytes, 0, encryptedBytes.Length));
			}
			catch
			{
				Proxy.MainForm.ShowWarning("Incorrect password or source text");
			}

			return result;
		}

		private void OnCryptButtonClicked()
		{
			if (string.IsNullOrEmpty(Proxy.EncryptionForm.GetPassword()) ||
			    string.IsNullOrEmpty(Proxy.EncryptionForm.GetSource()))
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
	}
}