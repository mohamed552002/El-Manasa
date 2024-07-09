using AutoMapper;
using FutureEducationalPlatform.Application.DTOS.ComprehensiveExamDtos;
using FutureEducationalPlatform.Domain.Entities.ComprehensiveExamEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
