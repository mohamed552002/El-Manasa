using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutureEducationalPlatform.Application.CQRS.Commands.CourseCommands
{
    public class DeleteCourseRequest:IRequest<string>
    {
        public Guid Id { get; }

        public DeleteCourseRequest(Guid id)
        {
            Id = id;
        }
    }
}
