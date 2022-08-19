using Memento.Interfaces;
using Memento.Utils;


namespace Memento.BusinessEntities
{
    internal class Caretaker
    {
        private List<IMemento> _mementos;
        private Originator _originator;
        private ConsoleColor _color;

        public Caretaker(Originator originator)
        {
            _mementos = new List<IMemento>();
            _originator = originator;
            _color = RandomConsoleColorPicker.Pick;
        }

        public void Backup()
        {
            Console.WriteLine();
            ColorConsole.WriteLine($"Caretaker: Saving Originator's state ...", _color);
            _mementos.Add(_originator.Save());
        }

        public void Undo()
        {
            if(_mementos.Count == 0)
            {
                return;
            }

            IMemento memento = _mementos.Last();
            _mementos.Remove(memento);
            ColorConsole.WriteLine($"Caretaker: Restoring state to {memento.Name}", _color);

            try
            {
                _originator.Restore(memento);
            }
            catch (Exception)
            {
                Undo();
            }
        }

        public void ShowHistory()
        {
            ColorConsole.WriteLine("Caretaker: Here's the list of mementos", _color);
            
            foreach(IMemento memento in _mementos)
            {
                ColorConsole.WriteLine(memento.Name, _color);
            }
        }
    }
}
