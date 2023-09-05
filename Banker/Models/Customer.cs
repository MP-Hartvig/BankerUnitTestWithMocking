namespace Banker.Models
{
    public class Customer : Person
    {
        public int CustomerId { get; set; }

        public Customer(int id, string firstName, string lastName, DateTime dateOfBirth, Address address) : base(firstName, lastName, dateOfBirth, address)
        {
            CustomerId = id;
        }
    }
}
