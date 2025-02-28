namespace facade_demo
{
    public class OrderApi
    {
        public void GenerateOrder(Customer customer, Order order)
        {
            Console.WriteLine($"Generating order for {customer.Name} with for order# {order.OrderId}");
        }
    }
}