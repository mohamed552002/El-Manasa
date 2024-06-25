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
    public class UpdateCourseHandler : BaseCourseHandler, IRequestHandler<UpdateCourseRequest, Course>
    {
        public UpdateCourseHandler(IBaseService<Course,GetCourseDto,AddCourseDto,UpdateCourseDto> baseService):base(baseService) { }
        public async Task<Course> Handle(UpdateCourseRequest request, CancellationToken cancellationToken) => await _baseService.Update(request.Id, request.UpdateCourseDto);
    }
}
