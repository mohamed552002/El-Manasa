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
    public class AddCourseHandler : BaseCourseHandler , IRequestHandler<AddCourseRequest, string>
    {
        public AddCourseHandler(IBaseService<Course, GetCourseDto, AddCourseDto, UpdateCourseDto> baseService) : base(baseService)
        {
        }

        public async Task<string> Handle(AddCourseRequest request, CancellationToken cancellationToken)
        {
           await _baseService.CreateAsync(request.addCourseDto);
            return "تمت اضافة الدورة بنجاح";
        }
    }
}
