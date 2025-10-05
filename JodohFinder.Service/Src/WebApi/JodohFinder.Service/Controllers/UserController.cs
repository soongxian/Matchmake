using JodohFinder.User.UseCase;
using JodohFinder.User.UseCase.User.UpdateUser;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace JodohFinder.Service.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        private readonly IMediator _Mediator;

        public UserController(IMediator mediator)
        {
            _Mediator = mediator;
        }

        [HttpGet]
        [ProducesResponseType(typeof(List<UserDTO>), 200)]
        [ProducesResponseType(typeof(object), 400)]
        public async Task<ActionResult<List<UserDTO>>> GetUser([FromQuery] GetUserQuery query)
        {
            var result = await _Mediator.Send(query);
            return StatusCode((int)HttpStatusCode.OK, result);
        }

        [HttpPost]
        [ProducesResponseType(typeof(UserDTO), 201)]
        [ProducesResponseType(typeof(object), 400)]
        public async Task<ActionResult<UserDTO>> AddUser([FromBody] AddUserCommand command)
        {
            var result = await _Mediator.Send(command);
            return StatusCode((int)HttpStatusCode.Created, result);
        }

        [HttpPut("{userId:guid}")]
        [ProducesResponseType(typeof(UserDTO), 200)]
        [ProducesResponseType(typeof(object), 400)]
        public async Task<ActionResult<UserDTO>> UpdateUser(Guid userId, [FromBody] UpdateUserCommand command)
        {
            command.USER_ID = userId;
            var result = await _Mediator.Send(command);
            return StatusCode((int)HttpStatusCode.OK, result);
        }

        [HttpDelete("{userId:guid}")]
        [ProducesResponseType(typeof(UserDTO), 200)]
        [ProducesResponseType(typeof(object), 400)]
        public async Task<ActionResult<UserDTO>> DeleteUser(Guid userId)
        {
            var command = new DeleteUserCommand { USER_ID = userId };
            var result = await _Mediator.Send(command);
            return StatusCode((int)HttpStatusCode.OK, result);
        }
    }
}
