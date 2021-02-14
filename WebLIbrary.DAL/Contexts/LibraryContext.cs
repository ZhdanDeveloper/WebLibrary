using Microsoft.EntityFrameworkCore;
using WebLibrary.DAL.Models;
using WebLibrary.DAL.Configurations;
namespace WebLibrary.DAL.Contexts
{
    public class LibraryContext : DbContext
    {

        public LibraryContext(DbContextOptions<LibraryContext> options) : base(options)
        {
           
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new BookConfiguration());
        }

        public DbSet<Book> Books { get; set; }

    }
}