using Factory.Interfaces;

namespace Factory.Models
{
    internal class ZeusHero : IHero
    {
        public void ShowPowers()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("My father is Zeus!");
            Console.WriteLine("I can fly and call forth lighting storms!");
            Console.WriteLine("Electric shocks are at my beck and call!");
            Console.ResetColor();
        }
    }
}
