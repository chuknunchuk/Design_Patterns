namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            var creator = new ConcreteCreator();
            var product = creator.FactoryMethod();

            creator.AnOperation();
        }
    }
}
