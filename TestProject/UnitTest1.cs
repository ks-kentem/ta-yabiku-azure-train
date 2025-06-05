using System.Net;

namespace TestProject
{
    public class UnitTest1
    {
        [Fact]
        public async Task GetAsync()
        {
            TestWebApplicationFactory factory = new();

            HttpClient client = factory.CreateClient();
            var response = await client.GetAsync("/Child");

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
            var content = response.Content.ReadAsStringAsync();
            Assert.NotNull(content);
        }
    }
}