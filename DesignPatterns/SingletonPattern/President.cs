namespace DesignPatterns.SingletonPattern
{
    public abstract class President
    {
    }

    public abstract class Singleton<T> where T : Singleton<T>, new()
    {
        protected Singleton()
        {
        }

        public static T Instance()
        {
            return Nested.Instance;
        }

        private class Nested
        {
            public static readonly T Instance;

            static Nested()
            {
                Instance = new T();
            }
        }
    }

    public class FrenchPresident : Singleton<FrenchPresident>
    {
        
    }
    
    public class UsaPresident : Singleton<UsaPresident>
    {
        
    }
}