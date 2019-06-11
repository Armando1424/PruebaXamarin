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
	public partial class ActivityIndicatorPage : ContentPage
	{
		public ActivityIndicatorPage ()
		{
			InitializeComponent ();
		}

        protected override void OnAppearing()
        {
            base.OnAppearing();
            indicator_image.SetBinding(ActivityIndicator.IsRunningProperty, "IsLoading");
            indicator_image.BindingContext = image_loading;
        }
    }
}