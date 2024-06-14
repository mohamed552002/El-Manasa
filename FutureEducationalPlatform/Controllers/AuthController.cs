using FutureEducationalPlatform.Application.CQRS.Commands.AuthCommands;
using FutureEducationalPlatform.Application.DTOS.AuthDtos;
using FutureEducationalPlatform.Application.DTOS.UserDtos;
using FutureEducationalPlatform.Domain.Entities.AuthEntites;
using MediatR;
using Microsoft.AspNetCore.Http;
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
        [HttpPost("Register")]
        public async Task<IActionResult> RegisterAsync(CreateUserDto userDto)
        {
            var command=new RegisterRequest(userDto);
            var result=await _mediator.Send(command);
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
