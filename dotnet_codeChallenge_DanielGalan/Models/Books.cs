using System;
using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;

namespace dotnet_codeChallenge_DanielGalan.Models
{
    public class Books
    {
        private MySqlConnection myDbConnection;
        private MySqlCommand myDbCommand;
        private BookShopDbConnection bookShopConnection;

        public Books()
        {
            this.bookShopConnection = new BookShopDbConnection();
            
            this.myDbConnection = this.bookShopConnection.getDbConnexion();
            this.myDbCommand =  myDbConnection.CreateCommand(); 
            
        }

                private static string ReadSingleRow(IDataRecord record)
        {
            return String.Format("{0},{1},{2}", record[1], record[2],record[3]);
        }

        public string getAllBooks() 
        {

            List<string> queryResult = new List<string>();

            myDbCommand.CommandText = "SELECT * FROM Books";

        try
        {
            myDbConnection.Open();

            MySqlDataReader myDataReader = myDbCommand.ExecuteReader();
            
            while(myDataReader.Read())
            {
                queryResult.Add(myDataReader["title"].ToString());
            }
            
            myDataReader.Close();

            string queryResultJoined = String.Join(",", queryResult);

            myDbConnection.Close();

            return queryResultJoined;
        }
        catch (Exception e)
        {
             return e.ToString();
        }
           
        }

        public string getBookDetails (int bookId)
        {
            List<string> queryResult = new List<string>();

            myDbCommand.CommandText = "SELECT * FROM Books WHERE id="+bookId;

        try
        {
            myDbConnection.Open();

            MySqlDataReader myDataReader = myDbCommand.ExecuteReader();
            
            while(myDataReader.Read())
            {
               // queryResult.Add(myDataReader.d);// .ToString());
               queryResult.Add(ReadSingleRow((IDataRecord)myDataReader));
            }
            
            myDataReader.Close();

            string queryResultJoined = String.Join(",", queryResult);

            myDbConnection.Close();

            return queryResultJoined;
        }
        catch (Exception e)
        {
             return e.ToString();
        }

        }
    }
}