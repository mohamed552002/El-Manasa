using FutureEducationalPlatform.Application.DTOS.ExamDtos;
using FutureEducationalPlatform.Application.Interfaces.IServices;
using FutureEducationalPlatform.Domain.Entities.ExamEntities;
using MediatR;

namespace FutureEducationalPlatform.Application.CQRS.Handlers.ExamHandlers
{
    public class AddExamHandler : BaseExamHandler, IRequestHandler<AddExamRequest, string>
    {
        public AddExamHandler(IBaseService<Exam, GetExamDto, AddExamDto, UpdateExamDto> baseService) : base(baseService) { }
        public async Task<string> Handle(AddExamRequest request, CancellationToken cancellationToken)
        {
            await _baseService.CreateAsync(request.AddExamDto);
            return "تم اضافه الاختبار بنجاح";
        }
    }
}
