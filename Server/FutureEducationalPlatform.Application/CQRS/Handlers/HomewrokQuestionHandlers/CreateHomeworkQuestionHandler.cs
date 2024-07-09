using FutureEducationalPlatform.Application.CQRS.Commands.HomeworkQuestionCommands;
using FutureEducationalPlatform.Application.DTOS.HomeworkQuestionDtos;
using FutureEducationalPlatform.Application.Interfaces.IServices;
using FutureEducationalPlatform.Domain.Entities.HomeworkEntites;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutureEducationalPlatform.Application.CQRS.Handlers.HomewrokQuestionHandlers
{
    public class CreateHomeworkQuestionHandler : BaseHomeworkQuestionHandler, IRequestHandler<CreateHomewrokQuestionRequest, string>
    {
        public CreateHomeworkQuestionHandler(IBaseService<HomeworkQuestion, GetHomeworkQuestionDto, CreateHomeworkQuestionDto, UpdateHomeworkQuestionDto> baseService) : base(baseService) { }

        public async Task<string> Handle(CreateHomewrokQuestionRequest request, CancellationToken cancellationToken)
        {
            await _baseService.CreateAsync(request.CreateHomeworkQuestionDto);
            return "تمت اضافة السؤال الي الواجب بنجاح";
        }
    }
}
