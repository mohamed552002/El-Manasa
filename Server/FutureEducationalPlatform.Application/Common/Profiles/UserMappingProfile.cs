using AutoMapper;
using FutureEducationalPlatform.Application.DTOS.UserDtos;
using FutureEducationalPlatform.Domain.Entities.UserEntities;

namespace FutureEducationalPlatform.Application.Common.Profiles
{
    public class UserMappingProfile : Profile
    {
        public UserMappingProfile()
        {
            CreateMap<CreateUserDto, User>();
        }
    }
}
