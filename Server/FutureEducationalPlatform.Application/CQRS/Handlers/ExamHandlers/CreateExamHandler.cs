using FutureEducationalPlatform.Application.DTOS.ExamDtos;
using FutureEducationalPlatform.Application.Interfaces.IServices;
using FutureEducationalPlatform.Domain.Entities.ExamEntities;
using MediatR;

namespace FutureEducationalPlatform.Application.CQRS.Handlers.ExamHandlers
{
    public class CreateExamHandler : BaseExamHandler, IRequestHandler<CreateExamRequest, string>
    {
        public CreateExamHandler(IBaseService<Exam, GetExamDto, CreateExamDto, UpdateExamDto> baseService) : base(baseService) { }
        public async Task<string> Handle(CreateExamRequest request, CancellationToken cancellationToken)
        {
            await _baseService.CreateAsync(request.CreateExamDto);
            return "تم اضافه الاختبار بنجاح";
        }
    }
}
