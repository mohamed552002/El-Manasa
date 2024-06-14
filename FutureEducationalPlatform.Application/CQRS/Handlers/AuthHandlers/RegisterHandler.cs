using FutureEducationalPlatform.Application.Common.HelperMethods;
using FutureEducationalPlatform.Application.CQRS.Commands.AuthCommands;
using FutureEducationalPlatform.Application.DTOS.UserDtos;
using FutureEducationalPlatform.Application.Exceptions;
using FutureEducationalPlatform.Application.HelperModels;
using FutureEducationalPlatform.Application.Interfaces.IHelperServices;
using FutureEducationalPlatform.Application.Interfaces.IServices;
using FutureEducationalPlatform.Application.Validators.AuthValidators;
using MediatR;
using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutureEducationalPlatform.Application.CQRS.Handlers.AuthHandlers
{
    public class RegisterHandler : IRequestHandler<RegisterRequest, string>
    {
        private readonly IIdentityService _identityService;
        private readonly IEmailSender _emailSender;
        private readonly IMemoryCache _memorycashe;
        private readonly TimeSpan _codeExpiration = TimeSpan.FromMinutes(15);
        public RegisterHandler(IIdentityService identityService, IEmailSender emailSender, IMemoryCache memorycashe)
        {
            _identityService = identityService;
            _emailSender = emailSender;
            _memorycashe = memorycashe;
        }

        public async Task<string> Handle(RegisterRequest request, CancellationToken cancellationToken)
        {
            var validator = new RegisterValidator();
            var result = await validator.ValidateAsync(request.CreateUserDto);
            if (result.Errors.Any()) throw new ValidationErrorException(result.Errors.Select(e => e.ErrorMessage).ToArray());
            if (await _identityService.GetByUserNameAsync(request.CreateUserDto.UserName) != null|| await _identityService.GetByEmailAsync(request.CreateUserDto.Email) != null) throw new BadRequestException("Email or userName is already exist");
            var user = await _identityService.CreateUser(request.CreateUserDto);
            await _identityService.AddToRoleAsync(user, "Student");
            var code = RandomCodeGenerator.GenerateRandomCode();
            _emailSender.SendEmail(user.Email, "Verification Code", $"Your verification code is {code}");
            _memorycashe.Set($"{user.Id} verification", code, _codeExpiration);
            return "Verification code has been sent to your email.";
        }
    }
}
