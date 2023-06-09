﻿namespace CustomersAPI.DTO
{
    public class CustomerTransactionDTO
    {
        public Guid CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime? DOB { get; set; }
        public List<TransactionDTO> Transactions { get; set; }

        public CustomerTransactionDTO()
        {
            
        }
    }
}
