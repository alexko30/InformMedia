using InformMedia.Repository.Contracts;
using InformMedia.Repository.Implementation.Repositories;

namespace InformMedia.WebApi.Startup
{
    public static class DataAccessLayerStartup
    {
        public static void RegisterServices(WebApplicationBuilder builder)
        {
            builder.Services.AddScoped<IPostsRepository, PostsRepository>();
        }
    }
}
