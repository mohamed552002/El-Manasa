using FutureEducationalPlatform.Application.Interfaces.IRepository;
using FutureEducationalPlatform.Domain.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutureEducationalPlatform.Persistence.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseModel
    {
        private readonly ApplicationDbContext _context;
        private DbSet<T> Entites;
        public BaseRepository(ApplicationDbContext context)
        {
            _context = context;
            Entites = _context.Set<T>();
        }
        public async Task AddAsync(T entity)
        {
            await Entites.AddAsync(entity);
        }

        public async Task<T> AddWithReturnAsync(T entity)
        {
            await Entites.AddAsync(entity);
            return entity;
        }

        public Task<bool> Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<T>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await Entites.FindAsync(id);
        }

        public Task<T> Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
