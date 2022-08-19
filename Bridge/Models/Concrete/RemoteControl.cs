using Bridge.Interfaces;
using Bridge.Models.Abstract;

namespace Bridge.Models.Concrete
{
    internal class RemoteControl : AbstractRemoteControl
    {

        public RemoteControl(IRemoteControllableMediaDevice targetDevice) : base(targetDevice) { }

        public override void TogglePower()
        {
            if (_targetDevice.Enabled)
            {
                _targetDevice.Disable();
            }
            else
            {
                _targetDevice.Enable();
            }
        }

        public override void VolumeDown()
        {
            float newValue = _targetDevice.Volume - 1;
            _targetDevice.Volume = newValue;
        }

        public override void VolumeUp()
        {
            float newValue = _targetDevice.Volume + 1;
            _targetDevice.Volume = newValue;
        }

        public override void ChannelDown()
        {
            _targetDevice.Channel = _targetDevice.Channel - 1;
        }

        public override void ChannelUp()
        {
            _targetDevice.Channel = _targetDevice.Channel + 1;
        }
    }
}
