namespace EasyCSharpEncryptor.FormLayout
{
	partial class CreateStorageForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateStorageForm));
			this.CancelButton = new System.Windows.Forms.Button();
			this.ClearNameButton = new System.Windows.Forms.Button();
			this.NameLabel = new System.Windows.Forms.Label();
			this.NameTextBox = new System.Windows.Forms.TextBox();
			this.CreateStorageButton = new System.Windows.Forms.Button();
			this.ClearPasswordButton = new System.Windows.Forms.Button();
			this.MasterKeyLabel = new System.Windows.Forms.Label();
			this.MasterKeyTextBox = new System.Windows.Forms.TextBox();
			this.WarningText = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// CancelButton
			// 
			this.CancelButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.CancelButton.Font = new System.Drawing.Font("Century Gothic", 12F);
			this.CancelButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
			this.CancelButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.CancelButton.Location = new System.Drawing.Point(12, 123);
			this.CancelButton.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.CancelButton.Name = "CancelButton";
			this.CancelButton.Size = new System.Drawing.Size(756, 32);
			this.CancelButton.TabIndex = 48;
			this.CancelButton.Text = "Cancel";
			this.CancelButton.UseVisualStyleBackColor = true;
			this.CancelButton.Click += new System.EventHandler(this.OnCancelButtonClicked);
			// 
			// ClearNameButton
			// 
			this.ClearNameButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ClearNameButton.BackgroundImage")));
			this.ClearNameButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.ClearNameButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.ClearNameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ClearNameButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
			this.ClearNameButton.Location = new System.Drawing.Point(738, 11);
			this.ClearNameButton.Name = "ClearNameButton";
			this.ClearNameButton.Size = new System.Drawing.Size(29, 29);
			this.ClearNameButton.TabIndex = 47;
			this.ClearNameButton.UseVisualStyleBackColor = true;
			this.ClearNameButton.Click += new System.EventHandler(this.OnClearNameButtonClicked);
			// 
			// NameLabel
			// 
			this.NameLabel.AutoSize = true;
			this.NameLabel.Font = new System.Drawing.Font("Century Gothic", 12F);
			this.NameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
			this.NameLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.NameLabel.Location = new System.Drawing.Point(11, 15);
			this.NameLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.NameLabel.Name = "NameLabel";
			this.NameLabel.Size = new System.Drawing.Size(62, 21);
			this.NameLabel.TabIndex = 46;
			this.NameLabel.Text = "Name:";
			// 
			// NameTextBox
			// 
			this.NameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
			this.NameTextBox.ForeColor = System.Drawing.Color.Green;
			this.NameTextBox.Location = new System.Drawing.Point(106, 12);
			this.NameTextBox.MinimumSize = new System.Drawing.Size(596, 27);
			this.NameTextBox.Name = "NameTextBox";
			this.NameTextBox.Size = new System.Drawing.Size(626, 27);
			this.NameTextBox.TabIndex = 45;
			// 
			// CreateStorageButton
			// 
			this.CreateStorageButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.CreateStorageButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.CreateStorageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.CreateStorageButton.Font = new System.Drawing.Font("Century Gothic", 12F);
			this.CreateStorageButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
			this.CreateStorageButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.CreateStorageButton.Location = new System.Drawing.Point(12, 83);
			this.CreateStorageButton.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.CreateStorageButton.Name = "CreateStorageButton";
			this.CreateStorageButton.Size = new System.Drawing.Size(756, 32);
			this.CreateStorageButton.TabIndex = 44;
			this.CreateStorageButton.Text = "Create";
			this.CreateStorageButton.UseVisualStyleBackColor = true;
			this.CreateStorageButton.Click += new System.EventHandler(this.OnCreateStorageButtonClicked);
			// 
			// ClearPasswordButton
			// 
			this.ClearPasswordButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ClearPasswordButton.BackgroundImage")));
			this.ClearPasswordButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.ClearPasswordButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.ClearPasswordButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ClearPasswordButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
			this.ClearPasswordButton.Location = new System.Drawing.Point(738, 44);
			this.ClearPasswordButton.Name = "ClearPasswordButton";
			this.ClearPasswordButton.Size = new System.Drawing.Size(29, 29);
			this.ClearPasswordButton.TabIndex = 51;
			this.ClearPasswordButton.UseVisualStyleBackColor = true;
			this.ClearPasswordButton.Click += new System.EventHandler(this.OnClearMasterKeyButtonClicked);
			// 
			// MasterKeyLabel
			// 
			this.MasterKeyLabel.AutoSize = true;
			this.MasterKeyLabel.Font = new System.Drawing.Font("Century Gothic", 12F);
			this.MasterKeyLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
			this.MasterKeyLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.MasterKeyLabel.Location = new System.Drawing.Point(11, 48);
			this.MasterKeyLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.MasterKeyLabel.Name = "MasterKeyLabel";
			this.MasterKeyLabel.Size = new System.Drawing.Size(95, 21);
			this.MasterKeyLabel.TabIndex = 50;
			this.MasterKeyLabel.Text = "MasterKey:";
			// 
			// MasterKeyTextBox
			// 
			this.MasterKeyTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
			this.MasterKeyTextBox.ForeColor = System.Drawing.Color.Green;
			this.MasterKeyTextBox.Location = new System.Drawing.Point(106, 45);
			this.MasterKeyTextBox.MinimumSize = new System.Drawing.Size(596, 27);
			this.MasterKeyTextBox.Name = "MasterKeyTextBox";
			this.MasterKeyTextBox.Size = new System.Drawing.Size(626, 27);
			this.MasterKeyTextBox.TabIndex = 49;
			// 
			// WarningText
			// 
			this.WarningText.AutoSize = true;
			this.WarningText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
			this.WarningText.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.WarningText.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.WarningText.Location = new System.Drawing.Point(11, 169);
			this.WarningText.MinimumSize = new System.Drawing.Size(756, 42);
			this.WarningText.Name = "WarningText";
			this.WarningText.Size = new System.Drawing.Size(756, 42);
			this.WarningText.TabIndex = 55;
			this.WarningText.Text = "Note: be sure to remember your master key and\r\ndo not store it on your computer";
			this.WarningText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// CreateStorageForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
			this.ClientSize = new System.Drawing.Size(783, 273);
			this.ControlBox = false;
			this.Controls.Add(this.WarningText);
			this.Controls.Add(this.ClearPasswordButton);
			this.Controls.Add(this.MasterKeyLabel);
			this.Controls.Add(this.MasterKeyTextBox);
			this.Controls.Add(this.CancelButton);
			this.Controls.Add(this.ClearNameButton);
			this.Controls.Add(this.NameLabel);
			this.Controls.Add(this.NameTextBox);
			this.Controls.Add(this.CreateStorageButton);
			this.Font = new System.Drawing.Font("Century Gothic", 12F);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(5);
			this.Name = "CreateStorageForm";
			this.Text = "StorageInternalForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button CancelButton;
		private System.Windows.Forms.Button ClearNameButton;
		private System.Windows.Forms.Label NameLabel;
		private System.Windows.Forms.TextBox NameTextBox;
		private System.Windows.Forms.Button CreateStorageButton;
		private System.Windows.Forms.Button ClearPasswordButton;
		private System.Windows.Forms.Label MasterKeyLabel;
		private System.Windows.Forms.TextBox MasterKeyTextBox;
		private System.Windows.Forms.Label WarningText;
	}
}