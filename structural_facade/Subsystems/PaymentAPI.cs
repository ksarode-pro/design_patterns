namespace facade_demo
{
    public class PaymentApi
    {
        public bool ConfirmPaymentSuccess(Order order)
        {
            Console.WriteLine($"Confirming payment for order# {order.OrderId} with total amount {order.TotalPrice}");
            return true;
        }
    }
}