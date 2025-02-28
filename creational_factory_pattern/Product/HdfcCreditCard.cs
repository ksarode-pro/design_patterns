namespace FactoryPatternDemo
{
    public class HdfcCreditCard : ICreditCard
    {
        public string DisplayCardDetails()
        {
            return "HDFC Credit Card";
        }
    }
}