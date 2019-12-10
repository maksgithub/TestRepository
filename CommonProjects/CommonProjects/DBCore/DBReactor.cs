using System;
using System.Data.SQLite;

namespace DBCore
{
    public class DBReactor
    {
        private SQLiteConnection _connection;

        public void Open()
        {
            var connectionStr = "Data Source=Users.db;Version=3;New=False;Compress=True;";
            _connection = new SQLiteConnection(connectionStr);
            _connection.Open();

            var createCommand = "CREATE TABLE IF NOT EXISTS Users (ID INTEGER PRIMARY KEY AUTOINCREMENT, Name varchar(64) not null)";
            ExecuteQuery(createCommand);
        }

        public void AddUser(string userName)
        {
            var command = $"INSERT INTO Users (Name) VALUES ('{userName}')";
            ExecuteQuery(command);
        }

        private void ExecuteQuery(string txtQuery)
        {
            SQLiteCommand command = _connection.CreateCommand();
            command.CommandText = txtQuery;
            command.ExecuteNonQuery();
        }
    }
}