using Memento.Interfaces;
using System.Reflection.Metadata.Ecma335;

namespace Memento.BusinessEntities
{
    internal class ConcreteMemento : IMemento
    {
        private string _state;
        private DateTime _date;

        public ConcreteMemento(string state)
        {
            _state = state;
            _date = DateTime.Now;
        }

        public string Name => $"{_date} / ({_state.Substring(0, 9)}) ...";

        public string State => _state;

        public DateTime Date => _date;
    }
}
