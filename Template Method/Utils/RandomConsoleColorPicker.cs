namespace TemplateMethod.Utils
{
    internal class RandomConsoleColorPicker
    {
        public static ConsoleColor Pick
        {
            get
            {
                Random random = new Random();
                var consoleColors = Enum.GetValues(typeof(ConsoleColor));
#pragma warning disable CS8605 // Unboxing a possibly null value.
                ConsoleColor randomColor = (ConsoleColor)consoleColors.GetValue(random.Next(consoleColors.Length));
#pragma warning restore CS8605 // Unboxing a possibly null value.
                if (randomColor == ConsoleColor.Black) { return ConsoleColor.White; }
                return randomColor;
            }
        }

    }
}
