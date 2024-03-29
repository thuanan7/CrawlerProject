using CrawlerProject_Web.Models;
using CrawlerProject_Web.Services.IServices;
using Microsoft.VisualBasic;
using Newtonsoft.Json;

namespace CrawlerProject_Web.Services
{
    public class CrawlerService : ICrawlerService
    {
        private readonly string crawlerApiUrl = "https://localhost:7111/api/crawlerapi";
        public IHttpClientFactory httpClient { get; set; }

        public CrawlerService(IHttpClientFactory httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<List<Conference>> GetConferencesAsync()
        {
            var client = httpClient.CreateClient("CrawlerProject");
            HttpRequestMessage message = new();
            message.Headers.Add("Accept", "application/json");
            message.RequestUri = new Uri(crawlerApiUrl);
            message.Method = HttpMethod.Get;

            HttpResponseMessage httpResponseMessage = await client.SendAsync(message);
            var apiContent = await httpResponseMessage.Content.ReadAsStringAsync();
            var responseContent = JsonConvert.DeserializeObject<List<Conference>>(apiContent);

            
            return responseContent;
        }
    }
}
