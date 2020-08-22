namespace EasyCSharpEncryptor
{
	public partial class MainForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.Title = new System.Windows.Forms.Label();
			this.EncryptionButton = new System.Windows.Forms.Button();
			this.DecryptionButton = new System.Windows.Forms.Button();
			this.SelectionHighlight = new System.Windows.Forms.Panel();
			this.PasswordGenerationButton = new System.Windows.Forms.Button();
			this.CloseButton = new System.Windows.Forms.Button();
			this.GeneratePasswordButton = new System.Windows.Forms.Button();
			this.PasswordGeneratorPanel = new System.Windows.Forms.Panel();
			this.PasswordResultTextBox = new System.Windows.Forms.TextBox();
			this.ExcludeAmbiguousCheckbox = new System.Windows.Forms.CheckBox();
			this.IncludeUppercaseCheckbox = new System.Windows.Forms.CheckBox();
			this.IncludeLowercaseCheckbox = new System.Windows.Forms.CheckBox();
			this.IncludeSymbolsCheckbox = new System.Windows.Forms.CheckBox();
			this.PasswordLengthTextBox = new System.Windows.Forms.TextBox();
			this.ExcludeAmbiguousCharactersLabel = new System.Windows.Forms.Label();
			this.IncludeUppercaseLabel = new System.Windows.Forms.Label();
			this.IncludeLowercaseLabel = new System.Windows.Forms.Label();
			this.IncludeSymbolsLabel = new System.Windows.Forms.Label();
			this.PasswordLengthLabel = new System.Windows.Forms.Label();
			this.PasswordGeneratorPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// Title
			// 
			resources.ApplyResources(this.Title, "Title");
			this.Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
			this.Title.Name = "Title";
			// 
			// EncryptionButton
			// 
			this.EncryptionButton.FlatAppearance.BorderSize = 0;
			resources.ApplyResources(this.EncryptionButton, "EncryptionButton");
			this.EncryptionButton.ForeColor = System.Drawing.Color.White;
			this.EncryptionButton.Name = "EncryptionButton";
			this.EncryptionButton.UseVisualStyleBackColor = true;
			this.EncryptionButton.Click += new System.EventHandler(this.OnEncryptionButtonClicked);
			// 
			// DecryptionButton
			// 
			this.DecryptionButton.FlatAppearance.BorderSize = 0;
			resources.ApplyResources(this.DecryptionButton, "DecryptionButton");
			this.DecryptionButton.ForeColor = System.Drawing.Color.White;
			this.DecryptionButton.Name = "DecryptionButton";
			this.DecryptionButton.UseVisualStyleBackColor = true;
			this.DecryptionButton.Click += new System.EventHandler(this.OnDecryptionButtonClicked);
			// 
			// SelectionHighlight
			// 
			this.SelectionHighlight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			resources.ApplyResources(this.SelectionHighlight, "SelectionHighlight");
			this.SelectionHighlight.Name = "SelectionHighlight";
			// 
			// PasswordGenerationButton
			// 
			this.PasswordGenerationButton.FlatAppearance.BorderSize = 0;
			resources.ApplyResources(this.PasswordGenerationButton, "PasswordGenerationButton");
			this.PasswordGenerationButton.ForeColor = System.Drawing.Color.White;
			this.PasswordGenerationButton.Name = "PasswordGenerationButton";
			this.PasswordGenerationButton.UseVisualStyleBackColor = true;
			this.PasswordGenerationButton.Click += new System.EventHandler(this.OnPasswordGenerationButtonClicked);
			// 
			// CloseButton
			// 
			this.CloseButton.BackColor = System.Drawing.Color.Brown;
			this.CloseButton.FlatAppearance.BorderSize = 0;
			resources.ApplyResources(this.CloseButton, "CloseButton");
			this.CloseButton.ForeColor = System.Drawing.Color.White;
			this.CloseButton.Name = "CloseButton";
			this.CloseButton.UseVisualStyleBackColor = false;
			this.CloseButton.Click += new System.EventHandler(this.OnCloseButtonClicked);
			// 
			// GeneratePasswordButton
			// 
			this.GeneratePasswordButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			resources.ApplyResources(this.GeneratePasswordButton, "GeneratePasswordButton");
			this.GeneratePasswordButton.Name = "GeneratePasswordButton";
			this.GeneratePasswordButton.UseVisualStyleBackColor = true;
			this.GeneratePasswordButton.Click += new System.EventHandler(this.OnGeneratePasswordButtonClicked);
			// 
			// PasswordGeneratorPanel
			// 
			this.PasswordGeneratorPanel.Controls.Add(this.PasswordResultTextBox);
			this.PasswordGeneratorPanel.Controls.Add(this.ExcludeAmbiguousCheckbox);
			this.PasswordGeneratorPanel.Controls.Add(this.IncludeUppercaseCheckbox);
			this.PasswordGeneratorPanel.Controls.Add(this.IncludeLowercaseCheckbox);
			this.PasswordGeneratorPanel.Controls.Add(this.IncludeSymbolsCheckbox);
			this.PasswordGeneratorPanel.Controls.Add(this.PasswordLengthTextBox);
			this.PasswordGeneratorPanel.Controls.Add(this.ExcludeAmbiguousCharactersLabel);
			this.PasswordGeneratorPanel.Controls.Add(this.IncludeUppercaseLabel);
			this.PasswordGeneratorPanel.Controls.Add(this.IncludeLowercaseLabel);
			this.PasswordGeneratorPanel.Controls.Add(this.IncludeSymbolsLabel);
			this.PasswordGeneratorPanel.Controls.Add(this.PasswordLengthLabel);
			this.PasswordGeneratorPanel.Controls.Add(this.GeneratePasswordButton);
			resources.ApplyResources(this.PasswordGeneratorPanel, "PasswordGeneratorPanel");
			this.PasswordGeneratorPanel.Name = "PasswordGeneratorPanel";
			// 
			// PasswordResultTextBox
			// 
			this.PasswordResultTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
			this.PasswordResultTextBox.ForeColor = System.Drawing.Color.Green;
			resources.ApplyResources(this.PasswordResultTextBox, "PasswordResultTextBox");
			this.PasswordResultTextBox.Name = "PasswordResultTextBox";
			// 
			// ExcludeAmbiguousCheckbox
			// 
			resources.ApplyResources(this.ExcludeAmbiguousCheckbox, "ExcludeAmbiguousCheckbox");
			this.ExcludeAmbiguousCheckbox.Name = "ExcludeAmbiguousCheckbox";
			this.ExcludeAmbiguousCheckbox.UseVisualStyleBackColor = true;
			// 
			// IncludeUppercaseCheckbox
			// 
			resources.ApplyResources(this.IncludeUppercaseCheckbox, "IncludeUppercaseCheckbox");
			this.IncludeUppercaseCheckbox.Name = "IncludeUppercaseCheckbox";
			this.IncludeUppercaseCheckbox.UseVisualStyleBackColor = true;
			// 
			// IncludeLowercaseCheckbox
			// 
			resources.ApplyResources(this.IncludeLowercaseCheckbox, "IncludeLowercaseCheckbox");
			this.IncludeLowercaseCheckbox.Name = "IncludeLowercaseCheckbox";
			this.IncludeLowercaseCheckbox.UseVisualStyleBackColor = true;
			this.IncludeLowercaseCheckbox.CheckedChanged += new System.EventHandler(this.OnIncludeLowercaseCheckboxChanged);
			// 
			// IncludeSymbolsCheckbox
			// 
			resources.ApplyResources(this.IncludeSymbolsCheckbox, "IncludeSymbolsCheckbox");
			this.IncludeSymbolsCheckbox.Name = "IncludeSymbolsCheckbox";
			this.IncludeSymbolsCheckbox.UseVisualStyleBackColor = true;
			this.IncludeSymbolsCheckbox.CheckedChanged += new System.EventHandler(this.OnIncludeSymbolsCheckBoxChanged);
			// 
			// PasswordLengthTextBox
			// 
			this.PasswordLengthTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
			resources.ApplyResources(this.PasswordLengthTextBox, "PasswordLengthTextBox");
			this.PasswordLengthTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
			this.PasswordLengthTextBox.Name = "PasswordLengthTextBox";
			this.PasswordLengthTextBox.TextChanged += new System.EventHandler(this.OnPasswordLengthTextBoxChanged);
			// 
			// ExcludeAmbiguousCharactersLabel
			// 
			resources.ApplyResources(this.ExcludeAmbiguousCharactersLabel, "ExcludeAmbiguousCharactersLabel");
			this.ExcludeAmbiguousCharactersLabel.Name = "ExcludeAmbiguousCharactersLabel";
			// 
			// IncludeUppercaseLabel
			// 
			resources.ApplyResources(this.IncludeUppercaseLabel, "IncludeUppercaseLabel");
			this.IncludeUppercaseLabel.Name = "IncludeUppercaseLabel";
			// 
			// IncludeLowercaseLabel
			// 
			resources.ApplyResources(this.IncludeLowercaseLabel, "IncludeLowercaseLabel");
			this.IncludeLowercaseLabel.Name = "IncludeLowercaseLabel";
			// 
			// IncludeSymbolsLabel
			// 
			resources.ApplyResources(this.IncludeSymbolsLabel, "IncludeSymbolsLabel");
			this.IncludeSymbolsLabel.Name = "IncludeSymbolsLabel";
			// 
			// PasswordLengthLabel
			// 
			resources.ApplyResources(this.PasswordLengthLabel, "PasswordLengthLabel");
			this.PasswordLengthLabel.Name = "PasswordLengthLabel";
			// 
			// MainForm
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
			resources.ApplyResources(this, "$this");
			this.Controls.Add(this.PasswordGeneratorPanel);
			this.Controls.Add(this.CloseButton);
			this.Controls.Add(this.PasswordGenerationButton);
			this.Controls.Add(this.SelectionHighlight);
			this.Controls.Add(this.DecryptionButton);
			this.Controls.Add(this.Title);
			this.Controls.Add(this.EncryptionButton);
			this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.PasswordGeneratorPanel.ResumeLayout(false);
			this.PasswordGeneratorPanel.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Label Title;
		private System.Windows.Forms.Button EncryptionButton;
		private System.Windows.Forms.Button DecryptionButton;
		private System.Windows.Forms.Panel SelectionHighlight;
		private System.Windows.Forms.Button PasswordGenerationButton;
		private System.Windows.Forms.Button CloseButton;
		private System.Windows.Forms.Button GeneratePasswordButton;
		private System.Windows.Forms.Panel PasswordGeneratorPanel;
		private System.Windows.Forms.TextBox PasswordLengthTextBox;
		private System.Windows.Forms.Label ExcludeAmbiguousCharactersLabel;
		private System.Windows.Forms.Label IncludeUppercaseLabel;
		private System.Windows.Forms.Label IncludeLowercaseLabel;
		private System.Windows.Forms.Label IncludeSymbolsLabel;
		private System.Windows.Forms.Label PasswordLengthLabel;
		private System.Windows.Forms.CheckBox IncludeSymbolsCheckbox;
		private System.Windows.Forms.CheckBox ExcludeAmbiguousCheckbox;
		private System.Windows.Forms.CheckBox IncludeUppercaseCheckbox;
		private System.Windows.Forms.CheckBox IncludeLowercaseCheckbox;
		private System.Windows.Forms.TextBox PasswordResultTextBox;
	}
}

