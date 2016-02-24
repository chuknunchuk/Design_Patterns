using System;
using System.Threading;

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
            Console.WriteLine();

            var lazyInstance1 = Singleton.Instance;
            var lazyInstance2 = Singleton.Instance;

            Console.WriteLine(lazyInstance1.GetHashCode());
            Console.WriteLine(lazyInstance2.GetHashCode());
            Console.WriteLine();

            Thread[] threads = {
                                   new Thread(TestMethod),
                                   new Thread(TestMethod)
                               };

            foreach (Thread thread in threads)
            {
                thread.Start();
            }

            // Delay.
            Console.ReadKey();
        }

        static void TestMethod()
        {
            ThreadSafeSingleton singleton = ThreadSafeSingleton.Instance;
            Console.WriteLine(singleton.GetHashCode());
        }
    }
}
