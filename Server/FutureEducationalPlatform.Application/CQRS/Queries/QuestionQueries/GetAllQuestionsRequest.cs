using FutureEducationalPlatform.Application.DTOS.QuestionDtos;
using MediatR;

namespace FutureEducationalPlatform.Application.CQRS.Queries.QuestionQueries
{
    public record GetAllQuestionsRequest:IRequest<IEnumerable<GetQuestionDto>>;

}
