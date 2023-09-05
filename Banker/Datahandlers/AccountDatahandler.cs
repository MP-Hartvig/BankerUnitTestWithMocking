using Banker.Interfaces;
using Banker.Models;
using Banker.Validators;

namespace Banker.Datahandlers
{
    public class AccountDatahandler : IAccountDatahandler
    {
        AccountBalanceValidator abv = new AccountBalanceValidator();

        public bool Withdraw(double withdrawalAmount, BankCard card)
        {
            double accountBalance = GetBalance(card);

            return abv.ValidateWithdraw(withdrawalAmount, accountBalance);
        }

        private double GetBalance(BankCard card)
        {
            // Get balance from db instead of hardcoded
            return 1000.0;
        }
    }
}
