using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebLibrary.BLL.DTOs;
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
                return Ok(new APINotFoundResponse(new string[] { "Book not found" }));
            }
            return Ok(new ApiOkResponse(await bookService.GetBookById(id)));
        }


        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var books = await bookService.GetAllBooks();

            if (books == null)
            {
                return Ok(new APINotFoundResponse(new string[] { "Books not found" }));
            }
            return Ok(new ApiOkResponse(books));
        }



        [HttpPost]
        public async Task<IActionResult> CreateBook([FromBody]BookCreateDTO book)
        {

            var result = await bookService.CreateBook(book);

           
             
            return Ok(new ApiOkResponse(result));


        }


        [HttpDelete]
        public async Task<IActionResult> DeleteBookById(int id)
        {

            var result = await bookService.DeleteBookById(id);



            return Ok(new ApiOkResponse(result));


        }


    }
}
