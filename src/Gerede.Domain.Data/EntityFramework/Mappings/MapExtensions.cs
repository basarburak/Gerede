using Gerede.Domain.Data.EntityFramework.Mappings.IdentityServer;
using Gerede.Domain.Data.Models.Entities.IdentityServer;
using Microsoft.EntityFrameworkCore;

namespace Gerede.Domain.Data.EntityFramework.Mappings
{
    public static class MapExtensions
    {
        public static ModelBuilder AddGeredeEntityMap(this ModelBuilder modelBuilder)
        {
            new ClientEntityMap(modelBuilder.Entity<ClientEntity>());
            new ApiResourceEntityMap(modelBuilder.Entity<ApiResourceEntity>());
            new IdentityResourceEntityMap(modelBuilder.Entity<IdentityResourceEntity>());

            return modelBuilder;
        }
    }
}
