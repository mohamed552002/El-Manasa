using FutureEducationalPlatform.Application.DTOS.StudentQuestionAnswerDtos;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace FutureEducationalPlatform.Controllers
{
    public class StudentQuestionAnswerController : BaseController
    {
        public StudentQuestionAnswerController(IMediator mediator) : base(mediator) { }
        [HttpPost("CreateStudentQuestionAnswer")]
        public async Task<IActionResult> CreateStudentQuestionAnswerAsync(CreateStudentQuestionAnswerDto createStudentQuestionAnswerDto) =>
            Ok(await _mediator.Send(new CreateStudentQuestionAnswerRequest(createStudentQuestionAnswerDto)));
        [HttpPut("UpdateStudentQuestionAnswer")]
        public async Task<IActionResult> UpdateStudentQuestionAnswerAsync(Guid id,UpdateStudentQuestionAnswerDto updateStudentQuestionAnswerDto) =>
            Ok(await _mediator.Send(new UpdateStudentQuestionAnswerRequest(id,updateStudentQuestionAnswerDto)));
        [HttpDelete("DeleteStudentQuestionAnswer")]
        public async Task<IActionResult> DeleteStudentQuestionAnswerAsync(Guid id) =>
          Ok(await _mediator.Send(new DeleteStudentQuestionAnswerRequest(id)));
    }
}
