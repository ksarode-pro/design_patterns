namespace abstract_factory_demo
{
    class WinTextbox : ITextbox
    {
        public void TextChange()
        {
            System.Console.WriteLine("Windows textbox is inputted");
        }
    }
}