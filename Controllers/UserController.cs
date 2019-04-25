using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using dotnet_codeChallenge_DanielGalan.Models;

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
            Books books = new Books();

            yield return books.getAllBooks();
        }


        // GET: api/user/5
        [HttpGet("{id:int}")]
        public string get(int id)
        {
            return  $"Hi! i'm user number {id}";
        }


        // POST: api/user
        [HttpPost]
        public void post([FromBody]string value)
        {
            //return  $"Hi! i'm user number {value}";
        }
        
    }
}