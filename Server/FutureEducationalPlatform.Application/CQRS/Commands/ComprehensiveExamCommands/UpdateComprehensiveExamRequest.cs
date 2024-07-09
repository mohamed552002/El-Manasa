using FutureEducationalPlatform.Application.DTOS.ComprehensiveExamDtos;
using MediatR;

namespace FutureEducationalPlatform.Application.CQRS.Commands.CenterCommands
{
    public record UpdateComprehensiveExamRequest(Guid Id, UpdateComprehensiveExamDto UpdateComprehensiveExamDto) : IRequest<string>;
}
