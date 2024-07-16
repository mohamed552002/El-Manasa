using FutureEducationalPlatform.Application.DTOS.CourseDtos;
using FutureEducationalPlatform.Application.Interfaces.IServices;
using FutureEducationalPlatform.Domain.Entities.CourseEntites;

namespace FutureEducationalPlatform.Application.CQRS.Handlers.CourseHandlers
{
    public class BaseCourseHandler
    {
        public readonly IBaseService<Course, GetCourseDto, CreateCourseDto, UpdateCourseDto> _baseService;

        public BaseCourseHandler(IBaseService<Course, GetCourseDto, CreateCourseDto, UpdateCourseDto> baseService)
        {
            _baseService = baseService;
        }
    }
}
