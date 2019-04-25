using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace dotnet_codeChallenge_DanielGalan.Models
{
    public class BookShopDbConnexion 
    {

        private static string myDbConnectionString = "server=localhost;database=bookShop;user=root;port=3306;password=";
        private static string errorFeedback = "Sorry, something happened processing your action, please try again. If the problem persists please contact us.";

        private MySqlConnection myDbConnection;
        public BookShopDbConnexion()
        {
            
            this.myDbConnection = new MySqlConnection(myDbConnectionString); 
        }

        

        public MySqlConnection getDbConnexion()
        {
            return this.myDbConnection;
        }

        public string getErrorFeedback()
        {
            return errorFeedback;
        }

    }

}