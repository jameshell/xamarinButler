using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace com.butler1
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();

			MainPage = new com.butler1.MainPage();
            //Designo la mainpage como la página que se iniciara al principio.
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
