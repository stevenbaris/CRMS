using CRMS.Models;
using CRMS.Services._BackgroundServices.Token;
using CRMS.Services.Contacts_Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.Identity.Client;
using Newtonsoft.Json;
using System.Net.Http.Headers;

namespace CRMS.Services._BackgroundServices
{
    public class CustomerAPI : BackgroundService
    {
        private readonly HttpClient _httpClient;
        private readonly IContactRepository _contactRepo;
        private readonly ITokenStorage _tokenStorage;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IConfidentialClientApplication _app;
        private readonly IConfiguration _configuration;

        public CustomerAPI(
            HttpClient httpClient,
            IContactRepository dbContext,
            UserManager<ApplicationUser> userManager,
            ITokenStorage tokenStorage,
            IConfiguration configuration,
            IConfidentialClientApplication app)
        {
            _httpClient = httpClient;
            _contactRepo = dbContext;
            _userManager = userManager;
            _tokenStorage = tokenStorage;
            _configuration = configuration;
            _app = app;

            var clientId = _configuration["Oath2Customer:ClientId"];
            var clientSecret = _configuration["Oath2Customer:Secret"];
            var tenantId = _configuration["Oath2Customer:TenantId"];
            var authority = "https://login.microsoftonline.com/<your Azure AD tenant ID>";
            authority = authority.Replace("<your Azure AD tenant ID>", tenantId);

            app = ConfidentialClientApplicationBuilder
                .Create(clientId)
                .WithClientSecret(clientSecret)
                .WithAuthority(authority)
                .Build();

        }


        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                // Get the CUSTOMER API data
                var CustomerToken = await GetContactsTokenAsync();
                var CustomerData = await GetCustomerApiDataAsync(CustomerToken);
               
                // Save new data to the database
                await SaveNewCustomerDataAsync(CustomerData);

                // Wait for the configured interval before retrieving data again
                await Task.Delay(TimeSpan.FromHours(24), stoppingToken);
            }
        }

        private async Task<string> GetContactsTokenAsync()
        {
            var storedToken = _tokenStorage.RetrieveContactToken();

            if (storedToken != null && !storedToken.IsExpired())
            {
                return storedToken.AccessToken;
            }

            var newToken = await RefreshToken(storedToken);

            _tokenStorage.StoreContactToken(newToken);

            return newToken.AccessToken;



        }


        private async Task<Tokens> RefreshToken(Tokens oldToken)
        {
            var clientId = _configuration["Oath2Customer:ClientId"];
            var clientSecret = _configuration["Oath2Customer:Secret"];
            var scopes = new string[] { _configuration["Oath2Customer:Scopes"] };
            var username = _configuration["Oath2Customer:UserName"];
            var password = _configuration["Oath2Customer:Password"];


            var pca = PublicClientApplicationBuilder.Create(clientId)
                 .WithAuthority(AzureCloudInstance.AzurePublic, AadAuthorityAudience.AzureAdAndPersonalMicrosoftAccount)
                 .WithRedirectUri("http://localhost:5274/signin")
                 .Build();

            var result = await pca.AcquireTokenByUsernamePassword(scopes, username, password)
                .ExecuteAsync();

            var newToken = new Tokens
            {
                AccessToken = result.AccessToken,
                ExpiresIn = result.ExpiresOn,
            };


            return newToken;
        }



        private async Task<List<Contacts>> GetCustomerApiDataAsync(string token)
        {
            // Send a GET request to the API to get data
            var request = new HttpRequestMessage(HttpMethod.Get, "http://localhost:5274/api/v1/Customer");
            request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", token);

            var response = await _httpClient.SendAsync(request);
            var responseContent = await response.Content.ReadAsStringAsync();

            // Deserialize the response content to a list of API data objects
            var data = JsonConvert.DeserializeObject<List<Contacts>>(responseContent);

            // Filter the data to only include new entries
            var system = await _userManager.FindByNameAsync("SYSTEM");
            var sysId = system.Id;
            var lastUpdatedTime = (await _contactRepo.GetAllAsync()).Where(d => d.UpdatedBy == sysId).Max(d => d.UpdateDate);
            var newData = new List<Contacts>();
            if (data != null)
            {
                if (lastUpdatedTime.HasValue)
                {
                    newData = data.Where(d => d.UpdateDate > lastUpdatedTime).ToList();
                }
                else
                {
                    newData = data;
                }
            }

            return newData;
        }


        private async Task SaveNewCustomerDataAsync(List<Contacts> data)
        {
            // Save the new data to the database
            foreach (var contact in data)
            {
                await _contactRepo.CreateAsync(contact);
            }
        }


    }
}

