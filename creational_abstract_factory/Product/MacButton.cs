namespace abstract_factory_demo
{
    class MacButton : IButton
    {
        public void Click()
        {
            System.Console.WriteLine("Mac OS button is clicked");
        }
    }
}