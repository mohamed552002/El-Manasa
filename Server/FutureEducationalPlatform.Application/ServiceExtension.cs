using FluentValidation;
using FutureEducationalPlatform.Application.Common.HelperModels;
using FutureEducationalPlatform.Application.Interfaces.IHelperServices;
using FutureEducationalPlatform.Application.Interfaces.IServices;
using FutureEducationalPlatform.Application.Services;
using FutureEducationalPlatform.Application.Services.HelperServices;
using MediatR;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using UnderAdmission.Application.Features_Imp.Common.Behaviors;
namespace FutureEducationalPlatform.Application
{
    public static class ServiceExtension
    {
        public static void ConfigureApplication(this IServiceCollection services,IConfiguration configuration)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));
            services.Configure<MessageSender>(configuration.GetSection("MessageSender"));
            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehavior<,>));
            services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
            services.AddScoped(typeof(IBaseService<,,,>), typeof(BaseService<,,,>));
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IRoleService, RoleService>();
            services.AddScoped<IEmailSender, EmailSender>();
            services.AddScoped<IOTPServices, OTPServices>();
            services.AddScoped<IPasswordService, PasswordService>();
            services.AddScoped<IJwtService, JwtService>();
        }
    }
}
