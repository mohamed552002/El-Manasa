using FutureEducationalPlatform.Application.DTOS.CourseDtos;
using FutureEducationalPlatform.Application.Interfaces.IServices;
using FutureEducationalPlatform.Domain.Entities.CourseEntites;
using MediatR;

namespace FutureEducationalPlatform.Application.CQRS.Handlers.CourseHandlers
{
    public class GetCourseByIdHandler :BaseCourseHandler, IRequestHandler<GetCourseByIdRequest, GetCourseDto>
    {
        public GetCourseByIdHandler(IBaseService<Course, GetCourseDto, CreateCourseDto, UpdateCourseDto> baseService) : base(baseService) { }

        public async Task<GetCourseDto> Handle(GetCourseByIdRequest request, CancellationToken cancellationToken)=>
             await _baseService.GetByIdAsync(request.Id);
    }
}
