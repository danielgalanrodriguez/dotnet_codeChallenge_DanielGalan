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
    public class BooksController : ControllerBase
    {
        private Books book = new Books();
               // GET: api/books
        [HttpGet]
        [Produces("application/json")]
        public IEnumerable<string> get()
        {   
          

            yield return book.getAllBooks();
        }


        // GET: api/books/5
        [HttpGet("{id:int}")]
        public IEnumerable<string> get(int id)
        {
            yield return  book.getBookDetails(id);
        }
        
    }
}