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
        public async Task<ActionResult<List<RoleDTO>>> GetAllRoles()
        {
            var roles = await _roleBS.GetAllAsync();
            return StatusCode((int)HttpStatusCode.OK, roles);
        }
    }
}
