using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSQL
{
    class DatabaseToolbox
    {
        SQLiteConnection m_dbConnection;

        public DatabaseToolbox()
        {
            connectToDatabase();
        }

        // Creates an empty database file
        void createNewDatabase()
        {
            SQLiteConnection.CreateFile("MyDatabase.sqlite");
        }

        // Creates a connection with our database file.
        void connectToDatabase()
        {
            m_dbConnection = new SQLiteConnection("Data Source=MyDatabase.sqlite;Version=3;");
            m_dbConnection.Open();
        }

        // Creates a table named 'highscores' with two columns: name (a string of max 20 characters) and score (an int)
        /*void createTable()
        {
            string sql = "create table highscores (name varchar(20), score int)";
            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            command.ExecuteNonQuery();
        }*/

        // Inserts some values in the highscores table.
        // As you can see, there is quite some duplicate code here, we'll solve this in part two.
        public void insertRecord(String tableName, String name, String description, String photo)
        {
            string sql = "insert into " + tableName + "(name, description, photo) values (@name, @description, @photo)";
            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            SQLiteParameter nameParam = new SQLiteParameter("@name", DbType.String);
            SQLiteParameter descParam = new SQLiteParameter("@description", DbType.String);
            SQLiteParameter photoParam = new SQLiteParameter("@photo", DbType.String);

            command.Parameters.AddWithValue("@name", name);
            command.Parameters.AddWithValue("@description", description);
            command.Parameters.AddWithValue("@photo", photo);

            command.ExecuteNonQuery();
        }

        public void insertImageRecord(String tableName, String columnName, String image)
        {
            string insertCommand = "insert into " + tableName + "(" + columnName + ") values (@value)";
            SQLiteCommand command = new SQLiteCommand(insertCommand, m_dbConnection);
            SQLiteParameter param = new SQLiteParameter("@value", DbType.String);
            param.Value = image;
            command.Parameters.Add(param);

            command.ExecuteNonQuery();
        }

        // Writes the highscores to the console sorted on score in descending order.
        public string getImage()
        {
            string sql = "select Photo from Elephants where name is null";
            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);

            string base64EncodedImage = null;
            IDataReader reader = command.ExecuteReader();
            var ordinal = reader.GetOrdinal("Photo");
            //reader.Read(); // advance the data reader to the first row

            while (reader.Read())
            {
                base64EncodedImage = reader.GetString(ordinal);
            }

            reader.Close();

            return base64EncodedImage;

        }
    }
}
