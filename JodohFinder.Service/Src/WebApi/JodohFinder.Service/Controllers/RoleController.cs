using JodohFinder.Role.UseCase;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace JodohFinder.Service.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RoleController : Controller
    {
        private readonly IRoleBS _roleBS;
        private readonly IMediator _Mediator;

        public RoleController(IMediator mediator, IRoleBS roleBS)
        {
            _Mediator = mediator;
            _roleBS = roleBS;
        }

        [HttpGet]
        [ProducesResponseType(typeof(List<RoleDTO>), 200)]
        [ProducesResponseType(typeof(object), 400)]
        public async Task<ActionResult<List<RoleDTO>>> GetRoles([FromQuery] GetRolesQuery query)
        {
            var result = await _Mediator.Send(query);
            return StatusCode((int)HttpStatusCode.OK, result);
        }
    }
}
