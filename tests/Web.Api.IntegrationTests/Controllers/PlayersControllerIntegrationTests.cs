using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Web.Api.Core.Domain.Entities;
using Xunit;

namespace Web.Api.IntegrationTests.Controllers
{
    public class PlayersControllerIntegrationTests : IClassFixture<CustomWebApplicationFactory<Startup>>
    {
        private readonly HttpClient _client;

        public PlayersControllerIntegrationTests(CustomWebApplicationFactory<Startup> factory)
        {
            _client = factory.CreateClient();
        }

        [Fact]
        public async Task Test1()
        {
            var httpResponse = await _client.GetAsync("/api/players");
            httpResponse.EnsureSuccessStatusCode();
            var stringResponse = await httpResponse.Content.ReadAsStringAsync();
            var players = JsonConvert.DeserializeObject<IEnumerable<Player>>(stringResponse);
            Assert.Contains(players, p => p.FirstName=="Wayne");
            Assert.Contains(players, p => p.FirstName == "Mario");
        }
    }
}
