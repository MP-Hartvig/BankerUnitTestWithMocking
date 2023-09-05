namespace Banker.Models
{
    public class Address
    {
        public string streetName { get; private set; }
        public string streetNumber { get; private set; }
        public string zipCode { get; private set; }

        public Address(string streetNameIn, string streetNumberIn, string zipCodeIn)
        {
            streetName = streetNameIn;
            streetNumber = streetNumberIn;
            zipCode = zipCodeIn;
        }
    }
}
