using WebLibrary.DAL.Repositories.Interfaces;
namespace WebLibrary.DAL
{
    public interface IUoW
    {
        IBookRepository BookRepository { get; }
    }
}