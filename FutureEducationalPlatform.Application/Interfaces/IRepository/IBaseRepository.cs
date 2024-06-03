using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutureEducationalPlatform.Application.Interfaces.IRepository
{
    public interface IBaseRepository<T> 
    {
        Task<IEnumerable<T>> GetAll();
        Task<bool> Delete(T entity);
        Task<T> Update(T entity);
    }
}
