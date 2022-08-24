using Autofac.Features.Metadata;
using InformMedia.Repository.Contracts;
using InformMedia.Repository.Contracts.Factories;
using InformMedia.Repository.Contracts.UnitOfWork;
using InformMedia.Repository.Implementation.Constants;

namespace InformMedia.Repository.Implementation.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly Dictionary<Type, Lazy<IBaseRepository<InformMediaContext>>> repositories;
        private readonly InformMediaContext context;

        public UnitOfWork(IGenericFactory factory, Func<Meta<Lazy<IBaseRepository<InformMediaContext>>>>[] repositoryFactories)
        {
            this.context = factory.Create<InformMediaContext>();
            this.repositories = repositoryFactories
                .Select(x => x())
                .ToDictionary(x => (Type)x.Metadata.First(m => m.Key == RepositoriesConstants.TypeMetadataKey).Value, x => x.Value);
        }

        public IPostsRepository PostsRepository => ResolveRepository<IPostsRepository>();

        public async Task CommitAsync()
        {
            await context.SaveChangesAsync();
        }

        public void Dispose()
        {
            context.Dispose();
        }

        private T ResolveRepository<T>()
        {
            var key = typeof(T);
            var found = repositories.TryGetValue(key, out var repository);

            if (!found)
            {
                throw new ApplicationException($"Requested repository with the type '{key.Name}' is not registered.");
            }

            if (!repository.IsValueCreated)
            {
                repository.Value.SetContext(context);
            }

            return (T)repository.Value;
        }
    }
}
