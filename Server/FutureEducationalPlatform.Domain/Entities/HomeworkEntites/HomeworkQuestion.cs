using FutureEducationalPlatform.Domain.Common;
using FutureEducationalPlatform.Domain.Entities.QuestionEntites;

namespace FutureEducationalPlatform.Domain.Entities.HomeworkEntites
{
    public class HomeworkQuestion : BaseModel
    {
        public Guid HomeworkId { get; set; }
        public Guid QuestionId { get; set; }
        public Homework Homework { get; set; }
        public Question Question { get; set; }
    }
}
