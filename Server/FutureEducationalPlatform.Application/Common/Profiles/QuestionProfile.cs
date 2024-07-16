using AutoMapper;
using FutureEducationalPlatform.Application.DTOS.QuestionDtos;
using FutureEducationalPlatform.Domain.Entities.QuestionEntites;

namespace FutureEducationalPlatform.Application.Common.Profiles
{
    public class QuestionProfile : Profile
    {
        public QuestionProfile()
        {
            CreateMap<CreateQuestionDto, Question>();
            CreateMap<UpdateQuestionDto, Question>();
            CreateMap<Question, GetQuestionDto>();
        }
    }
}
