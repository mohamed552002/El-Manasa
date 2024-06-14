using AutoMapper;
using FutureEducationalPlatform.Application.Common.Exceptions;
using FutureEducationalPlatform.Application.Interfaces.IRepository;
using FutureEducationalPlatform.Application.Interfaces.IServices;
using FutureEducationalPlatform.Domain.Common;
using Microsoft.EntityFrameworkCore.Query;
using System.Linq.Expressions;

namespace FutureEducationalPlatform.Application.Services
{
    public class BaseService<TEntity, TGetDto, TCreateDto, TUpdateDto> : IBaseService<TEntity, TGetDto, TCreateDto, TUpdateDto>
    where TEntity : BaseModel
    where TGetDto : class
    where TCreateDto : class
    where TUpdateDto : class
    {
        protected readonly IMapper _mapper;
        protected readonly IUnitOfWork _unitOfWork;
        protected readonly IBaseRepository<TEntity> _baseRepository;

        public BaseService(IMapper mapper, IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _baseRepository=_unitOfWork.GetRepository<TEntity>();
        }
        #region Queries
        public async Task<IEnumerable<TGetDto>> GetAllAsync()
        {
            return _mapper.Map<IEnumerable<TGetDto>>(await _baseRepository.GetAllAsync());
        }

        public async Task<TGetDto> GetByIdAsync(Guid id)
        {
            var entity = await GetEntityAsync(id);
            return _mapper.Map<TGetDto>(entity);
        }

        public async Task<TGetDto> GetByPropertyAsync(Expression<Func<TEntity, bool>> predicate, Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>> includes = null) =>
            _mapper.Map<TGetDto>(await GetByPropertyAsyncWithoutMap(predicate, includes));


        public async Task<TEntity> GetByPropertyAsyncWithoutMap(Expression<Func<TEntity, bool>> predicate, Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>> includes = null)
        {
            var entity = await _baseRepository.FirstOrDefaultAsync(predicate, includes);
            CheckAndThorwException(entity);
            return entity;
        }
        #endregion

        #region Commands
        public async Task CreateAsync(TCreateDto createDto)
        {
            var entity=_mapper.Map<TEntity>(createDto);
            await _baseRepository.AddAsync(entity);
            await _unitOfWork.CompleteAsync();
        }

        public async Task<TEntity> CreateWithReturnAsync(TCreateDto createDto)
        {
            var entity = _mapper.Map<TEntity>(createDto);
            var result= await _baseRepository.AddWithReturnAsync(entity);
            await _unitOfWork.CompleteAsync();
            return result;
        }

        public async void Delete(Guid id)
        {
           var entity =  await GetEntityAsync(id);
            _baseRepository.Delete(entity);
            await _unitOfWork.CompleteAsync();
        }
        

        public virtual async Task<TEntity> Update(Guid id,TUpdateDto updateDto)
        {
            var entity = await GetEntityAsync(id);
            _mapper.Map(updateDto, entity);
            var result= _baseRepository.Update(entity);
            await _unitOfWork.CompleteAsync();
            return result;
        }
        public async Task SaveChangesAsync()
        {
            await _unitOfWork.CompleteAsync();
        }
        #endregion

        #region Private Methods
        protected async Task<TEntity> GetEntityAsync(Guid id)
        {
            var entity = await _baseRepository.GetByIdAsync(id);
            CheckAndThorwException(entity);
            return entity;
        }
        private void CheckAndThorwException(TEntity entity)
        {
            if (entity == null) throw new EntityNotFoundException("No data is found");
            if (entity.IsDeleted == true) throw new NoDataFoundException("Something went wrong");
        }
        #endregion
    }
}
