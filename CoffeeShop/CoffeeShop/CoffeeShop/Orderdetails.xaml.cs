using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CoffeeShop
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Orderdetails : ContentPage
    {
        public Orderdetails()
        {
            InitializeComponent();
        }

        private void exitt1_Clicked(object sender, EventArgs e)
        {
            
        }

        private void buyybutton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PayPage());
        }
    }
}