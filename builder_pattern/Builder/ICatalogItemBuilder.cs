namespace builder_pattern
{
    // This interface is used to define the methods that are used to build the complex object
    public interface ICatalogItemBuilder
    {
        // This method is used to set the brand
        public void SetBrand(int brandId);
        // This method is used to set the products
        public void SetProducts(int brandId);
        // This method is used to return the complex object
        public CatalogItem Build();
    }
}