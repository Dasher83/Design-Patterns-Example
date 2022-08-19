using Visitor.BusinessEntities;
using Visitor.Interfaces;
using Visitor.Utils;


ConsoleColor color = RandomConsoleColorPicker.Pick;
List<IComponent> components = new List<IComponent>
{
    new ConcreteComponentA(),
    new ConcreteComponentB()
};

ColorConsole.WriteLine("The client code works with all visitors via the base Visitor interface:", color);
ConcreteVisitor1 visitor1 = new ConcreteVisitor1();
Client.ClientCode(components, visitor1);
Console.WriteLine();

ColorConsole.WriteLine("It allows the same client code to work with different types of visitors:", color);
ConcreteVisitor2 visitor2 = new ConcreteVisitor2();
Client.ClientCode(components, visitor2);
Console.WriteLine();
Console.WriteLine();
Console.ResetColor();
