using MediatR;

namespace FutureEducationalPlatform.Application.CQRS.Commands.CenterCourseTimeCommands
{
    public record DeleteCenterCourseTimeRequest(Guid id) : IRequest<string>;
}
