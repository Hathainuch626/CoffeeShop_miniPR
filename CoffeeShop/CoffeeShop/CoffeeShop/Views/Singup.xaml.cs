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
    public partial class Singup : ContentPage
    {
        public Singup()
        {
            InitializeComponent();
        }

        private void Singupbutton_Clicked(object sender, EventArgs e)
        {
            var dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Customer.db");
            var db = new SQLiteConnection(dbPath);
            db.CreateTable<Customer>();

            var item = new Customer()
            {
                Username = Username.Text,
                Name = Name.Text,
                Password = Password.Text,
            };

            db.Insert(item);

            if ((string.IsNullOrWhiteSpace(Username.Text)) || (string.IsNullOrEmpty(Username.Text)) ||
            (string.IsNullOrWhiteSpace(Password.Text)) || (string.IsNullOrEmpty(Password.Text)) ||
            string.IsNullOrWhiteSpace(Name.Text) || (string.IsNullOrEmpty(Name.Text)))
            {
                Device.BeginInvokeOnMainThread(async () =>
                {
                    var result = await this.DisplayAlert("Error", "Please Enter Data", "Cancel", "Yes");
                    if (result)
                    {
                        await Navigation.PushAsync(new LoginPage());
                    }
                    else
                    {
                        await Navigation.PushAsync(new LoginPage());
                    }
                });
            }
            else
            {
                Device.BeginInvokeOnMainThread(async () =>
                {
                    var result = await this.DisplayAlert("Successfull", "Registeration Successful", "Cancel", "Yes");
                    if (result)
                    {
                        App.Current.MainPage = new LoginPage();
                    }
                });

                Navigation.PushAsync(new LoginPage());
            }
        }
    }
}