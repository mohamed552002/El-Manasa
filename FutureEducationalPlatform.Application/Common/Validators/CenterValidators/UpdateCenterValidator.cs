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
            RuleFor(r => r.UpdateCenterDto).SetValidator(new BaseValidator());
        }
    }
}
