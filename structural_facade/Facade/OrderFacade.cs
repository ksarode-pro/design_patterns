namespace facade_demo
{
    // The Facade class provides a simple interface to the complex logic of the subsystems.
    public class OrderFacade
    {
        private InvoiceApi _invoiceApi;
        private OrderApi _orderApi;
        private NotificationApi _notificationApi;
        private PaymentApi _paymentApi;

        public OrderFacade()
        {
            _invoiceApi = new InvoiceApi();
            _orderApi = new OrderApi();
            _notificationApi = new NotificationApi();
            _paymentApi = new PaymentApi();
        }

        // The Facade's methods are convenient shortcuts to the sophisticated functionality of the subsystems.
        public void CreateOrder(Customer customer, Order order)
        {
            if (_paymentApi.ConfirmPaymentSuccess(order))
            {
                _orderApi.GenerateOrder(customer, order);
                _invoiceApi.CreateInvoice(customer, order);
                _notificationApi.SendReceipt(customer, order);
            }
            else
            {
                Console.WriteLine("Payment failed. Order not created.");
            }
        }
    }
}