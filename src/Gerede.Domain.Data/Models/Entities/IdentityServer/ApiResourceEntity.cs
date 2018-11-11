using Gerede.Domain.Core.EntityFramework;
using IdentityServer4.Models;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Gerede.Domain.Data.Models.Entities.IdentityServer
{
    public class ApiResourceEntity : EfBaseEntity
    {
        public string ApiResourceData { get; set; }

        [Key]
        public string ApiResourceName { get; set; }

        [NotMapped]
        public ApiResource ApiResource { get; set; }

        public void AddDataToEntity()
        {
            ApiResourceData = JsonConvert.SerializeObject(ApiResource);
            ApiResourceName = ApiResource.Name;
        }

        public void MapDataFromEntity()
        {
            ApiResource = JsonConvert.DeserializeObject<ApiResource>(ApiResourceData);
            ApiResourceName = ApiResource.Name;
        }
    }
}
