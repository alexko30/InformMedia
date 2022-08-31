using InformMedia.Models;
using InformMedia.Service.Contracts;
using System.Web.Http;

namespace InformMedia.WebApi.Controllers
{
    public class PostsController : BaseController
    {
        private readonly String mapper;
        private readonly IPostsService postsService;

        public PostsController(String mapper, IPostsService postsService)
        {
            this.mapper = mapper;
            this.postsService = postsService;
        }

        public async Task<IHttpActionResult> Create(PostCreate post)
        {
            await postsService.CreateAsync(post);

            return Ok();
        }
    }
}
