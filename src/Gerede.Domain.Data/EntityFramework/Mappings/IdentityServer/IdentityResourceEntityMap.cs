using Gerede.Domain.Data.Models.Entities.IdentityServer;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Gerede.Domain.Data.EntityFramework.Mappings.IdentityServer
{
    public class IdentityResourceEntityMap : EfBaseEntityMap<IdentityResourceEntity>
    {
        public IdentityResourceEntityMap(EntityTypeBuilder<IdentityResourceEntity> entity) : base(entity)
        {
            entity.HasKey(x => x.IdentityResourceName);
        }
    }
}
