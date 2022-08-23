using InformMedia.Repository.Implementation.DataAccessObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InformMedia.Repository.Implementation.DataStoreConfiguration
{
    public class PostConfiguration : IEntityTypeConfiguration<PostRecord>
    {
        public void Configure(EntityTypeBuilder<PostRecord> buildr)
        {
            
        }
    }
}
