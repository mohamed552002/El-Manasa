using FutureEducationalPlatform.Application.DTOS.ExamDtos;
using FutureEducationalPlatform.Application.Interfaces.IServices;
using FutureEducationalPlatform.Domain.Entities.ExamEntities;
using MediatR;

namespace FutureEducationalPlatform.Application.CQRS.Handlers.ExamHandlers
{
    public class DeleteExamHandler : BaseExamHandler, IRequestHandler<DeleteExamRequest, string>
    {
        public DeleteExamHandler(IBaseService<Exam, GetExamDto, AddExamDto, UpdateExamDto> baseService) : base(baseService) { }

        public async Task<string> Handle(DeleteExamRequest request, CancellationToken cancellationToken)
        {
            await _baseService.Delete(request.Id);
            return "تم حذف الاختبار بنجاح";
        }
    }
}
