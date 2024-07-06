using AutoMapper;
using FutureEducationalPlatform.Application.DTOS.HomeworkDtos;
using FutureEducationalPlatform.Domain.Entities.HomeworkEntites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutureEducationalPlatform.Application.Common.Profiles
{
    public class HomeworkProfile : Profile
    {
        public HomeworkProfile()
        {
            CreateMap<CreateHomeworkDto,Homework>();
            CreateMap<UpdateHomeworkDto,Homework>();
            CreateMap<Homework,GetHomeworkDto>();
        }
    }
}
