using System.Diagnostics;

namespace Banker.Validators
{
    public class AccountBalanceValidator
    {
        public bool ValidateWithdraw(double withdrawalAmount, double accountBalance)
        {
            try
            {
                if (withdrawalAmount <= double.MaxValue && withdrawalAmount > 0)
                {
                    if (withdrawalAmount <= accountBalance)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Value was greater than double.MaxValue, 0 or negative");
                }
            }
            catch (ArgumentOutOfRangeException e)
            {
                Debug.WriteLine(e.Message);
                return false;
            }

        }
    }
}
