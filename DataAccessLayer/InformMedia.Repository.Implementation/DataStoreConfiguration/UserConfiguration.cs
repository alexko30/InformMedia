using InformMedia.Repository.Implementation.DataAccessObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InformMedia.Repository.Implementation.DataStoreConfiguration
{
    public class UserConfiguration : IEntityTypeConfiguration<UserRecord>
    {
        public void Configure(EntityTypeBuilder<UserRecord> buildr)
        {
            
        }
    }
}
