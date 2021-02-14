using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using WebLibrary.DAL.Contexts;
using WebLibrary.DAL.Repositories.Interfaces;
namespace WebLibrary.DAL.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly LibraryContext _context;
        protected readonly DbSet<TEntity> dbSet;

        public Repository(LibraryContext context)
        {
            _context = context;
            dbSet = _context.Set<TEntity>();
        }

        public async Task<TEntity> CreateAsync(TEntity item)
        {
            await _context.Set<TEntity>().AddAsync(item);
            await _context.SaveChangesAsync();
            return item;
        }

        public async Task<TEntity> DeleteAsync(TEntity item)
        {
            _context.Set<TEntity>().Remove(item);
            await _context.SaveChangesAsync();
            return item;
        }

        public async Task<List<TEntity>> GetAllAsync()
        {
            return await _context.Set<TEntity>().AsNoTracking().ToListAsync();
        }

        public async Task<TEntity> GetByIdAsync(int Id)
        {
            return await _context.Set<TEntity>().FindAsync(Id);
        }

        public async Task<TEntity> GetByWhere(Expression<Func<TEntity, bool>> expression)
        {
            return await _context.Set<TEntity>().FirstOrDefaultAsync(expression);
        }

        public async Task<TEntity> UpdateAsync(TEntity item)
        {
            _context.Set<TEntity>().Update(item);
            await _context.SaveChangesAsync();
            return item;
        }
    }
}