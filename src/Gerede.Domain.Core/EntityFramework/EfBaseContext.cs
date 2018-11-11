using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace Gerede.Domain.Data.EntityFramework
{
    public class EfBaseContext<T> : DbContext where T : DbContext
    {
        public EfBaseContext(DbContextOptions<T> options) : base(options)
        {
            
        }

        public override int SaveChanges()
        {
            return base.SaveChanges();
        }

        public override Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default(CancellationToken))
        {
            return base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
        }
    }
}
