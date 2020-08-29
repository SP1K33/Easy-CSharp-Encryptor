namespace EasyCSharpEncryptor.FormLayout
{
	partial class StorageEntryForm
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
			this.OpenStorageButton = new System.Windows.Forms.Button();
			this.CreateStorageButton = new System.Windows.Forms.Button();
			this.StorageListBox = new System.Windows.Forms.ListBox();
			this.RemoveStorageButton = new System.Windows.Forms.Button();
			this.StoragesTitle = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// OpenStorageButton
			// 
			this.OpenStorageButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.OpenStorageButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.OpenStorageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.OpenStorageButton.Font = new System.Drawing.Font("Century Gothic", 12F);
			this.OpenStorageButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
			this.OpenStorageButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.OpenStorageButton.Location = new System.Drawing.Point(14, 140);
			this.OpenStorageButton.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.OpenStorageButton.Name = "OpenStorageButton";
			this.OpenStorageButton.Size = new System.Drawing.Size(756, 32);
			this.OpenStorageButton.TabIndex = 21;
			this.OpenStorageButton.Text = "Open storage";
			this.OpenStorageButton.UseVisualStyleBackColor = true;
			this.OpenStorageButton.Click += new System.EventHandler(this.OnOpenStorageButtonClicked);
			// 
			// CreateStorageButton
			// 
			this.CreateStorageButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.CreateStorageButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.CreateStorageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.CreateStorageButton.Font = new System.Drawing.Font("Century Gothic", 12F);
			this.CreateStorageButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
			this.CreateStorageButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.CreateStorageButton.Location = new System.Drawing.Point(14, 180);
			this.CreateStorageButton.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.CreateStorageButton.Name = "CreateStorageButton";
			this.CreateStorageButton.Size = new System.Drawing.Size(756, 32);
			this.CreateStorageButton.TabIndex = 43;
			this.CreateStorageButton.Text = "Create storage";
			this.CreateStorageButton.UseVisualStyleBackColor = true;
			this.CreateStorageButton.Click += new System.EventHandler(this.OnMakeStorageButtonClicked);
			// 
			// StorageListBox
			// 
			this.StorageListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
			this.StorageListBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
			this.StorageListBox.FormattingEnabled = true;
			this.StorageListBox.ItemHeight = 21;
			this.StorageListBox.Location = new System.Drawing.Point(13, 35);
			this.StorageListBox.Name = "StorageListBox";
			this.StorageListBox.Size = new System.Drawing.Size(756, 88);
			this.StorageListBox.TabIndex = 47;
			this.StorageListBox.SelectedIndexChanged += new System.EventHandler(this.OnStorageListBoxSelectedIndexChanged);
			// 
			// RemoveStorageButton
			// 
			this.RemoveStorageButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.RemoveStorageButton.DialogResult = System.Windows.Forms.DialogResult.No;
			this.RemoveStorageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.RemoveStorageButton.Font = new System.Drawing.Font("Century Gothic", 12F);
			this.RemoveStorageButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
			this.RemoveStorageButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.RemoveStorageButton.Location = new System.Drawing.Point(14, 220);
			this.RemoveStorageButton.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.RemoveStorageButton.Name = "RemoveStorageButton";
			this.RemoveStorageButton.Size = new System.Drawing.Size(756, 32);
			this.RemoveStorageButton.TabIndex = 48;
			this.RemoveStorageButton.Text = "Remove strorage";
			this.RemoveStorageButton.UseVisualStyleBackColor = false;
			this.RemoveStorageButton.Click += new System.EventHandler(this.OnRemoveStorageButtonClicked);
			// 
			// StoragesTitle
			// 
			this.StoragesTitle.Dock = System.Windows.Forms.DockStyle.Top;
			this.StoragesTitle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.StoragesTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
			this.StoragesTitle.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.StoragesTitle.Location = new System.Drawing.Point(0, 0);
			this.StoragesTitle.Name = "StoragesTitle";
			this.StoragesTitle.Size = new System.Drawing.Size(783, 33);
			this.StoragesTitle.TabIndex = 49;
			this.StoragesTitle.Text = "Storages:";
			this.StoragesTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// StorageEntryForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
			this.ClientSize = new System.Drawing.Size(783, 273);
			this.ControlBox = false;
			this.Controls.Add(this.StoragesTitle);
			this.Controls.Add(this.RemoveStorageButton);
			this.Controls.Add(this.StorageListBox);
			this.Controls.Add(this.CreateStorageButton);
			this.Controls.Add(this.OpenStorageButton);
			this.Font = new System.Drawing.Font("Century Gothic", 12F);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(5);
			this.Name = "StorageEntryForm";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button OpenStorageButton;
		private System.Windows.Forms.Button CreateStorageButton;
		private System.Windows.Forms.ListBox StorageListBox;
		private System.Windows.Forms.Button RemoveStorageButton;
		private System.Windows.Forms.Label StoragesTitle;
	}
}