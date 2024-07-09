using AutoMapper;
using FutureEducationalPlatform.Application.DTOS.ExamQuestionDtos;
using FutureEducationalPlatform.Domain.Entities.ExamEntities;

namespace FutureEducationalPlatform.Application.Common.Profiles
{
    public class ExamQuestionProfile:Profile
    {
        public ExamQuestionProfile()
        {
            CreateMap<CreateExamQuestionDto, ExamQuestion>();
            CreateMap<UpdateExamQuestionDto, ExamQuestion>();
            CreateMap<ExamQuestion,GetExamQuestionDto>();
        }
    }
}
