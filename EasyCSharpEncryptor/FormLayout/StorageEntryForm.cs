using System;
using System.Drawing;
using System.IO;
using System.Runtime.Remoting.Messaging;
using System.Windows.Forms;
using EasyCSharpEncryptor.App;
using EasyCSharpEncryptor.Features;

namespace EasyCSharpEncryptor.FormLayout
{
	public partial class StorageEntryForm : ControllableFormBase
	{
		public StorageEntryForm()
		{
			InitializeComponent();
		}

		public event Action OpenStorageButtonClickEvent;
		public event Action<string> StorageRemoveEvent;

		private const string _removeStorageDefaultName = "Remove storage";
		private const string _removeStorageClickName = "Are you sure?";
		private int _removeStorageClickCount;
		private object _lastListBoxItem;

		public override void Init()
		{
			base.Init();
			UpdateStorageListBox();
		}

		protected override void OnEnable()
		{
			UpdateStorageListBox();
			_removeStorageClickCount = 0;
			RemoveStorageButton.Text = _removeStorageDefaultName;
		}

		protected override void OnDisable() { }


		private void HideStorageLayout()
		{
			StorageListBox.Visible = false;
			OpenStorageButton.Visible = false;
			CreateStorageButton.Location = new Point(StorageListBox.Location.X,
				StorageListBox.Location.Y - StoragesTitle.Height + 10);
			RemoveStorageButton.Visible = false;
			StoragesTitle.Visible = false;
		}

		private void ShowStorageLayout()
		{
			StorageListBox.Visible = true;
			OpenStorageButton.Visible = true;
			CreateStorageButton.Location = new Point(OpenStorageButton.Location.X,
				OpenStorageButton.Location.Y + OpenStorageButton.Height + 8);
			RemoveStorageButton.Visible = true;
			StoragesTitle.Visible = true;
		}

		private void UpdateStorageListBox()
		{
			var storagePaths = Directory.GetFiles(Application.StartupPath, "*.storage");

			if (storagePaths.Length == 0)
			{
				HideStorageLayout();
			}
			else
			{
				StorageListBox.Items.Clear();
				ShowStorageLayout();
				foreach (var path in storagePaths)
				{
					StorageListBox.Items.Add(Path.GetFileNameWithoutExtension(path));
				}
			}
		}


		private void OnMakeStorageButtonClicked(object sender, EventArgs e)
		{
			Proxy.MainForm.OpenChildForm(Proxy.CreateStorageForm);
		}

		private void OnOpenStorageButtonClicked(object sender, EventArgs e)
		{
			if (StorageListBox.SelectedItem == null)
			{
				Proxy.MainForm.ShowTip("No storage selected");
			}
			else
			{
				Proxy.MainForm.OpenChildForm(Proxy.StorageViewForm);
			}
		}


		private void OnRemoveStorageButtonClicked(object sender, EventArgs e)
		{
			if (StorageListBox.SelectedItem == null)
			{
				Proxy.MainForm.ShowTip("No storage selected");
				return;
			}

			_removeStorageClickCount++;
			if (_removeStorageClickCount == 1)
			{
				RemoveStorageButton.Text = _removeStorageClickName;
			}
			else if (_removeStorageClickCount > 1)
			{
				_removeStorageClickCount = 0;
				RemoveStorageButton.Text = _removeStorageDefaultName;
				StorageRemoveEvent?.Invoke((string)StorageListBox.SelectedItem);
				UpdateStorageListBox();
				Proxy.MainForm.HideTip();
			}
		}

		private void OnStorageListBoxSelectedIndexChanged(object sender, EventArgs e)
		{
			_lastListBoxItem = StorageListBox.SelectedItem;
		}
	}
}
