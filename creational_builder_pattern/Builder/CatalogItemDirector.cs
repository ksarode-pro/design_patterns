namespace builder_pattern
{
    // This class is used to direct the building of the complex object
    public class CatalogItemDirector
    {
        private ICatalogItemBuilder _builder;

        // This method is used to set the builder
        public CatalogItemDirector(ICatalogItemBuilder builder)
        {
            _builder = builder;
        }

        // This method is used to build the complex object
        public CatalogItem BuildCatalogItem(int brandId)
        {
            _builder.BuildBrand(brandId);
            _builder.BuildProducts(brandId);
            return _builder.GetCatalogItem();
        }
    }
}