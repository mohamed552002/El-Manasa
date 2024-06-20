using FutureEducationalPlatform.Application.DTOS.CenterCourseTimeDtos;
using FutureEducationalPlatform.Application.Interfaces.IServices;
using FutureEducationalPlatform.Domain.Entities.CenterEntites;

namespace FutureEducationalPlatform.Application.CQRS.Handlers.CenterCourseTimeHandlers
{
    public class BaseCenterCourseTimeHandler
    {
        protected readonly IBaseService<CenterCourseTime,GetCenterCourseTimeDto,AddCenterCourseTimeDto,UpdateCenterCourseTimeDto> _baseService;
        public BaseCenterCourseTimeHandler(IBaseService<CenterCourseTime, GetCenterCourseTimeDto, AddCenterCourseTimeDto, UpdateCenterCourseTimeDto> baseService)
        {
            _baseService = baseService;
        }
    }
}
