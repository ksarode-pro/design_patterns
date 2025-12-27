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

//Existing class
public class Margaritta : IPizza
{
    public string GetPizza()
    {
        return "Perfect fluffy bready + mozerella Cheeze + Unique Tomato Sause";
    }
}

//Decorator which allows to reuse functionality from existing class  
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

//New class with modified functonality without modifying existing class - Open/Close principle demonstrated
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

