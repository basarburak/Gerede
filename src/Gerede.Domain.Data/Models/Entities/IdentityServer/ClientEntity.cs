using Gerede.Domain.Core.EntityFramework;
using System.ComponentModel.DataAnnotations;

namespace Gerede.Domain.Data.Models.Entities.IdentityServer
{
    public class ClientEntity : EfBaseEntity
    {
        public string ClientData { get; set; }

        [Key]
        public string ClientId { get; set; }

        //[NotMapped]
        //public Client Client { get; set; }

        //public void AddDataToEntity()
        //{
        //    ClientData = JsonConvert.SerializeObject(Client);
        //    ClientId = Client.ClientId;
        //}

        //public void MapDataFromEntity()
        //{
        //    Client = JsonConvert.DeserializeObject<Client>(ClientData);
        //    ClientId = Client.ClientId;
        //}
    }
}
