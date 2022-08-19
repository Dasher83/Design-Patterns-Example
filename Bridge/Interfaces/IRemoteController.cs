namespace Bridge.Interfaces
{
    internal interface IRemoteController
    {
        public void TogglePower();
        public void VolumeDown();
        public void VolumeUp();
        public void ChannelDown();
        public void ChannelUp();
    }
}
