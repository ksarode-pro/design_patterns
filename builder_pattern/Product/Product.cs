namespace builder_pattern
{
    // This class is a representation of a product; part of the complex object
    public class Product
    {
        public int BrandId { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string TermsAndConditions { get; set; }
    }
}