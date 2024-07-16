using FutureEducationalPlatform.Application.DTOS.ComprehensiveExamDtos;
using FutureEducationalPlatform.Application.DTOS.CourseDtos;
using FutureEducationalPlatform.Application.Interfaces.IServices;
using FutureEducationalPlatform.Domain.Entities.ComprehensiveExamEntities;
using FutureEducationalPlatform.Domain.Entities.CourseEntites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutureEducationalPlatform.Application.CQRS.Handlers.ComprehensiveExamHandlers
{
    public class BaseComprehensiveExamHandler
    {
        public readonly IBaseService<ComprehensiveExam, GetComprehensiveExamDto, CreateComprehensiveExamDto, UpdateComprehensiveExamDto> _baseService;

        public BaseComprehensiveExamHandler(IBaseService<ComprehensiveExam, GetComprehensiveExamDto, CreateComprehensiveExamDto, UpdateComprehensiveExamDto> baseService)
        {
            _baseService = baseService;
        }
    }
}
