// See https://aka.ms/new-console-template for more information
namespace Evolent.Evolent;

internal class Program
{
    private static void Main(string[] args)
    {
        PersonHandler handler = new PersonHandler();
        Console.WriteLine(handler.GetPersons());
    }
}

