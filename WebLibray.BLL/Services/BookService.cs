using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WebLIbrary.DAL;
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

        public async Task<BookDTO> GetBookById(int Id)
        {
            return mapper.Map<BookDTO>(await UoW.BookRepository.GetByIdAsync(Id));
        }
    }
}
