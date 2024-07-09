using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutureEducationalPlatform.Application.Common.Validators.ComprehensiveExamValidators
{
    public class CreateComprehensiveExamValidator : AbstractValidator<CreateComprehensiveExamRequest>
    {
        public CreateComprehensiveExamValidator()
        {
            RuleFor(ch => ch.CreateComprehensiveExamDto).SetValidator(new BaseComprehensiveExamValidator());
        }
    }
}
