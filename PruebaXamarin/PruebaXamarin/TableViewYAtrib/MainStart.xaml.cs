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
	public partial class MainStart : ContentPage
	{
		public MainStart ()
		{
			InitializeComponent ();
		}

        protected override void OnAppearing()
        {
            base.OnAppearing();
            SwitchSave.OnChanged += SwitchSave_OnChanged;
        }

        private void SwitchSave_OnChanged(object sender, ToggledEventArgs e)
        {
            if (e.Value)
            {
                if (!string.IsNullOrEmpty(BoxUsuario.Text))
                {
                    var username = BoxUsuario.Text;
                    DisplayAlert("Message", username, "Aceptar");
                }
            }
        }
    }
}