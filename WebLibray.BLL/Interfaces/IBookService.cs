using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WebLibray.BLL.DTOs;

namespace WebLibray.BLL.Interfaces
{
    public interface IBookService
    {
        Task<BookDTO> GetBookById(int Id);
    }
}
