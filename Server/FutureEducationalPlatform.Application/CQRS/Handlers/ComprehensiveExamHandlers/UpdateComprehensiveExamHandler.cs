using FutureEducationalPlatform.Application.CQRS.Commands.CenterCommands;
using FutureEducationalPlatform.Application.DTOS.ComprehensiveExamDtos;
using FutureEducationalPlatform.Application.Interfaces.IServices;
using FutureEducationalPlatform.Domain.Entities.ComprehensiveExamEntities;
using MediatR;

namespace FutureEducationalPlatform.Application.CQRS.Handlers.ComprehensiveExamHandlers
{
    public class UpdateComprehensiveExamHandler : BaseComprehensiveExamHandler, IRequestHandler<UpdateComprehensiveExamRequest, string>
    {
        public UpdateComprehensiveExamHandler(IBaseService<ComprehensiveExam, GetComprehensiveExamDto, CreateComprehensiveExamDto, UpdateComprehensiveExamDto> baseService):base(baseService) { }
        public async Task<string> Handle(UpdateComprehensiveExamRequest request, CancellationToken cancellationToken)
        {
            await _baseService.Update(request.Id, request.UpdateComprehensiveExamDto);
            return "تم تحديث الامحان الشامل بنجاح";
        }
    }
}
