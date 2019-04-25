using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace dotnet_codeChallenge_DanielGalan.Models
{
    public class BookShopDbConnection 
    {

        private static string myDbConnectionString = "server=localhost;database=bookShop;user=root;port=3306;password=";
        private static string successFeedback = "1";
        

        private MySqlConnection myDbConnection;
        public BookShopDbConnection()
        {
            
            this.myDbConnection = new MySqlConnection(myDbConnectionString); 
        }

        

        public MySqlConnection getDbConnexion()
        {
            return this.myDbConnection;
        }

         public string getSuccessFeedback()
        {
            return successFeedback;
        }

    }

}