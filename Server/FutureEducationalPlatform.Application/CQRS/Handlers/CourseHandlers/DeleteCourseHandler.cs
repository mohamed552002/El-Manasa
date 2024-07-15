using FutureEducationalPlatform.Application.DTOS.CourseDtos;
using FutureEducationalPlatform.Application.Interfaces.IServices;
using FutureEducationalPlatform.Domain.Entities.CourseEntites;
using MediatR;

namespace FutureEducationalPlatform.Application.CQRS.Handlers.CourseHandlers
{
    public class DeleteCourseHandler : BaseCourseHandler, IRequestHandler<DeleteCourseRequest, string>
    {
        public DeleteCourseHandler(IBaseService<Course,GetCourseDto,CreateCourseDto,UpdateCourseDto> baseService) : base(baseService) { }

        public async Task<string> Handle(DeleteCourseRequest request, CancellationToken cancellationToken)
        {
            await _baseService.Delete(request.Id);
            return "تم حذف الدورة بنجاح";
        }
    }
}
