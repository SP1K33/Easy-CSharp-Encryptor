using EasyCSharpEncryptor.App;
using EasyCSharpEncryptor.Features;
using EasyCSharpEncryptor.Responses;
using System;

namespace EasyCSharpEncryptor.FormLayout
{
	public partial class CreateStorageForm : ControllableFormBase
	{
		public CreateStorageForm()
		{
			InitializeComponent();
		}

		/// <summary>
		/// Name, MasterKey
		/// </summary>
		public event Action<string, string> CreateStorageButtonClickEvent;

		protected override void OnEnable()
		{
			Proxy.StorageHolder.StorageCreateEvent += OnStorageCreated;
		}

		protected override void OnDisable()
		{
			OnClearMasterKeyButtonClicked(null, null);
			OnClearNameButtonClicked(null, null);
			Proxy.StorageHolder.StorageCreateEvent -= OnStorageCreated;
		}

		private void OnStorageCreated(StorageCreateResponse response)
		{
			switch (response)
			{
				case StorageCreateResponse.Success:
					Proxy.MainForm.OpenChildForm(Proxy.StorageViewForm);
					break;
				case StorageCreateResponse.NameIsEmpty:
					Proxy.MainForm.ShowTip("Name is empty");
					break;
				case StorageCreateResponse.NameIsIncorrect:
					Proxy.MainForm.ShowTip("Name is incorrect");
					break;
			}
		}

		private void OnCancelButtonClicked(object sender, EventArgs e)
		{
			Proxy.MainForm.OpenChildForm(Proxy.StorageEntryForm);
		}

		private void OnClearNameButtonClicked(object sender, EventArgs e)
		{
			NameTextBox.Text = string.Empty;
		}

		private void OnCreateStorageButtonClicked(object sender, EventArgs e)
		{
			CreateStorageButtonClickEvent?.Invoke(NameTextBox.Text, MasterKeyTextBox.Text);
		}

		private void OnClearMasterKeyButtonClicked(object sender, EventArgs e)
		{
			MasterKeyTextBox.Text = string.Empty;
		}
	}
}
