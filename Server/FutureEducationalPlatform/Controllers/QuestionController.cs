using FutureEducationalPlatform.Application.CQRS.Commands.QuestionCommands;
using FutureEducationalPlatform.Application.CQRS.Queries.QuestionQueries;
using FutureEducationalPlatform.Application.DTOS.QuestionDtos;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace FutureEducationalPlatform.Controllers
{
    public class QuestionController : BaseController
    {
        public QuestionController(IMediator mediator) : base(mediator)
        {
        }
        [HttpGet]
        public async Task<IActionResult> GetQuestions() =>
            Ok(await _mediator.Send(new GetAllQuestionsRequest()));

        [HttpGet("{Id}")]
        public async Task<IActionResult> GetById(Guid Id) =>
            Ok(await _mediator.Send(new GetQuestionByIdRequest(Id)));

        [HttpPost]
        public async Task<IActionResult> CreateQuestion(CreateQuestionDto createQuestionDto)
        {
            var result = await _mediator.Send(new CreateQuestionRequest(createQuestionDto));
            return Ok(result);
        }
        [HttpPut]
        public async Task<IActionResult> UpdateQuestion(Guid id, UpdateQuestionDto updateQuestionDto)
        {
            var result = await _mediator.Send(new UpdateQuestionRequest(id, updateQuestionDto));
            return Ok(result);
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteQuestion(Guid id)
        {
            var result = await _mediator.Send(new DeleteQuestionRequest(id));
            return Ok(result);
        }
    }
}
