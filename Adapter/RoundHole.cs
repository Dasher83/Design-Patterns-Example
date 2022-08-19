namespace Adapter
{
    internal class RoundHole
    {
        private readonly double _radius; 

        public RoundHole(double radius)
        {
            _radius = radius;
        }

        public double Radius { get { return _radius; } }

        public bool Fits(IRoundPeg peg)
        {
            return _radius >= peg.Radius;
        }
    }
}
