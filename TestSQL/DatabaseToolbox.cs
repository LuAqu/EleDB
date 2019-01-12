using System;
using System.Collections;
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
            SQLiteConnection.CreateFile("Elephant.sqlite");
        }

        // Creates a connection with our database file.
        void connectToDatabase()
        {
            m_dbConnection = new SQLiteConnection("Data Source=Elephant.sqlite;Version=3;");
            m_dbConnection.Open();
        }

        // Creates a table named 'highscores' with two columns: name (a string of max 20 characters) and score (an int)
        void createTable()
        {
            string sql = "create table elephant (name varchar(20), description varchar(255), photo blob, gender varchar(1), date_added date, location varchar(255)";
            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            command.ExecuteNonQuery();
        }

        // Inserts some values in the highscores table.
        // As you can see, there is quite some duplicate code here, we'll solve this in part two.
        public void insertRecord(String tableName, String name, String description, String photo, String alternate_photo, String price, String source, String type, String origin, String acquisition, String dimensions, String location)
        {
            string sql = "insert into " + tableName + "(name, anecdote, photo, alternate_photo, price, type, source, origin, acquisition_method, dimensions, date_added, location) values (@name, @description, @photo, @alternate_photo, @price, @type, @source, @origin, @acquisition, @dimensions, @date_added, @location)";
            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            SQLiteParameter nameParam = new SQLiteParameter("@name", DbType.String);
            SQLiteParameter descParam = new SQLiteParameter("@description", DbType.String);
            SQLiteParameter photoParam = new SQLiteParameter("@photo", DbType.String);
            SQLiteParameter alternatePhotoParam = new SQLiteParameter("@alternate_photo", DbType.String);
            SQLiteParameter priceParam = new SQLiteParameter("@price", DbType.Double);
            SQLiteParameter typeParam = new SQLiteParameter("@type", DbType.String);
            SQLiteParameter originParam = new SQLiteParameter("@origin", DbType.String);
            SQLiteParameter acquisitionParam = new SQLiteParameter("@acquisition", DbType.String);
            SQLiteParameter dimensionParam = new SQLiteParameter("@dimensions", DbType.String);
            SQLiteParameter dateParam = new SQLiteParameter("@date_added", DbType.Date);
            SQLiteParameter locParam = new SQLiteParameter("@location", DbType.String);

            DateTime currDate = DateTime.Now;

            command.Parameters.AddWithValue("@name", name);
            command.Parameters.AddWithValue("@description", description);
            command.Parameters.AddWithValue("@photo", photo);
            command.Parameters.AddWithValue("@date_added", currDate);
            command.Parameters.AddWithValue("@location", location);
            command.Parameters.AddWithValue("@alternate_photo", alternate_photo);
            command.Parameters.AddWithValue("@price", price);
            command.Parameters.AddWithValue("@source", source);
            command.Parameters.AddWithValue("@type", type);
            command.Parameters.AddWithValue("@origin", origin);
            command.Parameters.AddWithValue("@acquisition", acquisition);
            command.Parameters.AddWithValue("@dimensions", dimensions);

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

        public void updateRecord(String tableName, String id, String name, String description, String photo, String alternate_photo, String price, String source, String type, String origin, String acquisition, String dimensions, String location)
        {
            string sql = "UPDATE " + tableName + " SET name = @name, anecdote = @anecdote, photo = @photo, alternate_photo = @alternate_photo, price = @price, type = @type, source = @source, origin = @origin, acquisition_method = @acquisition, dimensions = @dimensions, location = @location WHERE id = @id";
            
            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            SQLiteParameter idParam = new SQLiteParameter("@id", DbType.String);
            SQLiteParameter nameParam = new SQLiteParameter("@name", DbType.String);
            SQLiteParameter descParam = new SQLiteParameter("@description", DbType.String);
            SQLiteParameter photoParam = new SQLiteParameter("@photo", DbType.String);
            SQLiteParameter alternatePhotoParam = new SQLiteParameter("@alternate_photo", DbType.String);
            SQLiteParameter priceParam = new SQLiteParameter("@price", DbType.Double);
            SQLiteParameter typeParam = new SQLiteParameter("@type", DbType.String);
            SQLiteParameter originParam = new SQLiteParameter("@origin", DbType.String);
            SQLiteParameter acquisitionParam = new SQLiteParameter("@acquisition", DbType.String);
            SQLiteParameter dimensionParam = new SQLiteParameter("@dimensions", DbType.String);
            SQLiteParameter dateParam = new SQLiteParameter("@date_added", DbType.Date);
            SQLiteParameter locParam = new SQLiteParameter("@location", DbType.String);

            DateTime currDate = DateTime.Now;

            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@name", name);
            command.Parameters.AddWithValue("@anecdote", description);
            command.Parameters.AddWithValue("@photo", photo);
            command.Parameters.AddWithValue("@date_added", currDate);
            command.Parameters.AddWithValue("@location", location);
            command.Parameters.AddWithValue("@alternate_photo", alternate_photo);
            command.Parameters.AddWithValue("@price", price);
            command.Parameters.AddWithValue("@source", source);
            command.Parameters.AddWithValue("@type", type);
            command.Parameters.AddWithValue("@origin", origin);
            command.Parameters.AddWithValue("@acquisition", acquisition);
            command.Parameters.AddWithValue("@dimensions", dimensions);

            command.ExecuteNonQuery();
        }

        public void insertTypeRecord(String type)
        {
            string sql = "insert into types (name) values (@name)";
            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            SQLiteParameter nameParam = new SQLiteParameter("@name", DbType.String);

            command.Parameters.AddWithValue("@name", type);
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
                elephant.Id = reader["id"].ToString();
                elephant.Name = (reader["name"].ToString());
                elephant.Description = (reader["anecdote"].ToString());

                byte[] photoImage = Encoding.UTF8.GetBytes(reader["photo"].ToString());  
                byte[] photoImage2 = Encoding.UTF8.GetBytes(reader["alternate_photo"].ToString());

                elephant.Photo = (System.Text.Encoding.UTF8.GetString(photoImage));
                elephant.AlternatePhoto = (System.Text.Encoding.UTF8.GetString(photoImage2));

                elephant.DateAdded = Convert.ToDateTime(reader["date_added"].ToString());
                elephant.Location = reader["location"].ToString();
                elephant.Origin = reader["origin"].ToString();
                elephant.Price = reader["price"].ToString();
                elephant.Source = reader["source"].ToString();
                elephant.Dimensions = reader["dimensions"].ToString();
            }

            return elephant;
        }

        public ArrayList retrieveTypes()
        { 
            ArrayList retTypes = new ArrayList();

            string retrievalSQL = "select * from types";
            SQLiteCommand command = new SQLiteCommand(retrievalSQL, m_dbConnection);

            SQLiteDataReader reader;
            reader = command.ExecuteReader();

            while (reader.Read())
            {
                retTypes.Add(reader["name"].ToString());
            }

            return retTypes;
        }

        public int getCount()
        {
            string retrievalSQL = "select count(*) from elephants";
            SQLiteCommand command = new SQLiteCommand(retrievalSQL, m_dbConnection);

            SQLiteDataReader reader;

            return Convert.ToInt32(command.ExecuteScalar()) + 1;

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
