using Gerede.Domain.Data.ConfigurationStore;
using IdentityServer4.Stores;
using Microsoft.Extensions.DependencyInjection;

namespace Gerede.Hosting.Core.Extensions
{
    public static class IdentityServerExtensions
    {
        public static IServiceCollection AddGeredeIdentityServer(this IServiceCollection services)
        {
            services.AddIdentityServer()
                    .AddDeveloperSigningCredential()
                    .AddResourceStore<ResourceStore>()
                    .AddClientStore<ClientStore>()
                    .AddProfileService<ProfileService>();

            services.AddTransient<IClientStore, ClientStore>();
            services.AddTransient<IResourceStore, ResourceStore>();

            return services;
        }
    }
}
