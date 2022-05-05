using WebApplication3.Models;
namespace WebApplication3.Data
{
    public class DbInitializer
    {
        public static void Initialize(BankContext context)
        {
            // Look for any students.
            if (context.Transactions.Any())
            {
                return;   // DB has been seeded
            }

            var transactions = new Transaction[]
            {
                new Transaction{TransactionDate=DateTime.Parse("2021-11-01"),TransactionType="DR",Amount="-2.00", Location="MO", Description="Starbucks"},
                new Transaction{TransactionDate=DateTime.Parse("2021-11-01"),TransactionType="CR",Amount="800.00", Location="MO", Description="Payroll"},
                new Transaction{TransactionDate=DateTime.Parse("2021-11-01"),TransactionType="DR",Amount="-8.00", Location="MO", Description="Chipotle"},
                new Transaction{TransactionDate=DateTime.Parse("2021-11-01"),TransactionType="DR",Amount="-10.00", Location="MO", Description="ATM"},
                new Transaction{TransactionDate=DateTime.Parse("2021-11-01"),TransactionType="DR",Amount="-32.00", Location="KS", Description="Hoolihans"},
                new Transaction{TransactionDate=DateTime.Parse("2021-11-01"),TransactionType="DR",Amount="-100.00", Location="MO", Description="KCPL"},
                new Transaction{TransactionDate=DateTime.Parse("2021-11-01"),TransactionType="DR",Amount="-190.00", Location="MO", Description="Google Fiber"},
                new Transaction{TransactionDate=DateTime.Parse("2021-11-01"),TransactionType="DR",Amount="-9.99", Location="MO", Description="Netflix"},
            };

            context.Transactions.AddRange(transactions);
            context.SaveChanges();
        }
    }
}
