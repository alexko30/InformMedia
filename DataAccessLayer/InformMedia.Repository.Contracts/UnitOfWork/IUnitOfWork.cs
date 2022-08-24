namespace InformMedia.Repository.Contracts.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        IPostsRepository PostsRepository { get; }

        Task CommitAsync();
    }
}
