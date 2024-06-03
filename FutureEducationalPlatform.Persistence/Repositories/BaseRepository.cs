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
    public class BaseRepository<T> where T : BaseModel , IBaseRepository<T>
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
           var result= await Entites.AddAsync(entity);
            return result.Entity;
        }

        public void Delete(T entity)
        {
            entity.IsDeleted=true;
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await Entites.ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await Entites.FindAsync(id);
        }

        public T Update(T entity)
        {
            Entites.Attach(entity);
            Entites.Entry(entity).State = EntityState.Modified;
            return Entites.Update(entity).Entity;
        }
    }
}
