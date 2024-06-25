using FutureEducationalPlatform.Application.CQRS.Commands.CenterCommands;
using FutureEducationalPlatform.Application.DTOS.CenterDtos;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace FutureEducationalPlatform.Controllers
{
    public class CenterController : BaseController
    {
        public CenterController(IMediator mediator) : base(mediator) { }

        [HttpGet("GetCenters")]
        public async Task<IActionResult> GetCentersAsync() =>
           Ok(await _mediator.Send(new GetCentersRequest()));

        [HttpGet("GetCenterById")]
        public async Task<IActionResult> GetCenterByIdAsync(Guid id) =>
           Ok(await _mediator.Send(new GetCenterByIdRequest(id)));

        [HttpPost("CreateCenter")]
        public async Task<IActionResult> CreateCenterAsync(CreateCenterDto createCenterDto) =>
            Ok(await _mediator.Send(new CreateCenterRequest(createCenterDto)));

        [HttpPut("UpdateCenter")]
        public async Task<IActionResult> UpdateCenterAsync(Guid id, UpdateCenterDto updateCenterDto)=>
            Ok(await _mediator.Send(new UpdateCenterRequest(id,updateCenterDto)));

        [HttpDelete("DeleteCenter")]
        public async Task<IActionResult> DeleteCenterAsync(Guid id) => 
            Ok(await _mediator.Send(new DeleteCenterRequest(id)));

    }
}
