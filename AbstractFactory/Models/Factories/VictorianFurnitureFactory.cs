using AbstractFactory.Interfaces;
using AbstractFactory.Models.Chairs;
using AbstractFactory.Models.CoffeeTables;
using AbstractFactory.Models.Sofas;

namespace AbstractFactory.Models.Factories
{
    internal class VictorianFurnitureFactory : IFurnitureFactory
    {
        public IChair CreateChair(byte legs = 4, bool isReclinable = false)
        {
            IChair chair = new VictorianChair(legs: legs, isReclinable: isReclinable);
            return chair;
        }

        public ICoffeeTable CreateCoffeeTable(byte legs = 4)
        {
            ICoffeeTable coffeeTable = new VictorianCoffeeTable(legs: legs);
            return coffeeTable;
        }

        public ISofa CreateSofa(byte legs = 4, bool isReclinable = false, bool isSofaBed = false)
        {
            ISofa sofa = new VictorianSofa(legs: legs, isReclinable: isReclinable, isSofaBed: isSofaBed);
            return sofa;
        }
    }
}
