using InformMedia.Repository.Contracts;
using InformMedia.Repository.Contracts.UnitOfWork;
using InformMedia.Repository.Implementation.Repositories;

namespace InformMedia.Repository.Implementation.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly InformMediaContext context;
        public IPostsRepository PostsRepository { get; private set; }

        public UnitOfWork(InformMediaContext context)
        {
            this.context = context;
            this.PostsRepository = new PostsRepository(context);
        }

        public async Task CommitAsync()
        {
            await context.SaveChangesAsync();
        }

        public void Dispose()
        {
            context.Dispose();
        }
    }
}
