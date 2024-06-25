using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FutureEducationalPlatform.Application.Interfaces.IRepository
{
    public interface IBaseRepository<T> 
    {
        Task<T> GetByIdAsync(Guid id);
        Task<T> FirstOrDefaultAsync(Expression<Func<T,bool>> predicate, Func<IQueryable<T>, IIncludableQueryable<T, object>> includes = null);
        Task AddAsync(T entity);
        Task<T> AddWithReturnAsync(T entity);
        Task<IEnumerable<T>> GetAllAsync();
        Task<IEnumerable<T>> GetFilteredItemsAsync(Expression<Func<T,bool>> predicate, Func<IQueryable<T>, IIncludableQueryable<T,object>> includes = null);
        void Delete(T entity);
        T Update(T entity);
        Task<bool> IsExist(Expression<Func<T, bool>> predicate);
    }
}
