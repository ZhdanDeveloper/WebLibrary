using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WebLibrary.BLL.DTOs;
using WebLIbrary.DAL;
using WebLIbrary.DAL.Models;
using WebLibray.BLL.DTOs;
using WebLibray.BLL.Interfaces;

namespace WebLibray.BLL.Services
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
