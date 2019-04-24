using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

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
            return new string[] {"hi! im getting something"};
        }


        // GET: api/user/5
        [HttpGet("{id}")]
        public string get(int id)
        {
            return  $"Hi! i'm user number {id}";
        }

        // POST api/user
        [HttpPost]
        public void Post([FromBody] string value)
        {

        }
        
    }
}