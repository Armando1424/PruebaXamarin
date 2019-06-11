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
	public partial class DatePickerElementPage : ContentPage
	{
		public DatePickerElementPage ()
		{
			InitializeComponent ();
		}

        private void DatePicker_DateSelected(object sender, DateChangedEventArgs e)
        {
            var fechaMostrar = e.NewDate.ToString("D");
            DisplayAlert("Date Piker", fechaMostrar, "Aceptar");
        }
    }
}