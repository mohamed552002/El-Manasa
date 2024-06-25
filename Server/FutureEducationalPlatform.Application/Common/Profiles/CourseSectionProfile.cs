using AutoMapper;
using FutureEducationalPlatform.Application.DTOS.CourseDtos;
using FutureEducationalPlatform.Application.DTOS.CourseSectionDtos;
using FutureEducationalPlatform.Domain.Entities.CourseEntites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutureEducationalPlatform.Application.Common.Profiles
{
    public class CourseSectionProfile:Profile
    {
        public CourseSectionProfile()
        {
            CreateMap<CreateCourseSectionDto, CourseSection>();
            CreateMap<CourseSection, GetCourseSectionDto>();
            CreateMap<UpdateCourseSectionDto, CourseSection>();
        }
    }
}
