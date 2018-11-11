using Gerede.Domain.Data.Models.Entities.IdentityServer;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Gerede.Domain.Data.EntityFramework.Mappings.IdentityServer
{
    public class ApiResourceEntityMap : EfBaseEntityMap<ApiResourceEntity>
    {
        public ApiResourceEntityMap(EntityTypeBuilder<ApiResourceEntity> entity) : base(entity)
        {
            entity.HasKey(x => x.ApiResourceName);
        }
    }
}
