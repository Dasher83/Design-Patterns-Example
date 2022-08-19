using ChainOfResponsibility;
using ChainOfResponsibility.BusinessEntities;
using ChainOfResponsibility.Utils;


ConsoleColor color = RandomConsoleColorPicker.Pick;
var monkey = new MonkeyHandler();
var squirrel = new SquirrelHandler();
var dog = new DogHandler();
monkey.SetNext(squirrel).SetNext(dog);

ColorConsole.WriteLine("Chain: Monkey > Squirrel > Dog", color);
Console.WriteLine();
Client.ClientCode(monkey);
Console.WriteLine();
ColorConsole.WriteLine("Subchain: Squirrel > Dog", color);
Console.WriteLine();
Client.ClientCode(squirrel);
Console.WriteLine();
Console.WriteLine();
Console.ResetColor();