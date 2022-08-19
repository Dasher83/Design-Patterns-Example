using Command.Interfaces;
using Command.Shared.Utils;

namespace Command.Views
{
    internal class MenuView
    {
        private IEditor _editor;
        private uint _selectedAction;
        private readonly string _clipboard;

        public MenuView(IEditor editor, string clipboard)
        {
            _editor = editor;
            _selectedAction = 0;
            _clipboard = clipboard;
        }

        public uint SelectedAction { get { return _selectedAction; } }

        public void ShowPrompt()
        {
            Console.Clear();
            new MainTextView(_editor, _clipboard).Show();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Select an operation to perform:");
            Console.WriteLine("1- Append new text");
            Console.WriteLine("2- Prepend new text");
            Console.WriteLine("3- Select text by array positions");
            Console.WriteLine("4- Copy Selected text");
            Console.WriteLine("5- Cut Selected text at selected positions");
            Console.WriteLine("6- Append Pasted text");
            Console.WriteLine("7- Prepend Pasted text");
            Console.WriteLine("8- Replace selection by pasted text");
            Console.WriteLine("9- Undo previous action");
            Console.WriteLine("10- Exit");
            Console.WriteLine();
        }

        public void LoadData()
        {
            _selectedAction = (uint)UserInputTaker.TakeIntInput(min: 1, max: (int)Constants.ExitOption);
        }
    }
}
