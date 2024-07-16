using MediatR;

namespace FutureEducationalPlatform.Application.CQRS.Commands.HomeworkCommands
{
    public record DeleteHomeworkRequest(Guid Id):IRequest<string>;
}
