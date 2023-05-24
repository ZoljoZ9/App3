using App3.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace App3.Data
{
    public class AppDbContext : SQLiteConnection
    {
        public AppDbContext(string path) : base(path)
        {
            CreateTable<UserPreferences>();
        }

        public TableQuery<UserPreferences> UserPreferences => Table<UserPreferences>();
    }

}
