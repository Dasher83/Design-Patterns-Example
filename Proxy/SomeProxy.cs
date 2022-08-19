namespace Proxy
{
    internal class SomeProxy : ISubject
    {
        private RealSubject _realSubject;

        public SomeProxy(RealSubject realSubject)
        {
            _realSubject = realSubject;
        }

        public bool CheckAccess()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Proxy: Checking access prior to firing a real request...");
            Random random = new Random();
            float accessLevel = random.NextSingle();
            if (accessLevel > 0.5)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Proxy: access granted.");
                return true;
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Proxy: access denied!");
            Console.ResetColor();
            return false;
        }

        public void LogAccess()
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Proxy: Logging the time of request.");
            Console.ResetColor();
        }

        public void Request()
        {
            if (CheckAccess())
            {
                _realSubject.Request();

                LogAccess();
            }
        }
    }
}
