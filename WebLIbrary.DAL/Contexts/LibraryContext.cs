using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using WebLIbrary.DAL.Models;
using System.Text;

namespace WebLIbrary.DAL.Contexts
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
