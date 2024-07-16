using FutureEducationalPlatform.Application.CQRS.Commands.HomeworkCommands;
using FutureEducationalPlatform.Application.DTOS.HomeworkDtos;
using FutureEducationalPlatform.Application.Interfaces.IServices;
using FutureEducationalPlatform.Domain.Entities.HomeworkEntites;
using MediatR;

namespace FutureEducationalPlatform.Application.CQRS.Handlers.HomeworkHandlers
{
    public class CreateHomeworkHandler : BaseHomeworkHandler, IRequestHandler<CreateHomeworkRequest, string>
    {
        public CreateHomeworkHandler(IBaseService<Homework, GetHomeworkDto, CreateHomeworkDto, UpdateHomeworkDto> baseService) : base(baseService)
        {
        }

        public async Task<string> Handle(CreateHomeworkRequest request, CancellationToken cancellationToken)
        {
            await _baseService.CreateAsync(request.CreateHomeworkDto);
            return "تمت اضافة الواجب بنجاح";
        }
    }
}
