using System.ComponentModel.DataAnnotations;

namespace CustomersAPI.Models
{
    public class Transactions
    {
        public Transactions()
        {
            
        }


        public Guid Transaction_Id { get; set; } = Guid.NewGuid();

        [Required]
        public DateTime? TransactionDate { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "₱{0:N2}")]
        public Decimal Amount { get; set; }

        public Guid ContactId { get; set; }
        public Customer Customer { get; set; }





        public Transactions(Guid id, DateTime transactionDate, Decimal amount, Guid customerId)
        {
            Transaction_Id = id;
            TransactionDate = transactionDate;
            Amount = amount;
            ContactId = customerId;
        }
    }
}
