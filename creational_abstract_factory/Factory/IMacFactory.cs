namespace abstract_factory_demo
{
    // The IMacFactory interface is a sub-interface of the IUIFactory interface.
    interface IMacFactory : IUIFactory
    {
        IButton CreateButton();
        ITextbox CreateTextbox();
    }
}