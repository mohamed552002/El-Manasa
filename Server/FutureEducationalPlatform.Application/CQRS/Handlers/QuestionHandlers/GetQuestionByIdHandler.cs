using FutureEducationalPlatform.Application.CQRS.Queries.QuestionQueries;
using FutureEducationalPlatform.Application.DTOS.QuestionDtos;
using FutureEducationalPlatform.Application.Interfaces.IServices;
using FutureEducationalPlatform.Domain.Entities.QuestionEntites;
using MediatR;

namespace FutureEducationalPlatform.Application.CQRS.Handlers.QuestionHandlers
{
    public class GetQuestionByIdHandler : BaseQuestionHandler, IRequestHandler<GetQuestionByIdRequest, GetQuestionDto>
    {
        public GetQuestionByIdHandler(IBaseService<Question, GetQuestionDto, CreateQuestionDto, UpdateQuestionDto> baseService) : base(baseService)
        {
        }

        public async Task<GetQuestionDto> Handle(GetQuestionByIdRequest request, CancellationToken cancellationToken)=>
           await _baseService.GetByIdAsync(request.Id);
    }
}
