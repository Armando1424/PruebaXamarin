using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PruebaXamarin
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

        private void btnSave_Clicked(object sender, EventArgs e)
        {
            var nombre = boxNombre.Text;
            if (!string.IsNullOrEmpty(nombre))
            {
                //DisplayAlert("Xamarin Forms", nombre, "Aceptar");
                var user = new UserModel{ Name=nombre };
                Intent intent = new Intent(this, new UserPage());
                intent.PutObject("user",user);
                intent.PutString("xD", "lol");
                intent.StartIntent();
            }
        }
    }
}
