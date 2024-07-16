using FluentValidation;
using FutureEducationalPlatform.Application.DTOS.HomeworkDtos;

namespace FutureEducationalPlatform.Application.Common.Validators.HomeworkValidators
{
    public class BaseHomeworkValidator : AbstractValidator<BaseHomeworkDto>
    {
        public BaseHomeworkValidator()
        {
            RuleFor(h => h.Name)
                .NotEmpty()
                .NotNull()
                .MaximumLength(60).WithMessage("لا يمكن ان يتجاوز اسم الواجب 60 حرف");
        }
    }
}
