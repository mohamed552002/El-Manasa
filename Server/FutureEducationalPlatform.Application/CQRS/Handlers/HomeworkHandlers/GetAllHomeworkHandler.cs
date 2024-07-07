using FutureEducationalPlatform.Application.CQRS.Queries.HomeworkQueries;
using FutureEducationalPlatform.Application.DTOS.HomeworkDtos;
using FutureEducationalPlatform.Application.Interfaces.IServices;
using FutureEducationalPlatform.Domain.Entities.HomeworkEntites;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutureEducationalPlatform.Application.CQRS.Handlers.HomeworkHandlers
{
    public class GetAllHomeworkHandler : BaseHomeworkHandler, IRequestHandler<GetAllHomeworkRequest, IEnumerable<GetHomeworkDto>>
    {
        public GetAllHomeworkHandler(IBaseService<Homework, GetHomeworkDto, CreateHomeworkDto, UpdateHomeworkDto> baseService) : base(baseService)
        {
        }

        public async Task<IEnumerable<GetHomeworkDto>> Handle(GetAllHomeworkRequest request, CancellationToken cancellationToken)
        {
            var homework = await _baseService.GetAllAsync();
            return homework;
        }
    }
}
