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
        private readonly IUserService _userService;
        private readonly IOTPServices _otpService;
        public ResendVerificationCodeHandler(IUserService userService, IOTPServices otpService)
        {
            _userService = userService;
            _otpService = otpService;
        }

        public async Task<string> Handle(ResendVerificationCodeRequest request, CancellationToken cancellationToken)
        {
            var user=await _userService.GetByEmailAsync(request.UserEmailDto.Email);
            if (user == null) throw new EntityNotFoundException("خطأ في البريد الالكتروني");
            _otpService.SendOTP(user.Email, user.Id.ToString());
            return "تمت اعادة ارسال رمز التحقق";
        }
    }
}
