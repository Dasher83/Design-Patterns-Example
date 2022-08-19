using Bridge.Interfaces;

namespace Bridge.Models.Abstract
{
    internal abstract class AbstractRemoteControl : IRemoteController
    {
        protected IRemoteControllableMediaDevice _targetDevice;

        public AbstractRemoteControl(IRemoteControllableMediaDevice targetDevice)
        {
            _targetDevice = targetDevice;
        }

        abstract public void TogglePower();
        abstract public void VolumeDown();
        abstract public void VolumeUp();
        abstract public void ChannelDown();
        abstract public void ChannelUp();
    }
}
