using System.ComponentModel;

namespace builder_pattern
{
    // This is a complex object that is built by the builder
    public class CatalogItem
    {
        public Brand Brand { get; set; }
        public List<Product> Products { get; set; }
    }
}