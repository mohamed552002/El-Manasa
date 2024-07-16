using FutureEducationalPlatform.Application.Interfaces.IRepository;
using FutureEducationalPlatform.Domain.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using System.Linq.Expressions;

namespace FutureEducationalPlatform.Persistence.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseModel
    {
        protected readonly ApplicationDbContext _context;
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
        public async Task<IEnumerable<T>> GetFilteredItemsAsync(Expression<Func<T, bool>> predicate, Func<IQueryable<T>, IIncludableQueryable<T, object>> includes = null)
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
        public async Task<bool> IsExist(Expression<Func<T,bool>> predicate)
        {
            return await Entites.AnyAsync(predicate);
        }

    }
}
