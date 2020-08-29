using System;
using System.Windows.Forms;

namespace EasyCSharpEncryptor.FormLayout
{
	public partial class EncryptionForm : Form
	{
		public EncryptionForm()
		{
			InitializeComponent();
			Mode = CryptMode.Encryption;
			SwitchMode.Text = Enum.GetName(typeof(CryptMode), (int)Mode);
		}

		public Action CryptButtonClickEvent;

		public enum CryptMode
		{
			Encryption, 
			Decryption
		}

		public CryptMode Mode { get; private set; }

		private void OnCryptButtonClicked(object sender, EventArgs e)
		{
			CryptButtonClickEvent?.Invoke();
		}

		public void SetResultText(string text)
		{
			ResultTextBox.Text = text;
		}

		public string GetSource()
		{
			return SourceTextBox.Text;
		}

		public string GetPassword()
		{
			return PasswordTextBox.Text;
		}

		private void OnSwitchModeClicked(object sender, EventArgs e)
		{
			Mode = Mode == CryptMode.Encryption ? CryptMode.Decryption : CryptMode.Encryption;
			SwitchMode.Text = Enum.GetName(typeof(CryptMode), (int)Mode);
		}

		private void OnClearPasswordClicked(object sender, EventArgs e)
		{
			PasswordTextBox.Text = string.Empty;
		}
	}
}
