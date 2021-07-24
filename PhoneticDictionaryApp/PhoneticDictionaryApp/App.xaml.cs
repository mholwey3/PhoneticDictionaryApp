using PhoneticDictionaryApp.Source;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PhoneticDictionaryApp
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

			MainPage = new MainPage();
		}

		protected override void OnStart()
		{
		}

		protected override void OnSleep()
		{
		}

		protected override void OnResume()
		{
		}
	}
}
