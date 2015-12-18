using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            IBuilder builder = new ConcreteBuilder();
            Director director = new Director(builder);
            director.Construct();
            Product product = builder.GetResult();
            product.Show();

            Console.ReadKey();
        }
    }
}
