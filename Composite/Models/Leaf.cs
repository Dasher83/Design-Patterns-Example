using CompositePattern.Interfaces;

namespace CompositePattern.Models
{
    internal class Leaf : IComponent
    {
        private string _name;
        private double _price;

        public Leaf(string name, double price)
        {
            _name = name;
            _price = price;
        }

        public double Price => _price;
    }
}
