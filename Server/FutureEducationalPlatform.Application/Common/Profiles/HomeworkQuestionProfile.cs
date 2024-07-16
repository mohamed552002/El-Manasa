using AutoMapper;
using FutureEducationalPlatform.Application.DTOS.HomeworkQuestionDtos;
using FutureEducationalPlatform.Domain.Entities.HomeworkEntites;

namespace FutureEducationalPlatform.Application.Common.Profiles
{
    public class HomeworkQuestionProfile : Profile
    {
        public HomeworkQuestionProfile()
        {
            CreateMap<CreateHomeworkQuestionDto, HomeworkQuestion>();
            CreateMap<UpdateHomeworkQuestionDto, HomeworkQuestion>();
            CreateMap<HomeworkQuestion, GetHomeworkQuestionDto>();
        }
    }
}
