using AutoMapper;
using FutureEducationalPlatform.Application.DTOS.CenterDtos;
using FutureEducationalPlatform.Domain.Entities.CenterEntites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
