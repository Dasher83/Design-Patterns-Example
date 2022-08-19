namespace Flyweight.Interfaces
{
    internal interface IKeySeedableGenerator
    {
        public string GenerateKey(object seed);
    }
}
