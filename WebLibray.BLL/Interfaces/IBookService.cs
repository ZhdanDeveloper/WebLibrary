using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WebLibrary.BLL.DTOs;
using WebLibray.BLL.DTOs;

namespace WebLibray.BLL.Interfaces
{
    public interface IBookService
    {
        Task<BookDTO> GetBookById(int Id);
        Task<List<BookDTO>> GetAllBooks();
        Task<BookDTO> CreateBook(BookCreateDTO book);
        Task<BookDTO> DeleteBookById(int Id);


    }
}
