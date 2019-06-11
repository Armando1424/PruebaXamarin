using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaXamarin.Páginacontabs
{
    using Xamarin.Forms;
    using Xamarin.Forms.Xaml;
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TabAppPage : TabbedPage
    {
		public TabAppPage ()
		{
			InitializeComponent ();
		}

        protected override void OnAppearing()
        {
            base.OnAppearing();
            Children.Add(new InicioPage());
            Children.Add(new ProfilePage());
        }
    }
}