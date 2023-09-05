namespace Banker.Models
{
    public class Account
    {
        public int AccountNumber { get; set; }

        public double AccountBalance { get; set; }

        public Customer Customer { get; set; }

        public Account(int accountNumber, double accountBalance, Customer customer)
        {
            AccountNumber = accountNumber;
            AccountBalance = accountBalance;
            Customer = customer;
        }
    }
}
