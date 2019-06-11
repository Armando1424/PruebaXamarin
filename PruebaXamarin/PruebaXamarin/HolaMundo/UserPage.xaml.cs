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
	public partial class UserPage : ContentPage
	{
        public UserPage ()
		{
			InitializeComponent ();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            var intent = Intent.Navigation.Intent;
            var user = intent.GetObject<UserModel>("user");
            var lol = intent.GetString("xD");
            DisplayAlert("Xamarin", lol, "Aceptar");
            BindingContext = user;
        }
    }
}