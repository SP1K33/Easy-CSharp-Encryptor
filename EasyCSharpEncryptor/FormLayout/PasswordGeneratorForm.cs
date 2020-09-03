using System;
using EasyCSharpEncryptor.App;
using EasyCSharpEncryptor.Data;
using System.Windows.Forms;
using EasyCSharpEncryptor.Containers;
using EasyCSharpEncryptor.Features;
using EasyCSharpEncryptor.Responses;

namespace EasyCSharpEncryptor.FormLayout
{
	public partial class PasswordGeneratorForm : ControllableFormBase
	{
		public PasswordGeneratorForm()
		{
			InitializeComponent();
		}

		public event Action GeneratePasswordButtonClickEvent;

		protected override void OnInit()
		{
			RestoreData();
		}

		protected override void OnEnable()
		{
			FeaturesContainer.PasswordGenerator.PasswordGenerateEvent += OnPasswordGenerated;
		}

		protected override void OnDisable()
		{
			FeaturesContainer.PasswordGenerator.PasswordGenerateEvent -= OnPasswordGenerated;
		}

		private void OnPasswordGenerated(string password, PasswordResponse response)
		{
			if (response == PasswordResponse.Success)
			{
				PasswordResultTextBox.Text = password;
				FormsContainer.MainForm.HideTip();
			}
			else
			{
				FormsContainer.MainForm.ShowTip("Select at least one of the options");
			}
		}

		private void RestoreData()
		{
			var data = FeaturesContainer.DataContainer.GetData<PasswordGenerationData>();
			PasswordNumeric.Text = data.Length.ToString();

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

		private void OnGeneratePasswordButtonClicked(object sender, EventArgs e)
		{
			GeneratePasswordButtonClickEvent?.Invoke();
		}

		private void OnIncludeSymbolsCheckBoxChanged(object sender, EventArgs e)
		{
			var box = sender as CheckBox;
			var data = FeaturesContainer.DataContainer.GetData<PasswordGenerationData>();
			data.IncludeSymbols = box.CheckState == CheckState.Checked;
			FeaturesContainer.DataContainer.SaveData(data);
		}

		private void OnIncludeLowercaseCheckboxChanged(object sender, EventArgs e)
		{
			var box = sender as CheckBox;
			var data = FeaturesContainer.DataContainer.GetData<PasswordGenerationData>();
			data.IncludeLowercase = box.CheckState == CheckState.Checked;
			FeaturesContainer.DataContainer.SaveData(data);
		}

		private void OnIncludeNumbersCheckBoxChanged(object sender, EventArgs e)
		{
			var box = sender as CheckBox;
			var data = FeaturesContainer.DataContainer.GetData<PasswordGenerationData>();
			data.IncludeNumbers = box.CheckState == CheckState.Checked;
			FeaturesContainer.DataContainer.SaveData(data);
		}

		private void OnIncludeUppercaseCheckboxChanged(object sender, EventArgs e)
		{
			var box = sender as CheckBox;
			var data = FeaturesContainer.DataContainer.GetData<PasswordGenerationData>();
			data.IncludeUppercase = box.CheckState == CheckState.Checked;
			FeaturesContainer.DataContainer.SaveData(data);
		}

		private void OnIncludeAmbiguousCheckboxChanged(object sender, EventArgs e)
		{
			var box = sender as CheckBox;
			var data = FeaturesContainer.DataContainer.GetData<PasswordGenerationData>();
			data.IncludeAmbiguous = box.CheckState == CheckState.Checked;
			FeaturesContainer.DataContainer.SaveData(data);
		}

		private void OnPasswordNumericChanged(object sender, EventArgs e)
		{
			var numeric = sender as NumericUpDown;
			var data = FeaturesContainer.DataContainer.GetData<PasswordGenerationData>();
			data.Length = !string.IsNullOrEmpty(numeric.Text) ? int.Parse(numeric.Text) : 0;
			FeaturesContainer.DataContainer.SaveData(data);
		}
	}
}
