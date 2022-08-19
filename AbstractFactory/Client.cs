using AbstractFactory.Interfaces;

namespace AbstractFactory
{
    internal class Client
    {
        public void ClientMethod(IFurnitureFactory factory)
        {
            IChair chair = factory.CreateChair();
            ICoffeeTable coffeeTable = factory.CreateCoffeeTable();
            ISofa sofa = factory.CreateSofa();

            chair.SitOn();
            coffeeTable.Appreciate();
            sofa.SitOn();
        }
    }
}
