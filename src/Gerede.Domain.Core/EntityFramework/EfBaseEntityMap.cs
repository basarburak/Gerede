using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Gerede.Domain.Data.EntityFramework
{
    public abstract class EfBaseEntityMap<T> where T : class
    {
        public EfBaseEntityMap(EntityTypeBuilder<T> entity)
        {

        }
    }
}
