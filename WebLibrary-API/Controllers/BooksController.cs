using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebLibrary_API.Responses;
using WebLibray.BLL.Interfaces;

namespace WebLibrary_API.Controllers
{
    public class BooksController : BaseController
    {
        protected IBookService bookService;

        public BooksController(IBookService bookService)
        {
            this.bookService = bookService;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetBook(int id)
        {
            var book = await bookService.GetBookById(id);

            if (book == null)
            {
                return Ok(new APIBadRequestResponse(new string[] { "Book not found" }));
            }
            return Ok(new ApiOkResponse(await bookService.GetBookById(id)));
        }

       

    }
}
