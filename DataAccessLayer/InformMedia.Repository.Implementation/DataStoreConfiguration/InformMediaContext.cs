using InformMedia.Repository.Implementation.DataAccessObjects;
using Microsoft.EntityFrameworkCore;
using InformMedia.Repository.Implementation.DataStoreConfiguration;

namespace InformMedia.Repository.Implementation
{
    public class InformMediaContext: DbContext
    {
        public virtual DbSet<UserRecord> Posts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new PostConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}