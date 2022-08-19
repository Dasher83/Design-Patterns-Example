namespace Flyweight.Models
{
    internal class CarDistinctions
    {
        private string _owner;
        private string _number;

        public CarDistinctions(string owner, string number)
        {
            _owner = owner;
            _number = number;
        }

        public string Owner { get { return _owner; } }
        public string Number { get { return _number; } }
    }
}
