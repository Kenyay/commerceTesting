namespace WebApplication3.Models
{
    public class Account
    {
        public int AccountID { get; set; }
        public int TransactionID { get; set; }

        public Transaction Transaction { get; set; }
    }
}
