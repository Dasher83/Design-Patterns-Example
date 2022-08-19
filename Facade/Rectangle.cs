namespace Facade
{
    internal class Rectangle : Shape
    {
        public void Draw()
        {
            Console.ForegroundColor = RandomConsoleColorPicker.Pick;
            Console.WriteLine("Rectangle:Draw()");
            Console.WriteLine();
            Console.ResetColor();
        }
    }
}
