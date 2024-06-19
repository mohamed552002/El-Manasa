using FluentValidation;
using FutureEducationalPlatform.Application.DTOS.CenterDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutureEducationalPlatform.Application.Common.Validators.CenterValidators
{
    public class BaseValidator:AbstractValidator<BaseCenterDto>
    {
        public BaseValidator()
        {
            RuleFor(c => c.Name)
               .NotEmpty()
               .NotNull()
               .Length(2, 60)
               .WithMessage("يجب ان يكون اسم السنتر بين 2 الي 60 حرف");
            RuleFor(c => c.Address)
                .NotEmpty()
                .NotNull()
                .Length(5, 120)
                .WithMessage("يجب ان يكون عنوان السنتر بين 5 الي 120 حرف");
        }
    }
}
