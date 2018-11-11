using Gerede.Hosting.Core.Configration;
using Microsoft.Extensions.Configuration;

namespace Gerede.Hosting.Core.Extensions
{
    public static class ServerExtensions
    {
        public static ServerSetting GetServerSettings(this IConfiguration configuration)
        {
            return configuration.GetSection(ApplicationVariable.AppSettings)
                                .Get<ServerSetting>();
        }
    }
}
