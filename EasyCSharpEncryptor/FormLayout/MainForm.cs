using EasyCSharpEncryptor.App;
using EasyCSharpEncryptor.Data;
using System;
using System.Windows.Forms;

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

			AnimateOpening();
		}

		private enum AnimationState { Opening, Closing }
		private AnimationState _animationState;

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

		private void AnimateOpening()
		{
			Opacity = 0.0;
			_animationState = AnimationState.Opening;
			AnimationTimer.Start();
		}

		private void OnTimerTick(object sender, EventArgs e)
		{
			double fadePerTick = 0.075;
			if (Opacity < 1.0 && _animationState == AnimationState.Opening)
			{
				Opacity += fadePerTick;
			}
			else if (Opacity > 0.0 && _animationState == AnimationState.Closing)
			{
				Opacity -= fadePerTick;
			}
			else
			{
				AnimationTimer.Stop();
				if (_animationState == AnimationState.Closing)
				{
					Dispose(true);
				}
			}
		}
	}
}
