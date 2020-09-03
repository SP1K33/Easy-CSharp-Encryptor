using System;
using System.Windows.Forms;
using EasyCSharpEncryptor.App;
using EasyCSharpEncryptor.Dependency;
using EasyCSharpEncryptor.Features;

namespace EasyCSharpEncryptor.FormLayout
{
	// it is not abstract because form constructor cannot show abstract forms :(
	public class ControllableFormBase : Form, IInitializable
	{
		protected virtual void OnEnable() { }
		protected virtual void OnDisable() { }
		protected virtual void OnInit() { }

		public void Enable()
		{
			OnEnable();
		}

		public void Disable()
		{
			OnDisable();
		}

		public void Init()
		{
			OnInit();
		}
	}

}