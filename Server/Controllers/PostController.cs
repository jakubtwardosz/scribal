using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace scribal.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        private static List<Post> Posts = new List<Post>
        {
            new Post
            {
                Title = "Title",
                Content = "Content"
            }
        };



        [HttpGet]
        public async Task<IActionResult> GetPosts()
        {
            var result = await Task.FromResult(Posts);
            return Ok(result);
        }
    }
}
