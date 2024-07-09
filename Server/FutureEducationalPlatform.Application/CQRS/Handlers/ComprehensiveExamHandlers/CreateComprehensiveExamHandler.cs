using FutureEducationalPlatform.Application.DTOS.ComprehensiveExamDtos;
using FutureEducationalPlatform.Application.Interfaces.IServices;
using FutureEducationalPlatform.Domain.Entities.ComprehensiveExamEntities;
using MediatR;

namespace FutureEducationalPlatform.Application.CQRS.Handlers.ComprehensiveExamHandlers
{
    public class CreateComprehensiveExamHandler : BaseComprehensiveExamHandler , IRequestHandler<CreateComprehensiveExamRequest, string>
    {
        public CreateComprehensiveExamHandler(IBaseService<ComprehensiveExam, GetComprehensiveExamDto, CreateComprehensiveExamDto, UpdateComprehensiveExamDto> baseService) : base(baseService)
        {
        }

        public async Task<string> Handle(global::CreateComprehensiveExamRequest request, CancellationToken cancellationToken)
        {
           await _baseService.CreateAsync(request.CreateComprehensiveExamDto);
            return "تمت اضافة الامتحان الشامل بنجاح";
        }
    }
}
