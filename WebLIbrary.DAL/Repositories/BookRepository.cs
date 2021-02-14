using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using WebLibrary.DAL.Contexts;
using WebLibrary.DAL.Models;
using WebLibrary.DAL.Repositories.Interfaces;
namespace WebLibrary.DAL.Repositories
{
    public class BookRepository : Repository<Book>, IBookRepository
    {
        public BookRepository(LibraryContext context) : base(context) { }

        public async Task<Book> GetForDeleting(int Id)
        {
            return await _context.Books.FirstOrDefaultAsync(x => x.Id == Id);
        }
    }
}