namespace FutureEducationalPlatform.Application.DTOS.QuestionDtos
{
    public record UpdateQuestionDto : BaseQuestionDto
    {
        public DateTime UpdatedAt { get; set;} = DateTime.Now;
    }
}
