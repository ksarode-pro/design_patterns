
namespace builder_pattern
{
    /// <summary>
    /// This class is used to build the complex object
    /// </summary>
    class CatalogItemBuilder : ICatalogItemBuilder
    {
        private CatalogItem catalogItem = new CatalogItem();

        /// <summary>
        /// This method is used to set the brand
        /// </summary>
        /// <param name="brandId">brnad is which can be used to fetch brand data</param>
        public void BuildBrand(int brandId)
        {
            Brand brand = new Brand();
            // Fetch brand from the database or from a service
            brand.BrandId = 1;
            brand.BrandName = "Brand 1";
            brand.BrandDescription = "Brand 1 Description";
            brand.BrandStoreData = "Brand 1 Store Data";

            catalogItem.Brand = brand;

        }
        /// <summary>
        /// This method is used to set the products
        /// </summary>
        /// <param name="brandId">brandId is which can be used to fetch products</param>       
        public void BuildProducts(int brandId)
        {
            List<Product> products = new List<Product>();
            // Fetch products from the database or from a service
            products.Add(new Product
            {
                BrandId = 1,
                ProductId = 1,
                ProductName = "Product 1",
                Description = "Product 1 Description",
                Price = 100.00,
                TermsAndConditions = "Product 1 Terms and Conditions"
            });
            products.Add(new Product
            {
                BrandId = 1,
                ProductId = 2,
                ProductName = "Product 2",
                Description = "Product 2 Description",
                Price = 200.00,
                TermsAndConditions = "Product 2 Terms and Conditions"
            });
            products.Add(new Product
            {
                BrandId = 1,
                ProductId = 3,
                ProductName = "Product 3",
                Description = "Product 3 Description",
                Price = 300.00,
                TermsAndConditions = "Product 3 Terms and Conditions"
            });

            catalogItem.Products = products;
        }
        /// <summary>
        /// This method is used to return the complex object
        /// </summary>
        /// <returns>return the complex object</returns>
        public CatalogItem GetCatalogItem()
        {
            return catalogItem;
        }
    }
}