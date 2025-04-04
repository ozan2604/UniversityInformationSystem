using Application.Features.Mediatr.Commands.CourseCommands.CreateCourse;
using Application.Features.Mediatr.Commands.CourseCommands.RemoveCourse;
using Application.Features.Mediatr.Commands.CourseCommands.UpdateCourse;
using Application.Features.Mediatr.Queries.CourseQueries.GetAllCourse;
using Application.Features.Mediatr.Queries.CourseQueries.GetByIdCourse;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoursesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CoursesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetCourses()
        {

            var response = await _mediator.Send(new GetAllCourseQeryRequest());
            return Ok(response);
        }

        [HttpGet("{Id}")]
        public async Task<IActionResult> GetCourseById([FromRoute] GetByIdCourseQueryRequest request)
        {
            GetByIdCourseQueryResponse response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> CreateCourse(CreateCourseCommandRequest request)
        {
            CreateCourseCommandResponse response = await _mediator.Send(request);
            return StatusCode((int)HttpStatusCode.Created);
        }

        [HttpDelete("{Id}")]
        public async Task<IActionResult> DeleteCourse([FromRoute] RemoveCourseCommandRequest request)
        {
            RemoveCourseCommandResponse response = await _mediator.Send(request);
            return Ok("Course Removed Succesfully");
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCourse(string id,[FromBody] UpdateCourseCommandRequest request)
        {
            request.Id = id;
            UpdateCourseCommandResponse response = await _mediator.Send(request);
            return Ok("Course Updated Successfully");
        }
    }
}

