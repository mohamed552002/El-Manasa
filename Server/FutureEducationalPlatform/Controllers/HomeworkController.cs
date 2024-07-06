using FutureEducationalPlatform.Application.CQRS.Commands.HomeworkCommands;
using FutureEducationalPlatform.Application.CQRS.Queries.HomeworkQueries;
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
        [HttpPost]
        public async Task<IActionResult> CreateHomework([FromBody] CreateHomeworkDto createHomeworkDto)
        {
            var result = await _mediator.Send(new CreateHomeworkRequest(createHomeworkDto));
            return Ok(result);
        }
        [HttpGet]
        public async Task<IActionResult> GetAllHomework()
        {
            var result = await _mediator.Send(new GetAllHomeworkRequest());
            return Ok(result);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetHomeworkById(Guid id)
        {
            var result = await _mediator.Send(new GetHomeworkByIdRequest(id));
            return Ok(result);
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteHomework(Guid id)
        {
            var result = await _mediator.Send(new DeleteHomeworkRequest(id));
            return Ok(result);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateHomework(Guid id,UpdateHomeworkDto updateHomeworkDto)
        {
            var result = await _mediator.Send(new UpdateHomeworkRequest(id,updateHomeworkDto));
            return Ok(result);
        }
    }
}
