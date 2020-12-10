using System;

namespace MeuApp
{
    class Program
    {
        static void Main(string[] args)
        {
             Product product = new Product(15, "Black Widow", 185.0, EProductType.Service);

             Console.WriteLine(product.Id);
             Console.WriteLine(product.Name);
             Console.WriteLine(product.PriceInDolar(5.70f));
             Console.WriteLine(product.Type);
        }
    }

    struct Product
    {
        public Product(int id, string name, double price, EProductType type)
        {
            Id = id;
            Name = name;
            Price = price;
            Type = type;
        }
        public int Id;
        public string Name;
        public double Price;
        public EProductType Type;

        public double PriceInDolar (double dolar)
        {
            return Price * dolar;
        }
    }   

    enum EProductType
    {
        Product = 1,
        Service = 2
    }
}

