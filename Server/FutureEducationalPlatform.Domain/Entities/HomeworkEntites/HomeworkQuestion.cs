using FutureEducationalPlatform.Domain.Common;
using FutureEducationalPlatform.Domain.Entities.QuestionEntites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
