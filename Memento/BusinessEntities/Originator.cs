using Memento.Interfaces;
using Memento.Utils;


namespace Memento.BusinessEntities
{
    internal class Originator
    {
        private string _state;
        private ConsoleColor _color;

        public Originator(string state)
        {
            _state = state;
            _color = RandomConsoleColorPicker.Pick;
            ColorConsole.WriteLine($"Originator: My initial state is: {_state}", _color);
        }

        private string GenerateRandomString(int length = 10) 
        { 
            string allowedSymbols = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string result = String.Empty;

            while(length > 0)
            {
                result += allowedSymbols[new Random().Next(0, allowedSymbols.Length)];
                Thread.Sleep(12);
                length--;
            }

            return result;
        }

        public void DoSomething()
        {
            ColorConsole.WriteLine($"Originator: I'm doing something important ...", _color);
            _state = GenerateRandomString(30);
            ColorConsole.WriteLine($"Originator: and my state has changed to: {_state}", _color);
        }

        public IMemento Save()
        {
            return new ConcreteMemento(_state);
        }

        public void Restore(IMemento memento)
        {
            if(!(memento is ConcreteMemento))
            {
                throw new InvalidOperationException($"Unknown memento class {memento}");
            }

            _state = memento.State;
            ColorConsole.WriteLine($"Originator: My state has changed to: {_state}", _color);
        }
    }
}
