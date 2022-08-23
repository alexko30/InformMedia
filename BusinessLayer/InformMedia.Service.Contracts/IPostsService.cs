using InformMedia.Models;

namespace InformMedia.Service.Contracts
{
    public interface IPostsService
    {
        Task CreateAsync(PostCreate post);

        Task<PostGet> GetAsync(Guid id);

        Task Update(PostUpdate post);

        Task DeleteAsync(Guid id);
    }
}
