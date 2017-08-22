using com.butler1.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace com.butler1
{
	public partial class MainPage : MasterDetailPage
	{
       itemModel vm;

        public MainPage()
		{ InitializeComponent();

          

            vm = new itemModel();
            //Llamo al modelo de objeto prestablecido en la carpeta ViewModel.
            itemList.ItemsSource = vm.items;
           
           // Detail = new NavigationPage(new Page1());
            var nav = new NavigationPage(new Page1());
            nav.BarBackgroundColor = Color.Black;
            nav.BarTextColor = Color.White;
            /* Se cambian las propiedades de la barra de navegación.
             - Se tuvo que instanciar una variable de pagina de navegación para pode realizar los cambios
               de propiedades, pues al igualarlo con detail se daba lugar a un override atributos.
            */
            Detail = nav;
            IsPresented = true;
            /*Indica que esta sera la página que sera presentada al inicio de la aplicación poco después
              de que se termine el tiempo de duracion del splashscreen incorporado.
             */
		}

        private void Button_Clicked(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Page1());
            IsPresented = false;
            //Antiguo metodo para navegar con botones a traves del master detail.
            
        }

        private void Button_Clicked2(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Page2());
            IsPresented = false;
            //Antiguo metodo para navegar con botones a traves del master detail.
        }



    }
}
