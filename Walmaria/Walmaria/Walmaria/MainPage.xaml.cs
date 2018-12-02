using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Walmaria
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void OnStart(Button sender, EventArgs args)
        {
            Navigation.PushModalAsync(new Page1());
        }
    }
}
