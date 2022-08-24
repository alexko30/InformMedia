namespace InformMedia.Repository.Contracts
{
    public interface IBaseRepository<TContext>
    {
        void SetContext(TContext context);
    }
}
