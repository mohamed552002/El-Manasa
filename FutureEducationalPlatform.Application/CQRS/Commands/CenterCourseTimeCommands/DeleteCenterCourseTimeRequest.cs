using MediatR;

namespace FutureEducationalPlatform.Application.CQRS.Commands.CenterCourseTimeCommands
{
    public record DeleteCenterCourseTimeRequest(Guid courseId, Guid centerId) : IRequest<string>;
}
