namespace Decorator
{
    internal class Enemy : IEnemy
    {
        private double _health;
        private readonly double _defense;
        private readonly string _name;

        private static uint _instances = 0;

        public Enemy(double health, double defense, string? name = null)
        {
            _health = health;
            _defense = defense;
            if (name == null)
            {
                _name = $"Enemy #{_instances}";
            } else
            {
                _name = name;
            }
            _instances++;
        }

        private bool IsDead => _health <= 0 ;
        public string Name => _name;

        public double ComputeDamage(double receivedAttack)
        {
            double remainingAttack = receivedAttack - _defense;

            if (remainingAttack <= 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"{_name}: I was attacked but defended myself barehanded and received no damage!");
            } else {
                _health -= remainingAttack;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{_name}: I was attacked and got hurt! Took {remainingAttack} points of damage");

                if (IsDead)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"({_name} has fallen...)");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"{_name}: I survived with {_health} health points!");
                }
            }
            
            Console.WriteLine();
            return remainingAttack;
        }
    }
}
