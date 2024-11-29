using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WarehouseSecurityApplication.Feature.Login.Command.CreateUser;
using WarehouseSecurityApplication.Feature.Login.Command.CreateUser.CreateUser;

namespace WarehouseSecuriryWebapi.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ApiControllerBase
    {
        private IMediator _mediator;
        public UserController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpPost]
        [Route("Create user")]
        public async Task<IActionResult> CreateUser([FromBody] CreateUserRequest request)
        {
            var command = new CreateUserCommand(request.Username,request.Password);
            var res =await _mediator.Send(command);
            return Ok(res);
        }
    }
}
