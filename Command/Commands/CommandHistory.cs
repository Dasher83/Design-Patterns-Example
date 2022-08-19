using Command.Interfaces;

namespace Command.Commands
{
    internal class CommandHistory: ICommandHistory
    {
        private readonly List<Command> _commands;

        public CommandHistory()
        {
            _commands = new List<Command>();
        }

        public List<Command> Commands { get { return _commands; } } 

        public void Push(Command command)
        {
            _commands.Add(command);
        }

        public Command? Pop()
        {
            if(_commands.Count > 0)
            {
                Command lastCommand = _commands.Last();
                _commands.RemoveAt(_commands.Count - 1);
                return lastCommand;
            }
            return null;
        }
    }
}
