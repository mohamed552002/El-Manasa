using FutureEducationalPlatform.Application.DTOS.CenterCourseTimeDtos;
using FutureEducationalPlatform.Application.Interfaces.IServices;
using FutureEducationalPlatform.Domain.Entities.CenterEntites;

namespace FutureEducationalPlatform.Application.CQRS.Handlers.CenterCourseTimeHandlers
{
    public class BaseCenterCourseTimeHandler
    {
        protected readonly IBaseService<CenterCourseTime,GetCenterCourseTimeDto,CreateCenterCourseTimeDto,UpdateCenterCourseTimeDto> _baseService;
        public BaseCenterCourseTimeHandler(IBaseService<CenterCourseTime, GetCenterCourseTimeDto, CreateCenterCourseTimeDto, UpdateCenterCourseTimeDto> baseService)
        {
            _baseService = baseService;
        }
    }
}
