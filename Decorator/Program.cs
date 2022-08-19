using Decorator;


IEnemy enemy;
Console.WriteLine("---------------------------------------------------------------------------");

enemy = new Enemy(health: 100, defense: 10);
enemy = new EnemyArmorPieceDecorator(defense: 20, decoratedEnemy: enemy);
enemy = new EnemyMagicArmorPieceDecorator(uses: 1, reduction: 50, decoratedEnemy: enemy);
enemy = new EnemyArmorPieceDecorator(defense: 20, decoratedEnemy: enemy);
enemy.ComputeDamage(80);
enemy.ComputeDamage(100);
enemy.ComputeDamage(260);
Console.WriteLine("---------------------------------------------------------------------------");

enemy = new Enemy(health: 100, defense: 10);
enemy = new EnemyArmorPieceDecorator(defense: 20, decoratedEnemy: enemy);
enemy = new EnemyArmorPieceDecorator(defense: 20, decoratedEnemy: enemy);
enemy = new EnemyMagicArmorPieceDecorator(uses: 1, reduction: 50, decoratedEnemy: enemy);
enemy.ComputeDamage(80);
enemy.ComputeDamage(100);
enemy.ComputeDamage(260);
Console.WriteLine("---------------------------------------------------------------------------");
Console.WriteLine();
Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine("As you may have noticed if you look at the source code, both enemies recieved the same set of attacks.");
Console.WriteLine("Furthermore, both enemies where equiped with the same armor set. However the result was different.");
Console.WriteLine("This is a decent example of how the order in wich the decorators are stacked is relevant");
Console.WriteLine();
Console.ResetColor();
