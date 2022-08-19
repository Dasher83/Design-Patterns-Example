using System.Xml.Linq;

namespace Decorator
{
    internal sealed class EnemyArmorPieceDecorator : EnemyDecorator
    {
        private readonly double _defense;

        public EnemyArmorPieceDecorator(double defense, IEnemy decoratedEnemy): base(decoratedEnemy)
        {
            _defense = defense;
        }

        public override string Name => $"{_decoratedEnemy.Name}'s regular armor piece";

        public override double ComputeDamage(double receivedAttack)
        {
            double remainingDamage = receivedAttack - _defense;

            if (remainingDamage - Double.Epsilon < 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"{_decoratedEnemy.Name}: I was attacked but my armor protected me!");
                Console.WriteLine();
                return 0;
            }
            else
            {
                return this._decoratedEnemy.ComputeDamage(remainingDamage);
            }
        }
    }
}
