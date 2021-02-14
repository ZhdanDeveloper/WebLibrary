using System;
using System.Collections.Generic;
using System.Text;
using WebLIbrary.DAL.Contexts;
using WebLIbrary.DAL.Models;
using WebLIbrary.DAL.Repositories.Interfaces;

namespace WebLIbrary.DAL.Repositories
{
    public class BookRepository : Repository<Book>, IBookRepository
    {
        
        public BookRepository(LibraryContext context) : base(context)
        {
            
        }



    }
}
