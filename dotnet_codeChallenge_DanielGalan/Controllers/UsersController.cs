using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using dotnet_codeChallenge_DanielGalan.Models;

namespace dotnet_codeChallenge_DanielGalan.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
          private Users user = new Users();

        private readonly ILogger _logger;

        public UsersController(ILogger<UsersController> logger)
        {
            _logger = logger;
        }          

        // GET: api/users/1
        [HttpGet("{id:int}")]
        [Produces("application/json")]
        public IEnumerable<string> get(int id)
        {
            _logger.LogInformation("Getting user with id="+id);
            yield return user.getUserProfile(id);
        }


        // POST: api/users
        [HttpPost]
        [Consumes("application/json")]
        [Produces("application/json")]
        public IEnumerable<string> post([FromBody]Users user)
        {
           _logger.LogInformation("Persisting a user");            
           yield return user.registerUser();
        }

        // DELETE: api/users/1
        [HttpDelete("{id:int}")] 
        [Produces("application/json")]
        public IEnumerable<string> delete(int id)
        {
          _logger.LogInformation("Deleting user with id="+id);
           yield return user.deleteUser(id);
        }

        // PUT: api/users/1
        [HttpPut("{id:int}")] 
        [Consumes("application/json")]
        [Produces("application/json")]

        public IEnumerable<string> update(int id, Users user)
        {
             _logger.LogInformation("Updating user with id="+id);
            user.id=id;
           yield return user.updateUser();
        }
        
    }
}