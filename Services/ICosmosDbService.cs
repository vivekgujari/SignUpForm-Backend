using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignUpForm_Backend.Services
{
    public interface ICosmosDbService
    {
        Task<IEnumerable<JObject>> GetItemsAsync(string query);
        Task<JObject> GetItemAsync(string id);
        Task AddItemAsync(JObject data);
        Task UpdateItemAsync(string id, JObject data);
        Task DeleteItemAsync(string id);

    }
}
