using Gerede.Domain.Core.Extensions;
using Gerede.Domain.Data.EntityFramework.Context;
using Gerede.Hosting.Core.Configration;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Gerede.Hosting.Core.Extensions
{
    public static class DataExtensions
    {
        public static IServiceCollection AddGeredeData(this IServiceCollection services, ServerSetting serverSetting, bool useMssql = true)
        {
            if (useMssql)
            {
                services.AddDbContext<GeredeContext>(opt => opt.UseSqlServer(serverSetting.SqlConnection))
                        .AddUnitOfWork<GeredeContext>();
            }
            else 
            {
                services.AddDbContext<GeredeContext>(opt => opt.UseMySQL(serverSetting.MySqlConnection))
                        .AddUnitOfWork<GeredeContext>();
            }

            return services;
        }
    }
}
