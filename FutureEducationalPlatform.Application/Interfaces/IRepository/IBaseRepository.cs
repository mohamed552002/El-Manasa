using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutureEducationalPlatform.Application.Interfaces.IRepository
{
    public interface IBaseRepository<T>
    {
        Task<T> GetByIdAsync(int id);
        Task AddAsync(T entity);
        Task<T> AddWithReturnAsync(T entity);

    }
}
