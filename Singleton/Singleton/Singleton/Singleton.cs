namespace Singleton
{
    class Singleton
    {
        static Singleton instance;
        int rate = 0;

        protected Singleton()
        {
        }

        public static Singleton Instance {
            get
            {
                if (instance == null)
                    instance = new Singleton();

                return instance;
            }
        }

        public void IncrementRate()
        {
            rate++;
        }

        public int GetRate()
        {
            return rate;
        }
    }
}
