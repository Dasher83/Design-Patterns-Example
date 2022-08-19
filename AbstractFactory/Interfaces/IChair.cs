namespace AbstractFactory.Interfaces
{
    internal interface IChair
    {
        public byte Legs { get; }

        public bool IsReclinable { get; }

        public void SitOn();
    }
}
