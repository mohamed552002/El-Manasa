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
    public class UpdateHomeworkQuestionHandler : BaseHomeworkQuestionHandler, IRequestHandler<UpdateHomeworkQuestionRequest, string>
    {
        public UpdateHomeworkQuestionHandler(IBaseService<HomeworkQuestion, GetHomeworkQuestionDto, CreateHomeworkQuestionDto, UpdateHomeworkQuestionDto> baseService) : base(baseService)
        {
        }

        public async Task<string> Handle(UpdateHomeworkQuestionRequest request, CancellationToken cancellationToken)
        {
            await _baseService.Update(request.Id, request.UpdateHomeworkQuestionDto);
            return "تم تعديل ربط السؤال بالواجب بنجاح";
        }
    }
}
