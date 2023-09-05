namespace Banker.Models
{
    public class BankCard
    {
        public string CardNumber { get; set; }
        public string PinCode { get; set; }
        public Account Account { get; set; }

        public BankCard(string cardNumber, string pinCode, Account account)
        {
            CardNumber = cardNumber;
            PinCode = pinCode;
            Account = account;
        }
    }
}
