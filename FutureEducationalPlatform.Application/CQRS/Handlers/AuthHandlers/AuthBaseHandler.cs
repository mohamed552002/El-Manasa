using FutureEducationalPlatform.Application.DTOS.UserDtos;
using FutureEducationalPlatform.Application.Interfaces.IHelperServices;
using FutureEducationalPlatform.Application.Interfaces.IServices;
using FutureEducationalPlatform.Domain.Entities.UserEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutureEducationalPlatform.Application.CQRS.Handlers.AuthHandlers
{
    public class AuthBaseHandler
    {
        protected readonly IBaseService<User, GetUserDto, CreateUserDto, UpdateUserDto> _baseService;
        protected readonly IPasswordService _passwordService;

        public AuthBaseHandler(IBaseService<User, GetUserDto, CreateUserDto, UpdateUserDto> baseService, IPasswordService passwordService)
        {
            _baseService = baseService;
            _passwordService = passwordService;
        }
    }
}
