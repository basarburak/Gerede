using Gerede.Domain.Data.Manager;
using IdentityServer4.Models;
using IdentityServer4.Stores;
using System.Threading.Tasks;

namespace Gerede.Hosting.Identity.ConfigurationStore
{
    public class ClientStore : IClientStore
    {
        readonly IIdentityServerService _identityServerService;
        public ClientStore(IIdentityServerService identityServerService)
        {
            _identityServerService = identityServerService;
        }

        public async Task<Client> FindClientByIdAsync(string clientId)
        {
            return await _identityServerService.FindClientByIdAsync(clientId);
        }
    }
}
