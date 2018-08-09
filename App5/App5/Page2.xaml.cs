using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App5
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Page2 : ContentPage
	{
		public Page2 ()
		{
			InitializeComponent ();
		}
        void CambiarColor(object sender, Xamarin.Forms.ValueChangedEventArgs e)
        {
            var rojo = slaRojo.Value;
            var azul = slaAzul.Value;
            var verde = slaVerde.Value;
            Color bgColor = new Color(rojo, azul, verde);
            boxColor.BackgroundColor = bgColor;
            lbdDisplay.Text = ColorToHex(bgColor);
        }
        private string ColorToHex(Color color)
        {
            int rojo = (int)(color.R * 255);
            int verde = (int)(color.R * 255);
            int azul = (int)(color.R * 255);
            int alpha = (int)(color.R * 255);
            return $"#{rojo:X2}{verde:X2}{azul:X2}{alpha:X2}";
        }

    }
}