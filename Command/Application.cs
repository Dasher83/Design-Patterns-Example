using Command.Interfaces;
using Command.Views;

namespace Command
{
    internal class Application
    {
        private string _clipboard;
        private IEditor _editor;
        private ICommandHistory _commandHistory;
        private ICommandExecuter? _commandExecuter;

        public Application(ICommandHistory commandHistory)
        {
            _clipboard = "";
            _editor = new Editor();
            _commandHistory = commandHistory;
        }

        public IEditor Editor { get { return _editor; } }

        public string Clipboard { get { return _clipboard; } set { _clipboard = value; } }

        public ICommandHistory CommandHistory { get { return _commandHistory; } }

        public ICommandExecuter CommandExecuter { set { _commandExecuter = value; } }

        public void Undo()
        {
            Commands.Command? command = _commandHistory.Pop();
            if(command != null)
            {
                command.Undo();
            }
        }

        public void Run()
        {
            bool exit = false;
            MenuView menuView;
            do
            {
                menuView = new MenuView(_editor, this.Clipboard);
                menuView.ShowPrompt();
                menuView.LoadData();

                if(menuView.SelectedAction == Constants.ExitOption)
                {
                    exit = true;
                }
                else
                {
                    try
                    {
                        if (_commandExecuter == null)
                        {
                            throw new InvalidOperationException("No command executer set on application...");
                        }
                        _commandExecuter.Execute(action: menuView.SelectedAction);
                    }
                    catch (Exception ex)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        if ( ex is InvalidOperationException || ex is ArgumentOutOfRangeException || ex is NotImplementedException)
                        {
                            Console.WriteLine(ex.Message);
                            Console.WriteLine();
                            Console.ResetColor();
                            Console.WriteLine("Press any key to continue...");
                            Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine();
                            throw;
                        }
                    }
                }
            } while (!exit);
            Console.WriteLine();
            Console.ResetColor();
        }
    }
}
