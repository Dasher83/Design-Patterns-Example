namespace Bridge.Interfaces
{
    internal interface IRemoteControllable
    {
        public bool Enabled { get; }
        public void Enable();
        public void Disable();
    }
}
