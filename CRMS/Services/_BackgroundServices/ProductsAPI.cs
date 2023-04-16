using CRMS.Models;
using CRMS.Services._BackgroundServices.Token;
using Microsoft.AspNetCore.Identity;
using Microsoft.Identity.Client;
using Newtonsoft.Json;
using System.Net.Http.Headers;

namespace CRMS.Services._BackgroundServices
{
    public class ProductsAPI: BackgroundService
    {
        private readonly HttpClient _httpClient;
        private readonly IRepository<Product> _productRepo;
        //private readonly ITokenStorage _tokenStorage;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IProductConfidentialClientApplication _app;
        private readonly IConfiguration _configuration;

        public ProductsAPI(
            HttpClient httpClient,
            UserManager<ApplicationUser> userManager,
            //ITokenStorage tokenStorage,
            IConfiguration configuration,
            IProductConfidentialClientApplication app,
            IRepository<Product> productRepo)
        {
            _httpClient = httpClient;
            _productRepo = productRepo;
            _userManager = userManager;
            //_tokenStorage = tokenStorage;
            _configuration = configuration;
            _app = app;

           
            
        }


        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                // Get the PRODUCT API data
                var ProductToken = await GetTokenAsync();
                var ProductData = await GetProductApiDataAsync(ProductToken);

                // Save new data to the database
                await SaveNewProductDataAsync(ProductData);

                // Wait for the configured interval before retrieving data again
                await Task.Delay(TimeSpan.FromHours(24), stoppingToken);
            }
        }

        private async Task<string> GetTokenAsync()
        {
            var username = _configuration["Oath2Product:UserName"];
            var password = _configuration["Oath2Product:Password"];

            // Send a POST request to the API to get a token
            var request = new HttpRequestMessage(HttpMethod.Post, "http://localhost:5002/signin");
            request.Content = new FormUrlEncodedContent(new Dictionary<string, string>
        {
            { "username", username },
            { "password",  password },
        });

            var response = await _httpClient.SendAsync(request);
            var responseContent = await response.Content.ReadAsStringAsync();

            // Extract the token from the response
            var token = JsonConvert.DeserializeObject<Tokens>(responseContent);

            return token.AccessToken;
        }


        //private async Task<string> GetProductsTokenAsync()
        //{
        //    var storedToken = _tokenStorage.RetrieveProductToken();

        //    if (storedToken != null && !storedToken.IsExpired())
        //    {
        //        return storedToken.AccessToken;
        //    }

        //    var newToken = await RefreshToken(storedToken);

        //    _tokenStorage.StoreProdcutToken(newToken);

        //    return newToken.AccessToken;
        //}


        //private async Task<Tokens> RefreshToken(Tokens oldToken)
        //{
        //    var clientId = _configuration["Oath2Product:ClientId"];
        //    var clientSecret = _configuration["Oath2Product:Secret"];
        //    var scopes = new string[] { _configuration["Oath2Product:Scopes"] };
        //    var username = _configuration["Oath2Product:UserName"];
        //    var password = _configuration["Oath2Product:Password"];


        //    var pca = PublicClientApplicationBuilder.Create(clientId)
        //         .WithAuthority(AzureCloudInstance.AzurePublic, AadAuthorityAudience.AzureAdAndPersonalMicrosoftAccount)
        //         .WithRedirectUri("http://localhost:5002/signin")
        //         .Build();

        //    var result = await pca.AcquireTokenByUsernamePassword(scopes, username, password)
        //        .ExecuteAsync();

        //    var newToken = new Tokens
        //    {
        //        AccessToken = result.AccessToken,
        //        ExpiresIn = result.ExpiresOn,
        //    };


        //    return newToken;
        //}

        private async Task<List<Product>> GetProductApiDataAsync(string token)
        {
            // Send a GET request to the API to get data
            var request = new HttpRequestMessage(HttpMethod.Get, "http://localhost:5274/api/v1/Product");
            request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", token);

            var response = await _httpClient.SendAsync(request);
            var responseContent = await response.Content.ReadAsStringAsync();

            // Deserialize the response content to a list of API data objects
            var data = JsonConvert.DeserializeObject<List<Product>>(responseContent);

            // Filter the data to only include new entries
            var system = await _userManager.FindByNameAsync("SYSTEM");
            var sysId = system.Id;
            var lastUpdatedTime = (await _productRepo.GetAllAsync()).Where(d => d.UpdatedBy == sysId).Max(d => d.UpdateDate);
            var newData = new List<Product>();
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


        private async Task SaveNewProductDataAsync(List<Product> data)
        {
            // Save the new data to the database
            foreach (var product in data)
            {
                await _productRepo.CreateAsync(product);
            }
        }


    }

    public interface IProductConfidentialClientApplication: IConfidentialClientApplication
    {

    }
}


