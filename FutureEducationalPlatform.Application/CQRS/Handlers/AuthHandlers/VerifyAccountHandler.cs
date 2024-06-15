using FutureEducationalPlatform.Application.Common.Exceptions;
using FutureEducationalPlatform.Application.Common.Validators.AuthValidators;
using FutureEducationalPlatform.Application.CQRS.Commands.AuthCommands;
using FutureEducationalPlatform.Application.DTOS.AuthDtos;
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
        private readonly IMemoryCache _memoryCache;
        private readonly IJwtService _jwtService;

        public VerifyAccountHandler(IIdentityService identityService, IMemoryCache memoryCache, IJwtService jwtService)
        {
            _identityService = identityService;
            _memoryCache = memoryCache;
            _jwtService = jwtService;
        }

        public async Task<AuthModel> Handle(VerifyAccountRequest request, CancellationToken cancellationToken)
        {
            var user=await _identityService.GetByEmailAsync(request.VerifyAccountDto.Email);
            if (user == null) throw new EntityNotFoundException("Wrong email");
            if (!_memoryCache.TryGetValue($"{user.Id} OTP", out string cashedCode)) throw new NoDataFoundException("Verification code was not found or has expired");
            if (request.VerifyAccountDto.VerificationCode != cashedCode) throw new BadRequestException("Please enter valid verificationcode");
            user.EmailConfirmed = true;
            var refreshToken = _jwtService.GenerateRefreshToken();
            user.RefreshTokens.Add(refreshToken);
            await _identityService.SaveChangesAsync();
            var jwtSecurityToken =await _jwtService.GenerateToken(user);
            var userRoles=await _identityService.GetUserRoles(user);
            return new AuthModel(user, refreshToken, userRoles, jwtSecurityToken);
        }
    }
}
