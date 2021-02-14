using AutoMapper;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebLibrary.BLL.DTOs;
using WebLibrary.BLL.Interfaces;
using WebLibrary.DAL;
using WebLibrary.DAL.Models;
namespace WebLibrary.BLL.Services
{
    public class BookService : IBookService
    {
        private readonly IUoW UoW;
        private readonly IMapper mapper;

        public BookService(IUoW uoW, IMapper mapper)
        {
            UoW = uoW;
            this.mapper = mapper;
        }

        public async Task<BookDTO> CreateBook(BookCreateDTO book)
        {
            var BookToCreate = mapper.Map<Book>(book);
            return mapper.Map<BookDTO>(await UoW.BookRepository.CreateAsync(BookToCreate));
        }

        public async Task<BookDTO> DeleteBookById(int Id)
        {
            var BookToDelete = await UoW.BookRepository.GetForDeleting(Id);
            return mapper.Map<BookDTO>(await UoW.BookRepository.DeleteAsync(BookToDelete));
           
        }

        public async Task<List<BookDTO>> GetAllBooks()
        {
            return mapper.Map<List<BookDTO>>(await UoW.BookRepository.GetAllAsync());
        }

        public async Task<BookDTO> GetBookById(int Id)
        {
            return mapper.Map<BookDTO>(await UoW.BookRepository.GetByIdAsync(Id));
        }
    }
}