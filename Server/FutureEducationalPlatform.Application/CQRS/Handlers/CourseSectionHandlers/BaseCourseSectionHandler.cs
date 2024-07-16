using FutureEducationalPlatform.Application.DTOS.CourseSectionDtos;
using FutureEducationalPlatform.Application.Interfaces.IServices;
using FutureEducationalPlatform.Domain.Entities.CourseEntites;

namespace FutureEducationalPlatform.Application.CQRS.Handlers.CourseSectionHandlers
{
    public class BaseCourseSectionHandler
    {
        protected readonly IBaseService<CourseSection,GetCourseSectionDto,CreateCourseSectionDto,UpdateCourseSectionDto> _baseService;

        public BaseCourseSectionHandler(IBaseService<CourseSection, GetCourseSectionDto, CreateCourseSectionDto, UpdateCourseSectionDto> baseService)
        {
            _baseService = baseService;
        }
    }
}
