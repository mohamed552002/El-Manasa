
using FutureEducationalPlatform.Domain.Enums;

namespace FutureEducationalPlatform.Application.DTOS.QuestionDtos
{
    public record BaseQuestionDto
    {
        public string Text { get; set; }
        public QuestionType Type { get; set; }
        public QuestionDifficulity Difficulity { get; set; }
        public QuestionAnswers Answers { get; set; }
        public  double Grade { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    };
}
