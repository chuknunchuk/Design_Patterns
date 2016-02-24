using System.Threading;

namespace Singleton
{
    class ThreadSafeSingleton
    {
        private static volatile ThreadSafeSingleton instance;
        private static Mutex mutex = new Mutex();

        private ThreadSafeSingleton()
        {}

        public static ThreadSafeSingleton Instance
        {
            get
            {
                mutex.WaitOne();
                if (instance == null)
                    instance = new ThreadSafeSingleton();
                mutex.ReleaseMutex();
                return instance;
            }
        }

    }
}
