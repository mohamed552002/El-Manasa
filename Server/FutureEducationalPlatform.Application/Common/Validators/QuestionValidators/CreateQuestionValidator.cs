using FluentValidation;
using FutureEducationalPlatform.Application.CQRS.Commands.QuestionCommands;

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
