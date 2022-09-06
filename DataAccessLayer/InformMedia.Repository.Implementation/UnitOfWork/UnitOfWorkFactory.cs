using InformMedia.Repository.Contracts.Factories;
using InformMedia.Repository.Contracts.UnitOfWork;
using InformMedia.Repository.Contracts;

namespace InformMedia.Repository.Implementation.UnitOfWork
{
    public class UnitOfWorkFactory : IUnitOfWorkFactory
    {
        private readonly Func<Meta<Lazy<IBaseRepository<InformMediaContext>>>>[] repositoryFactories;
        private readonly IGenericFactory factory;

        public UnitOfWorkFactory(IGenericFactory factory, Func<Meta<Lazy<IBaseRepository<InformMediaContext>>>>[] repositoryFactories)
        {
            this.factory = factory;
            this.repositoryFactories = repositoryFactories;
        }

        public IUnitOfWork Create()
        {
            return new UnitOfWork(this.factory, this.repositoryFactories);
        }
    }
}
