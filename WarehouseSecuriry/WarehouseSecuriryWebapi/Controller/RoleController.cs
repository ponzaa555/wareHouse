using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WarehouseSecuriryWebapi.Controller
{
    // [Route("api/[controller]")]
    // [ApiController]
    public class RoleController : ApiControllerBase
    {
        [HttpGet]
        public IActionResult GetRole(){
            return Ok("Manager");
        }
    }
}
