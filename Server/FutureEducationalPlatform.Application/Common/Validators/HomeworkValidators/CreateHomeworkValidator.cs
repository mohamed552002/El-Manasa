using FluentValidation;
using FutureEducationalPlatform.Application.CQRS.Commands.HomeworkCommands;

namespace FutureEducationalPlatform.Application.Common.Validators.HomeworkValidators
{
    public class CreateHomeworkValidator : AbstractValidator<CreateHomeworkRequest>
    {
        public CreateHomeworkValidator()
        {
            RuleFor(h => h.CreateHomeworkDto).SetValidator(new BaseHomeworkValidator());
        }
    }
}
