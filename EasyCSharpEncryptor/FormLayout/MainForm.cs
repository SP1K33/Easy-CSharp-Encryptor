using EasyCSharpEncryptor.App;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using EasyCSharpEncryptor.Features;

namespace EasyCSharpEncryptor.FormLayout
{
	public partial class MainForm : ControllableFormBase
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private enum AnimationState { Opening, Closing }
		private AnimationState _animationState;
		private Form _currentChildForm;

		public override void Init()
		{
			base.Init();
			OpenChildForm(Proxy.StorageEntryForm);
			PlayOpenAnimation();
		}

		protected override void OnEnable()
		{
			MouseDown += OnMousePressed;
			WarningText.Visible = false;
			Title.MouseDown += OnMousePressed;
			ChildFormContainerPanel.MouseDown += OnMousePressed;
		}

		protected override void OnDisable()
		{
			MouseDown -= OnMousePressed;
			Title.MouseDown -= OnMousePressed;
			ChildFormContainerPanel.MouseDown -= OnMousePressed;
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

		private void OnStorageButtonClicked(object sender, EventArgs e)
		{
			MoveHighlight((Button)sender);
			OpenChildForm(Proxy.StorageEntryForm);
		}

		public void OpenChildForm(Form child)
		{
			if (_currentChildForm == child)
			{
				return;
			}

			Proxy.MainForm.HideTip();
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

		public void ShowTip(string text)
		{
			WarningText.Visible = true;
			WarningText.Text = text;
		}

		public void HideTip()
		{
			WarningText.Visible = false;
		}

		private void MoveHighlight(Button button)
		{
			SelectionHighlight.Location = new Point(button.Location.X, SelectionHighlight.Location.Y);
		}

		private void OnCloseButtonClicked(object sender, EventArgs e)
		{
			PlayCloseAnimation();
		}

		private void PlayCloseAnimation()
		{
			_animationState = AnimationState.Closing;
			AnimationTimer.Start();
		}

		[System.Runtime.InteropServices.DllImport("user32.dll")]
		private static extern int SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);
		[System.Runtime.InteropServices.DllImport("user32.dll")]
		private static extern bool ReleaseCapture();

		private void OnMousePressed(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				ReleaseCapture();
				SendMessage(Handle, 0xA1, 0x2, 0);
			}
		}
	}
}
