using Newtonsoft.Json;
using NuGet.Common;
using System.Net.Http.Headers;

namespace CRMS.Services.Contacts_Services
{
    public class APIBackgroundService:BackgroundService
    {
            private readonly HttpClient _httpClient;
            private readonly IConfiguration _configuration;
            private readonly IContactRepository _contactRepo;

            public APIBackgroundService(HttpClient httpClient, IConfiguration configuration, IDbContext dbContext)
            {
                _httpClient = httpClient;
                _configuration = configuration;
                _contactRepo = dbContext;
            }

            protected override async Task ExecuteAsync(CancellationToken stoppingToken)
            {
                while (!stoppingToken.IsCancellationRequested)
                {
                    // Get the API data
                    var token = await GetTokenAsync();
                    var data = await GetApiDataAsync(token);

                    // Save new data to the database
                    await SaveNewDataAsync(data);

                    // Wait for the configured interval before retrieving data again
                    await Task.Delay(TimeSpan.FromSeconds(_configuration.GetValue<int>("ApiService:IntervalSeconds")), stoppingToken);
                }
            }

            private async Task<string> GetTokenAsync()
            {
                // Send a POST request to the API to get a token
                var request = new HttpRequestMessage(HttpMethod.Post, "http://localhost:5274/signin");
                request.Content = new FormUrlEncodedContent(new Dictionary<string, string>
        {
            { "username", "your_username" },
            { "password", "your_password" },
        });

                var response = await _httpClient.SendAsync(request);
                var responseContent = await response.Content.ReadAsStringAsync();

                // Extract the token from the response
                var token = JsonConvert.DeserializeObject<Token>(responseContent);

                return token.AccessToken;
            }

            private async Task<List<ApiData>> GetApiDataAsync(string token)
            {
                // Send a GET request to the API to get data
                var request = new HttpRequestMessage(HttpMethod.Get, "http://localhost:5274/api/data");
                request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", token);

                var response = await _httpClient.SendAsync(request);
                var responseContent = await response.Content.ReadAsStringAsync();

                // Deserialize the response content to a list of API data objects
                var data = JsonConvert.DeserializeObject<List<ApiData>>(responseContent);

                // Filter the data to only include new entries
                var lastUpdatedTime = _contactRepo.ApiData.Max(d => d.LastUpdatedTime);
                var newData = data.Where(d => d.LastUpdatedTime > lastUpdatedTime).ToList();

                return newData;
            }

            private async Task SaveNewDataAsync(List<ApiData> data)
            {
                // Save the new data to the database
                foreach (var item in data)
                {
                    await _contactRepo.AddAsync(item);
                }

                await _contactRepo.SaveChangesAsync();
            }
    }
}
