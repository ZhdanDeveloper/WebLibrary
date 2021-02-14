using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace WebLIbrary.DAL.Interfaces
{
    public interface IRepository<T> where T : class
    {
        Task<T> CreateAsync(T item);
        Task<List<T>> GetAllAsync();
        Task<T> GetByIdAsync(int Id);
        Task<T> UpdateAsync(T item);
        Task<T> DeleteAsync(T item);
        Task<T> GetByWhere(Expression<Func<T, bool>> expression);

    }
}
