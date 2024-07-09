using FutureEducationalPlatform.Application.CQRS.Commands.HomeworkQuestionCommands;
using FutureEducationalPlatform.Application.DTOS.HomeworkQuestionDtos;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace FutureEducationalPlatform.Controllers
{
    public class HomeworkQuestionController : BaseController
    {
        public HomeworkQuestionController(IMediator mediator) : base(mediator)
        {
        }
        [HttpPost]
        public async Task<IActionResult> CreateHomeworkQuestion(CreateHomeworkQuestionDto createHomeworkQuestionDto)
        {
            var command = new CreateHomewrokQuestionRequest(createHomeworkQuestionDto);
            var result = await _mediator.Send(command);
            return Ok(result);
        }
        [HttpPut("{Id}")]
        public async Task<IActionResult> UpdateHomeworkQuestion(Guid Id,UpdateHomeworkQuestionDto updateHomeworkQuestionDto)
        {
            var command = new UpdateHomeworkQuestionRequest(Id,updateHomeworkQuestionDto);
            var result = await _mediator.Send(command);
            return Ok(result);
        }
        [HttpDelete("Id")]
        public async Task<IActionResult> CreateHomeworkQuestion(Guid Id)
        {
            var command = new DeleteHomeworkQuestionRequest(Id);
            var result = await _mediator.Send(command);
            return Ok(result);
        }
    }
}
