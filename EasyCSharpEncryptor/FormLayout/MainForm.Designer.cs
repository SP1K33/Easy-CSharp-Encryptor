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
			this.WarningText = new System.Windows.Forms.Label();
			this.AnimationTimer = new System.Windows.Forms.Timer(this.components);
			this.ChildFormContainerPanel = new System.Windows.Forms.Panel();
			this.GitHubButton = new System.Windows.Forms.Button();
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
			resources.ApplyResources(this.EncryptionButton, "EncryptionButton");
			this.EncryptionButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.EncryptionButton.FlatAppearance.BorderSize = 0;
			this.EncryptionButton.ForeColor = System.Drawing.Color.White;
			this.EncryptionButton.Name = "EncryptionButton";
			this.EncryptionButton.UseVisualStyleBackColor = true;
			this.EncryptionButton.Click += new System.EventHandler(this.OnEncryptionButtonClicked);
			// 
			// DecryptionButton
			// 
			this.DecryptionButton.Cursor = System.Windows.Forms.Cursors.Hand;
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
			this.PasswordGenerationButton.Cursor = System.Windows.Forms.Cursors.Hand;
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
			this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.CloseButton.FlatAppearance.BorderSize = 0;
			resources.ApplyResources(this.CloseButton, "CloseButton");
			this.CloseButton.ForeColor = System.Drawing.Color.White;
			this.CloseButton.Name = "CloseButton";
			this.CloseButton.UseVisualStyleBackColor = false;
			this.CloseButton.Click += new System.EventHandler(this.OnCloseButtonClicked);
			// 
			// WarningText
			// 
			resources.ApplyResources(this.WarningText, "WarningText");
			this.WarningText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.WarningText.Name = "WarningText";
			// 
			// AnimationTimer
			// 
			this.AnimationTimer.Interval = 2;
			this.AnimationTimer.Tick += new System.EventHandler(this.OnTimerTick);
			// 
			// ChildFormContainerPanel
			// 
			resources.ApplyResources(this.ChildFormContainerPanel, "ChildFormContainerPanel");
			this.ChildFormContainerPanel.Name = "ChildFormContainerPanel";
			// 
			// GitHubButton
			// 
			resources.ApplyResources(this.GitHubButton, "GitHubButton");
			this.GitHubButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.GitHubButton.FlatAppearance.BorderSize = 0;
			this.GitHubButton.ForeColor = System.Drawing.Color.Black;
			this.GitHubButton.Name = "GitHubButton";
			this.GitHubButton.UseVisualStyleBackColor = true;
			this.GitHubButton.Click += new System.EventHandler(this.OnGitHubButtonClicked);
			// 
			// MainForm
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
			resources.ApplyResources(this, "$this");
			this.Controls.Add(this.GitHubButton);
			this.Controls.Add(this.CloseButton);
			this.Controls.Add(this.ChildFormContainerPanel);
			this.Controls.Add(this.WarningText);
			this.Controls.Add(this.PasswordGenerationButton);
			this.Controls.Add(this.SelectionHighlight);
			this.Controls.Add(this.DecryptionButton);
			this.Controls.Add(this.Title);
			this.Controls.Add(this.EncryptionButton);
			this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label Title;
		private System.Windows.Forms.Button EncryptionButton;
		private System.Windows.Forms.Button DecryptionButton;
		private System.Windows.Forms.Panel SelectionHighlight;
		private System.Windows.Forms.Button PasswordGenerationButton;
		private System.Windows.Forms.Button CloseButton;
		private System.Windows.Forms.Label WarningText;
		private System.Windows.Forms.Timer AnimationTimer;
		private System.Windows.Forms.Panel ChildFormContainerPanel;
		private System.Windows.Forms.Button GitHubButton;
	}
}

