
using FutureEducationalPlatform.Application.DTOS.CourseDtos;
using MediatR;

namespace FutureEducationalPlatform.Application.CQRS.Commands.CourseCommands
{
    public class AddCourseRequest : IRequest<string>
    {
        public AddCourseDto addCourseDto { get;}
        public AddCourseRequest(AddCourseDto addCourseDto)
        {
            this.addCourseDto = addCourseDto;
        }
    }
}
