using AutoMapper;
using FutureEducationalPlatform.Application.DTOS.CenterDtos;
using FutureEducationalPlatform.Domain.Entities.CenterEntites;

namespace FutureEducationalPlatform.Application.Common.Profiles
{
    public class CenterProfile:Profile
    {
        public CenterProfile()
        {
            CreateMap<CreateCenterDto, Center>();
            CreateMap<UpdateCenterDto, Center>();
            CreateMap<Center, GetCenterDto>();
        }
    }
}
