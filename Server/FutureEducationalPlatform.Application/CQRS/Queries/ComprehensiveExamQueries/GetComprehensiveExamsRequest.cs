using FutureEducationalPlatform.Application.DTOS.ComprehensiveExamDtos;
using MediatR;

namespace FutureEducationalPlatform.Application.CQRS.Queries.ComprehensiveExamQueries
{
    public class GetComprehensiveExamsRequest() : IRequest<IEnumerable<GetComprehensiveExamDto>>;
}
