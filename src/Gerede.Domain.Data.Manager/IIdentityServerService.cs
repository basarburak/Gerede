using IdentityServer4.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Gerede.Domain.Data.Manager
{
    public interface IIdentityServerService
    {
        Task<Client> FindClientByIdAsync(string clientId);
        Task<ApiResource> FindApiResourceAsync(string name);
        Task<IEnumerable<ApiResource>> FindApiResourcesByScopeAsync(IEnumerable<string> scopeNames);
        Task<IEnumerable<IdentityResource>> FindIdentityResourcesByScopeAsync(IEnumerable<string> scopeNames);
        Task<Resources> GetAllResourcesAsync();
    }
}
