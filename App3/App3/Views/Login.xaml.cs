using App3.Views;
using App3.Models;
using App3.Persistence;
using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using App3.ViewModels;
using System.Diagnostics;

namespace App3
{
    [DesignTimeVisible(false)]
    public partial class Login : ContentPage
    {
        private SQLiteAsyncConnection _connection;

        public Login()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            _connection = DependencyService.Get<ISQLiteDb>().GetConnection();
            _connection.CreateTableAsync<User>().Wait();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            var users = await _connection.Table<User>().Where(u => (u.email == usr.Text)).ToListAsync();
            try
            {
                if (users.Count == 0)
                {
                    await DisplayAlert("Wrong credentials", "Either Password Or Username Are Wrong", "ok");
                }
                else
                {
                    if (users[0].password == psw.Text)
                    {
                        App.LoggedInUser = users[0];
                        await Navigation.PushModalAsync(new MainPage(users[0]));
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"An exception occurred: {ex.Message}");
            }
        }

        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new RegisterPage(_connection));
        }
    }

}
