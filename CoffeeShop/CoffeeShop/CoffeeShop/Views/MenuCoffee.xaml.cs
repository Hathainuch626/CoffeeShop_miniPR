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
    public partial class MenuCoffee : ContentPage
    {
        public MenuCoffee()
        {
            InitializeComponent();
        }

        private void buycup_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Orderdetails());
        }

        private void buycrepe_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Orderdetails());
        }

        private void buygreen_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Orderdetails());
        }

        private void buymocha_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Orderdetails());
        }


        private void buymilkk_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Orderdetails());
        }

        private void buycakecoco_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Orderdetails());
        }
    }
}