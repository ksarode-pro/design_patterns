namespace abstract_factory_demo
{
    class MacTextbox : ITextbox
    {
        public void TextChange()
        {
            System.Console.WriteLine("Mac OS textbox is inputted");
        }
    }
}