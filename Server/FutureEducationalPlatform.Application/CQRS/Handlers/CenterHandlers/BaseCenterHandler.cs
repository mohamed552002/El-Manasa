using FutureEducationalPlatform.Application.DTOS.CenterDtos;
using FutureEducationalPlatform.Application.Interfaces.IServices;
using FutureEducationalPlatform.Domain.Entities.CenterEntites;

namespace FutureEducationalPlatform.Application.CQRS.Handlers.CenterHandlers
{
    public class BaseCenterHandler 
    {
        protected readonly IBaseService<Center, GetCenterDto, CreateCenterDto, UpdateCenterDto> _baseService;

        public BaseCenterHandler(IBaseService<Center, GetCenterDto, CreateCenterDto, UpdateCenterDto> baseService) => _baseService = baseService;

    }
}
