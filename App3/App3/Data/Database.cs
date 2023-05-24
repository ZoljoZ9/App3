using SQLite;
using System.Collections.Generic;
using System.Linq;

namespace App3.Data
{
    public class Database
    {
        readonly SQLiteConnection _database;

        public Database(string dbPath)
        {
            _database = new SQLiteConnection(dbPath);
            _database.CreateTable<Vegetable>();
        }

        public void InitializeDatabase()
        {
            // check if the database is empty, and if it is, populate it with some vegetables
            if (!_database.Table<Vegetable>().Any())
            {
                _database.InsertAll(new List<Vegetable>
        {
            new Vegetable { Name = "Carrot", Description = "A root vegetable", ImageUrl = "https://www.example.com/carrot.png", Quantity = 4 },
            new Vegetable { Name = "Tomato", Description = "A fruit that is often used as a vegetable", ImageUrl = "https://www.example.com/tomato.png", Quantity = 4 },
            new Vegetable { Name = "Lettuce", Description = "A leafy green test", ImageUrl = "https://www.example.com/lettuce.png", Quantity = 4,}
                });
            }
        }
        public IEnumerable<Vegetable> GetVegetables()
        {
            return _database.Table<Vegetable>().ToList();
        }
    }
}
