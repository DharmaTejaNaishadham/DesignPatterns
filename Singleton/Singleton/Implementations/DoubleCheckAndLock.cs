namespace Singleton
{
    //sealed as we don't want any other class to inherit this
    public sealed class DoubleCheckAndLock
    {
        private static DoubleCheckAndLock _instance = null;

        private static object padlock = new object();

        private DoubleCheckAndLock()
        {            
        }

        public static DoubleCheckAndLock GetInstance()
        {
            if (_instance == null)//avoiding unnecessary locking when _instance is not null
            {
                lock (padlock)//ensure only 1 thread enters the below block at a time
                {
                    if (_instance == null)//it is possible that more than 1 thread could clear this
                    {
                        _instance = new DoubleCheckAndLock();
                    }
                }
            }

            return _instance;
        }
    }
}
