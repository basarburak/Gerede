using Gerede.Domain.Core.EntityFramework;
using IdentityServer4.Models;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Gerede.Domain.Data.Models.Entities.IdentityServer
{
    public class ClientEntity : EfBaseEntity
    {
        public string ClientData { get; set; }

        [Key]
        public string ClientId { get; set; }

        [NotMapped]
        public Client Client { get; set; }

        public void AddDataToEntity()
        {
            ClientData = JsonConvert.SerializeObject(Client);
            ClientId = Client.ClientId;
        }

        public void MapDataFromEntity()
        {
            Client = JsonConvert.DeserializeObject<Client>(ClientData);
            ClientId = Client.ClientId;
        }
    }
}
