using FluentValidation;
using FutureEducationalPlatform.Application.CQRS.Commands.CenterCommands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutureEducationalPlatform.Application.Common.Validators.CenterValidators
{
    public class UpdateCenterValidator : AbstractValidator<UpdateCenterRequest>
    {
        public UpdateCenterValidator()
        {
            RuleFor(c => c.UpdateCenterDto.Name).NotEmpty().NotNull().Length(2,60).WithMessage("يجب ان يكون اسم السنتر بين 2 الي 60 حرف");
            RuleFor(c => c.UpdateCenterDto.Address).NotEmpty().NotNull().Length(2,60).WithMessage("يجب ان يكون اسم السنتر بين 5 الي 120 حرف");
        }
    }
}
