using CompositePattern.Interfaces;

namespace CompositePattern.Models
{
    internal class Composite : IComponent
    {
        private readonly string _name;
        private readonly List<IComponent> _components;

        public Composite(string name)
        {
            _name = name;
            _components = new List<IComponent>();
        }

        public void AddComponent(IComponent component)
        {
            _components.Add(component);
        }

        public double Price { 
            get
            {
                double price = 0;
                foreach(IComponent component in _components)
                {
                    price += component.Price;
                }
                return price;
            } 
        }
    }
}
