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
    public class PurchasesController : ControllerBase
    {
          private Purchases purchase = new Purchases();
         private readonly ILogger _logger;

        public PurchasesController(ILogger<PurchasesController> logger)
        {
            _logger = logger;
        }

        // GET: api/purchases?user=1
        [HttpGet]
        [Produces("application/json")]
        public IEnumerable<string> get(int user_id)
        {
            _logger.LogInformation("Getting purchase from user_id="+user_id);

            yield return purchase.getUserPurchases(user_id);
        }


        // POST: api/purchases
        [HttpPost]
        [Consumes("application/json")]
        [Produces("application/json")]
        public IEnumerable<string> post([FromBody]Purchases purchase)
        {
            _logger.LogInformation("Persisting a purchase");
           yield return purchase.registerPurchase();
        }
    }
}