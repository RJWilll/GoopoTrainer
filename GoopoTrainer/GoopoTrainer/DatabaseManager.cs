using System;
using System.Collections.Generic;
using System.Text;
using SQLitePCL;
using Microsoft.Data.Sqlite;

namespace GoopoTrainer
{
    internal class DatabaseManager
    {
        public string DatabaseName;
        public string dbPath;

        public DatabaseManager(string databaseName)
        {
            DatabaseName = databaseName;

        }

        public void initializeDatabase()
        {
            using var con = new SqliteConnection(dbPath);
            con.Open();

            var cmd = con.CreateCommand();
            cmd.CommandText = """
                CREATE TABLE IF NOT EXISTS matches (
                    id          INTEGER PRIMARY KEY,
                    avatar TEXT NOT NULL, 
                );
            """;
            cmd.ExecuteNonQuery();
            //avatar text is json data for avatar object
        }
    }
}
