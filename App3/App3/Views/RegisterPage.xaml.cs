using App3.Models;
using App3.Persistence;
using App3.Views;
using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace App3.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
   

    public partial class RegisterPage : ContentPage
    {
        private SQLiteAsyncConnection _connection;
        public RegisterPage(SQLiteAsyncConnection connection)
        {
            InitializeComponent();
            _connection = connection;
        }
        public async void ButtonIsClicked(object sender, EventArgs args)
        {
            var user = new User 
            { 
                email = eml.Text, 
                username = usr.Text, 
                password = psw.Text,
                Shopping = fsd.SelectedItem?.ToString(),
                Milk = mpw.SelectedItem?.ToString(),
                Loathes = lpw.SelectedItem?.ToString(),
                Meat = kob.SelectedItem?.ToString(),
                Fish = kof.SelectedItem?.ToString(),
                Eggs = doe.SelectedItem?.ToString(),
                Vegetables = kov.SelectedItem?.ToString(),
                Fruit = koy.SelectedItem?.ToString()

            };
            await _connection.InsertAsync(user);
        }
    }
}
