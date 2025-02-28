namespace facade_demo
{
    public class NotificationApi
    {
        public void SendReceipt(Customer customer, Order order)
        {
            Console.WriteLine($"Sending receipt to {customer.Name} on {customer.Email} for for order# {order.OrderId} with total amount {order.TotalPrice}");
        }
    }
}