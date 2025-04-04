using Application.Features.Mediatr.Commands.StudentCommands.CreateStudent;
using Application.Features.Mediatr.Commands.StudentCommands.RemoveStudent;
using Application.Features.Mediatr.Commands.StudentCommands.UpdateStudent;
using Application.Features.Mediatr.Queries.StudentQueries.GetAllStudent;
using Application.Features.Mediatr.Queries.StudentQueries.GetByIdStudent;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public StudentsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetStudents()
        {
            
;           var response = await _mediator.Send(new GetAllStudentQueryRequest());
            return Ok(response);
        }

        [HttpGet("{Id}")]
        public async Task<IActionResult> GetStudentById([FromRoute] GetByIdStudentQueryRequest request)
        {
            GetByIdStudentQueryResponse response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> CreateStudent(CreateStudentCommandRequest request)
        {
            CreateStudentCommandResponse response = await _mediator.Send(request);
            return StatusCode((int)HttpStatusCode.Created);
        }

        [HttpDelete("{Id}")]
        public async Task<IActionResult> DeleteStudent([FromRoute] RemoveStudentCommandRequest request)
        {
            RemoveStudentCommandResponse response = await _mediator.Send(request);
            return Ok("Student Removed Succesfully");
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateStudent(string id, [FromBody] UpdateStudentCommandRequest request)
        {
            request.Id = id;
            UpdateStudentCommandResponse response = await _mediator.Send(request);
            return Ok("Student Updated Successfully");
        }
    }
}
