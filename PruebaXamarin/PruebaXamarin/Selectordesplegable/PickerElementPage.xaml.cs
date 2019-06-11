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
	public partial class PickerElementPage : ContentPage
	{
        List<ColorItem> colors;

        public PickerElementPage ()
		{
			InitializeComponent ();
            InitApp();
		}

        public void InitApp()
        {
            colors = new List<ColorItem>();
            colors.Add(new ColorItem { Color = Color.Aqua, Name = "Aqua" });
            colors.Add(new ColorItem { Color = Color.Black, Name = "Black" });
            colors.Add(new ColorItem { Color = Color.Blue, Name = "Blue" });
            colors.Add(new ColorItem { Color = Color.Fuchsia, Name = "Fuchsia" });
            colors.Add(new ColorItem { Color = Color.Green, Name = "Green" });

            foreach (var color in colors)
            {
                pickerColor.Items.Add(color.Name);
            }
        }

        private void pickerColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            int position = pickerColor.SelectedIndex;
            if (position > -1)
            {
                boxColor.Color = colors[position].Color;
            }
        }
    }
}