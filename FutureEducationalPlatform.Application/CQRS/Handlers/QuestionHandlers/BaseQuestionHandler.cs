using FutureEducationalPlatform.Application.DTOS.QuestionDtos;
using FutureEducationalPlatform.Application.Interfaces.IServices;
using FutureEducationalPlatform.Domain.Entities.QuestionEntites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutureEducationalPlatform.Application.CQRS.Handlers.QuestionHandlers
{
    public class BaseQuestionHandler
    {
        protected readonly IBaseService<Question,GetQuestionDto,CreateQuestionDto,UpdateQuestionDto> _baseService;
        public BaseQuestionHandler(IBaseService<Question, GetQuestionDto, CreateQuestionDto, UpdateQuestionDto> baseService)
        {
            _baseService = baseService;
        }
    }
}
