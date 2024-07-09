using FutureEducationalPlatform.Application.CQRS.Queries.ComprehensiveExamQueries;
using FutureEducationalPlatform.Application.DTOS.ComprehensiveExamDtos;
using FutureEducationalPlatform.Application.Interfaces.IServices;
using FutureEducationalPlatform.Domain.Entities.ComprehensiveExamEntities;
using MediatR;

namespace FutureEducationalPlatform.Application.CQRS.Handlers.ComprehensiveExamHandlers
{
    public class GetComprehensiveExamsHandler : BaseComprehensiveExamHandler, IRequestHandler<GetComprehensiveExamsRequest, IEnumerable<GetComprehensiveExamDto>>
    {
        public GetComprehensiveExamsHandler(IBaseService<ComprehensiveExam, GetComprehensiveExamDto, CreateComprehensiveExamDto, UpdateComprehensiveExamDto> baseService) : base(baseService){}

        public async Task<IEnumerable<GetComprehensiveExamDto>> Handle(GetComprehensiveExamsRequest request, CancellationToken cancellationToken)=>
            await _baseService.GetAllAsync();
    }
}
