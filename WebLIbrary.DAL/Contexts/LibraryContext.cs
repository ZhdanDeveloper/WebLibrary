using Microsoft.EntityFrameworkCore;
using WebLibrary.DAL.Models;
namespace WebLibrary.DAL.Contexts
{
    public class LibraryContext : DbContext
    {

        public LibraryContext(DbContextOptions<LibraryContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Book> Books { get; set; }

    }
}