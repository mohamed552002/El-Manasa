
using FutureEducationalPlatform.Application.DTOS.HomeworkQuestionDtos;
using MediatR;

namespace FutureEducationalPlatform.Application.CQRS.Commands.HomeworkQuestionCommands
{
    public record UpdateHomeworkQuestionRequest(Guid Id , UpdateHomeworkQuestionDto UpdateHomeworkQuestionDto) : IRequest<string>;

}
