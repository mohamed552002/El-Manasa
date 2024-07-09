using FutureEducationalPlatform.Application.DTOS.HomeworkQuestionDtos;
using MediatR;

namespace FutureEducationalPlatform.Application.CQRS.Commands.HomeworkQuestionCommands
{
    public record CreateHomewrokQuestionRequest(CreateHomeworkQuestionDto CreateHomeworkQuestionDto) : IRequest<string>;
}
