using EasyCSharpEncryptor.Containers;
using EasyCSharpEncryptor.Dependency;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Windows.Forms;

namespace EasyCSharpEncryptor.FormLayout
{
	public partial class MainForm : ControllableFormBase
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private enum AnimationState 
		{ 
			Unknown = 0, 
			Opening,
			Minimizing,
			Maximizing,
			Closing
		}

		private AnimationState _animationState;

		protected override void OnInit()
		{
			PlayOpenAnimation();
			OnEncryptionButtonClicked(EncryptionButton, null);
		}

		protected override void OnEnable()
		{
			MouseDown += OnMousePressed;
			WarningText.Visible = false;
			Title.MouseDown += OnMousePressed;
			ChildFormContainerPanel.MouseDown += OnMousePressed;
			Resize += OnResized;
		}

		protected override void OnDisable()
		{
			MouseDown -= OnMousePressed;
			Title.MouseDown -= OnMousePressed;
			ChildFormContainerPanel.MouseDown -= OnMousePressed;
			Resize -= OnResized;
		}

		private void OnEncryptionButtonClicked(object sender, EventArgs e)
		{
			MoveHighlight((Button)sender);
			DependencyManager.OpenChildForm(FormsContainer.EncryptionForm);
		}

		private void OnPasswordGenerationButtonClicked(object sender, EventArgs e)
		{
			MoveHighlight((Button)sender);
			DependencyManager.OpenChildForm(FormsContainer.PasswordGeneratorForm);
		}


		public void AddChildForm(ControllableFormBase form)
		{
			form.TopLevel = false;
			ChildFormContainerPanel.Controls.Add(form);
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
			if (Opacity < 1.0 && (_animationState == AnimationState.Opening || _animationState == AnimationState.Maximizing))
			{
				Opacity += fadePerTick;
			}
			else if (Opacity > 0.0 && (_animationState == AnimationState.Closing || _animationState == AnimationState.Minimizing))
			{
				Opacity -= fadePerTick;
			}
			else
			{
				AnimationTimer.Stop();
				switch (_animationState)
				{
					case AnimationState.Closing:
						Dispose(true);
						break;
					case AnimationState.Minimizing:
						FormsContainer.MainForm.WindowState = FormWindowState.Minimized;
						break;

				}
			}
		}

		private void OnResized(object sender, EventArgs e)
		{
			if (FormsContainer.MainForm.WindowState == FormWindowState.Normal 
			    && _animationState == AnimationState.Minimizing)
			{
				FormsContainer.MainForm.WindowState = FormWindowState.Normal;
				_animationState = AnimationState.Maximizing;
				AnimationTimer.Start();
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

		private void OnMinimizeButtonClicked(object sender, EventArgs e)
		{
			_animationState = AnimationState.Minimizing;
			AnimationTimer.Start();
		}

		private void PlayCloseAnimation()
		{
			_animationState = AnimationState.Closing;
			AnimationTimer.Start();
		}

		[DllImport("user32.dll")]
		private static extern int SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);
		[DllImport("user32.dll")]
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
