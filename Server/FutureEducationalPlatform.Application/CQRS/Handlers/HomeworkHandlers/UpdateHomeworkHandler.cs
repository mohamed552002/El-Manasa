using FutureEducationalPlatform.Application.CQRS.Commands.HomeworkCommands;
using FutureEducationalPlatform.Application.DTOS.HomeworkDtos;
using FutureEducationalPlatform.Application.Interfaces.IServices;
using FutureEducationalPlatform.Domain.Entities.HomeworkEntites;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutureEducationalPlatform.Application.CQRS.Handlers.HomeworkHandlers
{
    public class UpdateHomeworkHandler : BaseHomeworkHandler, IRequestHandler<UpdateHomeworkRequest, string>
    {
        public UpdateHomeworkHandler(IBaseService<Homework, GetHomeworkDto, CreateHomeworkDto, UpdateHomeworkDto> baseService) : base(baseService)
        {
        }

        public async Task<string> Handle(UpdateHomeworkRequest request, CancellationToken cancellationToken)
        {
            await _baseService.Update(request.Id, request.UpdateHomeworkDto);
            return "تم تحديث الواجب بنجاح";
        }
    }
}
