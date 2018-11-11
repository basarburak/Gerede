using Gerede.Domain.Data.EntityFramework.Context;
using IdentityServer4.Models;
using IdentityServer4.Stores;
using Microsoft.Extensions.Logging;
using System.Linq;
using System.Threading.Tasks;

namespace Gerede.Domain.Data.ConfigurationStore
{
    public class ClientStore : IClientStore
    {
        private readonly GeredeContext _context;
        private readonly ILogger _logger;

        public ClientStore(GeredeContext context, ILoggerFactory loggerFactory)
        {
            _context = context;
            _logger = loggerFactory.CreateLogger("ClientStore");
        }

        public Task<Client> FindClientByIdAsync(string clientId)
        {
            var client = _context.Clients.First(t => t.ClientId == clientId);
            client.MapDataFromEntity();
            return Task.FromResult(client.Client);
        }
    }
}
