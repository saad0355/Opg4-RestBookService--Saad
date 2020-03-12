using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ModelLib.Model;

namespace RestBookService4.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private static readonly List<Book> books = new List<Book>()
        {
            new Book("Wack", "Carl Dreslet", 500, "1234567891011"),
            new Book("Harry Potter", "J.K", 670, "1234567891012")


        };
        // GET: api/Book
        [HttpGet]
        public IEnumerable<Book> Get()
        {
            return books;
        }

        // GET: api/Book/5
        [HttpGet("{string}", Name = "Get")]
        public Book Get(string isbn13)
        {
            return books.Find(i => i.Isbn13 == isbn13);
        }

        // POST: api/Book
        [HttpPost]
        public void Post([FromBody] Book value)
        {
            books.Add(value);
        }

        // PUT: api/Book/5
        [HttpPut("{id}")]
        public void Put(string isbn13, [FromBody] Book value)
        {
            Book book = Get(isbn13);
            if (book != null)
            {
                book.Isbn13 = value.Isbn13;
                book.Title = value.Title;
                book.Forfatter = value.Forfatter;
                book.Sidetal = value.Sidetal;

            }
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(string isbn13)
        {
            Book book = Get(isbn13);
            books.Remove(book);
        }
    }
}