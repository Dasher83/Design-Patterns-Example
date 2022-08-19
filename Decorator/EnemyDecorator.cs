namespace Decorator
{
    internal abstract class EnemyDecorator : IEnemy
    {
        protected readonly IEnemy _decoratedEnemy;

        public EnemyDecorator(IEnemy decoratedEnemy)
        {
            _decoratedEnemy = decoratedEnemy;
        }

        public abstract double ComputeDamage(double receivedAttack);
        public abstract string Name { get; }
    }
}
