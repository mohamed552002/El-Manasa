

using FutureEducationalPlatform.Application.CQRS.Queries.CourseQueries;
using FutureEducationalPlatform.Application.DTOS.CourseDtos;
using FutureEducationalPlatform.Application.Interfaces.IServices;
using FutureEducationalPlatform.Domain.Entities.CourseEntites;
using MediatR;

namespace FutureEducationalPlatform.Application.CQRS.Handlers.CourseHandlers
{
    public class GetCoursesHandler : BaseCourseHandler, IRequestHandler<GetCoursesRequest, IEnumerable<GetCourseDto>>
    {
        public GetCoursesHandler(IBaseService<Course, GetCourseDto, AddCourseDto, UpdateCourseDto> baseService) : base(baseService){}

        public async Task<IEnumerable<GetCourseDto>> Handle(GetCoursesRequest request, CancellationToken cancellationToken)=>
            await _baseService.GetAllAsync();
    }
}
