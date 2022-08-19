namespace Proxy
{
    internal class RealSubject : ISubject
    {
        public void Request()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("RealSubject: Handling Request.");
        }
    }
}
