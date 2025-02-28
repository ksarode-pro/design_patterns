namespace facade_demo
{
    public class CustomerApi
    {
        public Customer GetCustomer(int customerId)
        {
            return new Customer
            {
                Id = customerId.ToString(),
                Name = "John Doe",
                Email = "John.Doe@gmail.com",
            };
        }
    }
}