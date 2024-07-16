using FluentValidation;
using FutureEducationalPlatform.Application.CQRS.Commands.AuthCommands;
using System.Linq.Expressions;

namespace FutureEducationalPlatform.Application.Common.Validators.AuthValidators
{
    public class RegisterValidator : BaseAuthValidator<RegisterRequest>
    {
        public RegisterValidator():base(r=>r.CreateUserDto.Password)
        {
            RuleFor(r => r.CreateUserDto.Email).EmailAddress().WithMessage("يرجي اضافة بريد الكتروني صحيح");
            AddNameRule(r => r.CreateUserDto.FirstName, "FirstName");
            AddNameRule(r => r.CreateUserDto.LastName, "LastName");
            AddNameRule(r => r.CreateUserDto.UserName, "UserName");
            RuleFor(r => r.CreateUserDto.Gender)
                .IsInEnum()
                .WithMessage("قيمة النوع غير صحيحة");
        }
        private void AddNameRule(Expression<Func<RegisterRequest, string>> expression, string fieldName)
        {
            RuleFor(expression)
                .Length(2, 16)
                .WithMessage($"{fieldName} يجب ان يكون من 2 الي 16 حرف");
        }
    }
}
