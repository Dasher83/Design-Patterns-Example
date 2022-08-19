using Memento.BusinessEntities;
using Memento.Utils;


ConsoleColor color = RandomConsoleColorPicker.Pick;
Originator originator = new Originator("Super-duper-super-puper-super.");
Caretaker caretaker = new Caretaker(originator);

caretaker.Backup();
originator.DoSomething();

caretaker.Backup();
originator.DoSomething();

caretaker.Backup();
originator.DoSomething();

Console.WriteLine();
caretaker.ShowHistory();

Console.WriteLine();
ColorConsole.WriteLine("Client: Now, let's rollback!", color);
Console.WriteLine();
caretaker.Undo();

Console.WriteLine();
ColorConsole.WriteLine("Client: Once more!", color);
Console.WriteLine();
caretaker.Undo();

Console.WriteLine();
Console.WriteLine();
Console.ResetColor();
