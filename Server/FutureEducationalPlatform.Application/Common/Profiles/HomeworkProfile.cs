using AutoMapper;
using FutureEducationalPlatform.Application.DTOS.HomeworkDtos;
using FutureEducationalPlatform.Domain.Entities.HomeworkEntites;

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
