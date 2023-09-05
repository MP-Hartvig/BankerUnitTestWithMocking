using Autofac.Extras.Moq;
using Banker.Datahandlers;
using Banker.Interfaces;
using Banker.Models;
using Banker.Validators;

namespace BankerUnitTest
{
    public class PinValidatorTests
    {
        PinValidator pv = new PinValidator();

        [Theory]
        [InlineData("1234", "1234", true)]
        [InlineData("0820", "1234", false)]
        [InlineData("0033", "0033", true)]
        [InlineData("12345", "1234", false)]
        [InlineData("3RT8", "1234", false)]
        [InlineData("12.34", "1234", false)]
        public void ValidatePin_ShouldValidateOnCorrectInput(string inputPin, string dbPin, bool expected)
        {
            // Act
            bool actual = pv.ValidatePin(inputPin, dbPin);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GetPin_ValidCall()
        {
            bool expected = true;

            using (var mock = AutoMock.GetLoose())
            {
                mock.Mock<IPinDatahandler>().Setup(x => x.GetPin(GetSampleCard())).Returns(GetSamplePin);

                var datahandler = mock.Create<PinDatahandler>();
                var actual = datahandler.ValidatePin(GetSamplePin(), GetSampleCard());

                Assert.Equal(actual, expected);
            }
        }

        private string GetSamplePin()
        {
            return "1234";
        }

        private BankCard GetSampleCard()
        {
            return new BankCard("057510809035", "1234", GetSampleAccount());
        }

        private Account GetSampleAccount()
        {
            return new Account(12345678, 1000, GetSampleCustomer());
        }

        private Customer GetSampleCustomer()
        {
            return new Customer(1, "Brian", "Briansen", DateTime.Now, GetSampleAddress());
        }

        private Address GetSampleAddress()
        {
            return new Address("Testvej", "12", "4600");
        }
    }
}
