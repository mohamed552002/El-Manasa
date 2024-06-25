using FluentValidation;
using FutureEducationalPlatform.Application.CQRS.Commands.QuestionCommands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutureEducationalPlatform.Application.Common.Validators.QuestionValidators
{
    public class CreateQuestionValidator : AbstractValidator<CreateQuestionRequest>
    {
        public CreateQuestionValidator()
        {
            RuleFor(q => q.CreateQuestionDto).SetValidator(new BaseQuestionValidator());
            RuleFor(q => q.CreateQuestionDto.CreatedAt).NotEmpty().NotNull()
                .GreaterThanOrEqualTo(DateTime.Now).WithMessage("لا يمكن ان يكون تاريخ اضافة السؤال في الماضي");
        }
    }
}
