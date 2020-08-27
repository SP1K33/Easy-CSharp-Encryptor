﻿namespace EasyCSharpEncryptor.FormLayout
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
			this.CryptButton = new System.Windows.Forms.Button();
			this.ResultTextBox = new System.Windows.Forms.TextBox();
			this.SourceTextBox = new System.Windows.Forms.TextBox();
			this.SourceLabel = new System.Windows.Forms.Label();
			this.ResultLabel = new System.Windows.Forms.Label();
			this.ClearPasswordButton = new System.Windows.Forms.Button();
			this.PasswordLabel = new System.Windows.Forms.Label();
			this.PasswordTextBox = new System.Windows.Forms.TextBox();
			this.SwitchMode = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// CryptButton
			// 
			this.CryptButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.CryptButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.CryptButton.Font = new System.Drawing.Font("Century Gothic", 12F);
			this.CryptButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
			this.CryptButton.Location = new System.Drawing.Point(380, 110);
			this.CryptButton.Name = "CryptButton";
			this.CryptButton.Size = new System.Drawing.Size(26, 155);
			this.CryptButton.TabIndex = 26;
			this.CryptButton.Text = "→";
			this.CryptButton.UseVisualStyleBackColor = true;
			this.CryptButton.Click += new System.EventHandler(this.OnCryptButtonClicked);
			// 
			// ResultTextBox
			// 
			this.ResultTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
			this.ResultTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
			this.ResultTextBox.Location = new System.Drawing.Point(415, 110);
			this.ResultTextBox.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.ResultTextBox.MinimumSize = new System.Drawing.Size(358, 155);
			this.ResultTextBox.Multiline = true;
			this.ResultTextBox.Name = "ResultTextBox";
			this.ResultTextBox.ReadOnly = true;
			this.ResultTextBox.Size = new System.Drawing.Size(358, 155);
			this.ResultTextBox.TabIndex = 32;
			// 
			// SourceTextBox
			// 
			this.SourceTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
			this.SourceTextBox.ForeColor = System.Drawing.Color.Green;
			this.SourceTextBox.Location = new System.Drawing.Point(14, 110);
			this.SourceTextBox.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.SourceTextBox.MinimumSize = new System.Drawing.Size(358, 155);
			this.SourceTextBox.Multiline = true;
			this.SourceTextBox.Name = "SourceTextBox";
			this.SourceTextBox.Size = new System.Drawing.Size(358, 155);
			this.SourceTextBox.TabIndex = 33;
			// 
			// SourceLabel
			// 
			this.SourceLabel.AutoSize = true;
			this.SourceLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
			this.SourceLabel.Location = new System.Drawing.Point(155, 85);
			this.SourceLabel.Name = "SourceLabel";
			this.SourceLabel.Size = new System.Drawing.Size(67, 21);
			this.SourceLabel.TabIndex = 34;
			this.SourceLabel.Text = "Source:";
			// 
			// ResultLabel
			// 
			this.ResultLabel.AutoSize = true;
			this.ResultLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
			this.ResultLabel.Location = new System.Drawing.Point(562, 85);
			this.ResultLabel.Name = "ResultLabel";
			this.ResultLabel.Size = new System.Drawing.Size(60, 21);
			this.ResultLabel.TabIndex = 35;
			this.ResultLabel.Text = "Result:";
			// 
			// ClearPasswordButton
			// 
			this.ClearPasswordButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ClearPasswordButton.BackgroundImage")));
			this.ClearPasswordButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.ClearPasswordButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.ClearPasswordButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ClearPasswordButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
			this.ClearPasswordButton.Location = new System.Drawing.Point(745, 10);
			this.ClearPasswordButton.Name = "ClearPasswordButton";
			this.ClearPasswordButton.Size = new System.Drawing.Size(29, 29);
			this.ClearPasswordButton.TabIndex = 38;
			this.ClearPasswordButton.UseVisualStyleBackColor = true;
			this.ClearPasswordButton.Click += new System.EventHandler(this.OnClearPasswordClicked);
			// 
			// PasswordLabel
			// 
			this.PasswordLabel.AutoSize = true;
			this.PasswordLabel.Font = new System.Drawing.Font("Century Gothic", 12F);
			this.PasswordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
			this.PasswordLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.PasswordLabel.Location = new System.Drawing.Point(13, 15);
			this.PasswordLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.PasswordLabel.Name = "PasswordLabel";
			this.PasswordLabel.Size = new System.Drawing.Size(86, 21);
			this.PasswordLabel.TabIndex = 37;
			this.PasswordLabel.Text = "Password:";
			// 
			// PasswordTextBox
			// 
			this.PasswordTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
			this.PasswordTextBox.ForeColor = System.Drawing.Color.Green;
			this.PasswordTextBox.Location = new System.Drawing.Point(108, 12);
			this.PasswordTextBox.MinimumSize = new System.Drawing.Size(579, 27);
			this.PasswordTextBox.Name = "PasswordTextBox";
			this.PasswordTextBox.Size = new System.Drawing.Size(631, 27);
			this.PasswordTextBox.TabIndex = 36;
			// 
			// SwitchMode
			// 
			this.SwitchMode.Cursor = System.Windows.Forms.Cursors.Hand;
			this.SwitchMode.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.SwitchMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.SwitchMode.Font = new System.Drawing.Font("Century Gothic", 12F);
			this.SwitchMode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
			this.SwitchMode.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.SwitchMode.Location = new System.Drawing.Point(14, 48);
			this.SwitchMode.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.SwitchMode.Name = "SwitchMode";
			this.SwitchMode.Size = new System.Drawing.Size(759, 32);
			this.SwitchMode.TabIndex = 39;
			this.SwitchMode.Text = "Encrypt";
			this.SwitchMode.UseVisualStyleBackColor = true;
			this.SwitchMode.Click += new System.EventHandler(this.OnSwitchModeClicked);
			// 
			// EncryptionForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
			this.ClientSize = new System.Drawing.Size(782, 272);
			this.Controls.Add(this.SwitchMode);
			this.Controls.Add(this.ClearPasswordButton);
			this.Controls.Add(this.PasswordLabel);
			this.Controls.Add(this.PasswordTextBox);
			this.Controls.Add(this.ResultLabel);
			this.Controls.Add(this.SourceLabel);
			this.Controls.Add(this.SourceTextBox);
			this.Controls.Add(this.ResultTextBox);
			this.Controls.Add(this.CryptButton);
			this.Font = new System.Drawing.Font("Century Gothic", 12F);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(5);
			this.Name = "EncryptionForm";
			this.Text = "EncryptionForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button CryptButton;
		private System.Windows.Forms.TextBox ResultTextBox;
		private System.Windows.Forms.TextBox SourceTextBox;
		private System.Windows.Forms.Label SourceLabel;
		private System.Windows.Forms.Label ResultLabel;
		private System.Windows.Forms.Button ClearPasswordButton;
		private System.Windows.Forms.Label PasswordLabel;
		private System.Windows.Forms.TextBox PasswordTextBox;
		private System.Windows.Forms.Button SwitchMode;
	}
}