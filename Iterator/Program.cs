using Iterator.BusinessEntities;
using Iterator.Utils;


ConsoleColor color = RandomConsoleColorPicker.Pick;
WordsCollection collection = new WordsCollection();
collection.AddItem("First");
collection.AddItem("Second");
collection.AddItem("Third");

ColorConsole.WriteLine("Straight traversal:", color);

foreach(var element in collection)
{
    ColorConsole.WriteLine(element.ToString(), color);
}

Console.WriteLine();
color = RandomConsoleColorPicker.Pick;
ColorConsole.WriteLine("Reverse traversal:", color);
collection.ReverseDirection();

foreach(var element in collection)
{
    ColorConsole.WriteLine(element.ToString(), color);
}

Console.WriteLine();
Console.WriteLine();
Console.ResetColor();
