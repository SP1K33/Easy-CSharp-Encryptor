using EasyCSharpEncryptor.App;

namespace EasyCSharpEncryptor.FormLayout
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
			Proxy.DataContainer.SaveData();

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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.Title = new System.Windows.Forms.Label();
			this.EncryptionButton = new System.Windows.Forms.Button();
			this.DecryptionButton = new System.Windows.Forms.Button();
			this.SelectionHighlight = new System.Windows.Forms.Panel();
			this.PasswordGenerationButton = new System.Windows.Forms.Button();
			this.CloseButton = new System.Windows.Forms.Button();
			this.GeneratePasswordButton = new System.Windows.Forms.Button();
			this.PasswordGeneratorPanel = new System.Windows.Forms.Panel();
			this.WarningText = new System.Windows.Forms.Label();
			this.IncludeNumbersCheckBox = new System.Windows.Forms.CheckBox();
			this.IncludeNumbersLabel = new System.Windows.Forms.Label();
			this.PasswordResultTextBox = new System.Windows.Forms.TextBox();
			this.IncludeAmbiguousCheckbox = new System.Windows.Forms.CheckBox();
			this.IncludeUppercaseCheckbox = new System.Windows.Forms.CheckBox();
			this.IncludeLowercaseCheckbox = new System.Windows.Forms.CheckBox();
			this.IncludeSymbolsCheckbox = new System.Windows.Forms.CheckBox();
			this.PasswordLengthTextBox = new System.Windows.Forms.TextBox();
			this.IncludeAmbiguousCharactersLabel = new System.Windows.Forms.Label();
			this.IncludeUppercaseLabel = new System.Windows.Forms.Label();
			this.IncludeLowercaseLabel = new System.Windows.Forms.Label();
			this.IncludeSymbolsLabel = new System.Windows.Forms.Label();
			this.PasswordLengthLabel = new System.Windows.Forms.Label();
			this.AnimationTimer = new System.Windows.Forms.Timer(this.components);
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
			this.PasswordGeneratorPanel.Controls.Add(this.WarningText);
			this.PasswordGeneratorPanel.Controls.Add(this.IncludeNumbersCheckBox);
			this.PasswordGeneratorPanel.Controls.Add(this.IncludeNumbersLabel);
			this.PasswordGeneratorPanel.Controls.Add(this.PasswordResultTextBox);
			this.PasswordGeneratorPanel.Controls.Add(this.IncludeAmbiguousCheckbox);
			this.PasswordGeneratorPanel.Controls.Add(this.IncludeUppercaseCheckbox);
			this.PasswordGeneratorPanel.Controls.Add(this.IncludeLowercaseCheckbox);
			this.PasswordGeneratorPanel.Controls.Add(this.IncludeSymbolsCheckbox);
			this.PasswordGeneratorPanel.Controls.Add(this.PasswordLengthTextBox);
			this.PasswordGeneratorPanel.Controls.Add(this.IncludeAmbiguousCharactersLabel);
			this.PasswordGeneratorPanel.Controls.Add(this.IncludeUppercaseLabel);
			this.PasswordGeneratorPanel.Controls.Add(this.IncludeLowercaseLabel);
			this.PasswordGeneratorPanel.Controls.Add(this.IncludeSymbolsLabel);
			this.PasswordGeneratorPanel.Controls.Add(this.PasswordLengthLabel);
			this.PasswordGeneratorPanel.Controls.Add(this.GeneratePasswordButton);
			resources.ApplyResources(this.PasswordGeneratorPanel, "PasswordGeneratorPanel");
			this.PasswordGeneratorPanel.Name = "PasswordGeneratorPanel";
			// 
			// WarningText
			// 
			resources.ApplyResources(this.WarningText, "WarningText");
			this.WarningText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.WarningText.Name = "WarningText";
			// 
			// IncludeNumbersCheckBox
			// 
			resources.ApplyResources(this.IncludeNumbersCheckBox, "IncludeNumbersCheckBox");
			this.IncludeNumbersCheckBox.Name = "IncludeNumbersCheckBox";
			this.IncludeNumbersCheckBox.UseVisualStyleBackColor = true;
			this.IncludeNumbersCheckBox.CheckedChanged += new System.EventHandler(this.OnIncludeNumbersCheckBoxChanged);
			// 
			// IncludeNumbersLabel
			// 
			resources.ApplyResources(this.IncludeNumbersLabel, "IncludeNumbersLabel");
			this.IncludeNumbersLabel.Name = "IncludeNumbersLabel";
			// 
			// PasswordResultTextBox
			// 
			this.PasswordResultTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
			this.PasswordResultTextBox.ForeColor = System.Drawing.Color.Green;
			resources.ApplyResources(this.PasswordResultTextBox, "PasswordResultTextBox");
			this.PasswordResultTextBox.Name = "PasswordResultTextBox";
			this.PasswordResultTextBox.ReadOnly = true;
			// 
			// IncludeAmbiguousCheckbox
			// 
			resources.ApplyResources(this.IncludeAmbiguousCheckbox, "IncludeAmbiguousCheckbox");
			this.IncludeAmbiguousCheckbox.Name = "IncludeAmbiguousCheckbox";
			this.IncludeAmbiguousCheckbox.UseVisualStyleBackColor = true;
			this.IncludeAmbiguousCheckbox.CheckedChanged += new System.EventHandler(this.OnIncludeAmbiguousCheckboxChanged);
			// 
			// IncludeUppercaseCheckbox
			// 
			resources.ApplyResources(this.IncludeUppercaseCheckbox, "IncludeUppercaseCheckbox");
			this.IncludeUppercaseCheckbox.Name = "IncludeUppercaseCheckbox";
			this.IncludeUppercaseCheckbox.UseVisualStyleBackColor = true;
			this.IncludeUppercaseCheckbox.CheckedChanged += new System.EventHandler(this.OnIncludeUppercaseCheckboxChanged);
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
			// IncludeAmbiguousCharactersLabel
			// 
			resources.ApplyResources(this.IncludeAmbiguousCharactersLabel, "IncludeAmbiguousCharactersLabel");
			this.IncludeAmbiguousCharactersLabel.Name = "IncludeAmbiguousCharactersLabel";
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
			// AnimationTimer
			// 
			this.AnimationTimer.Interval = 2;
			this.AnimationTimer.Tick += new System.EventHandler(this.OnTimerTick);
			// 
			// MainForm
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
			resources.ApplyResources(this, "$this");
			this.Controls.Add(this.CloseButton);
			this.Controls.Add(this.PasswordGenerationButton);
			this.Controls.Add(this.SelectionHighlight);
			this.Controls.Add(this.DecryptionButton);
			this.Controls.Add(this.Title);
			this.Controls.Add(this.EncryptionButton);
			this.Controls.Add(this.PasswordGeneratorPanel);
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
		private System.Windows.Forms.Label IncludeAmbiguousCharactersLabel;
		private System.Windows.Forms.Label IncludeUppercaseLabel;
		private System.Windows.Forms.Label IncludeLowercaseLabel;
		private System.Windows.Forms.Label IncludeSymbolsLabel;
		private System.Windows.Forms.Label PasswordLengthLabel;
		private System.Windows.Forms.CheckBox IncludeSymbolsCheckbox;
		private System.Windows.Forms.CheckBox IncludeAmbiguousCheckbox;
		private System.Windows.Forms.CheckBox IncludeUppercaseCheckbox;
		private System.Windows.Forms.CheckBox IncludeLowercaseCheckbox;
		private System.Windows.Forms.TextBox PasswordResultTextBox;
		private System.Windows.Forms.CheckBox IncludeNumbersCheckBox;
		private System.Windows.Forms.Label IncludeNumbersLabel;
		private System.Windows.Forms.Label WarningText;
		private System.Windows.Forms.Timer AnimationTimer;
	}
}

