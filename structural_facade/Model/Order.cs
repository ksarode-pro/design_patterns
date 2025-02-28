namespace facade_demo
{
    public class Order
    {
        public string CustomerId { get; set; }
        public string OrderId { get; set; }
        public double UnitPrice { get; set; }
        public int Quantity { get; set; }
        public double TotalPrice { get; set; }
        public int ProductId { get; set; }
    }
}