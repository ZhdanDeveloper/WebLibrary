using WebLibrary.DAL.Repositories.Interfaces;
namespace WebLibrary.DAL
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