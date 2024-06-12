using FutureEducationalPlatform.Application.Interfaces.IRepository;
using FutureEducationalPlatform.Domain.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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
           var result= await Entites.AddAsync(entity);
            return result.Entity;
        }

        public void Delete(T entity)
        {
            entity.IsDeleted=true;
        }


        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await Entites.AsNoTracking().ToListAsync();
        }
        public async Task<IEnumerable<T>> GetAllAsync(Expression<Func<T, bool>> predicate, Func<IQueryable<T>, IIncludableQueryable<T, object>> includes = null)
        {
            var query = Entites.AsQueryable().AsNoTracking();
            if(includes != null) query = includes(query);
            return await query.Where(predicate).ToListAsync();
        }
        public async Task<T> FirstOrDefaultAsync(Expression<Func<T, bool>> predicate, Func<IQueryable<T>, IIncludableQueryable<T, object>> includes = null)
        {
            var query = Entites.AsQueryable();
            if (includes != null) query = includes(query);
            return await query.FirstOrDefaultAsync(predicate);
        }

        public async Task<T> GetByIdAsync(Guid id)
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
