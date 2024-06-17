using FutureEducationalPlatform.Application.DTOS.CourseDtos;
using FutureEducationalPlatform.Domain.Entities.CourseEntites;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutureEducationalPlatform.Application.CQRS.Commands.CourseCommands
{
    public class UpdateCourseRequest:IRequest<Course>
    {
        public Guid Id { get; }
        public UpdateCourseDto UpdateCourseDto { get; }

        public UpdateCourseRequest(Guid id,UpdateCourseDto updateCourseDto)
        {
            Id = id;
            UpdateCourseDto = updateCourseDto;
        }
    }
}
