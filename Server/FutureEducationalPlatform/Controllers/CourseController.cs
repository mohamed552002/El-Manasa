using FutureEducationalPlatform.Application.CQRS.Commands.CourseCommands;
using FutureEducationalPlatform.Application.CQRS.Queries.CourseQueries;
using FutureEducationalPlatform.Application.DTOS.CourseDtos;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FutureEducationalPlatform.Controllers
{
    public class CourseController : BaseController
    {
        public CourseController(IMediator mediator) : base(mediator)
        {
        }

        [HttpPost("AddCourse")]
        public async Task<IActionResult> AddCourse(AddCourseDto addCourseDto)
        {
            var result = await _mediator.Send(new AddCourseRequest(addCourseDto));
            return Ok(result);
        }
        [HttpGet("GetCourse/{id}")]
        public async Task<IActionResult> GetCourseById(Guid id)
        {
            var result = await _mediator.Send(new GetCourseByIdRequest(id));
            return Ok(result);
        }
        [HttpGet("GetCourses")]
        public async Task<IActionResult> GetCourses()
        {
            var result = await _mediator.Send(new GetCoursesRequest());
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
