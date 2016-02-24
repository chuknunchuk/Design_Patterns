using System;

namespace Singleton
{
    class LazySingleton
    {
        private static readonly Lazy<LazySingleton> instance = new Lazy<LazySingleton>(() => new LazySingleton());

        private LazySingleton()
        {
        }

        public static LazySingleton Instance
        {
            get { return instance.Value; }
        }
    }
}
