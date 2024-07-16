using FutureEducationalPlatform.Application.DTOS.ExamDtos;
using FutureEducationalPlatform.Application.Interfaces.IServices;
using FutureEducationalPlatform.Domain.Entities.ExamEntities;
using MediatR;

namespace FutureEducationalPlatform.Application.CQRS.Handlers.ExamHandlers
{
    public class GetAllExamsHandler : BaseExamHandler, IRequestHandler<GetAllExamsRequest, IEnumerable<GetExamDto>>
    {
        public GetAllExamsHandler(IBaseService<Exam, GetExamDto, CreateExamDto, UpdateExamDto> baseService) : base(baseService) { }

        public async Task<IEnumerable<GetExamDto>> Handle(GetAllExamsRequest request, CancellationToken cancellationToken) =>
            await _baseService.GetAllAsync();
    }
}
