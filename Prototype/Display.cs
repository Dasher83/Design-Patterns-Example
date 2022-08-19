namespace Prototype
{
    internal static class Display
    {
        public static void DisplayState(Person person)
        {
            Console.ForegroundColor = RandomConsoleColorPicker.Pick;
            Console.WriteLine($"ID#: {person.IdInfo.IdNumber:d}");
            Console.WriteLine($"Name: {person.Name}, Age: {person.Age}, BirthDate: {person.BirthDate:MM/dd/yyyy}");
            Console.WriteLine();
            Console.ResetColor();
        }
    }
}
