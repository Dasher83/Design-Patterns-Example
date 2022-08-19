using Mediator.BusinessEntities;
using Mediator.Utils;


ConsoleColor color = RandomConsoleColorPicker.Pick;
ConcreteComponent1 component1 = new ConcreteComponent1();
ConcreteComponent2 component2 = new ConcreteComponent2();
new ConcreteMediator(component1, component2);

ColorConsole.WriteLine("Client triggers operation A.", color);
component1.DoOperationA();

Console.WriteLine();

ColorConsole.WriteLine("Client triggers operation D.", color);
component2.DoOperationD();

Console.WriteLine();
Console.WriteLine();
Console.ResetColor();
