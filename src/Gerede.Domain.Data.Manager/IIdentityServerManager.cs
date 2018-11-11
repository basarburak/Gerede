using Gerede.Domain.Core.UnitOfWork;
using Gerede.Domain.Data.Models.Entities.IdentityServer;
using IdentityServer4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gerede.Domain.Data.Manager
{
    public class IIdentityServerManager : IIdentityServerService
    {
        readonly IUnitOfWork _unitOfWork;
        public IIdentityServerManager(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public Task<ApiResource> FindApiResourceAsync(string name)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ApiResource>> FindApiResourcesByScopeAsync(IEnumerable<string> scopeNames)
        {
            throw new NotImplementedException();
        }

        public Task<Client> FindClientByIdAsync(string clientId)
        {
            var client = _unitOfWork.GetRepository<ClientEntity>()
                                    .GetAllQuery()
                                    .First(t => t.ClientId == clientId);

          //  client.MapDataFromEntity();

            throw new NotImplementedException();
        }

        public Task<IEnumerable<IdentityResource>> FindIdentityResourcesByScopeAsync(IEnumerable<string> scopeNames)
        {
            throw new NotImplementedException();
        }

        public Task<Resources> GetAllResourcesAsync()
        {
            throw new NotImplementedException();
        }
    }
}
