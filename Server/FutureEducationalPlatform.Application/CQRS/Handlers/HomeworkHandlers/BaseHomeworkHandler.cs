using FutureEducationalPlatform.Application.DTOS.HomeworkDtos;
using FutureEducationalPlatform.Application.Interfaces.IServices;
using FutureEducationalPlatform.Domain.Entities.HomeworkEntites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutureEducationalPlatform.Application.CQRS.Handlers.HomeworkHandlers
{
    public class BaseHomeworkHandler
    {
        protected readonly IBaseService<Homework,GetHomeworkDto,CreateHomeworkDto,UpdateHomeworkDto> _baseService;

        public BaseHomeworkHandler(IBaseService<Homework, GetHomeworkDto, CreateHomeworkDto, UpdateHomeworkDto> baseService)
        {
            _baseService = baseService;
        }
    }
}
