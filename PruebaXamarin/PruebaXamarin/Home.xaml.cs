using PruebaXamarin.Páginacontabs;
using PruebaXamarin.PlantillaListView;
using PruebaXamarin.PlantillaMasterPage;
using PruebaXamarin.PlantillaTabbed;
using PruebaXamarin.PaginaCarrusel;
using PruebaXamarin.PaginaTipoGrid;
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
	public partial class Home : ContentPage
	{
		public Home ()
		{
			InitializeComponent ();
		}

        protected override void OnAppearing()
        {
            base.OnAppearing();
            ListaElementos elementos = new ListaElementos();
            ListElemts.ItemsSource = elementos._elementos;
            ListElemts.ItemSelected += ListElemts_ItemSelected;
        }

        private async void ListElemts_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                var element = e.SelectedItem as Elemento;                
                if (element.Nombre.Equals("MainPage"))
                {
                    Intent intent = new Intent(this, new MainPage());
                    intent.StartIntent();
                }
                else if (element.Nombre.Equals("MainStart"))
                {
                    Intent intent = new Intent(this, new MainStart());
                    intent.StartIntent();
                }
                else if (element.Nombre.Equals("HomePage"))
                {
                    Intent intent = new Intent(this, new HomePage());
                    intent.StartIntent();
                }
                else if (element.Nombre.Equals("SliderPage"))
                {
                    Intent intent = new Intent(this, new SliderPage());
                    intent.StartIntent();
                }
                else if (element.Nombre.Equals("PickerElementPage"))
                {
                    Intent intent = new Intent(this, new NavigationPage(new PickerElementPage() { Title = "Color Selected"}));
                    intent.StartIntent();
                }
                else if (element.Nombre.Equals("DatePickerElementPage"))
                {
                    Intent intent = new Intent(this, new DatePickerElementPage());
                    intent.StartIntent();
                }
                else if (element.Nombre.Equals("ActivityIndicatorPage"))
                {
                    Intent intent = new Intent(this, new ActivityIndicatorPage());
                    intent.StartIntent();
                }
                else if (element.Nombre.Equals("HamburgerMenuPage"))
                {
                    Intent intent = new Intent(this, new HamburgerMenuPage());
                    intent.StartIntent();
                }
                else if (element.Nombre.Equals("TabAppPage"))
                {
                    Intent intent = new Intent(this, new TabAppPage());
                    intent.StartIntent();
                }
                else if (element.Nombre.Equals("MasterDetailPage1"))
                {
                    Intent intent = new Intent(this, new MasterDetailPage1());
                    intent.StartIntent();
                }
                else if (element.Nombre.Equals("ListViewPage1"))
                {
                    Intent intent = new Intent(this, new ListViewPage1());
                    intent.StartIntent();
                }
                else if (element.Nombre.Equals("View1"))
                {
                    Intent intent = new Intent(this, new ListViewPage1());
                    intent.StartIntent();
                }
                else if (element.Nombre.Equals("TabbedPage1"))
                {
                    Intent intent = new Intent(this, new TabbedPage1());
                    intent.StartIntent();
                }
                else if (element.Nombre.Equals("CarouselPage1"))
                {
                    Intent intent = new Intent(this, new CarouselPage1());
                    intent.StartIntent();
                }
                else if (element.Nombre.Equals("GridLayoutPage"))
                {
                    Intent intent = new Intent(this, new GridLayoutPage());
                    intent.StartIntent();
                }
                else
                {
                    await DisplayAlert("Listas", element.Nombre, "Aceptar");
                }
            }
        }
    }
}