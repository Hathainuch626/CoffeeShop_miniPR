using CoffeeShop.Tables;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using SQLite;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CoffeeShop.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }
        private void Loginbutton_Clicked(object sender, EventArgs e)
        {
            var dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Customer.db");
            var db = new SQLiteConnection(dbPath);
            var query = db.Table<Customer>().Where(u => u.Username.Equals(Username.Text) && u.Password.Equals(Password.Text)).FirstOrDefault();
            if (query != null)
            {
                App.Current.MainPage = new NavigationPage(new Home());
            }
            else
            {
                Device.BeginInvokeOnMainThread(async () =>
                {
                    var result = await this.DisplayAlert("Error", "Data Incorrect", "Cancel", "Yes");
                    if (result)
                    {
                        await Navigation.PushAsync(new Home());
                    }
                    else
                    {
                        await Navigation.PushAsync(new Home());
                    }
                });
            }

        }

        private void Singupbutton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Singup());
        }
    }
}
    


    


