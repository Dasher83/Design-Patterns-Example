namespace Adapter
{
    internal class SquarePeg
    {
        private readonly double _width;
        public SquarePeg(double width)
        {
            _width = width;
        }

        public double Width { get { return _width; } }
    }
}
