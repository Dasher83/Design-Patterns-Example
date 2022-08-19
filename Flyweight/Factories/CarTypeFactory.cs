using Flyweight.DTOs;
using Flyweight.Interfaces;
using Flyweight.Models;
using Flyweight.Utils;

namespace Flyweight.Factories
{
    internal class CarTypeFactory
    {
        private Dictionary<string, CarType> _carTypes;
        private IKeySeedableGenerator _keyGenerator;

        public CarTypeFactory(IKeySeedableGenerator keyGenerator, params CarType[] carTypes)
        {
            _keyGenerator = keyGenerator;
            _carTypes = new Dictionary<string, CarType>();
            foreach (CarType carType in carTypes)
            {
                _carTypes.Add(_keyGenerator.GenerateKey(carType.GetDTO()), carType);
            }
        }

        public CarType GetCarType(CarTypeDTO carTypeDTO, string? customKey = null)
        {
            string key;
            if (customKey != null)
            {
                key = customKey;
            }
            else
            {
                key = _keyGenerator.GenerateKey(carTypeDTO);
            }

            Console.ForegroundColor = RandomConsoleColorPicker.Pick;
            if (_carTypes.ContainsKey(key))
            {
                Console.WriteLine("CarTypeFactory: Reusing existing Flyweight CarType");
            }
            else
            {
                Console.WriteLine("CarTypeFactory: Can't find a Flyweight CarType, creating a new one.");
                _carTypes.Add(key, new CarType(carTypeDTO: carTypeDTO));
            }
            Console.ResetColor();
            Console.WriteLine();
            return _carTypes[key];
        }

        public void ListCarTypeFlyweights()
        {
            var count = _carTypes.Count;
            Console.ForegroundColor = RandomConsoleColorPicker.Pick;
            Console.WriteLine($"CarTypeFactory: I have {count} car type flyweights");
            foreach (CarType carType in _carTypes.Values)
            {
                Console.WriteLine(carType);
            }
            Console.ResetColor();
            Console.WriteLine();
        }
    }
}
