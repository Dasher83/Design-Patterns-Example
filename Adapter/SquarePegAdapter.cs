namespace Adapter
{
    internal class SquarePegAdapter : IRoundPeg
    {
        private readonly SquarePeg peg;

        public SquarePegAdapter(SquarePeg peg)
        {
            this.peg = peg;
        }

        public double Radius => peg.Width * Math.Sqrt(2) / 2;
    }
}
