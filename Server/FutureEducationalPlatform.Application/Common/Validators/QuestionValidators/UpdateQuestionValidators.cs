using FluentValidation;
using FutureEducationalPlatform.Application.CQRS.Commands.QuestionCommands;

namespace FutureEducationalPlatform.Application.Common.Validators.QuestionValidators
{
    public class UpdateQuestionValidators : AbstractValidator<UpdateQuestionRequest>
    {
        public UpdateQuestionValidators()
        {
            RuleFor(q => q.Id).NotNull().NotEmpty().WithMessage("يجب وجود رقم للسؤال المطلوب تحديثة");
            RuleFor(q => q.UpdateQuestionDto).SetValidator(new BaseQuestionValidator());
            RuleFor(q => q.UpdateQuestionDto.UpdatedAt).NotEmpty().NotNull()
                .GreaterThan(q => q.UpdateQuestionDto.CreatedAt).WithMessage("يجب ان يكون تاريخ تعديل السؤال بعد تاريخ اضافته");
        }
    }
}
