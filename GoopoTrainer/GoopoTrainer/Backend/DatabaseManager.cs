using System;
using System.Collections.Generic;
using System.Text;
using SQLitePCL;
using Microsoft.Data.Sqlite;

namespace GoopoTrainer.Backend
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
                    avatar      TEXT NOT NULL, 
                    exercises   TEXT NOT NULL,
                );

                CREATE TABLE IF NOT EXISTS exercises (
                    id          INTEGER PRIMARY KEY,
                    name        TEXT NOT NULL,
                    muscles     TEXT NOT NULL,
                    
                );
            """;
            cmd.ExecuteNonQuery();
            //avatar text is json data for avatar object
        }
    }
}
