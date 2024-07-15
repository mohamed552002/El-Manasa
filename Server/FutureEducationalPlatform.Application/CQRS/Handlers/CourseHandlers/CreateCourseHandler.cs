using FutureEducationalPlatform.Application.DTOS.CourseDtos;
using FutureEducationalPlatform.Application.Interfaces.IServices;
using FutureEducationalPlatform.Domain.Entities.CourseEntites;
using MediatR;

namespace FutureEducationalPlatform.Application.CQRS.Handlers.CourseHandlers
{
    public class CreateCourseHandler : BaseCourseHandler , IRequestHandler<CreateCourseRequest, string>
    {
        public CreateCourseHandler(IBaseService<Course, GetCourseDto, CreateCourseDto, UpdateCourseDto> baseService) : base(baseService) { }

        public async Task<string> Handle(CreateCourseRequest request, CancellationToken cancellationToken)
        {
            await _baseService.CreateAsync(request.CreateCourseDto);
            return "تمت اضافة الدورة بنجاح";
        }
    }
}
