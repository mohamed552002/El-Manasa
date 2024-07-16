using FluentValidation;
using System.Linq.Expressions;

namespace FutureEducationalPlatform.Application.Common.Validators.AuthValidators
{
    public class BaseAuthValidator<T> : AbstractValidator<T> where T : class
    {
        public BaseAuthValidator(Expression<Func<T,string>> passwordExpression)
        {
            RuleFor(passwordExpression)
                .NotEmpty().NotNull().WithMessage("كلمة المرور لا يمكن ان تكون فارغة")
                .MinimumLength(8).WithMessage("يجب ان تحتوي كلمة المرور علي 8 حروف علي الاقل")
                .Matches(@"[A-Z]").WithMessage("يجب ان تحتوي كلمة المرور علي حرف كبير علي الاقل")
                .Matches(@"[a-z]").WithMessage("يجب ان تحتوي كلمة المرور علي حرف صغير علي الاقل")
                .Matches(@"[0-9]").WithMessage("يجب ان تحتوي كلمة المرور علي رقم واحد علي الافل")
                .Matches(@"[\W_]").WithMessage("يجب ان تحتوي كلمة المرور علي حرف مميز علي الاقل");
        }
    }
}
