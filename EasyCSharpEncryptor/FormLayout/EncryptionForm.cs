using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyCSharpEncryptor.FormLayout
{
	public partial class EncryptionForm : Form
	{
		public EncryptionForm()
		{
			InitializeComponent();
		}

		private void OnClearPasswordButtonClicked(object sender, EventArgs e)
		{
			PasswordTextBox.Text = string.Empty;
		}
	}
}
