namespace Singleton
{
    public sealed class NestedStaticInstance
    {
        //slight variation of "StaticInstance.cs". In this we achieve perfect Lazy Loading.

        private NestedStaticInstance()
        {

        }

        public static NestedStaticInstance GetInstance()
        {
            return Nested.GetInstance();
        }

        private class Nested
        {
            private static NestedStaticInstance _instance = new NestedStaticInstance();

            static Nested()
            {

            }

            private Nested()
            {

            }

            public static NestedStaticInstance GetInstance()
            {
                return _instance;
            }
        }
    }

    
}
