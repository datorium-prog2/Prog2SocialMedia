using Microsoft.AspNetCore.Mvc;

namespace Prog2SocialMedia.Controllers
{
    [ApiController]
    [Route("api/posts")]
    public class PostsController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetPosts()
        {
            return Ok("POSTS");
        }
    }
}
