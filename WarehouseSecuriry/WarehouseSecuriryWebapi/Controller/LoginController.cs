using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace WarehouseSecuriryWebapi.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ApiControllerBase
    {
        [HttpGet]
        [Route("version")]
        public IActionResult GetVersion(){
            return Ok("Version v1");
        }
    }
}
