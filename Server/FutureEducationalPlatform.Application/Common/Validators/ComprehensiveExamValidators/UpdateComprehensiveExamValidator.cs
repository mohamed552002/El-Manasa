using FluentValidation;
using FutureEducationalPlatform.Application.CQRS.Commands.CenterCommands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutureEducationalPlatform.Application.Common.Validators.ComprehensiveExamValidators
{
    public class UpdateComprehensiveExamValidator : AbstractValidator<UpdateComprehensiveExamRequest>
    {
        public UpdateComprehensiveExamValidator()
        {
            RuleFor(ch => ch.UpdateComprehensiveExamDto).SetValidator(new BaseComprehensiveExamValidator());
        }
    }
}
