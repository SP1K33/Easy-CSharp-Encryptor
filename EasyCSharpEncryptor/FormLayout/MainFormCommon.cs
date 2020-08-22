using System;
using System.Drawing;
using System.Windows.Forms;

namespace EasyCSharpEncryptor.FormLayout
{
	public partial class MainForm
	{
		public void ShowWarning(string text)
		{
			WarningText.Visible = true;
			WarningText.Text = text;
		}

		public void HideWarning()
		{
			this.WarningText.Visible = false;
		}

		private void MoveHighlight(Button button)
		{
			
			SelectionHighlight.Location = new Point(button.Location.X, SelectionHighlight.Location.Y);
		}

		private void OnCloseButtonClicked(object sender, System.EventArgs e)
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