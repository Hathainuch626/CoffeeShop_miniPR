using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CoffeeShop.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Home : ContentPage
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Menucoffee_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MenuCoffee ());
        }

        private void Promoion_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Promoion());
        }

        private void exitt_Clicked(object sender, EventArgs e)
        {
           
        }
    }
}