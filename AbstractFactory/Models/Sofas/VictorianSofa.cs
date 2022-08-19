using AbstractFactory.Interfaces;

namespace AbstractFactory.Models.Sofas
{
    internal class VictorianSofa : ISofa
    {
        private readonly byte _legs;
        private readonly bool _isReclinable;
        private readonly bool _isSofaBed;

        public VictorianSofa(byte legs, bool isReclinable, bool isSofaBed)
        {
            _legs = legs;
            _isReclinable = isReclinable;
            _isSofaBed = isSofaBed;
        }

        public byte Legs => _legs;

        public bool IsReclinable => _isReclinable;

        public bool IsSofaBed => _isSofaBed;

        public void SitOn()
        {
            string reclinable = _isReclinable ? "reclinable " : "";
            string legs = _legs > 0 ? $"{_legs} " : "no ";
            Console.WriteLine($"I'm sitting on a {reclinable}Victorian style Sofa with {legs}legs!");
            if (_isSofaBed)
            {
                Console.WriteLine($"And look ... It turns into a bed!");
            }
            Console.WriteLine();
        }
    }
}
