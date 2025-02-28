namespace abstract_factory_demo
{
    // The abstract factory interface declares a set of methods that 
    // return different abstract products.
    // These products are called a family 
    // and are related by a high-level theme or concept.
    interface IUIFactory
    {
        IButton CreateButton();
        ITextbox CreateTextbox();
    }
}