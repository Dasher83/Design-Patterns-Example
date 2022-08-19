using State.Utils;

namespace State.BusinessEntities
{
    internal class Context
    {
        private State? _state = null;
        private readonly ConsoleColor _color;

        public Context(State state)
        {
            _color = RandomConsoleColorPicker.Pick;
            this.TransitionTo(state);
        }

        public void TransitionTo(State state)
        {
            ColorConsole.WriteLine($"Context: Transition to {state.GetType().Name}.", _color);
            this._state = state;
            this._state.Context = this;
        }

        public void Request1()
        {
            this._state.Handle1();
        }

        public void Request2()
        {
            this._state.Handle2();
        }
    }
}
