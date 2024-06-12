using AutoMapper;
using FutureEducationalPlatform.Application.Exceptions;
using FutureEducationalPlatform.Application.Interfaces.IRepository;
using FutureEducationalPlatform.Application.Interfaces.IServices;
using FutureEducationalPlatform.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutureEducationalPlatform.Application.Services
{
    public class BaseService<TEntity, TGetDto, TCreateDto, TUpdateDto> : IBaseService<TEntity, TGetDto, TCreateDto, TUpdateDto>
    where TEntity : BaseModel
    where TGetDto : class
    where TCreateDto : class
    where TUpdateDto : class
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IBaseRepository<TEntity> _baseRepository;

        public BaseService(IMapper mapper, IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _baseRepository=_unitOfWork.GetRepository<TEntity>();
        }

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

        public async Task<IEnumerable<TGetDto>> GetAllAsync()
        {
            return _mapper.Map<IEnumerable<TGetDto>>(await _baseRepository.GetAllAsync());
        }

        public async Task<TGetDto> GetByIdAsync(Guid id)
        {
            var entity = await GetEntityAsync(id);
            return _mapper.Map<TGetDto>(entity);
        }

        public async Task<TEntity> Update(Guid id,TUpdateDto updateDto)
        {
            var entity = await GetEntityAsync(id);
            _mapper.Map(updateDto, entity);
            var result= _baseRepository.Update(entity);
            await _unitOfWork.CompleteAsync();
            return result;
        }
        private async Task<TEntity> GetEntityAsync(Guid id)
        {
            var entity = await _baseRepository.GetByIdAsync(id);
            if (entity == null) throw new EntityNotFoundException("No data is found");
            if (entity.IsDeleted == true) throw new NoDataFoundException("Something went wrong");
            return entity;
        }
    }
}
