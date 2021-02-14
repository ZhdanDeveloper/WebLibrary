using System;
using System.Collections.Generic;
using System.Text;
using WebLIbrary.DAL.Repositories.Interfaces;

namespace WebLIbrary.DAL
{
    public interface IUoW
    {
        IBookRepository BookRepository { get; }
    }
}
