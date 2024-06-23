using FutureEducationalPlatform.Application.DTOS.QuestionDtos;
using MediatR;

namespace FutureEducationalPlatform.Application.CQRS.Commands.QuestionCommands
{
    public record UpdateQuestionRequest(Guid Id,UpdateQuestionDto UpdateQuestionDto):IRequest<string>;
}
