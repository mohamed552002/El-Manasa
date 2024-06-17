using FutureEducationalPlatform.Application.CQRS.Commands.CourseCommands;
using FutureEducationalPlatform.Application.DTOS.CourseDtos;
using FutureEducationalPlatform.Application.Interfaces.IServices;
using FutureEducationalPlatform.Domain.Entities.CourseEntites;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutureEducationalPlatform.Application.CQRS.Handlers.CourseHandlers
{
    public class DeleteCourseHandler : BaseCourseHandler, IRequestHandler<DeleteCourseRequest, string>
    {
        public DeleteCourseHandler(IBaseService<Course,GetCourseDto,AddCourseDto,UpdateCourseDto> baseService) : base(baseService) { }

        public async Task<string> Handle(DeleteCourseRequest request, CancellationToken cancellationToken)
        {
            await _baseService.Delete(request.Id);
            return "تم حذف الدورة بنجاح";
        }
    }
}
