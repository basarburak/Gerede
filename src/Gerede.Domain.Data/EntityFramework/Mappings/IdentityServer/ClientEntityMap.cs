using Gerede.Domain.Data.Models.Entities.IdentityServer;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Gerede.Domain.Data.EntityFramework.Mappings.IdentityServer
{
    public class ClientEntityMap : EfBaseEntityMap<ClientEntity>
    {
        public ClientEntityMap(EntityTypeBuilder<ClientEntity> entity) : base(entity)
        {
            entity.HasKey(m => m.ClientId);
        }
    }
}
