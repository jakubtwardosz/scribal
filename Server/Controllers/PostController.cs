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
                Id = 1,
                Title = "Title",
                Content = "Expedita non rem delectus cumque ab architecto repellendus voluptas. Consequatur eos similique dicta. Ea iure vitae non quos. Cumque magni ullam sint optio sit molestias. Quo quis consequatur recusandae praesentium debitis harum beatae. Doloribus nisi error consectetur aut eveniet tempora omnis nihil.",
            },
            new Post
            {
                Id = 2,
                Title = "Title",
                Content = "Expedita non rem delectus cumque ab architecto repellendus voluptas. Consequatur eos similique dicta. Ea iure vitae non quos. Cumque magni ullam sint optio sit molestias. Quo quis consequatur recusandae praesentium debitis harum beatae. Doloribus nisi error consectetur aut eveniet tempora omnis nihil.",
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
