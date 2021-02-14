using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using WebLIbrary.DAL.Contexts;
using WebLIbrary.DAL.Models;
using WebLIbrary.DAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace WebLIbrary.DAL.Repositories
{
    public class BookRepository : Repository<Book>, IBookRepository
    {
        
        public BookRepository(LibraryContext context) : base(context)
        {
            
        }

        public async Task<Book> GetForDeleting(int Id)
        {
            return await _context.Books.FirstOrDefaultAsync(x => x.Id == Id);

        }
    }
}
