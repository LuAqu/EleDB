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

namespace EleDB
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
            m_dbConnection = new SQLiteConnection("Data Source=Elephant.sqlite;Version=3;");
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
        public void insertRecord(String tableName, String name, String description, String photo, String gender, String location)
        {
            string sql = "insert into " + tableName + "(name, description, photo, gender, date_added, location) values (@name, @description, @photo, @gender, @date_added, @location)";
            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            SQLiteParameter nameParam = new SQLiteParameter("@name", DbType.String);
            SQLiteParameter descParam = new SQLiteParameter("@description", DbType.String);
            SQLiteParameter photoParam = new SQLiteParameter("@photo", DbType.String);
            SQLiteParameter genderParam = new SQLiteParameter("@gender", DbType.String);
            SQLiteParameter dateParam = new SQLiteParameter("@date_added", DbType.Date);
            SQLiteParameter locParam = new SQLiteParameter("@location", DbType.String);

            DateTime currDate = new DateTime();

            command.Parameters.AddWithValue("@name", name);
            command.Parameters.AddWithValue("@description", description);
            command.Parameters.AddWithValue("@photo", photo);
            command.Parameters.AddWithValue("@gender", gender);
            command.Parameters.AddWithValue("@date_added", currDate);
            command.Parameters.AddWithValue("@location", location);

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

        public Elephant retrieveRecords(String name)
        {
            Elephant elephant = new Elephant();
            string retrievalSQL = "select * from elephants where name='" + name + "'";
            SQLiteCommand command = new SQLiteCommand(retrievalSQL, m_dbConnection);

            SQLiteDataReader reader;
            reader = command.ExecuteReader();
            if (reader.Read())
            {
                elephant.setName(reader["name"].ToString());
                elephant.setDescription(reader["description"].ToString());

                byte[] photoImage = (byte[])reader["Photo"];

                elephant.setPhoto(System.Text.Encoding.UTF8.GetString(photoImage));
                elephant.setGender(reader["gender"].ToString());
                elephant.setDateAdded(Convert.ToDateTime(reader["date_added"].ToString()));
                elephant.setLocation(reader["location"].ToString());
            }

            return elephant;
        }

        public string getImage()
        {
            string sql = "select Photo from Elephants where name is null";
            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);

            string base64EncodedImage = null;
            IDataReader reader = command.ExecuteReader();
            var ordinal = reader.GetOrdinal("Photo");

            while (reader.Read())
            {
                base64EncodedImage = reader.GetString(ordinal);
            }

            reader.Close();

            return base64EncodedImage;

        }
    }
}
