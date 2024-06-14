using FutureEducationalPlatform.Application.Common.Exceptions;
using FutureEducationalPlatform.Application.Common.Validators.AuthValidators;
using FutureEducationalPlatform.Application.CQRS.Commands.AuthCommands;
using FutureEducationalPlatform.Application.Interfaces.IHelperServices;
using FutureEducationalPlatform.Application.Interfaces.IServices;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutureEducationalPlatform.Application.CQRS.Handlers.AuthHandlers
{
    public class ResendVerificationCodeHandler : IRequestHandler<ResendVerificationCodeRequest, string>
    {
        private readonly IIdentityService _identityService;
        private readonly IOTPServices _otpService;
        public ResendVerificationCodeHandler(IIdentityService identityService, IOTPServices otpService)
        {
            _identityService = identityService;
            _otpService = otpService;
        }

        public async Task<string> Handle(ResendVerificationCodeRequest request, CancellationToken cancellationToken)
        {
            var validator=new ResendVerificationCodeDtoValidator();
            var result = await validator.ValidateAsync(request.ResendVerificationCodeDto);
            if(result.Errors.Any()) throw new ValidationErrorException(result.Errors.Select(e=>e.ErrorMessage).ToArray());
            var user=await _identityService.GetByEmailAsync(request.ResendVerificationCodeDto.Email);
            if (user == null) throw new EntityNotFoundException("Wrong email");
            _otpService.SendOTP(user.Email, user.Id.ToString());
            return "Verification code has been sent again";
        }
    }
}
