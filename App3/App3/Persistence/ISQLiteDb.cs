using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace App3.Persistence
{
    public interface ISQLiteDb
    {
        SQLiteAsyncConnection GetConnection();
    }
}
