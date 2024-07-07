﻿using FutureEducationalPlatform.Application.CQRS.Commands.AuthCommands;
using FutureEducationalPlatform.Application.DTOS.AuthDtos;
using FutureEducationalPlatform.Application.DTOS.UserDtos;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace FutureEducationalPlatform.Controllers
{
    public class AuthController : BaseController
    {
        public AuthController(IMediator mediator) : base(mediator)
        {
        }
        [HttpPost("Login")]
        public async Task<IActionResult> LoginAsync(LoginDto loginDto)
        {
             var command = new LoginRequest(loginDto);
             var result = await _mediator.Send(command);
             SetRefreshTokenInCookie(result.RefreshToken, result.RefreshTokenExpiration);
             return Ok(result);
        }
        [HttpPut("ChangePassword")]
        public async Task<IActionResult> ChangePassword([FromBody] ChangePasswordDto changePasswordDto)
        {
            changePasswordDto.refreshToken = Request.Cookies["RefreshToken"];
            var result = await _mediator.Send(new ChangePasswordRequest(changePasswordDto));
            return Ok("New Password Is: " + result);
        }
        [HttpPost("Register")]
        public async Task<IActionResult> RegisterAsync(CreateUserDto userDto)
        {
            var command= new RegisterRequest(userDto);
            var result = await _mediator.Send(command);
            return Ok(result);
        }
        [HttpPost("ForgetPassword")]
        public async Task<IActionResult> ForgetPassword(string email)
        {
            await _mediator.Send(new ForgetPasswordRequest(email));
            return Ok("Forget password OTP has been sent To your email ");
        }
        [HttpPost("VerifyAccount")]
        public async Task<IActionResult> VerifyAccountAsync(VerifyAccountDto verifyAccountDto)
        {
            var command=new VerifyAccountRequest(verifyAccountDto);
            var result=await _mediator.Send(command);
            return Ok(result);
        }

        [HttpPost("ResendVerificationCode")]
        public async Task<IActionResult> ResendVerificationCodeAsync(UserEmailDto userEmailDto)
        {
            var command=new ResendVerificationCodeRequest(userEmailDto);
            var result=await _mediator.Send(command);
            return Ok(result);
        }
        [HttpPut("ResetPassword")]
        public async Task<IActionResult> ResetPassword(ResetPasswordDto resetPasswordDto)
        {
            var result =await _mediator.Send(new ResetPasswordRequest(resetPasswordDto));
            return Ok(result);
        }
        private void SetRefreshTokenInCookie(string refreshToken,DateTime expires)
        {
            CookieOptions cookieOptions = new CookieOptions
            {
                Expires = expires.ToLocalTime(),
                HttpOnly = true,
                Secure = true,
                IsEssential = true,
                SameSite = SameSiteMode.None,
            };
            Response.Cookies.Append("RefreshToken", refreshToken, cookieOptions);
        }
    }
}
