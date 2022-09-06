using InformMedia.Models;
using InformMedia.Service.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace InformMedia.WebApi.Controllers
{
    [ApiVersion("1.0")]
    [Route("v{version:apiVersion}/posts")]
    public class PostsController : BaseController
    {
        private readonly IPostsService mapper;
        private readonly IPostsService postsService;

        public PostsController(IPostsService mapper, IPostsService postsService)
        {
            this.mapper = mapper;
            this.postsService = postsService;
        }

        [HttpPost]
        public IEnumerable<Int32> Create(PostCreate post)
        {
            postsService.CreateAsync(post);

            return Enumerable.Range(1, 5).Select(index => index).ToArray();
        }
    }
}
