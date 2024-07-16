using FutureEducationalPlatform.Application.CQRS.Queries.HomeworkQueries;
using FutureEducationalPlatform.Application.DTOS.HomeworkDtos;
using FutureEducationalPlatform.Application.Interfaces.IServices;
using FutureEducationalPlatform.Domain.Entities.HomeworkEntites;
using MediatR;

namespace FutureEducationalPlatform.Application.CQRS.Handlers.HomeworkHandlers
{
    public class GetHomeworkById : BaseHomeworkHandler, IRequestHandler<GetHomeworkByIdRequest, GetHomeworkDto>
    {
        public GetHomeworkById(IBaseService<Homework, GetHomeworkDto, CreateHomeworkDto, UpdateHomeworkDto> baseService) : base(baseService)
        {
        }

        public async Task<GetHomeworkDto> Handle(GetHomeworkByIdRequest request, CancellationToken cancellationToken)
        {
            var homework = await _baseService.GetByIdAsync(request.Id);
            return homework;
        }
    }
}
