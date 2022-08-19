using Bridge.Interfaces;
using Bridge.Utils;

namespace Bridge.Models.Concrete
{
    internal class AdvancedRemoteControl : RemoteControl
    {
        private float _previousVolume;
        private readonly ConsoleColor _fontColor;
        public AdvancedRemoteControl(IRemoteControllableMediaDevice targetDevice) : base(targetDevice)
        {
            _fontColor = RandomConsoleColorPicker.Pick;
        }

        public void Mute()
        {
            ColorConsole.WriteLine($"AdvancedRemoteControl: muting target device", _fontColor);
            if (_targetDevice.Volume > 0)
            {
                _previousVolume = _targetDevice.Volume;
                _targetDevice.Volume = 0;
            }

        }

        public void Unmute()
        {
            string line = $"AdvancedRemoteControl: unmuting target device and restoring previous volume";
            ColorConsole.WriteLine(line, _fontColor);
            _targetDevice.Volume = _previousVolume;
        }
    }
}
