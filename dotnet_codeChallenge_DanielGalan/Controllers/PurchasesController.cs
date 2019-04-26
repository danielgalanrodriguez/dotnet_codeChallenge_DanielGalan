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
    public class PurchasesController : ControllerBase
    {
          private Purchases purchase = new Purchases();

        // GET: api/purchases?user=1
        [HttpGet]
        [Produces("application/json")]
        public IEnumerable<string> get(int user_id)
        {
            yield return purchase.getUserPurchases(user_id);
        }


        // POST: api/purchases
        [HttpPost]
        [Consumes("application/json")]
        [Produces("application/json")]
        public IEnumerable<string> post([FromBody]Purchases purchase)
        {
           yield return purchase.registerPurchase();
        }
/*
        // DELETE: api/users/1
        [HttpDelete("{id:int}")] 
        [Produces("application/json")]
        public IEnumerable<string> delete(int id)
        {

           yield return user.deleteUser(id);
        }

        // PUT: api/users/1
        [HttpPut("{id:int}")] 
        [Consumes("application/json")]
        [Produces("application/json")]

        public IEnumerable<string> update(int id, Users user)
        {
            user.id=id;
           yield return user.updateUser();
        }
        */
    }
}