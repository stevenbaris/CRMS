using CRMS.Models;
using CRMS.Services._BackgroundServices.Token;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Text;

namespace CRMS.Services._BackgroundServices
{
    public class ProductsAPI: BackgroundService
    {
        private readonly HttpClient _httpClient;
        private readonly IServiceProvider _serviceProvider;
        private readonly IConfiguration _configuration;

        public ProductsAPI(
            HttpClient httpClient,
            IConfiguration configuration,
            IServiceProvider serviceProvider)
        {
            _httpClient = httpClient;
            _configuration = configuration;
            _serviceProvider = serviceProvider;

        }


        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                try
                {
                    // Get the PRODUCT API data
                    var ProductToken = await GetTokenAsync();
                    var ProductData = await GetProductApiDataAsync(ProductToken);

                    // Save new data to the database
                    await SyncProductDataAsync(ProductData);

                    // Wait for the configured interval before retrieving data again
                    await Task.Delay(TimeSpan.FromHours(24), stoppingToken);
                }
                catch (HttpRequestException ex)
                {
                    // Log the exception
                    Console.WriteLine($"Error: {ex.Message}");

                    // Wait for a certain amount of time before retrying
                    await Task.Delay(TimeSpan.FromSeconds(30), stoppingToken);
                }
            }
        }

        private async Task<string> GetTokenAsync()
        {
            var _username = _configuration["ProductAPI:UserName"];
            var _password = _configuration["ProductAPI:Password"];
            var _URI = _configuration["ProductAPI:URI"];

            var json = JsonConvert.SerializeObject(new
            {
                UserName = _username,
                Password = _password
            });
            
            // Send a POST request to the API to get a token
            var request = new HttpRequestMessage(HttpMethod.Post, _URI+"/signin");
            request.Content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _httpClient.SendAsync(request);
            var responseContent = await response.Content.ReadAsStringAsync();

            // Extract the token from the response
            var token = JsonConvert.DeserializeObject<Tokens>(responseContent);

            return token.AccessToken;
        }

        private async Task<List<Product>> GetProductApiDataAsync(string token)
        {
            var _URI = _configuration["ProductAPI:URI"];
            // Send a GET request to the API to get data
            var request = new HttpRequestMessage(HttpMethod.Get, _URI+"/api/v1/Product/ProductList");
            request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", token);

            var response = await _httpClient.SendAsync(request);
            var responseContent = await response.Content.ReadAsStringAsync();

            // Deserialize the response content to a list of API data objects
            var data = JsonConvert.DeserializeObject<List<Product>>(responseContent);

            return data;
        }


        private async Task SyncProductDataAsync(List<Product> data)
        {
            // SYNC remdte data to the lcoal database
            using (var scope = _serviceProvider.CreateScope())
            {
                var _productsRepo = scope.ServiceProvider.GetRequiredService<IRepository<Product>>();
                var existingProducts = await _productsRepo.GetAllAsync();

                // Loop through each product in the incoming data
                foreach (var product in data)
                {
                    // Try to find the product in the existing products list
                    var existingProduct = existingProducts.FirstOrDefault(p => p.Product_Id == product.Product_Id);

                    if (existingProduct == null)
                    {
                        var newProduct = new Product
                        {
                        Product_Id = product.Product_Id,
                        ProductName = product.ProductName,
                        ProductDescription = product.ProductDescription,
                        Benefits = product.Benefits,
                        CreateDate = product.CreateDate,
                        UpdateDate = product.UpdateDate,
                    };
                        // Product does not exist in the database, add it
                        await _productsRepo.CreateAsync(newProduct);
                    }
                    else if (existingProduct.Product_Id == product.Product_Id && existingProduct.UpdateDate < product.UpdateDate)
                    {
                        // Product has been updated, update it in the database
                        
                        existingProduct.ProductName = product.ProductName;
                        existingProduct.ProductDescription = product.ProductDescription;
                        existingProduct.Benefits = product.Benefits;
                        existingProduct.UpdateDate = product.UpdateDate;
                        await _productsRepo.UpdateAsync(existingProduct);
                    }
                }

                // Find any products that were deleted
                var deletedProducts = existingProducts.Where(p => !data.Any(d => d.Product_Id == p.Product_Id));
                foreach (var deletedProduct in deletedProducts)
                {
                    // Product was deleted, remove it from the database
                    await _productsRepo.DeleteAsync(deletedProduct.Product_Id);
                }
            }
        }


    }
}


