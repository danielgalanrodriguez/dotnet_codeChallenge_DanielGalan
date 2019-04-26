using System;
using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;


namespace dotnet_codeChallenge_DanielGalan.Models
{
    public class Users
    {
        private MySqlConnection myDbConnection;
        private MySqlCommand myDbCommand;
        private BookShopDbConnection bookShopConnection;
        public int id;
        public string email;
        public string password;
        public string name;
        public string surname;

        public Users()
        {
            this.bookShopConnection = new BookShopDbConnection();
            
            this.myDbConnection = this.bookShopConnection.getDbConnexion();
            this.myDbCommand =  myDbConnection.CreateCommand(); 
            
        } 

        private static string ReadSingleRow(IDataRecord record)
        {
            return String.Format("{0},{1},{2},{3}", record[1], record[2],record[3], record[4]);
        }

        public string getUserProfile (int userId)
        {
                        List<string> queryResult = new List<string>();

            myDbCommand.CommandText = "SELECT * FROM Users WHERE id="+userId;

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

        public string registerUser()
        {
            myDbCommand.CommandText = "INSERT INTO Users (email,password,name,surname) VALUES('"+email+"','"+password+"','"+name+"','"+surname+"')";

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

        public string updateUser()
        {
            myDbCommand.CommandText = "UPDATE Users SET email='"+email+"', password='"+password+"',name='"+name+"',surname='"+surname+"' WHERE id="+id;

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


        public string deleteUser(int userId)
        {
            myDbCommand.CommandText = "DELETE FROM Users WHERE id="+userId;

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

    public int getLastUserId()
        {
            myDbCommand.CommandText = "SELECT MAX(id) as max FROM Users";
            int result = 0;

        try
        {
            myDbConnection.Open();

            MySqlDataReader myDataReader = myDbCommand.ExecuteReader();
            
            while(myDataReader.Read())
            {
               result = int.Parse (myDataReader["max"].ToString());
            }
            
            myDataReader.Close();

            myDbConnection.Close();

            return result;
        }
        catch (Exception e)
        {
             return -1;
        }

        }

        
    }
}