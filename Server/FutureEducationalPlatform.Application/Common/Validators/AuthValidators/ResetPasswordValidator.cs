﻿using FluentValidation;
using FutureEducationalPlatform.Application.CQRS.Commands.AuthCommands;


namespace FutureEducationalPlatform.Application.Common.Validators.AuthValidators
{
    public class ResetPasswordValidator : BaseAuthValidator<ResetPasswordRequest>
    {
        public ResetPasswordValidator():base(r=>r.ResetPasswordDto.newPassword)
        {
            RuleFor(rp => rp.ResetPasswordDto.email).EmailAddress().WithMessage("Please enter valid email").NotEmpty().NotNull();
            RuleFor(rp => rp.ResetPasswordDto.OTP).NotEmpty().NotNull().Length(6).WithMessage("Wrong OTP");
        }
    }
}
