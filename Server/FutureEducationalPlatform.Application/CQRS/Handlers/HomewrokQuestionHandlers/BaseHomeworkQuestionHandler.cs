using FutureEducationalPlatform.Application.DTOS.HomeworkQuestionDtos;
using FutureEducationalPlatform.Application.Interfaces.IServices;
using FutureEducationalPlatform.Domain.Entities.HomeworkEntites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutureEducationalPlatform.Application.CQRS.Handlers.HomewrokQuestionHandlers
{
    public class BaseHomeworkQuestionHandler
    {
        protected readonly IBaseService<HomeworkQuestion, GetHomeworkQuestionDto, CreateHomeworkQuestionDto, UpdateHomeworkQuestionDto> _baseService;

        public BaseHomeworkQuestionHandler(IBaseService<HomeworkQuestion, GetHomeworkQuestionDto, CreateHomeworkQuestionDto, UpdateHomeworkQuestionDto> baseService)
        {
            _baseService = baseService;
        }
    }
}
