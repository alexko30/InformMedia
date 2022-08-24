using InformMedia.Models;
using InformMedia.Repository.Contracts.UnitOfWork;
using InformMedia.Service.Contracts;

namespace InformMedia.Service.Implementation
{
    public class PostsService : BaseService, IPostsService
    {
        public PostsService(IUnitOfWorkFactory unitOfWorkFactory) : base(unitOfWorkFactory)
        {
            
        }

        public async Task CreateAsync(PostCreate post)
        {
            await RunWithoutCommit(async (unitOfWork) =>
            {
                await unitOfWork.PostsRepository.CreateAsync(post);
            });
        }

        public async Task<PostGet> GetAsync(Guid id)
        {
            return await RunWithoutCommit(async (unitOfWork) =>
            {
                return await unitOfWork.PostsRepository.GetAsync(id);
            });
        }

        public async Task Update(PostUpdate post)
        {
            await RunWithoutCommit(async (unitOfWork) =>
            {
                await unitOfWork.PostsRepository.UpdateAsync(post);
            });
        }

        public async Task DeleteAsync(Guid id)
        {
            await RunWithoutCommit(async (unitOfWork) =>
            {
                await unitOfWork.PostsRepository.DeleteAsync(id);
            });
        }
    }
}