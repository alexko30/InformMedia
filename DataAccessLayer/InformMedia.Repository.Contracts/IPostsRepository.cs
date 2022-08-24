using InformMedia.Models;

namespace InformMedia.Repository.Contracts
{
    public interface IPostsRepository
    {
        Task CreateAsync(PostCreate post);

        Task<PostGet> GetAsync(Guid id);

        Task UpdateAsync(PostUpdate post);

        Task DeleteAsync(Guid id);
    }
}
