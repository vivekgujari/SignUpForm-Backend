using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignUpForm_Backend.Services
{
    public class CosmosDbService : ICosmosDbService
    {
        public Task AddItemAsync(JObject data)
        {
            throw new NotImplementedException();
        }

        public Task DeleteItemAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<JObject> GetItemAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<JObject>> GetItemsAsync(string query)
        {
            throw new NotImplementedException();
        }

        public Task UpdateItemAsync(string id, JObject data)
        {
            throw new NotImplementedException();
        }
    }
}
