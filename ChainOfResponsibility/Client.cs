using ChainOfResponsibility.BusinessEntities;
using ChainOfResponsibility.Utils;


namespace ChainOfResponsibility
{
    internal class Client
    {
        public static void ClientCode(AbstractHandler handler)
        {
            ConsoleColor color = RandomConsoleColorPicker.Pick;
            foreach(string food in new List<string> { "Nut", "Banana", "Cup of coffee" })
            {
                ColorConsole.WriteLine($"Client: Who wants a {food} ?", color);
                var result = handler.Handle(food);
                if(result != null)
                {
                    ColorConsole.WriteLine($"    {result}", color);
                }
                else
                {
                    ColorConsole.WriteLine($"    {food} was left untouched.", color);
                }
            }
        }
    }
}
