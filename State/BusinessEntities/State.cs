using State.Utils;

namespace State.BusinessEntities
{
    internal abstract class State
    {
        private protected Context? _context;

        protected readonly ConsoleColor _color;
        public State()
        {
            _color = RandomConsoleColorPicker.Pick;
        }

        public Context Context { set { _context = value; } }
        public abstract void Handle1();
        public abstract void Handle2();
    }
}
