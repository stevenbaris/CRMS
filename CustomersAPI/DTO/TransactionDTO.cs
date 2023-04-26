namespace CustomersAPI.DTO
{
    public class TransactionDTO
    {
        public Guid TransactionID { get; set; }
        public decimal Amount { get; set; }

        public TransactionDTO()
        {
            
        }
    }
}
