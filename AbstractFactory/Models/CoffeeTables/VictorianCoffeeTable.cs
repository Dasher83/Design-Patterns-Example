using AbstractFactory.Interfaces;

namespace AbstractFactory.Models.CoffeeTables
{
    internal class VictorianCoffeeTable : ICoffeeTable
    {
        private readonly byte _legs;

        public VictorianCoffeeTable(byte legs)
        {
            _legs = legs;
        }

        public byte Legs => _legs;

        public void Appreciate()
        {
            string legs = _legs > 0 ? $"{_legs} " : "no ";
            Console.WriteLine($"It's a Victorian style coffee table with {legs}legs!");
            Console.WriteLine();
        }
    }
}
