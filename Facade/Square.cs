namespace Facade
{
    internal class Square : Shape
    {
        public void Draw()
        {
            Console.ForegroundColor = RandomConsoleColorPicker.Pick;
            Console.WriteLine("Square:Draw()");
            Console.WriteLine();
            Console.ResetColor();
        }
    }
}
