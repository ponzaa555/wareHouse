using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace WarehouseSecuriryWebapi.Controller
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ApiControllerBase
    {
        private readonly IMediator _mediator;
        public LoginController(IMediator mediator)
        {
            _mediator = mediator; 
        }
        
        [HttpGet]
        [Route("version")]
        public IActionResult GetVersion(){
            return Ok("Version v1");
        }
    }
}
