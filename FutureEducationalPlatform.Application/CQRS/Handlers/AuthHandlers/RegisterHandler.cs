using FutureEducationalPlatform.Application.Common.Exceptions;
using FutureEducationalPlatform.Application.Common.HelperMethods;
using FutureEducationalPlatform.Application.Common.Validators.AuthValidators;
using FutureEducationalPlatform.Application.CQRS.Commands.AuthCommands;
using FutureEducationalPlatform.Application.DTOS.UserDtos;
using FutureEducationalPlatform.Application.Interfaces.IHelperServices;
using FutureEducationalPlatform.Application.Interfaces.IServices;
using MediatR;
using Microsoft.Extensions.Caching.Memory;

namespace FutureEducationalPlatform.Application.CQRS.Handlers.AuthHandlers
{
    public class RegisterHandler : IRequestHandler<RegisterRequest, string>
    {
        private readonly IIdentityService _identityService;
        private readonly IOTPServices _otpService;
        public RegisterHandler(IIdentityService identityService, IEmailSender emailSender, IMemoryCache memorycashe, IOTPServices otpService)
        {
            _identityService = identityService;
            _otpService = otpService;
        }

        public async Task<string> Handle(RegisterRequest request, CancellationToken cancellationToken)
        {
            var validator = new RegisterValidator();
            var result = await validator.ValidateAsync(request.CreateUserDto);
            if (result.Errors.Any()) throw new ValidationErrorException(result.Errors.Select(e => e.ErrorMessage).ToArray());
            if (await _identityService.GetByUserNameAsync(request.CreateUserDto.UserName) != null|| await _identityService.GetByEmailAsync(request.CreateUserDto.Email) != null) throw new BadRequestException("Email or userName is already exist");
            var user = await _identityService.CreateUser(request.CreateUserDto);
            await _identityService.AddToRoleAsync(user, "Student");
            _otpService.SendOTP(user.Email, "Verfication OTP",user.Id.ToString());
            return "Verification code has been sent to your email.";
        }
    }
}
