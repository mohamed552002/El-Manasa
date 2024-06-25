using FutureEducationalPlatform.Application.DTOS.CourseDtos;
using FutureEducationalPlatform.Application.Interfaces.IServices;
using FutureEducationalPlatform.Domain.Entities.CourseEntites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutureEducationalPlatform.Application.CQRS.Handlers.CourseHandlers
{
    public class BaseCourseHandler
    {
        public readonly IBaseService<Course, GetCourseDto, AddCourseDto, UpdateCourseDto> _baseService;

        public BaseCourseHandler(IBaseService<Course, GetCourseDto, AddCourseDto, UpdateCourseDto> baseService)
        {
            _baseService = baseService;
        }
    }
}
