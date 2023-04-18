using CRMS.Models;
using CRMS.Services._BackgroundServices.Token;
using CRMS.Services.Contacts_Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.Identity.Client;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Text;

namespace CRMS.Services._BackgroundServices
{
    public class CustomerAPI : BackgroundService
    {
        private readonly HttpClient _httpClient;
        private readonly IServiceProvider _serviceProvider;
        private readonly IConfiguration _configuration;

        public CustomerAPI(
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

                    // Wait for a certain amount of time before retrying
                    await Task.Delay(TimeSpan.FromSeconds(30), stoppingToken);
                }
            }
        }

        private async Task<string> GetTokenAsync()
        {
            var _URI = _configuration["CustomerAPI:URI"];
            var _username = _configuration["CustomerAPI:UserName"];
            var _password = _configuration["CustomerAPI:Password"];

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


        private async Task<List<Contacts>> GetCustomerApiDataAsync(string token)
        {
            var _URI = _configuration["CustomerAPI:URI"];

            // Send a GET request to the API to get data
            var request = new HttpRequestMessage(HttpMethod.Get, _URI +"/api/v1/Customer/CustomerList");
            request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", token);

            var response = await _httpClient.SendAsync(request);
            var responseContent = await response.Content.ReadAsStringAsync();

            // Deserialize the response content to a list of API data objects
            var data = JsonConvert.DeserializeObject<List<Contacts>>(responseContent);

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
                        // Product does not exist in the database, add it
                        await _contactsRepo.CreateAsync(contact);
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
                var deletedContacts = existingContacts.Where(p => !data.Any(d => d.Contact_Id == p.Contact_Id));
                foreach (var deletedContact in deletedContacts)
                {
                    // Product was deleted, remove it from the database
                    await _contactsRepo.DeleteAsync(deletedContact.Contact_Id);
                }
            }
        }


    }
}

