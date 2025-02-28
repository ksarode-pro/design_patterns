namespace abstract_factory_demo
{
    class Program
    {
        static void Main(string[] args)
        {
            IUIFactory factory = new WinFactory();
            IButton button = factory.CreateButton();
            ITextbox textbox = factory.CreateTextbox();
            button.Click();
            textbox.TextChange();

            factory = new MacFactory();
            button = factory.CreateButton();
            textbox = factory.CreateTextbox();
            button.Click();
            textbox.TextChange();
        }
    }
}