using FutureEducationalPlatform.Application.DTOS.ExamQuestionDtos;
using FutureEducationalPlatform.Application.Interfaces.IServices;
using FutureEducationalPlatform.Domain.Entities.ExamEntities;
using MediatR;

namespace FutureEducationalPlatform.Application.CQRS.Handlers.ExamQuestionHandlers
{
    public class DeleteExamQuestionHandler : BaseExamQuestionHandler, IRequestHandler<DeleteExamQuestionRequest, string>
    {
        public DeleteExamQuestionHandler(IBaseService<ExamQuestion, GetExamQuestionDto, CreateExamQuestionDto, UpdateExamQuestionDto> baseService) : base(baseService) { }

        public async Task<string> Handle(DeleteExamQuestionRequest request, CancellationToken cancellationToken)
        {
            await _baseService.Delete(request.Id);
            return "تم حذف العنصر بنجاح";
        }
    }
}
