namespace Singleton
{
    internal class Connection
    {
        private static Connection? instance;

        private Connection() { }

        public static Connection Instance { 
            get { 
                if(instance == null)
                {
                    instance = new Connection();
                }
                return instance; 
            } 
        }

        public void Connect()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"I just established a healthy connection...");
            Console.ResetColor();
        }

        public void Disconnect()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"I just disconnected successfully... !!");
            Console.ResetColor();
        }
    }
}
