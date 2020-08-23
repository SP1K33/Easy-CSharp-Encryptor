using EasyCSharpEncryptor.App;
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

			Init();
		}

		private enum AnimationState { Opening, Closing }
		private AnimationState _animationState;
		private Form _currentChildForm;

		public event Action DecryptionButtonClickEvent;

		private void Init()
		{
			MouseDown += OnMousePressed;
			WarningText.Visible = false;
			Title.MouseDown += OnMousePressed;
			ChildFormContainerPanel.MouseDown += OnMousePressed;
			OpenChildForm(Proxy.EncryptionForm);
			PlayOpenAnimation();
		}

		private void OnDecryptionButtonClicked(object sender, EventArgs e)
		{
			MoveHighlight((Button)sender);
			DecryptionButtonClickEvent?.Invoke();
		}

		private void OnEncryptionButtonClicked(object sender, EventArgs e)
		{
			MoveHighlight((Button)sender);
			OpenChildForm(Proxy.EncryptionForm);
		}

		private void OnPasswordGenerationButtonClicked(object sender, EventArgs e)
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
			ChildFormContainerPanel.Controls.Add(_currentChildForm);
			_currentChildForm.Show();
		}

		private void PlayOpenAnimation()
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
