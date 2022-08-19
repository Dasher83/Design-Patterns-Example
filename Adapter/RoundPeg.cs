namespace Adapter
{
    internal class RoundPeg: IRoundPeg
    {
        private readonly double _radius;
        public RoundPeg(double radius)
        {
            _radius = radius;
        }

        public double Radius { get { return _radius; } }
    }
}
