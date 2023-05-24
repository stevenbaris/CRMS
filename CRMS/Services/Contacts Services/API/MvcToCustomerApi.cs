using CRMS.Models;
using CRMS.Services._BackgroundServices.Token;
using CustomersAPI.DTO;
using Newtonsoft.Json;
using NuGet.Common;
using System.Net.Http.Headers;
using System;
using System.Text;
using Newtonsoft.Json.Linq;
using Microsoft.AspNetCore.Mvc;
using System.Web.Helpers;

namespace CRMS.Services.Contacts_Services.API
{
    public class MvcToCustomerApi:ISyncMvcToApi<Contacts>
    {
        private readonly IConfiguration _configuration;
        private readonly HttpClient _httpClient;
        private string _apiKey;
        private string _baseURL;
        private string _userName;
        private string _password;


        public MvcToCustomerApi(IConfiguration configuration, HttpClient httpClient)
        {
            _configuration = configuration;
            _httpClient = httpClient;

            _apiKey = _configuration["CustomerAPI:ApiKey"];
            _baseURL = _configuration["CustomerAPI:URI"];
            _userName = _configuration["CustomerAPI:UserName"];
            _password = _configuration["CustomerAPI:Password"];

        }

        public async Task<string> AddApiData(Contacts Entity)
        {
            try
            {
                // GET a token from API
                var token = await GetTokenAsync();

                // Serialize the DTO
                var newAPIContact = new CustomerDTO
                {
                    Id = Entity.Contact_Id,
                    FirstName = Entity.FirstName,
                    LastName = Entity.LastName,
                    Email = Entity.Email,
                    PhoneNumber = Entity.PhoneNumber,
                    DOB = (DateTime)Entity.DOB,
                    Gender = Entity.Gender.ToString(),
                    Address = "None Provided"
                };

                var data = JsonConvert.SerializeObject(newAPIContact);

                // Send a GET request to the API to get data
                var request = new HttpRequestMessage(HttpMethod.Post, _baseURL + "/api/v1/Customer/CreateCustomer");
                request.Headers.Add("ApiKey", _apiKey);
                request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", token);
                request.Content = new StringContent(data, Encoding.UTF8, "application/json");


                var response = await _httpClient.SendAsync(request);
                string message = "";
                if (!response.IsSuccessStatusCode) { }
                {
                    message = $"FAILED to add the contact to the API. Status Code: {response.StatusCode} - {response.ReasonPhrase}";
                }
                message = "Successfully sent and added the Contact to the API";
                return message;

            }
            catch (HttpRequestException ex)
            {
                // Log the exception
                Console.WriteLine($"Error: {ex.Message}");
                var message = "Failed to add customer API data due to an HTTP Request error";
                return message;
            }
            catch (Exception ex)
            {
                // Log the exception
                Console.WriteLine($"Error: {ex.Message}");
                var message = "An error occurred while adding customer data to API";
                return message;
            }
            
        }

        public async Task<string> DeleteApiData(Guid Id)
        {
            try
            {
                // GET a token from API
                var token = await GetTokenAsync();

                // Serialize the DTO
               

                // Send a GET request to the API to get data
                var request = new HttpRequestMessage(HttpMethod.Delete, _baseURL + $"/api/v1/Customer/Delete/{Id}");
                request.Headers.Add("ApiKey", _apiKey);
                request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", token);

                var response = await _httpClient.SendAsync(request);
                string message = "";
                if (!response.IsSuccessStatusCode) { }
                {
                    message = $"FAILED to add the contact to the API. Status Code: {response.StatusCode} - {response.ReasonPhrase}";
                }
                message = "Successfully sent and added the Contact to the API";
                return message;

            }
            catch (HttpRequestException ex)
            {
                // Log the exception
                Console.WriteLine($"Error: {ex.Message}");
                var message = "Failed to delete customer API data due to an HTTP Request error";
                return message;
            }
            catch (Exception ex)
            {
                // Log the exception
                Console.WriteLine($"Error: {ex.Message}");
                var message = "An error occurred while deleting customer data to API";
                return message;
            }
        }

        public async Task<string> UpdateApiData(Guid Id, Contacts Entity)
        {
            try
            {
                // GET a token from API
                var token = await GetTokenAsync();

                // Serialize the DTO
                var newAPIContact = new CustomerDTO
                {
                    Id = Id,
                    FirstName = Entity.FirstName,
                    LastName = Entity.LastName,
                    Email = Entity.Email,
                    PhoneNumber = Entity.PhoneNumber,
                    DOB = (DateTime)Entity.DOB,
                    Gender = Entity.Gender.ToString(),
                    Address = "None Provided"
                };

                var data = JsonConvert.SerializeObject(newAPIContact);

                // Send a GET request to the API to get data
                var request = new HttpRequestMessage(HttpMethod.Put, _baseURL + $"/api/v1/Customer/Update/{Id}");
                request.Headers.Add("ApiKey", _apiKey);
                request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", token);
                request.Content = new StringContent(data, Encoding.UTF8, "application/json");


                var response = await _httpClient.SendAsync(request);
                string message = "";
                if (!response.IsSuccessStatusCode) { }
                {
                    message = $"FAILED to update the contact in the API. Status Code: {response.StatusCode} - {response.ReasonPhrase}";
                }
                message = "Successfully sent and added the Contact to the API";
                return message;

            }
            catch (HttpRequestException ex)
            {
                // Log the exception
                Console.WriteLine($"Error: {ex.Message}");
                var message = "Failed to update customer API data due to an HTTP Request error";
                return message;
            }
            catch (Exception ex)
            {
                // Log the exception
                Console.WriteLine($"Error: {ex.Message}");
                var message = "An error occurred while updating customer data to API";
                return message;
            }
        }

        private async Task<string> GetTokenAsync()
        {
            Tokens token;
            try
            {
                //var _URI = _configuration["CustomerAPI:URI"];
                //var _username = _configuration["CustomerAPI:UserName"];
                //var _password = _configuration["CustomerAPI:Password"];
                //var _apiKey = _configuration["CustomerAPI:ApiKey"];

                var json = JsonConvert.SerializeObject(new
                {
                    UserName = _userName,
                    Password = _password
                });

                // Send a POST request to the API to get a token
                var request = new HttpRequestMessage(HttpMethod.Post, _baseURL + "/signin");
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



    }
}
