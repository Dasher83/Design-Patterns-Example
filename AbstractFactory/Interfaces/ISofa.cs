namespace AbstractFactory.Interfaces
{
    internal interface ISofa
    {
        public byte Legs { get; }

        public bool IsReclinable { get; }

        public bool IsSofaBed { get; }

        public void SitOn();
    }
}
