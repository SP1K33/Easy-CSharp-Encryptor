using EasyCSharpEncryptor.App;
using EasyCSharpEncryptor.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using EasyCSharpEncryptor.Responses;

namespace EasyCSharpEncryptor.Features
{
	public class PasswordGenerator
	{
		~PasswordGenerator()
		{
			Proxy.PasswordGeneratorForm.GeneratePasswordButtonClickEvent -= OnGeneratePasswordClicked;
			Proxy.EncryptionForm.GeneratePasswordButtonClickEvent -= OnGeneratePasswordClicked;
		}

		private const string _symbols = "!'#$%&()+,-.:@[]_`~{}";
		private const string _ambiguous = "/\\:*?<>|";
		private const string _upperCase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
		private const string _lowerCase = "abcdefghijklmnopqrstuvwxyz";
		private const string _numbers = "0123456789";

		private readonly RNGCryptoServiceProvider _rng = new RNGCryptoServiceProvider();
		public event Action<string, PasswordResponse> PasswordGenerateEvent;

		public void Init()
		{
			Proxy.PasswordGeneratorForm.GeneratePasswordButtonClickEvent += OnGeneratePasswordClicked;
			Proxy.EncryptionForm.GeneratePasswordButtonClickEvent += OnGeneratePasswordClicked;
		}

		private void OnGeneratePasswordClicked()
		{
			var password = Next();
			PasswordGenerateEvent?.Invoke(password, string.IsNullOrEmpty(password) ? PasswordResponse.PasswordEmpty : PasswordResponse.Success);
		}

		private string Next()
		{
			var data = Proxy.DataContainer.GetData<PasswordGenerationData>();

			var characterSet = GetCharacterSet();

			if (characterSet.Length == 0)
			{
				return string.Empty;
			}

			characterSet = Shuffle(characterSet);

			var password = new char[data.Length];

			for (int i = 0, maxIdenticalConsecutiveChars = 2; i < data.Length; ++i)
			{
				password[i] = characterSet[GetRandomInRange(0, characterSet.Length - 1)];

				if (i > maxIdenticalConsecutiveChars
					&& password[i] == password[i - 1]
					&& password[i - 1] == password[i - 2])
				{
					i--;
				}
			}

			return string.Join(string.Empty, password);
		}

		private char[] GetCharacterSet()
		{
			string result = string.Empty;
			var data = Proxy.DataContainer.GetData<PasswordGenerationData>();

			if (data.IncludeSymbols)
			{
				result += _symbols;
			}

			if (data.IncludeAmbiguous)
			{
				result += _ambiguous;
			}

			if (data.IncludeLowercase)
			{
				result += _lowerCase;
			}

			if (data.IncludeNumbers)
			{
				result += _numbers;
			}

			if (data.IncludeUppercase)
			{
				result += _upperCase;
			}

			return result.ToCharArray();
		}

		private int GetRandomInRange(int min, int max)
		{
			var data = new byte[sizeof(int)];
			_rng.GetBytes(data);
			var randomNumber = BitConverter.ToInt32(data, 0);

			return (int)Math.Floor((double)(min + Math.Abs(randomNumber % (max - min))));
		}

		private char[] Shuffle(IEnumerable<char> items)
		{
			return items.OrderBy(item => Guid.NewGuid()).ToArray();
		}
	}
}