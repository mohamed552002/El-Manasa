using FutureEducationalPlatform.Application.DTOS.ExamDtos;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace FutureEducationalPlatform.Controllers
{
    public class ExamController : BaseController
    {
        public ExamController(IMediator mediator) : base(mediator) { }
        [HttpGet("GetExams")]
        public async Task<IActionResult> GetExamsAsync() =>
         Ok(await _mediator.Send(new GetAllExamsRequest()));

        [HttpGet("GetExamById")]
        public async Task<IActionResult> GetExamByIdAsync(Guid id) =>
         Ok(await _mediator.Send(new GetExamByIdRequest(id)));

        [HttpPost("CreateExam")]
        public async Task<IActionResult> CreateExamAsync(CreateExamDto createExamDto)=>
           Ok(await _mediator.Send(new CreateExamRequest(createExamDto)));

        [HttpPut("UpdateExam")]
        public async Task<IActionResult> UpdateExamAsync(Guid id,UpdateExamDto updateExamDto) =>
           Ok(await _mediator.Send(new UpdateExamRequest(id,updateExamDto)));

        [HttpDelete("DeleteExam")]
        public async Task<IActionResult> DeleteExamAsync(Guid id) =>
           Ok(await _mediator.Send(new DeleteExamRequest(id)));
    }
}
