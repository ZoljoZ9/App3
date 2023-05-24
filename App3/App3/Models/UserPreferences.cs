using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace App3.Models
{
    public class UserPreferences
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Meat { get; set; }
        public string Fish { get; set; }
        public string Shopping { get; set; }
        public string Milk { get; set; }
        public string Loathes { get; set; }
        public string Eggs { get; set; }
        public string Vegetables { get; set; }
        public string Fruit { get; set; }

    }

}
