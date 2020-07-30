using System;

namespace Singleton
{
    public sealed class UsingLazy
    {
        private static Lazy<UsingLazy> _instance = new Lazy<UsingLazy>(() => new UsingLazy());

        private UsingLazy()
        {

        }

        public static UsingLazy GetInstance()
        {
            return _instance.Value;
        }
    }
}
