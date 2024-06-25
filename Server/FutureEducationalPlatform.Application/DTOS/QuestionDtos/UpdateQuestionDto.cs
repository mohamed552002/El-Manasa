using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutureEducationalPlatform.Application.DTOS.QuestionDtos
{
    public record UpdateQuestionDto : BaseQuestionDto
    {
        public DateTime UpdatedAt { get; set;} = DateTime.Now;
    }
}
