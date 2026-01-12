using Microsoft.AspNetCore.Mvc;

namespace Prog2SocialMedia.Controllers
{
    [ApiController]
    [Route("api")]
    public class ApiController : ControllerBase
    {
        [HttpGet("hello")]
        public IActionResult HelloApi()
        {
            return Ok("Hello from the API!");
        }

        [HttpPost("hello")]
        public IActionResult HelloPost()
        {
            return Ok("Hello from the POST endpoint!");
        }
    }
}
