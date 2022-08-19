namespace Facade
{
    internal class Circle : Shape
    {
        public void Draw()
        {
            Console.ForegroundColor = RandomConsoleColorPicker.Pick;
            Console.WriteLine("Circle:Draw()");
            Console.WriteLine();
            Console.ResetColor();
        }
    }
}
