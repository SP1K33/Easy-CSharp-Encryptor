using EasyCSharpEncryptor.App;
using EasyCSharpEncryptor.Data;
using System;
using System.Diagnostics;
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
			Title.MouseDown += OnMousePressed;
			ChildFormContainerPanel.MouseDown += OnMousePressed;

			AnimateOpening();
		}

		private enum AnimationState { Opening, Closing }
		private AnimationState _animationState;
		private Form _currentChildForm;

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

		private void OnPasswordGenerationButtonClicked(object sender, System.EventArgs e)
		{
			MoveHighlight((Button)sender);

			OpenChildForm(Proxy.PasswordGeneratorForm);
		}

		private void OpenChildForm(Form child)
		{
			if (_currentChildForm == child)
			{
				return;
			}
			_currentChildForm?.Hide();
			_currentChildForm = child;
			_currentChildForm.TopLevel = false;
			_currentChildForm.TopMost = true;
			_currentChildForm.FormBorderStyle = FormBorderStyle.None;
			ChildFormContainerPanel.Controls.Add(_currentChildForm);
			ChildFormContainerPanel.Tag = _currentChildForm;
			_currentChildForm.BringToFront();
			_currentChildForm.Show();
		}

		private void AnimateOpening()
		{
			Opacity = 0.0;
			_animationState = AnimationState.Opening;
			AnimationTimer.Start();
		}

		private void OnTimerTick(object sender, EventArgs e)
		{
			const double fadePerTick = 0.075;
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

		private void OnGitHubButtonClicked(object sender, EventArgs e)
		{
			const string link = "https://github.com/SP1K33/Easy-CSharp-Encryptor";
			Process.Start(link);
		}
	}
}
