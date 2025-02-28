namespace builder_pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new builder
            ICatalogItemBuilder catalogItemBuilder = new CatalogItemBuilder();
            // Create a new director
            CatalogItemDirector catalogItemDirector = new CatalogItemDirector(catalogItemBuilder);
            // Build the complex object
            catalogItemDirector.BuildCatalogItem(1);
            // Get the complex object
            CatalogItem catalogItem = catalogItemBuilder.GetCatalogItem();
            // Print the complex object
            Console.WriteLine("Brand: " + catalogItem.Brand.BrandName);
            Console.WriteLine("BrandDesc: " + catalogItem.Brand.BrandDescription);
            Console.WriteLine("BrandStoreData: " + catalogItem.Brand.BrandStoreData);
            foreach (Product product in catalogItem.Products)
            {
                Console.WriteLine("Product: " + product.ProductName);
                Console.WriteLine("ProductDesc: " + product.Description);
                Console.WriteLine("ProductPrice: " + product.Price);
                Console.WriteLine("ProductTerms: " + product.TermsAndConditions);
            }
        }
    }
}
