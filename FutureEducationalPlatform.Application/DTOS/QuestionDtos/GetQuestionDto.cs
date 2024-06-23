
namespace FutureEducationalPlatform.Application.DTOS.QuestionDtos
{
    public record GetQuestionDto(Guid Id,DateTime UpdatedAt, DateTime CreatedAt) :BaseQuestionDto;
}
