using System;

namespace AbstractFactory
{
    class PepsiBottle : AbstractBottle
    {
        public override void Interact(AbstractWater water)
        {
            Console.WriteLine(this + " interacts with " + water);
        }

        public override void Interact(AbstractCover cover)
        {
            Console.WriteLine(this + " interacts with " + cover);
        }
    }
}
