namespace abstract_factory_demo
{
    class WinButton : IButton
    {
        public void Click()
        {
            System.Console.WriteLine("Windows button is clicked");
        }
    }
}