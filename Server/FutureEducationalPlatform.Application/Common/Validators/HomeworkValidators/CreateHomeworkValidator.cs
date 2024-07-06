using FluentValidation;
using FutureEducationalPlatform.Application.CQRS.Commands.HomeworkCommands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
