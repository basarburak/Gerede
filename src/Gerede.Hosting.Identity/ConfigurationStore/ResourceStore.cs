using Gerede.Domain.Data.Manager;
using IdentityServer4.Models;
using IdentityServer4.Stores;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Gerede.Hosting.Identity.ConfigurationStore
{
    public class ResourceStore : IResourceStore
    {
        readonly IIdentityServerService _identityServerService;
        public ResourceStore(IIdentityServerService identityServerService)
        {
            _identityServerService = identityServerService;
        }

        public async Task<ApiResource> FindApiResourceAsync(string name)
        {
           return await _identityServerService.FindApiResourceAsync(name);
        }

        public async Task<IEnumerable<ApiResource>> FindApiResourcesByScopeAsync(IEnumerable<string> scopeNames)
        {
            return await _identityServerService.FindApiResourcesByScopeAsync(scopeNames);
        }

        public async Task<IEnumerable<IdentityResource>> FindIdentityResourcesByScopeAsync(IEnumerable<string> scopeNames)
        {
            return await _identityServerService.FindIdentityResourcesByScopeAsync(scopeNames);
        }

        public async Task<Resources> GetAllResourcesAsync()
        {
            return await _identityServerService.GetAllResourcesAsync();
        }
    }
}