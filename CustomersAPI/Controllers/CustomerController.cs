using CustomersAPI.DTO;
using CustomersAPI.Models;
using CustomersAPI.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CustomersAPI.Controllers
{
    [Authorize]
    [Route("api/v1/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {

        private readonly ICustomerDBRepository _custDBRepository;
        private readonly CustomerTransactionService _transactionService;
        private readonly ILogger<CustomerController> _logger;

        public CustomerController(ICustomerDBRepository custDBRepository,
                                     ILogger<CustomerController> logger,
                                     CustomerTransactionService transactionService)
        {
            _custDBRepository = custDBRepository;
            _transactionService = transactionService;
            _logger = logger;
        }


        //GET ALL CUSTOMER
        [HttpGet("CustomerList")]
        public async Task<IActionResult> GetAllCustomers()
        {
            _logger.LogInformation("Request received from user: {user} to get the complete customer list.", User.Identity.Name);
            return Ok(await _custDBRepository.GetAllCustomersAsync());
        }

        //GET ALL CUSTOMERE WITH TRANSACTION LIST
        [HttpGet("CustomerListwithTransactions")]
        public async Task<IActionResult> GetAllTransactions()
        {
            _logger.LogInformation("Request received from user: {user} to get the complete transactions list.", User.Identity.Name);

            return Ok(await _transactionService.GetCustomersAndTransactionAsync());
        }

        [HttpGet("Get/{id}")]
        public async Task<IActionResult> GetCustomerById(Guid id)
        {
            _logger.LogInformation("Request received from user: {user} to get the customer by ID: {id}", User.Identity.Name, id);
            var customer = await _custDBRepository.GetbyIdAsync(id);
            if (customer == null)
            {
                return NotFound();
            }
            return Ok(customer);
        }


        [HttpPost("CreateCustomer")]
        public async Task<IActionResult> CreateCustomer([FromBody] CustomerDTO customerDto)
        {
            _logger.LogInformation("Request received from user: {user} to create customer", User.Identity.Name);
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var customer = new Customer
            {
                Contact_Id = customerDto.Id != Guid.Empty ? customerDto.Id.Value : Guid.NewGuid(),
                FirstName = customerDto.FirstName,
                LastName = customerDto.LastName,
                Gender = customerDto.Gender,
                DOB = customerDto.DOB,
                Email = customerDto.Email,
                PhoneNumber = customerDto.PhoneNumber,
                Address = customerDto.Address,
                CreateDate = DateTime.Now,
                UpdateDate = DateTime.Now
            };
            await _custDBRepository.CreateAsync(customer);
            return CreatedAtAction(nameof(GetCustomerById), new { id = customer.Contact_Id }, customer);
        }


        [HttpPut("Update/{id}")]
        public async Task<IActionResult> UpdateCustomer(Guid id, [FromBody] CustomerDTO customerDto)
        {
            _logger.LogInformation("Request received from user: {user} to update customer by ID: {id}", User.Identity.Name, id);
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var customer = await _custDBRepository.GetbyIdAsync(id);
            if (customer == null)
            {
                return NotFound();
            }
            customer.FirstName = customerDto.FirstName;
            customer.LastName = customerDto.LastName;
            customer.Gender = customerDto.Gender;
            customer.DOB = customerDto.DOB;
            customer.Email = customerDto.Email;
            customer.PhoneNumber = customerDto.PhoneNumber;
            customer.Address = customerDto.Address;
            customer.UpdateDate = DateTime.Now;
            await _custDBRepository.UpdateAsync(customer);
            return Ok(customer);
        }

        [HttpDelete("Delete/{id}")]
        public async Task<IActionResult> DeleteCustomer(Guid id)
        {
            _logger.LogInformation("Request received from user: {user} to delete customer by ID: {id}", User.Identity.Name, id);

            var customer = await _custDBRepository.GetbyIdAsync(id);
            if (customer == null)
            {
                return NotFound();
            }

            await _custDBRepository.DeleteAsync(customer.Contact_Id);

            return NoContent();
        }



    }
}

