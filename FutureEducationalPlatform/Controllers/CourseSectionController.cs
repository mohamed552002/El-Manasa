using FutureEducationalPlatform.Application.DTOS.CourseSectionDtos;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace FutureEducationalPlatform.Controllers
{
    public class CourseSectionController : BaseController
    {
        public CourseSectionController(IMediator mediator) : base(mediator) { }

        [HttpGet("GetCoursesSections")]
        public async Task<IActionResult> GetCoursesSectionsAsync() =>
            Ok(await _mediator.Send(new GetCoursesSectionsRequest()));
        [HttpGet("GetCourseSectionById")]
        public async Task<IActionResult> GetCourseSectionByIdAsync(Guid id) =>
            Ok(await _mediator.Send(new GetCourseSectionByIdRequest(id)));
        [HttpPost("CreateCourseSection")]
        public async Task<IActionResult> CreateCourseSectionAsync(CreateCourseSectionDto createCourseSectionDto)=>
            Ok(await _mediator.Send(new CreateCourseSectionRequest(createCourseSectionDto)));
        [HttpPut("UpdateCourseSection")]
        public async Task<IActionResult> UpdateCourseSectionAsync(Guid id,UpdateCourseSectionDto updateCourseSectionDto) =>
            Ok(await _mediator.Send(new UpdateCourseSectionRequest(id,updateCourseSectionDto)));
        [HttpDelete("DeleteCourseSection")]
        public async Task<IActionResult> DeleteCourseSectionAsync(Guid id) =>
           Ok(await _mediator.Send(new DeleteCourseSectionRequest(id)));
    }
}
