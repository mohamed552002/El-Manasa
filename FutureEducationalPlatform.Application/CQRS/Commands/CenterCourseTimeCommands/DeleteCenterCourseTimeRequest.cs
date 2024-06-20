using MediatR;

namespace FutureEducationalPlatform.Application.CQRS.Commands.CenterCourseTimeCommands
{
    public record DeleteCenterCourseTimeRequest(Guid Id) : IRequest<string>;
}
