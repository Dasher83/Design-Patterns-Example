using Strategy;
using Strategy.Strategies.Sorting.Strings;
using Strategy.Utils;

Context context = new Context();

ConsoleColor color = RandomConsoleColorPicker.Pick;
ColorConsole.WriteLine("Client: Strategy is set to normal sorting", color);
context.SetStrategy(new StrategyAlphabetic());
context.DoSomeBusinessLogic();
Console.WriteLine();

ColorConsole.WriteLine("Client: Strategy is set to reverse sorting.", color);
context.SetStrategy(new StrategyAlphabeticReverse());
context.DoSomeBusinessLogic();
Console.WriteLine();