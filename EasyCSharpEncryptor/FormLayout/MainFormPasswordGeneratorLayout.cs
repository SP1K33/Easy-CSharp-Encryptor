using System;
using System.Windows.Forms;
using EasyCSharpEncryptor.App;
using EasyCSharpEncryptor.Data;

namespace EasyCSharpEncryptor.FormLayout
{
	public partial class MainForm
	{
		public event Action GeneratePasswordButtonClickEvent;

		public void SetPasswordText(string password)
		{
			PasswordResultTextBox.Text = password;
		}

		private void OnGeneratePasswordButtonClicked(object sender, EventArgs e)
		{
			GeneratePasswordButtonClickEvent?.Invoke();
		}

		private void OnPasswordLengthTextBoxChanged(object sender, EventArgs e)
		{
			var box = sender as TextBox;
			var data = Proxy.DataContainer.GetData<PasswordGenerationData>();
			data.Length = int.Parse(box.Text);
		}

		private void OnIncludeSymbolsCheckBoxChanged(object sender, EventArgs e)
		{
			var box = sender as CheckBox;
			var data = Proxy.DataContainer.GetData<PasswordGenerationData>();
			data.IncludeSymbols = box.CheckState == CheckState.Checked;
		}

		private void OnIncludeLowercaseCheckboxChanged(object sender, EventArgs e)
		{
			var box = sender as CheckBox;
			var data = Proxy.DataContainer.GetData<PasswordGenerationData>();
			data.IncludeLowercase = box.CheckState == CheckState.Checked;
		}

		private void OnIncludeNumbersCheckBoxChanged(object sender, EventArgs e)
		{
			var box = sender as CheckBox;
			var data = Proxy.DataContainer.GetData<PasswordGenerationData>();
			data.IncludeNumbers = box.CheckState == CheckState.Checked;
		}


		private void OnIncludeUppercaseCheckboxChanged(object sender, EventArgs e)
		{
			var box = sender as CheckBox;
			var data = Proxy.DataContainer.GetData<PasswordGenerationData>();
			data.IncludeUppercase = box.CheckState == CheckState.Checked;
		}

		private void OnIncludeAmbiguousCheckboxChanged(object sender, EventArgs e)
		{
			var box = sender as CheckBox;
			var data = Proxy.DataContainer.GetData<PasswordGenerationData>();
			data.IncludeAmbiguous = box.CheckState == CheckState.Checked;
		}

		private void OnPasswordGenerationButtonClicked(object sender, System.EventArgs e)
		{
			MoveHighlight((Button)sender);

			PasswordGeneratorPanel.Visible = true;
		}
	}
}