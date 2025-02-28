namespace builder_pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a catalog item builder
            ICatalogItemBuilder catalogItemBuilder = new CatalogItemBuilder();

            // Set the brand
            catalogItemBuilder.SetBrand(1);

            // Set the products
            catalogItemBuilder.SetProducts(1);

            // Build the catalog item
            CatalogItem catalogItem = catalogItemBuilder.Build();

            // Display the catalog item
            Console.WriteLine("Catalog Item:");
            Console.WriteLine("Brand: " + catalogItem.Brand.BrandName);
            Console.WriteLine("Products: ");
            foreach (Product product in catalogItem.Products)
            {
                Console.WriteLine("Product Id: " + product.ProductId);
                Console.WriteLine("Product Name: " + product.ProductName);
                Console.WriteLine("Description: " + product.Description);
                Console.WriteLine("Price: " + product.Price);
                Console.WriteLine("Terms and Conditions: " + product.TermsAndConditions);
            }
        }
    }
}
