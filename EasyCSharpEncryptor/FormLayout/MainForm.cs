using System;
using System.Drawing;
using System.Windows.Forms;
using EasyCSharpEncryptor.App;
using EasyCSharpEncryptor.Data;

namespace EasyCSharpEncryptor.FormLayout
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
			MouseDown += OnMousePressed;
			WarningText.Visible = false;
			RestoreData();
		}

		public event Action DecryptionButtonClickEvent;

		private void OnDecryptionButtonClicked(object sender, System.EventArgs e)
		{
			MoveHighlight((Button)sender);

			DecryptionButtonClickEvent?.Invoke();
		}

		private void OnEncryptionButtonClicked(object sender, System.EventArgs e)
		{
			MoveHighlight((Button)sender);
		}

		private void RestoreData()
		{
			RestorePasswordLayout();
		}

		private void RestorePasswordLayout()
		{
			var data = Proxy.DataContainer.GetData<PasswordGenerationData>();
			PasswordLengthTextBox.Text = data.Length.ToString();

			if (data.IncludeAmbiguous)
			{
				IncludeAmbiguousCheckbox.CheckState = CheckState.Checked;
			}

			if (data.IncludeLowercase)
			{
				IncludeLowercaseCheckbox.CheckState = CheckState.Checked;
			}

			if (data.IncludeNumbers)
			{
				IncludeNumbersCheckBox.CheckState = CheckState.Checked;
			}

			if (data.IncludeSymbols)
			{
				IncludeSymbolsCheckbox.CheckState = CheckState.Checked;
			}

			if (data.IncludeUppercase)
			{
				IncludeUppercaseCheckbox.CheckState = CheckState.Checked;
			}
		}
	}
}
