using FutureEducationalPlatform.Application.CQRS.Queries.QuestionQueries;
using FutureEducationalPlatform.Application.DTOS.QuestionDtos;
using FutureEducationalPlatform.Application.Interfaces.IServices;
using FutureEducationalPlatform.Domain.Entities.QuestionEntites;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutureEducationalPlatform.Application.CQRS.Handlers.QuestionHandlers
{
    public class GetAllQuestionsHandler : BaseQuestionHandler, IRequestHandler<GetAllQuestionsRequest, IEnumerable<GetQuestionDto>>
    {
        public GetAllQuestionsHandler(IBaseService<Question, GetQuestionDto, CreateQuestionDto, UpdateQuestionDto> baseService) : base(baseService)
        {
        }

        public async Task<IEnumerable<GetQuestionDto>> Handle(GetAllQuestionsRequest request, CancellationToken cancellationToken) =>
           await _baseService.GetAllAsync();
    }
}
