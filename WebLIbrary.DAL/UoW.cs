using System;
using System.Collections.Generic;
using System.Text;
using WebLIbrary.DAL.Repositories.Interfaces;

namespace WebLIbrary.DAL
{
    public class UoW : IUoW
    {
        private readonly IBookRepository bookRepository;

        public UoW(IBookRepository bookRepository)
        {
            this.bookRepository = bookRepository;
        }   
        public IBookRepository BookRepository => bookRepository;
    }   
}
