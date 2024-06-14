using FluentValidation;
using FutureEducationalPlatform.Application.Common.HelperModels;
using FutureEducationalPlatform.Application.DTOS.AuthDtos;
using FutureEducationalPlatform.Application.Interfaces.IHelperServices;
using FutureEducationalPlatform.Application.Interfaces.IRepository;
using FutureEducationalPlatform.Application.Interfaces.IServices;
using FutureEducationalPlatform.Application.Services;
using FutureEducationalPlatform.Application.Services.HelperServices;
using MediatR;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using System.Reflection;
using System.Text;

namespace FutureEducationalPlatform.Application
{
    public static class ServiceExtension
    {
        public static void ConfigureApplication(this IServiceCollection services,IConfiguration configuration)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));
            services.Configure<MessageSender>(configuration.GetSection("MessageSender"));
            services.AddScoped(typeof(IBaseService<,,,>), typeof(BaseService<,,,>));
            services.AddScoped<IIdentityService, IdentityService>();
            services.AddScoped<IEmailSender, EmailSender>();
            services.AddScoped<IPasswordService, PasswordService>();
            services.AddScoped<IJwtService, JwtService>();
        }
    }
}
