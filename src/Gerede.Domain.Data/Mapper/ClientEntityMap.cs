using System;
using System.Collections.Generic;
using System.Text;
using Gerede.Domain.Data.Models.Entities.IdentityServer;
using IdentityServer4.Models;
using Newtonsoft.Json;

namespace Gerede.Domain.Data.Mapper
{
    public static class ClientEntityMap // Success
    {
        public static Client MapDataFromEntity(this ClientEntity clientEntity)
        {
            return JsonConvert.DeserializeObject<Client>(clientEntity.ClientData);
        }

        public static ClientEntity AddDataToEntity(this ClientEntity clientEntity, Client client)
        {
            clientEntity.ClientId = client.ClientId;
            clientEntity.ClientData = JsonConvert.SerializeObject(client);
            return clientEntity;
        }
    }
}
