using FutureEducationalPlatform.Application.CQRS.Commands.CenterCourseTimeCommands;
using FutureEducationalPlatform.Application.DTOS.CenterCourseTimeDtos;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace FutureEducationalPlatform.Controllers
{
    public class CenterCourseTimeController : BaseController
    {
        public CenterCourseTimeController(IMediator mediator) : base(mediator) { }
        [HttpPost("CreateCenterCourseTime")]
        public async Task<IActionResult> CreateCenterCourseTimeAsync(CreateCenterCourseTimeDto createCenterCourseTimeDto)
        {
            var result = await _mediator.Send(new CreateCenterCourseTimeRequest(createCenterCourseTimeDto));
            return Ok(result);
        }
        [HttpPut("UpdateCenterCourseTime")]
        public async Task<IActionResult> UpdateCenterCourseTimeAsync(Guid id, UpdateCenterCourseTimeDto updateCenterCourseTime)
        {
            var result = await _mediator.Send(new UpdateCenterCourseTimeRequest(id, updateCenterCourseTime));
            return Ok(result);
        }
        [HttpDelete("DeleteCenterCourseTime")]
        public async Task<IActionResult> DeleteCenterCourseTimeAsync(Guid id)
        {
            var result = await _mediator.Send(new DeleteCenterCourseTimeRequest(id));
            return Ok(result);
        }
    }
}
