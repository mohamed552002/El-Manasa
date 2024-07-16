using AutoMapper;
using FutureEducationalPlatform.Application.DTOS.ComprehensiveExamDtos;
using FutureEducationalPlatform.Domain.Entities.ComprehensiveExamEntities;

namespace FutureEducationalPlatform.Application.Common.Profiles
{
    public class ComprehensiveExamProfile : Profile
    {
        public ComprehensiveExamProfile()
        {
            CreateMap<CreateComprehensiveExamDto, ComprehensiveExam>();
            CreateMap<UpdateComprehensiveExamDto, ComprehensiveExam>();
            CreateMap<ComprehensiveExam,GetComprehensiveExamDto>();
        }
    }
}
