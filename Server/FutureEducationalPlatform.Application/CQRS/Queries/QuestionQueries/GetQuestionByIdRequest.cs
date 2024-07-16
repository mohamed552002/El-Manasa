using FutureEducationalPlatform.Application.DTOS.QuestionDtos;
using MediatR;

namespace FutureEducationalPlatform.Application.CQRS.Queries.QuestionQueries
{
    public record GetQuestionByIdRequest(Guid Id):IRequest<GetQuestionDto>;

}
