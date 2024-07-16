using FutureEducationalPlatform.Application.DTOS.ExamDtos;
using FutureEducationalPlatform.Application.Interfaces.IServices;
using FutureEducationalPlatform.Domain.Entities.ExamEntities;
using MediatR;

namespace FutureEducationalPlatform.Application.CQRS.Handlers.ExamHandlers
{
    public class GetExamByIdHandler : BaseExamHandler, IRequestHandler<GetExamByIdRequest, GetExamDto>
    {
        public GetExamByIdHandler(IBaseService<Exam, GetExamDto, CreateExamDto, UpdateExamDto> baseService) : base(baseService) { }
        public async Task<GetExamDto> Handle(GetExamByIdRequest request, CancellationToken cancellationToken) =>
            await _baseService.GetByIdAsync(request.Id);
    }
}
