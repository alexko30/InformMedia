using InformMedia.Repository.Contracts.UnitOfWork;

namespace InformMedia.Repository.Implementation.UnitOfWork
{
    public class UnitOfWorkFactory : IUnitOfWorkFactory
    {
        private readonly InformMediaContext context;

        public UnitOfWorkFactory(InformMediaContext context)
        {
            this.context = context;
        }

        public IUnitOfWork Create()
        {
            return new UnitOfWork(this.context);
        }
    }
}
