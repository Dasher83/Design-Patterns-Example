namespace Decorator
{
    internal sealed class EnemyMagicArmorPieceDecorator : EnemyDecorator
    {
        private uint _uses;
        private double _reduction;

        public EnemyMagicArmorPieceDecorator(uint uses, double reduction, IEnemy decoratedEnemy): base(decoratedEnemy)
        {
            _uses = uses;
            _reduction = reduction < 0 ? (reduction * -1) : reduction;
        }

        public override string Name => $"{_decoratedEnemy.Name}'s magical armor piece";

        private double Reduction { 
            get {
                if (_reduction - Double.Epsilon < 0 || _reduction + Double.Epsilon > 100)
                {
                    return 1;
                }
                return Math.Round(_reduction / 100, 2); 
            } 
        }

        public override double ComputeDamage(double receivedAttack)
        {
            if (_uses > 0)
            {
                double remainingDamage = receivedAttack * Reduction;
                if (remainingDamage - Double.Epsilon < 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"{_decoratedEnemy.Name}: I was attacked but my magic armor protected me!");
                    Console.WriteLine();
                    return 0;
                }
                else
                {
                    return this._decoratedEnemy.ComputeDamage(remainingDamage);
                }
            }
            return this._decoratedEnemy.ComputeDamage(receivedAttack);
        }
    }
}
