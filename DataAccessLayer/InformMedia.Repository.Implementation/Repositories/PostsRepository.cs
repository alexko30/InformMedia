using InformMedia.Models;
using InformMedia.Repository.Contracts;

namespace InformMedia.Repository.Implementation.Repositories
{
    public class PostsRepository : BaseRepository
    {
        public void CreateAsync(PostCreate post)
        {
            Console.WriteLine("CreateAsync");
        }

        public PostGet GetAsync(Guid id)
        {
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

        public void UpdateAsync(PostUpdate post)
        {
            Console.WriteLine("CreateAsync");
        }

        public void DeleteAsync(Guid id)
        {
            Console.WriteLine("CreateAsync");
        }
    }
}
