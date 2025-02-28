namespace facade_demo
{
    public class InvoiceApi
    {
        public void CreateInvoice(Customer customer, Order order)
        {
            Console.WriteLine($"Creating invoice for {customer.Name} for order# {order.OrderId}");
        }
    }
}