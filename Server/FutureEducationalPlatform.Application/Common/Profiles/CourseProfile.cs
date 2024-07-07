using AutoMapper;
using FutureEducationalPlatform.Application.DTOS.CourseDtos;
using FutureEducationalPlatform.Domain.Entities.CourseEntites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutureEducationalPlatform.Application.Common.Profiles
{
    public class CourseProfile : Profile
    {
        public CourseProfile()
        {
            CreateMap<AddCourseDto, Course>();
            CreateMap<Course, GetCourseDto>();
            CreateMap<UpdateCourseDto,Course>();
        }
    }
}
