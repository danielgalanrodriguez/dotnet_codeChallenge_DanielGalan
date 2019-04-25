using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using dotnet_codeChallenge_DanielGalan.Models;
using MySql.Data.MySqlClient;

namespace dotnet_codeChallenge_DanielGalan.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        // GET: api/user
        [HttpGet]
        public IEnumerable<string> get()
        {
            BookShopDbConnexion bookShopConnexion = new BookShopDbConnexion();
            MySqlConnection myDbConnection = bookShopConnexion.getDbConnexion();
            MySqlCommand myDbCommand =  myDbConnection.CreateCommand(); 
            List<string> myData = new List<string>();

            myDbCommand.CommandText = "SELECT * FROM Books"; //myCommand.Connection = myConnection;
        
            myDbConnection.Open();

            MySqlDataReader myDataReader = myDbCommand.ExecuteReader();

            while(myDataReader.Read())
            {
                myData.Add(myDataReader["title"].ToString());
            }
            string joined = string.Join(",", myData);
       
            myDbCommand.Connection.Close();
           
            yield return joined;
        }


        // GET: api/user/5
        [HttpGet("{id}")]
        public string get(int id)
        {
            return  $"Hi! i'm user number {id}";
        }


        // POST: api/user
        [HttpPost]
        public void post([FromBody]string value)
        {
            
        }
        
    }
}