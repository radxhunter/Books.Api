using Books.Api.Entites;
using Books.Api.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books.Api.Controllers
{
    [ApiController]
    [Route("api/{controller}")]
    public class BooksController : ControllerBase
    {
        private readonly IBooksRepository _booksRepository;

        public BooksController(IBooksRepository booksRepository)
        {
            _booksRepository = booksRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetBooks()
        {
            var books = await _booksRepository.GetBooks();
            return Ok(books);
        }
    }
}
