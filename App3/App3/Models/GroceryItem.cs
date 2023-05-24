using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace App3.Models
{
    internal class GroceryItem
        {
            [PrimaryKey, AutoIncrement]
            public int ItemID { get; set; }
            public string ItemName { get; set; }
            public int Quantity { get; set; }
            public string Category { get; set; } // Meat, vegetables, fruit, milk, bread, eggs
        }
}
