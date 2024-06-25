using FutureEducationalPlatform.Application.CQRS.Queries.CourseQueries;
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
    public class GetCourseByIdHandler :BaseCourseHandler, IRequestHandler<GetCourseByIdRequest, GetCourseDto>
    {
        public GetCourseByIdHandler(IBaseService<Course, GetCourseDto, AddCourseDto, UpdateCourseDto> baseService) : base(baseService) { }

        public async Task<GetCourseDto> Handle(GetCourseByIdRequest request, CancellationToken cancellationToken)=>
             await _baseService.GetByIdAsync(request.Id);
    }
}
