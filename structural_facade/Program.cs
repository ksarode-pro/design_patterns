using facade_demo;

var customer = new CustomerApi().GetCustomer(1);
var order_facades = new OrderFacade();
order_facades.CreateOrder(customer, new Order
{
    CustomerId = customer.Id,
    OrderId = "1",
    UnitPrice = 100,
    Quantity = 2,
    TotalPrice = 200,
    ProductId = 1
});

