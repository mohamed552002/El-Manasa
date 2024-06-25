using FutureEducationalPlatform.Application.DTOS.CenterCourseTimeDtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutureEducationalPlatform.Application.CQRS.Commands.CenterCourseTimeCommands
{
    public record CreateCenterCourseTimeRequest(AddCenterCourseTimeDto AddCenterCourseTimeDto) :IRequest<string>;

}
