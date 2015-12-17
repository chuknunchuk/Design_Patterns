namespace AbstractFactory
{
    class Client
    {
        private AbstractWater water;
        private AbstractBottle bottle;
        private AbstractCover cover;

        public Client(AbstractFactory factory)
        {
            this.water = factory.CreateWater();
            this.bottle = factory.CreateBottle();
            this.cover = factory.CreateCover();
        }

        public void Run()
        {
            bottle.Interact(water);
            bottle.Interact(cover);
        }
    }
}
