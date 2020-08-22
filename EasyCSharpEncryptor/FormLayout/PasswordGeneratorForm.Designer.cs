namespace EasyCSharpEncryptor.FormLayout
{
	partial class PasswordGeneratorForm
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
			this.IncludeNumbersCheckBox = new System.Windows.Forms.CheckBox();
			this.PasswordLengthTextBox = new System.Windows.Forms.TextBox();
			this.PasswordLengthLabel = new System.Windows.Forms.Label();
			this.IncludeNumbersLabel = new System.Windows.Forms.Label();
			this.GeneratePasswordButton = new System.Windows.Forms.Button();
			this.PasswordResultTextBox = new System.Windows.Forms.TextBox();
			this.IncludeSymbolsLabel = new System.Windows.Forms.Label();
			this.IncludeAmbiguousCheckbox = new System.Windows.Forms.CheckBox();
			this.IncludeLowercaseLabel = new System.Windows.Forms.Label();
			this.IncludeUppercaseCheckbox = new System.Windows.Forms.CheckBox();
			this.IncludeUppercaseLabel = new System.Windows.Forms.Label();
			this.IncludeLowercaseCheckbox = new System.Windows.Forms.CheckBox();
			this.IncludeAmbiguousCharactersLabel = new System.Windows.Forms.Label();
			this.IncludeSymbolsCheckbox = new System.Windows.Forms.CheckBox();
			this.SuspendLayout();
			// 
			// IncludeNumbersCheckBox
			// 
			this.IncludeNumbersCheckBox.AutoSize = true;
			this.IncludeNumbersCheckBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.IncludeNumbersCheckBox.Location = new System.Drawing.Point(309, 81);
			this.IncludeNumbersCheckBox.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.IncludeNumbersCheckBox.Name = "IncludeNumbersCheckBox";
			this.IncludeNumbersCheckBox.Size = new System.Drawing.Size(15, 14);
			this.IncludeNumbersCheckBox.TabIndex = 33;
			this.IncludeNumbersCheckBox.UseVisualStyleBackColor = true;
			this.IncludeNumbersCheckBox.CheckedChanged += new System.EventHandler(this.OnIncludeNumbersCheckBoxChanged);
			// 
			// PasswordLengthTextBox
			// 
			this.PasswordLengthTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
			this.PasswordLengthTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
			this.PasswordLengthTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
			this.PasswordLengthTextBox.Location = new System.Drawing.Point(309, 9);
			this.PasswordLengthTextBox.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.PasswordLengthTextBox.MaxLength = 3;
			this.PasswordLengthTextBox.Name = "PasswordLengthTextBox";
			this.PasswordLengthTextBox.Size = new System.Drawing.Size(52, 27);
			this.PasswordLengthTextBox.TabIndex = 26;
			this.PasswordLengthTextBox.Text = "888";
			this.PasswordLengthTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.PasswordLengthTextBox.TextChanged += new System.EventHandler(this.OnPasswordLengthTextBoxChanged);
			// 
			// PasswordLengthLabel
			// 
			this.PasswordLengthLabel.AutoSize = true;
			this.PasswordLengthLabel.Font = new System.Drawing.Font("Century Gothic", 12F);
			this.PasswordLengthLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
			this.PasswordLengthLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.PasswordLengthLabel.Location = new System.Drawing.Point(9, 9);
			this.PasswordLengthLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.PasswordLengthLabel.Name = "PasswordLengthLabel";
			this.PasswordLengthLabel.Size = new System.Drawing.Size(141, 21);
			this.PasswordLengthLabel.TabIndex = 21;
			this.PasswordLengthLabel.Text = "Password length:";
			// 
			// IncludeNumbersLabel
			// 
			this.IncludeNumbersLabel.AutoSize = true;
			this.IncludeNumbersLabel.Font = new System.Drawing.Font("Century Gothic", 12F);
			this.IncludeNumbersLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
			this.IncludeNumbersLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.IncludeNumbersLabel.Location = new System.Drawing.Point(9, 81);
			this.IncludeNumbersLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.IncludeNumbersLabel.Name = "IncludeNumbersLabel";
			this.IncludeNumbersLabel.Size = new System.Drawing.Size(148, 21);
			this.IncludeNumbersLabel.TabIndex = 32;
			this.IncludeNumbersLabel.Text = "Include numbers: ";
			// 
			// GeneratePasswordButton
			// 
			this.GeneratePasswordButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.GeneratePasswordButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.GeneratePasswordButton.Font = new System.Drawing.Font("Century Gothic", 12F);
			this.GeneratePasswordButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
			this.GeneratePasswordButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.GeneratePasswordButton.Location = new System.Drawing.Point(15, 230);
			this.GeneratePasswordButton.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.GeneratePasswordButton.Name = "GeneratePasswordButton";
			this.GeneratePasswordButton.Size = new System.Drawing.Size(756, 32);
			this.GeneratePasswordButton.TabIndex = 20;
			this.GeneratePasswordButton.Text = "Generate";
			this.GeneratePasswordButton.UseVisualStyleBackColor = true;
			this.GeneratePasswordButton.Click += new System.EventHandler(this.OnGeneratePasswordButtonClicked);
			// 
			// PasswordResultTextBox
			// 
			this.PasswordResultTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
			this.PasswordResultTextBox.ForeColor = System.Drawing.Color.Green;
			this.PasswordResultTextBox.Location = new System.Drawing.Point(375, 9);
			this.PasswordResultTextBox.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.PasswordResultTextBox.MinimumSize = new System.Drawing.Size(394, 205);
			this.PasswordResultTextBox.Multiline = true;
			this.PasswordResultTextBox.Name = "PasswordResultTextBox";
			this.PasswordResultTextBox.ReadOnly = true;
			this.PasswordResultTextBox.Size = new System.Drawing.Size(394, 205);
			this.PasswordResultTextBox.TabIndex = 31;
			// 
			// IncludeSymbolsLabel
			// 
			this.IncludeSymbolsLabel.AutoSize = true;
			this.IncludeSymbolsLabel.Font = new System.Drawing.Font("Century Gothic", 12F);
			this.IncludeSymbolsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
			this.IncludeSymbolsLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.IncludeSymbolsLabel.Location = new System.Drawing.Point(9, 42);
			this.IncludeSymbolsLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.IncludeSymbolsLabel.Name = "IncludeSymbolsLabel";
			this.IncludeSymbolsLabel.Size = new System.Drawing.Size(232, 21);
			this.IncludeSymbolsLabel.TabIndex = 22;
			this.IncludeSymbolsLabel.Text = "Include symbols (e.g. @#$%):";
			// 
			// IncludeAmbiguousCheckbox
			// 
			this.IncludeAmbiguousCheckbox.AutoSize = true;
			this.IncludeAmbiguousCheckbox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.IncludeAmbiguousCheckbox.Location = new System.Drawing.Point(309, 204);
			this.IncludeAmbiguousCheckbox.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.IncludeAmbiguousCheckbox.Name = "IncludeAmbiguousCheckbox";
			this.IncludeAmbiguousCheckbox.Size = new System.Drawing.Size(15, 14);
			this.IncludeAmbiguousCheckbox.TabIndex = 30;
			this.IncludeAmbiguousCheckbox.UseVisualStyleBackColor = true;
			this.IncludeAmbiguousCheckbox.CheckedChanged += new System.EventHandler(this.OnIncludeAmbiguousCheckboxChanged);
			// 
			// IncludeLowercaseLabel
			// 
			this.IncludeLowercaseLabel.AutoSize = true;
			this.IncludeLowercaseLabel.Font = new System.Drawing.Font("Century Gothic", 12F);
			this.IncludeLowercaseLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
			this.IncludeLowercaseLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.IncludeLowercaseLabel.Location = new System.Drawing.Point(9, 113);
			this.IncludeLowercaseLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.IncludeLowercaseLabel.Name = "IncludeLowercaseLabel";
			this.IncludeLowercaseLabel.Size = new System.Drawing.Size(263, 21);
			this.IncludeLowercaseLabel.TabIndex = 23;
			this.IncludeLowercaseLabel.Text = "Include lowercase (e.g. abcdef):";
			// 
			// IncludeUppercaseCheckbox
			// 
			this.IncludeUppercaseCheckbox.AutoSize = true;
			this.IncludeUppercaseCheckbox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.IncludeUppercaseCheckbox.Location = new System.Drawing.Point(309, 146);
			this.IncludeUppercaseCheckbox.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.IncludeUppercaseCheckbox.Name = "IncludeUppercaseCheckbox";
			this.IncludeUppercaseCheckbox.Size = new System.Drawing.Size(15, 14);
			this.IncludeUppercaseCheckbox.TabIndex = 29;
			this.IncludeUppercaseCheckbox.UseVisualStyleBackColor = true;
			this.IncludeUppercaseCheckbox.CheckedChanged += new System.EventHandler(this.OnIncludeUppercaseCheckboxChanged);
			// 
			// IncludeUppercaseLabel
			// 
			this.IncludeUppercaseLabel.AutoSize = true;
			this.IncludeUppercaseLabel.Font = new System.Drawing.Font("Century Gothic", 12F);
			this.IncludeUppercaseLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
			this.IncludeUppercaseLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.IncludeUppercaseLabel.Location = new System.Drawing.Point(9, 146);
			this.IncludeUppercaseLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.IncludeUppercaseLabel.Name = "IncludeUppercaseLabel";
			this.IncludeUppercaseLabel.Size = new System.Drawing.Size(274, 21);
			this.IncludeUppercaseLabel.TabIndex = 24;
			this.IncludeUppercaseLabel.Text = "Include uppercase (e.g. ABCDEF):";
			// 
			// IncludeLowercaseCheckbox
			// 
			this.IncludeLowercaseCheckbox.AutoSize = true;
			this.IncludeLowercaseCheckbox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.IncludeLowercaseCheckbox.Location = new System.Drawing.Point(309, 113);
			this.IncludeLowercaseCheckbox.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.IncludeLowercaseCheckbox.Name = "IncludeLowercaseCheckbox";
			this.IncludeLowercaseCheckbox.Size = new System.Drawing.Size(15, 14);
			this.IncludeLowercaseCheckbox.TabIndex = 28;
			this.IncludeLowercaseCheckbox.UseVisualStyleBackColor = true;
			this.IncludeLowercaseCheckbox.CheckedChanged += new System.EventHandler(this.OnIncludeLowercaseCheckboxChanged);
			// 
			// IncludeAmbiguousCharactersLabel
			// 
			this.IncludeAmbiguousCharactersLabel.AutoSize = true;
			this.IncludeAmbiguousCharactersLabel.Font = new System.Drawing.Font("Century Gothic", 12F);
			this.IncludeAmbiguousCharactersLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
			this.IncludeAmbiguousCharactersLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.IncludeAmbiguousCharactersLabel.Location = new System.Drawing.Point(9, 178);
			this.IncludeAmbiguousCharactersLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.IncludeAmbiguousCharactersLabel.Name = "IncludeAmbiguousCharactersLabel";
			this.IncludeAmbiguousCharactersLabel.Size = new System.Drawing.Size(253, 42);
			this.IncludeAmbiguousCharactersLabel.TabIndex = 25;
			this.IncludeAmbiguousCharactersLabel.Text = "Include ambiguous characters \r\n/ \\ : * ? \" < > |";
			// 
			// IncludeSymbolsCheckbox
			// 
			this.IncludeSymbolsCheckbox.AutoSize = true;
			this.IncludeSymbolsCheckbox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.IncludeSymbolsCheckbox.Location = new System.Drawing.Point(309, 48);
			this.IncludeSymbolsCheckbox.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.IncludeSymbolsCheckbox.Name = "IncludeSymbolsCheckbox";
			this.IncludeSymbolsCheckbox.Size = new System.Drawing.Size(15, 14);
			this.IncludeSymbolsCheckbox.TabIndex = 27;
			this.IncludeSymbolsCheckbox.UseVisualStyleBackColor = true;
			this.IncludeSymbolsCheckbox.CheckedChanged += new System.EventHandler(this.OnIncludeSymbolsCheckBoxChanged);
			// 
			// PasswordGeneratorForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
			this.ClientSize = new System.Drawing.Size(783, 273);
			this.ControlBox = false;
			this.Controls.Add(this.IncludeNumbersCheckBox);
			this.Controls.Add(this.PasswordLengthTextBox);
			this.Controls.Add(this.PasswordLengthLabel);
			this.Controls.Add(this.IncludeNumbersLabel);
			this.Controls.Add(this.GeneratePasswordButton);
			this.Controls.Add(this.PasswordResultTextBox);
			this.Controls.Add(this.IncludeSymbolsLabel);
			this.Controls.Add(this.IncludeAmbiguousCheckbox);
			this.Controls.Add(this.IncludeLowercaseLabel);
			this.Controls.Add(this.IncludeUppercaseCheckbox);
			this.Controls.Add(this.IncludeUppercaseLabel);
			this.Controls.Add(this.IncludeLowercaseCheckbox);
			this.Controls.Add(this.IncludeAmbiguousCharactersLabel);
			this.Controls.Add(this.IncludeSymbolsCheckbox);
			this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
			this.Name = "PasswordGeneratorForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.CheckBox IncludeNumbersCheckBox;
		private System.Windows.Forms.TextBox PasswordLengthTextBox;
		private System.Windows.Forms.Label PasswordLengthLabel;
		private System.Windows.Forms.Label IncludeNumbersLabel;
		private System.Windows.Forms.Button GeneratePasswordButton;
		private System.Windows.Forms.TextBox PasswordResultTextBox;
		private System.Windows.Forms.Label IncludeSymbolsLabel;
		private System.Windows.Forms.CheckBox IncludeAmbiguousCheckbox;
		private System.Windows.Forms.Label IncludeLowercaseLabel;
		private System.Windows.Forms.CheckBox IncludeUppercaseCheckbox;
		private System.Windows.Forms.Label IncludeUppercaseLabel;
		private System.Windows.Forms.CheckBox IncludeLowercaseCheckbox;
		private System.Windows.Forms.Label IncludeAmbiguousCharactersLabel;
		private System.Windows.Forms.CheckBox IncludeSymbolsCheckbox;
	}
}