using Application.Features.Mediatr.Commands.ClassroomCommands.CreateClassroom;
using Application.Features.Mediatr.Commands.ClassroomCommands.RemoveClassroom;
using Application.Features.Mediatr.Commands.ClassroomCommands.UpdateClassroom;
using Application.Features.Mediatr.Queries.ClassroomQueries.GetAllClassroom;
using Application.Features.Mediatr.Queries.ClassroomQueries.GetByIdClassroom;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClassroomsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ClassroomsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetClassrooms()
        {

            ; var response = await _mediator.Send(new GetAllClassroomQueryRequest());
            return Ok(response);
        }

        [HttpGet("{Id}")]
        public async Task<IActionResult> GetClassroomById([FromRoute] GetByIdClassroomQueryRequest request)
        {
            GetByIdClassroomQueryResponse response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> CreateClassroom(CreateClassroomCommandRequest request)
        {
            CreateClassroomCommandResponse response = await _mediator.Send(request);
            return StatusCode((int)HttpStatusCode.Created);
        }

        [HttpDelete("{Id}")]
        public async Task<IActionResult> DeleteClassroom([FromRoute] RemoveClassroomCommandRequest request)
        {
            RemoveClassroomCommandResponse response = await _mediator.Send(request);
            return Ok("Classroom Removed Succesfully");
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateClassroom(string id ,[FromBody] UpdateClassroomCommandRequest request)
        {
            request.Id = id;    
            UpdateClassroomCommandResponse response = await _mediator.Send(request);
            return Ok("Classroom Updated Successfully");
        }
    }
}

