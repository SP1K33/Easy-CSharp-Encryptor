using System;
using System.Drawing;
using System.Windows.Forms;

namespace EasyCSharpEncryptor
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
			MouseDown += OnMousePressed;
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

		private void OnPasswordGenerationButtonClicked(object sender, System.EventArgs e)
		{
			MoveHighlight((Button)sender);

			PasswordGeneratorPanel.Visible = true;
		}

		private void OnCloseButtonClicked(object sender, System.EventArgs e)
		{
			Dispose(true);
		}

		private void MoveHighlight(Button button)
		{
			HidePanels();
			SelectionHighlight.Location = new Point(button.Location.X, SelectionHighlight.Location.Y);
		}

		private void HidePanels()
		{
			PasswordGeneratorPanel.Visible = false;
		}

		[System.Runtime.InteropServices.DllImport("user32.dll")]
		private static extern int SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);
		[System.Runtime.InteropServices.DllImport("user32.dll")]
		private static extern bool ReleaseCapture();

		private void OnMousePressed(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				ReleaseCapture();
				SendMessage(Handle, 0xA1, 0x2, 0);
			}
		}

		private void OnGeneratePasswordButtonClicked(object sender, EventArgs e)
		{

		}

		private void OnPasswordLengthTextBoxChanged(object sender, EventArgs e)
		{

		}

		private void OnIncludeSymbolsCheckBoxChanged(object sender, EventArgs e)
		{

		}

		private void OnIncludeLowercaseCheckboxChanged(object sender, EventArgs e)
		{

		}
	}
}
