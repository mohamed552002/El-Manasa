using FutureEducationalPlatform.Domain.Enums;

namespace FutureEducationalPlatform.Application.DTOS.StudentQuestionAnswerDtos
{
    public record BaseStudentQuestionAnswerDto
    {
        public Guid StudentId { get; set; }
        public Guid QuestionId { get; set; }
        public QuestionAnswers StudentAnswer { get; set; }
        public DateTime AnsweredAt { get; set; }
    }
}
