using FutureEducationalPlatform.Application.CQRS.Commands.CourseCommands;
using FutureEducationalPlatform.Application.DTOS.CourseDtos;
using FutureEducationalPlatform.Application.Interfaces.IServices;
using FutureEducationalPlatform.Domain.Entities.CourseEntites;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace FutureEducationalPlatform.Application.CQRS.Handlers.CourseHandlers
{
    public class DeleteCourseHandler : BaseCourseHandler, IRequestHandler<DeleteCourseRequest, string>
    {
        public DeleteCourseHandler(IBaseService<Course,GetCourseDto,AddCourseDto,UpdateCourseDto> baseService) : base(baseService) { }

        public async Task<string> Handle(DeleteCourseRequest request, CancellationToken cancellationToken)
        {
            var course = await _baseService.GetByPropertyAsyncWithoutMap(c => c.Id == request.Id, c => c.Include(c => c.Centers).Include(c=>c.Sections));
            foreach (var center in course.Centers) 
                center.IsDeleted = true;
            foreach(var section in course.Sections) 
                section.IsDeleted = true;
            await _baseService.Delete(course);
            return "تم حذف الدورة بنجاح";
        }
    }
}
