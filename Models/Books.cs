using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace dotnet_codeChallenge_DanielGalan.Models
{
    public class Books
    {
        private MySqlConnection myDbConnection;
        private MySqlCommand myDbCommand;
        private BookShopDbConnexion bookShopConnexion;

        public Books()
        {
            this.bookShopConnexion = new BookShopDbConnexion();
            
            this.myDbConnection = this.bookShopConnexion.getDbConnexion();
            this.myDbCommand =  myDbConnection.CreateCommand(); 
            
        }

        public string getAllBooks() 
        {

            List<string> myData = new List<string>();

            myDbCommand.CommandText = "SELECT * FROM Books";

        try
        {
            myDbConnection.Open();

            MySqlDataReader myDataReader = myDbCommand.ExecuteReader();

            while(myDataReader.Read())
            {
                myData.Add(myDataReader["title"].ToString());
            }
            string joined = String.Join(",", myData);
       
            myDbCommand.Connection.Close();

            return joined;
        }
        catch (Exception e)
        {
             return this.bookShopConnexion.getErrorFeedback();
        }
           
        }
    }
}