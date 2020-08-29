using System;
using System.Windows.Forms;

namespace EasyCSharpEncryptor.FormLayout
{
	public class ControllableFormBase : Form
	{
		~ControllableFormBase()
		{
			OnDispose();
		}

		public virtual void Init()
		{
			VisibleChanged += OnVisibleChanged;
		}

		private void OnDispose()
		{
			OnDisable();
			VisibleChanged -= OnVisibleChanged;
		}

		private void OnVisibleChanged(object sender, EventArgs e)
		{
			if (Visible)
			{
				OnEnable();
			}
			else
			{
				OnDisable();
			}
		}

		protected virtual void OnEnable() { }
		protected virtual void OnDisable() { }

	}

}