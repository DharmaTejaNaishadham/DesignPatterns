namespace Singleton
{
    public sealed class StaticInstance
    {
        private static StaticInstance _instance = new StaticInstance();

        //If not for the static constructor, the Type "StaticInstance" would've been marked "beforefieldinit".
        //Meaning, _instance would've obtained value even before anyone referred to the Type "StaticInstance" or method "GetInstance()".

        //Static constructor in C# is specified to execute only when an instance of the class is created or a static member is referenced, 
        //and to execute only once per AppDomain.

        //As we've made the constructor private (default), no one can create an instance of this class.

        //Thus, having a static constructor is serving as a Lazy Loader. Not a perfect one though.
        //Reason - Had this class any other static members, any reference to them would've instantiated _instance
        static StaticInstance()
        {

        }

        private StaticInstance()
        {

        }

        public static StaticInstance GetInstance()
        {
            return _instance;
        }
    }
}
