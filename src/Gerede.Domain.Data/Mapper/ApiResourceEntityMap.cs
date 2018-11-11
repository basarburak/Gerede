using Gerede.Domain.Data.Models.Entities.IdentityServer;
using IdentityServer4.Models;
using Newtonsoft.Json;

namespace Gerede.Domain.Data.Mapper
{
    public static class ApiResourceEntityMap // Success
    {
        public static ApiResource MapDataFromEntity(this ApiResourceEntity apiResourceEntity)
        {
            return JsonConvert.DeserializeObject<ApiResource>(apiResourceEntity.ApiResourceData);
        }

        public static ApiResourceEntity AddDataToEntity(this ApiResourceEntity apiResourceEntity, ApiResource apiResource)
        {
            apiResourceEntity.ApiResourceName = apiResource.Name;
            apiResourceEntity.ApiResourceData = JsonConvert.SerializeObject(apiResource);
            return apiResourceEntity;
        }
    }
}
