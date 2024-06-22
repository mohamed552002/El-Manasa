using FutureEducationalPlatform.Application.DTOS.CenterDtos;
using FutureEducationalPlatform.Application.Interfaces.IServices;
using FutureEducationalPlatform.Domain.Entities.CenterEntites;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace FutureEducationalPlatform.Application.CQRS.Handlers.CenterHandlers
{
    public class DeleteCenterHandler : BaseCenterHandler, IRequestHandler<DeleteCenterRequest, string>
    {
        public DeleteCenterHandler(IBaseService<Center, GetCenterDto, CreateCenterDto, UpdateCenterDto> baseService) : base(baseService)
        {
        }

        public async Task<string> Handle(DeleteCenterRequest request, CancellationToken cancellationToken)
        {
            var center=await _baseService.GetByPropertyAsyncWithoutMap(c=>c.Id==request.Id,c=>c.Include(c=>c.Courses));
            foreach(var course in center.Courses) 
                course.IsDeleted = true;
            await _baseService.Delete(center);
            return "تم حذف السنتر بنجاح";
        }
    }
}
