namespace CRMS.Models
{
    public class RollingTransactions
    {
        //PROPERTIES
        public Guid? RollingTransactions_ID { get; set; }
        public Decimal? TransacationTotal { get; set; }
        public Guid? ContactId { get; set; } // FOREIGN KEY

        //FOREIGN ENTITY
        public Contacts? Contacts { get; set; }


        //CONTRUCTORS
        public RollingTransactions() { }

        public RollingTransactions(Guid rollingTransactionsID, decimal transacationTotal, Guid contactId)
        {
            RollingTransactions_ID = rollingTransactionsID;
            TransacationTotal = transacationTotal;
            ContactId = contactId;
        }
    }
}
