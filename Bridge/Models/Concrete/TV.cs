using Bridge.Models.Abstract;
using Bridge.Utils;

namespace Bridge.Models.Concrete
{
    internal class TV : RemoteControllableMediaDevice
    {
        private readonly uint _channels;
        private readonly ConsoleColor _fontColor;

        public TV(uint channels)
        {
            _channels = channels;
            _fontColor = RandomConsoleColorPicker.Pick;
        }

        public override bool Enabled { 
            get {
                string status = _enabled ? "enabled" : "disabled";  
                ColorConsole.WriteLine($"TV: status: {status}", _fontColor);
                return base.Enabled; 
            } 
        }
        public override void Enable()
        {
            base.Enable();
            ColorConsole.WriteLine($"TV: current status: enabled", _fontColor);
        }
        public override void Disable()
        {
            base.Disable();
            ColorConsole.WriteLine($"TV: setting status to: disabled", _fontColor);
        }
        public override float Volume
        {
            get
            {
                ColorConsole.WriteLine($"TV: current volume: {base.Volume}", _fontColor);
                return base.Volume;
            }
            set
            {
                base.Volume = value;
                ColorConsole.WriteLine($"TV: setting volume to: {base.Volume}", _fontColor);
            }
        }

        public override double Channel { 
            get
            {
                ColorConsole.WriteLine($"TV: current channel: {(uint)Math.Floor(_channel)}", _fontColor);
                return _channel;
            }
            set
            {
                uint channel;
                if(value < 0)
                {
                    channel = (uint)Math.Floor(value * -1);
                } 
                else
                {
                    channel = (uint)Math.Floor(value);
                }

                if(channel > _channels)
                {
                    _channel = (float)channel;
                    ColorConsole.WriteLine($"TV: setting channel to: {channel}", _fontColor);
                }
            }
        }
    }
}
