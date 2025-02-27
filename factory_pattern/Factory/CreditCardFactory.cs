namespace FactoryPatternDemo
{
    // This is the Factory class
    class CreditCardFactory : ICreditCardFactory
    {
        // Factory method, constraint T to ICreditCard and new() - T should have a parameterless constructor to create instance
        public ICreditCard GetCreditCard<T>() where T : ICreditCard, new()
        {
            return new T();
        }
    }
}