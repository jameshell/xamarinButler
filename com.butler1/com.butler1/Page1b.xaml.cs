using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace com.butler1
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Page1b : ContentPage
	{
		public Page1b ()
		{
			InitializeComponent ();
		}

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page1c());
        }
    }
}