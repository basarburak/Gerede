using Gerede.Domain.Core.EntityFramework;
using System.ComponentModel.DataAnnotations;

namespace Gerede.Domain.Data.Models.Entities.IdentityServer
{
    public class ApiResourceEntity : EfBaseEntity
    {
        public string ApiResourceData { get; set; }

        [Key]
        public string ApiResourceName { get; set; }

        //public void AddDataToEntity()
        //{
        //    ApiResourceData = JsonConvert.SerializeObject(ApiResource);
        //    ApiResourceName = ApiResource.Name;
        //}

        //public void MapDataFromEntity()
        //{
        //    ApiResource = JsonConvert.DeserializeObject<ApiResource>(ApiResourceData);
        //    ApiResourceName = ApiResource.Name;
        //}
    }
}
