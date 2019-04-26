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
    public class BooksController : ControllerBase
    {
        private Books book = new Books();
        private readonly ILogger _logger;

        public BooksController(ILogger<BooksController> logger)
        {
            _logger = logger;
        }

               // GET: api/books
        [HttpGet]
        [Produces("application/json")]
        public IEnumerable<string> get()
        {   
          
            _logger.LogInformation("Getting all books");
            yield return book.getAllBooks();
        }


        // GET: api/books/5
        [HttpGet("{id:int}")]
        [Produces("application/json")]

        public IEnumerable<string> get(int id)
        {
            _logger.LogInformation("Getting book with id="+id);
            yield return  book.getBookDetails(id);
        }
        
    }
}