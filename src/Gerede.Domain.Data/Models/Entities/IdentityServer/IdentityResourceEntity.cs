using Gerede.Domain.Core.EntityFramework;
using IdentityServer4.Models;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Gerede.Domain.Data.Models.Entities.IdentityServer
{
    public class IdentityResourceEntity : EfBaseEntity
    {
        public string IdentityResourceData { get; set; }

        [Key]
        public string IdentityResourceName { get; set; }

        [NotMapped]
        public IdentityResource IdentityResource { get; set; }

        public void AddDataToEntity()
        {
            IdentityResourceData = JsonConvert.SerializeObject(IdentityResource);
            IdentityResourceName = IdentityResource.Name;
        }

        public void MapDataFromEntity()
        {
            IdentityResource = JsonConvert.DeserializeObject<IdentityResource>(IdentityResourceData);
            IdentityResourceName = IdentityResource.Name;
        }
    }
}
