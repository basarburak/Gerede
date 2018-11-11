using System;
using System.Collections.Generic;
using System.Text;
using Gerede.Domain.Data.Models.Entities.IdentityServer;
using IdentityServer4.Models;
using Newtonsoft.Json;

namespace Gerede.Domain.Data.Mapper
{
    public static class IdentityResourceEntityMap // Sucess
    {
        public static IdentityResource MapDataFromEntity(this IdentityResourceEntity identityResourceEntity)
        {
            return JsonConvert.DeserializeObject<IdentityResource>(identityResourceEntity.IdentityResourceData);
        }

        public static IdentityResourceEntity AddDataToEntity(this IdentityResourceEntity identityResourceEntity, IdentityResource identityResource)
        {
            identityResourceEntity.IdentityResourceName = identityResource.Name;
            identityResourceEntity.IdentityResourceData = JsonConvert.SerializeObject(identityResource);
            return identityResourceEntity;
        }
    }
}
