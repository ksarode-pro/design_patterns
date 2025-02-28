
namespace builder_pattern
{
    /// <summary>
    /// This class is used to build the complex object
    /// </summary>
    class CatalogItemBuilder : ICatalogItemBuilder
    {
        CatalogItem catalogItem = new CatalogItem();
        Brand brand = new Brand();
        List<Product> products = new List<Product>();
        /// <summary>
        /// This method is used to set the brand
        /// </summary>
        /// <param name="brandId">brnad is which can be used to fetch brand data</param>
        public void SetBrand(int brandId)
        {
            // Fetch brand from the database or from a service
            brand.BrandId = 1;
            brand.BrandName = "Brand 1";
            brand.BrandDescription = "Brand 1 Description";
            brand.BrandStoreData = "Brand 1 Store Data";
        }
        /// <summary>
        /// This method is used to set the products
        /// </summary>
        /// <param name="brandId">brandId is which can be used to fetch products</param>       
        public void SetProducts(int brandId)
        {
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
        }
        /// <summary>
        /// This method is used to return the complex object
        /// </summary>
        /// <returns>complex opbject i.e catalog item</returns>
        public CatalogItem Build()
        {
            catalogItem.Brand = brand;
            catalogItem.Products = products;
            return catalogItem;
        }
    }

}