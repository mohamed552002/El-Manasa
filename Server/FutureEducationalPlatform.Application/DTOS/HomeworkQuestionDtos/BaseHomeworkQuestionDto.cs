
namespace FutureEducationalPlatform.Application.DTOS.HomeworkQuestionDtos
{
    public record BaseHomeworkQuestionDto 
    {
        public Guid HomeworkId { get; set; }
        public Guid QuestionId { get; set; }
    }
}
