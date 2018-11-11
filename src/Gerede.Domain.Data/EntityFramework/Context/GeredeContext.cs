using Gerede.Domain.Data.EntityFramework.Mappings;
using Gerede.Domain.Data.Models.Entities.IdentityServer;
using Microsoft.EntityFrameworkCore;

namespace Gerede.Domain.Data.EntityFramework.Context
{
    public class GeredeContext : EfBaseContext<GeredeContext>
    {
        public GeredeContext(DbContextOptions<GeredeContext> options) : base(options)
        {
            if (Database.EnsureCreated())
            {
                GeredeSeed.CreateData(this);
            }
        }

        public DbSet<ClientEntity> Clients { get; set; }
        public DbSet<ApiResourceEntity> ApiResources { get; set; }
        public DbSet<IdentityResourceEntity> IdentityResources { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.AddGeredeEntityMap();

            base.OnModelCreating(builder);
        }
    }
}
