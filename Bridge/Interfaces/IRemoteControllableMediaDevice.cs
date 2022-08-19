namespace Bridge.Interfaces
{
    internal interface IRemoteControllableMediaDevice : IRemoteControllable
    {
        public float Volume { get; set; }
        public double Channel { get; set; }
    }
}
