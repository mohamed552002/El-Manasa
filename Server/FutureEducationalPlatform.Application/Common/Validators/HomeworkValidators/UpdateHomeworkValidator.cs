using FluentValidation;
using FutureEducationalPlatform.Application.CQRS.Commands.HomeworkCommands;

namespace FutureEducationalPlatform.Application.Common.Validators.HomeworkValidators
{
    public class UpdateHomeworkValidator : AbstractValidator<UpdateHomeworkRequest>
    {
        public UpdateHomeworkValidator()
        {
            RuleFor(h => h.UpdateHomeworkDto).SetValidator(new BaseHomeworkValidator());
        }
    }
}
