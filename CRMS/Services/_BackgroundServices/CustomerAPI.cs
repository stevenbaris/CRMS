using CRMS.Models;
using CRMS.Services._BackgroundServices.Token;
using CRMS.Services.Contacts_Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.Identity.Client;
using Newtonsoft.Json;
using NuGet.Common;
using NuGet.Packaging;
using System.Net.Http.Headers;
using System.Text;

namespace CRMS.Services._BackgroundServices
{
    public class CustomerAPI : BackgroundService
    {
        private readonly HttpClient _httpClient;
        private readonly IServiceProvider _serviceProvider;
        private readonly IConfiguration _configuration;
        private readonly ILogger<CustomerAPI> _logger;

        public CustomerAPI(
            HttpClient httpClient,
            IConfiguration configuration,
            IServiceProvider serviceProvider,
            ILogger<CustomerAPI> logger)
        {
            _httpClient = httpClient;
            _configuration = configuration;
            _serviceProvider = serviceProvider;
            _logger = logger;
            _logger = logger;
        }


        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                try
                {
                    // Get the CUSTOMER API data
                    var CustomerToken = await GetTokenAsync();
                    var CustomerData = await GetCustomerApiDataAsync(CustomerToken);
               
                    // Save new data to the database
                    await SYNCNewCustomerDataAsync(CustomerData);

                    // Wait for the configured interval before retrieving data again
                    await Task.Delay(TimeSpan.FromHours(24), stoppingToken);
                }
                catch (HttpRequestException ex)
                {
                    // Log the exception
                    Console.WriteLine($"Error: {ex.Message}");
                    _logger.LogError("HTTP Error");

                    // Wait for a certain amount of time before retrying
                    await Task.Delay(TimeSpan.FromSeconds(30), stoppingToken);
                }
                catch (Exception ex)
                {
                    // Log the exception
                    Console.WriteLine($"Error: {ex.Message}");
                    _logger.LogError("Another exception Error");
                }
            }
        }

        private async Task<string> GetTokenAsync()
        {
            Tokens token;
            try
            {
                var _URI = _configuration["CustomerAPI:URI"];
                var _username = _configuration["CustomerAPI:UserName"];
                var _password = _configuration["CustomerAPI:Password"];
                var _apiKey = _configuration["CustomerAPI:ApiKey"];

                var json = JsonConvert.SerializeObject(new
                {
                    UserName = _username,
                    Password = _password
                });

                // Send a POST request to the API to get a token
                var request = new HttpRequestMessage(HttpMethod.Post, _URI + "/signin");
                request.Headers.Add("ApiKey", _apiKey);
                request.Content = new StringContent(json, Encoding.UTF8, "application/json");

                var response = await _httpClient.SendAsync(request);
                var responseContent = await response.Content.ReadAsStringAsync();

                // Extract the token from the response
                var apitoken = JsonConvert.DeserializeObject<Tokens>(responseContent);
                token = apitoken;
                
            }
            catch (Exception ex)
            {
                // Log the exception
                Console.WriteLine($"Error: {ex.Message}");
                return null;
            }
            return token.AccessToken;
        }


        private async Task<List<Contacts>> GetCustomerApiDataAsync(string token)
        {
            var _URI = _configuration["CustomerAPI:URI"];
            var _apiKey = _configuration["CustomerAPI:ApiKey"];
            var data = new List<Contacts>();

            try
            {
                // Send a GET request to the API to get data
                var request = new HttpRequestMessage(HttpMethod.Get, _URI + "/api/v1/Customer/CustomerList");
                request.Headers.Add("ApiKey", _apiKey);
                request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", token);

                var response = await _httpClient.SendAsync(request);
                var responseContent = await response.Content.ReadAsStringAsync();

                // Deserialize the response content to a list of API data objects
                var apidata = JsonConvert.DeserializeObject<List<Contacts>>(responseContent);
                data.AddRange(apidata);
                
            }
            catch (HttpRequestException ex)
            {
                // Log the exception
                Console.WriteLine($"Error: {ex.Message}");
                throw new Exception("Failed to get customer API data.", ex);
            }
            catch (JsonException ex)
            {
                // Log the exception
                Console.WriteLine($"Error: {ex.Message}");
                throw new Exception("Failed to deserialize customer API data.", ex);
            }
            catch (Exception ex)
            {
                // Log the exception
                Console.WriteLine($"Error: {ex.Message}");
                throw new Exception("An error occurred while getting customer API data.", ex);
            }
            return data;
        }


        private async Task SYNCNewCustomerDataAsync(List<Contacts> data)
        {
            // Save the new data to the database
            using (var scope = _serviceProvider.CreateScope())
            {
                var _contactsRepo = scope.ServiceProvider.GetRequiredService<IContactRepository>();
                var existingContacts = await _contactsRepo.GetAllAsync();

                // Loop through each contact in the incoming data
                foreach (var contact in data)
                {
                    // Try to find the contact in the existing contacts list
                    var existingContact = existingContacts.FirstOrDefault(p => p.Contact_Id == contact.Contact_Id);

                    if (existingContact == null)
                    {
                        var newContact = new Contacts
                        {
                        Contact_Id = contact.Contact_Id,
                        FirstName = contact.FirstName,
                        LastName = contact.LastName,
                        Email = contact.Email,
                        PhoneNumber = contact.PhoneNumber,
                        Gender = contact.Gender,
                        DOB = contact.DOB,
                        CreateDate = contact.CreateDate,
                        UpdateDate = contact.UpdateDate,
                        IsLocal = false
                        
                    };
                        // Product does not exist in the database, add it
                        await _contactsRepo.CreateAsync(newContact);
                    }
                    else if (existingContact.UpdateDate < contact.UpdateDate)
                    {
                        // Product has been updated, update it in the database
                        existingContact.Contact_Id = contact.Contact_Id;
                        existingContact.FirstName = contact.FirstName;
                        existingContact.LastName = contact.LastName;
                        existingContact.Email = contact.Email;
                        existingContact.PhoneNumber = contact.PhoneNumber;
                        existingContact.Gender = contact.Gender;
                        existingContact.DOB = contact.DOB;
                        existingContact.CreateDate = contact.CreateDate;
                        existingContact.UpdateDate = contact.UpdateDate;
                        

                        await _contactsRepo.UpdateAsync(existingContact);
                    }
                }

                // Find any contacts that were deleted
                var deletedContacts = existingContacts.Where(p => !data.Any(d => d.Contact_Id == p.Contact_Id) && !p.IsLocal);
                foreach (var deletedContact in deletedContacts)
                {
                    // Product was deleted, remove it from the database
                    await _contactsRepo.DeleteAsync(deletedContact.Contact_Id);
                }
            }
        }


    }
}

