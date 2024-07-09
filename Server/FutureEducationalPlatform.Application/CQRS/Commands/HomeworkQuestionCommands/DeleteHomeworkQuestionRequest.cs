using MediatR;

namespace FutureEducationalPlatform.Application.CQRS.Commands.HomeworkQuestionCommands
{
    public record DeleteHomeworkQuestionRequest(Guid Id) : IRequest<string>;
}
