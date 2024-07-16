using FutureEducationalPlatform.Application.CQRS.Commands.CenterCommands;
using FutureEducationalPlatform.Application.CQRS.Queries.ComprehensiveExamQueries;
using FutureEducationalPlatform.Application.DTOS.ComprehensiveExamDtos;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace FutureEducationalPlatform.Controllers
{
    public class ComprehensiveExamController : BaseController
    {
        public ComprehensiveExamController(IMediator mediator) : base(mediator)
        {
        }
        [HttpPost]
        public async Task<IActionResult> CreateComprehensiveExamAsync(CreateComprehensiveExamDto createComprehensiveExamDto)
        {
            var result = await _mediator.Send(new CreateComprehensiveExamRequest(createComprehensiveExamDto));
            return Ok(result);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetComprehensiveExamByIdAsync(Guid id)
        {
            var result = await _mediator.Send(new GetComprehensiveExamByIdRequest(id));
            return Ok(result);
        }
        [HttpGet]
        public async Task<IActionResult> GetComprehensiveExamsAsync()
        {
            var result = await _mediator.Send(new GetComprehensiveExamsRequest());
            return Ok(result);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateComprehensiveExamAsync(Guid id, UpdateComprehensiveExamDto updateComprehensiveExamDto)
        {
            var result = await _mediator.Send(new UpdateComprehensiveExamRequest(id, updateComprehensiveExamDto));
            return Ok(result);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCourseAsync(Guid id)
        {
            var result = await _mediator.Send(new DeleteComprehensiveExamRequest(id));
            return Ok(result);
        }

    }
}
