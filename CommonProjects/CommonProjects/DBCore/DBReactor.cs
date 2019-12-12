using System;
using System.Windows;
using System.Data.SQLite;

namespace DBCore
{
    public class DBReactor
    {
        private SQLiteConnection _connection;//поле для хранения соединений с базой данных

        public void Open()
        {
            var connectionStr = "Data Source=Users.db;Version=3;New=False;Compress=True;";
            _connection = new SQLiteConnection(connectionStr);
            _connection.Open();

            var createCommand = "CREATE TABLE IF NOT EXISTS Users (ID INTEGER PRIMARY KEY AUTOINCREMENT, Name varchar(64) not null, PassWord varchar(64) not null)";
            ExecuteQuery(createCommand);
        }

        public void AddUser(string userName, string userPassword)
        {
            var command = $"INSERT INTO Users (Name,PassWord) VALUES ('{userName}','{userPassword}')";
            ExecuteQuery(command);

        }

        private void ExecuteQuery(string txtQuery)
        {
            SQLiteCommand command = _connection.CreateCommand();
            command.CommandText = txtQuery;
            command.ExecuteNonQuery();//выполняет запрос не подразумевающий возврат значений

        }
        public string Search(string userName)
        {
            string resOfSearch = "";
            SQLiteCommand command = _connection.CreateCommand();
            command.CommandText = $"SELECT * FROM Users WHERE Name LIKE '%' || '{userName}' ||'%'";
            SQLiteDataReader sql = command.ExecuteReader();
            if (sql.HasRows)
            {
                while (sql.Read())
                {
                    resOfSearch += $"User {userName} has ID {sql["ID"]} \n ";
                }
            }
            else resOfSearch = "The search has not given any results";
            return resOfSearch;
        }
        public string UserCount()
        {
            SQLiteCommand command = _connection.CreateCommand();
            command.CommandText = "SELECT COUNT (*) FROM Users";
            string countUser = command.ExecuteScalar().ToString();
            return countUser;
        }
        public void DeleteLastElement(string countUser)
        {
            var command = $"DELETE FROM Users WHERE ID = '{countUser}'";
            ExecuteQuery(command);
        }
    }
}