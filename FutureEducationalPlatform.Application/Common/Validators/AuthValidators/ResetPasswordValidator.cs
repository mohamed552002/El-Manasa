using FluentValidation;
using FutureEducationalPlatform.Application.CQRS.Commands.AuthCommands;


namespace FutureEducationalPlatform.Application.Common.Validators.AuthValidators
{
    public class ResetPasswordValidator : AbstractValidator<ResetPasswordRequest>
    {
        public ResetPasswordValidator()
        {
            RuleFor(rp => rp.ResetPasswordDto.email).EmailAddress().WithMessage("Please enter valid email").NotEmpty().NotNull();
            RuleFor(rp => rp.ResetPasswordDto.newPassword)
                    .NotEmpty().WithMessage("Password must not be empty")
                    .MinimumLength(8).WithMessage("Password must be at least 8 characters long")
                    .Matches(@"[A-Z]").WithMessage("Password must contain at least one uppercase letter")
                    .Matches(@"[a-z]").WithMessage("Password must contain at least one lowercase letter")
                    .Matches(@"[0-9]").WithMessage("Password must contain at least one number")
                    .Matches(@"[\W_]").WithMessage("Password must contain at least one special character")
                    .NotEmpty().NotNull();
            RuleFor(rp => rp.ResetPasswordDto.OTP).NotEmpty().NotNull().Length(6).WithMessage("Wrong OTP");
        }
    }
}
