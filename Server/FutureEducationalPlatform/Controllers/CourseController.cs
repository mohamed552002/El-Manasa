using FutureEducationalPlatform.Application.CQRS.Queries.CourseQueries;
using FutureEducationalPlatform.Application.DTOS.CourseDtos;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace FutureEducationalPlatform.Controllers
{
    public class CourseController : BaseController
    {
        public CourseController(IMediator mediator) : base(mediator) { }

        [HttpGet("GetCourses")]
        public async Task<IActionResult> GetCoursesAsync()
        {
            var result = await _mediator.Send(new GetCoursesRequest());
            return Ok(result);
        }
        [HttpGet("GetCourse/{id}")]
        public async Task<IActionResult> GetCourseByIdAsync(Guid id)
        {
            var result = await _mediator.Send(new GetCourseByIdRequest(id));
            return Ok(result);
        }
        [HttpPost("CreateCourse")]
        public async Task<IActionResult> CreateCourseAsync(CreateCourseDto createCourseDto)
        {
            var result = await _mediator.Send(new CreateCourseRequest(createCourseDto));
            return Ok(result);
        }
        [HttpPut("UpdateCourse/{id}")]
        public async Task<IActionResult> UpdateCourseAsync(Guid id,UpdateCourseDto updateCourseDto)
        {
            var result = await _mediator.Send(new UpdateCourseRequest(id,updateCourseDto));
            return Ok(result);
        }
        [HttpDelete("DeleteCourse/{id}")]
        public async Task<IActionResult> DeleteCourseAsync(Guid id)
        {
            var result = await _mediator.Send(new DeleteCourseRequest(id));
            return Ok(result);
        }
    }
}
