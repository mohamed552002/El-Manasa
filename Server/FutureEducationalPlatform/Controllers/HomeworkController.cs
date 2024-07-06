using FutureEducationalPlatform.Application.DTOS.HomeworkDtos;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FutureEducationalPlatform.Controllers
{
    public class HomeworkController : BaseController
    {
        public HomeworkController(IMediator mediator) : base(mediator)
        {
        }
        public async Task<IActionResult> CreateHomework(CreateHomeworkDto createHomeworkDto)
        {
            return Ok();
        }
    }
}
