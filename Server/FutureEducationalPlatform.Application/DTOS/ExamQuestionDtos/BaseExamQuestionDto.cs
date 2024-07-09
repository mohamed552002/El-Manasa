namespace FutureEducationalPlatform.Application.DTOS.ExamQuestionDtos
{
    public record BaseExamQuestionDto
    {
       public Guid ExamId { get; set; }
       public Guid QuestionId { get; set; }
    }
}
