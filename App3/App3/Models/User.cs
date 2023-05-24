using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace App3.Models
{
    [Table("User")]
    public class User
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string email { get; set; }
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
