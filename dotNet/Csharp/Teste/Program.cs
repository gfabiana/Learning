using System;

namespace MyApp

{
    class Program
    {
        static void Main(string[] args)
        {
            var mouse = new Product(1, "Mouse Gamer", 169.90, EProductType.Product);
            var maintenance = new Product(3, "Maintenance", 79.9, EProductType.Service);

            mouse.Id = 2;

            Console.WriteLine(mouse.Id);
            Console.WriteLine(mouse.Name);
            Console.WriteLine(mouse.Price);
            Console.WriteLine(mouse.Type);
            Console.WriteLine((int)mouse.Type);

            Console.WriteLine(maintenance.Id);
            Console.WriteLine(maintenance.Name);
            Console.WriteLine(maintenance.Price);
            Console.WriteLine(maintenance.Type);
            Console.WriteLine((int)maintenance.Type);
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

        public double PriceInDolar(double dolar)
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


