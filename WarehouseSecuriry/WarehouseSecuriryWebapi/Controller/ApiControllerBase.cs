using System.Security.Claims;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WarehouseSecuriryWebapi.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApiControllerBase : ControllerBase
    {
        public ClaimsIdentity identity
        {
            get{
                var iden = HttpContext.User.Identity as ClaimsIdentity;
                if (iden == null) throw new Exception("Invalid identity.");
                return iden;
            }
        }
    }
}
