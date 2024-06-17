using FutureEducationalPlatform.Application.CQRS.Commands.CenterCommands;
using FutureEducationalPlatform.Application.DTOS.CenterDtos;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace FutureEducationalPlatform.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CenterController : BaseController
    {
        public CenterController(IMediator mediator) : base(mediator) { }


        [HttpPut("UpdateCenter")]
        public async Task<IActionResult> UpdateCenterAsync(Guid id, UpdateCenterDto updateCenterDto)=>
            Ok(await _mediator.Send(new UpdateCenterRequest(id,updateCenterDto)));

        [HttpDelete("DeleteCenter")]
        public async Task<IActionResult> DeleteCenterAsync(Guid id) => 
            Ok(await _mediator.Send(new DeleteCenterRequest(id)));

    }
}
