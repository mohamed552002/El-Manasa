using FutureEducationalPlatform.Application.CQRS.Commands.QuestionCommands;
using FutureEducationalPlatform.Application.DTOS.QuestionDtos;
using FutureEducationalPlatform.Application.Interfaces.IServices;
using FutureEducationalPlatform.Domain.Entities.QuestionEntites;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutureEducationalPlatform.Application.CQRS.Handlers.QuestionHandlers
{
    public class CreateQuestionHandler : BaseQuestionHandler, IRequestHandler<CreateQuestionRequest, string>
    {
        public CreateQuestionHandler(IBaseService<Question, GetQuestionDto, CreateQuestionDto, UpdateQuestionDto> baseService) : base(baseService)
        {
        }

        public async Task<string> Handle(CreateQuestionRequest request, CancellationToken cancellationToken)
        {
            await _baseService.CreateAsync(request.CreateQuestionDto);
            return "تمت اضافة السؤال بنجاح";
        }
    }
}
