using FutureEducationalPlatform.Application.DTOS.CourseDtos;
using FutureEducationalPlatform.Application.Interfaces.IServices;
using FutureEducationalPlatform.Domain.Entities.CourseEntites;
using MediatR;

namespace FutureEducationalPlatform.Application.CQRS.Handlers.CourseHandlers
{
    public class UpdateCourseHandler : BaseCourseHandler, IRequestHandler<UpdateCourseRequest, Course>
    {
        public UpdateCourseHandler(IBaseService<Course,GetCourseDto,CreateCourseDto,UpdateCourseDto> baseService):base(baseService) { }
        public async Task<Course> Handle(UpdateCourseRequest request, CancellationToken cancellationToken) => await _baseService.Update(request.Id, request.UpdateCourseDto);
    }
}
