using FutureEducationalPlatform.Application.DTOS.HomeworkDtos;
using MediatR;

namespace FutureEducationalPlatform.Application.CQRS.Commands.HomeworkCommands
{
    public record CreateHomeworkRequest(CreateHomeworkDto CreateHomeworkDto):IRequest<string>;
}
