namespace Facade
{
    internal class ShapeMaker
    {
        private readonly Shape _circle;
        private readonly Shape _rectangle;
        private readonly Shape _square;

        public ShapeMaker()
        {
            _circle = new Circle();
            _rectangle = new Rectangle();
            _square = new Square();
        }

        public void DrawCircle()
        {
            _circle.Draw();
        }

        public void DrawRectangle()
        {
            _rectangle.Draw();
        }

        public void DrawSquare()
        {
            _square.Draw();
        }
    }
}
