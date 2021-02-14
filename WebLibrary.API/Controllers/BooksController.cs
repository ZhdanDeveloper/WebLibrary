using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using WebLibrary.BLL.DTOs;
using WebLibrary.BLL.Interfaces;
using WebLibrary_API.Responses;
namespace WebLibrary_API.Controllers
{
    public class BooksController : BaseController
    {
        protected readonly IBookService bookService;
        public BooksController(IBookService bookService)
        {
            this.bookService = bookService;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetBook(int id)
        {
            var book = await bookService.GetBookById(id);
            if (book == null)
                return Ok(new APINotFoundResponse(new string[] { "Book not found" }));
            return Ok(new APIOKResponse(await bookService.GetBookById(id)));
        }


        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var books = await bookService.GetAllBooks();
            if (books == null)
                return Ok(new APINotFoundResponse(new string[] { "Books not found" }));
            return Ok(new APIOKResponse(books));
        }

        [HttpPost]
        public async Task<IActionResult> CreateBook([FromBody] BookCreateDTO book)
        {
            var result = await bookService.CreateBook(book);
            return Ok(new APIOKResponse(result));
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteBookById(int id)
        {
            var result = await bookService.DeleteBookById(id);
            return Ok(new APIOKResponse(result));
        }


        [HttpPut("{id}")]
        public async Task<IActionResult> DeleteBookById(int id, [FromBody]BookCreateDTO book)
        {
            
            return Ok(new APIOKResponse(await bookService.UpdateBook(book, id)));
        }
    }
}