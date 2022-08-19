using System.Xml.Linq;

namespace Decorator
{
    internal interface IEnemy
    {
        public double ComputeDamage(double receivedAttack);
        public string Name { get; }
    }
}
