using App3;
using App3.Data;
using App3.Models;
using SQLite;
using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App3
{
    public partial class App : Application
    {
        private static SQLiteConnection _database;

        public static SQLiteConnection Database
        {
            get
            {
                if (_database == null)
                {
                    var dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "vegetables.db3");
                    _database = new SQLiteConnection(dbPath);
                    _database.CreateTable<Vegetable>();
                }
                return _database;
            }
        }
        public App()
        {
            InitializeComponent();

            MainPage = new Login();

        }

        public static User LoggedInUser { get; set; }

        private static AppDbContext _dbContext;

        public static AppDbContext DbContext
        {
            get
            {
                if (_dbContext == null)
                {
                    var dbPath = Path.Combine(
                        System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal),
                        "MySQLite.db3");
                    _dbContext = new AppDbContext(dbPath);
                }
                return _dbContext;
            }
        }

        public static string DatabasePath
        {
            get { return DbContext.DatabasePath; }
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
