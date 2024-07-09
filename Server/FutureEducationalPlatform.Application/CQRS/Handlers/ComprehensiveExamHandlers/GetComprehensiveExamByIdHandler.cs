using FutureEducationalPlatform.Application.DTOS.ComprehensiveExamDtos;
using FutureEducationalPlatform.Application.Interfaces.IServices;
using FutureEducationalPlatform.Domain.Entities.ComprehensiveExamEntities;
using MediatR;

namespace FutureEducationalPlatform.Application.CQRS.Handlers.ComprehensiveExamHandlers
{
    public class GetComprehensiveExamByIdHandler : BaseComprehensiveExamHandler, IRequestHandler<GetComprehensiveExamByIdRequest, GetComprehensiveExamDto>
    {
        public GetComprehensiveExamByIdHandler(IBaseService<ComprehensiveExam, GetComprehensiveExamDto, CreateComprehensiveExamDto, UpdateComprehensiveExamDto> baseService) : base(baseService) { }

        public async Task<GetComprehensiveExamDto> Handle(GetComprehensiveExamByIdRequest request, CancellationToken cancellationToken)=>
             await _baseService.GetByIdAsync(request.Id);
    }
}
