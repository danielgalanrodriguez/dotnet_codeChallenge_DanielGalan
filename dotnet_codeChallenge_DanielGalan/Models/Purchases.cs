using System;
using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;


namespace dotnet_codeChallenge_DanielGalan.Models
{
    public class Purchases
    {

        private MySqlConnection myDbConnection;
        private MySqlCommand myDbCommand;
        private BookShopDbConnection bookShopConnection;

        public int book_id;
        public int user_id;


        public Purchases()
        {
            this.bookShopConnection = new BookShopDbConnection(); 
            this.myDbConnection = this.bookShopConnection.getDbConnexion();
            this.myDbCommand =  myDbConnection.CreateCommand(); 
            
        } 

        private static string ReadSingleRow(IDataRecord record)
        {
            return String.Format("{0},{1}", record[0], record[1]);
        }

        public string getUserPurchases (int userId)
        {
            List<string> queryResult = new List<string>();

            myDbCommand.CommandText = "SELECT b.title,p.date FROM Purchases as p LEFT JOIN Users AS u on p.user_id = u.id LEFT JOIN Books AS b on p.book_id = b.id  WHERE p.user_id="+userId;

        try
        {
            myDbConnection.Open();

            MySqlDataReader myDataReader = myDbCommand.ExecuteReader();
            
            while(myDataReader.Read())
            {
               queryResult.Add(ReadSingleRow((IDataRecord)myDataReader));
            }
            
            myDataReader.Close();

            string queryResultjoined = String.Join(",", queryResult);

            myDbConnection.Close();

            return queryResultjoined;
        }
        catch (Exception e)
        {
             return e.ToString();
        }

        }


        public string registerPurchase()
        {
            myDbCommand.CommandText = "INSERT INTO Purchases (book_id,user_id,date) VALUES('"+book_id+"','"+user_id+"',now())";

            try
            {
                myDbConnection.Open();

                int myDbCommandResult = myDbCommand.ExecuteNonQuery();
                
                myDbConnection.Close();

                return bookShopConnection.getSuccessFeedback();
            }
            catch (Exception e)
            {
                return e.ToString();
            }

        }
        
                

        
    }
}