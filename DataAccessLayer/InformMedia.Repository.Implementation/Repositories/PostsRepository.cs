using InformMedia.Models;
using InformMedia.Repository.Contracts;

namespace InformMedia.Repository.Implementation.Repositories
{
    public class PostsRepository : BaseRepository, IPostsRepository
    {
        public async Task CreateAsync(PostCreate post)
        {
            await Task.Delay(5);
            Console.WriteLine("CreateAsync");
        }

        public async Task<PostGet> GetAsync(Guid id)
        {
            await Task.Delay(5);

            PostTag[] tags = { PostTag.Markets };

            return new PostGet
            {
                Id = id,
                Tags = tags,
                Title = "Test title",
                Subtitle = "Test subtitle",
                Content = "Test content",
                CreatedDate = DateTime.Now,
            };
        }

        public async Task UpdateAsync(PostUpdate post)
        {
            await Task.Delay(5);
            Console.WriteLine("CreateAsync");
        }

        public async Task DeleteAsync(Guid id)
        {
            await Task.Delay(5);
            Console.WriteLine("CreateAsync");
        }
    }
}
