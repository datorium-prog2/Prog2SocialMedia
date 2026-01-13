using Microsoft.AspNetCore.Mvc;
using Prog2SocialMedia.Models;
using Prog2SocialMedia.Data;

namespace Prog2SocialMedia.Controllers
{
    [ApiController]
    [Route("api/posts")]
    public class PostsController : ControllerBase
    {
        private readonly AppDbContext _db;

        // šeit notiek AppDbContext injekcija
        public PostsController(AppDbContext dbContext)
        {
            _db = dbContext;
        }

        [HttpGet]
        public IActionResult GetPosts()
        {
            List<Post> allPosts = _db.Posts.ToList();
            return Ok(allPosts);
        }
    }
}
