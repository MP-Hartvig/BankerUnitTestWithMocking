using Banker.Models;

namespace Banker.Interfaces
{
    public interface IAccountDatahandler
    {
        public bool Withdraw(double withdrawalAmount, BankCard card);
    }
}
