namespace Pluralsight.DesignPatterns.Singleton
{
    //Thread safe
    public class LazySingleton
    {
        private LazySingleton()
        { }

        public static LazySingleton Instance
        {
            get { return Nested.instance; }
        }

        private class Nested
        {
            //Static constructor is important to not have BeforeFieldInit flag in C# compiler
            static Nested()
            {
            }

            internal static readonly LazySingleton instance = new LazySingleton();
        }
    }
}
