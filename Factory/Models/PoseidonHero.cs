using Factory.Interfaces;

namespace Factory.Models
{
    internal class PoseidonHero : IHero
    {
        public void ShowPowers()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("My father is Poseidon!");
            Console.WriteLine("Breathing under water is second nature");
            Console.WriteLine("Sailing effortlessly the seven seas");
            Console.WriteLine("I can summon tsunamis!");
            Console.WriteLine("I can call forth earthquakes!!");
            Console.ResetColor();
        }
    }
}
