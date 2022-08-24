namespace InformMedia.Repository.Contracts.UnitOfWork
{
    public interface IUnitOfWorkFactory
    {
        IUnitOfWork Create();
    }
}
