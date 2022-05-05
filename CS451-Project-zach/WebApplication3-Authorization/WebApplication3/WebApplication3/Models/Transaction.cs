namespace WebApplication3.Models
{
    public class Transaction
    {
        public int ID { get; set; }
        public DateTime TransactionDate { get; set; }
        public string TransactionType { get; set; }
        public string Amount { get; set; }
        public string Location { get; set; }
        public string Description { get; set; }
        
        public ICollection<Account> Accounts { get; set; }
    }
}
