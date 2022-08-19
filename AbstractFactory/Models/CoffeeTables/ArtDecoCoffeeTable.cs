using AbstractFactory.Interfaces;

namespace AbstractFactory.Models.CoffeeTables
{
    internal class ArtDecoCoffeeTable : ICoffeeTable
    {
        private readonly byte _legs;

        public ArtDecoCoffeeTable(byte legs)
        {
            _legs = legs;
        }

        public byte Legs => _legs;

        public void Appreciate()
        {
            string legs = _legs > 0 ? $"{_legs} " : "no ";
            Console.WriteLine($"It's a Art Deco style coffee table with {legs}legs!");
            Console.WriteLine();
        }
    }
}
