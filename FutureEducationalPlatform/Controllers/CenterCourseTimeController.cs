using FutureEducationalPlatform.Application.DTOS.CenterCourseTimeDtos;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FutureEducationalPlatform.Controllers
{
    public class CenterCourseTimeController : BaseController
    {
        public CenterCourseTimeController(IMediator mediator) : base(mediator) { }
        [HttpPut("UpdateCenterCourseTime")]
        public async Task<IActionResult> UpdateCenterCourseTimeAsync(Guid id, UpdateCenterCourseTimeDto updateCenterCourseTime) =>
             Ok(await _mediator.Send(new UpdateCenterCourseTimeRequest(id, updateCenterCourseTime)));
    }
}
