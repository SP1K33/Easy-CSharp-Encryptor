namespace EasyCSharpEncryptor.FormLayout
{
	partial class EncryptionForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EncryptionForm));
			this.PasswordTextBox = new System.Windows.Forms.TextBox();
			this.PasswordLabel = new System.Windows.Forms.Label();
			this.ClearPasswordButton = new System.Windows.Forms.Button();
			this.EncryptButton = new System.Windows.Forms.Button();
			this.ResultTextBox = new System.Windows.Forms.TextBox();
			this.SourceTextBox = new System.Windows.Forms.TextBox();
			this.SourceLabel = new System.Windows.Forms.Label();
			this.ResultLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// PasswordTextBox
			// 
			this.PasswordTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
			this.PasswordTextBox.ForeColor = System.Drawing.Color.Green;
			this.PasswordTextBox.Location = new System.Drawing.Point(107, 229);
			this.PasswordTextBox.MinimumSize = new System.Drawing.Size(579, 27);
			this.PasswordTextBox.Name = "PasswordTextBox";
			this.PasswordTextBox.Size = new System.Drawing.Size(631, 27);
			this.PasswordTextBox.TabIndex = 0;
			// 
			// PasswordLabel
			// 
			this.PasswordLabel.AutoSize = true;
			this.PasswordLabel.Font = new System.Drawing.Font("Century Gothic", 12F);
			this.PasswordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
			this.PasswordLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.PasswordLabel.Location = new System.Drawing.Point(12, 232);
			this.PasswordLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.PasswordLabel.Name = "PasswordLabel";
			this.PasswordLabel.Size = new System.Drawing.Size(86, 21);
			this.PasswordLabel.TabIndex = 22;
			this.PasswordLabel.Text = "Password:";
			// 
			// ClearPasswordButton
			// 
			this.ClearPasswordButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ClearPasswordButton.BackgroundImage")));
			this.ClearPasswordButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.ClearPasswordButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.ClearPasswordButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ClearPasswordButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
			this.ClearPasswordButton.Location = new System.Drawing.Point(744, 228);
			this.ClearPasswordButton.Name = "ClearPasswordButton";
			this.ClearPasswordButton.Size = new System.Drawing.Size(29, 29);
			this.ClearPasswordButton.TabIndex = 23;
			this.ClearPasswordButton.UseVisualStyleBackColor = true;
			this.ClearPasswordButton.Click += new System.EventHandler(this.OnClearPasswordButtonClicked);
			// 
			// EncryptButton
			// 
			this.EncryptButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.EncryptButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.EncryptButton.Font = new System.Drawing.Font("Century Gothic", 12F);
			this.EncryptButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
			this.EncryptButton.Location = new System.Drawing.Point(380, 33);
			this.EncryptButton.Name = "EncryptButton";
			this.EncryptButton.Size = new System.Drawing.Size(26, 185);
			this.EncryptButton.TabIndex = 26;
			this.EncryptButton.Text = "→";
			this.EncryptButton.UseVisualStyleBackColor = true;
			// 
			// ResultTextBox
			// 
			this.ResultTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
			this.ResultTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
			this.ResultTextBox.Location = new System.Drawing.Point(415, 33);
			this.ResultTextBox.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.ResultTextBox.MinimumSize = new System.Drawing.Size(358, 185);
			this.ResultTextBox.Multiline = true;
			this.ResultTextBox.Name = "ResultTextBox";
			this.ResultTextBox.ReadOnly = true;
			this.ResultTextBox.Size = new System.Drawing.Size(358, 185);
			this.ResultTextBox.TabIndex = 32;
			// 
			// SourceTextBox
			// 
			this.SourceTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
			this.SourceTextBox.ForeColor = System.Drawing.Color.Green;
			this.SourceTextBox.Location = new System.Drawing.Point(14, 33);
			this.SourceTextBox.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.SourceTextBox.MinimumSize = new System.Drawing.Size(358, 185);
			this.SourceTextBox.Multiline = true;
			this.SourceTextBox.Name = "SourceTextBox";
			this.SourceTextBox.Size = new System.Drawing.Size(358, 185);
			this.SourceTextBox.TabIndex = 33;
			// 
			// SourceLabel
			// 
			this.SourceLabel.AutoSize = true;
			this.SourceLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
			this.SourceLabel.Location = new System.Drawing.Point(155, 4);
			this.SourceLabel.Name = "SourceLabel";
			this.SourceLabel.Size = new System.Drawing.Size(67, 21);
			this.SourceLabel.TabIndex = 34;
			this.SourceLabel.Text = "Source:";
			// 
			// ResultLabel
			// 
			this.ResultLabel.AutoSize = true;
			this.ResultLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
			this.ResultLabel.Location = new System.Drawing.Point(562, 4);
			this.ResultLabel.Name = "ResultLabel";
			this.ResultLabel.Size = new System.Drawing.Size(60, 21);
			this.ResultLabel.TabIndex = 35;
			this.ResultLabel.Text = "Result:";
			// 
			// EncryptionForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
			this.ClientSize = new System.Drawing.Size(782, 272);
			this.Controls.Add(this.ResultLabel);
			this.Controls.Add(this.SourceLabel);
			this.Controls.Add(this.SourceTextBox);
			this.Controls.Add(this.ResultTextBox);
			this.Controls.Add(this.EncryptButton);
			this.Controls.Add(this.ClearPasswordButton);
			this.Controls.Add(this.PasswordLabel);
			this.Controls.Add(this.PasswordTextBox);
			this.Font = new System.Drawing.Font("Century Gothic", 12F);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(5);
			this.Name = "EncryptionForm";
			this.Text = "EncryptionForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox PasswordTextBox;
		private System.Windows.Forms.Label PasswordLabel;
		private System.Windows.Forms.Button ClearPasswordButton;
		private System.Windows.Forms.Button EncryptButton;
		private System.Windows.Forms.TextBox ResultTextBox;
		private System.Windows.Forms.TextBox SourceTextBox;
		private System.Windows.Forms.Label SourceLabel;
		private System.Windows.Forms.Label ResultLabel;
	}
}