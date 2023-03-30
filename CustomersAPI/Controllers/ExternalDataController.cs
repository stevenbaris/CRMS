using CustomersAPI.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CustomersAPI.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class ExternalDataController : ControllerBase
    {

        ICustomerDBRepository _custDBRepository;
        CustomerTransactionService _transactionService;
        private readonly ILogger<ExternalDataController> _logger;

        public ExternalDataController(ICustomerDBRepository custDBRepository,
                                     ILogger<ExternalDataController> logger,
                                     CustomerTransactionService transactionService)
        {
            _custDBRepository = custDBRepository;
            _transactionService = transactionService;
            _logger = logger;
        }

        [HttpGet("Customer")]
        public async Task<IActionResult> GetAllCustomers()
        {
            _logger.LogInformation("Request received from user: {user} to get the complete customer list.", User.Identity.Name);
            return  Ok(await _custDBRepository.GetAllCustomersAsync()); // json or xml
        }

        [HttpGet("Transactions")]
        public async Task<IActionResult> GetAllTransactions()
        {
            _logger.LogInformation("Request received from user: {user} to get the complete transactions list.", User.Identity.Name);

            return Ok(await _transactionService.GetCustomersAndTransactionAsync()); // json or xml
        }


    }
}

