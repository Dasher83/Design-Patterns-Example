using Command.Interfaces;

namespace Command.Commands
{
    internal class CommandExecuter : ICommandExecuter
    {
        private readonly Application _app;
        public CommandExecuter(Application app)
        {
            _app = app;
        }

        public void Execute(uint action)
        {
            Command command;
            switch (action)
            {
                case 1:
                    // 1- Append new text
                    command = new CommandAppendNew(_app);
                    break;
                case 2:
                    // 2- Prepend new text
                    command = new CommandPrependNew(_app);
                    break;
                case 3:
                    // 3- Select text by array positions
                    command = new CommandSelect(_app);
                    break;
                case 4:
                    // 4- Copy Selected text at selected positions
                    command = new CommandCopy(_app);
                    break;
                case 5:
                    // 5- Cut Selected text at selected positions
                    command = new CommandCut(_app);
                    break;
                case 6:
                    // 6- Append Pasted text
                    command = new CommandAppendPasted(_app);
                    break;
                case 7:
                    // 7- Prepend Pasted text
                    command = new CommandPrependPasted(_app);
                    break;
                case 8:
                    // 8- Replace selection by pasted text
                    command = new CommandReplace(_app);
                    break;
                case 9:
                    // 9- Undo previous action
                    command = new CommandUndo(_app);
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(action));
            }

            if (command.Execute())
            {
                _app.CommandHistory.Push(command);
            }
        }
    }
}
