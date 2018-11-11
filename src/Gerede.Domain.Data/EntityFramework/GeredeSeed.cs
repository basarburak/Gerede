using Gerede.Domain.Data.EntityFramework.Context;
using Gerede.Domain.Data.Models.Entities.IdentityServer;
using IdentityServer4;
using IdentityServer4.Models;
using System.Collections.Generic;

namespace Gerede.Domain.Data.EntityFramework
{
    public static class GeredeSeed
    {
        //public static void CreateData(this GeredeContext context)
        //{
        //    context.AddRange(GetClientsInternal());
        //    context.AddRange(GetIdentityResources());
        //    context.AddRange(GetApiResources());

        //    context.SaveChanges();
        //}

        //private static IEnumerable<ClientEntity> GetClientsInternal()
        //{
        //    // client credentials client
        //    var internalClient = new List<Client>
        //    {
        //      new Client
        //       {
        //           ClientId = "carstacksp",
        //           ClientName = "CarStackSp",
        //           AllowedGrantTypes = GrantTypes.Implicit,
        //           AllowAccessTokensViaBrowser = true,

        //           RedirectUris =           { "http://localhost:4200/assets/signin-callback.html" },
        //           PostLogoutRedirectUris = { "http://localhost:4200/index.html" },
        //           AllowedCorsOrigins =     { "http://localhost:4200" },

        //           AllowedScopes =
        //           {
        //               IdentityServerConstants.StandardScopes.OpenId,
        //               "carstackapi"
        //           }
        //       }
        //    };

        //    List<ClientEntity> clients = new List<ClientEntity>();

        //    foreach (var client in internalClient)
        //    {
        //        var clientEntity = new ClientEntity
        //        {
        //            Client = client
        //        };
        //        clientEntity.AddDataToEntity();
        //        clients.Add(clientEntity);
        //    }
        //    return clients;
        //}

        //public static IEnumerable<IdentityResource> GetIdentityResourcesInternal()
        //{
        //    return new List<IdentityResource>
        //    {
        //        new IdentityResources.OpenId(),
        //        new IdentityResources.Profile(),
        //    };
        //}

        //public static IEnumerable<ApiResource> GetApiResourcesInternal()
        //{
        //    return new List<ApiResource>
        //    {
        //        new ApiResource("carstackapi", "Car Stack Api")
        //    };
        //}

        //public static IEnumerable<IdentityResourceEntity> GetIdentityResources()
        //{
        //    List<IdentityResourceEntity> identityResources = new List<IdentityResourceEntity>();
        //    foreach (var identityResource in GetIdentityResourcesInternal())
        //    {
        //        var identityResourceEntity = new IdentityResourceEntity
        //        {
        //            IdentityResource = identityResource
        //        };
        //        identityResourceEntity.AddDataToEntity();
        //        identityResources.Add(identityResourceEntity);
        //    }

        //    return identityResources;
        //}

        //public static IEnumerable<ApiResourceEntity> GetApiResources()
        //{
        //    List<ApiResourceEntity> apiResources = new List<ApiResourceEntity>();
        //    foreach (var apiResource in GetApiResourcesInternal())
        //    {
        //        var apiResourceEntity = new ApiResourceEntity
        //        {
        //            ApiResource = apiResource
        //        };
        //        apiResourceEntity.AddDataToEntity();
        //        apiResources.Add(apiResourceEntity);
        //    }

        //    return apiResources;
        //}

    }
}
