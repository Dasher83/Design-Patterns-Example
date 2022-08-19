namespace AbstractFactory.Interfaces
{
    internal interface IFurnitureFactory
    {
        public IChair CreateChair(byte legs = 4, bool isReclinable = false);

        public ICoffeeTable CreateCoffeeTable(byte legs = 4);

        public ISofa CreateSofa(byte legs = 4, bool isReclinable = false, bool isSofaBed = false);
    }
}
