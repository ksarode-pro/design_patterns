namespace abstract_factory_demo
{
    // MacFactory is concrete factory for Mac OS products 
    class MacFactory : IMacFactory
    {
        public IButton CreateButton()
        {
            return new MacButton();
        }

        public ITextbox CreateTextbox()
        {
            return new MacTextbox();
        }
    }
}