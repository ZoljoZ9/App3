using App3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App3.Persistence;
using App3.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using App3.ViewModels;
using System.Collections.ObjectModel;
using System.Data.Common;
using SQLite;
using App3.Data;


namespace App3.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Personalize : ContentPage
    {
        public PersonalizeViewModel viewModel { get; set; }

        public Personalize()
        {
            InitializeComponent();

            // Retrieve the user's selected values from the database
            var dbContext = new AppDbContext(App.DatabasePath);
            var userPreferences = dbContext.UserPreferences.FirstOrDefault();
            if (userPreferences != null)
            {
                viewModel = new PersonalizeViewModel
                {
                    Meat = userPreferences.Meat,
                    Fish = userPreferences.Fish,
                    Shopping = userPreferences.Shopping,
                    Milk = userPreferences.Milk,
                    Loathes = userPreferences.Loathes,
                    Eggs = userPreferences.Eggs,
                    Vegetables = userPreferences.Vegetables,
                    Fruit = userPreferences.Fruit
           
                };
            }
            else
            {
                viewModel = new PersonalizeViewModel();
            }

            BindingContext = viewModel;
        }


        private void ButtonIsClicked(object sender, EventArgs e)
        {
            // Get the selected values from the pickers
            string meat = kob.SelectedItem?.ToString();
            string fish = kof.SelectedItem?.ToString();
            string shopping = fsd.SelectedItem?.ToString();
            string milk = mpw.SelectedItem?.ToString();
            string loathes = lpw.SelectedItem?.ToString();
            string eggs = doe.SelectedItem?.ToString();
            string vegetables = kov.SelectedItem?.ToString();
            string fruit = koy.SelectedItem?.ToString();

            // Update the ViewModel with the new values
            ((PersonalizeViewModel)BindingContext).Meat = meat;
            ((PersonalizeViewModel)BindingContext).Fish = fish;
            ((PersonalizeViewModel)BindingContext).Shopping = shopping;
            ((PersonalizeViewModel)BindingContext).Milk = milk;
            ((PersonalizeViewModel)BindingContext).Loathes = loathes;
            ((PersonalizeViewModel)BindingContext).Eggs = eggs;
            ((PersonalizeViewModel)BindingContext).Vegetables = vegetables;
            ((PersonalizeViewModel)BindingContext).Fruit = fruit;

            // Update the database with the new values
            var userPreferences = new UserPreferences
            {
                Meat = meat,
                Fish = fish,
                Shopping = shopping,
                Loathes = loathes,
                Eggs = eggs,
                Vegetables = vegetables,
                Fruit = fruit
            };
            using (var dbContext = new AppDbContext(App.DatabasePath))
            {
                dbContext.InsertOrReplace(userPreferences);
            }

            // Display a message to indicate that the values have been updated
            string message = "Meat: " + meat + ", Fish: " + fish + ", Shopping: " + shopping + ", Milk: " + milk + ", Loathes: " + loathes + ", Eggs: " + eggs + ", Vegetables: " + vegetables + ", Fruit: " + fruit;
            DisplayAlert("Values updated", message, "OK");
        }
    }
}
