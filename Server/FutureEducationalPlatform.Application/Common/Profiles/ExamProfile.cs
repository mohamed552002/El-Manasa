﻿using AutoMapper;
using FutureEducationalPlatform.Application.DTOS.ExamDtos;
using FutureEducationalPlatform.Domain.Entities.ExamEntities;

namespace FutureEducationalPlatform.Application.Common.Profiles
{
    public class ExamProfile:Profile
    {
        public ExamProfile()
        {
            CreateMap<CreateExamDto, Exam>();
            CreateMap<Exam, GetExamDto>();
            CreateMap<UpdateExamDto,Exam>();
        }
    }
}
