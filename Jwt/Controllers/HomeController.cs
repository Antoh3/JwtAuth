using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        [Authorize]
        [HttpGet]
        public IActionResult Get()
        {
            string[] partners = { "This is a protected page" };

            return Ok(new { protectedpage = partners });
        }
    }
}
