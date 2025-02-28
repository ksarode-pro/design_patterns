namespace FactoryPatternDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            ICreditCardFactory creditCardFactory = new CreditCardFactory();
            ICreditCard creditCard = creditCardFactory.GetCreditCard<AxisCreditCard>();
            System.Console.WriteLine(creditCard.DisplayCardDetails());

            creditCard = creditCardFactory.GetCreditCard<IciciCreditCard>();
            System.Console.WriteLine(creditCard.DisplayCardDetails());

            creditCard = creditCardFactory.GetCreditCard<HdfcCreditCard>();
            System.Console.WriteLine(creditCard.DisplayCardDetails());
        }
    }
}