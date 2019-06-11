using PruebaXamarin.PaginaCarrusel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaXamarin.PaginaCarrusel
{
    using Xamarin.Forms;
    using Xamarin.Forms.Xaml;
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CarouselPage1 : CarouselPage
	{
		public CarouselPage1 ()
		{
			InitializeComponent ();
		}

        protected override void OnAppearing()
        {
            base.OnAppearing();
            Children.Add(new InicioPage1());
            Children.Add(new ProfilePage1());
        }
    }
}