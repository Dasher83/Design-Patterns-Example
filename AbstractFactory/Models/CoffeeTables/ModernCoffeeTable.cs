using AbstractFactory.Interfaces;

namespace AbstractFactory.Models.CoffeeTables
{
    internal class ModernCoffeeTable : ICoffeeTable
    {
        private readonly byte _legs;

        public ModernCoffeeTable(byte legs)
        {
            _legs = legs;
        }

        public byte Legs => _legs;

        public void Appreciate()
        {
            string legs = _legs > 0 ? $"{_legs} " : "no ";
            Console.WriteLine($"It's a Modern style coffee table with {legs}legs!");
            Console.WriteLine();
        }
    }
}
