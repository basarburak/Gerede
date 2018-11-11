using Gerede.Domain.Core.UnitOfWork;
using Gerede.Domain.Data.Mapper;
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

        public async Task<ApiResource> FindApiResourceAsync(string name)
        {
            await Task.CompletedTask;

            return _unitOfWork.GetRepository<ApiResourceEntity>()
                              .GetAllQuery()
                              .First(t => t.ApiResourceName == name)
                              .MapDataFromEntity();
        }

        public async Task<IEnumerable<ApiResource>> FindApiResourcesByScopeAsync(IEnumerable<string> scopeNames)
        {
            await Task.CompletedTask;

            if (scopeNames == null) throw new ArgumentNullException(nameof(scopeNames));


            var apiResources = new List<ApiResource>();

            var apiResourcesEntities = from i in _unitOfWork.GetRepository<ApiResourceEntity>().GetAllQuery()
                                       where scopeNames.Contains(i.ApiResourceName)
                                       select i;

            foreach (var apiResourceEntity in apiResourcesEntities)
            {
                apiResourceEntity.MapDataFromEntity();

                apiResources.Add(apiResourceEntity.MapDataFromEntity());
            }
            return apiResources;
        }

        public async Task<Client> FindClientByIdAsync(string clientId)
        {
            await Task.CompletedTask;

            var client = _unitOfWork.GetRepository<ClientEntity>()
                                    .GetAllQuery()
                                    .First(t => t.ClientId == clientId);

            return client.MapDataFromEntity();
        }

        public Task<IEnumerable<IdentityResource>> FindIdentityResourcesByScopeAsync(IEnumerable<string> scopeNames)
        {
            if (scopeNames == null) throw new ArgumentNullException(nameof(scopeNames));

            var identityResources = new List<IdentityResource>();

            var identityResourcesEntities = from i in _unitOfWork.GetRepository<IdentityResourceEntity>().GetAllQuery()
                                            where scopeNames.Contains(i.IdentityResourceName)
                                            select i;

            foreach (var identityResourceEntity in identityResourcesEntities)
            {
                identityResources.Add(identityResourceEntity.MapDataFromEntity());
            }

            return Task.FromResult(identityResources.AsEnumerable());
        }

        public Task<Resources> GetAllResourcesAsync()
        {
            var apiResourcesEntities = _unitOfWork.GetRepository<ApiResourceEntity>().GetAllQuery();
            var identityResourcesEntities = _unitOfWork.GetRepository<IdentityResourceEntity>().GetAllQuery();

            var apiResources = new List<ApiResource>();
            var identityResources = new List<IdentityResource>();

            foreach (var apiResourceEntity in apiResourcesEntities)
            {
                apiResources.Add(apiResourceEntity.MapDataFromEntity());
            }

            foreach (var identityResourceEntity in identityResourcesEntities)
            {
                identityResources.Add(identityResourceEntity.MapDataFromEntity());
            }

            var result = new Resources(identityResources, apiResources);
            return Task.FromResult(result);
        }
    }
}
