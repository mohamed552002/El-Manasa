﻿using FutureEducationalPlatform.Domain.Common;
using FutureEducationalPlatform.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutureEducationalPlatform.Domain.Entities.QuestionEntites
{
    public class Question : BaseModel
    {
        public string Text { get; set; }
        public QuestionType Type { get; set; }
        public QuestionDifficulity Difficulity { get; set; }
        public QuestionAnswers Answers { get; set; }
        public double Grade { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

    }
}
