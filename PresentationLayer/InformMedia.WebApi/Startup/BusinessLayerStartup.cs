using InformMedia.Service.Contracts;
using InformMedia.Service.Implementation;

namespace InformMedia.WebApi.Startup
{
    public static class BusinessLayerStartup
    {
        public static void RegisterServices(WebApplicationBuilder builder)
        {
            builder.Services.AddScoped<IPostsService, PostsService>();
        }
    }
}
