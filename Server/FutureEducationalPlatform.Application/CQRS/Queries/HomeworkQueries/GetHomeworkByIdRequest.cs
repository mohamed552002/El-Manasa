using FutureEducationalPlatform.Application.DTOS.HomeworkDtos;
using MediatR;

namespace FutureEducationalPlatform.Application.CQRS.Queries.HomeworkQueries
{
    public record GetHomeworkByIdRequest(Guid Id):IRequest<GetHomeworkDto>;
}
