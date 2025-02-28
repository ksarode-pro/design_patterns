namespace abstract_factory_demo
{
    // This class is a concrete implementation of the IWinFactory interface.
    // It creates WinButton and WinTextbox objects.
    class WinFactory : IWinFactory
    {
        public IButton CreateButton()
        {
            return new WinButton();
        }

        public ITextbox CreateTextbox()
        {
            return new WinTextbox();
        }
    }
}