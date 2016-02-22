using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            var instance1 = Singleton.Instance;
            var instance2 = Singleton.Instance;

            instance1.IncrementRate();
            instance2.IncrementRate();

            Console.WriteLine(ReferenceEquals(instance1, instance2));
            Console.WriteLine(instance2.GetRate());

            Console.ReadKey();
        }
    }
}
