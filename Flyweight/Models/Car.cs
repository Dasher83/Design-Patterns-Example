using System.Text.Json;
using Flyweight.Utils;

namespace Flyweight.Models
{
    internal class Car
    {
        private readonly CarType _carType;
        private CarDistinctions _carDistinctions;

        public Car(CarType carType, CarDistinctions carDistinctions)
        {
            _carType = carType;
            _carDistinctions = carDistinctions;
        }

        public CarType CarType { get { return _carType; } }

        public void PrintInfo()
        {
            Console.ForegroundColor = RandomConsoleColorPicker.Pick;
            string sharedState = JsonSerializer.Serialize(_carType);
            string uniqueState = JsonSerializer.Serialize(new
            {
                _carDistinctions.Owner,
                _carDistinctions.Number
            });
            Console.WriteLine($"Car: Displaying shared state {sharedState} and unique state{uniqueState}");
            Console.WriteLine();
            Console.ResetColor();
        }
    }
}
