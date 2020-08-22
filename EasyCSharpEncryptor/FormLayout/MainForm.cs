using System;
using System.Drawing;
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
	}
}
