using FutureEducationalPlatform.Application.CQRS.Commands.CenterCourseTimeCommands;
using FutureEducationalPlatform.Application.DTOS.CenterCourseTimeDtos;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace FutureEducationalPlatform.Controllers
{
    public class CenterCourseTimeController : BaseController
    {
        public CenterCourseTimeController(IMediator mediator) : base(mediator) { }
        [HttpPost]
        public async Task<IActionResult> AddCenterCourseTime(AddCenterCourseTimeDto centerCourseTimeDto)
        {
            var result = await _mediator.Send(new CreateCenterCourseTimeRequest(centerCourseTimeDto));
            return Ok(result);
        }
        [HttpPut("UpdateCenterCourseTime")]
        public async Task<IActionResult> UpdateCenterCourseTimeAsync(Guid id, UpdateCenterCourseTimeDto updateCenterCourseTime) =>
             Ok(await _mediator.Send(new UpdateCenterCourseTimeRequest(id, updateCenterCourseTime)));
        [HttpDelete]
        public async Task<IActionResult> DeleteCenterCourseTime(Guid id)
        {
            var result = await _mediator.Send(new DeleteCenterCourseTimeRequest(id));
            return Ok(result);
        }
    }
}
