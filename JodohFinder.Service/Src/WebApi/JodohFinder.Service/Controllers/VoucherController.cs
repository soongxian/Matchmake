using JodohFinder.Voucher.UseCase;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace JodohFinder.Service.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class VoucherController : Controller
    {
        private readonly IMediator _Mediator;

        public VoucherController(IMediator mediator)
        {
            _Mediator = mediator;
        }

        [HttpGet]
        [ProducesResponseType(typeof(List<VoucherDTO>), 200)]
        [ProducesResponseType(typeof(object), 400)]
        public async Task<ActionResult<List<VoucherDTO>>> GetVoucher([FromQuery] GetVoucherQuery query)
        {
            var result = await _Mediator.Send(query);
            return StatusCode((int)HttpStatusCode.OK, result);
        }

        [HttpPost]
        public async Task<ActionResult<List<VoucherDTO>>> CreateVoucher([FromBody] AddVoucherCommand command, CancellationToken cancellationToken)
        {
            var result = await _Mediator.Send(command, cancellationToken);
            return Ok(result);
        }

        [HttpDelete]
        public async Task<ActionResult<List<VoucherDTO>>> DeleteVoucher([FromBody] DeleteVoucherCommand command, CancellationToken cancellationToken)
        {
            var result = await _Mediator.Send(command, cancellationToken);
            return Ok(result);
        }
    }
}
