namespace decorator_pattern
{
    class Program
    {
        public static void Main(string[] args)
        {
            Margaritta normalPrizza = new Margaritta();
            System.Console.WriteLine(normalPrizza.GetPizza());

            ChickenPizza chickenPizza = new ChickenPizza(normalPrizza);
            System.Console.WriteLine(chickenPizza.GetPizza());
        }
    }
}

public interface IPizza
{
    public string GetPizza();
}

public class Margaritta : IPizza
{
    public string GetPizza()
    {
        return "Perfect fluffy bready + mozerella Cheeze + Unique Tomato Sause";
    }
}

public abstract class PizzaDecorator : IPizza
{
    private IPizza _pizza;

    public PizzaDecorator(IPizza pizza)
    {
        this._pizza = pizza;
    }

    public virtual string GetPizza()
    {
        return _pizza.GetPizza();
    }
}

public class ChickenPizza : PizzaDecorator
{
    private IPizza _pizza;

    public ChickenPizza(IPizza pizza) : base(pizza)
    {
        this._pizza = pizza;
    }

    /*public override string GetPizza()
    {
        return base.GetPizza() + " + Tandoori Chicken"
    }*/

    public override string GetPizza() => base.GetPizza() + " + Tandoori Chicken";
}

