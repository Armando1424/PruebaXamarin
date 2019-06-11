using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PruebaXamarin
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class HamburgerMenuPage : MasterDetailPage
	{
		public HamburgerMenuPage ()
		{
			InitializeComponent ();
            Inith();
		}

        private void Inith()
        {
            List<Menu> menu = new List<Menu>
            {
                new Menu{page = new CasaPage(), MenuTitle = "Inicio", MenuDetail = "Regresa a la página principal" },
                new Menu{page = new SettingsPage(), MenuTitle = "Opciones", MenuDetail = "Navegar a la página de opciones" }
            };

            ListMenu.ItemsSource = menu;            

            switch (Device.RuntimePlatform)
            {
                case Device.iOS:
                    ListMenu.Margin = new Thickness(0, 21, 0, 0);
                    break;
                case Device.Android:
                    ListMenu.Margin = new Thickness(0, 21, 0, 0);
                    break;
                case Device.WinPhone:
                    ListMenu.Margin = new Thickness(0, 21, 0, 0);
                    break;
            }

            Detail = new NavigationPage(new CasaPage());
        }

        private void ListMenu_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var menu = e.SelectedItem as Menu;
            if (menu != null)
            {
                IsPresented = false;
                Detail = new NavigationPage(menu.page);
            }
            
        }
    }
    public class Menu
    {
        public string MenuTitle { get; set; }
        public string MenuDetail { get; set; }
        public Page page { get; set; }
    }
}