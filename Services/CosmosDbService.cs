using Microsoft.Azure.Cosmos;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignUpForm_Backend.Services
{
    public class CosmosDbService : ICosmosDbService
    {
        private Container _container;
        public CosmosDbService(CosmosClient dbClient, string databaseName, string containerName)
        {
            this._container = dbClient.GetContainer(databaseName, containerName);
        }
        public async Task AddItemAsync(JObject data)
        {
            await this._container.CreateItemAsync<JObject>(data);
        }

        public async Task DeleteItemAsync(string id)
        {
            await this._container.DeleteItemAsync<JObject>(id, new PartitionKey(id));
        }

        public async Task<JObject> GetItemAsync(string id)
        {
            try
            {
                ItemResponse<JObject> response = await this._container.ReadItemAsync<JObject>(id, new PartitionKey(id));
                return response;
            }
            catch (CosmosException ex) when (ex.StatusCode == System.Net.HttpStatusCode.NotFound)
            {
                return null;
            }
        }

        public async Task<IEnumerable<JObject>> GetItemsAsync(string queryString)
        {
            var query = this._container.GetItemQueryIterator<JObject>(new QueryDefinition(queryString));
            List<JObject> results = new List<JObject>();
            while (query.HasMoreResults)
            {
                var response = await query.ReadNextAsync();
                results.AddRange(response.ToList());
            }
            return results;
        }

        public async Task UpdateItemAsync(string id, JObject data)
        {
            await this._container.UpsertItemAsync<JObject>(data, new PartitionKey(id));
        }
    }
}
