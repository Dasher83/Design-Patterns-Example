namespace TemplateMethod.Utils
{
    internal static class ColorConsole
    {
        public static void WriteLine(string line, ConsoleColor? color = null)
        {
            if (color == null)
            {
                color = RandomConsoleColorPicker.Pick;
            }
            Console.ForegroundColor = (ConsoleColor)color;
            Console.WriteLine(line);
            Console.WriteLine();
            Console.ResetColor();
        }
    }
}
