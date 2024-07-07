using MediatR;


namespace FutureEducationalPlatform.Application.CQRS.Commands.QuestionCommands
{
    public record DeleteQuestionRequest(Guid Id) : IRequest<string>;

}
