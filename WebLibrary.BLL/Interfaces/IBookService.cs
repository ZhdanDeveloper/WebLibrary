using System.Collections.Generic;
using System.Threading.Tasks;
using WebLibrary.BLL.DTOs;
namespace WebLibrary.BLL.Interfaces
{
    public interface IBookService
    {
        Task<BookDTO> GetBookById(int Id);
        Task<List<BookDTO>> GetAllBooks();
        Task<BookDTO> CreateBook(BookCreateDTO book);
        Task<BookDTO> DeleteBookById(int Id);
    }
}