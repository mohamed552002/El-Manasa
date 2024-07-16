using FutureEducationalPlatform.Application.Interfaces.IRepository;
using FutureEducationalPlatform.Domain.Common;

namespace FutureEducationalPlatform.Persistence.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        public IUserRepository UserRepository { get; private set; }
        public IRoleRepository RoleRepository { get; private set; }

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
            UserRepository=new UserRepository(_context);
            RoleRepository=new RoleRepository(_context);
        }

        public async Task CompleteAsync()
        {
            await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }
        public IBaseRepository<T> GetRepository<T>() where T : BaseModel
        {
            return new BaseRepository<T>(_context);
        }
    }
}
