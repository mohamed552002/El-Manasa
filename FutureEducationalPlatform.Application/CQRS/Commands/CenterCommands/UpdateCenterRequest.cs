
using FutureEducationalPlatform.Application.DTOS.CenterDtos;
using MediatR;

namespace FutureEducationalPlatform.Application.CQRS.Commands.CenterCommands
{
    public record UpdateCenterRequest(Guid Id, UpdateCenterDto UpdateCenterDto) : IRequest<string>;
}
