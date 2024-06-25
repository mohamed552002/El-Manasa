using AutoMapper;
using FutureEducationalPlatform.Application.DTOS.CenterCourseTimeDtos;
using FutureEducationalPlatform.Domain.Entities.CenterEntites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutureEducationalPlatform.Application.Common.Profiles
{
    public class CenterCourseTimeProfile : Profile
    {
        public CenterCourseTimeProfile()
        {
            CreateMap<AddCenterCourseTimeDto, CenterCourseTime>();
            CreateMap<UpdateCenterCourseTimeDto, CenterCourseTime>();
            CreateMap<CenterCourseTime, GetCenterCourseTimeDto>();
        }
    }
}
