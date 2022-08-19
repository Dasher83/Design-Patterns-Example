using Bridge.Interfaces;

namespace Bridge.Models.Abstract
{
    internal abstract class RemoteControllableMediaDevice : IRemoteControllableMediaDevice
    {
        protected bool _enabled;
        protected float _volume;
        protected double _channel;

        public RemoteControllableMediaDevice()
        {
            _enabled = false;
            _volume = 0;
            _channel = 0;
        }

        public virtual bool Enabled { get { return _enabled; } }
        public virtual void Enable() 
        {
            if (!_enabled)
            {
                _enabled = true;
            }
        }
        public virtual void Disable()
        {
            if (_enabled)
            {
                _enabled = false;
            }
        }
        public virtual float Volume {
            get {
                return _volume; 
            } 
            set { 
                if(value - float.Epsilon <= 0)
                {
                    _volume = 0;
                    return;
                } else if (value + float.Epsilon >= 100)
                {
                    _volume = 100;
                    return;
                }
                _volume = value;
            } 
        }
        public abstract double Channel { get; set; }
    }
}
