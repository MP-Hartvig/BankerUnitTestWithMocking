using Banker.Validators;

namespace BankerUnitTest
{
    public class AccountBalanceValidatorTests
    {
        AccountBalanceValidator abv = new AccountBalanceValidator();

        [Theory]
        [InlineData(200.0, 300.0, true)]
        [InlineData(500.00, 500.0, true)]
        [InlineData(750.00, 500.0, false)]
        [InlineData(50.0, 500.0, true)]
        [InlineData(double.MaxValue, double.MaxValue, true)]
        [InlineData(double.MinValue, double.MaxValue, false)]
        [InlineData(0, 100, false)]
        [InlineData(-100, 300, false)]
        public void ValidateWithdraw_ShouldValidateOnCorrectInput(double withDrawalAmount, double accountBalance, bool expected)
        {
            // Act
            bool actual = abv.ValidateWithdraw(withDrawalAmount, accountBalance);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
