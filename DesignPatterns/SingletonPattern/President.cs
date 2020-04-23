namespace DesignPatterns.SingletonPattern
{
    public abstract class President
    {
    }

    public class Singleton<T> where T : President, new()
    {
        private Singleton()
        {
        }

        public static T Instance()
        {
            return Nested.Instance;
        }

        private class Nested
        {
            internal static readonly T Instance;

            static Nested()
            {
                Instance = new T();
            }
        }
    }

    public class FrenchPresident : President
    {
        
    }
}