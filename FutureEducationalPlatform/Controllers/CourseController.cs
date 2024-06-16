using FutureEducationalPlatform.Application.CQRS.Commands.CourseCommands;
using FutureEducationalPlatform.Application.CQRS.Queries.CourseQueries;
using FutureEducationalPlatform.Application.DTOS.CourseDtos;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FutureEducationalPlatform.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
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
    }
}
