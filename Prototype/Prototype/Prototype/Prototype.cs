namespace Prototype
{
    internal abstract class Prototype
    {
        protected Prototype(int id)
        {
            this.Id = id;
        }

        public int Id { get; private set; }

        public abstract Prototype Clone();

    }
}
