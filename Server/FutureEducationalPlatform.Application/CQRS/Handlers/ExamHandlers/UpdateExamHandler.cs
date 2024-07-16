using FutureEducationalPlatform.Application.DTOS.ExamDtos;
using FutureEducationalPlatform.Domain.Entities.ExamEntities;
using MediatR;

namespace FutureEducationalPlatform.Application.CQRS.Handlers.ExamHandlers
{
    public class UpdateExamHandler : BaseExamHandler, IRequestHandler<UpdateExamRequest, string>
    {
        public UpdateExamHandler(Interfaces.IServices.IBaseService<Exam, GetExamDto, CreateExamDto, UpdateExamDto> baseService) : base(baseService) { }

        public async Task<string> Handle(UpdateExamRequest request, CancellationToken cancellationToken)
        {
            await _baseService.Update(request.Id, request.UpdateExamDto);
            return "تم تحديث بيانات الاختبار بنجاح";
        }
    }
}
