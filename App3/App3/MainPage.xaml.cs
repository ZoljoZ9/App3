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
using Xamarin.Forms.PlatformConfiguration.GTKSpecific;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;
using System.IO;

namespace App3
{
    public partial class MainPage : Xamarin.Forms.TabbedPage
    {

        public MainPage(User user)
        {
            InitializeComponent();
            On<Xamarin.Forms.PlatformConfiguration.Android>().SetToolbarPlacement(ToolbarPlacement.Bottom);
            var listPage = new List();
            var addPage = new ManualAdd();
            var excludePage = new FoodToExclude();
            var personalizePage = new Personalize(); // 

            var navigationPage1 = new Xamarin.Forms.NavigationPage(listPage);
            navigationPage1.Title = "List";
            navigationPage1.IconImageSource = "page1.png";


            var navigationPage2 = new Xamarin.Forms.NavigationPage(addPage);
            navigationPage2.Title = "Add";
            navigationPage2.IconImageSource = "page2.png";


            var navigationPage3 = new Xamarin.Forms.NavigationPage(excludePage);
            navigationPage3.Title = "Exclude";
            navigationPage3.IconImageSource = "page3.png";


            var navigationPage4 = new Xamarin.Forms.NavigationPage(personalizePage);
            navigationPage4.Title = "Personalize";
            navigationPage4.IconImageSource = "page4.png";
            BackgroundColor = Color.Yellow; // Set background color of the tab bar



            Children.Add(navigationPage1);
            Children.Add(navigationPage2);
            Children.Add(navigationPage3);
            Children.Add(navigationPage4);

        }
    }
}