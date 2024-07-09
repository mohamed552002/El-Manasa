using FutureEducationalPlatform.Domain.Entities.HomeworkEntites;
using FutureEducationalPlatform.Domain.Entities.QuestionEntites;

namespace FutureEducationalPlatform.Application.DTOS.HomeworkQuestionDtos
{
    public record GetHomeworkQuestionDto(Homework Homework, Question Question) : BaseHomeworkQuestionDto;
}
