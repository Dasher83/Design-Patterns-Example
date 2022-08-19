using AbstractFactory.Interfaces;
using AbstractFactory.Models.Chairs;
using AbstractFactory.Models.CoffeeTables;
using AbstractFactory.Models.Sofas;

namespace AbstractFactory.Models.Factories
{
    internal class ModernFurnitureFactory : IFurnitureFactory
    {
        public IChair CreateChair(byte legs = 4, bool isReclinable = false)
        {
            IChair chair = new ModernChair(legs: legs, isReclinable: isReclinable);
            return chair;
        }

        public ICoffeeTable CreateCoffeeTable(byte legs = 4)
        {
            ICoffeeTable coffeeTable = new ModernCoffeeTable(legs: legs);
            return coffeeTable;
        }

        public ISofa CreateSofa(byte legs = 4, bool isReclinable = false, bool isSofaBed = false)
        {
            ISofa sofa = new ModernSofa(legs: legs, isReclinable: isReclinable, isSofaBed: isSofaBed);
            return sofa;
        }
    }
}
