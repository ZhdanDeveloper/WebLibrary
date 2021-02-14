using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WebLIbrary.DAL.Models;

namespace WebLIbrary.DAL.Repositories.Interfaces
{
    public interface IBookRepository : IRepository<Book>
    {
        Task<Book> GetForDeleting(int Id);
    }
}
