using InformMedia.Repository.Contracts;

namespace InformMedia.Repository.Implementation.Repositories
{
    public class BaseRepository : IBaseRepository<InformMediaContext>
    {
        public void SetContext(InformMediaContext context)
        {
            this.Context = context;
        }

        protected InformMediaContext Context { get; private set; }
    }
}
