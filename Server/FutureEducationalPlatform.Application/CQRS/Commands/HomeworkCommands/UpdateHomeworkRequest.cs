

using FutureEducationalPlatform.Application.DTOS.HomeworkDtos;
using MediatR;

namespace FutureEducationalPlatform.Application.CQRS.Commands.HomeworkCommands
{
    public record UpdateHomeworkRequest(Guid Id,UpdateHomeworkDto UpdateHomeworkDto):IRequest<string>;
}
