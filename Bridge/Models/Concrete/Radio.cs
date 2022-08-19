using Bridge.Models.Abstract;
using Bridge.Utils;

namespace Bridge.Models.Concrete
{
    internal class Radio : RemoteControllableMediaDevice
    {
        static public readonly double FrequencyMinimum = 20 * Math.Pow(10, 3);
        static public readonly double FrequencyMaximum = 300 * Math.Pow(10, 9);
        private readonly ConsoleColor _fontColor;

        public Radio()
        {
            _fontColor = RandomConsoleColorPicker.Pick;
        }
        public override bool Enabled
        {
            get
            {
                string status = _enabled ? "enabled" : "disabled";
                ColorConsole.WriteLine($"Radio: status: {status}", _fontColor);
                return base.Enabled;
            }
        }
        public override void Enable()
        {
            base.Enable();
            ColorConsole.WriteLine($"Radio: current status: enabled", _fontColor);
        }
        public override void Disable()
        {
            base.Disable();
            ColorConsole.WriteLine($"Radio: setting status to: disabled", _fontColor);
        }
        public override float Volume
        {
            get
            {
                ColorConsole.WriteLine($"Radio: current volume: {base.Volume}", _fontColor);
                return base.Volume;
            }
            set
            {
                ColorConsole.WriteLine($"Radio: setting volume to: {value}", _fontColor);
                base.Volume = value;
            }
        }

        public override double Channel
        {
            get
            {
                ColorConsole.WriteLine($"Radio: current channel: {_channel}", _fontColor);
                return _channel;
            }
            set
            {

                if (value >= FrequencyMinimum && value <= FrequencyMaximum)
                {
                    _channel = value;
                    ColorConsole.WriteLine($"Radio: setting channel to: {value}", _fontColor);
                }
            }
        }
    }
}
