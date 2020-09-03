using System.Collections.Generic;
using EasyCSharpEncryptor.Containers;
using EasyCSharpEncryptor.FormLayout;

namespace EasyCSharpEncryptor.Dependency
{
	public static class DependencyManager
	{
		/// <summary>
		/// Form, Classes
		/// </summary>
		private static Dictionary<IInitializable, IDependent[]> _dependencies;
		private static ControllableFormBase _currentChildForm;

		public static void Init()
		{
			_dependencies = new Dictionary<IInitializable, IDependent[]>
			{
				{ FormsContainer.EncryptionForm, new IDependent[] { FeaturesContainer.PasswordGenerator, FeaturesContainer.Cryptor } },
				{ FormsContainer.MainForm, new IDependent[] { /* TODO: mouse drag form */} },
				{ FormsContainer.PasswordGeneratorForm, new IDependent[] { FeaturesContainer.PasswordGenerator } },
			};

			foreach (var form in _dependencies.Keys)
			{
				form.Init();
			}

			FormsContainer.MainForm.Enable();
		}

		private static void TurnOffDependencies(IDependent[] dependencies)
		{
			foreach (var dependency in dependencies)
			{
				dependency.Disable();
			}
		}

		private static void TurnOnDependencies(IDependent[] dependencies)
		{
			foreach (var dependency in dependencies)
			{
				dependency.Enable();
			}
		}

		public static void OpenChildForm(ControllableFormBase form, bool storageForm = false)
		{
			if (_currentChildForm == form)
			{
				return;
			}

			FormsContainer.MainForm.HideTip();

			if (_currentChildForm != null)
			{
				TurnOffDependencies(_dependencies[_currentChildForm]);
				_currentChildForm.Disable();
				_currentChildForm.Hide();
			}

			form.Enable();
			TurnOnDependencies(_dependencies[form]);

			FormsContainer.MainForm.AddChildForm(form);
			form.Show();

			_currentChildForm = form;
		}
	}
}