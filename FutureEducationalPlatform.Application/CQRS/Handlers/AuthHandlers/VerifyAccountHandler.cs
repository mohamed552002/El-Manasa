using FutureEducationalPlatform.Application.Common.Exceptions;
using FutureEducationalPlatform.Application.Common.Validators.AuthValidators;
using FutureEducationalPlatform.Application.CQRS.Commands.AuthCommands;
using FutureEducationalPlatform.Application.DTOS.AuthDtos;
using FutureEducationalPlatform.Application.Interfaces.IHelperServices;
using FutureEducationalPlatform.Application.Interfaces.IServices;
using FutureEducationalPlatform.Domain.Entities.UserEntities;
using MediatR;
using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutureEducationalPlatform.Application.CQRS.Handlers.AuthHandlers
{
    public class VerifyAccountHandler : IRequestHandler<VerifyAccountRequest, AuthModel>
    {
        private readonly IIdentityService _identityService;
        private readonly IJwtService _jwtService;
        private readonly IOTPServices _otpServices;

        public VerifyAccountHandler(IIdentityService identityService, IJwtService jwtService, IOTPServices otpServices)
        {
            _identityService = identityService;
            _jwtService = jwtService;
            _otpServices = otpServices;
        }

        public async Task<AuthModel> Handle(VerifyAccountRequest request, CancellationToken cancellationToken)
        {
            var user=await _identityService.GetByEmailAsync(request.VerifyAccountDto.Email);
            if (user == null) throw new EntityNotFoundException("Wrong email");
            _otpServices.VerifyOTP(user.Id.ToString(),request.VerifyAccountDto.VerificationCode);
            user.EmailConfirmed = true;
            return await _jwtService.GetAuthModel(user);
        }
    }
}
