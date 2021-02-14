using System.Threading.Tasks;
using WebLibrary.DAL.Models;
namespace WebLibrary.DAL.Repositories.Interfaces
{
    public interface IBookRepository : IRepository<Book>
    {
        Task<Book> GetForDeleting(int Id);
    }
}