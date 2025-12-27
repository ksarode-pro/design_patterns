using System;


namespace factory
{
    #region Factory
    public interface IFactory
    {
        public T GetProduct<T>() where T : IProduct, new();
    }

    public class ProductFactory : IFactory
    {
        public T GetProduct<T>() where T : IProduct, new()
        {
            return new T();
        }
    }
    #endregion

    #region Products
    public interface IProduct
    {
        public string GetProduct();
    }

    class Circle : IProduct
    {
        public string GetProduct()
        {
            return "Circle";
        }
    }

    class Rectangle : IProduct
    {
        public string GetProduct()
        {
            return "Rectangle";
        }
    }
    #endregion

    #region Demo
    class Program
    {
        public static void Main(string[] arg)
        {
            IFactory factory = new ProductFactory();

            IProduct c = factory.GetProduct<Circle>();
            System.Console.WriteLine(c.GetProduct());

            IProduct r = factory.GetProduct<Rectangle>();
            System.Console.WriteLine(r.GetProduct());
        }
    }
    #endregion
}

