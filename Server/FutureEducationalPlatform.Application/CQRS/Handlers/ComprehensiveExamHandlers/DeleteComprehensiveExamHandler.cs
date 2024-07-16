using FutureEducationalPlatform.Application.CQRS.Commands.CourseCommands;
using FutureEducationalPlatform.Application.DTOS.ComprehensiveExamDtos;
using FutureEducationalPlatform.Application.Interfaces.IServices;
using FutureEducationalPlatform.Domain.Entities.ComprehensiveExamEntities;
using MediatR;

namespace FutureEducationalPlatform.Application.CQRS.Handlers.ComprehensiveExamHandlers
{
    public class DeleteComprehensiveExamHandler : BaseComprehensiveExamHandler, IRequestHandler<DeleteComprehensiveExamRequest, string>
    {
        public DeleteComprehensiveExamHandler(IBaseService<ComprehensiveExam, GetComprehensiveExamDto, CreateComprehensiveExamDto, UpdateComprehensiveExamDto> baseService) : base(baseService) { }

        public async Task<string> Handle(DeleteComprehensiveExamRequest request, CancellationToken cancellationToken)
        {
            await _baseService.Delete(request.Id);
            return "تم حذف الامتحان الشامل بنجاح";
        }
    }
}
