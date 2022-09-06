using InformMedia.Repository.Contracts;
using Microsoft.Extensions.Logging;

namespace InformMedia.Repository.Implementation.Repositories
{
    public class BaseRepository : IBaseRepository<InformMediaContext>
    {
        protected InformMediaContext Context { get; private set; }

        public BaseRepository(InformMediaContext context)
        {
            this.Context = context;
        }
    }
}
