using FutureEducationalPlatform.Domain.Common;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FutureEducationalPlatform.Application.Interfaces.IServices
{
    public interface IBaseService<TEntity, TGetDto, TCreateDto, TUpdateDto>
    where TEntity : BaseModel
    where TGetDto : class
    where TCreateDto : class
    where TUpdateDto : class
    {
    //Queries
        Task<TGetDto> GetByIdAsync(Guid id);
        Task<TEntity> GetByPropertyAsyncWithoutMap(Expression<Func<TEntity, bool>> predicate, Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>> includes = null);
        Task<TGetDto> GetByPropertyAsync(Expression<Func<TEntity, bool>> predicate, Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>> includes = null);
        Task<IEnumerable<TGetDto>> GetAllAsync();
    //Commands
        Task CreateAsync(TCreateDto createDto);
        Task<TEntity> CreateWithReturnAsync(TCreateDto createDto);
        //Task<IEnumerable<TGetDto>> GetAllAsync(Expression<Func<TEntity, bool>> predicate, Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>> includes = null);
        Task Delete(Guid id);
        Task Delete(TEntity entity);
        Task<TEntity> Update(Guid id,TUpdateDto updateDto);
    }
}
