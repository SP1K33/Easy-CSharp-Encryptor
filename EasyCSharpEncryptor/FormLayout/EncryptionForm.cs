using System;
using EasyCSharpEncryptor.App;
using EasyCSharpEncryptor.Containers;
using EasyCSharpEncryptor.Features;
using EasyCSharpEncryptor.Responses;

namespace EasyCSharpEncryptor.FormLayout
{
	public partial class EncryptionForm : ControllableFormBase
	{
		public EncryptionForm()
		{
			InitializeComponent();
		}

		public EncryptionMode Mode { get; private set; }

		public event Action<Cryptor.EncryptionInputData> CryptButtonClickEvent;
		public event Action GeneratePasswordButtonClickEvent;
		public event Action GenerateSaltButtonClickEvent;

		protected override void OnInit()
		{
			Mode = EncryptionMode.Encryption;
			SwitchMode.Text = Enum.GetName(typeof(EncryptionMode), (int) Mode);
		}

		protected override void OnEnable()
		{
			FeaturesContainer.PasswordGenerator.PasswordGenerateEvent += OnPasswordGenerated;
			FeaturesContainer.Cryptor.SaltGenerateEvent += OnSaltGenerated;
			FeaturesContainer.Cryptor.EncryptionCompleteEvent += OnEncryptionCompleted;
		}

		protected override void OnDisable()
		{
			FeaturesContainer.PasswordGenerator.PasswordGenerateEvent -= OnPasswordGenerated;
			FeaturesContainer.Cryptor.SaltGenerateEvent -= OnSaltGenerated;
			FeaturesContainer.Cryptor.EncryptionCompleteEvent -= OnEncryptionCompleted;
		}

		private void OnPasswordGenerated(string password, PasswordResponse response)
		{
			if (response == PasswordResponse.Success)
			{
				PasswordTextBox.Text = password;
				FormsContainer.MainForm.HideTip();
			}
			else
			{
				FormsContainer.MainForm.ShowTip("Select at least one of the options");
			}
		}

		private void OnCryptButtonClicked(object sender, EventArgs e)
		{
			var data = new Cryptor.EncryptionInputData
			{
				Password = PasswordTextBox.Text,
				Source = SourceTextBox.Text,
				Salt = SaltTextBox.Text,
				Mode = Mode,
			};

			CryptButtonClickEvent?.Invoke(data);
		}

		private void OnSwitchModeClicked(object sender, EventArgs e)
		{
			Mode = Mode == EncryptionMode.Encryption ? EncryptionMode.Decryption : EncryptionMode.Encryption;
			SwitchMode.Text = Enum.GetName(typeof(EncryptionMode), (int) Mode);
		}

		private void OnClearPasswordClicked(object sender, EventArgs e)
		{
			PasswordTextBox.Text = string.Empty;
		}

		private void OnGeneratePasswordButtonClicked(object sender, EventArgs e)
		{
			GeneratePasswordButtonClickEvent?.Invoke();
		}

		private void OnGenerateSaltButtonClicked(object sender, EventArgs e)
		{
			GenerateSaltButtonClickEvent?.Invoke();
		}

		private void OnClearSaltButtonClicked(object sender, EventArgs e)
		{
			SaltTextBox.Text = string.Empty;
		}

		private void OnEncryptionCompleted(string result, EncryptionResponse response)
		{
			switch (response)
			{
				case EncryptionResponse.Success:
					FormsContainer.MainForm.HideTip();
					ResultTextBox.Text = result;
					break;
				case EncryptionResponse.PasswordIsEmpty:
					FormsContainer.MainForm.ShowTip("Password is empty");
					break;
				case EncryptionResponse.SourceIsEmpty:
					FormsContainer.MainForm.ShowTip("Source is empty");
					break;
				case EncryptionResponse.SaltIsEmpty:
					FormsContainer.MainForm.ShowTip("Salt is empty");
					break;
				case EncryptionResponse.SaltIsIncorrect:
					FormsContainer.MainForm.ShowTip("Salt is incorrect");
					break;
				case EncryptionResponse.SaltIsLessThan8Bytes:
					FormsContainer.MainForm.ShowTip("Salt less than 8 bytes");
					break;
				case EncryptionResponse.SaltIsMoreThan32Bytes:
					FormsContainer.MainForm.ShowTip("Salt more than 32 bytes");
					break;
				case EncryptionResponse.DecryptionFail:
					FormsContainer.MainForm.ShowTip("Incorrect password or source text");
					break;
			}
		}

		private void OnSaltGenerated(string salt)
		{
			SaltTextBox.Text = salt;
			FormsContainer.MainForm.HideTip();
		}
	}
}