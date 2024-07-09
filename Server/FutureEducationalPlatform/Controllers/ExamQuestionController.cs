using FutureEducationalPlatform.Application.DTOS.ExamQuestionDtos;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace FutureEducationalPlatform.Controllers
{
    public class ExamQuestionController : BaseController
    {
        public ExamQuestionController(IMediator mediator) : base(mediator) { }
        [HttpPost("CreateExamQuestion")]
        public async Task<IActionResult> CreateExamQuestionAsync(CreateExamQuestionDto createExamQuestionDto)=>
            Ok(await _mediator.Send(new CreateExamQuestionRequest(createExamQuestionDto))); 
        [HttpPut("UpdateExamQuestion")]
        public async Task<IActionResult> UpdateExamQuestionAsync(Guid id,UpdateExamQuestionDto updateExamQuestionDto)=>
            Ok(await _mediator.Send(new UpdateExamQuestionRequest(id,updateExamQuestionDto))); 
        [HttpDelete("DeleteExamQuestion")]
        public async Task<IActionResult> DeleteExamQuestionAsync(Guid id)=>
            Ok(await _mediator.Send(new DeleteExamQuestionRequest(id)));
    }
}
