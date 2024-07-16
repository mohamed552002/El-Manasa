using FutureEducationalPlatform.Application.DTOS.QuestionDtos;
using MediatR;

namespace FutureEducationalPlatform.Application.CQRS.Commands.QuestionCommands
{
    public record CreateQuestionRequest(CreateQuestionDto CreateQuestionDto) : IRequest<string>;

}
