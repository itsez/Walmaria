using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Walmaria
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Page1 : ContentPage
	{
		public Page1 ()
		{
			InitializeComponent ();
            var bev = new Image { Source = "Walmaria.images.bev.PNG" };
            var keith = new Image { Source = "Walmaria.images.keith.PNG" };
            var tyler = new Image { Source = "Walmaria.images.tyler.PNG" };
            var andy = new Image { Source = "Walmaria.images.andy.PNG" };
        }
	}
}