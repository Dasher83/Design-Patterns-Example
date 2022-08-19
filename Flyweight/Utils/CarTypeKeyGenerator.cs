using Flyweight.DTOs;
using Flyweight.Interfaces;

namespace Flyweight.Utils
{
    internal class CarTypeKeyGenerator : IKeySeedableGenerator
    {
        public string GenerateKey(object seed)
        {
            CarTypeDTO carType = (CarTypeDTO)seed;
            List<string> elements = new List<string>();
            elements.Add(carType.model);
            elements.Add(carType.color);
            elements.Add(carType.company);
            elements.Sort();
            return string.Join("_", elements);
        }
    }
}
