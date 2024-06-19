using FutureEducationalPlatform.Application.DTOS.CenterCourseTimeDtos;
using FutureEducationalPlatform.Application.Interfaces.IServices;
using FutureEducationalPlatform.Domain.Entities.CenterEntites;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutureEducationalPlatform.Application.CQRS.Handlers.CenterCourseTimeHandlers
{
    public class BaseCenterCourseTimeHandler
    {
        protected readonly IBaseService<CenterCourseTime,GetCenterCourseTimeDto,AddCenterCourseTimeDto,UpdateCenterCourseTimeDto> _baseService;

        public BaseCenterCourseTimeHandler(IBaseService<CenterCourseTime, GetCenterCourseTimeDto, AddCenterCourseTimeDto, UpdateCenterCourseTimeDto> baseService)
        {
            _baseService = baseService;
        }
    }
}
